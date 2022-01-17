namespace Lab3_18520560_LeKimDanh
{
    partial class ChatTCPServer
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
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(12, 64);
            this.rtbData.Name = "rtbData";
            this.rtbData.ReadOnly = true;
            this.rtbData.Size = new System.Drawing.Size(423, 197);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
            // 
            // btnListen
            // 
            this.btnListen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListen.Location = new System.Drawing.Point(343, 24);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // ChatTCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 273);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.rtbData);
            this.Name = "ChatTCPServer";
            this.Text = "ChatTCPServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatTCPServer_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnListen;
    }
}