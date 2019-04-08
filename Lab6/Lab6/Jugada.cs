using System;

namespace Lab6
{
    public class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
            _intentos = 0;
        }

        public bool Adivino
        {
            get
            {
                return this._adivino;
            }
            set
            {
                this._adivino = value;
            }
        }

        public int Intentos
        {
            get
            {
                return this._intentos;
            }
            set
            {
                this._intentos = value;
            }
        }

        public int Numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                this._numero = value;
            }
        }

        public virtual void Comparar(int n)
        {
            if (n == this._numero)
            {
                Adivino = true;
            }
            Intentos++;
        }
    }
}