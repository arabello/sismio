namespace Sismio.io.sismio.ui
{
    partial class RegistraStazione
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputLocazione = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputIP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputPorta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCrea = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAnnulla = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inputNome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputLocazione, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputIP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputPorta, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 311);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // inputNome
            // 
            this.inputNome.Depth = 0;
            this.inputNome.Hint = "";
            this.inputNome.Location = new System.Drawing.Point(3, 3);
            this.inputNome.MaxLength = 32767;
            this.inputNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputNome.Name = "inputNome";
            this.inputNome.PasswordChar = '\0';
            this.inputNome.SelectedText = "";
            this.inputNome.SelectionLength = 0;
            this.inputNome.SelectionStart = 0;
            this.inputNome.Size = new System.Drawing.Size(192, 25);
            this.inputNome.TabIndex = 1;
            this.inputNome.TabStop = false;
            this.inputNome.Text = "Nome stazione";
            this.inputNome.UseSystemPasswordChar = false;
            // 
            // inputLocazione
            // 
            this.inputLocazione.Depth = 0;
            this.inputLocazione.Hint = "";
            this.inputLocazione.Location = new System.Drawing.Point(272, 3);
            this.inputLocazione.MaxLength = 32767;
            this.inputLocazione.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputLocazione.Name = "inputLocazione";
            this.inputLocazione.PasswordChar = '\0';
            this.inputLocazione.SelectedText = "";
            this.inputLocazione.SelectionLength = 0;
            this.inputLocazione.SelectionStart = 0;
            this.inputLocazione.Size = new System.Drawing.Size(192, 25);
            this.inputLocazione.TabIndex = 1;
            this.inputLocazione.TabStop = false;
            this.inputLocazione.Text = "Locazione";
            this.inputLocazione.UseSystemPasswordChar = false;
            // 
            // inputIP
            // 
            this.inputIP.Depth = 0;
            this.inputIP.Hint = "";
            this.inputIP.Location = new System.Drawing.Point(3, 148);
            this.inputIP.MaxLength = 32767;
            this.inputIP.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputIP.Name = "inputIP";
            this.inputIP.PasswordChar = '\0';
            this.inputIP.SelectedText = "";
            this.inputIP.SelectionLength = 0;
            this.inputIP.SelectionStart = 0;
            this.inputIP.Size = new System.Drawing.Size(192, 25);
            this.inputIP.TabIndex = 1;
            this.inputIP.TabStop = false;
            this.inputIP.Text = "Indirizzo IP";
            this.inputIP.UseSystemPasswordChar = false;
            // 
            // inputPorta
            // 
            this.inputPorta.Depth = 0;
            this.inputPorta.Hint = "";
            this.inputPorta.Location = new System.Drawing.Point(272, 148);
            this.inputPorta.MaxLength = 32767;
            this.inputPorta.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputPorta.Name = "inputPorta";
            this.inputPorta.PasswordChar = '\0';
            this.inputPorta.SelectedText = "";
            this.inputPorta.SelectionLength = 0;
            this.inputPorta.SelectionStart = 0;
            this.inputPorta.Size = new System.Drawing.Size(192, 25);
            this.inputPorta.TabIndex = 1;
            this.inputPorta.TabStop = false;
            this.inputPorta.Text = "Porta";
            this.inputPorta.UseSystemPasswordChar = false;
            // 
            // btnCrea
            // 
            this.btnCrea.AutoSize = true;
            this.btnCrea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrea.Depth = 0;
            this.btnCrea.Icon = null;
            this.btnCrea.Location = new System.Drawing.Point(469, 338);
            this.btnCrea.MaximumSize = new System.Drawing.Size(100, 36);
            this.btnCrea.MinimumSize = new System.Drawing.Size(100, 36);
            this.btnCrea.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Primary = true;
            this.btnCrea.Size = new System.Drawing.Size(100, 36);
            this.btnCrea.TabIndex = 8;
            this.btnCrea.Text = "crea";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.AutoSize = true;
            this.btnAnnulla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnnulla.Depth = 0;
            this.btnAnnulla.Icon = null;
            this.btnAnnulla.Location = new System.Drawing.Point(363, 338);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnnulla.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Primary = false;
            this.btnAnnulla.Size = new System.Drawing.Size(83, 36);
            this.btnAnnulla.TabIndex = 10;
            this.btnAnnulla.Text = "annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // RegistraStazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "RegistraStazione";
            this.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputLocazione;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputIP;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputPorta;
        private MaterialSkin.Controls.MaterialRaisedButton btnCrea;
        private MaterialSkin.Controls.MaterialFlatButton btnAnnulla;
    }
}
