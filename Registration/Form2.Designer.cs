namespace Registration
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ппDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОУчастникаКонференцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОРуководителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.участникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.регистрацияDataSet = new Registration.РегистрацияDataSet();
            this.участникиTableAdapter = new Registration.РегистрацияDataSetTableAdapters.УчастникиTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.регистрацияDataSet1 = new Registration.РегистрацияDataSet1();
            this.участникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.участникиTableAdapter1 = new Registration.РегистрацияDataSet1TableAdapters.УчастникиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.участникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.регистрацияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.регистрацияDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.участникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ппDataGridViewTextBoxColumn,
            this.фИОУчастникаКонференцииDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.фИОРуководителяDataGridViewTextBoxColumn,
            this.названиеРаботыDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.участникиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1116, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // ппDataGridViewTextBoxColumn
            // 
            this.ппDataGridViewTextBoxColumn.DataPropertyName = "№ п/п";
            this.ппDataGridViewTextBoxColumn.HeaderText = "№ п/п";
            this.ппDataGridViewTextBoxColumn.Name = "ппDataGridViewTextBoxColumn";
            this.ппDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОУчастникаКонференцииDataGridViewTextBoxColumn
            // 
            this.фИОУчастникаКонференцииDataGridViewTextBoxColumn.DataPropertyName = "ФИО участника конференции";
            this.фИОУчастникаКонференцииDataGridViewTextBoxColumn.HeaderText = "ФИО участника конференции";
            this.фИОУчастникаКонференцииDataGridViewTextBoxColumn.Name = "фИОУчастникаКонференцииDataGridViewTextBoxColumn";
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа №";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа №";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            // 
            // фИОРуководителяDataGridViewTextBoxColumn
            // 
            this.фИОРуководителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО руководителя";
            this.фИОРуководителяDataGridViewTextBoxColumn.HeaderText = "ФИО руководителя";
            this.фИОРуководителяDataGridViewTextBoxColumn.Name = "фИОРуководителяDataGridViewTextBoxColumn";
            // 
            // названиеРаботыDataGridViewTextBoxColumn
            // 
            this.названиеРаботыDataGridViewTextBoxColumn.DataPropertyName = "Название работы";
            this.названиеРаботыDataGridViewTextBoxColumn.HeaderText = "Название работы";
            this.названиеРаботыDataGridViewTextBoxColumn.Name = "названиеРаботыDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // участникиBindingSource
            // 
            this.участникиBindingSource.DataMember = "Участники";
            this.участникиBindingSource.DataSource = this.регистрацияDataSet;
            // 
            // регистрацияDataSet
            // 
            this.регистрацияDataSet.DataSetName = "РегистрацияDataSet";
            this.регистрацияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // участникиTableAdapter
            // 
            this.участникиTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 31);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(409, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // регистрацияDataSet1
            // 
            this.регистрацияDataSet1.DataSetName = "РегистрацияDataSet1";
            this.регистрацияDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // участникиBindingSource1
            // 
            this.участникиBindingSource1.DataMember = "Участники";
            this.участникиBindingSource1.DataSource = this.регистрацияDataSet1;
            // 
            // участникиTableAdapter1
            // 
            this.участникиTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.участникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.регистрацияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.регистрацияDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.участникиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private РегистрацияDataSet регистрацияDataSet;
        private System.Windows.Forms.BindingSource участникиBindingSource;
        private РегистрацияDataSetTableAdapters.УчастникиTableAdapter участникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ппDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОУчастникаКонференцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОРуководителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private РегистрацияDataSet1 регистрацияDataSet1;
        private System.Windows.Forms.BindingSource участникиBindingSource1;
        private РегистрацияDataSet1TableAdapters.УчастникиTableAdapter участникиTableAdapter1;
    }
}