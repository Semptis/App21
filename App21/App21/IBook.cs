using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App21.BookBase;

namespace App21
{
    public interface IBook
    {
        string Title { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);

        event AddGradesDelegate AddGrades;
        Statistics GetStatistics();
    }
}
