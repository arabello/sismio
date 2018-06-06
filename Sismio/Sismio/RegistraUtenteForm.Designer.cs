namespace Sismio
{
    partial class RegistraUtenteForm
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
            this.registraUtente1 = new Sismio.io.sismio.ui.RegistraUtente();
            this.SuspendLayout();
            // 
            // registraUtente1
            // 
            this.registraUtente1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registraUtente1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registraUtente1.Location = new System.Drawing.Point(0, 60);
            this.registraUtente1.MaximumSize = new System.Drawing.Size(600, 400);
            this.registraUtente1.MinimumSize = new System.Drawing.Size(600, 400);
            this.registraUtente1.Name = "registraUtente1";
            this.registraUtente1.Size = new System.Drawing.Size(600, 400);
            this.registraUtente1.TabIndex = 0;
            // 
            // RegistraUtenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.registraUtente1);
            this.MaximumSize = new System.Drawing.Size(600, 460);
            this.MinimumSize = new System.Drawing.Size(600, 460);
            this.Name = "RegistraUtenteForm";
            this.Text = "Aggiungi nuovo utente";
            this.ResumeLayout(false);

        }

        #endregion

        private io.sismio.ui.RegistraUtente registraUtente1;
    }
}