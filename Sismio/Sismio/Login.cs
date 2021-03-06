﻿using MaterialSkin;
using MaterialSkin.Controls;
using Sismio.io.sismio.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sismio.io.sismio.eventi;
using Sismio.io.sismio.sorgente;
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.trasmissione;
using Sismio.io.sismio.user;
using Sismio.io.sismio.utente;

namespace Sismio
{
    public partial class Login : MaterialForm
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font robotoMono;
        private readonly AutenticazioneController _controller;
        private readonly IGestioneUtentiController _gestioneUtentiController;
        private readonly IGestioneStazioniController _stazioniController;
        private readonly IStoricoController _storicoController;
        private readonly SorgenteFactory _factory;
        private readonly GestoreEventi _gestoreEventi;

        public Login(AutenticazioneController controller, IGestioneUtentiController gestioneUtentiController,
            IGestioneStazioniController stazioniController, IStoricoController storicoController,
            SorgenteFactory factory, GestoreEventi gestoreEventi)
        {
            InitializeComponent();
            _controller = controller;
            _gestioneUtentiController = gestioneUtentiController;
            _stazioniController = stazioniController;
            _storicoController = storicoController;
            _factory = factory;
            _gestoreEventi = gestoreEventi;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SismioColor.Scheme;
            this.background.BackColor = SismioColor.Scheme.DarkPrimaryColor;
            //
            // Load Font
            // 
            byte[] fontData = Properties.Resources.RobotoMono_Bold;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.RobotoMono_Bold.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.RobotoMono_Bold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            robotoMono = new Font(fonts.Families[0], 14.0F);

            this.textUsername.Font = robotoMono;
            this.title.Font = new Font(fonts.Families[0], 56.0F);

            // Focus at the startup
            this.ActiveControl = this.textUsername;

            // Precompilo il form
            this.textUsername.Text = "admin";
            this.textPassword.Text = "admin";

            // Carico la combo box
            CaricaSorgenti();
        }

        private void CaricaSorgenti()
        {
            this.comboBoxSorgente.Items.Clear();
            this.comboBoxSorgente.Items.Add("Locale");
            foreach (var stazione in _stazioniController.ListaTutti())
            {
                this.comboBoxSorgente.Items.Add(stazione.Nome);
            }

            this.comboBoxSorgente.SelectedIndex = 0;
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            string nomeSorgente = (string) comboBoxSorgente.SelectedItem;
            ISorgente sorgente = null;

            if (nomeSorgente == "Locale")
            {
                if (_controller.Autentica(this.textUsername.Text, this.textPassword.Text))
                {
                    sorgente = _factory.NuovaSorgenteLocale();
                }
                else
                {
                    MessageBox.Show("Coppia utente e password non corretta. Impossibile accedere.", "Credenziali non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                IStazione stazione = _stazioniController.Cerca(nomeSorgente)[0];
                try
                {
                    sorgente = _factory.NuovaSorgenteRemota(stazione, this.textUsername.Text, this.textPassword.Text);
                }
                catch (CredenzialiInvalideEccezione e1)
                {
                    MessageBox.Show("Coppia utente e password non corretta. Il server ha rifiutato la connessione.", "Credenziali non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NonFidatoEccezione e2)
                {
                    MessageBox.Show("Il certificato della stazione remota non è valido.", "Errore certificato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (RispostaInvalidaEccezione e3)
                {
                    MessageBox.Show("Il server non ha restituito una risposta valida", "Risposta invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }


            if (sorgente != null)
            {
                this.Hide();
                Form mainForm = new MainForm(_gestioneUtentiController, _stazioniController, _storicoController, sorgente, _gestoreEventi, _controller);
                DialogResult res = mainForm.ShowDialog();
                CaricaSorgenti();
                this.Show();
            }
        }

        private void background_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
