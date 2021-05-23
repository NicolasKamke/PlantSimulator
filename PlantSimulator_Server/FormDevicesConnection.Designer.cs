
namespace PlantSimulator_Server
{
    partial class FormDevicesConnection
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
            this.txtTestSend = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnTestSend = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpTestConnection = new System.Windows.Forms.GroupBox();
            this.grpSerialConnection = new System.Windows.Forms.GroupBox();
            this.grpRestConnection = new System.Windows.Forms.GroupBox();
            this.btnStartRest = new System.Windows.Forms.Button();
            this.btnStopRest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStatusConnectionRest = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpTestConnection.SuspendLayout();
            this.grpSerialConnection.SuspendLayout();
            this.grpRestConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTestSend
            // 
            this.txtTestSend.Location = new System.Drawing.Point(9, 23);
            this.txtTestSend.Name = "txtTestSend";
            this.txtTestSend.Size = new System.Drawing.Size(185, 20);
            this.txtTestSend.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(212, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 74);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(74, 24);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(121, 21);
            this.cmbCOMPort.TabIndex = 3;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cmbBaudRate.Location = new System.Drawing.Point(74, 51);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Porta (COM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baud Rate";
            // 
            // btnTestSend
            // 
            this.btnTestSend.Location = new System.Drawing.Point(211, 23);
            this.btnTestSend.Name = "btnTestSend";
            this.btnTestSend.Size = new System.Drawing.Size(79, 20);
            this.btnTestSend.TabIndex = 5;
            this.btnTestSend.Text = "Enviar";
            this.btnTestSend.UseVisualStyleBackColor = true;
            this.btnTestSend.Click += new System.EventHandler(this.btnTestSend_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(212, 24);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(79, 74);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Desconectar";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Enabled = false;
            this.txtReceive.Location = new System.Drawing.Point(9, 49);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(185, 20);
            this.txtReceive.TabIndex = 0;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(211, 49);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(79, 20);
            this.btnReceive.TabIndex = 5;
            this.btnReceive.Text = "Receber";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(74, 78);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 20);
            this.txtStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.cmbCOMPort);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Location = new System.Drawing.Point(5, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão";
            // 
            // grpTestConnection
            // 
            this.grpTestConnection.Controls.Add(this.btnReceive);
            this.grpTestConnection.Controls.Add(this.btnTestSend);
            this.grpTestConnection.Controls.Add(this.txtReceive);
            this.grpTestConnection.Controls.Add(this.txtTestSend);
            this.grpTestConnection.Location = new System.Drawing.Point(5, 138);
            this.grpTestConnection.Name = "grpTestConnection";
            this.grpTestConnection.Size = new System.Drawing.Size(303, 86);
            this.grpTestConnection.TabIndex = 7;
            this.grpTestConnection.TabStop = false;
            this.grpTestConnection.Text = "Teste de Conexão";
            // 
            // grpSerialConnection
            // 
            this.grpSerialConnection.Controls.Add(this.grpTestConnection);
            this.grpSerialConnection.Controls.Add(this.groupBox1);
            this.grpSerialConnection.Location = new System.Drawing.Point(206, 79);
            this.grpSerialConnection.Name = "grpSerialConnection";
            this.grpSerialConnection.Size = new System.Drawing.Size(317, 233);
            this.grpSerialConnection.TabIndex = 8;
            this.grpSerialConnection.TabStop = false;
            this.grpSerialConnection.Text = "Serial";
            // 
            // grpRestConnection
            // 
            this.grpRestConnection.Controls.Add(this.txtStatusConnectionRest);
            this.grpRestConnection.Controls.Add(this.textBox1);
            this.grpRestConnection.Controls.Add(this.label5);
            this.grpRestConnection.Controls.Add(this.label4);
            this.grpRestConnection.Controls.Add(this.btnStopRest);
            this.grpRestConnection.Controls.Add(this.btnStartRest);
            this.grpRestConnection.Location = new System.Drawing.Point(26, 79);
            this.grpRestConnection.Name = "grpRestConnection";
            this.grpRestConnection.Size = new System.Drawing.Size(174, 103);
            this.grpRestConnection.TabIndex = 9;
            this.grpRestConnection.TabStop = false;
            this.grpRestConnection.Text = "Rest";
            // 
            // btnStartRest
            // 
            this.btnStartRest.Location = new System.Drawing.Point(8, 68);
            this.btnStartRest.Name = "btnStartRest";
            this.btnStartRest.Size = new System.Drawing.Size(75, 23);
            this.btnStartRest.TabIndex = 0;
            this.btnStartRest.Text = "Start";
            this.btnStartRest.UseVisualStyleBackColor = true;
            this.btnStartRest.Click += new System.EventHandler(this.btnStartRest_Click);
            // 
            // btnStopRest
            // 
            this.btnStopRest.Location = new System.Drawing.Point(89, 68);
            this.btnStopRest.Name = "btnStopRest";
            this.btnStopRest.Size = new System.Drawing.Size(75, 23);
            this.btnStopRest.TabIndex = 1;
            this.btnStopRest.Text = "Stop";
            this.btnStopRest.UseVisualStyleBackColor = true;
            this.btnStopRest.Click += new System.EventHandler(this.btnStopRest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Porta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(48, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "http://localhost:8080";
            // 
            // txtStatusConnectionRest
            // 
            this.txtStatusConnectionRest.Location = new System.Drawing.Point(48, 42);
            this.txtStatusConnectionRest.Name = "txtStatusConnectionRest";
            this.txtStatusConnectionRest.Size = new System.Drawing.Size(115, 20);
            this.txtStatusConnectionRest.TabIndex = 5;
            // 
            // FormDevicesConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 436);
            this.Controls.Add(this.grpRestConnection);
            this.Controls.Add(this.grpSerialConnection);
            this.Name = "FormDevicesConnection";
            this.Text = "FormDevicesConnection";
            this.Load += new System.EventHandler(this.FormDevicesConnection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTestConnection.ResumeLayout(false);
            this.grpTestConnection.PerformLayout();
            this.grpSerialConnection.ResumeLayout(false);
            this.grpRestConnection.ResumeLayout(false);
            this.grpRestConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTestSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbCOMPort;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnTestSend;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpTestConnection;
        private System.Windows.Forms.GroupBox grpSerialConnection;
        private System.Windows.Forms.GroupBox grpRestConnection;
        private System.Windows.Forms.TextBox txtStatusConnectionRest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStopRest;
        private System.Windows.Forms.Button btnStartRest;
    }
}