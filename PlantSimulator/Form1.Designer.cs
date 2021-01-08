
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
            this.updownStep = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.grpPrimeiraOrdem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownStep)).BeginInit();
            this.grpCommand.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.zedGraph.Size = new System.Drawing.Size(462, 292);
            this.zedGraph.TabIndex = 0;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 59);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxSitema
            // 
            this.cbxSitema.FormattingEnabled = true;
            this.cbxSitema.Items.AddRange(new object[] {
            "1ª Ordem"});
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
            this.txtGain.Location = new System.Drawing.Point(26, 39);
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
            this.grpPrimeiraOrdem.Location = new System.Drawing.Point(141, 17);
            this.grpPrimeiraOrdem.Name = "grpPrimeiraOrdem";
            this.grpPrimeiraOrdem.Size = new System.Drawing.Size(171, 95);
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
            this.btnStop.Location = new System.Drawing.Point(13, 59);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // updownStep
            // 
            this.updownStep.Location = new System.Drawing.Point(13, 33);
            this.updownStep.Name = "updownStep";
            this.updownStep.Size = new System.Drawing.Size(120, 20);
            this.updownStep.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Degrau";
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.updownStep);
            this.grpCommand.Controls.Add(this.label1);
            this.grpCommand.Controls.Add(this.btnStart);
            this.grpCommand.Controls.Add(this.btnStop);
            this.grpCommand.Location = new System.Drawing.Point(325, 18);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(149, 94);
            this.grpCommand.TabIndex = 8;
            this.grpCommand.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(552, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segunda Ordem";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 454);
            this.Controls.Add(this.btnConnectionPage);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPrimeiraOrdem);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.cbxSitema);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPrimeiraOrdem.ResumeLayout(false);
            this.grpPrimeiraOrdem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownStep)).EndInit();
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown updownStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

