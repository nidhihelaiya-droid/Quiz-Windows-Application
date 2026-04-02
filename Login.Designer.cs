namespace QuizApp
{
    partial class Login
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
            this.u_id = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.uid_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // u_id
            // 
            this.u_id.AutoSize = true;
            this.u_id.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_id.Location = new System.Drawing.Point(76, 117);
            this.u_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.u_id.Name = "u_id";
            this.u_id.Size = new System.Drawing.Size(89, 20);
            this.u_id.TabIndex = 0;
            this.u_id.Text = "Username :";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(76, 170);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(87, 20);
            this.pass.TabIndex = 0;
            this.pass.Text = "Password :";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(213, 33);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(128, 36);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login";
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(205, 167);
            this.pass_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(132, 22);
            this.pass_text.TabIndex = 1;
            this.pass_text.UseSystemPasswordChar = true;
            // 
            // uid_text
            // 
            this.uid_text.Location = new System.Drawing.Point(205, 111);
            this.uid_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uid_text.Name = "uid_text";
            this.uid_text.Size = new System.Drawing.Size(132, 22);
            this.uid_text.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(228, 229);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 28);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.uid_text);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.u_id);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label u_id;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox uid_text;
        private System.Windows.Forms.Button login_button;
    }
}