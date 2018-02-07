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
            this.lb_Module = new System.Windows.Forms.ListBox();
            this.lb_Functions = new System.Windows.Forms.ListBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_Ergebnis = new System.Windows.Forms.ListBox();
            this.ms_module = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // lb_Module
            // 
            this.lb_Module.FormattingEnabled = true;
            this.lb_Module.Location = new System.Drawing.Point(118, 6);
            this.lb_Module.Name = "lb_Module";
            this.lb_Module.Size = new System.Drawing.Size(98, 134);
            this.lb_Module.TabIndex = 0;
            this.lb_Module.SelectedIndexChanged += new System.EventHandler(this.lb_Module_SelectedIndexChanged);
            // 
            // lb_Functions
            // 
            this.lb_Functions.FormattingEnabled = true;
            this.lb_Functions.Location = new System.Drawing.Point(112, 146);
            this.lb_Functions.Name = "lb_Functions";
            this.lb_Functions.Size = new System.Drawing.Size(104, 134);
            this.lb_Functions.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(222, 29);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(103, 36);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Starten";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_Ergebnis
            // 
            this.lb_Ergebnis.FormattingEnabled = true;
            this.lb_Ergebnis.Location = new System.Drawing.Point(358, 10);
            this.lb_Ergebnis.Name = "lb_Ergebnis";
            this.lb_Ergebnis.Size = new System.Drawing.Size(118, 121);
            this.lb_Ergebnis.TabIndex = 3;
            // 
            // ms_module
            // 
            this.ms_module.Dock = System.Windows.Forms.DockStyle.Left;
            this.ms_module.Location = new System.Drawing.Point(0, 0);
            this.ms_module.Name = "ms_module";
            this.ms_module.Size = new System.Drawing.Size(30, 281);
            this.ms_module.TabIndex = 4;
            this.ms_module.Text = "ms_module";
            // 
            // rechnermodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 281);
            this.Controls.Add(this.lb_Ergebnis);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_Functions);
            this.Controls.Add(this.lb_Module);
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
    }
}

