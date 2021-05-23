
namespace PlantSimulator_Server
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
            this.cbxSitema = new System.Windows.Forms.ComboBox();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblTransferFunction = new System.Windows.Forms.Label();
            this.txtGainK = new System.Windows.Forms.TextBox();
            this.txtTau = new System.Windows.Forms.TextBox();
            this.txtSignal = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.grpPrimeiraOrdem = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpSegundaOrdem = new System.Windows.Forms.GroupBox();
            this.txtbWn2 = new System.Windows.Forms.TextBox();
            this.txtSignal2 = new System.Windows.Forms.TextBox();
            this.textSignal1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtKsiWn = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtWn2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSistemas = new System.Windows.Forms.GroupBox();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.grpParametrosPrimeiraOrdem = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtTE = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.picRestButton = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picOpcButton = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDataReceive = new PlantSimulator.CircularButton();
            this.btnDataSend = new PlantSimulator.CircularButton();
            this.grpPrimeiraOrdem.SuspendLayout();
            this.grpSegundaOrdem.SuspendLayout();
            this.grpSistemas.SuspendLayout();
            this.grpParametrosPrimeiraOrdem.SuspendLayout();
            this.grpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpcButton)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSitema
            // 
            this.cbxSitema.FormattingEnabled = true;
            this.cbxSitema.Items.AddRange(new object[] {
            "1ª Ordem",
            "2ª Ordem"});
            this.cbxSitema.Location = new System.Drawing.Point(10, 104);
            this.cbxSitema.Name = "cbxSitema";
            this.cbxSitema.Size = new System.Drawing.Size(93, 21);
            this.cbxSitema.TabIndex = 2;
            this.cbxSitema.SelectedIndexChanged += new System.EventHandler(this.cbxSitema_SelectedIndexChanged);
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(10, 85);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(93, 13);
            this.lblSistema.TabIndex = 3;
            this.lblSistema.Text = "Ordem do Sistema";
            // 
            // lblTransferFunction
            // 
            this.lblTransferFunction.AutoSize = true;
            this.lblTransferFunction.Location = new System.Drawing.Point(23, 20);
            this.lblTransferFunction.Name = "lblTransferFunction";
            this.lblTransferFunction.Size = new System.Drawing.Size(126, 13);
            this.lblTransferFunction.TabIndex = 4;
            this.lblTransferFunction.Text = "Função de Transferência";
            // 
            // txtGainK
            // 
            this.txtGainK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGainK.Location = new System.Drawing.Point(25, 39);
            this.txtGainK.Name = "txtGainK";
            this.txtGainK.Size = new System.Drawing.Size(120, 20);
            this.txtGainK.TabIndex = 5;
            this.txtGainK.Text = "1";
            this.txtGainK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGainK.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtGainK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtGainK.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // txtTau
            // 
            this.txtTau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTau.Location = new System.Drawing.Point(29, 65);
            this.txtTau.Name = "txtTau";
            this.txtTau.Size = new System.Drawing.Size(30, 20);
            this.txtTau.TabIndex = 5;
            this.txtTau.Text = "1";
            this.txtTau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTau.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtTau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtTau.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // txtSignal
            // 
            this.txtSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignal.Location = new System.Drawing.Point(84, 65);
            this.txtSignal.MaxLength = 1;
            this.txtSignal.Name = "txtSignal";
            this.txtSignal.Size = new System.Drawing.Size(20, 20);
            this.txtSignal.TabIndex = 5;
            this.txtSignal.Text = "+";
            this.txtSignal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSignal.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtSignal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockSignalCharacteres_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(110, 65);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(30, 20);
            this.txtA.TabIndex = 5;
            this.txtA.Text = "1";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtA.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // grpPrimeiraOrdem
            // 
            this.grpPrimeiraOrdem.Controls.Add(this.txtA);
            this.grpPrimeiraOrdem.Controls.Add(this.txtSignal);
            this.grpPrimeiraOrdem.Controls.Add(this.textBox1);
            this.grpPrimeiraOrdem.Controls.Add(this.txtTau);
            this.grpPrimeiraOrdem.Controls.Add(this.txtGainK);
            this.grpPrimeiraOrdem.Controls.Add(this.lblTransferFunction);
            this.grpPrimeiraOrdem.Location = new System.Drawing.Point(27, 8);
            this.grpPrimeiraOrdem.Name = "grpPrimeiraOrdem";
            this.grpPrimeiraOrdem.Size = new System.Drawing.Size(170, 95);
            this.grpPrimeiraOrdem.TabIndex = 6;
            this.grpPrimeiraOrdem.TabStop = false;
            this.grpPrimeiraOrdem.Text = "Primeira Ordem";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(58, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "s";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpSegundaOrdem
            // 
            this.grpSegundaOrdem.Controls.Add(this.txtbWn2);
            this.grpSegundaOrdem.Controls.Add(this.txtSignal2);
            this.grpSegundaOrdem.Controls.Add(this.textSignal1);
            this.grpSegundaOrdem.Controls.Add(this.textBox8);
            this.grpSegundaOrdem.Controls.Add(this.txtKsiWn);
            this.grpSegundaOrdem.Controls.Add(this.textBox4);
            this.grpSegundaOrdem.Controls.Add(this.txtbA);
            this.grpSegundaOrdem.Controls.Add(this.txtWn2);
            this.grpSegundaOrdem.Controls.Add(this.label2);
            this.grpSegundaOrdem.Location = new System.Drawing.Point(7, 8);
            this.grpSegundaOrdem.Name = "grpSegundaOrdem";
            this.grpSegundaOrdem.Size = new System.Drawing.Size(207, 95);
            this.grpSegundaOrdem.TabIndex = 6;
            this.grpSegundaOrdem.TabStop = false;
            this.grpSegundaOrdem.Text = "Segunda Ordem";
            // 
            // txtbWn2
            // 
            this.txtbWn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbWn2.Location = new System.Drawing.Point(164, 65);
            this.txtbWn2.Name = "txtbWn2";
            this.txtbWn2.Size = new System.Drawing.Size(23, 20);
            this.txtbWn2.TabIndex = 5;
            this.txtbWn2.Text = "1";
            this.txtbWn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbWn2.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtbWn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtbWn2.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // txtSignal2
            // 
            this.txtSignal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignal2.Location = new System.Drawing.Point(139, 65);
            this.txtSignal2.MaxLength = 1;
            this.txtSignal2.Name = "txtSignal2";
            this.txtSignal2.Size = new System.Drawing.Size(20, 20);
            this.txtSignal2.TabIndex = 5;
            this.txtSignal2.Text = "+";
            this.txtSignal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSignal2.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtSignal2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockSignalCharacteres_KeyPress);
            // 
            // textSignal1
            // 
            this.textSignal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSignal1.Location = new System.Drawing.Point(70, 65);
            this.textSignal1.MaxLength = 1;
            this.textSignal1.Name = "textSignal1";
            this.textSignal1.Size = new System.Drawing.Size(20, 20);
            this.textSignal1.TabIndex = 5;
            this.textSignal1.Text = "+";
            this.textSignal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSignal1.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.textSignal1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockSignalCharacteres_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(115, 65);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(20, 20);
            this.textBox8.TabIndex = 5;
            this.textBox8.Text = "s";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKsiWn
            // 
            this.txtKsiWn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKsiWn.Location = new System.Drawing.Point(93, 65);
            this.txtKsiWn.Name = "txtKsiWn";
            this.txtKsiWn.Size = new System.Drawing.Size(23, 20);
            this.txtKsiWn.TabIndex = 5;
            this.txtKsiWn.Text = "1";
            this.txtKsiWn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKsiWn.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtKsiWn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtKsiWn.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(46, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(20, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "s²";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbA
            // 
            this.txtbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbA.Location = new System.Drawing.Point(24, 65);
            this.txtbA.Name = "txtbA";
            this.txtbA.Size = new System.Drawing.Size(23, 20);
            this.txtbA.TabIndex = 5;
            this.txtbA.Text = "1";
            this.txtbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbA.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtbA.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // txtWn2
            // 
            this.txtWn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWn2.Location = new System.Drawing.Point(46, 39);
            this.txtWn2.Name = "txtWn2";
            this.txtWn2.Size = new System.Drawing.Size(120, 20);
            this.txtWn2.TabIndex = 5;
            this.txtWn2.Text = "1";
            this.txtWn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWn2.TextChanged += new System.EventHandler(this.tranferFunction_TextChanged);
            this.txtWn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtWn2.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Função de Transferência";
            // 
            // grpSistemas
            // 
            this.grpSistemas.Controls.Add(this.grpPrimeiraOrdem);
            this.grpSistemas.Controls.Add(this.grpSegundaOrdem);
            this.grpSistemas.Location = new System.Drawing.Point(114, 69);
            this.grpSistemas.Name = "grpSistemas";
            this.grpSistemas.Size = new System.Drawing.Size(220, 118);
            this.grpSistemas.TabIndex = 10;
            this.grpSistemas.TabStop = false;
            // 
            // txtTS
            // 
            this.txtTS.Enabled = false;
            this.txtTS.Location = new System.Drawing.Point(167, 21);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(45, 20);
            this.txtTS.TabIndex = 11;
            // 
            // grpParametrosPrimeiraOrdem
            // 
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.button3);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.button2);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.button1);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.label7);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.label6);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.label5);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.label4);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.label3);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.label1);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.txtT);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.txtTE);
            this.grpParametrosPrimeiraOrdem.Controls.Add(this.txtTS);
            this.grpParametrosPrimeiraOrdem.Location = new System.Drawing.Point(5, 9);
            this.grpParametrosPrimeiraOrdem.Name = "grpParametrosPrimeiraOrdem";
            this.grpParametrosPrimeiraOrdem.Size = new System.Drawing.Size(298, 109);
            this.grpParametrosPrimeiraOrdem.TabIndex = 12;
            this.grpParametrosPrimeiraOrdem.TabStop = false;
            this.grpParametrosPrimeiraOrdem.Text = "Parâmetros";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(15, 20);
            this.button3.TabIndex = 13;
            this.button3.Text = "?";
            this.toolTip1.SetToolTip(this.button3, "A constante de tempo é o tempo para \r\nque a resposta alcance 63% do valor da\r\nres" +
        "posta em regime permanente.");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "?";
            this.toolTip1.SetToolTip(this.button2, "O tempo de estabelecimento é definido como o \r\ntempo necessário para que a respos" +
        "ta  alcance \r\numa faixa de valores de 2% em torno do valor \r\nfinal e aí permanec" +
        "e.");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 20);
            this.button1.TabIndex = 13;
            this.button1.Text = "?";
            this.toolTip1.SetToolTip(this.button1, "O tempo de subida é definido como o tempo necessário \r\npara que a resposta passe " +
        "de 10 a 90% do valor final");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "segundos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "segundos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "segundos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Constante de Tempo (T):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tempo de Estabelecimento (Te):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo de Subida (Ts):";
            // 
            // txtT
            // 
            this.txtT.Enabled = false;
            this.txtT.Location = new System.Drawing.Point(167, 73);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(45, 20);
            this.txtT.TabIndex = 11;
            // 
            // txtTE
            // 
            this.txtTE.Enabled = false;
            this.txtTE.Location = new System.Drawing.Point(167, 47);
            this.txtTE.Name = "txtTE";
            this.txtTE.Size = new System.Drawing.Size(45, 20);
            this.txtTE.TabIndex = 11;
            // 
            // grpParameters
            // 
            this.grpParameters.Controls.Add(this.grpParametrosPrimeiraOrdem);
            this.grpParameters.Location = new System.Drawing.Point(349, 65);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(308, 127);
            this.grpParameters.TabIndex = 13;
            this.grpParameters.TabStop = false;
            // 
            // picRestButton
            // 
            this.picRestButton.BackColor = System.Drawing.Color.White;
            this.picRestButton.Image = global::PlantSimulator.Properties.Resources.Rest;
            this.picRestButton.Location = new System.Drawing.Point(9, 5);
            this.picRestButton.Name = "picRestButton";
            this.picRestButton.Size = new System.Drawing.Size(72, 50);
            this.picRestButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRestButton.TabIndex = 15;
            this.picRestButton.TabStop = false;
            this.picRestButton.Click += new System.EventHandler(this.picRestButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(658, 57);
            this.label8.TabIndex = 16;
            // 
            // picOpcButton
            // 
            this.picOpcButton.BackColor = System.Drawing.Color.White;
            this.picOpcButton.Image = ((System.Drawing.Image)(resources.GetObject("picOpcButton.Image")));
            this.picOpcButton.Location = new System.Drawing.Point(93, 5);
            this.picOpcButton.Name = "picOpcButton";
            this.picOpcButton.Size = new System.Drawing.Size(75, 50);
            this.picOpcButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpcButton.TabIndex = 17;
            this.picOpcButton.TabStop = false;
            this.picOpcButton.Click += new System.EventHandler(this.picOpcButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Enviando";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Recebendo";
            // 
            // btnDataReceive
            // 
            this.btnDataReceive.BackColor = System.Drawing.Color.DarkRed;
            this.btnDataReceive.Enabled = false;
            this.btnDataReceive.FlatAppearance.BorderSize = 0;
            this.btnDataReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataReceive.Location = new System.Drawing.Point(72, 150);
            this.btnDataReceive.Name = "btnDataReceive";
            this.btnDataReceive.Size = new System.Drawing.Size(20, 20);
            this.btnDataReceive.TabIndex = 18;
            this.btnDataReceive.UseVisualStyleBackColor = false;
            // 
            // btnDataSend
            // 
            this.btnDataSend.BackColor = System.Drawing.Color.DarkRed;
            this.btnDataSend.Enabled = false;
            this.btnDataSend.FlatAppearance.BorderSize = 0;
            this.btnDataSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataSend.Location = new System.Drawing.Point(14, 150);
            this.btnDataSend.Name = "btnDataSend";
            this.btnDataSend.Size = new System.Drawing.Size(20, 20);
            this.btnDataSend.TabIndex = 18;
            this.btnDataSend.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 195);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDataReceive);
            this.Controls.Add(this.btnDataSend);
            this.Controls.Add(this.picOpcButton);
            this.Controls.Add(this.picRestButton);
            this.Controls.Add(this.grpParameters);
            this.Controls.Add(this.grpSistemas);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.cbxSitema);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Text = "SERVER";
            this.grpPrimeiraOrdem.ResumeLayout(false);
            this.grpPrimeiraOrdem.PerformLayout();
            this.grpSegundaOrdem.ResumeLayout(false);
            this.grpSegundaOrdem.PerformLayout();
            this.grpSistemas.ResumeLayout(false);
            this.grpParametrosPrimeiraOrdem.ResumeLayout(false);
            this.grpParametrosPrimeiraOrdem.PerformLayout();
            this.grpParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRestButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpcButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxSitema;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblTransferFunction;
        private System.Windows.Forms.TextBox txtGainK;
        private System.Windows.Forms.TextBox txtTau;
        private System.Windows.Forms.TextBox txtSignal;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox grpPrimeiraOrdem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpSegundaOrdem;
        private System.Windows.Forms.TextBox txtbWn2;
        private System.Windows.Forms.TextBox txtSignal2;
        private System.Windows.Forms.TextBox textSignal1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtKsiWn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtWn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSistemas;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.GroupBox grpParametrosPrimeiraOrdem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtTE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox picRestButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picOpcButton;
        private System.Windows.Forms.Label label9;
        private PlantSimulator.CircularButton btnDataReceive;
        private System.Windows.Forms.Label label10;
        internal PlantSimulator.CircularButton btnDataSend;
    }
}

