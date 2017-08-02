namespace COMP212_Assignment1
{
    partial class ManageSub
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
            this.checkboxEmail = new System.Windows.Forms.CheckBox();
            this.checkboxPhone = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btn_Unsubscribe = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkboxEmail
            // 
            this.checkboxEmail.AutoSize = true;
            this.checkboxEmail.Location = new System.Drawing.Point(41, 36);
            this.checkboxEmail.Name = "checkboxEmail";
            this.checkboxEmail.Size = new System.Drawing.Size(137, 17);
            this.checkboxEmail.TabIndex = 0;
            this.checkboxEmail.Text = "Message Sent By Email";
            this.checkboxEmail.UseVisualStyleBackColor = true;
            this.checkboxEmail.CheckedChanged += new System.EventHandler(this.sentByEmail_CheckedChanged);
            // 
            // checkboxPhone
            // 
            this.checkboxPhone.AutoSize = true;
            this.checkboxPhone.Location = new System.Drawing.Point(41, 69);
            this.checkboxPhone.Name = "checkboxPhone";
            this.checkboxPhone.Size = new System.Drawing.Size(143, 17);
            this.checkboxPhone.TabIndex = 1;
            this.checkboxPhone.Text = "Message Sent By Phone";
            this.checkboxPhone.UseVisualStyleBackColor = true;
            this.checkboxPhone.CheckedChanged += new System.EventHandler(this.sentByPhone_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(209, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(209, 69);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "xxx-xxx-xxxx";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(42, 129);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 4;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btn_Unsubscribe
            // 
            this.btn_Unsubscribe.Location = new System.Drawing.Point(207, 129);
            this.btn_Unsubscribe.Name = "btn_Unsubscribe";
            this.btn_Unsubscribe.Size = new System.Drawing.Size(81, 23);
            this.btn_Unsubscribe.TabIndex = 5;
            this.btn_Unsubscribe.Text = "UnSubscribe";
            this.btn_Unsubscribe.UseVisualStyleBackColor = true;
            this.btn_Unsubscribe.Click += new System.EventHandler(this.btn_Unsubscribe_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ManageSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 172);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Unsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.checkboxPhone);
            this.Controls.Add(this.checkboxEmail);
            this.Name = "ManageSub";
            this.Text = "Manage Subscription";
            this.Load += new System.EventHandler(this.ManageSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxEmail;
        private System.Windows.Forms.CheckBox checkboxPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btn_Unsubscribe;
        private System.Windows.Forms.Button button3;
    }
}