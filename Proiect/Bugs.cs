using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    public class Bugs : IComparable, ICloneable
    {
        readonly int  id;
        public int userID;
        string summary;
        string description;
        string category;
        int priority;
        public readonly string date = DateTime.Now.ToString("yyyy, MM, dd, HH:mm:ss tt");

        public int ID
        {
            get { return id; }
        }

        public  string Summary
        {
            get { return summary; }
        }

        public string Description
        {
            get { return description; }
        }

        public string Category
        {
            get { return category; }
        }

        public int Priority
        {
            get { return priority; }
        }

        public Bugs(int i, string s, string d, string c, int p, string dt)
        {
            id = i;
            summary = s;
            description = d;
            category = c;
            priority = p;
            date = dt;
        }

        public Bugs(int i, int ui, string s,  string c, int p, string dt)
        {
            id = i;
            userID = ui;
            summary = s;
            category = c;
            priority = p;
            date = dt;
        }
        public Bugs(int i, string s,  string c, int p)
        {
            id = i;
            summary = s;
            category = c;
            priority = p;
           
        }

        public object Clone()
        {
            Bugs b = (Bugs)this.MemberwiseClone();
            return b;
        }

        public int CompareTo(object obj)
        {
            Bugs b = (Bugs)obj;
            if (this.priority < b.priority)
                return -1;
            else if (this.priority > b.priority)
                return 1;
            else return string.Compare(this.summary, b.summary);
        }

        public override string ToString()
        {
            string result = "Bug ID: "+ id + " - \"" + summary + "\" - with priority " + priority;
            if (priority == 1) result += " (low)";
            else if (priority == 2) result += " (medium)";
            else if (priority == 3) result += " (high)";
            else if (priority == 4) result += " (urgent)";
            result+=" was reported successfully on -- " +date;
            return result;
        }
    }
}
