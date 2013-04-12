using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Questionaire
    {
        private int iQuestionsToGo = 3;
        private int iCurrentQuestion;
        private bool bRightAnswer = false;
        private bool CanExit = false;
        private String strPasscode = "MeinGeheimesKennwort";
        private String[] arrQuestions = new String[9] {"Eins", "Zwei", "Drei", "Vier", "Fünf", "Sechs", "Sieben", "Acht", "Neun"};
        private String[] arrAnswers = new String[9] { "Eins", "Zwei", "Drei", "Vier", "Fünf", "Sechs", "Sieben", "Acht", "Neun" };

        public int RemainingQuestions()
        {
            return iQuestionsToGo;
        }

        public bool LastQuestionCorrectAnswered()
        {
            return bRightAnswer;
        }

        public String getQuestion()
        {
            Random rnd = new Random();
            iCurrentQuestion = rnd.Next(this.arrQuestions.Length);
            while (arrQuestions[iCurrentQuestion] == null)
            {
                iCurrentQuestion = rnd.Next(this.arrQuestions.Length);
            }
            return arrQuestions[iCurrentQuestion];
        }

        public bool AnotherQuestion(String answer)
        {
            if (answer == strPasscode)
            {
                CanExit = true;
                return false;
            }
            if ((answer == arrAnswers[iCurrentQuestion]))
            {
                iQuestionsToGo = iQuestionsToGo - 1;
                arrQuestions[iCurrentQuestion] = null;
                if (iQuestionsToGo == 0)
                {
                    CanExit = true;
                    return false;
                }
                else
                {
                    bRightAnswer = true;
                    return true;
                }
            }
            else
            {
                bRightAnswer = false;
                return true;
            }
        }

        public bool CheckExit()
        {
            return CanExit;
        }
    }
}
