using System;
namespace CustomLists
{
    public class TesterObjects
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public TesterObjects(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
           
    }
}
