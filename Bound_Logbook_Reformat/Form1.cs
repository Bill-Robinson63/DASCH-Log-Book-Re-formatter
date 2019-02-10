using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BoundLogbookReformat : Form
    {
        public BoundLogbookReformat()
        {
            InitializeComponent();
        }

        private void buttonSelectImages_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                buttonReformatImages.Enabled = true;
                progressBarReformat.Value = 0;
                progressBarReformat.Visible = true;
            }
            else
            {
                buttonReformatImages.Enabled = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReformatImages_Click(object sender, EventArgs e)
        {
            int Cut1Start = Convert.ToInt32(numericUpDown1Start.Text);
            int Cut1Stop = Convert.ToInt32(numericUpDown1Stop.Text);
            int Cut2Start = Convert.ToInt32(numericUpDown2Start.Text);
            int Cut2Stop = Convert.ToInt32(numericUpDown2Stop.Text);
            if (Cut1Start > Cut1Stop)
            {
                MessageBox.Show("Cut 1 start must be less than cut 1 stop.");
            }
            else if (Cut1Stop > Cut2Start)
            {
                MessageBox.Show("Cut 1 stop must be less than cut 2 start.");
            }
            else if (Cut2Start > Cut2Stop)
            {
                MessageBox.Show("Cut 2 start must be less than cut 2 stop.");
            }
            else
            {

                progressBarReformat.Value = 0;
                for (int Index = 0; Index < openFileDialogImage.FileNames.Count(); Index++)
                {
                    if (openFileDialogImage.FileNames[Index].Contains("_Reformatted_") == false)
                    {
                        Image ImageOriginal = Image.FromFile(openFileDialogImage.FileNames[Index]);
                        using (var BitmapNew = new Bitmap(ImageOriginal.Width - ((Cut1Stop - Cut1Start) + (Cut2Stop - Cut2Start)), ImageOriginal.Height))
                        {
                            using (var Canvas = Graphics.FromImage(BitmapNew))
                            {
                                Canvas.DrawImage(ImageOriginal, new Rectangle(0, 0, Cut1Start, ImageOriginal.Height),
                                                                new Rectangle(0, 0, Cut1Start, ImageOriginal.Height), GraphicsUnit.Pixel);
                                Canvas.DrawImage(ImageOriginal, new Rectangle(Cut1Start, 0, Cut2Start - Cut1Stop, ImageOriginal.Height),
                                                                new Rectangle(Cut1Stop, 0, Cut2Start - Cut1Stop, ImageOriginal.Height), GraphicsUnit.Pixel);
                                Canvas.DrawImage(ImageOriginal, new Rectangle(Cut1Start + Cut2Start - Cut1Stop, 0, ImageOriginal.Width - Cut2Stop, ImageOriginal.Height),
                                                                new Rectangle(Cut2Stop, 0, ImageOriginal.Width - Cut2Stop, ImageOriginal.Height), GraphicsUnit.Pixel);
                                if (checkBoxArrow.Checked)
                                {

                                }
                                Canvas.Save();
                            }
                            int TestIndex = 0;
                            for (TestIndex = openFileDialogImage.FileNames[Index].Length - 1; TestIndex > -1; TestIndex--)
                            {
                                if (openFileDialogImage.FileNames[Index].Substring(TestIndex, 1) == "\\")
                                    break;
                            }
                            if (TestIndex > 0)
                                TestIndex++;
                            try
                            {
                                BitmapNew.Save(openFileDialogImage.FileNames[Index].Substring(0, TestIndex) + "_Reformatted_" +
                                               openFileDialogImage.FileNames[Index].Substring(TestIndex, openFileDialogImage.FileNames[Index].Length - TestIndex),
                                               ImageFormat.Jpeg);
                            }
                            catch
                            {
                                MessageBox.Show("Failed to save reformatted image " + openFileDialogImage.FileNames[Index] + " to disk.");
                                BitmapNew.Dispose();
                                break;
                            }
                            BitmapNew.Dispose();
                        }
                        ImageOriginal.Dispose();
                        progressBarReformat.Value = 100 * (Index / openFileDialogImage.FileNames.Count());
                    }
                }
                progressBarReformat.Value = 100;
                MessageBox.Show("Image Reformatting Complete");
            }
        }

        private void BoundLogbookReformat_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            numericUpDown1Start.Text = "250";
            numericUpDown1Stop.Text = "350";
            numericUpDown2Start.Text = "720";
            numericUpDown2Stop.Text = "1140";
        }

        private void buttonDefCuts_Click(object sender, EventArgs e)
        {
            SetDefaults();
        } 
    }
}
