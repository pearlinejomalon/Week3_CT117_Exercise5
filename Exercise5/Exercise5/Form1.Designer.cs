namespace Exercise5
{
    partial class ApproximatePiForm
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
            this.SuspendLayout();
            // 
            // ApproximatePiForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "ApproximatePiForm";
            this.Load += new System.EventHandler(this.ApproximatePiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox txtPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClose;
    }
}

