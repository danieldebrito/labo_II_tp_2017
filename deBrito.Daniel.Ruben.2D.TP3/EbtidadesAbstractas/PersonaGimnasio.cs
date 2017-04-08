﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class PersonaGimnasio :Persona
    {
        #region fields
        protected int _identificador;
        #endregion

        #region Methods
        public PersonaGimnasio()
        {
        }

        public PersonaGimnasio(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this._identificador = id;
        }

        public override bool Equals(object obj) 
        { 
            if(obj.GetType() == this.GetType())
            {
                if (this.DNI == ((PersonaGimnasio)obj).DNI || this._identificador == ((PersonaGimnasio)obj)._identificador)
                return true;
            }
            
            return false;
        }

        protected virtual string MostrarDatos()
        {
            return this.ToString() + this._identificador;
        }

        protected abstract string ParticiparEnClase();

        public static bool operator == (PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            if (pg1.DNI == pg2.DNI || pg1._identificador == pg2._identificador)
                return true;
        
            return false;
        }

        public static bool operator != (PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
