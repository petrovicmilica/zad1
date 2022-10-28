using System;
using System.Collections.Generic;
using System.Text;

namespace zad1.model
{
    enum Status
    {
        B,
        S
    }
    class Student
    {
        public string prezime { get; set; }
        public string ime { get; set; }
        public DateTime datum_rodjenja { get; set }
        public string adresa { get; set; }
        public int telefon { get; set; }
        public string email { get; set; }
        public string indeks { get; set; }
        public int god_upisa { get; set; }
        public int trenutna_god_studija { get; set; }
        public enum Status { }
        public double prosecna_ocena { get; set; }

        public Student(string pr, string i, string dr1, string a, int t, string e, string i2, int gu2, int tgs, enum s, double po2)
        {
            prezime = pr;
            ime = i;
            datum_rodjenja = dr1;
            adresa = a; 
            telefon = t;
            email = e;
            indeks = i2;
            god_upisa = gu2;
            trenutna_god_studija = tds;
            Status = s;
            prosecna_ocena = po2;
        }

        public Student() { }

        public override string ToString()
        {
            return String.Format("| Ime: {0,20} | Prezime: {1,5} |", ime, prezime);
        }
    }

    static void Main(string[] args)
{
    Console.WriteLine("Unesite ime: ");
    string Ime;
    Console.ReadLine();
    Console.WriteLine("Unesite prezime: ");
    string Prezime;
    Console.ReadLine();
    Student s1 = new Student(Prezime, Ime, 22 - 10 - 1983, "Vase Stajica 20", 06060606, "diajidaj", "ra86*2020", 2020, 3, B, 9.0);
    Console.WriteLine(s1);
}
}
