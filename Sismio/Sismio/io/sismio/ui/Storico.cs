using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MaterialSkin;

namespace Sismio.io.sismio.ui
{
    public partial class Storico : UserControl
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
         IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font robotoMonoBold16;
        Font robotMonoLight10;
        public Storico()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SismioColor.Scheme;

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

            robotoMonoBold16 = new Font(fonts.Families[0], 16.0f);

            fontData = Properties.Resources.RobotoMono_Light;
            fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.RobotoMono_Light.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.RobotoMono_Light.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            robotMonoLight10 = new Font(fonts.Families[0], 10.0f);

            this.title.Font = robotoMonoBold16;
            this.textCerca.Font = robotMonoLight10;
            this.label1.Font = robotMonoLight10;
            this.label2.Font = robotMonoLight10;
            this.label3.Font = robotMonoLight10;
            this.textFiltro.Font = robotMonoLight10;

            this.BackColor = SismioColor.BackColor;

            /**
             * Set up buttom controls
             */
            this.textCerca.BackColor = SismioColor.Scheme.DarkPrimaryColor;
            this.textCerca.GotFocus += onTextCercaFocus;
            this.textCerca.LostFocus += onTextCercaBlur;
            this.textCerca.ForeColor = Color.White;
            this.bgTextCerca.BackColor = SismioColor.Scheme.DarkPrimaryColor;

            /**
             * Set up ListView
             **/
            seedListView();
            this.listView.MultiSelect = false;

            /**
             * Set up filtro
             **/
            this.panelFiltro.BackColor = SismioColor.Scheme.DarkPrimaryColor;
        }

        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"Lollipop", "392", "0.2", "Messagio informativo", "INFO"},
                new []{"KitKat", "518", "26.0", "Messagio informativo", "ALERT"},
                new []{"Ice cream sandwich", "237", "9.0", "Messagio informativo", "WARNING"},
                new []{"Jelly Bean", "375", "0.0", "Messagio informativo", "CRTITICAL"},
                new []{"Honeycomb", "408", "3.2", "Messagio informativo", "INFO"}
            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                item.BackColor = Color.AliceBlue;
                this.listView.Items.Add(item);
            }
        }

        private void onTextCercaBlur(object sender, EventArgs e)
        {
            this.textCerca.Text = "Cerca qui";
        }

        private void onTextCercaFocus(object sender, EventArgs e)
        {
            this.textCerca.Text = "";
        }
    }
}
