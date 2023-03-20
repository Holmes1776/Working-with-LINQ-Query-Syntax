using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }

    public static void Main(string[] args)
    {
        IList<famousPeople> stemPeople = new List<famousPeople>() {
            new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
            new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
            new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
            new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
            new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
            new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
            new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
            new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
            new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
            new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
            new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
            new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
            new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
            new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
            new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
            new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
            };

        var first = from f in stemPeople
                    where f.BirthYear > 1900
                    select f;

        var second = from s in stemPeople
                     where s.Name.Contains("ll")
                     select s;
        var third = from t in stemPeople
                    where t.BirthYear > 1950
                    select t;
        var fourth = from fo in stemPeople
                    where fo.BirthYear > 1920 && fo.BirthYear <  2000
                    select fo;
        var order = from o in stemPeople
                    orderby o.BirthYear
                    select o;
        var fifth = from fi in stemPeople
                    orderby fi.Name
                    where fi.DeathYear > 1960 && fi.DeathYear < 2015
                    select fi;


        foreach (var f in first)
        {
            Console.WriteLine(f.Name);
        }
        Console.WriteLine();
        foreach (var s in second)
        {
            Console.WriteLine(s.Name);
        }
        Console.WriteLine();  
        int pb = 0;
        foreach (var t in third)
        {
            pb++;
        }
        Console.WriteLine(pb);
        Console.WriteLine();
        foreach (var fo in fourth)
        {
            Console.WriteLine(fo.Name);
        }
        Console.WriteLine();
        foreach (var fi in fifth)
        {
            Console.WriteLine(fi.Name);
        }
        Console.ReadLine();
    }
}
