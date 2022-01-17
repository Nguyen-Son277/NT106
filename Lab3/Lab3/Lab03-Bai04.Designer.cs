namespace Lab3_18520560_LeKimDanh
{
    partial class Lab03_Bai04
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
            this.btnOpenServer = new System.Windows.Forms.Button();
            this.btnOpennewClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenServer
            // 
            this.btnOpenServer.Location = new System.Drawing.Point(100, 28);
            this.btnOpenServer.Name = "btnOpenServer";
            this.btnOpenServer.Size = new System.Drawing.Size(196, 28);
            this.btnOpenServer.TabIndex = 0;
            this.btnOpenServer.Text = "OpenTCPServer";
            this.btnOpenServer.UseVisualStyleBackColor = true;
            this.btnOpenServer.Click += new System.EventHandler(this.btnOpenServer_Click);
            // 
            // btnOpennewClient
            // 
            this.btnOpennewClient.Location = new System.Drawing.Point(100, 79);
            this.btnOpennewClient.Name = "btnOpennewClient";
            this.btnOpennewClient.Size = new System.Drawing.Size(196, 28);
            this.btnOpennewClient.TabIndex = 1;
            this.btnOpennewClient.Text = "OpenNewTCPClient";
            this.btnOpennewClient.UseVisualStyleBackColor = true;
            this.btnOpennewClient.Click += new System.EventHandler(this.btnOpennewClient_Click);
            // 
            // Lab03_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 142);
            this.Controls.Add(this.btnOpennewClient);
            this.Controls.Add(this.btnOpenServer);
            this.Name = "Lab03_Bai04";
            this.Text = "Lab03_Bai04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenServer;
        private System.Windows.Forms.Button btnOpennewClient;
    }
}