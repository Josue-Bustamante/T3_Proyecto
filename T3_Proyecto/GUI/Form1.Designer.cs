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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cb_Especialidad = new System.Windows.Forms.ComboBox();
            this.cb_Area = new System.Windows.Forms.ComboBox();
            this.txt_NPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1311, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_Especialidad);
            this.tabPage1.Controls.Add(this.txt_ID);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1303, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registo Medicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_Area);
            this.tabPage2.Controls.Add(this.txt_NPaciente);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1303, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro Pacientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1303, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Atenciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidad";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(13, 59);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(13, 118);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 4;
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
            this.cb_Especialidad.Size = new System.Drawing.Size(121, 21);
            this.cb_Especialidad.TabIndex = 5;
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
            this.txt_NPaciente.Location = new System.Drawing.Point(9, 38);
            this.txt_NPaciente.Name = "txt_NPaciente";
            this.txt_NPaciente.Size = new System.Drawing.Size(100, 20);
            this.txt_NPaciente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicina_General,
            this.Ginecologia,
            this.Traumatologia,
            this.Neumologia,
            this.Cardiologia,
            this.Pediatria,
            this.Dermatologia,
            this.Gastroenterologia});
            this.dataGridView1.Location = new System.Drawing.Point(10, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Medicina_General
            // 
            this.Medicina_General.HeaderText = "Medicina General";
            this.Medicina_General.Name = "Medicina_General";
            // 
            // Ginecologia
            // 
            this.Ginecologia.HeaderText = "Ginecologia";
            this.Ginecologia.Name = "Ginecologia";
            // 
            // Traumatologia
            // 
            this.Traumatologia.HeaderText = "Traumatologia";
            this.Traumatologia.Name = "Traumatologia";
            // 
            // Neumologia
            // 
            this.Neumologia.HeaderText = "Neumologia";
            this.Neumologia.Name = "Neumologia";
            // 
            // Cardiologia
            // 
            this.Cardiologia.HeaderText = "Cardiologia";
            this.Cardiologia.Name = "Cardiologia";
            // 
            // Pediatria
            // 
            this.Pediatria.HeaderText = "Pediatria";
            this.Pediatria.Name = "Pediatria";
            // 
            // Dermatologia
            // 
            this.Dermatologia.HeaderText = "Dermatologia";
            this.Dermatologia.Name = "Dermatologia";
            // 
            // Gastroenterologia
            // 
            this.Gastroenterologia.HeaderText = "Gastroenterologia";
            this.Gastroenterologia.Name = "Gastroenterologia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicina_General;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ginecologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traumatologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neumologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cardiologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pediatria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dermatologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gastroenterologia;
    }
}

