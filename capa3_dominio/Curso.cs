using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa3_dominio
{
    public class Curso
    {
        private int _cursoid;
        private String _codigo;
        private String _nombre;

        public int cursoid
        {
            set { _cursoid = value; }
            get { return _cursoid; }
        }
        public String codigo
        {
            set { _codigo = value; }
            get { return _codigo; }
        }
        public String nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }
    }
}
