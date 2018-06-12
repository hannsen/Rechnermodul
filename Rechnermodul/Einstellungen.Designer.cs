namespace Rechnermodul
{
    partial class Einstellungen
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_font = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_bgcolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_font
            // 
            this.btn_font.Location = new System.Drawing.Point(50, 27);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(137, 37);
            this.btn_font.TabIndex = 0;
            this.btn_font.Text = "Schrift wählen";
            this.btn_font.UseVisualStyleBackColor = true;
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // btn_bgcolor
            // 
            this.btn_bgcolor.Location = new System.Drawing.Point(101, 93);
            this.btn_bgcolor.Name = "btn_bgcolor";
            this.btn_bgcolor.Size = new System.Drawing.Size(110, 43);
            this.btn_bgcolor.TabIndex = 1;
            this.btn_bgcolor.Text = "Hintergrundfarbe wählen";
            this.btn_bgcolor.UseVisualStyleBackColor = true;
            this.btn_bgcolor.Click += new System.EventHandler(this.btn_bgcolor_Click);
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_bgcolor);
            this.Controls.Add(this.btn_font);
            this.Name = "Einstellungen";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_font;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_bgcolor;
    }
}