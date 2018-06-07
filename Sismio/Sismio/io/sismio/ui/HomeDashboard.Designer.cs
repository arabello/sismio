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
            this.panelAllertaEvento = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrioritaEvento = new System.Windows.Forms.Label();
            this.labelMessaggioEvento = new System.Windows.Forms.Label();
            this.comboBoxSorgente = new System.Windows.Forms.ComboBox();
            this.panelAllertaEvento.SuspendLayout();
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
            // panelAllertaEvento
            // 
            this.panelAllertaEvento.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panelAllertaEvento.ColumnCount = 2;
            this.panelAllertaEvento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelAllertaEvento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 514F));
            this.panelAllertaEvento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelAllertaEvento.Controls.Add(this.labelPrioritaEvento, 0, 0);
            this.panelAllertaEvento.Controls.Add(this.labelMessaggioEvento, 1, 0);
            this.panelAllertaEvento.Location = new System.Drawing.Point(30, 362);
            this.panelAllertaEvento.Name = "panelAllertaEvento";
            this.panelAllertaEvento.RowCount = 1;
            this.panelAllertaEvento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelAllertaEvento.Size = new System.Drawing.Size(785, 126);
            this.panelAllertaEvento.TabIndex = 11;
            // 
            // labelPrioritaEvento
            // 
            this.labelPrioritaEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrioritaEvento.AutoSize = true;
            this.labelPrioritaEvento.BackColor = System.Drawing.Color.Transparent;
            this.labelPrioritaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioritaEvento.Location = new System.Drawing.Point(4, 1);
            this.labelPrioritaEvento.Name = "labelPrioritaEvento";
            this.labelPrioritaEvento.Size = new System.Drawing.Size(262, 124);
            this.labelPrioritaEvento.TabIndex = 0;
            this.labelPrioritaEvento.Text = "label1";
            this.labelPrioritaEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessaggioEvento
            // 
            this.labelMessaggioEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessaggioEvento.AutoSize = true;
            this.labelMessaggioEvento.BackColor = System.Drawing.Color.Transparent;
            this.labelMessaggioEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessaggioEvento.Location = new System.Drawing.Point(273, 1);
            this.labelMessaggioEvento.Name = "labelMessaggioEvento";
            this.labelMessaggioEvento.Size = new System.Drawing.Size(508, 124);
            this.labelMessaggioEvento.TabIndex = 1;
            this.labelMessaggioEvento.Text = "label2";
            this.labelMessaggioEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSorgente
            // 
            this.comboBoxSorgente.FormattingEnabled = true;
            this.comboBoxSorgente.Location = new System.Drawing.Point(599, 29);
            this.comboBoxSorgente.Name = "comboBoxSorgente";
            this.comboBoxSorgente.Size = new System.Drawing.Size(212, 21);
            this.comboBoxSorgente.TabIndex = 12;
            // 
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSorgente);
            this.Controls.Add(this.panelAllertaEvento);
            this.Controls.Add(this.chartMagnitudo);
            this.Controls.Add(this.chartFrequenza);
            this.Controls.Add(this.title);
            this.Name = "HomeDashboard";
            this.Size = new System.Drawing.Size(848, 518);
            this.Load += new System.EventHandler(this.HomeDashboard_Load);
            this.panelAllertaEvento.ResumeLayout(false);
            this.panelAllertaEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private LiveCharts.WinForms.CartesianChart chartFrequenza;
        private LiveCharts.WinForms.CartesianChart chartMagnitudo;
        private System.Windows.Forms.TableLayoutPanel panelAllertaEvento;
        private System.Windows.Forms.Label labelPrioritaEvento;
        private System.Windows.Forms.Label labelMessaggioEvento;
        private System.Windows.Forms.ComboBox comboBoxSorgente;
    }
}
