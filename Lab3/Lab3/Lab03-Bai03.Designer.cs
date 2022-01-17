namespace Lab3_18520560_LeKimDanh
{
    partial class Lab03_Bai03
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
            this.btnTCPServer = new System.Windows.Forms.Button();
            this.btnTCPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTCPServer
            // 
            this.btnTCPServer.Location = new System.Drawing.Point(130, 23);
            this.btnTCPServer.Name = "btnTCPServer";
            this.btnTCPServer.Size = new System.Drawing.Size(136, 23);
            this.btnTCPServer.TabIndex = 0;
            this.btnTCPServer.Text = "Open TCP Server";
            this.btnTCPServer.UseVisualStyleBackColor = true;
            this.btnTCPServer.Click += new System.EventHandler(this.btnTCPServer_Click);
            // 
            // btnTCPClient
            // 
            this.btnTCPClient.Location = new System.Drawing.Point(130, 64);
            this.btnTCPClient.Name = "btnTCPClient";
            this.btnTCPClient.Size = new System.Drawing.Size(136, 23);
            this.btnTCPClient.TabIndex = 1;
            this.btnTCPClient.Text = "Open TCP Client";
            this.btnTCPClient.UseVisualStyleBackColor = true;
            this.btnTCPClient.Click += new System.EventHandler(this.btnTCPClient_Click);
            // 
            // Lab03_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 111);
            this.Controls.Add(this.btnTCPClient);
            this.Controls.Add(this.btnTCPServer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Lab03_Bai03";
            this.Text = "Lab03_Bai03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTCPServer;
        private System.Windows.Forms.Button btnTCPClient;
    }
}