
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
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.grpCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.zedGraph.Size = new System.Drawing.Size(788, 292);
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
            this.txtStep.Text = "1";
            this.txtStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtStep.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
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
            // txtFeedbackGain
            // 
            this.txtFeedbackGain.Location = new System.Drawing.Point(677, 93);
            this.txtFeedbackGain.Name = "txtFeedbackGain";
            this.txtFeedbackGain.Size = new System.Drawing.Size(89, 20);
            this.txtFeedbackGain.TabIndex = 8;
            this.txtFeedbackGain.Text = "1";
            this.txtFeedbackGain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNumberCharacteres_KeyPress);
            this.txtFeedbackGain.Leave += new System.EventHandler(this.emptyTxtBoxVerify);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ganho de retroação:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(821, 18);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(79, 20);
            this.textBox10.TabIndex = 14;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(832, 82);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(414, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(984, 42);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(92, 20);
            this.textBox11.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 454);
            this.Controls.Add(this.txtFeedbackGain);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.btnConnectionPage);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtFeedbackGain;
        private System.Windows.Forms.Label label8;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBox11;
    }
}

