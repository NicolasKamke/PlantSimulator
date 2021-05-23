
namespace PlantSimulator_Client
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnConnectionPage = new System.Windows.Forms.Button();
            this.txtFeedbackGain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.picOpcButton = new System.Windows.Forms.PictureBox();
            this.picRestButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseLoop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMalha = new System.Windows.Forms.Label();
            this.grpCSV = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGerarCSV = new System.Windows.Forms.Button();
            this.txtPasso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTermino = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWindowTime = new System.Windows.Forms.TextBox();
            this.grpController = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.btnController = new System.Windows.Forms.Button();
            this.grpCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpcButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestButton)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpCSV.SuspendLayout();
            this.grpController.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.Location = new System.Drawing.Point(12, 192);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(720, 351);
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
            this.grpCommand.Location = new System.Drawing.Point(167, 76);
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
            this.txtStep.Text = "1";
            this.txtStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtStep.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // btnConnectionPage
            // 
            this.btnConnectionPage.Location = new System.Drawing.Point(771, 88);
            this.btnConnectionPage.Name = "btnConnectionPage";
            this.btnConnectionPage.Size = new System.Drawing.Size(79, 26);
            this.btnConnectionPage.TabIndex = 9;
            this.btnConnectionPage.Text = "Conectar";
            this.btnConnectionPage.UseVisualStyleBackColor = true;
            this.btnConnectionPage.Visible = false;
            // 
            // txtFeedbackGain
            // 
            this.txtFeedbackGain.Location = new System.Drawing.Point(27, 78);
            this.txtFeedbackGain.Name = "txtFeedbackGain";
            this.txtFeedbackGain.Size = new System.Drawing.Size(89, 20);
            this.txtFeedbackGain.TabIndex = 8;
            this.txtFeedbackGain.Text = "1";
            this.txtFeedbackGain.Visible = false;
            this.txtFeedbackGain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtFeedbackGain.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ganho de retroação";
            this.label8.Visible = false;
            // 
            // picOpcButton
            // 
            this.picOpcButton.BackColor = System.Drawing.Color.White;
            this.picOpcButton.Image = ((System.Drawing.Image)(resources.GetObject("picOpcButton.Image")));
            this.picOpcButton.Location = new System.Drawing.Point(92, 12);
            this.picOpcButton.Name = "picOpcButton";
            this.picOpcButton.Size = new System.Drawing.Size(75, 50);
            this.picOpcButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpcButton.TabIndex = 20;
            this.picOpcButton.TabStop = false;
            this.picOpcButton.Click += new System.EventHandler(this.picOpcButton_Click);
            this.picOpcButton.DoubleClick += new System.EventHandler(this.picOpcButton_DoubleClick);
            // 
            // picRestButton
            // 
            this.picRestButton.BackColor = System.Drawing.Color.White;
            this.picRestButton.Image = ((System.Drawing.Image)(resources.GetObject("picRestButton.Image")));
            this.picRestButton.Location = new System.Drawing.Point(8, 12);
            this.picRestButton.Name = "picRestButton";
            this.picRestButton.Size = new System.Drawing.Size(72, 50);
            this.picRestButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRestButton.TabIndex = 18;
            this.picRestButton.TabStop = false;
            this.picRestButton.Click += new System.EventHandler(this.picRestButton_Click);
            this.picRestButton.DoubleClick += new System.EventHandler(this.picRestButton_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 57);
            this.label1.TabIndex = 19;
            // 
            // btnCloseLoop
            // 
            this.btnCloseLoop.BackColor = System.Drawing.Color.Lime;
            this.btnCloseLoop.Location = new System.Drawing.Point(34, 31);
            this.btnCloseLoop.Name = "btnCloseLoop";
            this.btnCloseLoop.Size = new System.Drawing.Size(75, 23);
            this.btnCloseLoop.TabIndex = 21;
            this.btnCloseLoop.Text = "Open";
            this.btnCloseLoop.UseVisualStyleBackColor = false;
            this.btnCloseLoop.Click += new System.EventHandler(this.btnCloseLoop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMalha);
            this.groupBox1.Controls.Add(this.btnCloseLoop);
            this.groupBox1.Controls.Add(this.txtFeedbackGain);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 110);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loop";
            // 
            // lblMalha
            // 
            this.lblMalha.AutoSize = true;
            this.lblMalha.Location = new System.Drawing.Point(31, 16);
            this.lblMalha.Name = "lblMalha";
            this.lblMalha.Size = new System.Drawing.Size(81, 13);
            this.lblMalha.TabIndex = 22;
            this.lblMalha.Text = "Malha Fechada";
            // 
            // grpCSV
            // 
            this.grpCSV.Controls.Add(this.label4);
            this.grpCSV.Controls.Add(this.btnGerarCSV);
            this.grpCSV.Controls.Add(this.txtPasso);
            this.grpCSV.Controls.Add(this.label3);
            this.grpCSV.Controls.Add(this.label2);
            this.grpCSV.Controls.Add(this.txtTermino);
            this.grpCSV.Controls.Add(this.txtInicio);
            this.grpCSV.Location = new System.Drawing.Point(477, 77);
            this.grpCSV.Name = "grpCSV";
            this.grpCSV.Size = new System.Drawing.Size(149, 110);
            this.grpCSV.TabIndex = 23;
            this.grpCSV.TabStop = false;
            this.grpCSV.Text = "CSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passo (ms)";
            // 
            // btnGerarCSV
            // 
            this.btnGerarCSV.Location = new System.Drawing.Point(78, 61);
            this.btnGerarCSV.Name = "btnGerarCSV";
            this.btnGerarCSV.Size = new System.Drawing.Size(60, 35);
            this.btnGerarCSV.TabIndex = 2;
            this.btnGerarCSV.Text = "Gerar";
            this.btnGerarCSV.UseVisualStyleBackColor = true;
            this.btnGerarCSV.Click += new System.EventHandler(this.btnGerarCSV_Click);
            // 
            // txtPasso
            // 
            this.txtPasso.Location = new System.Drawing.Point(11, 76);
            this.txtPasso.Name = "txtPasso";
            this.txtPasso.Size = new System.Drawing.Size(60, 20);
            this.txtPasso.TabIndex = 2;
            this.txtPasso.Text = "100";
            this.txtPasso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberAndSignalsCharacteres_KeyPress);
            this.txtPasso.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Término (s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Início (s)";
            // 
            // txtTermino
            // 
            this.txtTermino.Location = new System.Drawing.Point(78, 37);
            this.txtTermino.Name = "txtTermino";
            this.txtTermino.Size = new System.Drawing.Size(60, 20);
            this.txtTermino.TabIndex = 0;
            this.txtTermino.Text = "10";
            this.txtTermino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberAndSignalsCharacteres_KeyPress);
            this.txtTermino.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(11, 37);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(60, 20);
            this.txtInicio.TabIndex = 0;
            this.txtInicio.Text = "0";
            this.txtInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberAndSignalsCharacteres_KeyPress);
            this.txtInicio.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Janela de tempo (min)";
            // 
            // txtWindowTime
            // 
            this.txtWindowTime.Location = new System.Drawing.Point(631, 92);
            this.txtWindowTime.Name = "txtWindowTime";
            this.txtWindowTime.Size = new System.Drawing.Size(100, 20);
            this.txtWindowTime.TabIndex = 25;
            this.txtWindowTime.Text = "2";
            this.txtWindowTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberAndSignalsCharacteres_KeyPress);
            this.txtWindowTime.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // grpController
            // 
            this.grpController.Controls.Add(this.btnController);
            this.grpController.Controls.Add(this.txtKd);
            this.grpController.Controls.Add(this.txtKi);
            this.grpController.Controls.Add(this.txtKp);
            this.grpController.Controls.Add(this.label9);
            this.grpController.Controls.Add(this.label7);
            this.grpController.Controls.Add(this.label6);
            this.grpController.Location = new System.Drawing.Point(322, 76);
            this.grpController.Name = "grpController";
            this.grpController.Size = new System.Drawing.Size(149, 110);
            this.grpController.TabIndex = 26;
            this.grpController.TabStop = false;
            this.grpController.Text = "Controlador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ki";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kd";
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(29, 25);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(45, 20);
            this.txtKp.TabIndex = 3;
            this.txtKp.Text = "0";
            this.txtKp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberAndSignalsCharacteres_KeyPress);
            this.txtKp.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // txtKi
            // 
            this.txtKi.Location = new System.Drawing.Point(29, 52);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(45, 20);
            this.txtKi.TabIndex = 4;
            this.txtKi.Text = "0";
            this.txtKi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberAndSignalsCharacteres_KeyPress);
            this.txtKi.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // txtKd
            // 
            this.txtKd.Location = new System.Drawing.Point(29, 79);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(45, 20);
            this.txtKd.TabIndex = 5;
            this.txtKd.Text = "0";
            this.txtKd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberAndSignalsCharacteres_KeyPress);
            this.txtKd.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // btnController
            // 
            this.btnController.BackColor = System.Drawing.Color.Red;
            this.btnController.Location = new System.Drawing.Point(85, 25);
            this.btnController.Name = "btnController";
            this.btnController.Size = new System.Drawing.Size(58, 75);
            this.btnController.TabIndex = 6;
            this.btnController.Text = "OFF";
            this.btnController.UseVisualStyleBackColor = false;
            this.btnController.Click += new System.EventHandler(this.btnController_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 555);
            this.Controls.Add(this.grpController);
            this.Controls.Add(this.txtWindowTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpCSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picOpcButton);
            this.Controls.Add(this.picRestButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnectionPage);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "CLIENT";
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpcButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestButton)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCSV.ResumeLayout(false);
            this.grpCSV.PerformLayout();
            this.grpController.ResumeLayout(false);
            this.grpController.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Button btnConnectionPage;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtFeedbackGain;
        private System.Windows.Forms.Label label8;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox picOpcButton;
        private System.Windows.Forms.PictureBox picRestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseLoop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpCSV;
        private System.Windows.Forms.TextBox txtTermino;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Button btnGerarCSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasso;
        private System.Windows.Forms.Label lblMalha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWindowTime;
        private System.Windows.Forms.GroupBox grpController;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnController;
    }
}

