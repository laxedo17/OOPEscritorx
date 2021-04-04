namespace App 
{
    public abstract class Promotor
    {
        private string _nome;
        private string _apelidos;
        private int _movil;

        public string Tarxeta
        {
            get
            {
                return string.Format("{0} {1} {2}", this._nome, this._apelidos, this._movil);
            }
        }
        public Promotor(string nome, string apelidos, int movil)
        {
            this._nome = nome;
            this._apelidos = apelidos;
            this._movil = movil;
        }
        public void Promove()
        {
            this.CompartirInternamente();
            this.UsarPubliPagada();
        }

        protected abstract void CompartirInternamente();
        protected abstract void UsarPubliPagada();
    }
}