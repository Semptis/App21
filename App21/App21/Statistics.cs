using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class Statistics
    {
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public float Sum {get; private set; }
        public float Count { get; private set; }
        public float Max {get; private set; }
        public float Min {get; private set; }
        public float Avg { get => Sum / Count; }
        
        public void AddGrade(float grade)
        {
            Count++;
            Sum += grade;
            Max = Math.Max(Max, grade);
            Min = Math.Min(Min, grade);
        }
        
    }
}
