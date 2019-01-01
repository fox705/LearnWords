using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toci.business.Quiz.Implementation;
using Toci.business.Quiz.Interfaces;
using Toci.business.Quiz.Mock;

namespace Toci.Lang.Ui.Mazur
{
    public partial class QuizMazur : Form1
    {
        IQuizLogic qLogic;

        public QuizMazur()
        {
            InitializeComponent();
            QuizButton();
        }

        protected void QuizButton()
        {
            // do podmiany
            qLogic = new QuizLogicMock();

            List<IQuizEntity> quizWords = qLogic.GetQuizEntities("", "");

            foreach (IQuizEntity word in quizWords)
            {
                Label l1 = ControlManager.CreateControl<Label>(100, 20, 20, 100, word.Word);
                Controls.Add(l1);
                int i =1;
                foreach (KeyValuePair<string, IQuizAnswer> answer in word.Answers)
                {
                    Button b1 = ControlManager.CreateControl<Button>(100, 20, (20 + (100 * i++)), 100, answer.Value.Word);
                    Controls.Add(b1);
                }
            }

            

        }
        private void ButtonAcceptClick(object sender, System.EventArgs s)
        {
            IQuizEntity result = new QuizEntity();
            

        }
    }
}
