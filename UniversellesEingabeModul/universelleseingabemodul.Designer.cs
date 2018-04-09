namespace UniversellesEingabeModul
{
    partial class universelleseingabemodul
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.eingabePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 29);
            this.panel1.TabIndex = 0;
            // 
            // eingabePanel
            // 
            this.eingabePanel.Location = new System.Drawing.Point(9, 47);
            this.eingabePanel.Name = "eingabePanel";
            this.eingabePanel.Size = new System.Drawing.Size(261, 212);
            this.eingabePanel.TabIndex = 1;
            // 
            // universelleseingabemodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 341);
            this.Controls.Add(this.eingabePanel);
            this.Controls.Add(this.panel1);
            this.Name = "universelleseingabemodul";
            this.Text = "UniversellesEingabeModul";
            this.Load += new System.EventHandler(this.universelleseingabemodul_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel eingabePanel;
    }
}

