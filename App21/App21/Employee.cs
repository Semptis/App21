using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class Employee
    {
        private List<float> scores = new List<float>();
        public Employee(string imie, string nazwisko, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }

        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private int Wiek { get; set; }

        public void AddScores(string letter)
        {
            switch (letter)
            {
                case "a":
                case "A":
                    this.scores.Add(100);
                    break;
                case "b":
                case "B":
                    this.scores.Add(75);
                    break;
                case "c":
                case "C":
                    this.scores.Add(50);
                    break;
                case "d":
                case "D":
                    this.scores.Add(25);
                    break;
                default:
                    this.scores.Add(0);
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            this.scores.Sort();

            statistics.Max = this.scores.Last();
            statistics.Min = this.scores.First();
            statistics.Avg = (float)this.scores.Sum() / this.scores.Count();

            switch (statistics.Avg)
            {
                case var avg when avg >= 80:
                    statistics.AvgLetter = "A";
                    break;
                case var avg when avg >= 65:
                    statistics.AvgLetter = "B";
                    break;
                case var avg when avg >= 45:
                    statistics.AvgLetter = "C";
                    break;
                case var avg when avg >= 30:
                    statistics.AvgLetter = "D";
                    break;
                default:
                    statistics.AvgLetter = "F";
                    break;
            }
            return statistics;
        }

    }
}
