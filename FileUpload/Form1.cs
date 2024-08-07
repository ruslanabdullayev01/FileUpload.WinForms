using System.Windows.Forms;

namespace FileUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text, Path.Combine(@"C:\Users\Admin\source\repos\FileUpload\FileUpload\Images\", Path.GetFileName(textBox1.Text)), true);
            label1.Text = "Image File saved successfully!";
        }

    }
}
