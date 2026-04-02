namespace QuizApp
{
    partial class CC
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
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.rbA);
            this.groupBoxOptions.Controls.Add(this.rbB);
            this.groupBoxOptions.Controls.Add(this.rbC);
            this.groupBoxOptions.Controls.Add(this.rbD);
            this.groupBoxOptions.Location = new System.Drawing.Point(113, 191);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Size = new System.Drawing.Size(200, 139);
            this.groupBoxOptions.TabIndex = 30;
            this.groupBoxOptions.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "CLOUD COMPUTING";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(135, 172);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(46, 17);
            this.lblQuestion.TabIndex = 29;
            this.lblQuestion.Text = "label1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(42, 346);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(113, 17);
            this.lblTimer.TabIndex = 28;
            this.lblTimer.Text = "Time Left 20 sec";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(331, 389);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(94, 389);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Location = new System.Drawing.Point(182, 129);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(113, 17);
            this.lblQuestionNo.TabIndex = 24;
            this.lblQuestionNo.Text = "Question 1 of 10";
            // 
            // quizTimer
            // 
            this.quizTimer.Enabled = true;
            // 
            // CC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 476);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestionNo);
            this.Name = "CC";
            this.Text = "CC";
            this.Load += new System.EventHandler(this.CC_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Timer quizTimer;
    }
}