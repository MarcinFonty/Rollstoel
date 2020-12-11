namespace SelecteerBestuurder
{
    partial class FormSelecteerBestuurder
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
            this.btnHandmatig = new System.Windows.Forms.Button();
            this.btnAutonoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHandmatig
            // 
            this.btnHandmatig.Location = new System.Drawing.Point(15, 25);
            this.btnHandmatig.Name = "btnHandmatig";
            this.btnHandmatig.Size = new System.Drawing.Size(125, 23);
            this.btnHandmatig.TabIndex = 0;
            this.btnHandmatig.Text = "Handmatige Besturing";
            this.btnHandmatig.UseVisualStyleBackColor = true;
            this.btnHandmatig.Click += new System.EventHandler(this.btnHandmatig_Click);
            // 
            // btnAutonoom
            // 
            this.btnAutonoom.Location = new System.Drawing.Point(15, 54);
            this.btnAutonoom.Name = "btnAutonoom";
            this.btnAutonoom.Size = new System.Drawing.Size(125, 23);
            this.btnAutonoom.TabIndex = 1;
            this.btnAutonoom.Text = "Autonome Besturing";
            this.btnAutonoom.UseVisualStyleBackColor = true;
            this.btnAutonoom.Click += new System.EventHandler(this.btnAutonoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoe wil je de auto besturen?";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 83);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSelecteerBestuurder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 118);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutonoom);
            this.Controls.Add(this.btnHandmatig);
            this.Name = "FormSelecteerBestuurder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHandmatig;
        private System.Windows.Forms.Button btnAutonoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}

