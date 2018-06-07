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
using Sismio.io.sismio.stazione;
using Sismio.io.sismio.ui;

namespace Sismio
{
    public partial class RegistraStazioneForm : MaterialForm
    {
        public RegistraStazioneForm(IGestioneStazioniController gestioneStazioniController)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SismioColor.Scheme;

            this.registraStazione1.Controller = gestioneStazioniController;
        }

        private void RegistraStazioneForm_Load(object sender, EventArgs e)
        {

        }
    }
}
