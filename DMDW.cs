using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class DMDW : Form
    {
        int currentQuestion = 0;
        int score = 0;
        int timeLeft = 20;

        string[,] questions =
{
    {"Data mining is used to?", "Store data", "Analyze patterns", "Delete data", "Transfer data", "B"},
    {"Which technique is used for grouping data?", "Classification", "Clustering", "Regression", "Sorting", "B"},
    {"Data warehouse is mainly used for?", "Transaction processing", "Data analysis", "Data entry", "Data deletion", "B"},
    {"ETL stands for?", "Extract Transform Load", "Enter Transfer Load", "Extract Transfer Link", "Enter Transform Link", "A"},
    {"Which algorithm is used in classification?", "Decision Tree", "Bubble Sort", "Binary Search", "DFS", "A"},
    {"Association rule mining uses?", "Apriori Algorithm", "Merge Sort", "Prim", "Kruskal", "A"},
    {"Which database is optimized for analysis?", "Data Warehouse", "OLTP", "File System", "Spreadsheet", "A"},
    {"OLAP stands for?", "Online Analytical Processing", "Online Algorithm Processing", "Offline Analytical Program", "Online Access Program", "A"},
    {"Which technique predicts numeric values?", "Classification", "Regression", "Clustering", "Association", "B"},
    {"Which tool is used for big data analysis?", "Hadoop", "Photoshop", "Excel", "Word", "A"}
};

        string[] selectedAnswers = new string[10];
        public DMDW()
        {
            InitializeComponent();
        }

        private void DMDW_Load(object sender, EventArgs e)
        {
        }

        void DisplayQuestion()
        {
            lblQuestionNo.Text = $"Question {currentQuestion + 1} of 10";
            lblQuestion.Text = questions[currentQuestion, 0];

            rbA.Text = questions[currentQuestion, 1];
            rbB.Text = questions[currentQuestion, 2];
            rbC.Text = questions[currentQuestion, 3];
            rbD.Text = questions[currentQuestion, 4];

            // Clear previous selection
            groupBoxOptions.Controls.OfType<RadioButton>().ToList().ForEach(r => r.Checked = false);

            // Restore previous selection if any
            if (!string.IsNullOrEmpty(selectedAnswers[currentQuestion]))
            {
                switch (selectedAnswers[currentQuestion])
                {
                    case "A": rbA.Checked = true; break;
                    case "B": rbB.Checked = true; break;
                    case "C": rbC.Checked = true; break;
                    case "D": rbD.Checked = true; break;
                }
            }

            // Reset timer for current question
            timeLeft = 20;
            lblTimer.Text = "Time Left: 20 sec";

            // Enable/Disable navigation buttons
            
            btnNext.Enabled = currentQuestion < questions.GetLength(0) - 1;
        }

        void SaveAnswer()
        {
            if (rbA.Checked) selectedAnswers[currentQuestion] = "A";
            else if (rbB.Checked) selectedAnswers[currentQuestion] = "B";
            else if (rbC.Checked) selectedAnswers[currentQuestion] = "C";
            else if (rbD.Checked) selectedAnswers[currentQuestion] = "D";
            else selectedAnswers[currentQuestion] = null; // No selection
        }

        void CalculateScore()
        {
            score = 0;
            for (int i = 0; i < questions.GetLength(0); i++)
            {
                if (selectedAnswers[i] == questions[i, 5])
                    score++;
            }

            MessageBox.Show($"Your Score: {score} / {questions.GetLength(0)}");
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = "Time Left: " + timeLeft + " sec";

            if (timeLeft <= 0)
            {
                SaveAnswer();
                if (currentQuestion < questions.GetLength(0) - 1)
                {
                    currentQuestion++;
                    DisplayQuestion();
                }
                else
                {
                    quizTimer.Stop();
                    CalculateScore();
                }
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (currentQuestion < questions.GetLength(0) - 1)
            {
                currentQuestion++;
                DisplayQuestion();
            }
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            quizTimer.Stop();
            CalculateScore();
        }

        private void DMDW_Load_1(object sender, EventArgs e)
        {

            quizTimer.Interval = 1000;   // 1 second
            quizTimer.Tick += quizTimer_Tick;  // Attach Tick event
            quizTimer.Start();            // Start timer
            DisplayQuestion();
        }
    }
}
  
