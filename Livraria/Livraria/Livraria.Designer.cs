namespace Livraria
{
    partial class Livraria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livraria));
            BuscaCliente = new TabControl();
            tabCadastrar = new TabPage();
            panel3 = new Panel();
            txtdata = new TextBox();
            txtemail = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            BtnConfirmaCadastro = new Button();
            txtcidade = new TextBox();
            label2 = new Label();
            txtcep = new TextBox();
            txtbairro = new TextBox();
            txtEditora = new Label();
            txtcliente = new TextBox();
            txtuf = new TextBox();
            txtendereco = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtpreco = new Label();
            txtcpf = new TextBox();
            tabPage1 = new TabPage();
            txtnomeEditora = new TextBox();
            button1 = new Button();
            lblerro = new Label();
            txtCadastroEditora = new Label();
            tabPage2 = new TabPage();
            txtBuscaCliente = new TextBox();
            dgClientes = new DataGridView();
            btnAlterarCliente = new Button();
            button2 = new Button();
            label13 = new Label();
            tabBuscar = new TabPage();
            txtEditoras = new TextBox();
            btnAlterar = new Button();
            btnRemoveBanda = new Button();
            label5 = new Label();
            dgEditora = new DataGridView();
            AlteraCliente1 = new TabPage();
            button3 = new Button();
            txtAltData = new TextBox();
            txtAltEmail = new TextBox();
            AltEmail = new Label();
            AltCidade = new Label();
            AltCEP = new Label();
            txtAltCidade = new TextBox();
            AltBairro = new Label();
            txtAltCEP = new TextBox();
            txtAltBairro = new TextBox();
            AltCPF = new Label();
            txtAltCliente = new TextBox();
            txtAltUF = new TextBox();
            txtAltEndereco = new TextBox();
            AltCliente = new Label();
            AltUF = new Label();
            AltData = new Label();
            AltEndereco = new Label();
            txtAltCpf = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            nomeProjeto = new Label();
            closebtn = new Button();
            panel2 = new Panel();
            BuscaCliente.SuspendLayout();
            tabCadastrar.SuspendLayout();
            panel3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEditora).BeginInit();
            AlteraCliente1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BuscaCliente
            // 
            BuscaCliente.Controls.Add(tabCadastrar);
            BuscaCliente.Controls.Add(tabPage1);
            BuscaCliente.Controls.Add(tabPage2);
            BuscaCliente.Controls.Add(tabBuscar);
            BuscaCliente.Controls.Add(AlteraCliente1);
            BuscaCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BuscaCliente.Location = new Point(3, 200);
            BuscaCliente.Margin = new Padding(4);
            BuscaCliente.Name = "BuscaCliente";
            BuscaCliente.SelectedIndex = 0;
            BuscaCliente.Size = new Size(870, 333);
            BuscaCliente.TabIndex = 10;
            // 
            // tabCadastrar
            // 
            tabCadastrar.BackColor = Color.White;
            tabCadastrar.BorderStyle = BorderStyle.Fixed3D;
            tabCadastrar.Controls.Add(panel3);
            tabCadastrar.Location = new Point(4, 25);
            tabCadastrar.Margin = new Padding(4);
            tabCadastrar.Name = "tabCadastrar";
            tabCadastrar.Padding = new Padding(4);
            tabCadastrar.Size = new Size(862, 304);
            tabCadastrar.TabIndex = 0;
            tabCadastrar.Text = "Cadastro Cliente";
            tabCadastrar.Click += tabCadastrar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Controls.Add(txtdata);
            panel3.Controls.Add(txtemail);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(BtnConfirmaCadastro);
            panel3.Controls.Add(txtcidade);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtcep);
            panel3.Controls.Add(txtbairro);
            panel3.Controls.Add(txtEditora);
            panel3.Controls.Add(txtcliente);
            panel3.Controls.Add(txtuf);
            panel3.Controls.Add(txtendereco);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtpreco);
            panel3.Controls.Add(txtcpf);
            panel3.Location = new Point(1, -26);
            panel3.Name = "panel3";
            panel3.Size = new Size(853, 340);
            panel3.TabIndex = 13;
            // 
            // txtdata
            // 
            txtdata.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdata.Location = new Point(220, 64);
            txtdata.Margin = new Padding(4);
            txtdata.Name = "txtdata";
            txtdata.Size = new Size(490, 26);
            txtdata.TabIndex = 27;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(220, 289);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(490, 26);
            txtemail.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(30, 289);
            label12.Name = "label12";
            label12.Size = new Size(74, 26);
            label12.TabIndex = 25;
            label12.Text = "E-Mail:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(30, 225);
            label11.Name = "label11";
            label11.Size = new Size(75, 26);
            label11.TabIndex = 24;
            label11.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(30, 257);
            label6.Name = "label6";
            label6.Size = new Size(51, 26);
            label6.TabIndex = 23;
            label6.Text = "CEP:";
            // 
            // BtnConfirmaCadastro
            // 
            BtnConfirmaCadastro.BackColor = Color.White;
            BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            BtnConfirmaCadastro.FlatStyle = FlatStyle.Flat;
            BtnConfirmaCadastro.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfirmaCadastro.ForeColor = Color.Black;
            BtnConfirmaCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConfirmaCadastro.Location = new Point(727, 34);
            BtnConfirmaCadastro.Margin = new Padding(4);
            BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            BtnConfirmaCadastro.Size = new Size(112, 45);
            BtnConfirmaCadastro.TabIndex = 13;
            BtnConfirmaCadastro.Text = "Confirmar";
            BtnConfirmaCadastro.TextAlign = ContentAlignment.MiddleLeft;
            BtnConfirmaCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnConfirmaCadastro.UseVisualStyleBackColor = false;
            BtnConfirmaCadastro.Click += BtnConfirmaCadastro_Click;
            // 
            // txtcidade
            // 
            txtcidade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcidade.Location = new Point(220, 225);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(490, 26);
            txtcidade.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 192);
            label2.Name = "label2";
            label2.Size = new Size(72, 26);
            label2.TabIndex = 19;
            label2.Text = "Bairro:";
            // 
            // txtcep
            // 
            txtcep.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcep.Location = new Point(220, 257);
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(490, 26);
            txtcep.TabIndex = 21;
            // 
            // txtbairro
            // 
            txtbairro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbairro.Location = new Point(220, 193);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(490, 26);
            txtbairro.TabIndex = 20;
            // 
            // txtEditora
            // 
            txtEditora.AutoSize = true;
            txtEditora.BackColor = Color.White;
            txtEditora.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditora.ForeColor = Color.Black;
            txtEditora.Location = new Point(29, 96);
            txtEditora.Margin = new Padding(4, 0, 4, 0);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(51, 26);
            txtEditora.TabIndex = 7;
            txtEditora.Text = "CPF:";
            // 
            // txtcliente
            // 
            txtcliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcliente.Location = new Point(220, 29);
            txtcliente.Margin = new Padding(4);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(490, 26);
            txtcliente.TabIndex = 16;
            // 
            // txtuf
            // 
            txtuf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtuf.Location = new Point(220, 129);
            txtuf.Name = "txtuf";
            txtuf.Size = new Size(490, 26);
            txtuf.TabIndex = 18;
            // 
            // txtendereco
            // 
            txtendereco.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtendereco.Location = new Point(220, 161);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(490, 26);
            txtendereco.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(29, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 26);
            label4.TabIndex = 6;
            label4.Text = "Cliente:";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 129);
            label1.Name = "label1";
            label1.Size = new Size(44, 26);
            label1.TabIndex = 17;
            label1.Text = "UF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 64);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 26);
            label3.TabIndex = 8;
            label3.Text = "Data Nascimento:";
            // 
            // txtpreco
            // 
            txtpreco.AutoSize = true;
            txtpreco.BackColor = Color.White;
            txtpreco.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtpreco.ForeColor = Color.Black;
            txtpreco.Location = new Point(29, 161);
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(100, 26);
            txtpreco.TabIndex = 13;
            txtpreco.Text = "Endereço:";
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcpf.Location = new Point(220, 96);
            txtcpf.Margin = new Padding(4);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(490, 26);
            txtcpf.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DimGray;
            tabPage1.Controls.Add(txtnomeEditora);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(lblerro);
            tabPage1.Controls.Add(txtCadastroEditora);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1245, 304);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Cadastro Editora";
            // 
            // txtnomeEditora
            // 
            txtnomeEditora.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnomeEditora.Location = new Point(243, 106);
            txtnomeEditora.Margin = new Padding(4);
            txtnomeEditora.Name = "txtnomeEditora";
            txtnomeEditora.Size = new Size(532, 26);
            txtnomeEditora.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(826, 250);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(111, 45);
            button1.TabIndex = 14;
            button1.Text = "Confirmar";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblerro
            // 
            lblerro.AutoSize = true;
            lblerro.Location = new Point(228, 272);
            lblerro.Name = "lblerro";
            lblerro.Size = new Size(12, 16);
            lblerro.TabIndex = 12;
            lblerro.Text = "*";
            // 
            // txtCadastroEditora
            // 
            txtCadastroEditora.AutoSize = true;
            txtCadastroEditora.BackColor = Color.White;
            txtCadastroEditora.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCadastroEditora.ForeColor = Color.Black;
            txtCadastroEditora.Location = new Point(63, 102);
            txtCadastroEditora.Name = "txtCadastroEditora";
            txtCadastroEditora.Size = new Size(138, 26);
            txtCadastroEditora.TabIndex = 0;
            txtCadastroEditora.Text = "Nome Editora:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DimGray;
            tabPage2.Controls.Add(txtBuscaCliente);
            tabPage2.Controls.Add(dgClientes);
            tabPage2.Controls.Add(btnAlterarCliente);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label13);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1245, 304);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Busca Cliente";
            // 
            // txtBuscaCliente
            // 
            txtBuscaCliente.Location = new Point(380, 15);
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.Size = new Size(443, 22);
            txtBuscaCliente.TabIndex = 23;
            txtBuscaCliente.TextChanged += textBox2_TextChanged;
            // 
            // dgClientes
            // 
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClientes.BackgroundColor = Color.White;
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Location = new Point(14, 72);
            dgClientes.Margin = new Padding(3, 2, 3, 2);
            dgClientes.Name = "dgClientes";
            dgClientes.ReadOnly = true;
            dgClientes.RowHeadersWidth = 51;
            dgClientes.RowTemplate.Height = 29;
            dgClientes.Size = new Size(1214, 226);
            dgClientes.TabIndex = 20;
            dgClientes.CellContentClick += dgClientes_CellContentClick;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.BackColor = Color.White;
            btnAlterarCliente.FlatAppearance.BorderSize = 0;
            btnAlterarCliente.FlatStyle = FlatStyle.Flat;
            btnAlterarCliente.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarCliente.ForeColor = Color.Black;
            btnAlterarCliente.Image = (Image)resources.GetObject("btnAlterarCliente.Image");
            btnAlterarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterarCliente.Location = new Point(1106, 15);
            btnAlterarCliente.Margin = new Padding(4);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(122, 41);
            btnAlterarCliente.TabIndex = 19;
            btnAlterarCliente.Text = "Alterar";
            btnAlterarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnAlterarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterarCliente.UseVisualStyleBackColor = false;
            btnAlterarCliente.Click += btnAlterarCliente_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(976, 15);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(122, 41);
            button2.TabIndex = 18;
            button2.Text = "Remover";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(253, 11);
            label13.Name = "label13";
            label13.Size = new Size(76, 26);
            label13.TabIndex = 3;
            label13.Text = "Cliente:";
            // 
            // tabBuscar
            // 
            tabBuscar.BackColor = Color.DimGray;
            tabBuscar.Controls.Add(txtEditoras);
            tabBuscar.Controls.Add(btnAlterar);
            tabBuscar.Controls.Add(btnRemoveBanda);
            tabBuscar.Controls.Add(label5);
            tabBuscar.Controls.Add(dgEditora);
            tabBuscar.Location = new Point(4, 25);
            tabBuscar.Margin = new Padding(4);
            tabBuscar.Name = "tabBuscar";
            tabBuscar.Padding = new Padding(4);
            tabBuscar.Size = new Size(1245, 304);
            tabBuscar.TabIndex = 1;
            tabBuscar.Text = "Busca Editora";
            // 
            // txtEditoras
            // 
            txtEditoras.Location = new Point(380, 15);
            txtEditoras.Name = "txtEditoras";
            txtEditoras.Size = new Size(447, 22);
            txtEditoras.TabIndex = 16;
            txtEditoras.TextChanged += txtEditoras_TextChanged;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.White;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterar.ForeColor = Color.Black;
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(1104, 11);
            btnAlterar.Margin = new Padding(4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(122, 41);
            btnAlterar.TabIndex = 15;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextAlign = ContentAlignment.MiddleLeft;
            btnAlterar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnRemoveBanda
            // 
            btnRemoveBanda.BackColor = Color.White;
            btnRemoveBanda.FlatAppearance.BorderSize = 0;
            btnRemoveBanda.FlatStyle = FlatStyle.Flat;
            btnRemoveBanda.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveBanda.ForeColor = Color.Black;
            btnRemoveBanda.Image = (Image)resources.GetObject("btnRemoveBanda.Image");
            btnRemoveBanda.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemoveBanda.Location = new Point(974, 11);
            btnRemoveBanda.Margin = new Padding(4);
            btnRemoveBanda.Name = "btnRemoveBanda";
            btnRemoveBanda.Size = new Size(122, 41);
            btnRemoveBanda.TabIndex = 14;
            btnRemoveBanda.Text = "Remover";
            btnRemoveBanda.TextAlign = ContentAlignment.MiddleLeft;
            btnRemoveBanda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemoveBanda.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(253, 11);
            label5.Name = "label5";
            label5.Size = new Size(82, 26);
            label5.TabIndex = 2;
            label5.Text = "Editora:";
            // 
            // dgEditora
            // 
            dgEditora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEditora.BackgroundColor = Color.White;
            dgEditora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEditora.Location = new Point(7, 72);
            dgEditora.Margin = new Padding(3, 2, 3, 2);
            dgEditora.Name = "dgEditora";
            dgEditora.ReadOnly = true;
            dgEditora.RowHeadersWidth = 51;
            dgEditora.RowTemplate.Height = 29;
            dgEditora.Size = new Size(1231, 226);
            dgEditora.TabIndex = 0;
            dgEditora.CellContentClick += dgProdutos_CellContentClick;
            // 
            // AlteraCliente1
            // 
            AlteraCliente1.BackColor = Color.DimGray;
            AlteraCliente1.Controls.Add(button3);
            AlteraCliente1.Controls.Add(txtAltData);
            AlteraCliente1.Controls.Add(txtAltEmail);
            AlteraCliente1.Controls.Add(AltEmail);
            AlteraCliente1.Controls.Add(AltCidade);
            AlteraCliente1.Controls.Add(AltCEP);
            AlteraCliente1.Controls.Add(txtAltCidade);
            AlteraCliente1.Controls.Add(AltBairro);
            AlteraCliente1.Controls.Add(txtAltCEP);
            AlteraCliente1.Controls.Add(txtAltBairro);
            AlteraCliente1.Controls.Add(AltCPF);
            AlteraCliente1.Controls.Add(txtAltCliente);
            AlteraCliente1.Controls.Add(txtAltUF);
            AlteraCliente1.Controls.Add(txtAltEndereco);
            AlteraCliente1.Controls.Add(AltCliente);
            AlteraCliente1.Controls.Add(AltUF);
            AlteraCliente1.Controls.Add(AltData);
            AlteraCliente1.Controls.Add(AltEndereco);
            AlteraCliente1.Controls.Add(txtAltCpf);
            AlteraCliente1.Location = new Point(4, 25);
            AlteraCliente1.Name = "AlteraCliente1";
            AlteraCliente1.Padding = new Padding(3);
            AlteraCliente1.Size = new Size(1245, 304);
            AlteraCliente1.TabIndex = 5;
            AlteraCliente1.Text = "Altera Cliente";
            // 
            // button3
            // 
            button3.Location = new Point(716, 238);
            button3.Name = "button3";
            button3.Size = new Size(104, 54);
            button3.TabIndex = 46;
            button3.Text = "Confirmar Alteração\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtAltData
            // 
            txtAltData.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltData.Location = new Point(222, 41);
            txtAltData.Margin = new Padding(4);
            txtAltData.Name = "txtAltData";
            txtAltData.Size = new Size(393, 26);
            txtAltData.TabIndex = 45;
            // 
            // txtAltEmail
            // 
            txtAltEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltEmail.Location = new Point(222, 266);
            txtAltEmail.Name = "txtAltEmail";
            txtAltEmail.Size = new Size(393, 26);
            txtAltEmail.TabIndex = 44;
            // 
            // AltEmail
            // 
            AltEmail.AutoSize = true;
            AltEmail.BackColor = Color.White;
            AltEmail.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltEmail.ForeColor = Color.Black;
            AltEmail.Location = new Point(32, 266);
            AltEmail.Name = "AltEmail";
            AltEmail.Size = new Size(74, 26);
            AltEmail.TabIndex = 43;
            AltEmail.Text = "E-Mail:";
            // 
            // AltCidade
            // 
            AltCidade.AutoSize = true;
            AltCidade.BackColor = Color.White;
            AltCidade.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltCidade.ForeColor = Color.Black;
            AltCidade.Location = new Point(32, 202);
            AltCidade.Name = "AltCidade";
            AltCidade.Size = new Size(75, 26);
            AltCidade.TabIndex = 42;
            AltCidade.Text = "Cidade:";
            // 
            // AltCEP
            // 
            AltCEP.AutoSize = true;
            AltCEP.BackColor = Color.White;
            AltCEP.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltCEP.ForeColor = Color.Black;
            AltCEP.Location = new Point(32, 234);
            AltCEP.Name = "AltCEP";
            AltCEP.Size = new Size(51, 26);
            AltCEP.TabIndex = 41;
            AltCEP.Text = "CEP:";
            // 
            // txtAltCidade
            // 
            txtAltCidade.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltCidade.Location = new Point(222, 202);
            txtAltCidade.Name = "txtAltCidade";
            txtAltCidade.Size = new Size(393, 26);
            txtAltCidade.TabIndex = 40;
            // 
            // AltBairro
            // 
            AltBairro.AutoSize = true;
            AltBairro.BackColor = Color.White;
            AltBairro.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltBairro.ForeColor = Color.Black;
            AltBairro.Location = new Point(31, 169);
            AltBairro.Name = "AltBairro";
            AltBairro.Size = new Size(72, 26);
            AltBairro.TabIndex = 37;
            AltBairro.Text = "Bairro:";
            // 
            // txtAltCEP
            // 
            txtAltCEP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltCEP.Location = new Point(222, 234);
            txtAltCEP.Name = "txtAltCEP";
            txtAltCEP.Size = new Size(393, 26);
            txtAltCEP.TabIndex = 39;
            // 
            // txtAltBairro
            // 
            txtAltBairro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltBairro.Location = new Point(222, 170);
            txtAltBairro.Name = "txtAltBairro";
            txtAltBairro.Size = new Size(393, 26);
            txtAltBairro.TabIndex = 38;
            // 
            // AltCPF
            // 
            AltCPF.AutoSize = true;
            AltCPF.BackColor = Color.White;
            AltCPF.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltCPF.ForeColor = Color.Black;
            AltCPF.Location = new Point(31, 73);
            AltCPF.Margin = new Padding(4, 0, 4, 0);
            AltCPF.Name = "AltCPF";
            AltCPF.Size = new Size(51, 26);
            AltCPF.TabIndex = 29;
            AltCPF.Text = "CPF:";
            // 
            // txtAltCliente
            // 
            txtAltCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltCliente.Location = new Point(222, 9);
            txtAltCliente.Margin = new Padding(4);
            txtAltCliente.Name = "txtAltCliente";
            txtAltCliente.Size = new Size(393, 26);
            txtAltCliente.TabIndex = 34;
            // 
            // txtAltUF
            // 
            txtAltUF.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltUF.Location = new Point(222, 106);
            txtAltUF.Name = "txtAltUF";
            txtAltUF.Size = new Size(393, 26);
            txtAltUF.TabIndex = 36;
            // 
            // txtAltEndereco
            // 
            txtAltEndereco.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltEndereco.Location = new Point(222, 138);
            txtAltEndereco.Name = "txtAltEndereco";
            txtAltEndereco.Size = new Size(393, 26);
            txtAltEndereco.TabIndex = 32;
            // 
            // AltCliente
            // 
            AltCliente.AutoSize = true;
            AltCliente.BackColor = Color.White;
            AltCliente.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltCliente.ForeColor = Color.Black;
            AltCliente.Location = new Point(31, 6);
            AltCliente.Margin = new Padding(4, 0, 4, 0);
            AltCliente.Name = "AltCliente";
            AltCliente.Size = new Size(76, 26);
            AltCliente.TabIndex = 28;
            AltCliente.Text = "Cliente:";
            // 
            // AltUF
            // 
            AltUF.AutoSize = true;
            AltUF.BackColor = Color.White;
            AltUF.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltUF.ForeColor = Color.Black;
            AltUF.Location = new Point(31, 106);
            AltUF.Name = "AltUF";
            AltUF.Size = new Size(44, 26);
            AltUF.TabIndex = 35;
            AltUF.Text = "UF:";
            // 
            // AltData
            // 
            AltData.AutoSize = true;
            AltData.BackColor = Color.White;
            AltData.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltData.ForeColor = Color.Black;
            AltData.Location = new Point(31, 41);
            AltData.Margin = new Padding(4, 0, 4, 0);
            AltData.Name = "AltData";
            AltData.Size = new Size(167, 26);
            AltData.TabIndex = 30;
            AltData.Text = "Data Nascimento:";
            // 
            // AltEndereco
            // 
            AltEndereco.AutoSize = true;
            AltEndereco.BackColor = Color.White;
            AltEndereco.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AltEndereco.ForeColor = Color.Black;
            AltEndereco.Location = new Point(31, 138);
            AltEndereco.Name = "AltEndereco";
            AltEndereco.Size = new Size(100, 26);
            AltEndereco.TabIndex = 33;
            AltEndereco.Text = "Endereço:";
            // 
            // txtAltCpf
            // 
            txtAltCpf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltCpf.Location = new Point(222, 73);
            txtAltCpf.Margin = new Padding(4);
            txtAltCpf.Name = "txtAltCpf";
            txtAltCpf.Size = new Size(393, 26);
            txtAltCpf.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Livraria.Properties.Resources.livro;
            pictureBox1.Location = new Point(448, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(nomeProjeto);
            panel1.Controls.Add(closebtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 227);
            panel1.TabIndex = 12;
            // 
            // nomeProjeto
            // 
            nomeProjeto.AutoSize = true;
            nomeProjeto.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            nomeProjeto.ForeColor = Color.White;
            nomeProjeto.Location = new Point(148, 78);
            nomeProjeto.Name = "nomeProjeto";
            nomeProjeto.Size = new Size(148, 42);
            nomeProjeto.TabIndex = 13;
            nomeProjeto.Text = "Livraria";
            // 
            // closebtn
            // 
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            closebtn.ForeColor = Color.White;
            closebtn.Location = new Point(1215, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 12;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(119, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 100);
            panel2.TabIndex = 14;
            // 
            // Livraria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(901, 534);
            Controls.Add(BuscaCliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Livraria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Livraria";
            Load += Livraria_Load_1;
            BuscaCliente.ResumeLayout(false);
            tabCadastrar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            tabBuscar.ResumeLayout(false);
            tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgEditora).EndInit();
            AlteraCliente1.ResumeLayout(false);
            AlteraCliente1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TabControl BuscaCliente;
        private TabPage tabCadastrar;
        private TextBox txtendereco;
        private Label txtpreco;
        private Button BtnConfirmaCadastro;
        private TextBox txtcpf;
        private Label label3;
        private Label txtEditora;
        private Label label4;
        private TabPage tabBuscar;
        private Button btnAlterar;
        private Button btnRemoveBanda;
        private Label label5;
        private DataGridView dgEditora;
        private TabPage tabAlterar;
        private ComboBox cbAlteraGenero;
        private TextBox txtAlteraRanking;
        private Label label7;
        private Button btnConfirmaAlteracao;
        private TextBox txtAlteraIntegrantes;
        private TextBox txtAlteraNome;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Label lblerro;
        private TextBox txtcliente;
        private TabPage tabPage1;
        private Label txtCadastroEditora;
        private Button button1;
        private TextBox txtuf;
        private Label label1;
        private TextBox txtbairro;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private Label label11;
        private Label label6;
        private TextBox txtcidade;
        private TextBox txtcep;
        private TextBox txtemail;
        private Label label12;
        private TextBox txtdata;
        private TextBox txtnomeEditora;
        private TabPage tabPage2;
        private DataGridView dgClientes;
        private Label label13;
        private TextBox txtBuscaCliente;
        private TextBox textBox1;
        private Button btnAlterarCliente;
        private Button button2;
        private TextBox txtBuscaEditora;
        private TextBox txtEditoras;
        private Button closebtn;
        private Label nomeProjeto;
        private Panel panel2;
        private TabPage AlteraCliente1;
        private TextBox txtAltData;
        private TextBox txtAltEmail;
        private Label AltEmail;
        private Label AltCidade;
        private Label AltCEP;
        private TextBox txtAltCidade;
        private Label AltBairro;
        private TextBox txtAltCEP;
        private TextBox txtAltBairro;
        private Label AltCPF;
        private TextBox txtAltCliente;
        private TextBox txtAltUF;
        private TextBox txtAltEndereco;
        private Label AltCliente;
        private Label AltUF;
        private Label AltData;
        private Label AltEndereco;
        private TextBox txtAltCpf;
        private Button button3;
    }
}