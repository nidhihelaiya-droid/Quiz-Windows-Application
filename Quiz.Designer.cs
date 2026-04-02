namespace QuizApp
{
    partial class Quiz
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DS = new System.Windows.Forms.Button();
            this.net = new System.Windows.Forms.Button();
            this.ada = new System.Windows.Forms.Button();
            this.DMDW = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.Button();
            this.AI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "     "});
            this.listBox1.Location = new System.Drawing.Point(233, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(94)))), ((int)(((byte)(194)))));
            this.DS.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DS.Location = new System.Drawing.Point(253, 159);
            this.DS.Name = "DS";
            this.DS.Size = new System.Drawing.Size(165, 95);
            this.DS.TabIndex = 1;
            this.DS.Text = "Data Structure";
            this.DS.UseVisualStyleBackColor = false;
            this.DS.Click += new System.EventHandler(this.DS_Click);
            // 
            // net
            // 
            this.net.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(93)))), ((int)(((byte)(177)))));
            this.net.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.net.Location = new System.Drawing.Point(424, 159);
            this.net.Name = "net";
            this.net.Size = new System.Drawing.Size(162, 95);
            this.net.TabIndex = 1;
            this.net.Text = ".Net";
            this.net.UseVisualStyleBackColor = false;
            this.net.Click += new System.EventHandler(this.net_Click);
            // 
            // ada
            // 
            this.ada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(145)))));
            this.ada.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ada.Location = new System.Drawing.Point(253, 259);
            this.ada.Name = "ada";
            this.ada.Size = new System.Drawing.Size(165, 103);
            this.ada.TabIndex = 1;
            this.ada.Text = "Analysis and Design of Algorithm";
            this.ada.UseVisualStyleBackColor = false;
            this.ada.Click += new System.EventHandler(this.ada_Click);
            // 
            // DMDW
            // 
            this.DMDW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(95)))));
            this.DMDW.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMDW.Location = new System.Drawing.Point(253, 368);
            this.DMDW.Name = "DMDW";
            this.DMDW.Size = new System.Drawing.Size(165, 99);
            this.DMDW.TabIndex = 1;
            this.DMDW.Text = "Data Mining And Data Warehouse";
            this.DMDW.UseVisualStyleBackColor = false;
            this.DMDW.Click += new System.EventHandler(this.DMDW_Click);
            // 
            // CC
            // 
            this.CC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(113)))));
            this.CC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC.Location = new System.Drawing.Point(424, 368);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(162, 99);
            this.CC.TabIndex = 1;
            this.CC.Text = "Cloud Computing";
            this.CC.UseVisualStyleBackColor = false;
            this.CC.Click += new System.EventHandler(this.CC_Click);
            // 
            // AI
            // 
            this.AI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(113)))));
            this.AI.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AI.Location = new System.Drawing.Point(424, 260);
            this.AI.Name = "AI";
            this.AI.Size = new System.Drawing.Size(162, 102);
            this.AI.TabIndex = 1;
            this.AI.Text = "Artifical Intelligence";
            this.AI.UseVisualStyleBackColor = false;
            this.AI.Click += new System.EventHandler(this.AI_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 643);
            this.Controls.Add(this.net);
            this.Controls.Add(this.AI);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.DMDW);
            this.Controls.Add(this.ada);
            this.Controls.Add(this.DS);
            this.Controls.Add(this.listBox1);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DS;
        private System.Windows.Forms.Button net;
        private System.Windows.Forms.Button ada;
        private System.Windows.Forms.Button DMDW;
        private System.Windows.Forms.Button CC;
        private System.Windows.Forms.Button AI;
    }
}