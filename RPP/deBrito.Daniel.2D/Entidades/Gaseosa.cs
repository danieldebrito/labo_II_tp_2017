using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa:Producto
    {
        #region fields
        protected float _litros;
        protected static bool DeConsumo;
        #endregion

        #region properties
        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * 0.42f;}
        }
        #endregion

        #region methods
        public override string Consumir()
        {
            return "Bebible";
        }
        static Gaseosa()
        {
            DeConsumo = true; 
        }

        public Gaseosa (int codigoBarra, EMarcaProducto marca, float precio, float litros)
            : base(codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa (Producto p, float litros)
            : base((int)p, p.Marca, p.Precio)
        {
            this._litros = litros;
        }


        private string MostrarGaseosa()
        {
            return (string)this + "LITROS: " + this._litros + "\n";
        }

        public override string ToString()
        {

            return MostrarGaseosa();
        }
        
        
        #endregion

    }
}
