namespace QuizApp
{
    partial class Registration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.cpass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirm Password";
            // 
            // signin
            // 
            this.signin.AutoSize = true;
            this.signin.Location = new System.Drawing.Point(667, 396);
            this.signin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(51, 17);
            this.signin.TabIndex = 1;
            this.signin.TabStop = true;
            this.signin.Text = "Sign In";
            this.signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signin_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(611, 372);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Already have an account?";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(429, 372);
            this.register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(100, 28);
            this.register.TabIndex = 5;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(429, 134);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 22);
            this.txtname.TabIndex = 0;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(429, 223);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(132, 22);
            this.emailtxt.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(429, 268);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(132, 22);
            this.pass.TabIndex = 3;
            this.pass.UseSystemPasswordChar = true;
            // 
            // cpass
            // 
            this.cpass.Location = new System.Drawing.Point(429, 314);
            this.cpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpass.Name = "cpass";
            this.cpass.Size = new System.Drawing.Size(132, 22);
            this.cpass.TabIndex = 4;
            this.cpass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(429, 178);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1059, 633);
            this.Controls.Add(this.register);
            this.Controls.Add(this.cpass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel signin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox cpass;
        private System.Windows.Forms.TextBox txtUsername;
    }
}