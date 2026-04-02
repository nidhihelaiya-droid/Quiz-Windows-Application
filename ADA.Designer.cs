namespace QuizApp
{
    partial class ADA
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.DS = new System.Windows.Forms.Label();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBoxOptions.Location = new System.Drawing.Point(231, 114);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Size = new System.Drawing.Size(200, 139);
            this.groupBoxOptions.TabIndex = 13;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Enter += new System.EventHandler(this.groupBoxOptions_Enter);
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
            this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged);
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
            this.rbB.CheckedChanged += new System.EventHandler(this.rbB_CheckedChanged);
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
            this.rbC.CheckedChanged += new System.EventHandler(this.rbC_CheckedChanged);
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
            this.rbD.CheckedChanged += new System.EventHandler(this.rbD_CheckedChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(233, 95);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(46, 17);
            this.lblQuestion.TabIndex = 12;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(153, 264);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(113, 17);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "Time Left 20 sec";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(400, 294);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(191, 294);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // DS
            // 
            this.DS.AutoSize = true;
            this.DS.Location = new System.Drawing.Point(104, -54);
            this.DS.Name = "DS";
            this.DS.Size = new System.Drawing.Size(100, 17);
            this.DS.TabIndex = 6;
            this.DS.Text = "Data Structure";
            this.DS.Click += new System.EventHandler(this.DS_Click);
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Location = new System.Drawing.Point(270, 63);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(113, 17);
            this.lblQuestionNo.TabIndex = 7;
            this.lblQuestionNo.Text = "Question 1 of 10";
            this.lblQuestionNo.Click += new System.EventHandler(this.lblQuestionNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Analysis and design of Algorithm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // quizTimer
            // 
            this.quizTimer.Enabled = true;
            this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick_1);
            // 
            // ADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.DS);
            this.Controls.Add(this.lblQuestionNo);
            this.Name = "ADA";
            this.Text = "ADA";
            this.Load += new System.EventHandler(this.ADA_Load);
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
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label DS;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer quizTimer;
    }
}