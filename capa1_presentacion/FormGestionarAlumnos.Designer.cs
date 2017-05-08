namespace capa1_presentacion
{
    partial class FormGestionarAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarAlumnos));
            this.barOpciones = new System.Windows.Forms.ToolStrip();
            this.botCrear = new System.Windows.Forms.ToolStripButton();
            this.botModificar = new System.Windows.Forms.ToolStripButton();
            this.botEliminar = new System.Windows.Forms.ToolStripButton();
            this.botCerrar = new System.Windows.Forms.ToolStripButton();
            this.etiNombre = new System.Windows.Forms.Label();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.botBuscar = new System.Windows.Forms.Button();
            this.tablaAlumnos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // barOpciones
            // 
            this.barOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botCrear,
            this.botModificar,
            this.botEliminar,
            this.botCerrar});
            this.barOpciones.Location = new System.Drawing.Point(0, 0);
            this.barOpciones.Name = "barOpciones";
            this.barOpciones.Size = new System.Drawing.Size(620, 25);
            this.barOpciones.TabIndex = 0;
            this.barOpciones.Text = "toolStrip1";
            // 
            // botCrear
            // 
            this.botCrear.Image = ((System.Drawing.Image)(resources.GetObject("botCrear.Image")));
            this.botCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCrear.Name = "botCrear";
            this.botCrear.Size = new System.Drawing.Size(55, 22);
            this.botCrear.Text = "Crear";
            this.botCrear.Click += new System.EventHandler(this.botCrear_Click);
            // 
            // botModificar
            // 
            this.botModificar.Image = ((System.Drawing.Image)(resources.GetObject("botModificar.Image")));
            this.botModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botModificar.Name = "botModificar";
            this.botModificar.Size = new System.Drawing.Size(78, 22);
            this.botModificar.Text = "Modificar";
            this.botModificar.Click += new System.EventHandler(this.botModificar_Click);
            // 
            // botEliminar
            // 
            this.botEliminar.Image = ((System.Drawing.Image)(resources.GetObject("botEliminar.Image")));
            this.botEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botEliminar.Name = "botEliminar";
            this.botEliminar.Size = new System.Drawing.Size(70, 22);
            this.botEliminar.Text = "Eliminar";
            this.botEliminar.Click += new System.EventHandler(this.botEliminar_Click);
            // 
            // botCerrar
            // 
            this.botCerrar.Image = ((System.Drawing.Image)(resources.GetObject("botCerrar.Image")));
            this.botCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botCerrar.Name = "botCerrar";
            this.botCerrar.Size = new System.Drawing.Size(59, 22);
            this.botCerrar.Text = "Cerrar";
            this.botCerrar.Click += new System.EventHandler(this.botCerrar_Click);
            // 
            // etiNombre
            // 
            this.etiNombre.AutoSize = true;
            this.etiNombre.Location = new System.Drawing.Point(14, 47);
            this.etiNombre.Name = "etiNombre";
            this.etiNombre.Size = new System.Drawing.Size(47, 13);
            this.etiNombre.TabIndex = 1;
            this.etiNombre.Text = "Nombre:";
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(76, 44);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(390, 20);
            this.texNombre.TabIndex = 2;
            this.texNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texNombre_KeyPress);
            // 
            // botBuscar
            // 
            this.botBuscar.Image = ((System.Drawing.Image)(resources.GetObject("botBuscar.Image")));
            this.botBuscar.Location = new System.Drawing.Point(472, 42);
            this.botBuscar.Name = "botBuscar";
            this.botBuscar.Size = new System.Drawing.Size(75, 23);
            this.botBuscar.TabIndex = 3;
            this.botBuscar.Text = "Buscar";
            this.botBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botBuscar.UseVisualStyleBackColor = true;
            this.botBuscar.Click += new System.EventHandler(this.botBuscar_Click);
            // 
            // tablaAlumnos
            // 
            this.tablaAlumnos.AllowUserToAddRows = false;
            this.tablaAlumnos.AllowUserToDeleteRows = false;
            this.tablaAlumnos.AllowUserToResizeRows = false;
            this.tablaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.dni,
            this.direccion,
            this.correo});
            this.tablaAlumnos.Location = new System.Drawing.Point(12, 71);
            this.tablaAlumnos.MultiSelect = false;
            this.tablaAlumnos.Name = "tablaAlumnos";
            this.tablaAlumnos.ReadOnly = true;
            this.tablaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAlumnos.Size = new System.Drawing.Size(596, 333);
            this.tablaAlumnos.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 80;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo-e";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 200;
            // 
            // FormGestionarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 416);
            this.Controls.Add(this.tablaAlumnos);
            this.Controls.Add(this.botBuscar);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.etiNombre);
            this.Controls.Add(this.barOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 454);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(636, 454);
            this.Name = "FormGestionarAlumnos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Alumnos";
            this.Shown += new System.EventHandler(this.FormGestionarAlumnos_Shown);
            this.barOpciones.ResumeLayout(false);
            this.barOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barOpciones;
        private System.Windows.Forms.ToolStripButton botCrear;
        private System.Windows.Forms.ToolStripButton botModificar;
        private System.Windows.Forms.ToolStripButton botEliminar;
        private System.Windows.Forms.ToolStripButton botCerrar;
        private System.Windows.Forms.Label etiNombre;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.Button botBuscar;
        private System.Windows.Forms.DataGridView tablaAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
    }
}