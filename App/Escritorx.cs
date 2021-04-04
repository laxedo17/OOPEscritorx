namespace App
{
    public abstract class Escritorx : IBlogger
    {
        private string _nome;
        private string _apelidos;

        public string BioAutor
        {
            get
            {
                return string.Format("O meu nome e {0} {1}", this._nome, this._apelidos);
            }
        }
        public Escritorx(string nome, string apelidos)
        {
            this._nome = nome;
            this._apelidos = apelidos;
        }

        public abstract void Blog();

        public abstract void Escribe();
    }
}