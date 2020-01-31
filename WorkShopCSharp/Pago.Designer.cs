namespace WorkShopCSharp
{
    partial class Pago
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.workShopDataSet1 = new WorkShopCSharp.WorkShopDataSet1();
            this.pagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagoTableAdapter = new WorkShopCSharp.WorkShopDataSet1TableAdapters.pagoTableAdapter();
            this.idpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ihssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fosoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netopagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldeduccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workShopDataSet2 = new WorkShopCSharp.WorkShopDataSet2();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new WorkShopCSharp.WorkShopDataSet2TableAdapters.empleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workShopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadoBindingSource;
            this.comboBox1.DisplayMember = "id_empleado";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id_empleado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pago";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpagoDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn,
            this.ihssDataGridViewTextBoxColumn,
            this.fosoviDataGridViewTextBoxColumn,
            this.netopagarDataGridViewTextBoxColumn,
            this.fechapagoDataGridViewTextBoxColumn,
            this.totaldeduccionesDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pagoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(210, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(262, 139);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Realizar Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Empleados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // workShopDataSet1
            // 
            this.workShopDataSet1.DataSetName = "WorkShopDataSet1";
            this.workShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagoBindingSource
            // 
            this.pagoBindingSource.DataMember = "pago";
            this.pagoBindingSource.DataSource = this.workShopDataSet1;
            // 
            // pagoTableAdapter
            // 
            this.pagoTableAdapter.ClearBeforeFill = true;
            // 
            // idpagoDataGridViewTextBoxColumn
            // 
            this.idpagoDataGridViewTextBoxColumn.DataPropertyName = "id_pago";
            this.idpagoDataGridViewTextBoxColumn.HeaderText = "id_pago";
            this.idpagoDataGridViewTextBoxColumn.Name = "idpagoDataGridViewTextBoxColumn";
            this.idpagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "pago";
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            // 
            // ihssDataGridViewTextBoxColumn
            // 
            this.ihssDataGridViewTextBoxColumn.DataPropertyName = "ihss";
            this.ihssDataGridViewTextBoxColumn.HeaderText = "ihss";
            this.ihssDataGridViewTextBoxColumn.Name = "ihssDataGridViewTextBoxColumn";
            // 
            // fosoviDataGridViewTextBoxColumn
            // 
            this.fosoviDataGridViewTextBoxColumn.DataPropertyName = "fosovi";
            this.fosoviDataGridViewTextBoxColumn.HeaderText = "fosovi";
            this.fosoviDataGridViewTextBoxColumn.Name = "fosoviDataGridViewTextBoxColumn";
            // 
            // netopagarDataGridViewTextBoxColumn
            // 
            this.netopagarDataGridViewTextBoxColumn.DataPropertyName = "neto_pagar";
            this.netopagarDataGridViewTextBoxColumn.HeaderText = "neto_pagar";
            this.netopagarDataGridViewTextBoxColumn.Name = "netopagarDataGridViewTextBoxColumn";
            // 
            // fechapagoDataGridViewTextBoxColumn
            // 
            this.fechapagoDataGridViewTextBoxColumn.DataPropertyName = "fecha_pago";
            this.fechapagoDataGridViewTextBoxColumn.HeaderText = "fecha_pago";
            this.fechapagoDataGridViewTextBoxColumn.Name = "fechapagoDataGridViewTextBoxColumn";
            // 
            // totaldeduccionesDataGridViewTextBoxColumn
            // 
            this.totaldeduccionesDataGridViewTextBoxColumn.DataPropertyName = "total_deducciones";
            this.totaldeduccionesDataGridViewTextBoxColumn.HeaderText = "total_deducciones";
            this.totaldeduccionesDataGridViewTextBoxColumn.Name = "totaldeduccionesDataGridViewTextBoxColumn";
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "empleado";
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            // 
            // workShopDataSet2
            // 
            this.workShopDataSet2.DataSetName = "WorkShopDataSet2";
            this.workShopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.workShopDataSet2;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 208);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workShopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private WorkShopDataSet1 workShopDataSet1;
        private System.Windows.Forms.BindingSource pagoBindingSource;
        private WorkShopDataSet1TableAdapters.pagoTableAdapter pagoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ihssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fosoviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netopagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldeduccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private WorkShopDataSet2 workShopDataSet2;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private WorkShopDataSet2TableAdapters.empleadoTableAdapter empleadoTableAdapter;
    }
}