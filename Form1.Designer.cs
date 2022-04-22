namespace Testing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.usernameinputtext = new Testing.UserControl1();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordinputtext = new Testing.UserControl1();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // usernameinputtext
            // 
            this.usernameinputtext.BorderColor = System.Drawing.Color.Black;
            this.usernameinputtext.BorderFocusColor = System.Drawing.Color.Black;
            this.usernameinputtext.BorderRadius = 15;
            this.usernameinputtext.BorderSize = 1;
            this.usernameinputtext.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameinputtext.Location = new System.Drawing.Point(120, 41);
            this.usernameinputtext.Margin = new System.Windows.Forms.Padding(4);
            this.usernameinputtext.Multiline = false;
            this.usernameinputtext.Name = "usernameinputtext";
            this.usernameinputtext.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.usernameinputtext.PasswordChar = false;
            this.usernameinputtext.PlaceholderColor = System.Drawing.Color.DimGray;
            this.usernameinputtext.PlaceholderText = "Username here";
            this.usernameinputtext.Size = new System.Drawing.Size(198, 36);
            this.usernameinputtext.TabIndex = 2;
            this.usernameinputtext.Texts = "";
            this.usernameinputtext.UnderlinedStyle = false;
            this.usernameinputtext._TextChanged += new System.EventHandler(this.usernameinputtext__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // passwordinputtext
            // 
            this.passwordinputtext.BorderColor = System.Drawing.Color.Black;
            this.passwordinputtext.BorderFocusColor = System.Drawing.Color.Black;
            this.passwordinputtext.BorderRadius = 15;
            this.passwordinputtext.BorderSize = 1;
            this.passwordinputtext.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordinputtext.Location = new System.Drawing.Point(120, 98);
            this.passwordinputtext.Margin = new System.Windows.Forms.Padding(4);
            this.passwordinputtext.Multiline = false;
            this.passwordinputtext.Name = "passwordinputtext";
            this.passwordinputtext.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordinputtext.PasswordChar = true;
            this.passwordinputtext.PlaceholderColor = System.Drawing.Color.Gray;
            this.passwordinputtext.PlaceholderText = "Password here";
            this.passwordinputtext.Size = new System.Drawing.Size(198, 36);
            this.passwordinputtext.TabIndex = 2;
            this.passwordinputtext.Texts = "";
            this.passwordinputtext.UnderlinedStyle = false;
            this.passwordinputtext._TextChanged += new System.EventHandler(this.usernameinputtext__TextChanged);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(194, 169);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(94, 29);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 228);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordinputtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameinputtext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private UserControl1 usernameinputtext;
        private Label label2;
        private UserControl1 passwordinputtext;
        private Button loginbutton;
    }
}