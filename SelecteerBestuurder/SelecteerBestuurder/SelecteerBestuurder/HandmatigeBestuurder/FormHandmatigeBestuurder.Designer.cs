﻿namespace SelecteerBestuurder
{
    partial class FormHandmatigeBestuurder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.cbTestCar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gebruik de volgende toetsen om de auto te besturen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "W = Vooruit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "A = Links";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "S = Achteruit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "D = Rechts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Spatie = Coördinaten opslaan";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(15, 101);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(143, 23);
            this.btnTerug.TabIndex = 6;
            this.btnTerug.Text = "Ga terug naar menu";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            this.btnTerug.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandmatigeBestuurder_KeyDown);
            this.btnTerug.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandmatigeBestuurder_KeyUp);
            // 
            // cbTestCar
            // 
            this.cbTestCar.AutoSize = true;
            this.cbTestCar.Location = new System.Drawing.Point(195, 107);
            this.cbTestCar.Name = "cbTestCar";
            this.cbTestCar.Size = new System.Drawing.Size(72, 17);
            this.cbTestCar.TabIndex = 7;
            this.cbTestCar.Text = "Test Car?";
            this.cbTestCar.UseVisualStyleBackColor = true;
            this.cbTestCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandmatigeBestuurder_KeyDown);
            this.cbTestCar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandmatigeBestuurder_KeyUp);
            // 
            // FormHandmatigeBestuurder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 132);
            this.Controls.Add(this.cbTestCar);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHandmatigeBestuurder";
            this.Text = "HandmatigeBestuurder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandmatigeBestuurder_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandmatigeBestuurder_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.CheckBox cbTestCar;
    }
}