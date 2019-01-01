using System.Data;

namespace Toci.business.Dal
{
    public class TranslationDal : PostgresqlDbAccess
    {
        

        /*public virtual int Insert(string name, string language = "pl")
        {
            string query = "insert into word (name, language) values ('" + name + "', '" + language + "') returning id;";

            return ExecuteInsert(query);


        }*/

        public virtual int InsertToTranslationmap(int idWord, int idWordChild) //translationmap
        {
             string query = "insert into Languages (id_word, id_word_child) values (" + idWord + ", " + idWordChild + ") returning id;";

            return ExecuteInsert(query);  
        }

        public virtual DataTable GetTranslations(string toLanguage)
        {
            string query = "select * from WordTranslation where tolanguage = '" + toLanguage + "'";

            return ExecuteSelect(query);
        }

        public virtual DataTable GetTranslationsFromTo(string fromLanguage, string toLanguage)
        {
            string query = "select * from translations where fromlanguage = '" + fromLanguage +"' and tolanguage = '" + toLanguage + "'";

            return ExecuteSelect(query);
        }

        public virtual int PutTranslateToTable(string word, string tword)
        {
            string query = "insert into words (word, tword) values ('" + word + "', '" + tword + "') returning id;";

            return ExecuteInsert(query);

        }

        public virtual DataTable GetWordFromDataTable(int id)
        {
            string query = "select * from words where id in ('" + id + "')";
            
            return ExecuteSelect(query);
        }

        public virtual DataTable GetOneWordFromDataTable(int id)
        {
            string query = "select * from words where id in ('" + id + "')";

            return ExecuteSelect(query);
        }

        
        public virtual DataTable GetWordsFromDataTable(int idmin, int idmax)
        {
            string query = "select* from words limit ('" + idmax + "') offset ('" + idmin + "') ";

            return ExecuteSelect(query);
        }



    }
}