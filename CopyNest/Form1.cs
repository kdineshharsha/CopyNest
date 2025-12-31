namespace RoboCopyGUI
{
    public partial class CopyNest : Form
    {
        public CopyNest()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text) || string.IsNullOrEmpty(txtDestination.Text))
            {
                MessageBox.Show("Please select both source and destination folders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string command = $"robocopy \"{txtSource.Text}\" \"{txtDestination.Text}\" /E";

            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c {command}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            System.Diagnostics.Process process = new System.Diagnostics.Process
            {
                StartInfo = psi
            };

            process.OutputDataReceived += (s, ea) =>
            {
                if (!string.IsNullOrEmpty(ea.Data))
                {
                    this.Invoke(new Action(() =>
                    {
                        txtOutput.AppendText(ea.Data + Environment.NewLine);

                    }));
                }
            };

            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            btnStart.Enabled = false;

            process.EnableRaisingEvents = true;

            process.Exited += (s, ev) =>
            {
                Invoke(new Action(() =>
                {
                    progressBar1.Visible = false;
                }));
            };


            process.Start();

            process.BeginOutputReadLine();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
