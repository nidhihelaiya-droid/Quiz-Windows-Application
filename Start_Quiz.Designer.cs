namespace QuizApp
{
    partial class Start_Quiz
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
            this.quizapp_label = new System.Windows.Forms.Label();
            this.testlabel = new System.Windows.Forms.Label();
            this.desp_label1 = new System.Windows.Forms.Label();
            this.startquiz_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quizapp_label
            // 
            this.quizapp_label.AutoSize = true;
            this.quizapp_label.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizapp_label.Location = new System.Drawing.Point(324, 30);
            this.quizapp_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quizapp_label.Name = "quizapp_label";
            this.quizapp_label.Size = new System.Drawing.Size(254, 36);
            this.quizapp_label.TabIndex = 0;
            this.quizapp_label.Text = "Quiz Master";
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testlabel.Location = new System.Drawing.Point(377, 80);
            this.testlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(166, 20);
            this.testlabel.TabIndex = 1;
            this.testlabel.Text = "Test Your Knowledge!";
            // 
            // desp_label1
            // 
            this.desp_label1.AutoSize = true;
            this.desp_label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desp_label1.Location = new System.Drawing.Point(337, 132);
            this.desp_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desp_label1.Name = "desp_label1";
            this.desp_label1.Size = new System.Drawing.Size(260, 20);
            this.desp_label1.TabIndex = 2;
            this.desp_label1.Text = "Ready to begin your quiz journey? ";
            // 
            // startquiz_button
            // 
            this.startquiz_button.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startquiz_button.Location = new System.Drawing.Point(417, 185);
            this.startquiz_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startquiz_button.Name = "startquiz_button";
            this.startquiz_button.Size = new System.Drawing.Size(100, 32);
            this.startquiz_button.TabIndex = 3;
            this.startquiz_button.Text = "Start Quiz";
            this.startquiz_button.UseVisualStyleBackColor = true;
            this.startquiz_button.Click += new System.EventHandler(this.startquiz_button_Click);
            // 
            // Start_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 558);
            this.Controls.Add(this.startquiz_button);
            this.Controls.Add(this.desp_label1);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.quizapp_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Start_Quiz";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Start_Quiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quizapp_label;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.Label desp_label1;
        private System.Windows.Forms.Button startquiz_button;
    }
}

