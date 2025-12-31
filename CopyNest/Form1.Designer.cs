namespace RoboCopyGUI
{
    partial class CopyNest
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
            label1 = new Label();
            label2 = new Label();
            txtSource = new TextBox();
            txtDestination = new TextBox();
            btnSource = new Button();
            btnDestination = new Button();
            btnStart = new Button();
            txtOutput = new RichTextBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 68);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Source";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 119);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Destination";
            // 
            // txtSource
            // 
            txtSource.Location = new Point(214, 68);
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(325, 27);
            txtSource.TabIndex = 2;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(214, 111);
            txtDestination.Name = "txtDestination";
            txtDestination.ReadOnly = true;
            txtDestination.Size = new Size(325, 27);
            txtDestination.TabIndex = 3;
            txtDestination.TextChanged += textBox2_TextChanged;
            // 
            // btnSource
            // 
            btnSource.Location = new Point(576, 66);
            btnSource.Name = "btnSource";
            btnSource.Size = new Size(122, 29);
            btnSource.TabIndex = 4;
            btnSource.Text = "Browse";
            btnSource.UseVisualStyleBackColor = true;
            btnSource.Click += btnSource_Click;
            // 
            // btnDestination
            // 
            btnDestination.Location = new Point(576, 109);
            btnDestination.Name = "btnDestination";
            btnDestination.Size = new Size(122, 29);
            btnDestination.TabIndex = 5;
            btnDestination.Text = "Browse";
            btnDestination.UseVisualStyleBackColor = true;
            btnDestination.Click += btnDestination_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(332, 170);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(122, 29);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtOutput
            // 
            txtOutput.Dock = DockStyle.Bottom;
            txtOutput.Location = new Point(8, 292);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(784, 150);
            txtOutput.TabIndex = 7;
            txtOutput.Text = "";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(101, 235);
            progressBar1.MarqueeAnimationSpeed = 30;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(597, 29);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 8;
            progressBar1.Visible = false;
            // 
            // CopyNest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(txtOutput);
            Controls.Add(btnStart);
            Controls.Add(btnDestination);
            Controls.Add(btnSource);
            Controls.Add(txtDestination);
            Controls.Add(txtSource);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CopyNest";
            Padding = new Padding(8);
            Text = "CopyNest";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSource;
        private TextBox txtDestination;
        private Button btnSource;
        private Button btnDestination;
        private Button btnStart;
        private RichTextBox txtOutput;
        private ProgressBar progressBar1;
    }
}
