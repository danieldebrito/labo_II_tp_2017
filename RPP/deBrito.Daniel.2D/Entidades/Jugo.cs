using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo:Producto
    {
        #region fields
        private ESaborJugo _sabor;
        private static bool DeConsumo;
        #endregion

        public enum ESaborJugo { Asqueroso, Pasable, Rico }

        #region properties
        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * 0.4f;}
        }
        #endregion

        #region methods
        public override string Consumir()
        {
            return "Bebible";
        }
        static Jugo()
        {
            DeConsumo = false; 
        }

        public Jugo (int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }

        private string MostrarJugo()
        {   
            return (string)this + "SABOR: " +  this._sabor + "\n";
        }

        public override string ToString()
        {
            
            return MostrarJugo();
        }
        #endregion

    }
}
