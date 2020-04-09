namespace CalculoFinanceiro
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSinal = new System.Windows.Forms.TextBox();
            this.textBoxParcela1 = new System.Windows.Forms.TextBox();
            this.textBoxFinanciado = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxParcela2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxJuros = new System.Windows.Forms.ComboBox();
            this.textBoxJuros = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewCalculo = new System.Windows.Forms.DataGridView();
            this.colParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDevedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBoxJuros60 = new System.Windows.Forms.TextBox();
            this.textBoxJuros90 = new System.Windows.Forms.TextBox();
            this.textBoxJuros120 = new System.Windows.Forms.TextBox();
            this.textBoxJuros150 = new System.Windows.Forms.TextBox();
            this.textBoxJuros180 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox120 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox150 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox180 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewSinal = new System.Windows.Forms.DataGridView();
            this.colParc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMeses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorParc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalculo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinal)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSinal
            // 
            this.textBoxSinal.Location = new System.Drawing.Point(5, 33);
            this.textBoxSinal.Name = "textBoxSinal";
            this.textBoxSinal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSinal.TabIndex = 1;
            this.textBoxSinal.Text = "1";
            this.textBoxSinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSinal.Click += new System.EventHandler(this.textBoxSinal_Click);
            this.textBoxSinal.TextChanged += new System.EventHandler(this.textBoxSinal_TextChanged);
            // 
            // textBoxParcela1
            // 
            this.textBoxParcela1.Location = new System.Drawing.Point(111, 33);
            this.textBoxParcela1.Name = "textBoxParcela1";
            this.textBoxParcela1.Size = new System.Drawing.Size(45, 20);
            this.textBoxParcela1.TabIndex = 3;
            this.textBoxParcela1.Text = "0";
            this.textBoxParcela1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxParcela1.TextChanged += new System.EventHandler(this.textBoxParcela1_TextChanged);
            this.textBoxParcela1.Leave += new System.EventHandler(this.textBoxParcela1_Leave);
            // 
            // textBoxFinanciado
            // 
            this.textBoxFinanciado.Location = new System.Drawing.Point(5, 71);
            this.textBoxFinanciado.Name = "textBoxFinanciado";
            this.textBoxFinanciado.ReadOnly = true;
            this.textBoxFinanciado.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinanciado.TabIndex = 7;
            this.textBoxFinanciado.Text = "1";
            this.textBoxFinanciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxFinanciado.Click += new System.EventHandler(this.textBoxFinanciado_Click);
            this.textBoxFinanciado.TextChanged += new System.EventHandler(this.textBoxFinanciado_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.textBoxParcela2);
            this.groupBox1.Controls.Add(this.textBoxSinal);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxParcela1);
            this.groupBox1.Controls.Add(this.textBoxFinanciado);
            this.groupBox1.Location = new System.Drawing.Point(278, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condições de Pagamentos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parcelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parcela";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Financiado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinal:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Location = new System.Drawing.Point(162, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(275, 20);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBoxParcela2
            // 
            this.textBoxParcela2.Location = new System.Drawing.Point(111, 71);
            this.textBoxParcela2.Name = "textBoxParcela2";
            this.textBoxParcela2.Size = new System.Drawing.Size(45, 20);
            this.textBoxParcela2.TabIndex = 9;
            this.textBoxParcela2.Text = "180";
            this.textBoxParcela2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxParcela2.TextChanged += new System.EventHandler(this.textBoxParcela2_TextChanged);
            this.textBoxParcela2.Leave += new System.EventHandler(this.textBoxParcela2_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxJuros);
            this.groupBox2.Controls.Add(this.textBoxJuros);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxVenda);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Financiamento:";
            // 
            // comboBoxJuros
            // 
            this.comboBoxJuros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJuros.FormattingEnabled = true;
            this.comboBoxJuros.Items.AddRange(new object[] {
            "Ao ano.",
            "Ao mês."});
            this.comboBoxJuros.Location = new System.Drawing.Point(179, 35);
            this.comboBoxJuros.Name = "comboBoxJuros";
            this.comboBoxJuros.Size = new System.Drawing.Size(70, 21);
            this.comboBoxJuros.TabIndex = 5;
            // 
            // textBoxJuros
            // 
            this.textBoxJuros.Location = new System.Drawing.Point(112, 35);
            this.textBoxJuros.Name = "textBoxJuros";
            this.textBoxJuros.Size = new System.Drawing.Size(60, 20);
            this.textBoxJuros.TabIndex = 3;
            this.textBoxJuros.Text = "1";
            this.textBoxJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJuros.Click += new System.EventHandler(this.textBoxJuros_Click);
            this.textBoxJuros.TextChanged += new System.EventHandler(this.textBoxJuros_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Juros:";
            // 
            // textBoxVenda
            // 
            this.textBoxVenda.Location = new System.Drawing.Point(6, 35);
            this.textBoxVenda.Name = "textBoxVenda";
            this.textBoxVenda.Size = new System.Drawing.Size(100, 20);
            this.textBoxVenda.TabIndex = 1;
            this.textBoxVenda.Text = "1";
            this.textBoxVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxVenda.Click += new System.EventHandler(this.textBoxVenda_Click);
            this.textBoxVenda.TextChanged += new System.EventHandler(this.textBoxVenda_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor de Venda:";
            // 
            // dataGridViewCalculo
            // 
            this.dataGridViewCalculo.AllowUserToAddRows = false;
            this.dataGridViewCalculo.AllowUserToDeleteRows = false;
            this.dataGridViewCalculo.AllowUserToOrderColumns = true;
            this.dataGridViewCalculo.AllowUserToResizeColumns = false;
            this.dataGridViewCalculo.AllowUserToResizeRows = false;
            this.dataGridViewCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParcela,
            this.colMes,
            this.colValor,
            this.colAmort,
            this.colJuros,
            this.colDevedor});
            this.dataGridViewCalculo.Location = new System.Drawing.Point(12, 125);
            this.dataGridViewCalculo.Name = "dataGridViewCalculo";
            this.dataGridViewCalculo.RowHeadersWidth = 10;
            this.dataGridViewCalculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCalculo.ShowCellErrors = false;
            this.dataGridViewCalculo.ShowCellToolTips = false;
            this.dataGridViewCalculo.ShowEditingIcon = false;
            this.dataGridViewCalculo.ShowRowErrors = false;
            this.dataGridViewCalculo.Size = new System.Drawing.Size(618, 478);
            this.dataGridViewCalculo.TabIndex = 3;
            this.dataGridViewCalculo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewCalculo_RowPostPaint);
            // 
            // colParcela
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colParcela.DefaultCellStyle = dataGridViewCellStyle1;
            this.colParcela.HeaderText = "Parcela:";
            this.colParcela.Name = "colParcela";
            this.colParcela.Width = 50;
            // 
            // colMes
            // 
            this.colMes.HeaderText = "Meses:";
            this.colMes.Name = "colMes";
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor:";
            this.colValor.Name = "colValor";
            // 
            // colAmort
            // 
            this.colAmort.HeaderText = "Amortização:";
            this.colAmort.Name = "colAmort";
            // 
            // colJuros
            // 
            this.colJuros.HeaderText = "Juros:";
            this.colJuros.Name = "colJuros";
            // 
            // colDevedor
            // 
            this.colDevedor.HeaderText = "Saldo Devedor:";
            this.colDevedor.Name = "colDevedor";
            this.colDevedor.Width = 125;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCalcular.Enabled = false;
            this.buttonCalcular.FlatAppearance.BorderSize = 0;
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.ForeColor = System.Drawing.Color.White;
            this.buttonCalcular.Image = global::CalculoFinanceiro.Properties.Resources.icons8_Math_32;
            this.buttonCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalcular.Location = new System.Drawing.Point(727, 54);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(103, 40);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBoxJuros60);
            this.groupBox3.Controls.Add(this.textBoxJuros90);
            this.groupBox3.Controls.Add(this.textBoxJuros120);
            this.groupBox3.Controls.Add(this.textBoxJuros150);
            this.groupBox3.Controls.Add(this.textBoxJuros180);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox60);
            this.groupBox3.Controls.Add(this.textBox90);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox120);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox150);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox180);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(636, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 164);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumo:";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(6, 136);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(61, 20);
            this.textBox10.TabIndex = 2;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "60";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJuros60
            // 
            this.textBoxJuros60.Location = new System.Drawing.Point(179, 136);
            this.textBoxJuros60.Name = "textBoxJuros60";
            this.textBoxJuros60.Size = new System.Drawing.Size(60, 20);
            this.textBoxJuros60.TabIndex = 3;
            this.textBoxJuros60.Text = "1";
            this.textBoxJuros60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJuros60.Click += new System.EventHandler(this.textBoxJuros_Click);
            this.textBoxJuros60.TextChanged += new System.EventHandler(this.textBoxJuros_TextChanged);
            // 
            // textBoxJuros90
            // 
            this.textBoxJuros90.Location = new System.Drawing.Point(179, 110);
            this.textBoxJuros90.Name = "textBoxJuros90";
            this.textBoxJuros90.Size = new System.Drawing.Size(60, 20);
            this.textBoxJuros90.TabIndex = 3;
            this.textBoxJuros90.Text = "1";
            this.textBoxJuros90.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJuros90.Click += new System.EventHandler(this.textBoxJuros_Click);
            this.textBoxJuros90.TextChanged += new System.EventHandler(this.textBoxJuros_TextChanged);
            // 
            // textBoxJuros120
            // 
            this.textBoxJuros120.Location = new System.Drawing.Point(179, 84);
            this.textBoxJuros120.Name = "textBoxJuros120";
            this.textBoxJuros120.Size = new System.Drawing.Size(60, 20);
            this.textBoxJuros120.TabIndex = 3;
            this.textBoxJuros120.Text = "1";
            this.textBoxJuros120.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJuros120.Click += new System.EventHandler(this.textBoxJuros_Click);
            this.textBoxJuros120.TextChanged += new System.EventHandler(this.textBoxJuros_TextChanged);
            // 
            // textBoxJuros150
            // 
            this.textBoxJuros150.Location = new System.Drawing.Point(179, 58);
            this.textBoxJuros150.Name = "textBoxJuros150";
            this.textBoxJuros150.Size = new System.Drawing.Size(60, 20);
            this.textBoxJuros150.TabIndex = 3;
            this.textBoxJuros150.Text = "1";
            this.textBoxJuros150.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJuros150.Click += new System.EventHandler(this.textBoxJuros_Click);
            this.textBoxJuros150.TextChanged += new System.EventHandler(this.textBoxJuros_TextChanged);
            // 
            // textBoxJuros180
            // 
            this.textBoxJuros180.Location = new System.Drawing.Point(179, 32);
            this.textBoxJuros180.Name = "textBoxJuros180";
            this.textBoxJuros180.Size = new System.Drawing.Size(60, 20);
            this.textBoxJuros180.TabIndex = 3;
            this.textBoxJuros180.Text = "1";
            this.textBoxJuros180.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJuros180.Click += new System.EventHandler(this.textBoxJuros_Click);
            this.textBoxJuros180.TextChanged += new System.EventHandler(this.textBoxJuros_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(6, 110);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(61, 20);
            this.textBox8.TabIndex = 2;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "90";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(73, 136);
            this.textBox60.Name = "textBox60";
            this.textBox60.ReadOnly = true;
            this.textBox60.Size = new System.Drawing.Size(100, 20);
            this.textBox60.TabIndex = 1;
            this.textBox60.TabStop = false;
            this.textBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox90
            // 
            this.textBox90.Location = new System.Drawing.Point(73, 110);
            this.textBox90.Name = "textBox90";
            this.textBox90.ReadOnly = true;
            this.textBox90.Size = new System.Drawing.Size(100, 20);
            this.textBox90.TabIndex = 1;
            this.textBox90.TabStop = false;
            this.textBox90.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(6, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(61, 20);
            this.textBox6.TabIndex = 2;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "120";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox120
            // 
            this.textBox120.Location = new System.Drawing.Point(73, 84);
            this.textBox120.Name = "textBox120";
            this.textBox120.ReadOnly = true;
            this.textBox120.Size = new System.Drawing.Size(100, 20);
            this.textBox120.TabIndex = 1;
            this.textBox120.TabStop = false;
            this.textBox120.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(6, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(61, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "150";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox150
            // 
            this.textBox150.Location = new System.Drawing.Point(73, 58);
            this.textBox150.Name = "textBox150";
            this.textBox150.ReadOnly = true;
            this.textBox150.Size = new System.Drawing.Size(100, 20);
            this.textBox150.TabIndex = 1;
            this.textBox150.TabStop = false;
            this.textBox150.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "180";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox180
            // 
            this.textBox180.Location = new System.Drawing.Point(73, 32);
            this.textBox180.Name = "textBox180";
            this.textBox180.ReadOnly = true;
            this.textBox180.Size = new System.Drawing.Size(100, 20);
            this.textBox180.TabIndex = 1;
            this.textBox180.TabStop = false;
            this.textBox180.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Meses:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(176, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Juros a.a:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Valor de Venda:";
            // 
            // dataGridViewSinal
            // 
            this.dataGridViewSinal.AllowUserToAddRows = false;
            this.dataGridViewSinal.AllowUserToDeleteRows = false;
            this.dataGridViewSinal.AllowUserToOrderColumns = true;
            this.dataGridViewSinal.AllowUserToResizeColumns = false;
            this.dataGridViewSinal.AllowUserToResizeRows = false;
            this.dataGridViewSinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParc,
            this.colMeses,
            this.colValorParc});
            this.dataGridViewSinal.Location = new System.Drawing.Point(636, 125);
            this.dataGridViewSinal.Name = "dataGridViewSinal";
            this.dataGridViewSinal.RowHeadersWidth = 10;
            this.dataGridViewSinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSinal.Size = new System.Drawing.Size(288, 308);
            this.dataGridViewSinal.TabIndex = 5;
            this.dataGridViewSinal.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewSinal_RowPostPaint);
            // 
            // colParc
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colParc.DefaultCellStyle = dataGridViewCellStyle2;
            this.colParc.HeaderText = "Parcela:";
            this.colParc.Name = "colParc";
            this.colParc.Width = 50;
            // 
            // colMeses
            // 
            this.colMeses.HeaderText = "Meses:";
            this.colMeses.Name = "colMeses";
            // 
            // colValorParc
            // 
            this.colValorParc.HeaderText = "Valor:";
            this.colValorParc.Name = "colValorParc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(633, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Sinal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Financiamento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 616);
            this.Controls.Add(this.dataGridViewSinal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.dataGridViewCalculo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação de Cálculo para Ivisson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalculo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSinal;
        private System.Windows.Forms.TextBox textBoxParcela1;
        private System.Windows.Forms.TextBox textBoxFinanciado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxParcela2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxJuros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxJuros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewCalculo;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox180;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox90;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox120;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox150;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDevedor;
        private System.Windows.Forms.DataGridView dataGridViewSinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxJuros60;
        private System.Windows.Forms.TextBox textBoxJuros90;
        private System.Windows.Forms.TextBox textBoxJuros120;
        private System.Windows.Forms.TextBox textBoxJuros150;
        private System.Windows.Forms.TextBox textBoxJuros180;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorParc;
    }
}

