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

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public TesterObjects(string Name, string Color, int Age)
        {
            this.Name = Name;
            this.Color = Color;
            this.Age = Age;
        }
           
    }
}
