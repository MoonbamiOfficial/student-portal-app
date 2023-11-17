using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal.Panels
{
    public partial class Degree : UserControl
    {
        public Degree()
        {
            InitializeComponent();
        }
        Bitmap bit;
        private void captureCardPanel()
        {
            bit = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bit, new Rectangle(0, 0, this.Width, this.Height));
        }
        //
        //  Captures the whole user control and save it as a PNG with a title of "My Card"
        //
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveCard = new SaveFileDialog();
            saveCard.Filter = "PNG Image|*.png";
            saveCard.FileName = "My Card";
            saveCard.InitialDirectory = "Downloads";
            saveCard.RestoreDirectory = true;

            if(saveCard.ShowDialog() == DialogResult.OK)
            {
                downloadBtn.Hide();
                captureCardPanel();
                bit.Save(saveCard.FileName, System.Drawing.Imaging.ImageFormat.Png);
                downloadBtn.Show();
            }
        }
    }
}
