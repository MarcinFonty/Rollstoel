namespace SelecteerBestuurder
{
    partial class FormAutonomeBestuurder
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
            this.cbSelecteerRoute = new System.Windows.Forms.ComboBox();
            this.btnStartRoute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSelecteerRoute
            // 
            this.cbSelecteerRoute.FormattingEnabled = true;
            this.cbSelecteerRoute.Location = new System.Drawing.Point(16, 29);
            this.cbSelecteerRoute.Name = "cbSelecteerRoute";
            this.cbSelecteerRoute.Size = new System.Drawing.Size(150, 21);
            this.cbSelecteerRoute.TabIndex = 0;
            // 
            // btnStartRoute
            // 
            this.btnStartRoute.Location = new System.Drawing.Point(16, 56);
            this.btnStartRoute.Name = "btnStartRoute";
            this.btnStartRoute.Size = new System.Drawing.Size(150, 23);
            this.btnStartRoute.TabIndex = 1;
            this.btnStartRoute.Text = "Start route";
            this.btnStartRoute.UseVisualStyleBackColor = true;
            this.btnStartRoute.Click += new System.EventHandler(this.btnStartRoute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kies de route die je wilt volgen:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(16, 85);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Ga terug naar menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormAutonomeBestuurder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 117);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartRoute);
            this.Controls.Add(this.cbSelecteerRoute);
            this.Name = "FormAutonomeBestuurder";
            this.Text = "AutonomeBestuurder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelecteerRoute;
        private System.Windows.Forms.Button btnStartRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
    }
}