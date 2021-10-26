using RotateImageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RotateImageApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void BtnSelectOutput_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = FbdOutput.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TxtBOutputLoc.Text = FbdOutput.SelectedPath;
            }
            else
            {
                TxtBOutputLoc.Text = string.Empty;
            }
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            OfdInput.Filter = "Image Files(*.BMP;*.PNG;*.JPEG;*.JPG;*.GIF)|*.BMP;*.PNG;*.JPEG;*.JPG;*.GIF";

            DialogResult dialogResult = OfdInput.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                TxtBInputFile.Text = OfdInput.FileName;
            }
            else
            {
                TxtBInputFile.Text = string.Empty;
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateFields();
            if (!isValid)
                return;

            string messageTitle = "Information";
            string messageInfo = "This operation will be generate images in folder selected with selected angles";

            DialogResult dialogResult = MessageBox.Show(messageInfo, messageTitle, MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    string inputImage = TxtBInputFile.Text,
                           outputImage = TxtBOutputLoc.Text;
                    float[] angles = GenerateArrAngles();

                    ImageService.GenerateSaveImages(inputImage, outputImage, angles);

                    MessageBox.Show("Images generated with success!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error. {ex.Message}");
                }
            }
            else
            {
                return;
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(TxtBOutputLoc.Text))
            {
                MessageBox.Show("Output location is required", "Output location required");
                return false;
            }

            if (string.IsNullOrEmpty(TxtBInputFile.Text))
            {
                MessageBox.Show("Input image is required", "Input image required");
                return false;
            }

            bool noAnglesSelected = !CkB90.Checked && !CkB180.Checked && !ckB270.Checked && !CkB360.Checked && NUDCustom.Value == 0;
            if (noAnglesSelected)
            {
                MessageBox.Show("It is mandatory to inform at least one angle", "Angle required");
                return false;   
            }

            return true;
        }

        private float[] GenerateArrAngles()
        {
            IList<float> angles = new List<float>();

            if (CkB90.Checked)
            {
                angles.Add(90);
            }

            if (CkB180.Checked)
            {
                angles.Add(180);
            }

            if (ckB270.Checked)
            {
                angles.Add(270);
            }

            if (CkB360.Checked)
            {
                angles.Add(360);
            }

            bool customAngleHasValue = NUDCustom.Value > 0 && NUDCustom.Value != 0;
            if (customAngleHasValue)
            {
                angles.Add((float)NUDCustom.Value);
            }

            return angles.ToArray();
        }
    }
}
