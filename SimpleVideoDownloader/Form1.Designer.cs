namespace SimpleVideoDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_vidUrl = new Label();
            txt_videoUrls = new TextBox();
            btnDownload = new Button();
            statusStrip1 = new StatusStrip();
            lbl_status = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_vidUrl
            // 
            lbl_vidUrl.AutoSize = true;
            lbl_vidUrl.Location = new Point(12, 16);
            lbl_vidUrl.Name = "lbl_vidUrl";
            lbl_vidUrl.Size = new Size(62, 15);
            lbl_vidUrl.TabIndex = 0;
            lbl_vidUrl.Text = "Video-Urls";
            // 
            // txt_videoUrls
            // 
            txt_videoUrls.Location = new Point(12, 34);
            txt_videoUrls.Multiline = true;
            txt_videoUrls.Name = "txt_videoUrls";
            txt_videoUrls.Size = new Size(776, 123);
            txt_videoUrls.TabIndex = 1;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(12, 163);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(123, 49);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Download starten";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_status });
            statusStrip1.Location = new Point(0, 234);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(794, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(49, 17);
            lbl_status.Text = "Leerlauf";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 256);
            Controls.Add(statusStrip1);
            Controls.Add(btnDownload);
            Controls.Add(txt_videoUrls);
            Controls.Add(lbl_vidUrl);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_vidUrl;
        private TextBox txt_videoUrls;
        private Button btnDownload;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_status;
    }
}
