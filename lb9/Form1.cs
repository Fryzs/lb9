using System.Windows.Forms;

namespace lb9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        object Source;
        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Source = sender;
                DataObject data = new DataObject();
                data.SetData(typeof(Image), ((PictureBox)sender).BackgroundImage);
                data.SetData(typeof(string), ((PictureBox)sender).Tag?.ToString());

                ((PictureBox)sender).DoDragDrop(data, DragDropEffects.Copy);

            }
        }

        private void pictureBox8_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Image)) || e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox8_DragDrop(object sender, DragEventArgs e)
        {
            Image tmpColor = ((PictureBox)sender).BackgroundImage;
            object tmpTag = ((PictureBox)sender).Tag;
            if (e.Data.GetDataPresent(typeof(Image)))
            {
                ((PictureBox)sender).BackgroundImage = (Image)e.Data.GetData(typeof(Image));
            }

            if (e.Data.GetDataPresent(typeof(string)))
            {
                ((PictureBox)sender).Tag = (string)e.Data.GetData(typeof(string)); // Приймаємо та встановлюємо тег
            }
            ((PictureBox)Source).BackgroundImage = tmpColor;
            ((PictureBox)Source).Tag = tmpTag;

            if (Convert.ToInt32(pictureBox3.Tag) == 1 && Convert.ToInt32(pictureBox4.Tag) == 2 && Convert.ToInt32(pictureBox5.Tag) == 3)
            {
                MessageBox.Show("Перемога");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox14.AllowDrop = true;
            pictureBox15.AllowDrop = true;
            pictureBox16.AllowDrop = true;
            pictureBox17.AllowDrop = true;
            pictureBox18.AllowDrop = true;
            pictureBox19.AllowDrop = true;
            pictureBox20.AllowDrop = true;
            pictureBox21.AllowDrop = true;
            pictureBox22.AllowDrop = true;
            pictureBox23.AllowDrop = true;
            pictureBox24.AllowDrop = true;
            pictureBox25.AllowDrop = true;
            pictureBox26.AllowDrop = true;
            pictureBox27.AllowDrop = true;
            pictureBox28.AllowDrop = true;
            pictureBox29.AllowDrop = true;



        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }
    }
}
