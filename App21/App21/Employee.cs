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

        public void AddScores(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);
            }
            else
            {
                Console.WriteLine("Grade must be between 0-100");
            }
        }
        public void AddScores(string score)
        {
            if (float.TryParse(score,out var scores))
            {
                this.AddScores(scores);
            }
            else
            {
                Console.WriteLine("Invalid string parese");
            }
        }
        public void AddScores(double score)
        {
            this.AddScores((float)score);
        }
        public void AddScores(long score)
        {
            this.AddScores((float)score);
        }
        public string GetPersonalData()
        {
            return $"Dane pracownika: {Imie} {Nazwisko} {Wiek}";
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            this.scores.Sort();

            statistics.Max = this.scores.Last();
            statistics.Min = this.scores.First();
            statistics.Avg = (float)this.scores.Sum() / this.scores.Count();

            return statistics;
        }

    }
}
