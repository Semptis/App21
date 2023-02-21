using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    public class Employee
    {
        private List<int> scores = new List<int>();
        public Employee(string imie, string nazwisko, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }

        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private int Wiek { get; set; }

        public void AddScores(int score)
        {
            this.scores.Add(score);
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
            statistics.Avg = (float)this.scores.Sum()/this.scores.Count();

            return statistics;
        }

    }
}
