using capa3_dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa3_dominio
{
    public class Inscripcion
    {
        private int _inscripcionid;
        private DateTime _fecha;
        private String _estado;
        private Alumno _alumno;
        private Grupo _grupo;
        //private List<Evaluacion> listaEvaluaciones;

        public Inscripcion()
        {
            _fecha = DateTime.Now;
            _estado = "Inscrito";
        }
        public int inscripcionid
        {
            set { _inscripcionid = value; }
            get { return _inscripcionid; }
        }
        public DateTime fecha
        {
            set { _fecha = value; }
            get { return _fecha; }
        }
        public String estado
        {
            set { _estado = value; }
            get { return _estado; }
        }
        public Alumno alumno
        {
            set { _alumno = value; }
            get { return _alumno; }
        }
        public Grupo grupo
        {
            set { _grupo = value; }
            get { return _grupo; }
        }
    }
}
