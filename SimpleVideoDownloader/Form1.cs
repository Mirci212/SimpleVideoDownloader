using System.Security.Policy;
using System.Windows.Forms;

namespace SimpleVideoDownloader
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource? cts = null;

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
            if (cts != null)
            {
                cts.Cancel();
                cts = null;
                btnDownload.Text = "Download starten";
                return;
            }

            lbl_status.Text = "Video wird heruntergeladen";
            btnDownload.Text = "Download abbrechen";
            txt_videoUrls.ReadOnly = true;
            try
            {
                cts = new CancellationTokenSource();
                await DownloadVideos(txt_videoUrls.Lines, cts.Token);
                lbl_status.Text = "Video wurde heruntergeladen.";
            }
            catch(OperationCanceledException)
            {
                lbl_status.Text = "Download wurde abgebrochen";
            }
            catch
            {
                lbl_status.Text = "Fehler beim Download des Videos.";
            }
            txt_videoUrls.ReadOnly = false;
        }

        private async Task DownloadVideos(string[] urls, CancellationToken ct)
        {
            foreach (var url in urls)
            {
                byte[] videoContent = await LoadVideo(url,ct);
                await File.WriteAllBytesAsync("../.. /../video.mp4", videoContent, ct);
            }
        }

        private async Task<byte[]> LoadVideo(string url, CancellationToken ct)
        {
            using HttpClient httpClient = new();
            return await httpClient.GetByteArrayAsync(url, ct);
        }
    }
}
