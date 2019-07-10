namespace Ferris_Directory_Scanner
{
    partial class NewMainForm
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
            this.scanControl1 = new Ferris_Directory_Scanner.ScanControl();
            this.SuspendLayout();
            // 
            // scanControl1
            // 
            this.scanControl1.Location = new System.Drawing.Point(99, 109);
            this.scanControl1.Name = "scanControl1";
            this.scanControl1.Size = new System.Drawing.Size(501, 389);
            this.scanControl1.TabIndex = 0;
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 569);
            this.Controls.Add(this.scanControl1);
            this.Name = "NewMainForm";
            this.Text = "NewMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ScanControl scanControl1;
    }
}