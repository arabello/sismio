namespace Sismio.io.sismio.ui
{
    partial class Storico
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.listView = new MaterialSkin.Controls.MaterialListView();
            this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Messaggio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priorita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconCerca = new System.Windows.Forms.PictureBox();
            this.textCerca = new System.Windows.Forms.TextBox();
            this.panelFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.filtroDateTimeFine = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filtroDateTimeInizio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.filtroPriorita = new System.Windows.Forms.ComboBox();
            this.textFiltro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bgTextCerca = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerca)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.bgTextCerca.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(23, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(232, 37);
            this.title.TabIndex = 9;
            this.title.Text = "Storico eventi";
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateTime,
            this.Tag,
            this.Stazione,
            this.Messaggio,
            this.Priorita});
            this.listView.Depth = 0;
            this.listView.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HoverSelection = true;
            this.listView.Location = new System.Drawing.Point(30, 80);
            this.listView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView.MouseState = MaterialSkin.MouseState.OUT;
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(800, 507);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // DateTime
            // 
            this.DateTime.Text = "Data e ora";
            this.DateTime.Width = 160;
            // 
            // Tag
            // 
            this.Tag.Text = "Tag";
            this.Tag.Width = 120;
            // 
            // Stazione
            // 
            this.Stazione.Text = "Stazione d\'origine";
            this.Stazione.Width = 120;
            // 
            // Messaggio
            // 
            this.Messaggio.Text = "Messaggio";
            this.Messaggio.Width = 240;
            // 
            // Priorita
            // 
            this.Priorita.Text = "Priorità";
            this.Priorita.Width = 160;
            // 
            // iconCerca
            // 
            this.iconCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerca.Image = global::Sismio.Properties.Resources.baseline_search_white_24dp;
            this.iconCerca.Location = new System.Drawing.Point(139, 6);
            this.iconCerca.Name = "iconCerca";
            this.iconCerca.Size = new System.Drawing.Size(23, 24);
            this.iconCerca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerca.TabIndex = 4;
            this.iconCerca.TabStop = false;
            // 
            // textCerca
            // 
            this.textCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCerca.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textCerca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCerca.Location = new System.Drawing.Point(6, 9);
            this.textCerca.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textCerca.MaximumSize = new System.Drawing.Size(120, 26);
            this.textCerca.MinimumSize = new System.Drawing.Size(120, 26);
            this.textCerca.Name = "textCerca";
            this.textCerca.Size = new System.Drawing.Size(120, 26);
            this.textCerca.TabIndex = 3;
            this.textCerca.Text = "Cerca qui";
            this.textCerca.TextChanged += new System.EventHandler(this.textCerca_TextChanged);
            // 
            // panelFiltro
            // 
            this.panelFiltro.ColumnCount = 2;
            this.panelFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86226F));
            this.panelFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13774F));
            this.panelFiltro.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.panelFiltro.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.panelFiltro.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.panelFiltro.Location = new System.Drawing.Point(429, 14);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.RowCount = 2;
            this.panelFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelFiltro.Size = new System.Drawing.Size(401, 58);
            this.panelFiltro.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.11364F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.88636F));
            this.tableLayoutPanel2.Controls.Add(this.filtroDateTimeFine, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(202, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 23);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // filtroDateTimeFine
            // 
            this.filtroDateTimeFine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filtroDateTimeFine.CustomFormat = "dd/MM/yyyy HH:mm";
            this.filtroDateTimeFine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filtroDateTimeFine.Location = new System.Drawing.Point(80, 3);
            this.filtroDateTimeFine.Name = "filtroDateTimeFine";
            this.filtroDateTimeFine.Size = new System.Drawing.Size(113, 20);
            this.filtroDateTimeFine.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fine";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.28571F));
            this.tableLayoutPanel1.Controls.Add(this.filtroDateTimeInizio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 23);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // filtroDateTimeInizio
            // 
            this.filtroDateTimeInizio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filtroDateTimeInizio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.filtroDateTimeInizio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.filtroDateTimeInizio.Location = new System.Drawing.Point(81, 3);
            this.filtroDateTimeInizio.Name = "filtroDateTimeInizio";
            this.filtroDateTimeInizio.Size = new System.Drawing.Size(109, 20);
            this.filtroDateTimeInizio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inizio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.panelFiltro.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.84746F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.15254F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel3.Controls.Add(this.filtroPriorita, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.textFiltro, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 23);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // filtroPriorita
            // 
            this.filtroPriorita.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filtroPriorita.FormattingEnabled = true;
            this.filtroPriorita.Items.AddRange(new object[] {
            "INFO",
            "ALERT",
            "WARNING",
            "CRITICAL",
            "FATAL",
            "-"});
            this.filtroPriorita.Location = new System.Drawing.Point(278, 3);
            this.filtroPriorita.Name = "filtroPriorita";
            this.filtroPriorita.Size = new System.Drawing.Size(114, 21);
            this.filtroPriorita.TabIndex = 1;
            // 
            // textFiltro
            // 
            this.textFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textFiltro.AutoSize = true;
            this.textFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFiltro.ForeColor = System.Drawing.Color.White;
            this.textFiltro.Location = new System.Drawing.Point(3, 3);
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.Size = new System.Drawing.Size(126, 17);
            this.textFiltro.TabIndex = 0;
            this.textFiltro.Text = "Filtro eventi sismici";
            this.textFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(192, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Priorità";
            // 
            // bgTextCerca
            // 
            this.bgTextCerca.ColumnCount = 2;
            this.bgTextCerca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.bgTextCerca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.bgTextCerca.Controls.Add(this.iconCerca, 1, 0);
            this.bgTextCerca.Controls.Add(this.textCerca, 0, 0);
            this.bgTextCerca.Location = new System.Drawing.Point(245, 14);
            this.bgTextCerca.Name = "bgTextCerca";
            this.bgTextCerca.RowCount = 1;
            this.bgTextCerca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bgTextCerca.Size = new System.Drawing.Size(165, 36);
            this.bgTextCerca.TabIndex = 14;
            // 
            // Storico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bgTextCerca);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.title);
            this.Name = "Storico";
            this.Size = new System.Drawing.Size(848, 518);
            this.Load += new System.EventHandler(this.Storico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconCerca)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.bgTextCerca.ResumeLayout(false);
            this.bgTextCerca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private MaterialSkin.Controls.MaterialListView listView;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.ColumnHeader Tag;
        private System.Windows.Forms.ColumnHeader Stazione;
        private System.Windows.Forms.ColumnHeader Messaggio;
        private System.Windows.Forms.ColumnHeader Priorita;
        private System.Windows.Forms.PictureBox iconCerca;
        private System.Windows.Forms.TextBox textCerca;
        private System.Windows.Forms.TableLayoutPanel panelFiltro;
        private System.Windows.Forms.Label textFiltro;
        private System.Windows.Forms.ComboBox filtroPriorita;
        private System.Windows.Forms.DateTimePicker filtroDateTimeInizio;
        private System.Windows.Forms.DateTimePicker filtroDateTimeFine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel bgTextCerca;
    }
}
