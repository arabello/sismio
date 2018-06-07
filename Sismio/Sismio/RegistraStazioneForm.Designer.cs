namespace Sismio
{
    partial class RegistraStazioneForm
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
            this.registraStazione1 = new Sismio.io.sismio.ui.RegistraStazione();
            this.SuspendLayout();
            // 
            // registraStazione1
            // 
            this.registraStazione1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registraStazione1.Location = new System.Drawing.Point(0, 64);
            this.registraStazione1.MaximumSize = new System.Drawing.Size(600, 400);
            this.registraStazione1.MinimumSize = new System.Drawing.Size(600, 400);
            this.registraStazione1.Name = "registraStazione1";
            this.registraStazione1.Size = new System.Drawing.Size(600, 400);
            this.registraStazione1.TabIndex = 0;
            // 
            // RegistraStazioneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.registraStazione1);
            this.MaximumSize = new System.Drawing.Size(600, 460);
            this.MinimumSize = new System.Drawing.Size(600, 460);
            this.Name = "RegistraStazioneForm";
            this.Text = "Aggiungi nuova stazione";
            this.Load += new System.EventHandler(this.RegistraStazioneForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private io.sismio.ui.RegistraStazione registraStazione1;
    }
}