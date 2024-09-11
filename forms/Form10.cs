using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace adoproject
{
    public partial class Form10 : Form
    {
        private int currentQuestionIndex = 0;
        private int score = 0;
        private int[] userAnswers;

        private string[] questions = {
            " Which data structure is commonly used to implement a LIFO (Last In First Out) order?",
            "What does SQL stand for?",
            "Which of the following is a statically typed programming language??",
            "In programming, what is a loop",
             "What is an algorithm?"
        };

        private string[][] options = {
            new string[] { "Stack", "Queue", "Variable", "List" },
            new string[] { "Structured Query Language", " Simple Query Language", "Sequential Query Language", " Structured Quota Language" },
            new string[] { "Java", "C", "Python", "C++" },
            new string[] { " A sequence of instructions that is executed repeatedly","A method to store multiple values"," A function that calls itself", "A way to manage memory" },
            new string[] { "A graphic representation of a flow of data"," A step-by-step procedure to solve a problem","A method of data storage"," A type of variable in programming" }
        };

        private int[] correctAnswers = { 0, 0, 0, 0, 1 };
        public Form10()
        {
            InitializeComponent();
            userAnswers = new int[questions.Length];
            for (int i = 0; i < userAnswers.Length; i++)
            {
                userAnswers[i] = -1; // Initialize user answers with -1 (indicating no answer)
            }
            LoadQuestion();
        }
        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Length)
            {
                label1.Text = questions[currentQuestionIndex];
                radioButton1.Text = options[currentQuestionIndex][0];
                radioButton2.Text = options[currentQuestionIndex][1];
                radioButton3.Text = options[currentQuestionIndex][2];
                radioButton4.Text = options[currentQuestionIndex][3];

                // Set previously selected answer if available
                switch (userAnswers[currentQuestionIndex])
                {
                    case 0:
                        radioButton1.Checked = true;
                        break;
                    case 1:
                        radioButton2.Checked = true;
                        break;
                    case 2:
                        radioButton3.Checked = true;
                        break;
                    case 3:
                        radioButton4.Checked = true;
                        break;
                    default:
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        break;
                }
                button3.Enabled = currentQuestionIndex > 0;
                button2.Enabled = currentQuestionIndex < questions.Length - 1;
            }
        }
        private void SaveUserAnswer()
        {
            if (radioButton1.Checked) userAnswers[currentQuestionIndex] = 0;
            if (radioButton2.Checked) userAnswers[currentQuestionIndex] = 1;
            if (radioButton3.Checked) userAnswers[currentQuestionIndex] = 2;
            if (radioButton4.Checked) userAnswers[currentQuestionIndex] = 3;
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveUserAnswer();
            score = 0;
            for (int i = 0; i < userAnswers.Length; i++)
            {
                if (userAnswers[i] == correctAnswers[i])
                {
                    score++;
                }
            }
            MessageBox.Show("Your score: " + score +" ");
            label2.Text = "Final Score: " + score;
            if(score>2)
            {
                
                linkLabel1.Enabled = true;
            }
            else
            {
                MessageBox.Show("YOUR NOT QUALIFY IN THE TEST","RETAKE SOME OTHER TIME",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                Form8 f=new Form8();
                f.ShowDialog();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveUserAnswer();
            if (currentQuestionIndex < questions.Length - 1)
            {
                currentQuestionIndex++;
                LoadQuestion();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveUserAnswer();
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                LoadQuestion();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 f = new Form12();
            f.ShowDialog();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
