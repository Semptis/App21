using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App21
{
    public class BookInFile : BookBase
    {
        private const string fileName = "grade.txt";
        public override event AddGradesDelegate AddGrades;
        public BookInFile(string title) :
            base(title)
        {
            if (File.Exists($"{fileName}"))
            {
                File.Delete($"{fileName}");
            }
            this.AddGrades += Message;
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 10)
            {
                using (var sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(grade);
                    if (AddGrades != null)
                    {
                        AddGrades(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Grade must be between 0 - 10");
            }
        }
        public override void AddGrade(string grade)
        {
            float number;
            bool success = float.TryParse(grade, out number);
            if (success)
            {
                AddGrade(number);
            }
            else
            {
                throw new Exception($"Attempted conversion of '{grade}' failed.");
            }
        }
        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = new StreamReader(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("File not exist");
            }
            return result;
        }
    }
}
