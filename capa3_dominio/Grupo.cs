using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa3_dominio
{
    public class Grupo
    {
        private int _grupoid;
        private DateTime _fechainicio;
        private DateTime _fechafin;
        private DateTime _fechalimite;
        private DateTime _fechacierre;
        private int _limiteinscritos;        
        private Curso _curso;
        private Docente _docente;
        private List<Inscripcion> _listaInscripciones;
        private List<Horario> _listaHorarios;

        public Grupo()
        {
            _listaInscripciones = new List<Inscripcion>();
            _listaHorarios = new List<Horario>();
        }

        public int grupoid
        {
            set { _grupoid = value; }
            get { return _grupoid; }
        }
        public DateTime fechainicio
        {
            set { _fechainicio = value; }
            get { return _fechainicio; }
        }
        public DateTime fechafin
        {
            set { _fechafin = value; }
            get { return _fechafin; }
        }
        public DateTime fechalimite
        {
            set { _fechalimite = value; }
            get { return _fechalimite; }
        }
        public DateTime fechacierre
        {
            set { _fechacierre = value; }
            get { return _fechacierre; }
        }
        public Curso curso
        {
            set { _curso = value; }
            get { return _curso; }
        }
        public Docente docente
        {
            set { _docente = value; }
            get { return _docente; }
        }

        public int limiteinscritos
        {
            get { return _limiteinscritos; }
            set { _limiteinscritos = value; }
        }

        public void agregarIncripcion(Inscripcion inscripcion)
        {
            _listaInscripciones.Add(inscripcion);
        }

        public void agregarHorario(Horario horario)
        {
            _listaHorarios.Add(horario);
        }

        public List<Horario> listaHorarios
        {
            get { return _listaHorarios; }
            set { _listaHorarios = value; }
        }

        public bool yaExisteInscripcion(Alumno alumno){
            bool existeInscripcion = false;
            foreach (Inscripcion inscripcion in _listaInscripciones)
            {
                Alumno alumno_inscrito = inscripcion.alumno;
                if (alumno.alumnoid == alumno_inscrito.alumnoid)
                {
                    existeInscripcion = true;
                    break;
                }                    
            }
            return existeInscripcion;
        }

        public bool verificarLimiteDeInscritos()
        {
            bool estaenlimite = false;
            int totalInscritos = 0;
            foreach (Inscripcion inscripcion in _listaInscripciones)
            {
                if (inscripcion.estado.Trim().Equals("Inscrito"))
                    totalInscritos++;
            }
            if (totalInscritos == _limiteinscritos)
                estaenlimite = true;
            return estaenlimite;
        }

        public int totalInscritos()
        {
            int totalInscritos = 0;
            foreach (Inscripcion inscripcion in _listaInscripciones)
            {
                if (inscripcion.estado.Trim().Equals("Inscrito"))
                    totalInscritos++;
            }
            return totalInscritos;
        }

    }
}
