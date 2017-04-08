using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region fields
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;
        #endregion

        public enum EMarcaProducto { Manaos, Pitusas, Naranjú, Diversión, Swift, Favorita }
        public enum ETipoProducto { Jugo, Galletita, Harina, Gaseosa, Todos }
        

        #region properties
        public abstract float CalcularCostoDeProduccion {get;}

        public EMarcaProducto Marca
        {
            get { return this._marca;}
        }
        
        public float Precio
        {
            get { return this._precio; }
        }
        #endregion

        #region Methods
       
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        private static string MostrarProducto (Producto p)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("MARCA: ");
            sb.AppendLine(p._marca.ToString());
            sb.Append("CODIGO DE BARRAS: ");
            sb.AppendLine((p._codigoBarra).ToString());
            sb.Append("PRECIO: ");
            sb.AppendLine(p._precio.ToString());

            return sb.ToString();
        }

        public override bool Equals (object obj) {return this.GetType() == obj.GetType();}

        public static bool operator == (Producto prodUno, EMarcaProducto marca)
        {
            bool ret = false;
            if (prodUno.Marca == marca)
                ret = true;
            return ret;
        }

        public static bool operator != (Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        public static bool operator == (Producto prodUno, Producto prodDos)
        {
            bool ret = false;

            if (((int)prodUno == (int)prodDos) && (prodUno == prodDos.Marca))
            {
                if(prodUno.Equals(prodDos))
                ret = true;
            }
            return ret;
        }

        public static bool operator != (Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }

        public static explicit operator int (Producto p)
        {
            return p._codigoBarra;
        }

        public static implicit operator string (Producto p)
        {
            return MostrarProducto(p);
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }
        #endregion

    }
}
