using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region fields
        protected sbyte _capacidad;
        private List<Producto> _productos;
        #endregion

        #region properties
        public float ValorEstanteTotal
        {
            get {return this.GetValorEstante();}
        }
        #endregion

        #region methods
        private Estante()
        {
            this._productos = new List<Producto> ();
        }

        public Estante (sbyte capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }
        
        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        public float GetValorEstante()
        {
            return GetValorEstante(Producto.ETipoProducto.Todos); 
        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float acum = 0;

            foreach (Producto p in this._productos)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (p is Galletita)
                            acum += p.Precio;
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (p is Harina)
                            acum += p.Precio;
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (p is Jugo)
                            acum += p.Precio;
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (p is Gaseosa)
                            acum += p.Precio;
                        break;
                    case Producto.ETipoProducto.Todos:
                        acum += p.Precio;
                        break;
                }
            }
            return acum;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad: " + e._capacidad.ToString());
            
            foreach (Producto p in e._productos)
            {
                if (p is Galletita)
                {
                    sb.AppendLine(p.ToString());
                }
                if (p is Jugo)
                {
                    sb.AppendLine(p.ToString());
                }
                if (p is Gaseosa)
                {
                    sb.AppendLine(p.ToString());
                }
                if (p is Harina)
                {
                    sb.AppendLine(p.ToString());
                }
            }
            return sb.ToString();
        }
        
        public static bool operator == (Estante e, Producto prod)
        {
            bool ret = false;

            foreach (Producto p in e.GetProductos())
            {
                if (p == prod)
                {
                    ret = true;
                    break;
                }
            }
        return ret;
        }

        public static bool operator != (Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static bool operator + (Estante e, Producto prod)
        {
            bool ret = false;

            if ((e._capacidad > e.GetProductos().Count) && (e != prod))
            {
                e.GetProductos().Add(prod);
                ret = true;
            }
                
            return ret;
        }

        public static Estante operator - (Estante e, Producto prod)
        {
            if (e == prod)
            {
                e.GetProductos().Remove(prod);
            }
            
            return e;
        }

        public static Estante operator - (Estante e, Producto.ETipoProducto tipo)
        {
            Estante eAux = e;

            for (int i = 0; i < eAux.GetProductos().Count; i++)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (eAux._productos[i] is Galletita)
                        {
                            eAux -= e._productos[i];
                            i--;
                        }
                           break;
                    case Producto.ETipoProducto.Gaseosa:
                           if (eAux._productos[i] is Gaseosa)
                            {
                                eAux -= e._productos[i];
                                i--;
                            }
                            break;
                    case Producto.ETipoProducto.Harina:
                            if (eAux._productos[i] is Harina)
                            {
                                eAux -= e._productos[i];
                                i--;
                            }
                            break;
                    case Producto.ETipoProducto.Jugo:
                            if (eAux._productos[i] is Jugo)
                            {
                                eAux -= e._productos[i];
                                i--;
                            }
                            break;
                    default:
                            eAux -= e._productos[i];
                            i--;
                            break;
                }
            }
            return eAux;
        }
        #endregion
    }
}
