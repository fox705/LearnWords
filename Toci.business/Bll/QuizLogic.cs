using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Toci.business.Dal;
using Control = System.Web.UI.Control;
using Label = System.Reflection.Emit.Label;


namespace Toci.business.Bll
{
    public class QuizLogic
    {
        TranslationDal dal = new TranslationDal();
        Dictionary<string, string> wordDictionary = new Dictionary<string, string>();
        Random rnd = new Random();
        

        public virtual Dictionary<string, string> GetQuetionToQuiz()
        {
            
                int idmin = rnd.Next(30, 46);
                int idmax = 15;
                DataTable dt = dal.GetWordsFromDataTable(idmin, idmax);
                wordDictionary = dt.AsEnumerable().ToDictionary<DataRow, string, string>(row => row[1].ToString(),
                    row => row[2].ToString());
                
            return wordDictionary;
            
        }


      
        

    }


}