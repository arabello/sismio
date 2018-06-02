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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccedi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.btnAccedi);
            this.panel1.Controls.Add(this.textUsername);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 524);
            this.panel1.TabIndex = 0;
            // 
            // btnAccedi
            // 
            this.btnAccedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccedi.AutoSize = true;
            this.btnAccedi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(220)))));
            this.btnAccedi.Depth = 0;
            this.btnAccedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccedi.Icon = null;
            this.btnAccedi.Location = new System.Drawing.Point(331, 353);
            this.btnAccedi.MaximumSize = new System.Drawing.Size(200, 36);
            this.btnAccedi.MinimumSize = new System.Drawing.Size(200, 36);
            this.btnAccedi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAccedi.Name = "btnAccedi";
            this.btnAccedi.Primary = true;
            this.btnAccedi.Size = new System.Drawing.Size(200, 36);
            this.btnAccedi.TabIndex = 3;
            this.btnAccedi.Text = "accedi";
            this.btnAccedi.UseVisualStyleBackColor = false;
            // 
            // textUsername
            // 
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(331, 271);
            this.textUsername.Margin = new System.Windows.Forms.Padding(16);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(200, 32);
            this.textUsername.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(331, 312);
            this.textPassword.Margin = new System.Windows.Forms.Padding(16);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(200, 32);
            this.textPassword.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btnAccedi;
    }
}