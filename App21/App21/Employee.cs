using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    internal class Employee
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

        public void AddScores()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                scores.Add(rnd.Next(1,11));
            }          
        }

        public int GetScore()
        {
            return scores.Sum();
        }

        public string GetPersonalData()
        {
            return Imie + " " + Nazwisko + " " + Wiek;
        }

    }
}
