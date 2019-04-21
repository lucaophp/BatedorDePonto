namespace CadastroAlunos
{
    partial class FRMAdmin
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
            this.AdminTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCONTROLEDataSet = new CadastroAlunos.DBCONTROLEDataSet();
            this.Cadastrar_Usuario = new System.Windows.Forms.TabPage();
            this.excluirBTN = new System.Windows.Forms.Button();
            this.IN_Cad_Nome = new System.Windows.Forms.TextBox();
            this.IN_Cad_Matricula = new System.Windows.Forms.TextBox();
            this.cadastrarBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_listaadm = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txt_Pass_Adm = new System.Windows.Forms.TextBox();
            this.txt_Login_Adm = new System.Windows.Forms.TextBox();
            this.txt_Mat_Adm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpresencaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_usuarioTableAdapter2 = new CadastroAlunos.DBCONTROLEDataSetTableAdapters.tb_usuarioTableAdapter();
            this.tbpresencaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_presencaTableAdapter = new CadastroAlunos.DBCONTROLEDataSetTableAdapters.tb_presencaTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.mudaURL = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AdminTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCONTROLEDataSet)).BeginInit();
            this.Cadastrar_Usuario.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpresencaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpresencaBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTab
            // 
            this.AdminTab.Controls.Add(this.tabPage1);
            this.AdminTab.Controls.Add(this.Cadastrar_Usuario);
            this.AdminTab.Controls.Add(this.tabPage2);
            this.AdminTab.Controls.Add(this.tabPage3);
            this.AdminTab.Controls.Add(this.tabPage4);
            this.AdminTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTab.Location = new System.Drawing.Point(0, 0);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.SelectedIndex = 0;
            this.AdminTab.Size = new System.Drawing.Size(656, 321);
            this.AdminTab.TabIndex = 0;
            this.AdminTab.Click += new System.EventHandler(this.onclick);
            this.AdminTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_user);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios Cadastrados";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbusuarioBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbusuarioBindingSource
            // 
            this.tbusuarioBindingSource.DataMember = "tb_usuario";
            this.tbusuarioBindingSource.DataSource = this.dBCONTROLEDataSet;
            // 
            // dBCONTROLEDataSet
            // 
            this.dBCONTROLEDataSet.DataSetName = "DBCONTROLEDataSet";
            this.dBCONTROLEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cadastrar_Usuario
            // 
            this.Cadastrar_Usuario.Controls.Add(this.excluirBTN);
            this.Cadastrar_Usuario.Controls.Add(this.IN_Cad_Nome);
            this.Cadastrar_Usuario.Controls.Add(this.IN_Cad_Matricula);
            this.Cadastrar_Usuario.Controls.Add(this.cadastrarBTN);
            this.Cadastrar_Usuario.Controls.Add(this.label2);
            this.Cadastrar_Usuario.Controls.Add(this.label1);
            this.Cadastrar_Usuario.Location = new System.Drawing.Point(4, 22);
            this.Cadastrar_Usuario.Name = "Cadastrar_Usuario";
            this.Cadastrar_Usuario.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastrar_Usuario.Size = new System.Drawing.Size(648, 295);
            this.Cadastrar_Usuario.TabIndex = 1;
            this.Cadastrar_Usuario.Text = "Cadastrar Usuarios";
            this.Cadastrar_Usuario.UseVisualStyleBackColor = true;
            // 
            // excluirBTN
            // 
            this.excluirBTN.Location = new System.Drawing.Point(252, 130);
            this.excluirBTN.Name = "excluirBTN";
            this.excluirBTN.Size = new System.Drawing.Size(75, 23);
            this.excluirBTN.TabIndex = 5;
            this.excluirBTN.Text = "Excluir";
            this.excluirBTN.UseVisualStyleBackColor = true;
            this.excluirBTN.Click += new System.EventHandler(this.excluirBTN_Click);
            // 
            // IN_Cad_Nome
            // 
            this.IN_Cad_Nome.Location = new System.Drawing.Point(159, 93);
            this.IN_Cad_Nome.Name = "IN_Cad_Nome";
            this.IN_Cad_Nome.Size = new System.Drawing.Size(291, 20);
            this.IN_Cad_Nome.TabIndex = 4;
            // 
            // IN_Cad_Matricula
            // 
            this.IN_Cad_Matricula.Location = new System.Drawing.Point(159, 42);
            this.IN_Cad_Matricula.Name = "IN_Cad_Matricula";
            this.IN_Cad_Matricula.Size = new System.Drawing.Size(183, 20);
            this.IN_Cad_Matricula.TabIndex = 3;
            // 
            // cadastrarBTN
            // 
            this.cadastrarBTN.Location = new System.Drawing.Point(159, 130);
            this.cadastrarBTN.Name = "cadastrarBTN";
            this.cadastrarBTN.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBTN.TabIndex = 2;
            this.cadastrarBTN.Text = "Cadastrar";
            this.cadastrarBTN.UseVisualStyleBackColor = true;
            this.cadastrarBTN.Click += new System.EventHandler(this.cadastrarBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a Matricula:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 295);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Gerenciamento de Horas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_matricula);
            this.panel1.Controls.Add(this.btn_Filtrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataInicio);
            this.panel1.Controls.Add(this.dataFim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 289);
            this.panel1.TabIndex = 3;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(433, 5);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 4;
            this.txt_matricula.Text = "##Matricula##";
            this.txt_matricula.Click += new System.EventHandler(this.txt_matricula_Click);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(561, 3);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar.TabIndex = 3;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 254);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(641, 254);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.horas_Click);
            // 
            // dataInicio
            // 
            this.dataInicio.Location = new System.Drawing.Point(16, 6);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(193, 20);
            this.dataInicio.TabIndex = 0;
            // 
            // dataFim
            // 
            this.dataFim.Location = new System.Drawing.Point(215, 6);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(197, 20);
            this.dataFim.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.lbl_listaadm);
            this.tabPage3.Controls.Add(this.btn_Excluir);
            this.tabPage3.Controls.Add(this.btn_Cadastrar);
            this.tabPage3.Controls.Add(this.txt_Pass_Adm);
            this.tabPage3.Controls.Add(this.txt_Login_Adm);
            this.tabPage3.Controls.Add(this.txt_Mat_Adm);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(648, 295);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Cadastro de Administrador";
            // 
            // lbl_listaadm
            // 
            this.lbl_listaadm.AutoSize = true;
            this.lbl_listaadm.Location = new System.Drawing.Point(406, 48);
            this.lbl_listaadm.Name = "lbl_listaadm";
            this.lbl_listaadm.Size = new System.Drawing.Size(12, 13);
            this.lbl_listaadm.TabIndex = 8;
            this.lbl_listaadm.Text = "\\";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(228, 177);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 7;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(112, 177);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 6;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // txt_Pass_Adm
            // 
            this.txt_Pass_Adm.Location = new System.Drawing.Point(112, 137);
            this.txt_Pass_Adm.Name = "txt_Pass_Adm";
            this.txt_Pass_Adm.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass_Adm.TabIndex = 5;
            // 
            // txt_Login_Adm
            // 
            this.txt_Login_Adm.Location = new System.Drawing.Point(112, 91);
            this.txt_Login_Adm.Name = "txt_Login_Adm";
            this.txt_Login_Adm.Size = new System.Drawing.Size(162, 20);
            this.txt_Login_Adm.TabIndex = 4;
            // 
            // txt_Mat_Adm
            // 
            this.txt_Mat_Adm.Location = new System.Drawing.Point(112, 42);
            this.txt_Mat_Adm.Name = "txt_Mat_Adm";
            this.txt_Mat_Adm.Size = new System.Drawing.Size(100, 20);
            this.txt_Mat_Adm.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Matricula";
            // 
            // tbpresencaBindingSource1
            // 
            this.tbpresencaBindingSource1.DataMember = "tb_presenca";
            this.tbpresencaBindingSource1.DataSource = this.dBCONTROLEDataSet;
            // 
            // tb_usuarioTableAdapter2
            // 
            this.tb_usuarioTableAdapter2.ClearBeforeFill = true;
            // 
            // tbpresencaBindingSource
            // 
            this.tbpresencaBindingSource.DataMember = "tb_presenca";
            this.tbpresencaBindingSource.DataSource = this.dBCONTROLEDataSet;
            // 
            // tb_presencaTableAdapter
            // 
            this.tb_presencaTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.mudaURL);
            this.tabPage4.Controls.Add(this.txt_url);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(648, 295);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Configuração";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(127, 40);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(271, 20);
            this.txt_url.TabIndex = 0;
            // 
            // mudaURL
            // 
            this.mudaURL.Location = new System.Drawing.Point(38, 93);
            this.mudaURL.Name = "mudaURL";
            this.mudaURL.Size = new System.Drawing.Size(75, 23);
            this.mudaURL.TabIndex = 1;
            this.mudaURL.Text = "Mudar URL";
            this.mudaURL.UseVisualStyleBackColor = true;
            this.mudaURL.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Url do Relatorio ";
            // 
            // FRMAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 321);
            this.Controls.Add(this.AdminTab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMAdmin";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.FRMAdmin_Load);
            this.AdminTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCONTROLEDataSet)).EndInit();
            this.Cadastrar_Usuario.ResumeLayout(false);
            this.Cadastrar_Usuario.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpresencaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpresencaBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Cadastrar_Usuario;
        private DBCONTROLEDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbusuarioBindingSource;
        private DBCONTROLEDataSet dBCONTROLEDataSet;
        private System.Windows.Forms.TextBox IN_Cad_Nome;
        private System.Windows.Forms.TextBox IN_Cad_Matricula;
        private System.Windows.Forms.Button cadastrarBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excluirBTN;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.BindingSource tbpresencaBindingSource;
        private DBCONTROLEDataSetTableAdapters.tb_presencaTableAdapter tb_presencaTableAdapter;
        private System.Windows.Forms.BindingSource tbpresencaBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox txt_Pass_Adm;
        private System.Windows.Forms.TextBox txt_Login_Adm;
        private System.Windows.Forms.TextBox txt_Mat_Adm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_listaadm;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button mudaURL;
        private System.Windows.Forms.TextBox txt_url;
    }
}