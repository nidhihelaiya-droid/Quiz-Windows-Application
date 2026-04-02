namespace QuizApp
{
    partial class Data_Structure
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
            this.components = new System.ComponentModel.Container();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.DS = new System.Windows.Forms.Label();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Location = new System.Drawing.Point(211, 89);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(113, 17);
            this.lblQuestionNo.TabIndex = 0;
            this.lblQuestionNo.Text = "Question 1 of 10";
            // 
            // DS
            // 
            this.DS.AutoSize = true;
            this.DS.Location = new System.Drawing.Point(211, 37);
            this.DS.Name = "DS";
            this.DS.Size = new System.Drawing.Size(100, 17);
            this.DS.TabIndex = 0;
            this.DS.Text = "Data Structure";
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(5, 21);
            this.rbA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(84, 21);
            this.rbA.TabIndex = 1;
            this.rbA.TabStop = true;
            this.rbA.Text = "Option A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(5, 48);
            this.rbB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(84, 21);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "Option B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(5, 75);
            this.rbC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(84, 21);
            this.rbC.TabIndex = 1;
            this.rbC.TabStop = true;
            this.rbC.Text = "Option C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(5, 102);
            this.rbD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(85, 21);
            this.rbD.TabIndex = 1;
            this.rbD.TabStop = true;
            this.rbD.Text = "Option D";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(127, 374);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(341, 374);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(109, 332);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(113, 17);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Time Left 20 sec";
            // 
            // quizTimer
            // 
            this.quizTimer.Enabled = true;
            this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick_1);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(109, 121);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(46, 17);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "label1";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.rbA);
            this.groupBoxOptions.Controls.Add(this.rbB);
            this.groupBoxOptions.Controls.Add(this.rbC);
            this.groupBoxOptions.Controls.Add(this.rbD);
            this.groupBoxOptions.Location = new System.Drawing.Point(112, 161);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Size = new System.Drawing.Size(200, 139);
            this.groupBoxOptions.TabIndex = 5;
            this.groupBoxOptions.TabStop = false;
            // 
            // Data_Structure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 583);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.DS);
            this.Controls.Add(this.lblQuestionNo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Data_Structure";
            this.Text = "Data_Structure";
            this.Load += new System.EventHandler(this.Data_Structure_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label DS;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer quizTimer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupBoxOptions;
    }
}