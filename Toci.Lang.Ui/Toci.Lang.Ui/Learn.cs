using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toci.business.Bll;
using Toci.business.Dal;

namespace Toci.Lang.Ui
{
    public partial class Learn : Form

    {
        
        
        
        QuizLogic ql = new QuizLogic();

        List<Control> ControlToRefresh = new List<Control>();
        List<Control> ScoreToRefresh = new List<Control>();
        Dictionary<string, string> wordDictionary = new Dictionary<string, string>();
        private string _answerword = String.Empty;
        private string _quizword = String.Empty;
        private int _score = 0;
        Random rand = new Random();


        public Learn()
        {
            InitializeComponent();
            wordDictionary = ql.GetQuetionToQuiz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            RefreshQuestion();
            



        }
        
        private void RefreshQuestion()
        {
            

            foreach (Control control in ControlToRefresh)
            {
                Controls.Remove(control);
            }

            ControlToRefresh = new List<Control>();

            var rnd = new Random();
            var randomEntry = wordDictionary.ElementAt(rnd.Next(0, wordDictionary.Count));
            _quizword = randomEntry.Key;
            _answerword = randomEntry.Value;
            Label l1 = ControlManager.CreateControl<Label>(50, 20, 210, 100, _quizword);
            ControlToRefresh.Add(l1);
            Controls.Add(l1);
            
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == _answerword)
            {
                _score++;
                foreach (Control control in ScoreToRefresh)
                {
                    Controls.Remove(control);
                }
                ScoreToRefresh = new List<Control>();
                Label scoreLabel = ControlManager.CreateControl<Label>(20, 20, 200, 20, _score.ToString());
                ScoreToRefresh.Add(scoreLabel);
                Controls.Add(scoreLabel);

                wordDictionary.Remove(_quizword);

            }
            else
            {
                Label l2 = ControlManager.CreateControl<Label>(50, 20, 310, 100, _answerword);
                ControlToRefresh.Add(l2);
                Controls.Add(l2);
            }
            

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }



    
}
