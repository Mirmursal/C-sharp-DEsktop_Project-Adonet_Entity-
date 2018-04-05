using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_FİnalProject_.Model;

namespace University_FİnalProject_
{
    public partial class Exam : Form
    {
        //general begin
        University_Final_ProjectEntities db = new University_Final_ProjectEntities();
        string examSubject;
        Model.Student ActiveStudent;
        List<string> Content = new List<string>();
        List<string> Correct = new List<string>();
        List<string> Incorrect1 = new List<string>();
        List<string> Incorrect2 = new List<string>();
        List<string> Incorrect3 = new List<string>();
        List<string> CorrectAnswers = new List<string>();
        List<string> IncorrectAnswers = new List<string>();
        List<int> CheckAgain = new List<int>();
        int i = 0;
        int CorrectAnswCount = 0;
        int IncorrectAnsCount = 0;
        decimal AnswerPoint;
        // general end
        public Exam(string subject , Model.Student currentStudent)
        {
            InitializeComponent();
            examSubject = subject;
            ActiveStudent = currentStudent;
        }
        private void Exam_Load(object sender, EventArgs e)
        {
            lblHeading.Text = examSubject + " Exam";
        }
        private void UpdateFilters()
        {
            lblCountCorAnsw.Text = CorrectAnswCount.ToString();
            lblCountIncAnsw.Text = IncorrectAnsCount.ToString();
            lblCountPoint.Text = (CorrectAnswCount * AnswerPoint).ToString();
        }
        private void RefreshButton()
        {
            foreach (Button btn in pnlButton.Controls)
            {
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
            }
        }
        //Generate Random numbers---------------------------
        private void GenerateRandom(List<int>list)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            int b = rnd.Next(2, 4);
            int c = 0;
            int d = 0;

            for(int i = 0; i < 4; i++)
            {
                if(i != a && i != b)
                {
                    c = i;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (i != a && i != b && i!=c)
                {
                    d = i;
                }
            }
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
        }
        //Random end-----------------------------------------
        private void ShowQuestions()
        {
            RefreshButton();
            lblError.Visible = false;

            if (i < Content.Count)
            {
                //add list answers begin
                List<string> Answers = new List<string>();
                Answers.Add(Correct[i]);
                Answers.Add(Incorrect1[i]);
                Answers.Add(Incorrect2[i]);
                Answers.Add(Incorrect3[i]);
                //add list answers end
                //randomize begin
                List<int> myList = new List<int>();
                //random begin
                Random rand = new Random();
                int k = rand.Next(0, 4);
                int l = rand.Next(0, 4);
                int m = rand.Next(0, 4);
                int n = rand.Next(0, 4);

                {
                    AAA:
                    l = rand.Next(0, 4);
                    if (l == k)
                    {
                        goto AAA;
                    }
                    else
                    {
                    }
                }

                {
                    BBB:
                    m = rand.Next(0, 4);
                    if (m == l || m == k)

                    {
                        goto BBB;
                    }
                    else
                    {

                    }
                }
                {
                    CCC:
                    n = rand.Next(0, 4);
                    if (n == l || n == k || n == m)
                    {
                        goto CCC;
                    }
                    else
                    {
                        //Console.WriteLine(n);
                    }
                }
                //random end
                myList.Add(k);
                myList.Add(l);
                myList.Add(m);
                myList.Add(n);
                // randomize end
                //-------------------------------------------------
                lblActiveQuestion.Text = (i + 1).ToString();
                rtxtContent.Text = Content[i];
                //--------------------------------------------------
                //-------------------------------------------------
                btnCorrect.Text = Answers[myList[1]];
                btnIncorrect1.Text = Answers[myList[0]];
                btnIncorrect2.Text = Answers[myList[3]];
                btnIncorrect3.Text = Answers[myList[2]];
                if (i == Content.Count - 1)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                }
            }
            else
            {
                btnNext.Enabled = false;
            }
            if (i < 1)
            {
                btnPrev.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            // Question add to lists begin
            foreach (var eq in db.ExamQuestions.Where(q=>q.Subject.Name == examSubject))
            {
                Content.Add(eq.Content);
                Correct.Add(eq.Correct);
                Incorrect1.Add(eq.Incorrect1);
                Incorrect2.Add(eq.Incorrect2);
                Incorrect3.Add(eq.Incorrect3);
            }
            // Question add to lists end     
            ShowQuestions();

            AnswerPoint = (50 / Content.Count);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {     
            i++;
            ShowQuestions();   
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            i--;
            ShowQuestions();
        }
        private void ButtonClick(Button btn)
        {
            string answer = btn.Text;
            if (!CheckAgain.Contains(i))
            {
                if (answer == Correct[i])
                {
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.Green;
                    CorrectAnswCount++;
                    UpdateFilters();
                    CorrectAnswers.Add(answer);
                }
                else
                {
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.DarkRed;
                    IncorrectAnsCount++;
                    UpdateFilters();
                    IncorrectAnswers.Add(answer);
                }
                CheckAgain.Add(i);
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Sorry , You have already used your answer";
            }       
        }
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            ButtonClick(btnCorrect);
        }

        private void btnIncorrect1_Click(object sender, EventArgs e)
        {
            ButtonClick(btnIncorrect1);
        }

        private void btnIncorrect2_Click(object sender, EventArgs e)
        {
            ButtonClick(btnIncorrect2);
        }

        private void btnIncorrect3_Click(object sender, EventArgs e)
        {
            ButtonClick(btnIncorrect3);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            string Total = (CorrectAnswCount * AnswerPoint).ToString();
            ExamResult er = new ExamResult(ActiveStudent , examSubject , Total );
            er.ShowDialog();
            this.Close();     
        }
        //check random begin
        //check random end
    }
}

