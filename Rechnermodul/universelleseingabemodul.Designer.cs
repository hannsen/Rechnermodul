namespace Rechnermodul
{
    partial class universelleseingabemodul
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
            this.funktionsPanel = new System.Windows.Forms.Panel();
            this.eingabePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // funktionsPanel
            // 
            this.funktionsPanel.Location = new System.Drawing.Point(15, 13);
            this.funktionsPanel.Name = "funktionsPanel";
            this.funktionsPanel.Size = new System.Drawing.Size(257, 8);
            this.funktionsPanel.TabIndex = 0;
            // 
            // eingabePanel
            // 
            this.eingabePanel.Location = new System.Drawing.Point(15, 34);
            this.eingabePanel.Name = "eingabePanel";
            this.eingabePanel.Size = new System.Drawing.Size(257, 217);
            this.eingabePanel.TabIndex = 1;
            // 
            // universelleseingabemodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.eingabePanel);
            this.Controls.Add(this.funktionsPanel);
            this.Name = "universelleseingabemodul";
            this.Text = "UniversellesEingabeModul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel funktionsPanel;
        private System.Windows.Forms.Panel eingabePanel;
    }
}