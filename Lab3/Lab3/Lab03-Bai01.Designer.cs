namespace Lab3_18520560_LeKimDanh
{
    partial class Lab03_Bai01
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
            this.btnUDPServer = new System.Windows.Forms.Button();
            this.btnUDPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUDPServer
            // 
            this.btnUDPServer.AutoSize = true;
            this.btnUDPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDPServer.Location = new System.Drawing.Point(42, 37);
            this.btnUDPServer.Name = "btnUDPServer";
            this.btnUDPServer.Size = new System.Drawing.Size(90, 26);
            this.btnUDPServer.TabIndex = 0;
            this.btnUDPServer.Text = "UDP Server";
            this.btnUDPServer.UseVisualStyleBackColor = true;
            this.btnUDPServer.Click += new System.EventHandler(this.btnUDPServer_Click);
            // 
            // btnUDPClient
            // 
            this.btnUDPClient.AutoSize = true;
            this.btnUDPClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDPClient.Location = new System.Drawing.Point(183, 37);
            this.btnUDPClient.Name = "btnUDPClient";
            this.btnUDPClient.Size = new System.Drawing.Size(90, 26);
            this.btnUDPClient.TabIndex = 1;
            this.btnUDPClient.Text = "UDP Client";
            this.btnUDPClient.UseVisualStyleBackColor = true;
            this.btnUDPClient.Click += new System.EventHandler(this.btnUDPClient_Click);
            // 
            // Lab03_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 94);
            this.Controls.Add(this.btnUDPClient);
            this.Controls.Add(this.btnUDPServer);
            this.Name = "Lab03_Bai01";
            this.Text = "Lab03_Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUDPServer;
        private System.Windows.Forms.Button btnUDPClient;
    }
}