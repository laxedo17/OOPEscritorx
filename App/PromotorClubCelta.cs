using System;

namespace App 
{
    public class PromotorClubCelta : Promotor
    {
        public PromotorClubCelta(string nome, string apelidos, int movil) : base(nome, apelidos, movil)
        {

        }

        protected override void CompartirInternamente()
        {
            Console.WriteLine("Comparto info cos meus amigos.");
        }

        protected override void UsarPubliPagada()
        {
            Console.WriteLine("Utilizo sempre anuncios pagados");
        }
    }
}