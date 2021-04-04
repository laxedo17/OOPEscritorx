using System;

namespace App
{
    public class EscribeBlogs : Escritorx, IBlogger
    {
        public EscribeBlogs(string nome, string apelidos) : base(nome, apelidos)
        {
        }

        public override void Blog()
        {
            Console.WriteLine("Eu blogueo");
        }
        
        public override void Escribe()
        {
            Console.WriteLine("Escribo todo tipo de cousas, adoro escriir");
        }
    }
}