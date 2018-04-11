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
            this.components = new System.ComponentModel.Container();
            this.funktionsPanel = new System.Windows.Forms.Panel();
            this.eingabePanel = new System.Windows.Forms.Panel();
            this.numericInputButtondivision = new Rechnermodul.NumericInputButton();
            this.numericInputButtonmultiplication = new Rechnermodul.NumericInputButton();
            this.numericInputButtonminus = new Rechnermodul.NumericInputButton();
            this.numericInputButtonplus = new Rechnermodul.NumericInputButton();
            this.numericInputButton11 = new Rechnermodul.NumericInputButton();
            this.numericInputButton10 = new Rechnermodul.NumericInputButton();
            this.numericInputButton9 = new Rechnermodul.NumericInputButton();
            this.numericInputButton8 = new Rechnermodul.NumericInputButton();
            this.numericInputButton7 = new Rechnermodul.NumericInputButton();
            this.numericInputButton6 = new Rechnermodul.NumericInputButton();
            this.numericInputButton5 = new Rechnermodul.NumericInputButton();
            this.numericInputButton4 = new Rechnermodul.NumericInputButton();
            this.numericInputButton3 = new Rechnermodul.NumericInputButton();
            this.numericInputButton2 = new Rechnermodul.NumericInputButton();
            this.numericInputButton1 = new Rechnermodul.NumericInputButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.eingabePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // funktionsPanel
            // 
            this.funktionsPanel.Location = new System.Drawing.Point(15, 13);
            this.funktionsPanel.Name = "funktionsPanel";
            this.funktionsPanel.Size = new System.Drawing.Size(276, 8);
            this.funktionsPanel.TabIndex = 0;
            // 
            // eingabePanel
            // 
            this.eingabePanel.Controls.Add(this.numericInputButtondivision);
            this.eingabePanel.Controls.Add(this.numericInputButtonmultiplication);
            this.eingabePanel.Controls.Add(this.numericInputButtonminus);
            this.eingabePanel.Controls.Add(this.numericInputButtonplus);
            this.eingabePanel.Controls.Add(this.numericInputButton11);
            this.eingabePanel.Controls.Add(this.numericInputButton10);
            this.eingabePanel.Controls.Add(this.numericInputButton9);
            this.eingabePanel.Controls.Add(this.numericInputButton8);
            this.eingabePanel.Controls.Add(this.numericInputButton7);
            this.eingabePanel.Controls.Add(this.numericInputButton6);
            this.eingabePanel.Controls.Add(this.numericInputButton5);
            this.eingabePanel.Controls.Add(this.numericInputButton4);
            this.eingabePanel.Controls.Add(this.numericInputButton3);
            this.eingabePanel.Controls.Add(this.numericInputButton2);
            this.eingabePanel.Controls.Add(this.numericInputButton1);
            this.eingabePanel.Location = new System.Drawing.Point(15, 27);
            this.eingabePanel.Name = "eingabePanel";
            this.eingabePanel.Size = new System.Drawing.Size(276, 224);
            this.eingabePanel.TabIndex = 1;
            // 
            // numericInputButtondivision
            // 
            this.numericInputButtondivision.Location = new System.Drawing.Point(204, 119);
            this.numericInputButtondivision.Name = "numericInputButtondivision";
            this.numericInputButtondivision.Size = new System.Drawing.Size(61, 33);
            this.numericInputButtondivision.TabIndex = 14;
            this.numericInputButtondivision.Text = "/";
            this.numericInputButtondivision.UseVisualStyleBackColor = true;
            this.numericInputButtondivision.Click += new System.EventHandler(this.numericInputButtondivision_Click);
            // 
            // numericInputButtonmultiplication
            // 
            this.numericInputButtonmultiplication.Location = new System.Drawing.Point(137, 120);
            this.numericInputButtonmultiplication.Name = "numericInputButtonmultiplication";
            this.numericInputButtonmultiplication.Size = new System.Drawing.Size(61, 32);
            this.numericInputButtonmultiplication.TabIndex = 13;
            this.numericInputButtonmultiplication.Text = "*";
            this.numericInputButtonmultiplication.UseVisualStyleBackColor = true;
            this.numericInputButtonmultiplication.Click += new System.EventHandler(this.numericInputButtonmultiplication_Click);
            // 
            // numericInputButtonminus
            // 
            this.numericInputButtonminus.Location = new System.Drawing.Point(204, 81);
            this.numericInputButtonminus.Name = "numericInputButtonminus";
            this.numericInputButtonminus.Size = new System.Drawing.Size(60, 32);
            this.numericInputButtonminus.TabIndex = 12;
            this.numericInputButtonminus.Text = "-";
            this.numericInputButtonminus.UseVisualStyleBackColor = true;
            this.numericInputButtonminus.Click += new System.EventHandler(this.numericInputButtonminus_Click);
            // 
            // numericInputButtonplus
            // 
            this.numericInputButtonplus.Location = new System.Drawing.Point(204, 42);
            this.numericInputButtonplus.Name = "numericInputButtonplus";
            this.numericInputButtonplus.Size = new System.Drawing.Size(61, 33);
            this.numericInputButtonplus.TabIndex = 11;
            this.numericInputButtonplus.Text = "+";
            this.numericInputButtonplus.UseVisualStyleBackColor = true;
            this.numericInputButtonplus.Click += new System.EventHandler(this.numericInputButtonplus_Click);
            // 
            // numericInputButton11
            // 
            this.numericInputButton11.Location = new System.Drawing.Point(204, 3);
            this.numericInputButton11.Name = "numericInputButton11";
            this.numericInputButton11.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton11.TabIndex = 10;
            this.numericInputButton11.Text = "←\t";
            this.numericInputButton11.UseVisualStyleBackColor = true;
            this.numericInputButton11.Click += new System.EventHandler(this.numericInputButtonBackspace_Click);
            // 
            // numericInputButton10
            // 
            this.numericInputButton10.Location = new System.Drawing.Point(70, 120);
            this.numericInputButton10.Name = "numericInputButton10";
            this.numericInputButton10.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton10.TabIndex = 9;
            this.numericInputButton10.Text = "0";
            this.numericInputButton10.UseVisualStyleBackColor = true;
            this.numericInputButton10.Click += new System.EventHandler(this.numericInputButton10_Click);
            // 
            // numericInputButton9
            // 
            this.numericInputButton9.Location = new System.Drawing.Point(137, 3);
            this.numericInputButton9.Name = "numericInputButton9";
            this.numericInputButton9.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton9.TabIndex = 8;
            this.numericInputButton9.Text = "9";
            this.numericInputButton9.UseVisualStyleBackColor = true;
            this.numericInputButton9.Click += new System.EventHandler(this.numericInputButton9_Click);
            // 
            // numericInputButton8
            // 
            this.numericInputButton8.Location = new System.Drawing.Point(70, 3);
            this.numericInputButton8.Name = "numericInputButton8";
            this.numericInputButton8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericInputButton8.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton8.TabIndex = 7;
            this.numericInputButton8.Text = "8";
            this.numericInputButton8.UseVisualStyleBackColor = true;
            this.numericInputButton8.Click += new System.EventHandler(this.numericInputButton8_Click);
            // 
            // numericInputButton7
            // 
            this.numericInputButton7.Location = new System.Drawing.Point(3, 3);
            this.numericInputButton7.Name = "numericInputButton7";
            this.numericInputButton7.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton7.TabIndex = 6;
            this.numericInputButton7.Text = "7";
            this.numericInputButton7.UseVisualStyleBackColor = true;
            this.numericInputButton7.Click += new System.EventHandler(this.numericInputButton7_Click);
            // 
            // numericInputButton6
            // 
            this.numericInputButton6.Location = new System.Drawing.Point(137, 42);
            this.numericInputButton6.Name = "numericInputButton6";
            this.numericInputButton6.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton6.TabIndex = 5;
            this.numericInputButton6.Text = "6";
            this.numericInputButton6.UseVisualStyleBackColor = true;
            this.numericInputButton6.Click += new System.EventHandler(this.numericInputButton6_Click);
            // 
            // numericInputButton5
            // 
            this.numericInputButton5.Location = new System.Drawing.Point(70, 42);
            this.numericInputButton5.Name = "numericInputButton5";
            this.numericInputButton5.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton5.TabIndex = 4;
            this.numericInputButton5.Text = "5";
            this.numericInputButton5.UseVisualStyleBackColor = true;
            this.numericInputButton5.Click += new System.EventHandler(this.numericInputButton5_Click);
            // 
            // numericInputButton4
            // 
            this.numericInputButton4.Location = new System.Drawing.Point(3, 42);
            this.numericInputButton4.Name = "numericInputButton4";
            this.numericInputButton4.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton4.TabIndex = 3;
            this.numericInputButton4.Text = "4";
            this.numericInputButton4.UseVisualStyleBackColor = true;
            this.numericInputButton4.Click += new System.EventHandler(this.numericInputButton4_Click);
            // 
            // numericInputButton3
            // 
            this.numericInputButton3.Location = new System.Drawing.Point(137, 81);
            this.numericInputButton3.Name = "numericInputButton3";
            this.numericInputButton3.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton3.TabIndex = 2;
            this.numericInputButton3.Text = "3";
            this.numericInputButton3.UseVisualStyleBackColor = true;
            this.numericInputButton3.Click += new System.EventHandler(this.numericInputButton3_Click);
            // 
            // numericInputButton2
            // 
            this.numericInputButton2.Location = new System.Drawing.Point(70, 81);
            this.numericInputButton2.Name = "numericInputButton2";
            this.numericInputButton2.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton2.TabIndex = 1;
            this.numericInputButton2.Text = "2";
            this.numericInputButton2.UseVisualStyleBackColor = true;
            this.numericInputButton2.Click += new System.EventHandler(this.numericInputButton2_Click);
            // 
            // numericInputButton1
            // 
            this.numericInputButton1.Location = new System.Drawing.Point(3, 81);
            this.numericInputButton1.Name = "numericInputButton1";
            this.numericInputButton1.Size = new System.Drawing.Size(61, 33);
            this.numericInputButton1.TabIndex = 0;
            this.numericInputButton1.Text = "1";
            this.numericInputButton1.UseVisualStyleBackColor = true;
            this.numericInputButton1.Click += new System.EventHandler(this.numericInputButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // universelleseingabemodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 262);
            this.Controls.Add(this.eingabePanel);
            this.Controls.Add(this.funktionsPanel);
            this.Name = "universelleseingabemodul";
            this.Text = "UniversellesEingabeModul";
            this.eingabePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel funktionsPanel;
        private System.Windows.Forms.Panel eingabePanel;
        private NumericInputButton numericInputButton1;
        private NumericInputButton numericInputButton2;
        private NumericInputButton numericInputButton3;
        private NumericInputButton numericInputButton10;
        private NumericInputButton numericInputButton9;
        private NumericInputButton numericInputButton8;
        private NumericInputButton numericInputButton7;
        private NumericInputButton numericInputButton6;
        private NumericInputButton numericInputButton5;
        private NumericInputButton numericInputButton4;
        private NumericInputButton numericInputButton11;
        private NumericInputButton numericInputButtonplus;
        private NumericInputButton numericInputButtonminus;
        private NumericInputButton numericInputButtonmultiplication;
        private NumericInputButton numericInputButtondivision;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}