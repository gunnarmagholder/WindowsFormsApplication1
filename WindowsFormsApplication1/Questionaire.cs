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
        private String[] arrQuestions = new String[5] {"Eins", "Zwei", "Drei", "Vier", "Fünf"};
        private String[] arrAnswers = new String[5] {"Eins", "Zwei", "Drei", "Vier", "Fünf"};

        public bool AnotherQuestion()
        {
            return false;
        }

        public bool CheckExit()
        {
            return true;
        }
    }
}
