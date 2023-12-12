using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTWAREDDRIGEL
{
    public partial class MULTIPLE_CHOICE : UserControl
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public MULTIPLE_CHOICE()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var sender0bject = (Button)sender;

            int buttonTag = Convert.ToInt32(sender0bject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);


                MessageBox.Show(
                    "YOUR SCORE!" + Environment.NewLine +
                    "You have answered " + score + " question(s) correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.q1;

                    lblQuestion.Text = "Question 1. Choose the correct answer";

                    button1.Text = "A) Agile";
                    button2.Text = "B) End User";
                    button3.Text = "C) Prototyping";
                    button4.Text = "D) Structured";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.q2;

                    lblQuestion.Text = "Question 2. Choose the correct answer";

                    button1.Text = "A) Creating source code";
                    button2.Text = "B) Developing a token stream";
                    button3.Text = "C) Conducting lexical analysis";
                    button4.Text = "D) Generating random test data";

                    correctAnswer = 1;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.q3;

                    lblQuestion.Text = "Question 3. Choose the correct answer";

                    button1.Text = "A) Boolean";
                    button2.Text = "B) Integer";
                    button3.Text = "C) Real";
                    button4.Text = "D) String";

                    correctAnswer = 1;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.q4;

                    lblQuestion.Text = "Question 4. Choose the correct answer";

                    button1.Text = "A) Agile";
                    button2.Text = "B) End User";
                    button3.Text = "C) Prototype";
                    button4.Text = "D) Structured";

                    correctAnswer = 2;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.q5;

                    lblQuestion.Text = "Question 5";

                    button1.Text = "A) IPO Chart";
                    button2.Text = "B) Storyboard";
                    button3.Text = "C) Context Diagram";
                    button4.Text = "D) System Flowchart";

                    correctAnswer = 3;

                    break;




            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MULTIPLE_CHOICE_Load(object sender, EventArgs e)
        {

        }
    }
}
