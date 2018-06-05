﻿using System;
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
using Sismio.io.sismio.eventi;

namespace Sismio.io.sismio.ui
{
    public partial class Storico : UserControl
    {
        public IStoricoController StoricoController { get; set; }

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
            
            this.listView.MultiSelect = false;

            /**
             * Set up filtro
             **/
            this.panelFiltro.BackColor = SismioColor.Scheme.DarkPrimaryColor;
        }

        private void seedListView(IList<IFiltroEvento> filtri)
        {
            this.listView.Items.Clear();

            //Define
            IList<IEventoSismico> eventi = StoricoController.ListaEventi(filtri);

            //Add
            foreach (IEventoSismico evento in eventi)
            {
                DateTime date = UnixTimeStampToDateTime(evento.Timestamp);
                var version = new string[]
                {
                    date.Date.ToString(), evento.Tag, evento.Stazione.Nome, evento.Messaggio, evento.Priorita.ToString()
                };
                var item = new ListViewItem(version);
                item.BackColor = Color.AliceBlue;
                this.listView.Items.Add(item);
            }
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void onTextCercaBlur(object sender, EventArgs e)
        {
            this.textCerca.Text = "Cerca qui";
        }

        private void onTextCercaFocus(object sender, EventArgs e)
        {
            this.textCerca.Text = "";
        }

        private void Storico_Load(object sender, EventArgs e)
        {
            seedListView(new List<IFiltroEvento>());
        }

        private void textCerca_TextChanged(object sender, EventArgs e)
        {
            if (this.textCerca.Text != "Cerca qui")
            {
                seedListView(new List<IFiltroEvento> { new FiltroCerca(this.textCerca.Text) });
            }
        }
    }
}
