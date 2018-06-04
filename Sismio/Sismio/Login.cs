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

namespace Sismio
{
    public partial class Login : MaterialForm
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font robotoMono;
        Form mainForm;

        public Login()
        {
            InitializeComponent();

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

            mainForm = new MainForm();
        }

        private bool verificaCredenziali(string user, string password)
        {
            // TODO: Correctly implement
            return true;
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (verificaCredenziali(this.textUsername.Text, this.textPassword.Text))
            {
                this.Hide();
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
    }
}
