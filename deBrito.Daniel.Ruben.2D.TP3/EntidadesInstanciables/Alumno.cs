using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Alumno :PersonaGimnasio
    {

        public enum EEstadoCuenta { AlDia, Deudor, MesPrueba }
        
        #region Fields
        protected EntidadesInstanciables.Gimnasio.EClases _claseQueToma;
        protected EEstadoCuenta _estadoCuenta;
        #endregion

        #region Methods
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma)
            :base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
            this._estadoCuenta = EEstadoCuenta.MesPrueba;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            :this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.Append("ESTADO DE CUENTA: ");
            sb.AppendLine(this._estadoCuenta.ToString());
            sb.Append("CLASE QUE TOMA: ");
            sb.AppendLine(this._claseQueToma.ToString());
            return sb.ToString();
        }

        public static bool operator == (Alumno a, Gimnasio.EClases clase)
        {
            if (a._claseQueToma.Equals(clase) && a._estadoCuenta.Equals(EEstadoCuenta.AlDia))
                return true;
            
            return false;
        }

        public static bool operator != (Alumno a, Gimnasio.EClases clase)
        {
            return !(a._claseQueToma.Equals(clase));
        }

        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE: " + this._claseQueToma.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion


    }
}
