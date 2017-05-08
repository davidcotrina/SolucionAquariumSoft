namespace capa1_presentacion
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPlanificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionarCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionarDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionarGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionarHorarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMatriculas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionarAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestionarInscripcion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuReporteInscritos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEvaluacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEvaluacionGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuReporteNotasGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.barOpciones = new System.Windows.Forms.ToolStrip();
            this.botAlumnos = new System.Windows.Forms.ToolStripButton();
            this.botInscripcion = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.barOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlanificacion,
            this.menuMatriculas,
            this.menuEvaluacion,
            this.menuSeguridad,
            this.menuSistema});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPlanificacion
            // 
            this.menuPlanificacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestionarCursos,
            this.menuGestionarDocentes,
            this.menuGestionarGrupos,
            this.menuGestionarHorarios});
            this.menuPlanificacion.Name = "menuPlanificacion";
            this.menuPlanificacion.Size = new System.Drawing.Size(87, 20);
            this.menuPlanificacion.Text = "Planificación";
            // 
            // menuGestionarCursos
            // 
            this.menuGestionarCursos.Name = "menuGestionarCursos";
            this.menuGestionarCursos.Size = new System.Drawing.Size(224, 22);
            this.menuGestionarCursos.Text = "Gestionar Cursos";
            // 
            // menuGestionarDocentes
            // 
            this.menuGestionarDocentes.Name = "menuGestionarDocentes";
            this.menuGestionarDocentes.Size = new System.Drawing.Size(224, 22);
            this.menuGestionarDocentes.Text = "Gestionar Docentes";
            // 
            // menuGestionarGrupos
            // 
            this.menuGestionarGrupos.Name = "menuGestionarGrupos";
            this.menuGestionarGrupos.Size = new System.Drawing.Size(224, 22);
            this.menuGestionarGrupos.Text = "Gestionar Grupos";
            // 
            // menuGestionarHorarios
            // 
            this.menuGestionarHorarios.Name = "menuGestionarHorarios";
            this.menuGestionarHorarios.Size = new System.Drawing.Size(224, 22);
            this.menuGestionarHorarios.Text = "Gestionar Horarios de Grupo";
            // 
            // menuMatriculas
            // 
            this.menuMatriculas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestionarAlumnos,
            this.menuGestionarInscripcion,
            this.toolStripSeparator1,
            this.menuReporteInscritos});
            this.menuMatriculas.Name = "menuMatriculas";
            this.menuMatriculas.Size = new System.Drawing.Size(70, 20);
            this.menuMatriculas.Text = "Maticulas";
            // 
            // menuGestionarAlumnos
            // 
            this.menuGestionarAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("menuGestionarAlumnos.Image")));
            this.menuGestionarAlumnos.Name = "menuGestionarAlumnos";
            this.menuGestionarAlumnos.Size = new System.Drawing.Size(304, 22);
            this.menuGestionarAlumnos.Text = "Gestionar Alumnos";
            this.menuGestionarAlumnos.Click += new System.EventHandler(this.menuGestionarAlumnos_Click);
            // 
            // menuGestionarInscripcion
            // 
            this.menuGestionarInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("menuGestionarInscripcion.Image")));
            this.menuGestionarInscripcion.Name = "menuGestionarInscripcion";
            this.menuGestionarInscripcion.Size = new System.Drawing.Size(304, 22);
            this.menuGestionarInscripcion.Text = "Gestionar Inscripción a Grupo";
            this.menuGestionarInscripcion.Click += new System.EventHandler(this.menuGestionarInscripcion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(301, 6);
            // 
            // menuReporteInscritos
            // 
            this.menuReporteInscritos.Name = "menuReporteInscritos";
            this.menuReporteInscritos.Size = new System.Drawing.Size(304, 22);
            this.menuReporteInscritos.Text = "Generar Reporte de Inscripciones por Grupo";
            // 
            // menuEvaluacion
            // 
            this.menuEvaluacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEvaluacionGrupo,
            this.menuNotas,
            this.toolStripSeparator2,
            this.menuReporteNotasGrupo});
            this.menuEvaluacion.Name = "menuEvaluacion";
            this.menuEvaluacion.Size = new System.Drawing.Size(76, 20);
            this.menuEvaluacion.Text = "Evaluación";
            // 
            // menuEvaluacionGrupo
            // 
            this.menuEvaluacionGrupo.Name = "menuEvaluacionGrupo";
            this.menuEvaluacionGrupo.Size = new System.Drawing.Size(289, 22);
            this.menuEvaluacionGrupo.Text = "Gestionar Tipos de evaluación por Grupo";
            // 
            // menuNotas
            // 
            this.menuNotas.Name = "menuNotas";
            this.menuNotas.Size = new System.Drawing.Size(289, 22);
            this.menuNotas.Text = "Registrar Notas por Grupo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
            // 
            // menuReporteNotasGrupo
            // 
            this.menuReporteNotasGrupo.Name = "menuReporteNotasGrupo";
            this.menuReporteNotasGrupo.Size = new System.Drawing.Size(289, 22);
            this.menuReporteNotasGrupo.Text = "Generar Reporte de Notas por Grupo";
            // 
            // menuSeguridad
            // 
            this.menuSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRoles,
            this.menuUsuarios});
            this.menuSeguridad.Name = "menuSeguridad";
            this.menuSeguridad.Size = new System.Drawing.Size(72, 20);
            this.menuSeguridad.Text = "Seguridad";
            // 
            // menuRoles
            // 
            this.menuRoles.Name = "menuRoles";
            this.menuRoles.Size = new System.Drawing.Size(175, 22);
            this.menuRoles.Text = "Gestionar Permisos";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(175, 22);
            this.menuUsuarios.Text = "Gestionar Usuarios";
            // 
            // menuSistema
            // 
            this.menuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAcerca,
            this.menuAyuda,
            this.menuSalir});
            this.menuSistema.Name = "menuSistema";
            this.menuSistema.Size = new System.Drawing.Size(60, 20);
            this.menuSistema.Text = "Sistema";
            // 
            // menuAcerca
            // 
            this.menuAcerca.Name = "menuAcerca";
            this.menuAcerca.Size = new System.Drawing.Size(152, 22);
            this.menuAcerca.Text = "Acerca de";
            // 
            // menuAyuda
            // 
            this.menuAyuda.Image = ((System.Drawing.Image)(resources.GetObject("menuAyuda.Image")));
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(152, 22);
            this.menuAyuda.Text = "Ayuda";
            // 
            // menuSalir
            // 
            this.menuSalir.Image = ((System.Drawing.Image)(resources.GetObject("menuSalir.Image")));
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(152, 22);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // barOpciones
            // 
            this.barOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botAlumnos,
            this.botInscripcion});
            this.barOpciones.Location = new System.Drawing.Point(0, 24);
            this.barOpciones.Name = "barOpciones";
            this.barOpciones.Size = new System.Drawing.Size(583, 25);
            this.barOpciones.TabIndex = 1;
            this.barOpciones.Text = "toolStrip1";
            // 
            // botAlumnos
            // 
            this.botAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("botAlumnos.Image")));
            this.botAlumnos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botAlumnos.Name = "botAlumnos";
            this.botAlumnos.Size = new System.Drawing.Size(75, 22);
            this.botAlumnos.Text = "Alumnos";
            this.botAlumnos.Click += new System.EventHandler(this.botAlumnos_Click);
            // 
            // botInscripcion
            // 
            this.botInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("botInscripcion.Image")));
            this.botInscripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botInscripcion.Name = "botInscripcion";
            this.botInscripcion.Size = new System.Drawing.Size(69, 22);
            this.botInscripcion.Text = "Inscribir";
            this.botInscripcion.Click += new System.EventHandler(this.botInscripcion_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 463);
            this.Controls.Add(this.barOpciones);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Sistema Académico - AquariumSoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.barOpciones.ResumeLayout(false);
            this.barOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPlanificacion;
        private System.Windows.Forms.ToolStripMenuItem menuGestionarCursos;
        private System.Windows.Forms.ToolStripMenuItem menuGestionarDocentes;
        private System.Windows.Forms.ToolStripMenuItem menuGestionarGrupos;
        private System.Windows.Forms.ToolStripMenuItem menuGestionarHorarios;
        private System.Windows.Forms.ToolStripMenuItem menuMatriculas;
        private System.Windows.Forms.ToolStripMenuItem menuGestionarAlumnos;
        private System.Windows.Forms.ToolStripMenuItem menuGestionarInscripcion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuReporteInscritos;
        private System.Windows.Forms.ToolStripMenuItem menuEvaluacion;
        private System.Windows.Forms.ToolStripMenuItem menuEvaluacionGrupo;
        private System.Windows.Forms.ToolStripMenuItem menuNotas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuReporteNotasGrupo;
        private System.Windows.Forms.ToolStripMenuItem menuSeguridad;
        private System.Windows.Forms.ToolStripMenuItem menuRoles;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuSistema;
        private System.Windows.Forms.ToolStripMenuItem menuAcerca;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.ToolStrip barOpciones;
        private System.Windows.Forms.ToolStripButton botAlumnos;
        private System.Windows.Forms.ToolStripButton botInscripcion;
    }
}

