
namespace PlantSimulator
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxSitema = new System.Windows.Forms.ComboBox();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblTransferFunction = new System.Windows.Forms.Label();
            this.txtGain = new System.Windows.Forms.TextBox();
            this.txtTau = new System.Windows.Forms.TextBox();
            this.txtSignal = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.grpPrimeiraOrdem = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.grpSegundaOrdem = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnectionPage = new System.Windows.Forms.Button();
            this.grpSistemas = new System.Windows.Forms.GroupBox();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.grpParametrosPrimeiraOrdem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.grpPrimeiraOrdem.SuspendLayout();
            this.grpCommand.SuspendLayout();
            this.grpSegundaOrdem.SuspendLayout();
            this.grpSistemas.SuspendLayout();
            this.grpParametrosPrimeiraOrdem.SuspendLayout();
            this.grpParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.Location = new System.Drawing.Point(12, 144);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(793, 292);
            this.zedGraph.TabIndex = 0;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(58, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxSitema
            // 
            this.cbxSitema.FormattingEnabled = true;
            this.cbxSitema.Items.AddRange(new object[] {
            "1ª Ordem",
            "2ª Ordem"});
            this.cbxSitema.Location = new System.Drawing.Point(12, 37);
            this.cbxSitema.Name = "cbxSitema";
            this.cbxSitema.Size = new System.Drawing.Size(93, 21);
            this.cbxSitema.TabIndex = 2;
            this.cbxSitema.SelectedIndexChanged += new System.EventHandler(this.cbxSitema_SelectedIndexChanged);
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(12, 18);
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
            // txtGain
            // 
            this.txtGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGain.Location = new System.Drawing.Point(25, 39);
            this.txtGain.Name = "txtGain";
            this.txtGain.Size = new System.Drawing.Size(120, 20);
            this.txtGain.TabIndex = 5;
            this.txtGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTau
            // 
            this.txtTau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTau.Location = new System.Drawing.Point(29, 65);
            this.txtTau.Name = "txtTau";
            this.txtTau.Size = new System.Drawing.Size(30, 20);
            this.txtTau.TabIndex = 5;
            this.txtTau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignal
            // 
            this.txtSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignal.Location = new System.Drawing.Point(84, 65);
            this.txtSignal.Name = "txtSignal";
            this.txtSignal.Size = new System.Drawing.Size(20, 20);
            this.txtSignal.TabIndex = 5;
            this.txtSignal.Text = "+";
            this.txtSignal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(110, 65);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(30, 20);
            this.txtA.TabIndex = 5;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPrimeiraOrdem
            // 
            this.grpPrimeiraOrdem.Controls.Add(this.txtA);
            this.grpPrimeiraOrdem.Controls.Add(this.txtSignal);
            this.grpPrimeiraOrdem.Controls.Add(this.textBox1);
            this.grpPrimeiraOrdem.Controls.Add(this.txtTau);
            this.grpPrimeiraOrdem.Controls.Add(this.txtGain);
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
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(75, 48);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(58, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnStep);
            this.grpCommand.Controls.Add(this.btnReset);
            this.grpCommand.Controls.Add(this.txtStep);
            this.grpCommand.Controls.Add(this.btnStart);
            this.grpCommand.Controls.Add(this.btnStop);
            this.grpCommand.Location = new System.Drawing.Point(340, 12);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(149, 110);
            this.grpCommand.TabIndex = 8;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Degrau";
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(13, 48);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(58, 23);
            this.btnStep.TabIndex = 12;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 78);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(13, 21);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(119, 20);
            this.txtStep.TabIndex = 4;
            // 
            // grpSegundaOrdem
            // 
            this.grpSegundaOrdem.Controls.Add(this.textBox2);
            this.grpSegundaOrdem.Controls.Add(this.textBox9);
            this.grpSegundaOrdem.Controls.Add(this.textBox3);
            this.grpSegundaOrdem.Controls.Add(this.textBox8);
            this.grpSegundaOrdem.Controls.Add(this.textBox7);
            this.grpSegundaOrdem.Controls.Add(this.textBox4);
            this.grpSegundaOrdem.Controls.Add(this.textBox5);
            this.grpSegundaOrdem.Controls.Add(this.textBox6);
            this.grpSegundaOrdem.Controls.Add(this.label2);
            this.grpSegundaOrdem.Location = new System.Drawing.Point(7, 8);
            this.grpSegundaOrdem.Name = "grpSegundaOrdem";
            this.grpSegundaOrdem.Size = new System.Drawing.Size(207, 95);
            this.grpSegundaOrdem.TabIndex = 6;
            this.grpSegundaOrdem.TabStop = false;
            this.grpSegundaOrdem.Text = "Segunda Ordem";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(164, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(23, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(139, 65);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(20, 20);
            this.textBox9.TabIndex = 5;
            this.textBox9.Text = "+";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(70, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "+";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(93, 65);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(23, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(24, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(23, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(46, 39);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btnConnectionPage
            // 
            this.btnConnectionPage.Location = new System.Drawing.Point(15, 82);
            this.btnConnectionPage.Name = "btnConnectionPage";
            this.btnConnectionPage.Size = new System.Drawing.Size(79, 26);
            this.btnConnectionPage.TabIndex = 9;
            this.btnConnectionPage.Text = "Conectar";
            this.btnConnectionPage.UseVisualStyleBackColor = true;
            this.btnConnectionPage.Click += new System.EventHandler(this.btnConnectionPage_Click_1);
            // 
            // grpSistemas
            // 
            this.grpSistemas.Controls.Add(this.grpSegundaOrdem);
            this.grpSistemas.Controls.Add(this.grpPrimeiraOrdem);
            this.grpSistemas.Location = new System.Drawing.Point(114, 12);
            this.grpSistemas.Name = "grpSistemas";
            this.grpSistemas.Size = new System.Drawing.Size(220, 110);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo de Subida (Ts):";
            // 
            // txtTE
            // 
            this.txtTE.Enabled = false;
            this.txtTE.Location = new System.Drawing.Point(167, 47);
            this.txtTE.Name = "txtTE";
            this.txtTE.Size = new System.Drawing.Size(45, 20);
            this.txtTE.TabIndex = 11;
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
            // txtT
            // 
            this.txtT.Enabled = false;
            this.txtT.Location = new System.Drawing.Point(167, 73);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(45, 20);
            this.txtT.TabIndex = 11;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "segundos";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "segundos";
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
            // grpParameters
            // 
            this.grpParameters.Controls.Add(this.grpParametrosPrimeiraOrdem);
            this.grpParameters.Location = new System.Drawing.Point(496, 12);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(308, 127);
            this.grpParameters.TabIndex = 13;
            this.grpParameters.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 454);
            this.Controls.Add(this.grpParameters);
            this.Controls.Add(this.grpSistemas);
            this.Controls.Add(this.btnConnectionPage);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.cbxSitema);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPrimeiraOrdem.ResumeLayout(false);
            this.grpPrimeiraOrdem.PerformLayout();
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            this.grpSegundaOrdem.ResumeLayout(false);
            this.grpSegundaOrdem.PerformLayout();
            this.grpSistemas.ResumeLayout(false);
            this.grpParametrosPrimeiraOrdem.ResumeLayout(false);
            this.grpParametrosPrimeiraOrdem.PerformLayout();
            this.grpParameters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbxSitema;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblTransferFunction;
        private System.Windows.Forms.TextBox txtGain;
        private System.Windows.Forms.TextBox txtTau;
        private System.Windows.Forms.TextBox txtSignal;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox grpPrimeiraOrdem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.GroupBox grpSegundaOrdem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnectionPage;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSistemas;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.Button btnStep;
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
    }
}

