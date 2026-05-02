using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment212
{
    public partial class Welcome : Form
    {
        private int angle = 0;
        private int tickCount = 0;

        public Welcome()
        {
            InitializeComponent();
            // FIX: removed duplicate InitializeComponent() call — was causing double event subscriptions
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Width = 600;
            this.Height = 400;

            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Top welcome message
            using (Font welcomeFont = new Font("Segoe UI", 22, FontStyle.Bold))
            {
                string welcomeText = "Welcome to Lifeline Hospital";
                SizeF textSize = e.Graphics.MeasureString(welcomeText, welcomeFont);
                e.Graphics.DrawString(welcomeText, welcomeFont,
                    Brushes.SkyBlue, (this.Width - textSize.Width) / 2, 60);
            }

            // Rotating arc loader
            using (Pen pen = new Pen(Color.SkyBlue, 14))
            {
                int size = 150;
                int x = (this.Width - size) / 2;
                int y = (this.Height - size) / 2;
                e.Graphics.DrawArc(pen, x, y, size, size, angle, 270);
            }

            // Bottom please-wait message
            using (Font waitFont = new Font("Segoe UI", 14, FontStyle.Italic))
            {
                string waitText = "Please wait...";
                SizeF textSize = e.Graphics.MeasureString(waitText, waitFont);
                e.Graphics.DrawString(waitText, waitFont,
                    Brushes.Gray, (this.Width - textSize.Width) / 2, this.Height - 80);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle += 10;
            tickCount++;

            if (tickCount <= 20 && this.Opacity < 1.0)
                this.Opacity += 0.05;

            if (tickCount >= 70 && this.Opacity > 0)
                this.Opacity -= 0.05;

            // After ~3 seconds open login
            if (tickCount >= 60)
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }

            this.Invalidate();
        }

        private void Welcome_Load(object sender, EventArgs e) { }
        private void Welcome_Load_1(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
