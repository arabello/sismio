namespace Sismio.io.sismio.ui
{
    partial class HomeGestioneUtenti
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
            this.btnAggiungiNuovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.title = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.listView = new MaterialSkin.Controls.MaterialListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoginRemoto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bgTextCerca = new System.Windows.Forms.TableLayoutPanel();
            this.iconCerca = new System.Windows.Forms.PictureBox();
            this.textCerca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.bgTextCerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAggiungiNuovo
            // 
            this.btnAggiungiNuovo.AutoSize = true;
            this.btnAggiungiNuovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAggiungiNuovo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAggiungiNuovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAggiungiNuovo.Depth = 0;
            this.btnAggiungiNuovo.FlatAppearance.BorderSize = 3;
            this.btnAggiungiNuovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAggiungiNuovo.Icon = null;
            this.btnAggiungiNuovo.Location = new System.Drawing.Point(366, 15);
            this.btnAggiungiNuovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAggiungiNuovo.MinimumSize = new System.Drawing.Size(160, 36);
            this.btnAggiungiNuovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAggiungiNuovo.Name = "btnAggiungiNuovo";
            this.btnAggiungiNuovo.Primary = true;
            this.btnAggiungiNuovo.Size = new System.Drawing.Size(160, 36);
            this.btnAggiungiNuovo.TabIndex = 8;
            this.btnAggiungiNuovo.Text = "Aggiungi Nuovo";
            this.btnAggiungiNuovo.UseVisualStyleBackColor = false;
            this.btnAggiungiNuovo.Click += new System.EventHandler(this.btnAggiungiNuovo_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(23, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(232, 37);
            this.title.TabIndex = 7;
            this.title.Text = "Gestione Utenti";
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
            this.btnDelete.TabIndex = 11;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.Username,
            this.Tipo,
            this.LoginRemoto});
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
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 235;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 160;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 177;
            // 
            // LoginRemoto
            // 
            this.LoginRemoto.Text = "Login Remoto";
            this.LoginRemoto.Width = 146;
            // 
            // bgTextCerca
            // 
            this.bgTextCerca.ColumnCount = 2;
            this.bgTextCerca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.bgTextCerca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.bgTextCerca.Controls.Add(this.iconCerca, 1, 0);
            this.bgTextCerca.Controls.Add(this.textCerca, 0, 0);
            this.bgTextCerca.Location = new System.Drawing.Point(559, 15);
            this.bgTextCerca.Name = "bgTextCerca";
            this.bgTextCerca.RowCount = 1;
            this.bgTextCerca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bgTextCerca.Size = new System.Drawing.Size(165, 36);
            this.bgTextCerca.TabIndex = 15;
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
            // HomeGestioneUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bgTextCerca);
            this.Controls.Add(this.btnAggiungiNuovo);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView);
            this.Name = "HomeGestioneUtenti";
            this.Size = new System.Drawing.Size(848, 518);
            this.Load += new System.EventHandler(this.HomeGestioneUtenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.bgTextCerca.ResumeLayout(false);
            this.bgTextCerca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAggiungiNuovo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox btnDelete;
        private MaterialSkin.Controls.MaterialListView listView;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader LoginRemoto;
        private System.Windows.Forms.TableLayoutPanel bgTextCerca;
        private System.Windows.Forms.PictureBox iconCerca;
        private System.Windows.Forms.TextBox textCerca;
    }
}
