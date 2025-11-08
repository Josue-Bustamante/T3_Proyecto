namespace GUI
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Registrar_Medico = new System.Windows.Forms.Button();
            this.cb_Especialidad = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkB_Prioridad = new System.Windows.Forms.CheckBox();
            this.btn_Registrar_Paciente = new System.Windows.Forms.Button();
            this.cb_Area = new System.Windows.Forms.ComboBox();
            this.txt_NPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.TabPage();
            this.btn_Atender = new System.Windows.Forms.Button();
            this.cb_Area_Desencolar = new System.Windows.Forms.ComboBox();
            this.dgv_Vista = new System.Windows.Forms.DataGridView();
            this.Medicina_General = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ginecologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traumatologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neumologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cardiologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pediatria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dermatologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gastroenterologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vista)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.panel3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 270);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Registrar_Medico);
            this.tabPage1.Controls.Add(this.cb_Especialidad);
            this.tabPage1.Controls.Add(this.txt_ID);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(956, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registo Medicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Registrar_Medico
            // 
            this.btn_Registrar_Medico.Location = new System.Drawing.Point(211, 36);
            this.btn_Registrar_Medico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Registrar_Medico.Name = "btn_Registrar_Medico";
            this.btn_Registrar_Medico.Size = new System.Drawing.Size(90, 47);
            this.btn_Registrar_Medico.TabIndex = 6;
            this.btn_Registrar_Medico.Text = "Registrar";
            this.btn_Registrar_Medico.UseVisualStyleBackColor = true;
            this.btn_Registrar_Medico.Click += new System.EventHandler(this.btn_Registrar_Medico_Click);
            // 
            // cb_Especialidad
            // 
            this.cb_Especialidad.FormattingEnabled = true;
            this.cb_Especialidad.Items.AddRange(new object[] {
            "Medicina General",
            "Ginecologia",
            "Traumatologia",
            "Neumologia",
            "Cardiologia",
            "Pediatria",
            "Dermatologia",
            "Gastroenterología",
            "Neumología"});
            this.cb_Especialidad.Location = new System.Drawing.Point(13, 189);
            this.cb_Especialidad.Name = "cb_Especialidad";
            this.cb_Especialidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_Especialidad.Size = new System.Drawing.Size(152, 21);
            this.cb_Especialidad.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(10, 96);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(76, 25);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(10, 36);
            this.txt_Nombre.Multiline = true;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(92, 25);
            this.txt_Nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkB_Prioridad);
            this.tabPage2.Controls.Add(this.btn_Registrar_Paciente);
            this.tabPage2.Controls.Add(this.cb_Area);
            this.tabPage2.Controls.Add(this.txt_NPaciente);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(956, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro Pacientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkB_Prioridad
            // 
            this.checkB_Prioridad.AutoSize = true;
            this.checkB_Prioridad.Location = new System.Drawing.Point(140, 67);
            this.checkB_Prioridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkB_Prioridad.Name = "checkB_Prioridad";
            this.checkB_Prioridad.Size = new System.Drawing.Size(148, 17);
            this.checkB_Prioridad.TabIndex = 13;
            this.checkB_Prioridad.Text = "El paciente tiene prioridad";
            this.checkB_Prioridad.UseVisualStyleBackColor = true;
            // 
            // btn_Registrar_Paciente
            // 
            this.btn_Registrar_Paciente.Location = new System.Drawing.Point(9, 158);
            this.btn_Registrar_Paciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Registrar_Paciente.Name = "btn_Registrar_Paciente";
            this.btn_Registrar_Paciente.Size = new System.Drawing.Size(91, 60);
            this.btn_Registrar_Paciente.TabIndex = 12;
            this.btn_Registrar_Paciente.Text = "Registrar";
            this.btn_Registrar_Paciente.UseVisualStyleBackColor = true;
            this.btn_Registrar_Paciente.Click += new System.EventHandler(this.btn_Registrar_Paciente_Click);
            // 
            // cb_Area
            // 
            this.cb_Area.FormattingEnabled = true;
            this.cb_Area.Items.AddRange(new object[] {
            "Medicina General",
            "Ginecologia",
            "Traumatologia",
            "Neumologia",
            "Cardiologia",
            "Pediatria",
            "Dermatologia",
            "Gastroenterología",
            "Neumología"});
            this.cb_Area.Location = new System.Drawing.Point(9, 114);
            this.cb_Area.Name = "cb_Area";
            this.cb_Area.Size = new System.Drawing.Size(121, 21);
            this.cb_Area.TabIndex = 11;
            // 
            // txt_NPaciente
            // 
            this.txt_NPaciente.Location = new System.Drawing.Point(7, 31);
            this.txt_NPaciente.Multiline = true;
            this.txt_NPaciente.Name = "txt_NPaciente";
            this.txt_NPaciente.Size = new System.Drawing.Size(76, 25);
            this.txt_NPaciente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Especialidad del Medico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Atender);
            this.panel3.Controls.Add(this.cb_Area_Desencolar);
            this.panel3.Controls.Add(this.dgv_Vista);
            this.panel3.Location = new System.Drawing.Point(4, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 244);
            this.panel3.TabIndex = 2;
            this.panel3.Text = "Atenciones";
            this.panel3.UseVisualStyleBackColor = true;
            // 
            // btn_Atender
            // 
            this.btn_Atender.Location = new System.Drawing.Point(833, 43);
            this.btn_Atender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Atender.Name = "btn_Atender";
            this.btn_Atender.Size = new System.Drawing.Size(91, 63);
            this.btn_Atender.TabIndex = 13;
            this.btn_Atender.Text = "Atender";
            this.btn_Atender.UseVisualStyleBackColor = true;
            this.btn_Atender.Click += new System.EventHandler(this.btn_Atender_Click);
            // 
            // cb_Area_Desencolar
            // 
            this.cb_Area_Desencolar.FormattingEnabled = true;
            this.cb_Area_Desencolar.Items.AddRange(new object[] {
            "Medicina General",
            "Ginecologia",
            "Traumatologia",
            "Neumologia",
            "Cardiologia",
            "Pediatria",
            "Dermatologia",
            "Gastroenterología",
            "Neumología"});
            this.cb_Area_Desencolar.Location = new System.Drawing.Point(833, 11);
            this.cb_Area_Desencolar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Area_Desencolar.Name = "cb_Area_Desencolar";
            this.cb_Area_Desencolar.Size = new System.Drawing.Size(92, 21);
            this.cb_Area_Desencolar.TabIndex = 12;
            // 
            // dgv_Vista
            // 
            this.dgv_Vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicina_General,
            this.Ginecologia,
            this.Traumatologia,
            this.Neumologia,
            this.Cardiologia,
            this.Pediatria,
            this.Dermatologia,
            this.Gastroenterologia});
            this.dgv_Vista.Location = new System.Drawing.Point(8, 11);
            this.dgv_Vista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Vista.Name = "dgv_Vista";
            this.dgv_Vista.RowHeadersWidth = 51;
            this.dgv_Vista.Size = new System.Drawing.Size(790, 122);
            this.dgv_Vista.TabIndex = 0;
            // 
            // Medicina_General
            // 
            this.Medicina_General.HeaderText = "Medicina General";
            this.Medicina_General.MinimumWidth = 6;
            this.Medicina_General.Name = "Medicina_General";
            this.Medicina_General.Width = 125;
            // 
            // Ginecologia
            // 
            this.Ginecologia.HeaderText = "Ginecologia";
            this.Ginecologia.MinimumWidth = 6;
            this.Ginecologia.Name = "Ginecologia";
            this.Ginecologia.Width = 125;
            // 
            // Traumatologia
            // 
            this.Traumatologia.HeaderText = "Traumatologia";
            this.Traumatologia.MinimumWidth = 6;
            this.Traumatologia.Name = "Traumatologia";
            this.Traumatologia.Width = 125;
            // 
            // Neumologia
            // 
            this.Neumologia.HeaderText = "Neumologia";
            this.Neumologia.MinimumWidth = 6;
            this.Neumologia.Name = "Neumologia";
            this.Neumologia.Width = 125;
            // 
            // Cardiologia
            // 
            this.Cardiologia.HeaderText = "Cardiologia";
            this.Cardiologia.MinimumWidth = 6;
            this.Cardiologia.Name = "Cardiologia";
            this.Cardiologia.Width = 125;
            // 
            // Pediatria
            // 
            this.Pediatria.HeaderText = "Pediatria";
            this.Pediatria.MinimumWidth = 6;
            this.Pediatria.Name = "Pediatria";
            this.Pediatria.Width = 125;
            // 
            // Dermatologia
            // 
            this.Dermatologia.HeaderText = "Dermatologia";
            this.Dermatologia.MinimumWidth = 6;
            this.Dermatologia.Name = "Dermatologia";
            this.Dermatologia.Width = 125;
            // 
            // Gastroenterologia
            // 
            this.Gastroenterologia.HeaderText = "Gastroenterologia";
            this.Gastroenterologia.MinimumWidth = 6;
            this.Gastroenterologia.Name = "Gastroenterologia";
            this.Gastroenterologia.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 280);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Especialidad;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Area;
        private System.Windows.Forms.TextBox txt_NPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Vista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicina_General;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ginecologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traumatologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neumologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cardiologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pediatria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dermatologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gastroenterologia;
        private System.Windows.Forms.Button btn_Registrar_Paciente;
        private System.Windows.Forms.Button btn_Registrar_Medico;
        private System.Windows.Forms.Button btn_Atender;
        private System.Windows.Forms.ComboBox cb_Area_Desencolar;
        private System.Windows.Forms.CheckBox checkB_Prioridad;
    }
}

