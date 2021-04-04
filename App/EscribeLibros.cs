using System;

namespace App 
{
    public class EscribeLibros : Escritorx, IBlogger
    {
        public EscribeLibros(string nome, string apelidos) : base(nome, apelidos)
        {

        }

        public override void Blog()
        {
            Console.WriteLine("Eu blogueo no meu PC para escribir rápido");
        }

        public override void Escribe()
        {
            Console.WriteLine("Escribo sobre todo tipo de cousas, especialmente etnografia");
        }
    }
}