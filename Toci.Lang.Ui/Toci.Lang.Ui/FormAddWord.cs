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

namespace Toci.Lang.Ui
{
    public partial class FormAddWord : Form
    {
        protected TranslationDal dal = new TranslationDal();
        protected ApiTranslationProxy translationProxy = new ApiTranslationProxy();

        public FormAddWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dal.Insert(textBox1.Text);

            translationProxy.AddTranslation(textBox1.Text);


        }
    }
}
