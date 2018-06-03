﻿using Sismio.io.sismio.ui;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Sismio
{
    partial class Form1
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

        private PrivateFontCollection loadRobotoMono()
        {

            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.RobotoMono_Bold.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.RobotoMono_Bold;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
            return pfc;
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.navbar = new System.Windows.Forms.Panel();
            this.navGestioneUtenti = new System.Windows.Forms.PictureBox();
            this.asvg = new System.Windows.Forms.PictureBox();
            this.navStorico = new System.Windows.Forms.PictureBox();
            this.navGestioneStazioni = new System.Windows.Forms.PictureBox();
            this.navDashboard = new System.Windows.Forms.PictureBox();
            this.tabGestioneUtenti = new System.Windows.Forms.TabPage();
            this.textCerca = new System.Windows.Forms.TextBox();
            this.btnAggiungiNuovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.titleGestioneUtenti = new System.Windows.Forms.Label();
            this.tabStorico = new System.Windows.Forms.TabPage();
            this.titleStorico = new System.Windows.Forms.Label();
            this.tabGestioneStazioni = new System.Windows.Forms.TabPage();
            this.titleGestioneStazioni = new System.Windows.Forms.Label();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.titleDashboard = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navGestioneUtenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navStorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navGestioneStazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navDashboard)).BeginInit();
            this.tabGestioneUtenti.SuspendLayout();
            this.tabStorico.SuspendLayout();
            this.tabGestioneStazioni.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.navbar.Controls.Add(this.navGestioneUtenti);
            this.navbar.Controls.Add(this.asvg);
            this.navbar.Controls.Add(this.navStorico);
            this.navbar.Controls.Add(this.navGestioneStazioni);
            this.navbar.Controls.Add(this.navDashboard);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(48, 550);
            this.navbar.TabIndex = 1;
            // 
            // navGestioneUtenti
            // 
            this.navGestioneUtenti.Image = global::Sismio.Properties.Resources.baseline_people_white_48dp;
            this.navGestioneUtenti.Location = new System.Drawing.Point(0, 444);
            this.navGestioneUtenti.Margin = new System.Windows.Forms.Padding(0);
            this.navGestioneUtenti.Name = "navGestioneUtenti";
            this.navGestioneUtenti.Size = new System.Drawing.Size(48, 32);
            this.navGestioneUtenti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.navGestioneUtenti.TabIndex = 4;
            this.navGestioneUtenti.TabStop = false;
            this.navGestioneUtenti.Click += new System.EventHandler(this.navGestioneUtenti_Click);
            // 
            // asvg
            // 
            this.asvg.Image = global::Sismio.Properties.Resources.baseline_exit_to_app_white_48dp;
            this.asvg.Location = new System.Drawing.Point(0, 495);
            this.asvg.Margin = new System.Windows.Forms.Padding(0);
            this.asvg.Name = "asvg";
            this.asvg.Size = new System.Drawing.Size(48, 32);
            this.asvg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.asvg.TabIndex = 3;
            this.asvg.TabStop = false;
            // 
            // navStorico
            // 
            this.navStorico.Image = global::Sismio.Properties.Resources.baseline_history_white_48dp;
            this.navStorico.Location = new System.Drawing.Point(0, 179);
            this.navStorico.Margin = new System.Windows.Forms.Padding(0);
            this.navStorico.Name = "navStorico";
            this.navStorico.Size = new System.Drawing.Size(48, 32);
            this.navStorico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.navStorico.TabIndex = 2;
            this.navStorico.TabStop = false;
            this.navStorico.Click += new System.EventHandler(this.navStorico_Click);
            // 
            // navGestioneStazioni
            // 
            this.navGestioneStazioni.Image = global::Sismio.Properties.Resources.baseline_settings_input_antenna_white_48dp;
            this.navGestioneStazioni.Location = new System.Drawing.Point(0, 122);
            this.navGestioneStazioni.Margin = new System.Windows.Forms.Padding(0);
            this.navGestioneStazioni.Name = "navGestioneStazioni";
            this.navGestioneStazioni.Size = new System.Drawing.Size(48, 32);
            this.navGestioneStazioni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.navGestioneStazioni.TabIndex = 1;
            this.navGestioneStazioni.TabStop = false;
            this.navGestioneStazioni.Click += new System.EventHandler(this.navGestioneStazioni_Click);
            // 
            // navDashboard
            // 
            this.navDashboard.Image = global::Sismio.Properties.Resources.baseline_dashboard_white_48dp;
            this.navDashboard.Location = new System.Drawing.Point(0, 68);
            this.navDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Size = new System.Drawing.Size(48, 32);
            this.navDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.navDashboard.TabIndex = 0;
            this.navDashboard.TabStop = false;
            this.navDashboard.Click += new System.EventHandler(this.navDashboard_Click);
            // 
            // tabGestioneUtenti
            // 
            this.tabGestioneUtenti.Controls.Add(this.textCerca);
            this.tabGestioneUtenti.Controls.Add(this.btnAggiungiNuovo);
            this.tabGestioneUtenti.Controls.Add(this.titleGestioneUtenti);
            this.tabGestioneUtenti.Location = new System.Drawing.Point(23, 4);
            this.tabGestioneUtenti.Name = "tabGestioneUtenti";
            this.tabGestioneUtenti.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestioneUtenti.Size = new System.Drawing.Size(848, 518);
            this.tabGestioneUtenti.TabIndex = 3;
            this.tabGestioneUtenti.Text = "tabGestioneUtenti";
            this.tabGestioneUtenti.UseVisualStyleBackColor = true;
            // 
            // textCerca
            // 
            this.textCerca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCerca.Location = new System.Drawing.Point(609, 25);
            this.textCerca.MaximumSize = new System.Drawing.Size(160, 36);
            this.textCerca.MinimumSize = new System.Drawing.Size(160, 36);
            this.textCerca.Name = "textCerca";
            this.textCerca.Size = new System.Drawing.Size(160, 13);
            this.textCerca.TabIndex = 3;
            this.textCerca.Text = "Cerca qui";
            // 
            // btnAggiungiNuovo
            // 
            this.btnAggiungiNuovo.AutoSize = true;
            this.btnAggiungiNuovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAggiungiNuovo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAggiungiNuovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAggiungiNuovo.Depth = 0;
            this.btnAggiungiNuovo.Icon = null;
            this.btnAggiungiNuovo.Location = new System.Drawing.Point(430, 25);
            this.btnAggiungiNuovo.MaximumSize = new System.Drawing.Size(160, 0);
            this.btnAggiungiNuovo.MinimumSize = new System.Drawing.Size(160, 0);
            this.btnAggiungiNuovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAggiungiNuovo.Name = "btnAggiungiNuovo";
            this.btnAggiungiNuovo.Primary = true;
            this.btnAggiungiNuovo.Size = new System.Drawing.Size(160, 36);
            this.btnAggiungiNuovo.TabIndex = 2;
            this.btnAggiungiNuovo.Text = "Aggiungi Nuovo";
            this.btnAggiungiNuovo.UseVisualStyleBackColor = false;
            // 
            // titleGestioneUtenti
            // 
            this.titleGestioneUtenti.BackColor = System.Drawing.SystemColors.Window;
            this.titleGestioneUtenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleGestioneUtenti.Location = new System.Drawing.Point(25, 25);
            this.titleGestioneUtenti.Name = "titleGestioneUtenti";
            this.titleGestioneUtenti.Size = new System.Drawing.Size(232, 37);
            this.titleGestioneUtenti.TabIndex = 1;
            this.titleGestioneUtenti.Text = "Gestione Utenti";
            // 
            // tabStorico
            // 
            this.tabStorico.Controls.Add(this.titleStorico);
            this.tabStorico.Location = new System.Drawing.Point(23, 4);
            this.tabStorico.Name = "tabStorico";
            this.tabStorico.Padding = new System.Windows.Forms.Padding(3);
            this.tabStorico.Size = new System.Drawing.Size(848, 518);
            this.tabStorico.TabIndex = 2;
            this.tabStorico.Text = "tabStorico";
            this.tabStorico.UseVisualStyleBackColor = true;
            // 
            // titleStorico
            // 
            this.titleStorico.BackColor = System.Drawing.SystemColors.Window;
            this.titleStorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleStorico.Location = new System.Drawing.Point(25, 25);
            this.titleStorico.Name = "titleStorico";
            this.titleStorico.Size = new System.Drawing.Size(212, 37);
            this.titleStorico.TabIndex = 1;
            this.titleStorico.Text = "Storico Eventi";
            // 
            // tabGestioneStazioni
            // 
            this.tabGestioneStazioni.Controls.Add(this.titleGestioneStazioni);
            this.tabGestioneStazioni.Location = new System.Drawing.Point(23, 4);
            this.tabGestioneStazioni.Name = "tabGestioneStazioni";
            this.tabGestioneStazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestioneStazioni.Size = new System.Drawing.Size(848, 518);
            this.tabGestioneStazioni.TabIndex = 1;
            this.tabGestioneStazioni.Text = "tabGestioneStazioni";
            this.tabGestioneStazioni.UseVisualStyleBackColor = true;
            // 
            // titleGestioneStazioni
            // 
            this.titleGestioneStazioni.BackColor = System.Drawing.SystemColors.Window;
            this.titleGestioneStazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleGestioneStazioni.Location = new System.Drawing.Point(25, 25);
            this.titleGestioneStazioni.Name = "titleGestioneStazioni";
            this.titleGestioneStazioni.Size = new System.Drawing.Size(257, 37);
            this.titleGestioneStazioni.TabIndex = 1;
            this.titleGestioneStazioni.Text = "Gestione Stazioni";
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.titleDashboard);
            this.tabDashboard.Location = new System.Drawing.Point(23, 4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(848, 518);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "tabDashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // titleDashboard
            // 
            this.titleDashboard.BackColor = System.Drawing.SystemColors.Window;
            this.titleDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDashboard.Location = new System.Drawing.Point(25, 25);
            this.titleDashboard.Name = "titleDashboard";
            this.titleDashboard.Size = new System.Drawing.Size(212, 37);
            this.titleDashboard.TabIndex = 0;
            this.titleDashboard.Text = "Dashboard";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabGestioneStazioni);
            this.tabControl.Controls.Add(this.tabStorico);
            this.tabControl.Controls.Add(this.tabGestioneUtenti);
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Location = new System.Drawing.Point(25, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(875, 526);
            this.tabControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.navbar);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navGestioneUtenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navStorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navGestioneStazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navDashboard)).EndInit();
            this.tabGestioneUtenti.ResumeLayout(false);
            this.tabGestioneUtenti.PerformLayout();
            this.tabStorico.ResumeLayout(false);
            this.tabGestioneStazioni.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.PictureBox navDashboard;
        private System.Windows.Forms.PictureBox navGestioneStazioni;
        private System.Windows.Forms.PictureBox navStorico;
        private System.Windows.Forms.PictureBox asvg;
        private System.Windows.Forms.PictureBox navGestioneUtenti;
        private System.Windows.Forms.TabPage tabGestioneUtenti;
        private System.Windows.Forms.TabPage tabStorico;
        private System.Windows.Forms.TabPage tabGestioneStazioni;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label titleDashboard;
        private System.Windows.Forms.Label titleGestioneStazioni;
        private System.Windows.Forms.Label titleGestioneUtenti;
        private System.Windows.Forms.Label titleStorico;
        private MaterialSkin.Controls.MaterialRaisedButton btnAggiungiNuovo;
        private System.Windows.Forms.TextBox textCerca;
    }




}

