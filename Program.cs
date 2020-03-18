using System;
using System.Collections.Generic;

namespace Practice_March2020
{
    class Program
    {
       static List<Gripa> gripe = new List<Gripa>();
        static void Main(string[] args)
        {
            Arrays inst = new Arrays();
            inst.Weekdays();
        }
    }

    #region Interface 1
    interface IAnimal
    {
        string Describe();
        string Name { get; set; }
    }

    class Dog : IAnimal, IComparable
    {
        private string name;
        public Dog(string name)
        {
            this.Name = name;
        }
        public string Describe()
        {
            return "Hello, I am a dog with namele " + this.Name;
        }
        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
            
                return this.Name.CompareTo((obj as IAnimal).Name);
                return 0;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    #endregion

    #region Interface 2
    interface IVirus
    {
        string Descriere();
            int AnulStart { get; set; }
            string Nume { get; set; }
    }

    class Gripa : IVirus, IComparable
    {
        public string Nume { get; set; }
        public int AnulStart {get; set;}
        public Gripa(int anulStart, string nume)
        {
            this.AnulStart = anulStart;
            this.Nume = nume;
        }
        public string Descriere()
        {
            return "Acest virus a inceput in anul " + this.AnulStart +
                "\nsi se numeste " + this.Nume;
        }
        public int CompareTo (object obj)
        {
            if (obj is IAnimal)
                return this.AnulStart.CompareTo((obj as IVirus).AnulStart);
            return 0;
        }
    }

    class SortIntDescending : IComparer<int>
    {
        int IComparer<int>.Compare(int x, int y)
        {
            if (x>y)
            {
                return -1;
            }
            if (x<y)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    #endregion
}
