using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Sismio.io.sismio.ui;
using Sismio.io.sismio.utente;

namespace Sismio
{
    public partial class RegistraUtenteForm : MaterialForm
    {
        public RegistraUtenteForm(IGestioneUtentiController gestioneUtentiController)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SismioColor.Scheme;

            this.registraUtente1.Controller = gestioneUtentiController;
        }

        private void RegistraUtenteForm_Load(object sender, EventArgs e)
        {
        }
    }
}
