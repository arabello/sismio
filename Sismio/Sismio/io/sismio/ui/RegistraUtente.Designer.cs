namespace Sismio.io.sismio.ui
{
    partial class RegistraUtente
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
            this.btnCrea = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAnnulla = new MaterialSkin.Controls.MaterialFlatButton();
            this.checkboxLoginRemoto = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkboxAmm = new MaterialSkin.Controls.MaterialCheckBox();
            this.inputPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputCognome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCrea.Text = "CREA";
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
            this.btnAnnulla.TabIndex = 9;
            this.btnAnnulla.Text = "annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // checkboxLoginRemoto
            // 
            this.checkboxLoginRemoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkboxLoginRemoto.AutoSize = true;
            this.checkboxLoginRemoto.Depth = 0;
            this.checkboxLoginRemoto.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxLoginRemoto.Location = new System.Drawing.Point(0, 9);
            this.checkboxLoginRemoto.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxLoginRemoto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxLoginRemoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxLoginRemoto.Name = "checkboxLoginRemoto";
            this.checkboxLoginRemoto.Ripple = true;
            this.checkboxLoginRemoto.Size = new System.Drawing.Size(166, 30);
            this.checkboxLoginRemoto.TabIndex = 6;
            this.checkboxLoginRemoto.Text = "Consenti login remoto";
            this.checkboxLoginRemoto.UseVisualStyleBackColor = true;
            // 
            // checkboxAmm
            // 
            this.checkboxAmm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkboxAmm.AutoSize = true;
            this.checkboxAmm.Depth = 0;
            this.checkboxAmm.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxAmm.Location = new System.Drawing.Point(0, 59);
            this.checkboxAmm.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxAmm.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxAmm.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxAmm.Name = "checkboxAmm";
            this.checkboxAmm.Ripple = true;
            this.checkboxAmm.Size = new System.Drawing.Size(126, 30);
            this.checkboxAmm.TabIndex = 7;
            this.checkboxAmm.Text = "Amministratore";
            this.checkboxAmm.UseVisualStyleBackColor = true;
            // 
            // inputPassword
            // 
            this.inputPassword.Depth = 0;
            this.inputPassword.Hint = "";
            this.inputPassword.Location = new System.Drawing.Point(272, 106);
            this.inputPassword.MaxLength = 32767;
            this.inputPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.SelectedText = "";
            this.inputPassword.SelectionLength = 0;
            this.inputPassword.SelectionStart = 0;
            this.inputPassword.Size = new System.Drawing.Size(220, 23);
            this.inputPassword.TabIndex = 5;
            this.inputPassword.TabStop = false;
            this.inputPassword.Text = "Password";
            this.inputPassword.UseSystemPasswordChar = false;
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
            this.inputNome.Size = new System.Drawing.Size(192, 23);
            this.inputNome.TabIndex = 1;
            this.inputNome.TabStop = false;
            this.inputNome.Text = "Nome";
            this.inputNome.UseSystemPasswordChar = false;
            // 
            // inputCognome
            // 
            this.inputCognome.Depth = 0;
            this.inputCognome.Hint = "";
            this.inputCognome.Location = new System.Drawing.Point(3, 106);
            this.inputCognome.MaxLength = 32767;
            this.inputCognome.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputCognome.Name = "inputCognome";
            this.inputCognome.PasswordChar = '\0';
            this.inputCognome.SelectedText = "";
            this.inputCognome.SelectionLength = 0;
            this.inputCognome.SelectionStart = 0;
            this.inputCognome.Size = new System.Drawing.Size(192, 23);
            this.inputCognome.TabIndex = 2;
            this.inputCognome.TabStop = false;
            this.inputCognome.Text = "Cognome";
            this.inputCognome.UseSystemPasswordChar = false;
            // 
            // inputEmail
            // 
            this.inputEmail.Depth = 0;
            this.inputEmail.Hint = "";
            this.inputEmail.Location = new System.Drawing.Point(3, 209);
            this.inputEmail.MaxLength = 32767;
            this.inputEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.PasswordChar = '\0';
            this.inputEmail.SelectedText = "";
            this.inputEmail.SelectionLength = 0;
            this.inputEmail.SelectionStart = 0;
            this.inputEmail.Size = new System.Drawing.Size(192, 23);
            this.inputEmail.TabIndex = 3;
            this.inputEmail.TabStop = false;
            this.inputEmail.Text = "Email";
            this.inputEmail.UseSystemPasswordChar = false;
            // 
            // inputUsername
            // 
            this.inputUsername.Depth = 0;
            this.inputUsername.Hint = "";
            this.inputUsername.Location = new System.Drawing.Point(272, 3);
            this.inputUsername.MaxLength = 32767;
            this.inputUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.PasswordChar = '\0';
            this.inputUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputUsername.SelectedText = "";
            this.inputUsername.SelectionLength = 0;
            this.inputUsername.SelectionStart = 0;
            this.inputUsername.Size = new System.Drawing.Size(192, 23);
            this.inputUsername.TabIndex = 4;
            this.inputUsername.TabStop = false;
            this.inputUsername.Text = "Username";
            this.inputUsername.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inputNome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputCognome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 311);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.checkboxAmm, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkboxLoginRemoto, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(272, 209);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 99);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // RegistraUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnCrea);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "RegistraUtente";
            this.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCrea;
        private MaterialSkin.Controls.MaterialFlatButton btnAnnulla;
        private MaterialSkin.Controls.MaterialCheckBox checkboxLoginRemoto;
        private MaterialSkin.Controls.MaterialCheckBox checkboxAmm;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputCognome;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputUsername;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
