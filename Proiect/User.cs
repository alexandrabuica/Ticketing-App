using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Proiect
{
    public class User:ICloneable
    {
        int Id; 
        private string fullName;
        private string telephone;
        private string userName;
        private string password;


        public User(string n, string t, string u, string p)
        {
            fullName = n;
            telephone = t;
            userName = u;
            password = p;
        }
        public User()
        {
            Id = 0;
            fullName = "";
            telephone = "";
            userName = "";
            password = "";
        }

        public User(int id, string n, string t, string u, string p)
        {
            Id = id;
            fullName = n;
            telephone = t;
            userName = u;
            password = p;
        }

        public User(int id, string n, string t, string u)
        {
            Id = id;
            fullName = n;
            telephone = t;
            userName = u;
        }

        public string Name
        {
            get { return fullName; }
        }

        public string Telephone
        {
            get { return telephone; }
        }

        public int ID
        {
            get { return Id; }
        }

        public string Username
        {
            get { return userName; }
        }

        public string Password
        {
            get { return password; }
        }
        public User(string u, string p)
        {
            userName = u;
            password = p;
        }
        
        public override string ToString()
        {
            return "Name: " + fullName + "\n Telephone: " + telephone + "\n Username: " + userName + "\n Password: " + password;
        }

        public static User Login(string connString, string username, string password)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);

            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM Users WHERE username='" + username + "' AND password='" + password + "'";


                OleDbDataReader reader = comanda.ExecuteReader();
                User currentUser = new User();
                while (reader.Read())
                {
                    currentUser = new User(Convert.ToInt32(reader["ID"]), reader["fullName"].ToString(),
                        reader["telephone"].ToString(), reader["username"].ToString(), reader["password"].ToString());

                }
                
                    return currentUser;
                

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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
