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

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            lbl_status.Text = "Video wird heruntergeladen";
            HttpClient httpClient = new();
            byte[] videoContent = await httpClient.GetByteArrayAsync(txt_videoUrls.Lines[0]);
            await Task.Run(() => File.WriteAllBytesAsync("../../../video.mp4", videoContent));
            lbl_status.Text = "Video wurde heruntergeladen.";
        }
    }
}
