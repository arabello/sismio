namespace Sismio
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.background = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAccedi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.comboBoxSorgente = new System.Windows.Forms.ComboBox();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(160)))));
            this.background.Controls.Add(this.comboBoxSorgente);
            this.background.Controls.Add(this.title);
            this.background.Controls.Add(this.pictureBox1);
            this.background.Controls.Add(this.btnAccedi);
            this.background.Controls.Add(this.textUsername);
            this.background.Controls.Add(this.textPassword);
            this.background.Location = new System.Drawing.Point(0, 26);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(900, 524);
            this.background.TabIndex = 0;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(344, 87);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(368, 85);
            this.title.TabIndex = 4;
            this.title.Text = "ismio";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Sismio.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(235, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnAccedi
            // 
            this.btnAccedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccedi.AutoSize = true;
            this.btnAccedi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.btnAccedi.Depth = 0;
            this.btnAccedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccedi.Icon = null;
            this.btnAccedi.Location = new System.Drawing.Point(312, 354);
            this.btnAccedi.MaximumSize = new System.Drawing.Size(250, 36);
            this.btnAccedi.MinimumSize = new System.Drawing.Size(250, 36);
            this.btnAccedi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.Primary = true;
            this.btnAccedi.Size = new System.Drawing.Size(250, 36);
            this.btnAccedi.TabIndex = 3;
            this.btnAccedi.Text = "accedi";
            this.btnAccedi.UseVisualStyleBackColor = false;
            this.btnAccedi.Click += new System.EventHandler(this.btnAccedi_Click);
            // 
            // textUsername
            // 
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(312, 243);
            this.textUsername.Margin = new System.Windows.Forms.Padding(16);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(250, 32);
            this.textUsername.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(312, 284);
            this.textPassword.Margin = new System.Windows.Forms.Padding(16);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(250, 32);
            this.textPassword.TabIndex = 1;
            // 
            // comboBoxSorgente
            // 
            this.comboBoxSorgente.FormattingEnabled = true;
            this.comboBoxSorgente.Location = new System.Drawing.Point(312, 325);
            this.comboBoxSorgente.Name = "comboBoxSorgente";
            this.comboBoxSorgente.Size = new System.Drawing.Size(250, 21);
            this.comboBoxSorgente.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.background);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Login";
            this.Text = "Login";
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btnAccedi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox comboBoxSorgente;
    }
}