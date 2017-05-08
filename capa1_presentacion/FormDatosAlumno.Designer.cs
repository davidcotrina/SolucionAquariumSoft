namespace capa1_presentacion
{
    partial class FormDatosAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosAlumno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.botGuardar = new System.Windows.Forms.Button();
            this.botCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo-e:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 23);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(101, 60);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(101, 99);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(229, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(101, 135);
            this.txtCorreo.MaxLength = 40;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(229, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // botGuardar
            // 
            this.botGuardar.Image = ((System.Drawing.Image)(resources.GetObject("botGuardar.Image")));
            this.botGuardar.Location = new System.Drawing.Point(158, 181);
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(75, 26);
            this.botGuardar.TabIndex = 8;
            this.botGuardar.Text = "Guardar";
            this.botGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botGuardar.UseVisualStyleBackColor = true;
            this.botGuardar.Click += new System.EventHandler(this.botGuardar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botCancelar.Image")));
            this.botCancelar.Location = new System.Drawing.Point(255, 181);
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(75, 26);
            this.botCancelar.TabIndex = 9;
            this.botCancelar.Text = "Cancelar";
            this.botCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botCancelar.UseVisualStyleBackColor = true;
            this.botCancelar.Click += new System.EventHandler(this.botCancelar_Click);
            // 
            // FormDatosAlumno
            // 
            this.AcceptButton = this.botGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.botCancelar;
            this.ClientSize = new System.Drawing.Size(347, 219);
            this.Controls.Add(this.botCancelar);
            this.Controls.Add(this.botGuardar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 257);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(363, 257);
            this.Name = "FormDatosAlumno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button botGuardar;
        private System.Windows.Forms.Button botCancelar;
    }
}