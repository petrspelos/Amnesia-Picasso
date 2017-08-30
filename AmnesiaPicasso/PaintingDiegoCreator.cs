using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AmnesiaPicasso
{
    class PaintingDiegoCreator
    {
        private Bitmap template;
        public Bitmap Template { get => template; }

        public PaintingDiegoCreator()
        {
            template = Properties.Resources.painting_diego_template;
        }

        public void Create(string entityName, string outputPath, string texturePath)
        {
            if (texturePath != Path.Combine(outputPath, entityName + ".tga"))
                File.Copy(texturePath, Path.Combine(outputPath, entityName + ".tga"), true);

            string dae = new painting_diego_dae
            {
                TextureName = entityName
            }.TransformText();

            string ent = new painting_diego_ent
            {
                DaeName = entityName
            }.TransformText();

            string mat = new painting_diego_mat
            {
                TextureName = entityName
            }.TransformText();

            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), entityName + ".dae"), dae);
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), entityName + ".ent"), ent);
            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), entityName + ".mat"), mat);

            File.Move(entityName + ".dae", Path.Combine(outputPath, entityName + ".dae"));
            File.Move(entityName + ".ent", Path.Combine(outputPath, entityName + ".ent"));
            File.Move(entityName + ".mat", Path.Combine(outputPath, entityName + ".mat"));

            MessageBox.Show("Your entity was successfully created.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
