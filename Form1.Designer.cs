
namespace practicaRec
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagAdministrar = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.dtpNació = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTrabaja = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdPersona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnConsultarVer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radSi = new System.Windows.Forms.RadioButton();
            this.lstSexo = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPagAdministrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagAdministrar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(24, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagAdministrar
            // 
            this.tabPagAdministrar.Controls.Add(this.btnAgregar);
            this.tabPagAdministrar.Controls.Add(this.btnModificar);
            this.tabPagAdministrar.Controls.Add(this.btnEliminar);
            this.tabPagAdministrar.Controls.Add(this.btnBuscar);
            this.tabPagAdministrar.Controls.Add(this.cboBarrio);
            this.tabPagAdministrar.Controls.Add(this.dtpNació);
            this.tabPagAdministrar.Controls.Add(this.label4);
            this.tabPagAdministrar.Controls.Add(this.label3);
            this.tabPagAdministrar.Controls.Add(this.chkTrabaja);
            this.tabPagAdministrar.Controls.Add(this.groupBox1);
            this.tabPagAdministrar.Controls.Add(this.txtNombre);
            this.tabPagAdministrar.Controls.Add(this.txtIdPersona);
            this.tabPagAdministrar.Controls.Add(this.label2);
            this.tabPagAdministrar.Controls.Add(this.label1);
            this.tabPagAdministrar.Location = new System.Drawing.Point(4, 27);
            this.tabPagAdministrar.Name = "tabPagAdministrar";
            this.tabPagAdministrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagAdministrar.Size = new System.Drawing.Size(828, 421);
            this.tabPagAdministrar.TabIndex = 0;
            this.tabPagAdministrar.Text = "Administrar";
            this.tabPagAdministrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(397, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 35);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(397, 117);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 32);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(397, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(397, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 34);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(149, 333);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(177, 29);
            this.cboBarrio.TabIndex = 5;
            // 
            // dtpNació
            // 
            this.dtpNació.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNació.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNació.Location = new System.Drawing.Point(149, 286);
            this.dtpNació.Name = "dtpNació";
            this.dtpNació.Size = new System.Drawing.Size(177, 29);
            this.dtpNació.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barrio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nació";
            // 
            // chkTrabaja
            // 
            this.chkTrabaja.AutoSize = true;
            this.chkTrabaja.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrabaja.Location = new System.Drawing.Point(41, 239);
            this.chkTrabaja.Name = "chkTrabaja";
            this.chkTrabaja.Size = new System.Drawing.Size(85, 25);
            this.chkTrabaja.TabIndex = 2;
            this.chkTrabaja.Text = "Trabaja";
            this.chkTrabaja.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMasculino);
            this.groupBox1.Controls.Add(this.radFemenino);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(114, 76);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(105, 25);
            this.radMasculino.TabIndex = 1;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Checked = true;
            this.radFemenino.Location = new System.Drawing.Point(114, 40);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(103, 25);
            this.radFemenino.TabIndex = 0;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(149, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersona.Location = new System.Drawing.Point(149, 17);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(177, 29);
            this.txtIdPersona.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Persona";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDatos);
            this.tabPage2.Controls.Add(this.btnConsultarVer);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lstSexo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.C6});
            this.dgvDatos.Location = new System.Drawing.Point(9, 139);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(799, 261);
            this.dgvDatos.TabIndex = 3;
            // 
            // btnConsultarVer
            // 
            this.btnConsultarVer.Location = new System.Drawing.Point(553, 64);
            this.btnConsultarVer.Name = "btnConsultarVer";
            this.btnConsultarVer.Size = new System.Drawing.Size(97, 33);
            this.btnConsultarVer.TabIndex = 2;
            this.btnConsultarVer.Text = "Consultar";
            this.btnConsultarVer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radNo);
            this.groupBox2.Controls.Add(this.radSi);
            this.groupBox2.Location = new System.Drawing.Point(281, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trabaja";
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(76, 52);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(48, 22);
            this.radNo.TabIndex = 1;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radSi
            // 
            this.radSi.AutoSize = true;
            this.radSi.Checked = true;
            this.radSi.Location = new System.Drawing.Point(76, 28);
            this.radSi.Name = "radSi";
            this.radSi.Size = new System.Drawing.Size(41, 22);
            this.radSi.TabIndex = 0;
            this.radSi.TabStop = true;
            this.radSi.Text = "Si";
            this.radSi.UseVisualStyleBackColor = true;
            // 
            // lstSexo
            // 
            this.lstSexo.FormattingEnabled = true;
            this.lstSexo.ItemHeight = 18;
            this.lstSexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO",
            "AMBOS"});
            this.lstSexo.Location = new System.Drawing.Point(31, 47);
            this.lstSexo.Name = "lstSexo";
            this.lstSexo.Size = new System.Drawing.Size(194, 76);
            this.lstSexo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sexo";
            // 
            // c1
            // 
            this.c1.HeaderText = "ID Persona";
            this.c1.Name = "c1";
            this.c1.Width = 75;
            // 
            // c2
            // 
            this.c2.HeaderText = "Nombre";
            this.c2.Name = "c2";
            this.c2.Width = 150;
            // 
            // c3
            // 
            this.c3.HeaderText = "Sexo";
            this.c3.Name = "c3";
            this.c3.Width = 150;
            // 
            // c4
            // 
            this.c4.HeaderText = "Trabaja";
            this.c4.Name = "c4";
            this.c4.Width = 75;
            // 
            // c5
            // 
            this.c5.HeaderText = "Nació";
            this.c5.Name = "c5";
            this.c5.Width = 120;
            // 
            // C6
            // 
            this.C6.HeaderText = "Barrio";
            this.C6.Name = "C6";
            this.C6.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 488);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Trabajadores";
            this.tabControl1.ResumeLayout(false);
            this.tabPagAdministrar.ResumeLayout(false);
            this.tabPagAdministrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagAdministrar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.DateTimePicker dtpNació;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTrabaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnConsultarVer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radSi;
        private System.Windows.Forms.ListBox lstSexo;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn C6;
    }
}

