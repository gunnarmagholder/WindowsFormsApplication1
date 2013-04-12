using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Questionaire clsQuest = new Questionaire();
        private int iMittelweite;
        private int iMittelhoehe;
        private int iRemainingQuestions;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnExit;
            iRemainingQuestions = clsQuest.RemainingQuestions();
            lblMessage.Text = "Noch " +  iRemainingQuestions.ToString() + " Fragen korrekt zu beantworten.";
            iMittelweite = this.Size.Width / 2;
            iMittelhoehe = this.Size.Height / 2;
            newQuestion();
        }

        private void SetFieldPositions()
        {
            foreach (Control c in this.Controls)
            {
                int iCSize = c.Size.Width / 2;
                c.Left = iMittelweite - iCSize;
                c.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!clsQuest.AnotherQuestion(tbAnswer.Text))
            {
                lblMessage.Text = "Fragen sind korrekt beantwortet. Viel Spass!";
                SetFieldPositions();
                System.Threading.Thread.Sleep(2000);
                Application.Exit();
            } else {
                iRemainingQuestions = clsQuest.RemainingQuestions();
                lblMessage.Text = (clsQuest.LastQuestionCorrectAnswered() ? "Die Antwort ist richtig!" : "Das war leider falsch.") + " Noch " + iRemainingQuestions.ToString() + ((iRemainingQuestions > 1) ? " Fragen." : " Frage");
                SetFieldPositions();
                newQuestion();
            }
        }

        private void newQuestion()
        {
            tbAnswer.Text = "";
            lblQuestion.Text = clsQuest.getQuestion();
            SetFieldPositions();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clsQuest.CheckExit())    
                e.Cancel = true;
        }
    }
}
