using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Chien c1 = new Chien("Heidi", 2);
            Chien c2= new Chien("Cylene", 3);
            Chien c3 = new Chien("Popy", 1);
            Chien c4 = new Chien("dsfgsg", 4);

            List<Chien> ListeChiens2 = new List<Chien>();
            ListeChiens2.Add(c1);
            ListeChiens2.Add(c2);
            ListeChiens2.Add(c3);
            ListeChiens2.Add(c4);

            /*
            List<Chien> ListeChiens = new List<Chien>();
            ListeChiens.Add(new Chien("Heidi", 2));
            ListeChiens.Add(new Chien("Cylene", 3));
            ListeChiens.Add(new Chien("Popy", 1));
            */

            ListeChiens2.Sort();
            foreach (Chien ch in ListeChiens2)
            {
                WriteLine(ch.Decrire());
            }

            ReadKey();
        }
    }

    public interface IAnimal
    {
        string nom { get; set; }
        int MonPrefere { get; set; }
        string Decrire();
    }

    //public interface IComparable<Chien>
    //{
    //    int CompareTo(Chien chien);
    //}

    public class Chien : IAnimal, IComparable<Chien>
    {
        public Chien(string nom, int monPrefere)
        {
            this.nom = nom;
            MonPrefere = monPrefere;
        }

        public string nom { get; set; }
        public int MonPrefere { get; set; }

        public string Decrire()
        {
            return "Je suis : " + nom + " et j'ai le n° : " + MonPrefere ;
        }

        int IComparable<Chien>.CompareTo(Chien chien)
        {
            int result = 0;           
            if (this.MonPrefere < chien.MonPrefere)
            {
                result = -1;
            }
            if (this.MonPrefere > chien.MonPrefere)
            {
                result = 1;
            }
            return result;
        }
    }
}
