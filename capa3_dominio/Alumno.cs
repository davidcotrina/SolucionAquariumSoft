using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa3_dominio
{
    public class Alumno
    {
        private int _alumnoid;
        private string _nombre;
        private string _dni;
        private string _direccion;
        private string _correoe;

        public int alumnoid
        {
            get { return _alumnoid; }
            set { _alumnoid = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string correoe
        {
            get { return _correoe; }
            set { _correoe = value; }
        }
    }
}
