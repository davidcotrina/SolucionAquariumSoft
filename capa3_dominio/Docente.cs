using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa3_dominio
{
    public class Docente
    {
        private int _docenteid;
        private String _nombre;
        private String _dni;

        public int docenteid
        {
            set { _docenteid = value; }
            get { return _docenteid; }
        }
        public String nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }
        public String dni
        {
            set { _dni = value; }
            get { return _dni; }
        }
    }
}
