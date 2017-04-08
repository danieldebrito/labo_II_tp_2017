﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero }
        
        #region fields
        protected string _apellido;
        protected int _dni;
        protected ENacionalidad _nacionalidad;
        protected string _nombre;
        #endregion
  
        #region properties
        public string Apellido 
        { 
            get {return this._apellido;}
            set { this._apellido = ValidarNombreApellido(value);}              
        }
        public int DNI
        {
            get { return this._dni; }
            set { this._dni = ValidarDni(this._nacionalidad, value); }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }

            set
            {
                if (Nacionalidad == ENacionalidad.Argentino || Nacionalidad == ENacionalidad.Extranjero)
                { this._nacionalidad = value; }
                else
                    throw new NacionalidadInvalidaException();
            }
        }
        
        public string Nombre 
        { 
            get {return this._nombre;}
            set { this._nombre = ValidarNombreApellido(value);}              
        }
        public string StringToDNI { set { int.TryParse(value, out this._dni);} }
        #endregion

        #region Methods
        public Persona()
        {
        }
        
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad)
            :this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("NOMBRE COMPLETO: ");
            sb.AppendLine(this.Nombre);
            //sb.AppendLine(this.DNI.ToString());
            sb.Append("NACIONALIDAD: ");
            sb.AppendLine(this.Nacionalidad.ToString());

            return sb.ToString();
        }

        private int ValidarDni (ENacionalidad nacionalidad, int dato)
        {
            if ((nacionalidad == ENacionalidad.Argentino && dato > 0 && dato < 90000000) || 
                (nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato < 100000000))
                return dato;
            else
                throw new DniInvalidoException();
        }
       
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int ret;
            if(int.TryParse(dato, out ret))
                return ValidarDni(nacionalidad, ret);
            else
                throw new DniInvalidoException(dato.ToString());
        }
       
        private string ValidarNombreApellido (string dato)
        {
            Regex rgx = new Regex(@"^[a-zA-ZñÑ]$");
            if (rgx.IsMatch(dato))
                return dato;
            else
                return null;
        }
        #endregion
    }
}
