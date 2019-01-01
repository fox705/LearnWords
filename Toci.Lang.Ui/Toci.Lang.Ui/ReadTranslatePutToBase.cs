using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toci.business.Bll;
using Toci.business.Dal;
using Toci.business.EfExample;

namespace Toci.Lang.Ui
{
    public partial class ReadTranslatePutToBase : Form
    {
        public ReadTranslatePutToBase()
        {
            InitializeComponent();
        }

        EfClassGenerator ecg = new EfClassGenerator();
        ApiTranslationProxy atp = new ApiTranslationProxy();
        TranslationDal dal = new TranslationDal();
        List<string> tword = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            tword = ecg.GenerateCode();

           
            for (int i=0; i <1000; i++)
            {
                
                string esword = atp.Translate(tword[i], "es");
                dal.PutTranslateToTable(tword[i], esword);

            }

             
        }
    }
}
