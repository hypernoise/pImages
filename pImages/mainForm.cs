using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pImages
{
    public partial class mainForm : System.Windows.Forms.Form
    {
        bool isResizeMode = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                Title = "Browse Text Files",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true
            };

            DialogResult dr = openFileDialog.ShowDialog();

            // Determine if the OK button was clicked on the dialog box.
            if (dr == DialogResult.OK)
            {
                // Display a message box indicating that the OK button was clicked.
                testTextBox.Text = openFileDialog.FileName;
                ImageControlPanel.ImageBox.ImageLocation = openFileDialog.FileName;
                ImageControlPanel.ImageBox.Image = Image.FromFile(@ImageControlPanel.ImageBox.ImageLocation);
                // imageBox.Width = imageBox.Image.Width;
                ImageControlPanel.ImageBox.Size = ImageControlPanel.ImageBox.Image.Size / 2;
                ImageControlPanel.ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                testTextBox.Location = new Point(0, ImageControlPanel.Location.Y + ImageControlPanel.Size.Height);
            }
            else
            {
                // Display a message box indicating that the Cancel button was clicked.
                testTextBox.Text = "404";
            }
        }

        private void testTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImageControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizeMode = true;
            }
        }

        private void ImageControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizeMode)
            {
                this.Size = new Size(e.X, e.Y);
            }
        }

        private void ImageControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizeMode = false;
            }
        }
    }
}