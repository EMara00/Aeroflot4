
namespace Aeroport
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.informationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.informationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseAeportDataSet = new Aeroport.DataBaseAeportDataSet();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.users_12TableAdapter = new Aeroport.DataBaseAeportDataSetTableAdapters.Users_12TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataBaseAeportDataSet11 = new Aeroport.DataBaseAeportDataSet1();
            this.informationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.informationTableAdapter = new Aeroport.DataBaseAeportDataSet1TableAdapters.InformationTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otchestvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grazdanstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrOtpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrPrib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Familia,
            this.Name,
            this.Otchestvo,
            this.Document,
            this.Nomer,
            this.Grazdanstvo,
            this.Compania,
            this.Class,
            this.StrOtpr,
            this.DateTime,
            this.StrPrib});
            this.dataGridView1.DataSource = this.informationBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // informationBindingSource2
            // 
            this.informationBindingSource2.DataMember = "Information";
            // 
            // users12BindingSource
            // 
            this.users12BindingSource.DataMember = "Users_12";
            this.users12BindingSource.DataSource = this.dataBaseAeportDataSet;
            // 
            // dataBaseAeportDataSet
            // 
            this.dataBaseAeportDataSet.DataSetName = "DataBaseAeportDataSet";
            this.dataBaseAeportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.Location = new System.Drawing.Point(1188, 151);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(105, 36);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Control;
            this.Delete.Location = new System.Drawing.Point(1188, 271);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(105, 36);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.Control;
            this.Save.Location = new System.Drawing.Point(925, 308);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(105, 36);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сбросить фильтр";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // users_12TableAdapter
            // 
            this.users_12TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1163, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(1188, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Выйти на форму входа";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1164, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1161, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выбирите ID для удаления";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(798, 308);
            this.button_apply.Margin = new System.Windows.Forms.Padding(2);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(105, 36);
            this.button_apply.TabIndex = 9;
            this.button_apply.Text = "Применить фильтр";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(551, 310);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(191, 20);
            this.textBox7.TabIndex = 70;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(551, 343);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(191, 20);
            this.textBox10.TabIndex = 69;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 343);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 68;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 308);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Дата и время отправления";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Компания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Количество найденных пассажиров:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(994, 352);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 20);
            this.textBox4.TabIndex = 72;
            // 
            // dataBaseAeportDataSet11
            // 
            this.dataBaseAeportDataSet11.DataSetName = "DataBaseAeportDataSet1";
            this.dataBaseAeportDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationBindingSource3
            // 
            this.informationBindingSource3.DataMember = "Information";
            this.informationBindingSource3.DataSource = this.dataBaseAeportDataSet11;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Familia
            // 
            this.Familia.DataPropertyName = "Familia";
            this.Familia.HeaderText = "Фамилия";
            this.Familia.Name = "Familia";
            this.Familia.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Otchestvo
            // 
            this.Otchestvo.DataPropertyName = "Otchestvo";
            this.Otchestvo.HeaderText = "Отчество";
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.ReadOnly = true;
            // 
            // Document
            // 
            this.Document.DataPropertyName = "Document";
            this.Document.HeaderText = "Документ";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            // 
            // Nomer
            // 
            this.Nomer.DataPropertyName = "Nomer";
            this.Nomer.HeaderText = "Номер документа";
            this.Nomer.Name = "Nomer";
            this.Nomer.ReadOnly = true;
            // 
            // Grazdanstvo
            // 
            this.Grazdanstvo.DataPropertyName = "Grazdanstvo";
            this.Grazdanstvo.HeaderText = "Гражданство";
            this.Grazdanstvo.Name = "Grazdanstvo";
            this.Grazdanstvo.ReadOnly = true;
            // 
            // Compania
            // 
            this.Compania.DataPropertyName = "Compania";
            this.Compania.HeaderText = "Компания перелета";
            this.Compania.Name = "Compania";
            this.Compania.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // StrOtpr
            // 
            this.StrOtpr.DataPropertyName = "StrOtpr";
            this.StrOtpr.HeaderText = "Страна и город отправления";
            this.StrOtpr.Name = "StrOtpr";
            this.StrOtpr.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "Дата и время отправления";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // StrPrib
            // 
            this.StrPrib.DataPropertyName = "StrPrib";
            this.StrPrib.HeaderText = "Страна и город прибытия";
            this.StrPrib.Name = "StrPrib";
            this.StrPrib.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1331, 400);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Text = "Регистрация пассажиров";
            this.Load += new System.EventHandler(this.Form_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseAeportDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        public DataBaseAeportDataSet dataBaseAeportDataSet;
        public System.Windows.Forms.BindingSource users12BindingSource;
        public DataBaseAeportDataSetTableAdapters.Users_12TableAdapter users_12TableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        public DataBaseAeportDataSet1 dataBaseAeportDataSet1;
        public System.Windows.Forms.BindingSource informationBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource informationBindingSource1;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource informationBindingSource2;
        private DataBaseAeportDataSet1 dataBaseAeportDataSet11;
        private System.Windows.Forms.BindingSource informationBindingSource3;
        private DataBaseAeportDataSet1TableAdapters.InformationTableAdapter informationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otchestvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grazdanstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrOtpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrPrib;
    }
}