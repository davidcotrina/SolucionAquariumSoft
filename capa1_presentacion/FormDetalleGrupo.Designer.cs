namespace capa1_presentacion
{
    partial class FormDetalleGrupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textoCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoFechaInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textoFechaFin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoFechaLimite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textoTotalInscritos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textoLimite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tablaHorarios = new System.Windows.Forms.DataGridView();
            this.Día = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // textoCurso
            // 
            this.textoCurso.Location = new System.Drawing.Point(159, 69);
            this.textoCurso.Name = "textoCurso";
            this.textoCurso.ReadOnly = true;
            this.textoCurso.Size = new System.Drawing.Size(139, 20);
            this.textoCurso.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Docente:";
            // 
            // textoDocente
            // 
            this.textoDocente.Location = new System.Drawing.Point(159, 104);
            this.textoDocente.Name = "textoDocente";
            this.textoDocente.ReadOnly = true;
            this.textoDocente.Size = new System.Drawing.Size(139, 20);
            this.textoDocente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de inicio:";
            // 
            // textoFechaInicio
            // 
            this.textoFechaInicio.Location = new System.Drawing.Point(159, 140);
            this.textoFechaInicio.Name = "textoFechaInicio";
            this.textoFechaInicio.ReadOnly = true;
            this.textoFechaInicio.Size = new System.Drawing.Size(72, 20);
            this.textoFechaInicio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "fecha de fin:";
            // 
            // textoFechaFin
            // 
            this.textoFechaFin.Location = new System.Drawing.Point(159, 173);
            this.textoFechaFin.Name = "textoFechaFin";
            this.textoFechaFin.ReadOnly = true;
            this.textoFechaFin.Size = new System.Drawing.Size(72, 20);
            this.textoFechaFin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha límite de inscripción";
            // 
            // textoFechaLimite
            // 
            this.textoFechaLimite.Location = new System.Drawing.Point(159, 207);
            this.textoFechaLimite.Name = "textoFechaLimite";
            this.textoFechaLimite.ReadOnly = true;
            this.textoFechaLimite.Size = new System.Drawing.Size(72, 20);
            this.textoFechaLimite.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total de inscritos:";
            // 
            // textoTotalInscritos
            // 
            this.textoTotalInscritos.Location = new System.Drawing.Point(159, 244);
            this.textoTotalInscritos.Name = "textoTotalInscritos";
            this.textoTotalInscritos.ReadOnly = true;
            this.textoTotalInscritos.Size = new System.Drawing.Size(72, 20);
            this.textoTotalInscritos.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Límite de inscritos:";
            // 
            // textoLimite
            // 
            this.textoLimite.Location = new System.Drawing.Point(159, 277);
            this.textoLimite.Name = "textoLimite";
            this.textoLimite.ReadOnly = true;
            this.textoLimite.Size = new System.Drawing.Size(72, 20);
            this.textoLimite.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Horario programado:";
            // 
            // tablaHorarios
            // 
            this.tablaHorarios.AllowUserToAddRows = false;
            this.tablaHorarios.AllowUserToDeleteRows = false;
            this.tablaHorarios.AllowUserToResizeColumns = false;
            this.tablaHorarios.AllowUserToResizeRows = false;
            this.tablaHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Día,
            this.HoraInicio,
            this.HoraFin,
            this.Salon});
            this.tablaHorarios.Location = new System.Drawing.Point(12, 348);
            this.tablaHorarios.MultiSelect = false;
            this.tablaHorarios.Name = "tablaHorarios";
            this.tablaHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaHorarios.Size = new System.Drawing.Size(286, 105);
            this.tablaHorarios.TabIndex = 17;
            // 
            // Día
            // 
            this.Día.HeaderText = "Día";
            this.Día.Name = "Día";
            this.Día.ReadOnly = true;
            this.Día.Width = 80;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Inicia";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 50;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Finaliza";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 50;
            // 
            // Salon
            // 
            this.Salon.HeaderText = "Salon";
            this.Salon.Name = "Salon";
            this.Salon.ReadOnly = true;
            this.Salon.Width = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Detalle del Grupo";
            // 
            // FormDetalleGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 469);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tablaHorarios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textoLimite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textoTotalInscritos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textoFechaLimite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textoFechaFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textoFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoDocente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoCurso);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 507);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 507);
            this.Name = "FormDetalleGrupo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoDocente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoFechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoFechaLimite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textoTotalInscritos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textoLimite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tablaHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Día;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salon;
        private System.Windows.Forms.Label label9;
    }
}