namespace Sismio.io.sismio.ui
{
    partial class HomeDashboard
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
            this.chartFrequenza = new LiveCharts.WinForms.CartesianChart();
            this.chartMagnitudo = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(23, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(232, 37);
            this.title.TabIndex = 8;
            this.title.Text = "Dashboard";
            // 
            // chartFrequenza
            // 
            this.chartFrequenza.BackColor = System.Drawing.Color.White;
            this.chartFrequenza.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chartFrequenza.Location = new System.Drawing.Point(30, 72);
            this.chartFrequenza.Name = "chartFrequenza";
            this.chartFrequenza.Size = new System.Drawing.Size(380, 260);
            this.chartFrequenza.TabIndex = 9;
            this.chartFrequenza.Text = "Frequenza";
            // 
            // chartMagnitudo
            // 
            this.chartMagnitudo.BackColor = System.Drawing.Color.White;
            this.chartMagnitudo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chartMagnitudo.Location = new System.Drawing.Point(435, 72);
            this.chartMagnitudo.Name = "chartMagnitudo";
            this.chartMagnitudo.Size = new System.Drawing.Size(380, 260);
            this.chartMagnitudo.TabIndex = 10;
            this.chartMagnitudo.Text = "Magnitudo";
            // 
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMagnitudo);
            this.Controls.Add(this.chartFrequenza);
            this.Controls.Add(this.title);
            this.Name = "HomeDashboard";
            this.Size = new System.Drawing.Size(848, 518);
            this.Load += new System.EventHandler(this.HomeDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private LiveCharts.WinForms.CartesianChart chartFrequenza;
        private LiveCharts.WinForms.CartesianChart chartMagnitudo;
    }
}
