using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promotor> promotorxs = new List<Promotor>() { new PromotorClubXs("Calixto", "Pintos", 2536634), new PromotorClubXs("Antoine", "Petunia", 57448356), new PromotorClubCelta("Pepe", "Portas", 172746) };

            foreach (var promotor in promotorxs)
            {
                promotor.Promove();
            }

            List<Escritorx> escritorxs = new List<Escritorx>() { new EscribeLibros("Parfum", "Parfect"), new EscribeLibros("Alisa", "Curva"), new EscribeBlogs("Grimaldo", "Gris") };

            foreach (var escritxr in escritorxs)
            {
                escritxr.Escribe();
            }

            List<IXimnasio> ratasGym = new List<IXimnasio>() { new PromotorClubXs("Matilda", "Gracia Latuya", 23465363), new PromotorClubXs("Camila", "Ohrevienta", 36463474) };

            foreach (var rataGym in ratasGym)
            {
                rataGym.Ximnasio();
            }

            List<IBlogger> ratasBiblio = new List<IBlogger>() { new PromotorClubXs("Camilo", "Ruisenor", 34667868), new EscribeBlogs("Paco", "Gancho") };

            foreach (var rataBiblio in ratasBiblio)
            {
                rataBiblio.Blog();
            }
        }
    }
}