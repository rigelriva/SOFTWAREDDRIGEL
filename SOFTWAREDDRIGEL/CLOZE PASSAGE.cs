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
    public partial class CLOZE_PASSAGE : UserControl
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public CLOZE_PASSAGE()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void CLOZE_PASSAGE_Load(object sender, EventArgs e)
        {

        }

        private void checkAnswersEvent(object sender, EventArgs e)
        {
            var sender0bject = (Button)sender;

            int buttonTag = Convert.ToInt32(sender0bject.Tag);

            if(buttonTag ==correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);


                MessageBox.Show(
                    "YOUR SCORE!" + Environment.NewLine +
                    "You have answered " + score + " question(s) correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.q6;

                    lblQuestion.Text = "Question 1. Fill in the BLANK";

                    button1.Text = "A) Structured";
                    button2.Text = "B) End-User";
                    button3.Text = "C) RAD";
                    button4.Text = "D) Prototype";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.q7;

                    lblQuestion.Text = "Question 2 Fill in the BLANKS.";

                    button1.Text = "A) Structured, Flexible";
                    button2.Text = "B) End-User, Systematic";
                    button3.Text = "C) Agile, Flexible";
                    button4.Text = "D) Agile, Systematic";

                    correctAnswer = 3;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.q8;

                    lblQuestion.Text = "Question 3. Fill in the BLANK.";

                    button1.Text = "A) Prototype";
                    button2.Text = "B) Mock-Up";
                    button3.Text = "C) GUI";
                    button4.Text = "D) Pseudocode";

                    correctAnswer = 1;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.q9;

                    lblQuestion.Text = "Question 4. Fill in the BLANK.";

                    button1.Text = "A) Prototype";
                    button2.Text = "B) RAD";
                    button3.Text = "C) End-User";
                    button4.Text = "D) Agile";

                    correctAnswer = 2;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.q10;

                    lblQuestion.Text = "Question 5. Fill in the BLANK.";

                    button1.Text = "A) Standard";
                    button2.Text = "B) End-User";
                    button3.Text = "C) Agile";
                    button4.Text = "D) Structured";

                    correctAnswer = 4;

                    break;
            }
        }
    }
}
