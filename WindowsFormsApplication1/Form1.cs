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
        private int iQuestionSize;
        private int iAnswerSize;
        private int iExitSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblQuestion.Text = "Irrsinnig langer Text mit viel BlaBla, so wie schule halt ist ...";

            iMittelweite = this.Size.Width / 2;
            iMittelhoehe = this.Size.Height / 2;

            SetFieldPositions();
        }

        private void SetFieldPositions()
        {

            iQuestionSize = lblQuestion.Size.Width / 2;
            lblQuestion.Left = iMittelweite - iQuestionSize;

            iAnswerSize = tbAnswer.Size.Width / 2;
            tbAnswer.Left = iMittelweite - iAnswerSize;

            iExitSize = btnExit.Size.Width / 2;
            btnExit.Left = iMittelweite - iExitSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clsQuest.CheckExit())    
                e.Cancel = true;
        }


    }
}
