using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Proiect
{
    public class Programmer: User, ICloneable
    {
        public string[] technologies; //programming languages known by the dev

        public Programmer() : base()
        {
            technologies = null;
        }
        
        public Programmer(int id, string n, string t, string u, string p, string[] tech): base(id,n,t,u,p)
        {
            for (int i=0; i<tech.Length; i++)
            {
                technologies[i] = tech[i];
            }
        }

        public Programmer(int id, string n, string t, string u, string p) : base(id, n, t, u, p)
        {
        }
        public static new Programmer Login(string connString, string username, string password)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);

            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM Programmers WHERE username='" + username + "' AND password='" + password + "'";


                OleDbDataReader reader = comanda.ExecuteReader();
                Programmer currentProgr = new Programmer();
                while (reader.Read())
                {
                    currentProgr = new Programmer(Convert.ToInt32(reader["ID"]), reader["fullName"].ToString(),
                        reader["telephone"].ToString(), reader["username"].ToString(), reader["password"].ToString());

                }

                return currentProgr;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexiune.Close();
            }
        }

        public override string ToString()
        {
            string result=base.ToString();
            result += "\nTechnologies: ";
            if(technologies!=null)
            {
                for (int i = 0; i < technologies.Length; i++)
                    result += technologies[i] + ",";
            }
            else
                result += "none";
            return result;
        }
        
    }
}
