using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina:Producto
    {
        #region fields
        private ETipoHarina _tipo;
        protected static bool DeConsumo;
        #endregion

        public enum ETipoHarina {CuatroCeros, Integral}

        #region properties
        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * 0.6f;}
        }
        #endregion

        #region methods
        static Harina()
        {
            DeConsumo = false; 
        }

        public Harina(int codigoBarra, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigoBarra, marca, precio)
        {
            this._tipo = tipo;
        }

        private string MostrarHarina()
        {
            return (string)this + "TIPO: " + this._tipo + "\n";
        }

        public override string ToString()
        {
            
            return MostrarHarina();
        }
        
        
        #endregion
    }
}
