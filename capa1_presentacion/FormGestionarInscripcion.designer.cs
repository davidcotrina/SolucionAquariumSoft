namespace capa1_presentacion
{
    partial class FormGestionarInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarInscripcion));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.botBuscarGrupos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaGrupos = new System.Windows.Forms.DataGridView();
            this.GrupoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.botBuscarAlumno = new System.Windows.Forms.Button();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.botGuardar = new System.Windows.Forms.Button();
            this.botCancelar = new System.Windows.Forms.Button();
            this.botVerDetalle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del curso:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(116, 59);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(262, 20);
            this.txtNombreCurso.TabIndex = 1;
            this.txtNombreCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCurso_KeyPress);
            // 
            // botBuscarGrupos
            // 
            this.botBuscarGrupos.Image = ((System.Drawing.Image)(resources.GetObject("botBuscarGrupos.Image")));
            this.botBuscarGrupos.Location = new System.Drawing.Point(384, 57);
            this.botBuscarGrupos.Name = "botBuscarGrupos";
            this.botBuscarGrupos.Size = new System.Drawing.Size(75, 23);
            this.botBuscarGrupos.TabIndex = 2;
            this.botBuscarGrupos.Text = "Buscar";
            this.botBuscarGrupos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botBuscarGrupos.UseVisualStyleBackColor = true;
            this.botBuscarGrupos.Click += new System.EventHandler(this.botonBuscarGrupos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inscripción de alumno a grupo ";
            // 
            // tablaGrupos
            // 
            this.tablaGrupos.AllowDrop = true;
            this.tablaGrupos.AllowUserToAddRows = false;
            this.tablaGrupos.AllowUserToDeleteRows = false;
            this.tablaGrupos.AllowUserToOrderColumns = true;
            this.tablaGrupos.AllowUserToResizeRows = false;
            this.tablaGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrupoId,
            this.Curso,
            this.FechaInicio,
            this.FechaFin,
            this.Docente});
            this.tablaGrupos.Location = new System.Drawing.Point(20, 120);
            this.tablaGrupos.MultiSelect = false;
            this.tablaGrupos.Name = "tablaGrupos";
            this.tablaGrupos.ReadOnly = true;
            this.tablaGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaGrupos.Size = new System.Drawing.Size(662, 187);
            this.tablaGrupos.TabIndex = 4;
            // 
            // GrupoId
            // 
            this.GrupoId.Frozen = true;
            this.GrupoId.HeaderText = "GrupoId";
            this.GrupoId.Name = "GrupoId";
            this.GrupoId.ReadOnly = true;
            this.GrupoId.Visible = false;
            // 
            // Curso
            // 
            this.Curso.Frozen = true;
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 200;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // Docente
            // 
            this.Docente.HeaderText = "Docente";
            this.Docente.Name = "Docente";
            this.Docente.ReadOnly = true;
            this.Docente.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI de Alumno:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(116, 329);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // botBuscarAlumno
            // 
            this.botBuscarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("botBuscarAlumno.Image")));
            this.botBuscarAlumno.Location = new System.Drawing.Point(222, 327);
            this.botBuscarAlumno.Name = "botBuscarAlumno";
            this.botBuscarAlumno.Size = new System.Drawing.Size(75, 23);
            this.botBuscarAlumno.TabIndex = 8;
            this.botBuscarAlumno.Text = "Buscar";
            this.botBuscarAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botBuscarAlumno.UseVisualStyleBackColor = true;
            this.botBuscarAlumno.Click += new System.EventHandler(this.botonBuscarAlumno_Click);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Enabled = false;
            this.txtNombreAlumno.Location = new System.Drawing.Point(303, 329);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.ReadOnly = true;
            this.txtNombreAlumno.Size = new System.Drawing.Size(379, 20);
            this.txtNombreAlumno.TabIndex = 9;
            // 
            // botGuardar
            // 
            this.botGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botGuardar.Image")));
            this.botGuardar.Location = new System.Drawing.Point(504, 376);
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(75, 23);
            this.botGuardar.TabIndex = 10;
            this.botGuardar.Text = "Guardar";
            this.botGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botGuardar.UseVisualStyleBackColor = true;
            this.botGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botCancelar.Image")));
            this.botCancelar.Location = new System.Drawing.Point(607, 376);
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(75, 23);
            this.botCancelar.TabIndex = 11;
            this.botCancelar.Text = "Cancelar";
            this.botCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botCancelar.UseVisualStyleBackColor = true;
            this.botCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botVerDetalle
            // 
            this.botVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("botVerDetalle.Image")));
            this.botVerDetalle.Location = new System.Drawing.Point(584, 59);
            this.botVerDetalle.Name = "botVerDetalle";
            this.botVerDetalle.Size = new System.Drawing.Size(98, 23);
            this.botVerDetalle.TabIndex = 12;
            this.botVerDetalle.Text = "Ver detalle";
            this.botVerDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botVerDetalle.UseVisualStyleBackColor = true;
            this.botVerDetalle.Click += new System.EventHandler(this.botonVerDetalle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lista grupos abiertos para inscripción";
            // 
            // FormInscribirAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.botCancelar;
            this.ClientSize = new System.Drawing.Size(694, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botVerDetalle);
            this.Controls.Add(this.botCancelar);
            this.Controls.Add(this.botGuardar);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.botBuscarAlumno);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaGrupos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botBuscarGrupos);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 450);
            this.Name = "FormInscribirAlumno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscribir Alumno";
            this.Shown += new System.EventHandler(this.FormInscribirAlumno_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button botBuscarGrupos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button botBuscarAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Button botGuardar;
        private System.Windows.Forms.Button botCancelar;
        private System.Windows.Forms.Button botVerDetalle;
        private System.Windows.Forms.Label label4;
    }
}