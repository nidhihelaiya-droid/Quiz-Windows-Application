using System;
using System.Windows.Forms;
using System.Linq;

namespace QuizApp
{
    public partial class Data_Structure : Form
    {
        int currentQuestion = 0;
        int score = 0;
        int timeLeft = 20;

        string[,] questions =
        {
    {"Which data structure uses FIFO?", "Stack", "Queue", "Tree", "Graph", "B"},
    {"Which data structure uses LIFO?", "Queue", "Array", "Stack", "Linked List", "C"},
    {"Binary search time complexity?", "O(n)", "O(log n)", "O(n^2)", "O(1)", "B"},
    {"Which DS is used in recursion?", "Queue", "Stack", "Graph", "Tree", "B"},
    {"Singly linked list node contains?", "Data only", "Pointer only", "Data + next pointer", "Two pointers", "C"},
    {"Root-Left-Right traversal?", "Inorder", "Postorder", "Preorder", "Level Order", "C"},
    {"Max children in binary tree?", "1", "2", "3", "Unlimited", "B"},
    {"Priority scheduling uses?", "Stack", "Queue", "Heap", "Linked List", "C"},
    {"Divide & conquer sorting?", "Bubble", "Insertion", "Merge", "Selection", "C"},
    {"Worst case of Bubble Sort?", "O(n)", "O(log n)", "O(n log n)", "O(n^2)", "D"}
};

        string[] selectedAnswers = new string[10];

        public Data_Structure()
        {
            InitializeComponent();
        }

        private void Data_Structure_Load(object sender, EventArgs e)
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


        private void btnNext_Click_1(object sender, EventArgs e)
        {
            SaveAnswer();
            if (currentQuestion < questions.GetLength(0) - 1)
            {
                currentQuestion++;
                DisplayQuestion();
            }
        }

        private void quizTimer_Tick_1(object sender, EventArgs e)
        {

        }

       

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            SaveAnswer();
            quizTimer.Stop();
            CalculateScore();
        }
    }
}