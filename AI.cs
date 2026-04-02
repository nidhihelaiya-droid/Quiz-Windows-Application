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
    public partial class AI : Form
    {

        int currentQuestion = 0;
        int score = 0;
        int timeLeft = 20;

    string[,] questions =
        {
            {"AI stands for?", "Automated Intelligence", "Artificial Intelligence", "Advanced Intelligence", "Automatic Interface", "B"},
            {"Which language is used in AI?", "Python", "HTML", "CSS", "SQL", "A"},
            {"Machine learning is a part of?", "AI", "Networking", "Database", "OS", "A"},
            {"Which algorithm is used in AI search?", "A*", "Bubble Sort", "Merge Sort", "Insertion Sort", "A"},
            {"NLP stands for?", "Natural Language Processing", "Network Link Protocol", "New Logic Program", "None", "A"},
            {"Which field studies robots?", "Robotics", "Cloud", "Networking", "Database", "A"},
            {"AI system for speech understanding?", "Speech Recognition", "Compiler", "Debugger", "Linker", "A"},
            {"Expert systems mimic?", "Human decision making", "Database", "Networking", "Sorting", "A"},
            {"Which company works heavily on AI?", "Google", "Intel", "Adobe", "Cisco", "A"},
            {"AI is mainly used for?", "Smart decision making", "Typing", "Printing", "Scanning", "A"}
        };

        string[] selectedAnswers = new string[10];
        public AI()
        {
            InitializeComponent();
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

        private void AI_Load(object sender, EventArgs e)
        {

            quizTimer.Interval = 1000;   // 1 second
            quizTimer.Tick += quizTimer_Tick;  // Attach Tick event
            quizTimer.Start();            // Start timer
            DisplayQuestion();
        }
    }
}
