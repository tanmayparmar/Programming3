namespace COMP212_Assignment1
{
    partial class ManagePublishForm
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
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(167, 51);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(100, 20);
            this.txtMsg.TabIndex = 1;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(42, 93);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(97, 34);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "Publish\r\n";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagePublishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 157);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label1);
            this.Name = "ManagePublishForm";
            this.Text = "Publish Notitification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Button btnExit;
    }
}