using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureBoxSizeChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonIncreaseSize_Click(object sender, EventArgs e)
        {
            // Increase the size of the PictureBox from the center
            int delta = 20;
            pictureBox1.Size = new Size(pictureBox1.Width + delta, pictureBox1.Height + delta);
            pictureBox1.Location = new Point(pictureBox1.Location.X - delta / 2, pictureBox1.Location.Y - delta / 2);

            // Check if the PictureBox size exceeds the form size
            if (pictureBox1.Right > this.ClientSize.Width || pictureBox1.Bottom > this.ClientSize.Height)
            {
                MessageBox.Show("😨کیوان دیگه چاق تر نیمشه😨", "👌تو برنده شدی👌", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDecreaseSize_Click(object sender, EventArgs e)
        {
            // Decrease the size of the PictureBox from the center
            MessageBox.Show("🥵کیوان که نمیتونه لاغر شه🥵", "!!!!ریدی");
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Size = new Size(100, 100); // Set to a desired small size
                pictureBox1.Location = new Point((this.ClientSize.Width - pictureBox1.Width) / 2, (this.ClientSize.Height - pictureBox1.Height) / 2); // Center the PictureBox
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
