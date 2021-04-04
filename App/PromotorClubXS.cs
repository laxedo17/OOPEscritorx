using System;

namespace App 
{
    public class PromotorClubXs : Promotor, IXimnasio, IBlogger
    {
        public PromotorClubXs(string nome, string apelidos, int movil) : base(nome, apelidos, movil)
        {

        }

        public void Blog()
        {
            Console.WriteLine("Despois do ximnasio gustame moito bloguear, pero prefiro esto ultimo con diferencia.");
        }

        public void Ximnasio()
        {
            Console.WriteLine("Son de ir ao ximnasio, pero cando termino, blogueo, logo existo.");
        }

        protected override void CompartirInternamente()
        {
            Console.WriteLine("Comparto info coa xente do meu equipo de traballo.");
        }

        protected override void UsarPubliPagada()
        {
            Console.WriteLine("Os anuncios pagados son o meu con google adwords ou facebook ads.");
        }
    }
}