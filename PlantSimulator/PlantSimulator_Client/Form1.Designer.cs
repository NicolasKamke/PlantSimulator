
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
            this.grpCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpcButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestButton)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.zedGraph.Size = new System.Drawing.Size(725, 351);
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
            this.btnConnectionPage.Location = new System.Drawing.Point(619, 91);
            this.btnConnectionPage.Name = "btnConnectionPage";
            this.btnConnectionPage.Size = new System.Drawing.Size(79, 26);
            this.btnConnectionPage.TabIndex = 9;
            this.btnConnectionPage.Text = "Conectar";
            this.btnConnectionPage.UseVisualStyleBackColor = true;
            this.btnConnectionPage.Visible = false;
            // 
            // txtFeedbackGain
            // 
            this.txtFeedbackGain.Location = new System.Drawing.Point(27, 72);
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
            this.label8.Location = new System.Drawing.Point(20, 56);
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
            this.label1.Size = new System.Drawing.Size(734, 57);
            this.label1.TabIndex = 19;
            // 
            // btnCloseLoop
            // 
            this.btnCloseLoop.BackColor = System.Drawing.Color.Red;
            this.btnCloseLoop.Location = new System.Drawing.Point(34, 25);
            this.btnCloseLoop.Name = "btnCloseLoop";
            this.btnCloseLoop.Size = new System.Drawing.Size(75, 23);
            this.btnCloseLoop.TabIndex = 21;
            this.btnCloseLoop.Text = "Close";
            this.btnCloseLoop.UseVisualStyleBackColor = false;
            this.btnCloseLoop.Click += new System.EventHandler(this.btnCloseLoop_Click);
            // 
            // groupBox1
            // 
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 555);
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
            this.ResumeLayout(false);

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
    }
}

