namespace Sismio
{
    partial class RegistraStazioniForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.RegistraStazioneForm = new Sismio.io.sismio.ui.RegistraStazione();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // RegistraStazioneForm
            // 
            this.RegistraStazioneForm.Location = new System.Drawing.Point(0, 63);
            this.RegistraStazioneForm.MaximumSize = new System.Drawing.Size(600, 400);
            this.RegistraStazioneForm.MinimumSize = new System.Drawing.Size(600, 400);
            this.RegistraStazioneForm.Name = "RegistraStazioneForm";
            this.RegistraStazioneForm.Size = new System.Drawing.Size(600, 400);
            this.RegistraStazioneForm.TabIndex = 0;
            // 
            // RegistraStazioniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.RegistraStazioneForm);
            this.MaximumSize = new System.Drawing.Size(600, 460);
            this.MinimumSize = new System.Drawing.Size(600, 460);
            this.Name = "RegistraStazioniForm";
            this.Text = "Aggiungi nuova stazione";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private io.sismio.ui.RegistraStazione RegistraStazioneForm;
    }
}