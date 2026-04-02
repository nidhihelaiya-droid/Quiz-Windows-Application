namespace QuizApp
{
    partial class DMDW
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
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizTimer
            // 
            this.quizTimer.Enabled = true;
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Location = new System.Drawing.Point(318, 92);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(113, 17);
            this.lblQuestionNo.TabIndex = 16;
            this.lblQuestionNo.Text = "Question 1 of 10";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(278, 361);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(457, 361);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(202, 315);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(113, 17);
            this.lblTimer.TabIndex = 20;
            this.lblTimer.Text = "Time Left 20 sec";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(248, 129);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(46, 17);
            this.lblQuestion.TabIndex = 21;
            this.lblQuestion.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data Mining and Data Warehouse";
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
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.rbA);
            this.groupBoxOptions.Controls.Add(this.rbB);
            this.groupBoxOptions.Controls.Add(this.rbC);
            this.groupBoxOptions.Controls.Add(this.rbD);
            this.groupBoxOptions.Location = new System.Drawing.Point(278, 160);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Size = new System.Drawing.Size(200, 139);
            this.groupBoxOptions.TabIndex = 22;
            this.groupBoxOptions.TabStop = false;
            // 
            // DMDW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 669);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestionNo);
            this.Name = "DMDW";
            this.Text = "DMDW";
            this.Load += new System.EventHandler(this.DMDW_Load_1);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer quizTimer;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.GroupBox groupBoxOptions;
    }
}