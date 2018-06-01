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
            this.tb_param = new System.Windows.Forms.TextBox();
            this.lb_param_name = new System.Windows.Forms.Label();
            this.eingabePanel = new System.Windows.Forms.Panel();
            this.btn_next_param = new System.Windows.Forms.Button();
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel_array = new System.Windows.Forms.Panel();
            this.btn_next_value = new System.Windows.Forms.Button();
            this.btn_nebenrechnug = new System.Windows.Forms.Button();
            this.funktionsPanel.SuspendLayout();
            this.eingabePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel_array.SuspendLayout();
            this.SuspendLayout();
            // 
            // funktionsPanel
            // 
            this.funktionsPanel.Controls.Add(this.tb_param);
            this.funktionsPanel.Controls.Add(this.lb_param_name);
            this.funktionsPanel.Location = new System.Drawing.Point(12, 13);
            this.funktionsPanel.Name = "funktionsPanel";
            this.funktionsPanel.Size = new System.Drawing.Size(279, 69);
            this.funktionsPanel.TabIndex = 0;
            // 
            // tb_param
            // 
            this.tb_param.Location = new System.Drawing.Point(3, 37);
            this.tb_param.Name = "tb_param";
            this.tb_param.Size = new System.Drawing.Size(259, 20);
            this.tb_param.TabIndex = 1;
            // 
            // lb_param_name
            // 
            this.lb_param_name.AutoSize = true;
            this.lb_param_name.Location = new System.Drawing.Point(0, 9);
            this.lb_param_name.Name = "lb_param_name";
            this.lb_param_name.Size = new System.Drawing.Size(82, 13);
            this.lb_param_name.TabIndex = 0;
            this.lb_param_name.Text = "lb_param_name";
            // 
            // eingabePanel
            // 
            this.eingabePanel.Controls.Add(this.btn_nebenrechnug);
            this.eingabePanel.Controls.Add(this.btn_next_param);
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
            this.eingabePanel.Location = new System.Drawing.Point(12, 128);
            this.eingabePanel.Name = "eingabePanel";
            this.eingabePanel.Size = new System.Drawing.Size(276, 210);
            this.eingabePanel.TabIndex = 1;
            // 
            // btn_next_param
            // 
            this.btn_next_param.Location = new System.Drawing.Point(137, 163);
            this.btn_next_param.Name = "btn_next_param";
            this.btn_next_param.Size = new System.Drawing.Size(127, 36);
            this.btn_next_param.TabIndex = 15;
            this.btn_next_param.Text = "Nächster Parameter";
            this.btn_next_param.UseVisualStyleBackColor = true;
            this.btn_next_param.Click += new System.EventHandler(this.btn_next_param_Click);
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
            // panel_array
            // 
            this.panel_array.Controls.Add(this.btn_next_value);
            this.panel_array.Location = new System.Drawing.Point(12, 89);
            this.panel_array.Name = "panel_array";
            this.panel_array.Size = new System.Drawing.Size(278, 39);
            this.panel_array.TabIndex = 2;
            // 
            // btn_next_value
            // 
            this.btn_next_value.Location = new System.Drawing.Point(137, 3);
            this.btn_next_value.Name = "btn_next_value";
            this.btn_next_value.Size = new System.Drawing.Size(127, 30);
            this.btn_next_value.TabIndex = 1;
            this.btn_next_value.Text = "Nächster Wert";
            this.btn_next_value.UseVisualStyleBackColor = true;
            this.btn_next_value.Click += new System.EventHandler(this.btn_next_value_Click);
            // 
            // btn_nebenrechnug
            // 
            this.btn_nebenrechnug.Location = new System.Drawing.Point(3, 163);
            this.btn_nebenrechnug.Name = "btn_nebenrechnug";
            this.btn_nebenrechnug.Size = new System.Drawing.Size(128, 35);
            this.btn_nebenrechnug.TabIndex = 16;
            this.btn_nebenrechnug.Text = "Nebenrechnung";
            this.btn_nebenrechnug.UseVisualStyleBackColor = true;
            this.btn_nebenrechnug.Click += new System.EventHandler(this.btn_nebenrechnug_Click);
            // 
            // universelleseingabemodul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 341);
            this.Controls.Add(this.panel_array);
            this.Controls.Add(this.eingabePanel);
            this.Controls.Add(this.funktionsPanel);
            this.Name = "universelleseingabemodul";
            this.Text = "UniversellesEingabeModul";
            this.funktionsPanel.ResumeLayout(false);
            this.funktionsPanel.PerformLayout();
            this.eingabePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel_array.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tb_param;
        private System.Windows.Forms.Label lb_param_name;
        private System.Windows.Forms.Button btn_next_param;
        private System.Windows.Forms.Panel panel_array;
        private System.Windows.Forms.Button btn_next_value;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btn_nebenrechnug;
    }
}