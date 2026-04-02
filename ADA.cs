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
    public partial class ADA : Form
    {
        int currentQuestion = 0;
        int score = 0;
        int timeLeft = 20;

        string[,] questions =
 {
    {"Which technique is used in Merge Sort?", "Greedy", "Divide and Conquer", "Dynamic Programming", "Backtracking", "B"},
    {"Time complexity of Binary Search?", "O(n)", "O(log n)", "O(n^2)", "O(1)", "B"},
    {"Which algorithm is used to find shortest path?", "Kruskal", "Dijkstra", "Prim", "Merge", "B"},
    {"Which technique is used in Quick Sort?", "Divide and Conquer", "Greedy", "Backtracking", "Dynamic Programming", "A"},
    {"Worst case time complexity of Quick Sort?", "O(n)", "O(n log n)", "O(n^2)", "O(log n)", "C"},
    {"Which algorithm is used for Minimum Spanning Tree?", "Dijkstra", "Prim", "Binary Search", "Merge Sort", "B"},
    {"Which technique is used in Fibonacci using DP?", "Greedy", "Dynamic Programming", "Backtracking", "Divide", "B"},
    {"Which algorithm is used for job scheduling?", "Greedy", "Divide", "Dynamic Programming", "Backtracking", "A"},
    {"Which algorithm solves the Travelling Salesman Problem?", "Greedy", "Dynamic Programming", "Backtracking", "All of the above", "D"},
    {"Best case time complexity of Merge Sort?", "O(n)", "O(n log n)", "O(log n)", "O(n^2)", "B"}
};

        string[] selectedAnswers = new string[10];
        public ADA()
        {
            InitializeComponent();
        }

        private void ADA_Load(object sender, EventArgs e)
        {
            quizTimer.Interval = 1000;   // 1 second
            quizTimer.Tick += quizTimer_Tick;  // Attach Tick event
            quizTimer.Start();            // Start timer
            DisplayQuestion();
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

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void DS_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestionNo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quizTimer_Tick_1(object sender, EventArgs e)
        {

        }

        private void groupBoxOptions_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }
    }
}