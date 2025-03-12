namespace SimpleVideoDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #if DEBUG
            txt_videoUrls.Lines = [
                "https://htlvb.at/wp-content/uploads/2025/01/Girlsteam_Interview.mp4"
                ];

            #endif
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using HttpClient httpClient = new();
            byte[] videoContent = httpClient.GetByteArrayAsync(txt_videoUrls.Lines[0]).Result;
            File.WriteAllBytes("../../video.mp4", videoContent);
        }
    }
}
