namespace Factorials
{
    partial class FrmFactorials
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LstFactorials = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(283, 60);
            this.BtnGenerate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(309, 74);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate Factorials";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LstFactorials
            // 
            this.LstFactorials.FormattingEnabled = true;
            this.LstFactorials.ItemHeight = 31;
            this.LstFactorials.Location = new System.Drawing.Point(164, 177);
            this.LstFactorials.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LstFactorials.Name = "LstFactorials";
            this.LstFactorials.Size = new System.Drawing.Size(551, 438);
            this.LstFactorials.TabIndex = 1;
            // 
            // FrmFactorials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 934);
            this.Controls.Add(this.LstFactorials);
            this.Controls.Add(this.BtnGenerate);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmFactorials";
            this.Text = "Recursive Factorials";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ListBox LstFactorials;
    }
}

