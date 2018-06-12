namespace Rechnermodul
{
    partial class rechnermodul
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Ergebnis = new System.Windows.Forms.ListBox();
            this.ms_module = new System.Windows.Forms.MenuStrip();
            this.btn_einstellungen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Ergebnis
            // 
            this.lb_Ergebnis.FormattingEnabled = true;
            this.lb_Ergebnis.Location = new System.Drawing.Point(141, 12);
            this.lb_Ergebnis.Name = "lb_Ergebnis";
            this.lb_Ergebnis.Size = new System.Drawing.Size(183, 264);
            this.lb_Ergebnis.TabIndex = 3;
            // 
            // ms_module
            // 
            this.ms_module.Dock = System.Windows.Forms.DockStyle.Left;
            this.ms_module.Location = new System.Drawing.Point(0, 0);
            this.ms_module.Name = "ms_module";
            this.ms_module.Size = new System.Drawing.Size(30, 284);
            this.ms_module.TabIndex = 4;
            this.ms_module.Text = "ms_module";
            // 
            // btn_einstellungen
            // 
            this.btn_einstellungen.Location = new System.Drawing.Point(4, 245);
            this.btn_einstellungen.Name = "btn_einstellungen";
            this.btn_einstellungen.Size = new System.Drawing.Size(117, 30);
            this.btn_einstellungen.TabIndex = 5;
            this.btn_einstellungen.Text = "Einstellungen";
            this.btn_einstellungen.UseVisualStyleBackColor = true;
            this.btn_einstellungen.Click += new System.EventHandler(this.btn_einstellungen_Click);
            // 
            // rechnermodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 284);
            this.Controls.Add(this.btn_einstellungen);
            this.Controls.Add(this.lb_Ergebnis);
            this.Controls.Add(this.ms_module);
            this.MainMenuStrip = this.ms_module;
            this.Name = "rechnermodul";
            this.Text = "Startfenster";
            this.Load += new System.EventHandler(this.rechnermodul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Module;
        private System.Windows.Forms.ListBox lb_Functions;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ListBox lb_Ergebnis;
        private System.Windows.Forms.MenuStrip ms_module;
        private System.Windows.Forms.Button btn_einstellungen;
    }
}

