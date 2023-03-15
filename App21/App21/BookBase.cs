using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public delegate void AddGradesDelegate(object sender, EventArgs e);
    public abstract class BookBase : IBook
    {
        public abstract event AddGradesDelegate AddGrades;
        public BookBase(string title) => this.Title = title;
        public string Title { get; private set; }
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();
        public void Message(object sender, EventArgs e)
        {
            Console.WriteLine("Grade added");
        }
    }
}
