using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException :Exception
    {
        private string _mensajeBase = "No es un nro de DNI valido";

        public string Message
        {
            get { return this._mensajeBase; }
        }
        
        public DniInvalidoException()
            :base()
        { 
        }

        public DniInvalidoException(Exception e)
            :this()
        {
            this._mensajeBase = e.Message;
        }

        public DniInvalidoException(string message)
            : base(message)
        {
        }
        public DniInvalidoException(string message, Exception e)
            : base(message, e)
        {
        }


    }
}
