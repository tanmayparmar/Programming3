namespace _300872344_ASS_2
{
    partial class Bill_Calculator
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
            // Bill_Calculator
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Bill_Calculator";
           
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBev;
        private System.Windows.Forms.ComboBox comboBev;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.ComboBox comboAppetizer;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.ComboBox comboMain;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.ComboBox comboDes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}