using capa3_dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa3_dominio
{
    public class Horario
    {
        private int _horarioid;
        private String _dia;
        private String _horaInicio;
        private String _horaFin;
        private String _salon;
        private Grupo _grupo;
        
        public int horarioid
        {
            get { return _horarioid; }
            set { _horarioid = value; }
        }
        
        public String dia
        {
            get { return _dia; }
            set { _dia = value; }
        }
        
        public String horaInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }
        
        public String horaFin
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }
        
        public String salon
        {
            get { return _salon; }
            set { _salon = value; }
        }
        
        public Grupo grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }
    }
}
