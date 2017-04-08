using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Instructor :PersonaGimnasio
    {
        private Queue<Gimnasio.EClases> _clasesDelDia;
        private static Random _random;


        public Instructor()
        {
        }

        
        static Instructor()
        {
            _random = new Random();
        }

        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesDelDia = new Queue<Gimnasio.EClases>();
            this.RandomClases();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine(ParticiparEnClase());

            return sb.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Gimnasio.EClases c in this._clasesDelDia)
            {
                sb.AppendLine(c.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        private void RandomClases()
        {
            this._clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(0, 3));
            this._clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(0, 3));
        }

        public static bool operator == (Instructor i, Gimnasio.EClases clase)
        {
            foreach (Gimnasio.EClases clase2 in i._clasesDelDia)
            {
                if (clase2 == clase)
                    return true;
            }
            return false;
        }

        public static bool operator != (Instructor i, Gimnasio.EClases clase)
        {
            return !(i == clase);
        }
     }
}
