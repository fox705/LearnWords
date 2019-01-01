using System.Data;
using System.Data.Common;
using Npgsql;

namespace Toci.business.Dal
{
    public class PostgresqlDbAccess : DbAccessBase
    {
        protected NpgsqlConnection Connection;

        public PostgresqlDbAccess()
        {
            Connect("User ID=postgres;Password=fd705mnb;Host=localhost;Port=5432;Database=Languages;");
        }

        public override bool Connect(string connectionString)
        {
            Connection = new NpgsqlConnection(connectionString);

            Connection.Open();

            return Connection.State == ConnectionState.Open;
        }

        public override int ExecuteInsert(string query)
        {
            NpgsqlCommand command = Connection.CreateCommand();

            command.CommandText = query;

            return int.Parse(command.ExecuteScalar().ToString());


        }

        public override DataTable ExecuteSelect(string @select)
        {
            NpgsqlCommand command = Connection.CreateCommand();

            command.CommandText = @select;

            DbDataReader reader = command.ExecuteReader();

            DataTable dtb = new DataTable();

            dtb.Load(reader);

            return dtb;
        }
    }
}

/*
 * drop table word;

create table word
(
	id serial primary key,
	id_word int references word(id),
	name text,
	language text
);

create table translationmap
(
	id serial primary key,
	id_word int references word(id),
	id_word_child int references word(id)
);

create or replace  view TRanslations as 
select w1.name as fromWord, w1.language as fromLanguage, w2.name as toWord, w2.language as toLanguage
from translationmap t1 
join  word w1 on t1.id_word = w1.id
join word w2 on t1.id_word_child = w2.id;
select * from TRanslations where fromLanguage = 'es' and toLanguage = 'en';
select * from translationmap;




select id, id_word, name, language from word;

update word set id_word = 5 where id > 5;

create view WordTranslation as 
select w1.name as fromWord, w1.language as fromLanguage, w2.name as toWord, w2.language as toLanguage
from word w1 join word w2 on w1.id = w2.id_word;

select * from WordTranslation where tolanguage = 'es'
select * from WordTranslation where tolanguage = 'nl' and fromLanguage = 'de';
 */
