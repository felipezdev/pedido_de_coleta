namespace Pedido_De_Coleta
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSolicitacao = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDataImpressao = new System.Windows.Forms.TextBox();
            this.txtLocalColeta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraSolicitacao = new System.Windows.Forms.TextBox();
            this.txtDataLimite = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdNao = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbColetado = new System.Windows.Forms.RadioButton();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbAlocado = new System.Windows.Forms.RadioButton();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbLiberado = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSolicitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSolicitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLimiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaLimiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataImpressaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDeColetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdcBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pDCDados = new Pedido_De_Coleta.PDCDados();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnhistorico = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pdcTableAdapter2 = new Pedido_De_Coleta.PDCDadosTableAdapters.pdcTableAdapter();
            this.rdSim = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdcBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDCDados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 162);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.dateTimePicker2);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(731, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(154, 100);
            this.panel6.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Data Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data Inicial";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Solicitação";
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(734, 112);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(141, 47);
            this.btPesquisar.TabIndex = 4;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.txtSolicitacao);
            this.panel5.Controls.Add(this.txtCliente);
            this.panel5.Controls.Add(this.txtDataImpressao);
            this.panel5.Controls.Add(this.txtLocalColeta);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtHoraSolicitacao);
            this.panel5.Controls.Add(this.txtDataLimite);
            this.panel5.Controls.Add(this.txtNumero);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(220, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(505, 162);
            this.panel5.TabIndex = 3;
            // 
            // txtSolicitacao
            // 
            this.txtSolicitacao.Location = new System.Drawing.Point(3, 132);
            this.txtSolicitacao.Name = "txtSolicitacao";
            this.txtSolicitacao.Size = new System.Drawing.Size(256, 20);
            this.txtSolicitacao.TabIndex = 4;
            this.txtSolicitacao.TextChanged += new System.EventHandler(this.txtSolicitacao_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(263, 44);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(239, 20);
            this.txtCliente.TabIndex = 4;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // txtDataImpressao
            // 
            this.txtDataImpressao.Location = new System.Drawing.Point(263, 87);
            this.txtDataImpressao.Name = "txtDataImpressao";
            this.txtDataImpressao.Size = new System.Drawing.Size(239, 20);
            this.txtDataImpressao.TabIndex = 4;
            this.txtDataImpressao.TextChanged += new System.EventHandler(this.txtDataImpressao_TextChanged);
            // 
            // txtLocalColeta
            // 
            this.txtLocalColeta.Location = new System.Drawing.Point(6, 87);
            this.txtLocalColeta.Name = "txtLocalColeta";
            this.txtLocalColeta.Size = new System.Drawing.Size(256, 20);
            this.txtLocalColeta.TabIndex = 4;
            this.txtLocalColeta.TextChanged += new System.EventHandler(this.txtLocalColeta_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data solicit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Hora Solicit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Data Limite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Data Impressão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Local de Coleta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Número";
            // 
            // txtHoraSolicitacao
            // 
            this.txtHoraSolicitacao.Location = new System.Drawing.Point(394, 132);
            this.txtHoraSolicitacao.Name = "txtHoraSolicitacao";
            this.txtHoraSolicitacao.Size = new System.Drawing.Size(108, 20);
            this.txtHoraSolicitacao.TabIndex = 1;
            this.txtHoraSolicitacao.TextChanged += new System.EventHandler(this.txtHoraSolicitacao_TextChanged);
            // 
            // txtDataLimite
            // 
            this.txtDataLimite.Location = new System.Drawing.Point(263, 132);
            this.txtDataLimite.Name = "txtDataLimite";
            this.txtDataLimite.Size = new System.Drawing.Size(125, 20);
            this.txtDataLimite.TabIndex = 1;
            this.txtDataLimite.TextChanged += new System.EventHandler(this.txtDataLimite_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(251, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dados Para Pesquisa";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.rdSim);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.rdNao);
            this.panel4.Controls.Add(this.radioButton9);
            this.panel4.Location = new System.Drawing.Point(110, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(104, 162);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "•Impresso";
            // 
            // rdNao
            // 
            this.rdNao.AutoSize = true;
            this.rdNao.Location = new System.Drawing.Point(2, 21);
            this.rdNao.Name = "rdNao";
            this.rdNao.Size = new System.Drawing.Size(45, 17);
            this.rdNao.TabIndex = 1;
            this.rdNao.TabStop = true;
            this.rdNao.Text = "Não";
            this.rdNao.UseVisualStyleBackColor = true;
            this.rdNao.CheckedChanged += new System.EventHandler(this.rdNao_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(2, 63);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(57, 17);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Ambos";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rbColetado);
            this.panel3.Controls.Add(this.rbPendente);
            this.panel3.Controls.Add(this.rbTodos);
            this.panel3.Controls.Add(this.rbAlocado);
            this.panel3.Controls.Add(this.rbCancelado);
            this.panel3.Controls.Add(this.rbLiberado);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 162);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "•Status";
            // 
            // rbColetado
            // 
            this.rbColetado.AutoSize = true;
            this.rbColetado.Location = new System.Drawing.Point(2, 88);
            this.rbColetado.Name = "rbColetado";
            this.rbColetado.Size = new System.Drawing.Size(67, 17);
            this.rbColetado.TabIndex = 1;
            this.rbColetado.TabStop = true;
            this.rbColetado.Text = "Coletado";
            this.rbColetado.UseVisualStyleBackColor = true;
            this.rbColetado.CheckedChanged += new System.EventHandler(this.rbColetado_CheckedChanged);
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Location = new System.Drawing.Point(3, 22);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(71, 17);
            this.rbPendente.TabIndex = 1;
            this.rbPendente.TabStop = true;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(2, 132);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(60, 17);
            this.rbTodos.TabIndex = 1;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbAlocado
            // 
            this.rbAlocado.AutoSize = true;
            this.rbAlocado.Location = new System.Drawing.Point(2, 44);
            this.rbAlocado.Name = "rbAlocado";
            this.rbAlocado.Size = new System.Drawing.Size(64, 17);
            this.rbAlocado.TabIndex = 1;
            this.rbAlocado.TabStop = true;
            this.rbAlocado.Text = "Alocado";
            this.rbAlocado.UseVisualStyleBackColor = true;
            this.rbAlocado.CheckedChanged += new System.EventHandler(this.rbAlocado_CheckedChanged);
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Location = new System.Drawing.Point(2, 110);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(76, 17);
            this.rbCancelado.TabIndex = 1;
            this.rbCancelado.TabStop = true;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            this.rbCancelado.CheckedChanged += new System.EventHandler(this.rbCancelado_CheckedChanged);
            // 
            // rbLiberado
            // 
            this.rbLiberado.AutoSize = true;
            this.rbLiberado.Location = new System.Drawing.Point(2, 66);
            this.rbLiberado.Name = "rbLiberado";
            this.rbLiberado.Size = new System.Drawing.Size(66, 17);
            this.rbLiberado.TabIndex = 1;
            this.rbLiberado.TabStop = true;
            this.rbLiberado.Text = "Liberado";
            this.rbLiberado.UseVisualStyleBackColor = true;
            this.rbLiberado.CheckedChanged += new System.EventHandler(this.rbLiberado_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 187);
            this.panel2.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel16.Controls.Add(this.dataGridView1);
            this.panel16.Controls.Add(this.button8);
            this.panel16.Controls.Add(this.button9);
            this.panel16.Controls.Add(this.btnImprimir);
            this.panel16.Controls.Add(this.btnhistorico);
            this.panel16.Controls.Add(this.button6);
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(882, 174);
            this.panel16.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.dataSolicitDataGridViewTextBoxColumn,
            this.horaSolicitDataGridViewTextBoxColumn,
            this.dataLimiteDataGridViewTextBoxColumn,
            this.horaLimiteDataGridViewTextBoxColumn,
            this.dataImpressaoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.localDeColetaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pdcBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 138);
            this.dataGridView1.TabIndex = 4;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // dataSolicitDataGridViewTextBoxColumn
            // 
            this.dataSolicitDataGridViewTextBoxColumn.DataPropertyName = "Data Solicit";
            this.dataSolicitDataGridViewTextBoxColumn.HeaderText = "Data Solicit";
            this.dataSolicitDataGridViewTextBoxColumn.Name = "dataSolicitDataGridViewTextBoxColumn";
            // 
            // horaSolicitDataGridViewTextBoxColumn
            // 
            this.horaSolicitDataGridViewTextBoxColumn.DataPropertyName = "Hora Solicit";
            this.horaSolicitDataGridViewTextBoxColumn.HeaderText = "Hora Solicit";
            this.horaSolicitDataGridViewTextBoxColumn.Name = "horaSolicitDataGridViewTextBoxColumn";
            // 
            // dataLimiteDataGridViewTextBoxColumn
            // 
            this.dataLimiteDataGridViewTextBoxColumn.DataPropertyName = "Data Limite";
            this.dataLimiteDataGridViewTextBoxColumn.HeaderText = "Data Limite";
            this.dataLimiteDataGridViewTextBoxColumn.Name = "dataLimiteDataGridViewTextBoxColumn";
            // 
            // horaLimiteDataGridViewTextBoxColumn
            // 
            this.horaLimiteDataGridViewTextBoxColumn.DataPropertyName = "Hora Limite";
            this.horaLimiteDataGridViewTextBoxColumn.HeaderText = "Hora Limite";
            this.horaLimiteDataGridViewTextBoxColumn.Name = "horaLimiteDataGridViewTextBoxColumn";
            // 
            // dataImpressaoDataGridViewTextBoxColumn
            // 
            this.dataImpressaoDataGridViewTextBoxColumn.DataPropertyName = "Data Impressao";
            this.dataImpressaoDataGridViewTextBoxColumn.HeaderText = "Data Impressao";
            this.dataImpressaoDataGridViewTextBoxColumn.Name = "dataImpressaoDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // localDeColetaDataGridViewTextBoxColumn
            // 
            this.localDeColetaDataGridViewTextBoxColumn.DataPropertyName = "Local de Coleta";
            this.localDeColetaDataGridViewTextBoxColumn.HeaderText = "Local de Coleta";
            this.localDeColetaDataGridViewTextBoxColumn.Name = "localDeColetaDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // pdcBindingSource2
            // 
            this.pdcBindingSource2.DataMember = "pdc";
            this.pdcBindingSource2.DataSource = this.pDCDados;
            // 
            // pDCDados
            // 
            this.pDCDados.DataSetName = "PDCDados";
            this.pDCDados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(708, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 22);
            this.button8.TabIndex = 3;
            this.button8.Text = "&Excluir";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(789, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 26);
            this.button9.TabIndex = 3;
            this.button9.Text = "&Sair";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(9, 145);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 25);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnhistorico
            // 
            this.btnhistorico.Location = new System.Drawing.Point(90, 145);
            this.btnhistorico.Name = "btnhistorico";
            this.btnhistorico.Size = new System.Drawing.Size(75, 25);
            this.btnhistorico.TabIndex = 3;
            this.btnhistorico.Text = "&Histórico";
            this.btnhistorico.UseVisualStyleBackColor = true;
            this.btnhistorico.Click += new System.EventHandler(this.btnOpenForm2_Click_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(627, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 22);
            this.button6.TabIndex = 3;
            this.button6.Text = "&Incluir";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pdcTableAdapter2
            // 
            this.pdcTableAdapter2.ClearBeforeFill = true;
            // 
            // rdSim
            // 
            this.rdSim.AutoSize = true;
            this.rdSim.Location = new System.Drawing.Point(3, 41);
            this.rdSim.Name = "rdSim";
            this.rdSim.Size = new System.Drawing.Size(42, 17);
            this.rdSim.TabIndex = 2;
            this.rdSim.TabStop = true;
            this.rdSim.Text = "Sim";
            this.rdSim.UseVisualStyleBackColor = true;
            this.rdSim.CheckedChanged += new System.EventHandler(this.rdSim_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido De Coleta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdcBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDCDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbColetado;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbLiberado;
        private System.Windows.Forms.RadioButton rbAlocado;
        private System.Windows.Forms.RadioButton rbPendente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdNao;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnhistorico;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSolicitacao;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtDataImpressao;
        private System.Windows.Forms.TextBox txtLocalColeta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraSolicitacao;
        private System.Windows.Forms.TextBox txtDataLimite;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PDCDados pDCDados;
        private System.Windows.Forms.BindingSource pdcBindingSource2;
        private PDCDadosTableAdapters.pdcTableAdapter pdcTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSolicitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSolicitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLimiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaLimiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataImpressaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDeColetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rdSim;
    }
}

