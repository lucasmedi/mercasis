using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercaSisTOs
{
    public class Campo<T>
    {
        #region Construtores

        public Campo() { }

        public Campo(T valor)
        {
            this.valor = valor;
        }
        #endregion

        #region Propriedades

        private bool foiSetado = false;
        private T valor;

        public bool FoiSetado
        {
            get { return foiSetado; }
        }

        public T Valor
        {
            get { return valor; }

            set
            {
                valor = value;
                foiSetado = true;
            }
        }
        #endregion
    }
}
