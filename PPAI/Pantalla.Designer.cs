
namespace PPAI
{
    partial class Registro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkHumo = new System.Windows.Forms.CheckBox();
            this.btn_Ingreso = new System.Windows.Forms.Button();
            this.tablaRecursos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoRecurso = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.groupBoxRecurso = new System.Windows.Forms.GroupBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnSeleccionadoMantenimient = new System.Windows.Forms.Button();
            this.txtRazonMantenimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateInHabilitacionRecurso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmacion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWhatsApp = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.nombreCientifico = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.table_title = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecursos)).BeginInit();
            this.groupBoxRecurso.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkHumo
            // 
            this.chkHumo.AutoSize = true;
            this.chkHumo.Location = new System.Drawing.Point(737, 16);
            this.chkHumo.Name = "chkHumo";
            this.chkHumo.Size = new System.Drawing.Size(153, 24);
            this.chkHumo.TabIndex = 14;
            this.chkHumo.Text = "Señales de Humo";
            this.chkHumo.UseVisualStyleBackColor = true;
            // 
            // btn_Ingreso
            // 
            this.btn_Ingreso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingreso.Location = new System.Drawing.Point(363, 242);
            this.btn_Ingreso.Name = "btn_Ingreso";
            this.btn_Ingreso.Size = new System.Drawing.Size(445, 111);
            this.btn_Ingreso.TabIndex = 0;
            this.btn_Ingreso.Text = "Registrar Ingreso de RT en mantenimiento Correctivo";
            this.btn_Ingreso.UseVisualStyleBackColor = true;
            this.btn_Ingreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablaRecursos
            // 
            this.tablaRecursos.AllowUserToAddRows = false;
            this.tablaRecursos.AllowUserToDeleteRows = false;
            this.tablaRecursos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaRecursos.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaRecursos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tablaRecursos.Location = new System.Drawing.Point(12, 69);
            this.tablaRecursos.Name = "tablaRecursos";
            this.tablaRecursos.ReadOnly = true;
            this.tablaRecursos.RowTemplate.Height = 25;
            this.tablaRecursos.Size = new System.Drawing.Size(1136, 243);
            this.tablaRecursos.TabIndex = 1;
            this.tablaRecursos.Visible = false;
            this.tablaRecursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRecursos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Recurso";
            // 
            // txtTipoRecurso
            // 
            this.txtTipoRecurso.Enabled = false;
            this.txtTipoRecurso.Location = new System.Drawing.Point(136, 24);
            this.txtTipoRecurso.Name = "txtTipoRecurso";
            this.txtTipoRecurso.Size = new System.Drawing.Size(181, 26);
            this.txtTipoRecurso.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(396, 24);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(102, 26);
            this.txtNumero.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(323, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(567, 24);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(147, 26);
            this.txtMarca.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(502, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(793, 24);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(147, 26);
            this.txtModelo.TabIndex = 9;
            // 
            // groupBoxRecurso
            // 
            this.groupBoxRecurso.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxRecurso.Controls.Add(this.btnSeleccion);
            this.groupBoxRecurso.Controls.Add(this.txtModelo);
            this.groupBoxRecurso.Controls.Add(this.label5);
            this.groupBoxRecurso.Controls.Add(this.txtMarca);
            this.groupBoxRecurso.Controls.Add(this.label3);
            this.groupBoxRecurso.Controls.Add(this.txtNumero);
            this.groupBoxRecurso.Controls.Add(this.label2);
            this.groupBoxRecurso.Controls.Add(this.txtTipoRecurso);
            this.groupBoxRecurso.Controls.Add(this.label1);
            this.groupBoxRecurso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRecurso.Location = new System.Drawing.Point(12, 335);
            this.groupBoxRecurso.Name = "groupBoxRecurso";
            this.groupBoxRecurso.Size = new System.Drawing.Size(1122, 57);
            this.groupBoxRecurso.TabIndex = 10;
            this.groupBoxRecurso.TabStop = false;
            this.groupBoxRecurso.Text = "Recurso Seleccionado";
            this.groupBoxRecurso.Visible = false;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(959, 22);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(154, 28);
            this.btnSeleccion.TabIndex = 10;
            this.btnSeleccion.Text = "Seleccionar";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Visible = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(720, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modelo";
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.btnSeleccionadoMantenimient);
            this.gbMantenimiento.Controls.Add(this.txtRazonMantenimiento);
            this.gbMantenimiento.Controls.Add(this.label6);
            this.gbMantenimiento.Controls.Add(this.dateInHabilitacionRecurso);
            this.gbMantenimiento.Controls.Add(this.label4);
            this.gbMantenimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbMantenimiento.Location = new System.Drawing.Point(12, 398);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(1122, 82);
            this.gbMantenimiento.TabIndex = 11;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimiento";
            this.gbMantenimiento.Visible = false;
            // 
            // btnSeleccionadoMantenimient
            // 
            this.btnSeleccionadoMantenimient.Location = new System.Drawing.Point(959, 38);
            this.btnSeleccionadoMantenimient.Name = "btnSeleccionadoMantenimient";
            this.btnSeleccionadoMantenimient.Size = new System.Drawing.Size(154, 28);
            this.btnSeleccionadoMantenimient.TabIndex = 11;
            this.btnSeleccionadoMantenimient.Text = "Seleccionar";
            this.btnSeleccionadoMantenimient.UseVisualStyleBackColor = true;
            this.btnSeleccionadoMantenimient.Click += new System.EventHandler(this.btnSeleccionadoMantenimient_Click);
            // 
            // txtRazonMantenimiento
            // 
            this.txtRazonMantenimiento.Location = new System.Drawing.Point(516, 42);
            this.txtRazonMantenimiento.Name = "txtRazonMantenimiento";
            this.txtRazonMantenimiento.Size = new System.Drawing.Size(424, 26);
            this.txtRazonMantenimiento.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Razon Mantenimiento";
            // 
            // dateInHabilitacionRecurso
            // 
            this.dateInHabilitacionRecurso.Location = new System.Drawing.Point(56, 40);
            this.dateInHabilitacionRecurso.MinDate = new System.DateTime(2022, 6, 26, 0, 0, 0, 0);
            this.dateInHabilitacionRecurso.Name = "dateInHabilitacionRecurso";
            this.dateInHabilitacionRecurso.Size = new System.Drawing.Size(289, 26);
            this.dateInHabilitacionRecurso.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha De InHabilitacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 570);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 214);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnConfirmacion
            // 
            this.btnConfirmacion.Location = new System.Drawing.Point(323, 62);
            this.btnConfirmacion.Name = "btnConfirmacion";
            this.btnConfirmacion.Size = new System.Drawing.Size(154, 28);
            this.btnConfirmacion.TabIndex = 12;
            this.btnConfirmacion.Text = "Confirmar";
            this.btnConfirmacion.UseVisualStyleBackColor = true;
            this.btnConfirmacion.Visible = false;
            this.btnConfirmacion.Click += new System.EventHandler(this.btnConfirmacion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkWhatsApp);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.chkHumo);
            this.groupBox1.Controls.Add(this.chkEmail);
            this.groupBox1.Controls.Add(this.btnConfirmacion);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 486);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 99);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notificacion";
            this.groupBox1.Visible = false;
            // 
            // chkWhatsApp
            // 
            this.chkWhatsApp.AutoSize = true;
            this.chkWhatsApp.Location = new System.Drawing.Point(422, 16);
            this.chkWhatsApp.Name = "chkWhatsApp";
            this.chkWhatsApp.Size = new System.Drawing.Size(104, 24);
            this.chkWhatsApp.TabIndex = 16;
            this.chkWhatsApp.Text = "WhatsApp";
            this.chkWhatsApp.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(626, 16);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(52, 24);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Fax";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Checked = true;
            this.chkEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmail.Location = new System.Drawing.Point(247, 16);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(64, 24);
            this.chkEmail.TabIndex = 13;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseCompatibleTextRendering = true;
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Usuario: ";
            this.label7.Visible = false;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreUsuario.Location = new System.Drawing.Point(106, 6);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(57, 21);
            this.nombreUsuario.TabIndex = 15;
            this.nombreUsuario.Text = "label8";
            this.nombreUsuario.Visible = false;
            // 
            // nombreCientifico
            // 
            this.nombreCientifico.AutoSize = true;
            this.nombreCientifico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreCientifico.Location = new System.Drawing.Point(388, 6);
            this.nombreCientifico.Name = "nombreCientifico";
            this.nombreCientifico.Size = new System.Drawing.Size(57, 21);
            this.nombreCientifico.TabIndex = 17;
            this.nombreCientifico.Text = "label9";
            this.nombreCientifico.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(294, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cientifico:";
            this.label10.Visible = false;
            // 
            // table_title
            // 
            this.table_title.AutoSize = true;
            this.table_title.Font = new System.Drawing.Font("Poetsen One", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.table_title.Location = new System.Drawing.Point(795, 28);
            this.table_title.Name = "table_title";
            this.table_title.Size = new System.Drawing.Size(353, 38);
            this.table_title.TabIndex = 18;
            this.table_title.Text = "Recursos Tecnologicos";
            this.table_title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.table_title.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(528, 548);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(154, 28);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1160, 651);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.table_title);
            this.Controls.Add(this.nombreCientifico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.btn_Ingreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.groupBoxRecurso);
            this.Controls.Add(this.tablaRecursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro Ingreso de RT en Mantenimiento Correctivo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecursos)).EndInit();
            this.groupBoxRecurso.ResumeLayout(false);
            this.groupBoxRecurso.PerformLayout();
            this.gbMantenimiento.ResumeLayout(false);
            this.gbMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ingreso;
        private System.Windows.Forms.DataGridView tablaRecursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoRecurso;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.GroupBox groupBoxRecurso;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.Button btnSeleccionadoMantenimient;
        private System.Windows.Forms.TextBox txtRazonMantenimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateInHabilitacionRecurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkWhatsApp;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox chkHumo;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label nombreCientifico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label table_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancelar;
    }
}