namespace Client1
{
    partial class Form1
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
            this.txtPort2 = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.txtHost2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPort2
            // 
            this.txtPort2.Location = new System.Drawing.Point(238, 36);
            this.txtPort2.Name = "txtPort2";
            this.txtPort2.Size = new System.Drawing.Size(64, 20);
            this.txtPort2.TabIndex = 20;
            this.txtPort2.Text = "8910";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(94, 155);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(329, 111);
            this.txtDisplay.TabIndex = 21;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(94, 65);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(329, 55);
            this.txtMess.TabIndex = 22;
            // 
            // txtHost2
            // 
            this.txtHost2.Location = new System.Drawing.Point(94, 36);
            this.txtHost2.Name = "txtHost2";
            this.txtHost2.Size = new System.Drawing.Size(100, 20);
            this.txtHost2.TabIndex = 23;
            this.txtHost2.Text = "127.0.0.1";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(348, 126);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Port :";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(348, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 19;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Host :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 283);
            this.Controls.Add(this.txtPort2);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.txtHost2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort2;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.TextBox txtHost2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
    }
}

