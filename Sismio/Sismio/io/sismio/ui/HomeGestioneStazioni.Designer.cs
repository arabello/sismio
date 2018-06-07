namespace Sismio.io.sismio.ui
{
    partial class HomeGestioneStazioni
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
            this.btnAggiungiNuovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.listView = new MaterialSkin.Controls.MaterialListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Indirizzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chiave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bgTextCerca = new System.Windows.Forms.TableLayoutPanel();
            this.textCerca = new System.Windows.Forms.TextBox();
            this.iconCerca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.bgTextCerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerca)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.title.Location = new System.Drawing.Point(23, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(269, 37);
            this.title.TabIndex = 7;
            this.title.Text = "Gestione Stazioni";
            // 
            // btnAggiungiNuovo
            // 
            this.btnAggiungiNuovo.AutoSize = true;
            this.btnAggiungiNuovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAggiungiNuovo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAggiungiNuovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAggiungiNuovo.Depth = 0;
            this.btnAggiungiNuovo.Icon = null;
            this.btnAggiungiNuovo.Location = new System.Drawing.Point(366, 15);
            this.btnAggiungiNuovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAggiungiNuovo.MinimumSize = new System.Drawing.Size(160, 36);
            this.btnAggiungiNuovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAggiungiNuovo.Name = "btnAggiungiNuovo";
            this.btnAggiungiNuovo.Primary = true;
            this.btnAggiungiNuovo.Size = new System.Drawing.Size(160, 36);
            this.btnAggiungiNuovo.TabIndex = 8;
            this.btnAggiungiNuovo.Text = "Associa Nuova";
            this.btnAggiungiNuovo.UseVisualStyleBackColor = false;
            this.btnAggiungiNuovo.Click += new System.EventHandler(this.btnAggiungiNuovo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Sismio.Properties.Resources.btndelete;
            this.btnDelete.Location = new System.Drawing.Point(770, 432);
            this.btnDelete.MaximumSize = new System.Drawing.Size(56, 56);
            this.btnDelete.MinimumSize = new System.Drawing.Size(56, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 9;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Stazione,
            this.Indirizzo,
            this.Chiave});
            this.listView.Depth = 0;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(30, 70);
            this.listView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView.MouseState = MaterialSkin.MouseState.OUT;
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(719, 507);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 160;
            // 
            // Stazione
            // 
            this.Stazione.Text = "Locazione";
            this.Stazione.Width = 130;
            // 
            // Indirizzo
            // 
            this.Indirizzo.Text = "IP:Porta";
            this.Indirizzo.Width = 150;
            // 
            // Chiave
            // 
            this.Chiave.Text = "Chiave pubblica";
            this.Chiave.Width = 390;
            // 
            // bgTextCerca
            // 
            this.bgTextCerca.ColumnCount = 2;
            this.bgTextCerca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.42424F));
            this.bgTextCerca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.57576F));
            this.bgTextCerca.Controls.Add(this.textCerca, 0, 0);
            this.bgTextCerca.Controls.Add(this.iconCerca, 1, 0);
            this.bgTextCerca.Location = new System.Drawing.Point(559, 15);
            this.bgTextCerca.Name = "bgTextCerca";
            this.bgTextCerca.RowCount = 1;
            this.bgTextCerca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bgTextCerca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bgTextCerca.Size = new System.Drawing.Size(165, 36);
            this.bgTextCerca.TabIndex = 15;
            // 
            // textCerca
            // 
            this.textCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCerca.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textCerca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textCerca.Location = new System.Drawing.Point(6, 9);
            this.textCerca.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textCerca.MaximumSize = new System.Drawing.Size(120, 26);
            this.textCerca.MinimumSize = new System.Drawing.Size(120, 26);
            this.textCerca.Name = "textCerca";
            this.textCerca.Size = new System.Drawing.Size(120, 26);
            this.textCerca.TabIndex = 0;
            this.textCerca.Text = "Cerca qui";
            this.textCerca.TextChanged += new System.EventHandler(this.textCerca_TextChanged);
            // 
            // iconCerca
            // 
            this.iconCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerca.Image = global::Sismio.Properties.Resources.baseline_search_white_24dp;
            this.iconCerca.Location = new System.Drawing.Point(138, 6);
            this.iconCerca.Name = "iconCerca";
            this.iconCerca.Size = new System.Drawing.Size(24, 24);
            this.iconCerca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerca.TabIndex = 1;
            this.iconCerca.TabStop = false;
            // 
            // HomeGestioneStazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bgTextCerca);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAggiungiNuovo);
            this.Controls.Add(this.title);
            this.Name = "HomeGestioneStazioni";
            this.Size = new System.Drawing.Size(848, 518);
            this.Load += new System.EventHandler(this.HomeGestioneStazioni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.bgTextCerca.ResumeLayout(false);
            this.bgTextCerca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private MaterialSkin.Controls.MaterialRaisedButton btnAggiungiNuovo;
        private System.Windows.Forms.PictureBox btnDelete;
        private MaterialSkin.Controls.MaterialListView listView;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Stazione;
        private System.Windows.Forms.ColumnHeader Indirizzo;
        private System.Windows.Forms.ColumnHeader Chiave;
        private System.Windows.Forms.TableLayoutPanel bgTextCerca;
        private System.Windows.Forms.TextBox textCerca;
        private System.Windows.Forms.PictureBox iconCerca;
    }
}
