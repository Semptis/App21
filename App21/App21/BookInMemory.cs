using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class BookInMemory : BookBase
    {
        private List<float> grades;
        public override event AddGradesDelegate AddGrades;
        public BookInMemory(string name)
            : base(name)
        {
            grades = new List<float>();
            this.AddGrades += Message;
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 10)
            {
                grades.Add(grade);
                if (AddGrades != null)
                {
                    AddGrades(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Grade must be between 0 - 10");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            foreach (var grade in grades)
            {
                result.AddGrade(grade);
            }
            return result;
        }
    }
}
