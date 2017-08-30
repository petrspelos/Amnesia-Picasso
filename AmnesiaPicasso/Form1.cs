using System;
using System.Windows.Forms;
using System.IO;

namespace AmnesiaPicasso
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ModelSelection.SelectedIndex = 0;
        }
        
        private void DownloadTemplateBtn_Click(object sender, EventArgs e)
        {
            DownloadPaintingTemplate();
        }

        private void TexturePathBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenTextureDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string textureFile = OpenTextureDialog.FileName;
                TexturePathTextBox.Text = textureFile;
            }
        }

        private void GeneratePaintingBtn_Click(object sender, EventArgs e)
        {
            StartPaintingGeneration();
        }

        private void OutputPathBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OutputBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                OutputPathTextBox.Text = OutputBrowserDialog.SelectedPath;
            }
        }

        private void EntityNameTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                EntityNameTextBox.Text = EntityNameTextBox.Text.Replace(c, '_');
            }
        }

        private void DownloadPaintingTemplate()
        {
            DialogResult result = SaveTemplateDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string saveFile = SaveTemplateDialog.FileName;
                Properties.Resources.painting_diego_template.Save(saveFile);
            }
        }

        private void OutputToCurrentLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OutputPathTextBox.Enabled = OutputPathBrowseButton.Enabled = !OutputToCurrentLocationCheckBox.Checked;
        }
        
        private void NameSameAsTextureCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            EntityNameTextBox.Enabled = !NameSameAsTextureCheckbox.Checked;
        }

        private bool UserInputIsValid()
        {
            if (!File.Exists(TexturePathTextBox.Text))
            {
                MessageBox.Show("Texture you selected wasn't found.", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CustomNameIsValidOrNotNeeded()) return true;
            return false;
        }

        private bool CustomNameIsValidOrNotNeeded()
        {
            if (NameSameAsTextureCheckbox.Checked) return true;
            if (EntityNameTextBox.Text == "")
            {
                MessageBox.Show("Entity name must not be empty.", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void StartPaintingGeneration()
        {
            if (UserInputIsValid())
            {
                string texture = TexturePathTextBox.Text;
                string name = (NameSameAsTextureCheckbox.Checked) ? Path.GetFileNameWithoutExtension(texture) : EntityNameTextBox.Text;
                string path = (OutputToCurrentLocationCheckBox.Checked) ? Directory.GetCurrentDirectory() : OutputPathTextBox.Text;
                GeneratePainting(texture, name, path);
            }
        }

        private void GeneratePainting(string texture, string name, string path)
        {
            PaintingDiegoCreator pdc = new PaintingDiegoCreator();
            pdc.Create(name, path, texture);
        }
    }
}
