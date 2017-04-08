using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita:Producto
    {
        #region fields
        private float _peso;
        private static bool DeConsumo;
        #endregion

        #region properties
        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * 0.33f;}
        }
        #endregion

        #region methods
        public override string Consumir()
        {
            return "Comestible";
        }
        static Galletita()
        {
            DeConsumo = true; 
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso)
            : base(codigoBarra, marca, precio)
        {
            this._peso = peso;
        }

        private static string MostrarGalletita(Galletita g)
        {
            return (string)g + "PESO: " + g._peso + "\n";
        }

        public override string ToString()
        {

            return MostrarGalletita(this);
        }
        
        
        #endregion
    }
}
