
namespace PlantSimulator.Communication.Rest.Forms
{
    partial class FormRest
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
            this.grpRestConnection = new System.Windows.Forms.GroupBox();
            this.txtStatusConnectionRest = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStopRest = new System.Windows.Forms.Button();
            this.btnStartRest = new System.Windows.Forms.Button();
            this.grpRestConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRestConnection
            // 
            this.grpRestConnection.Controls.Add(this.txtStatusConnectionRest);
            this.grpRestConnection.Controls.Add(this.textBox1);
            this.grpRestConnection.Controls.Add(this.label5);
            this.grpRestConnection.Controls.Add(this.label4);
            this.grpRestConnection.Controls.Add(this.btnStopRest);
            this.grpRestConnection.Controls.Add(this.btnStartRest);
            this.grpRestConnection.Location = new System.Drawing.Point(12, 12);
            this.grpRestConnection.Name = "grpRestConnection";
            this.grpRestConnection.Size = new System.Drawing.Size(174, 98);
            this.grpRestConnection.TabIndex = 10;
            this.grpRestConnection.TabStop = false;
            this.grpRestConnection.Text = "Rest";
            // 
            // txtStatusConnectionRest
            // 
            this.txtStatusConnectionRest.Location = new System.Drawing.Point(48, 42);
            this.txtStatusConnectionRest.Name = "txtStatusConnectionRest";
            this.txtStatusConnectionRest.Size = new System.Drawing.Size(115, 20);
            this.txtStatusConnectionRest.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "http://localhost:8080";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Porta";
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
            // FormRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 113);
            this.Controls.Add(this.grpRestConnection);
            this.Name = "FormRest";
            this.Text = "FormRest";
            this.grpRestConnection.ResumeLayout(false);
            this.grpRestConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRestConnection;
        private System.Windows.Forms.TextBox txtStatusConnectionRest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStopRest;
        private System.Windows.Forms.Button btnStartRest;
    }
}