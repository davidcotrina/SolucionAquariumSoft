using capa2_aplicacion;
using capa3_dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa1_presentacion
{
    public partial class FormDetalleGrupo : Form
    {
        public FormDetalleGrupo(Grupo grupo)
        {
            InitializeComponent();
            textoCurso.Text = grupo.curso.nombre;
            textoDocente.Text = grupo.docente.nombre;
            textoFechaInicio.Text = grupo.fechainicio.ToShortDateString();
            textoFechaFin.Text = grupo.fechafin.ToShortDateString();            
            textoFechaLimite.Text = grupo.fechalimite.ToShortDateString();
            textoTotalInscritos.Text = grupo.totalInscritos().ToString();
            textoLimite.Text = grupo.limiteinscritos.ToString();
            foreach (Horario horario in grupo.listaHorarios)
            {
                Object[] fila_horario = { horario.dia, horario.horaInicio, horario.horaFin, horario.salon };
                tablaHorarios.Rows.Add(fila_horario);
            }
        }

    }
}
