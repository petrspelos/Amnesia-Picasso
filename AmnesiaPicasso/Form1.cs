using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AmnesiaPicasso
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

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

        private void download_template_Click(object sender, EventArgs e)
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

        private void OutputToCurrentLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OutputPathTextBox.Enabled = OutputPathBrowseButton.Enabled = !OutputToCurrentLocationCheckBox.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EntityNameTextBox.Enabled = !checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPaintingGeneration();
        }

        private void StartPaintingGeneration()
        {
            if(UserInputIsValid())
            {
                string texture = TexturePathTextBox.Text;
                string name = (checkBox1.Checked) ? Path.GetFileNameWithoutExtension(texture) : EntityNameTextBox.Text;
                string path = (OutputToCurrentLocationCheckBox.Checked) ? Directory.GetCurrentDirectory() : OutputPathTextBox.Text;
                GeneratePainting(texture, name, path);
            }
        }

        private bool UserInputIsValid()
        {
            return (File.Exists(TexturePathTextBox.Text) && CustomNameIsValidOrNotNeeded());
        }

        private bool CustomNameIsValidOrNotNeeded()
        {
            if (checkBox1.Checked) return true;
            if (EntityNameTextBox.Text == "") return false;
            return true;
        }

        private void GeneratePainting(string texture, string name, string path)
        {
            DiegoPaintingGenerator gen = new DiegoPaintingGenerator();
            gen.Generate(texture, name, path);
        }

        private void EntityNameTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                EntityNameTextBox.Text = EntityNameTextBox.Text.Replace(c, '_');
            }
        }

        private void OutputPathBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = OutputBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                OutputPathTextBox.Text = OutputBrowserDialog.SelectedPath;
            }
        }
    }
}
