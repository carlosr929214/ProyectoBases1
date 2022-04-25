
namespace Interfaz_Proyecto_Base_de_Datos.CAPAPRESENTACION
{
    partial class VEHICULO
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTaller = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMecanico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(667, 27);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // cmbTaller
            // 
            this.cmbTaller.FormattingEnabled = true;
            this.cmbTaller.Location = new System.Drawing.Point(667, 63);
            this.cmbTaller.Name = "cmbTaller";
            this.cmbTaller.Size = new System.Drawing.Size(121, 21);
            this.cmbTaller.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(559, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Cliente";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taller Asignado";
            // 
            // cmbMecanico
            // 
            this.cmbMecanico.FormattingEnabled = true;
            this.cmbMecanico.Location = new System.Drawing.Point(667, 103);
            this.cmbMecanico.Name = "cmbMecanico";
            this.cmbMecanico.Size = new System.Drawing.Size(121, 21);
            this.cmbMecanico.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mecanico Asinado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Placa:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Marca";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "BIN del Motor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha Hora de Registro";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(688, 139);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 12;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(688, 172);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 13;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(688, 205);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 14;
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(688, 240);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(100, 20);
            this.txtBin.TabIndex = 15;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(688, 276);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Agregar Vehiculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // txtColor
            // 
            this.txtColor.AutoSize = true;
            this.txtColor.Location = new System.Drawing.Point(562, 324);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(31, 13);
            this.txtColor.TabIndex = 19;
            this.txtColor.Text = "Color";
            this.txtColor.Click += new System.EventHandler(this.label8_Click);
            // 
            // VEHICULO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtBin);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMecanico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cmbTaller);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VEHICULO";
            this.Text = "Mecanicos";
            this.Load += new System.EventHandler(this.VEHICULO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTaller;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMecanico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtColor;
    }
}