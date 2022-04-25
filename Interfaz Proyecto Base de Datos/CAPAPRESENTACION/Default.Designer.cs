
namespace Interfaz_Proyecto_Base_de_Datos.CAPAPRESENTACION
{
    partial class Default
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
            this.Lateral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonAdministrar = new System.Windows.Forms.Button();
            this.panelSubMenuAdmin = new System.Windows.Forms.Panel();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.btnMec = new System.Windows.Forms.Button();
            this.btnTaller = new System.Windows.Forms.Button();
            this.btnCupo = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.btnAsesor = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.Citas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnReparacion = new System.Windows.Forms.Button();
            this.panelCita = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lateral.SuspendLayout();
            this.panelSubMenuAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lateral
            // 
            this.Lateral.AutoScroll = true;
            this.Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.Lateral.Controls.Add(this.btnReparacion);
            this.Lateral.Controls.Add(this.btnMantenimiento);
            this.Lateral.Controls.Add(this.Citas);
            this.Lateral.Controls.Add(this.panelSubMenuAdmin);
            this.Lateral.Controls.Add(this.botonAdministrar);
            this.Lateral.Controls.Add(this.panel1);
            this.Lateral.Controls.Add(this.panelCita);
            this.Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lateral.Location = new System.Drawing.Point(0, 0);
            this.Lateral.Name = "Lateral";
            this.Lateral.Size = new System.Drawing.Size(250, 648);
            this.Lateral.TabIndex = 0;
            this.Lateral.Paint += new System.Windows.Forms.PaintEventHandler(this.Lateral_Paint);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 108);
            this.panel1.TabIndex = 0;
            // 
            // botonAdministrar
            // 
            this.botonAdministrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAdministrar.FlatAppearance.BorderSize = 0;
            this.botonAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAdministrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonAdministrar.Location = new System.Drawing.Point(0, 108);
            this.botonAdministrar.Name = "botonAdministrar";
            this.botonAdministrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.botonAdministrar.Size = new System.Drawing.Size(250, 45);
            this.botonAdministrar.TabIndex = 0;
            this.botonAdministrar.Text = "Administrar Elementos";
            this.botonAdministrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAdministrar.UseVisualStyleBackColor = true;
            this.botonAdministrar.Click += new System.EventHandler(this.botonAdministrar_Click);
            // 
            // panelSubMenuAdmin
            // 
            this.panelSubMenuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuAdmin.Controls.Add(this.button2);
            this.panelSubMenuAdmin.Controls.Add(this.button1);
            this.panelSubMenuAdmin.Controls.Add(this.btnAgregarEmpleado);
            this.panelSubMenuAdmin.Controls.Add(this.btnAsesor);
            this.panelSubMenuAdmin.Controls.Add(this.btnVehiculo);
            this.panelSubMenuAdmin.Controls.Add(this.btnCupo);
            this.panelSubMenuAdmin.Controls.Add(this.btnTaller);
            this.panelSubMenuAdmin.Controls.Add(this.btnMec);
            this.panelSubMenuAdmin.Controls.Add(this.BtnCliente);
            this.panelSubMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAdmin.Location = new System.Drawing.Point(0, 153);
            this.panelSubMenuAdmin.Name = "panelSubMenuAdmin";
            this.panelSubMenuAdmin.Size = new System.Drawing.Size(250, 281);
            this.panelSubMenuAdmin.TabIndex = 1;
            // 
            // BtnCliente
            // 
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCliente.Location = new System.Drawing.Point(0, 0);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnCliente.Size = new System.Drawing.Size(250, 40);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "Agregar Cliente";
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMec
            // 
            this.btnMec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMec.FlatAppearance.BorderSize = 0;
            this.btnMec.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMec.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMec.Location = new System.Drawing.Point(0, 40);
            this.btnMec.Name = "btnMec";
            this.btnMec.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMec.Size = new System.Drawing.Size(250, 40);
            this.btnMec.TabIndex = 1;
            this.btnMec.Text = "Agregar Mecanico";
            this.btnMec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMec.UseVisualStyleBackColor = true;
            this.btnMec.Click += new System.EventHandler(this.btnMec_Click);
            // 
            // btnTaller
            // 
            this.btnTaller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaller.FlatAppearance.BorderSize = 0;
            this.btnTaller.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaller.ForeColor = System.Drawing.Color.LightGray;
            this.btnTaller.Location = new System.Drawing.Point(0, 80);
            this.btnTaller.Name = "btnTaller";
            this.btnTaller.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTaller.Size = new System.Drawing.Size(250, 40);
            this.btnTaller.TabIndex = 2;
            this.btnTaller.Text = "Agregar Taller";
            this.btnTaller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaller.UseVisualStyleBackColor = true;
            this.btnTaller.Click += new System.EventHandler(this.btnTaller_Click);
            // 
            // btnCupo
            // 
            this.btnCupo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCupo.FlatAppearance.BorderSize = 0;
            this.btnCupo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCupo.ForeColor = System.Drawing.Color.LightGray;
            this.btnCupo.Location = new System.Drawing.Point(0, 120);
            this.btnCupo.Name = "btnCupo";
            this.btnCupo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCupo.Size = new System.Drawing.Size(250, 40);
            this.btnCupo.TabIndex = 3;
            this.btnCupo.Text = "Agregar Cupo";
            this.btnCupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCupo.UseVisualStyleBackColor = true;
            this.btnCupo.Click += new System.EventHandler(this.btnCupo_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculo.FlatAppearance.BorderSize = 0;
            this.btnVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculo.ForeColor = System.Drawing.Color.LightGray;
            this.btnVehiculo.Location = new System.Drawing.Point(0, 160);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVehiculo.Size = new System.Drawing.Size(250, 40);
            this.btnVehiculo.TabIndex = 4;
            this.btnVehiculo.Text = "Agregar Vehiculo";
            this.btnVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnAsesor
            // 
            this.btnAsesor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsesor.FlatAppearance.BorderSize = 0;
            this.btnAsesor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAsesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsesor.ForeColor = System.Drawing.Color.LightGray;
            this.btnAsesor.Location = new System.Drawing.Point(0, 200);
            this.btnAsesor.Name = "btnAsesor";
            this.btnAsesor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAsesor.Size = new System.Drawing.Size(250, 40);
            this.btnAsesor.TabIndex = 5;
            this.btnAsesor.Text = "Agregar Asesor";
            this.btnAsesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsesor.UseVisualStyleBackColor = true;
            this.btnAsesor.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(0, 240);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(250, 40);
            this.btnAgregarEmpleado.TabIndex = 6;
            this.btnAgregarEmpleado.Text = "Agregar Tipo Empleado";
            this.btnAgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // Citas
            // 
            this.Citas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Citas.FlatAppearance.BorderSize = 0;
            this.Citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Citas.ForeColor = System.Drawing.Color.Gainsboro;
            this.Citas.Location = new System.Drawing.Point(0, 434);
            this.Citas.Name = "Citas";
            this.Citas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Citas.Size = new System.Drawing.Size(250, 45);
            this.Citas.TabIndex = 2;
            this.Citas.Text = "Generar Cita";
            this.Citas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Citas.UseVisualStyleBackColor = true;
            this.Citas.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 280);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 320);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Agregar Cliente";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.ForeColor = System.Drawing.Color.LightGray;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 479);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMantenimiento.Size = new System.Drawing.Size(250, 40);
            this.btnMantenimiento.TabIndex = 3;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReparacion
            // 
            this.btnReparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnReparacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReparacion.FlatAppearance.BorderSize = 0;
            this.btnReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReparacion.ForeColor = System.Drawing.Color.LightGray;
            this.btnReparacion.Location = new System.Drawing.Point(0, 519);
            this.btnReparacion.Name = "btnReparacion";
            this.btnReparacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReparacion.Size = new System.Drawing.Size(250, 40);
            this.btnReparacion.TabIndex = 4;
            this.btnReparacion.Text = "Reparacion";
            this.btnReparacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReparacion.UseVisualStyleBackColor = false;
            this.btnReparacion.Click += new System.EventHandler(this.btnReparacion_Click);
            // 
            // panelCita
            // 
            this.panelCita.Location = new System.Drawing.Point(3, 479);
            this.panelCita.Name = "panelCita";
            this.panelCita.Size = new System.Drawing.Size(244, 80);
            this.panelCita.TabIndex = 9;
            this.panelCita.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCita_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 626);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Interfaz_Proyecto_Base_de_Datos.Properties.Resources.UNAH_version_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(101, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lateral);
            this.Name = "Default";
            this.Text = "Default";
            this.Lateral.ResumeLayout(false);
            this.panelSubMenuAdmin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Lateral;
        private System.Windows.Forms.Panel panelSubMenuAdmin;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnCupo;
        private System.Windows.Forms.Button btnTaller;
        private System.Windows.Forms.Button btnMec;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button botonAdministrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAsesor;
        private System.Windows.Forms.Button Citas;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnReparacion;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel panelCita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}