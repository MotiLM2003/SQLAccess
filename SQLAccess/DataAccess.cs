using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQLAccess
{
    public class DataAccess
    {
        public List<Person> GetPeople(string name)
        {
            List<Person> lst = new List<Person>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@LastName", name);
                lst = connection.Query<Person>("People_GetByLastName", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return lst;
        }


        public void InsertPerson(Person p)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(p);
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @PhoneNumber, @EmailAddress", people);


            }


        }
    }
}

