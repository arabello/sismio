using MaterialSkin;
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

        public Login(AutenticazioneController controller, IGestioneUtentiController gestioneUtentiController, IGestioneStazioniController stazioniController, IStoricoController storicoController, SorgenteFactory factory)
        {
            InitializeComponent();
            _controller = controller;
            _gestioneUtentiController = gestioneUtentiController;
            _stazioniController = stazioniController;
            _storicoController = storicoController;
            _factory = factory;

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
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (_controller.Autentica(this.textUsername.Text, this.textPassword.Text) || true)  // TODO: levare true
            {
                this.Hide();
                Form mainForm = new MainForm(_gestioneUtentiController, _stazioniController,_storicoController, _factory);
                DialogResult res = mainForm.ShowDialog();               
                if (res.Equals(DialogResult.Abort))
                    this.Close();
               else
                    this.Show();
            }
            else
            {
                MessageBox.Show("Coppia utente e password non corretta. Impossibile accedere.", "Credenziali non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void background_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
