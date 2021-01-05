
namespace SelecteerBestuurder
{
    partial class FormTestCar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTerugRealCar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "W = TestVooruit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "A = TestLinks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "S = TestAchteruit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "D = TestRechts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Spatie = TestCoördinaten opslaan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gebruik de volgende toetsen om de auto te besturen:";
            // 
            // btnTerugRealCar
            // 
            this.btnTerugRealCar.Location = new System.Drawing.Point(4, 120);
            this.btnTerugRealCar.Name = "btnTerugRealCar";
            this.btnTerugRealCar.Size = new System.Drawing.Size(143, 23);
            this.btnTerugRealCar.TabIndex = 8;
            this.btnTerugRealCar.Text = "Ga terug naar RealCar";
            this.btnTerugRealCar.UseVisualStyleBackColor = true;
            this.btnTerugRealCar.Click += new System.EventHandler(this.btnTerugRealCar_Click_1);
            this.btnTerugRealCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTestCar_KeyDown);
            this.btnTerugRealCar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormTestCar_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dit formulier is om te testen het laat geen auto rijden";
            // 
            // FormTestCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 150);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTerugRealCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormTestCar";
            this.Text = "FormTestCar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTestCar_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormTestCar_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerugRealCar;
        private System.Windows.Forms.Label label7;
    }
}