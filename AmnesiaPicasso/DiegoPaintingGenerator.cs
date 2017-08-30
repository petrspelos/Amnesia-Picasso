using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace AmnesiaPicasso
{
    class DiegoPaintingGenerator
    {
        private XmlDocument daeDoc;
        private XmlDocument entDoc;
        private XmlDocument matDoc;

        enum DocType
        {
            DAE,
            ENT,
            MAT
        }

        public DiegoPaintingGenerator()
        {
            daeDoc = new XmlDocument();
            entDoc = new XmlDocument();
            matDoc = new XmlDocument();

            daeDoc.LoadXml(Properties.Resources.painting_diego_dae);
            entDoc.LoadXml(Properties.Resources.painting_diego_ent);
            matDoc.LoadXml(Properties.Resources.painting_diego_mat);
        }

        public void Generate(string texturePath, string name, string outputPath)
        {
            ReplaceTagText(DocType.DAE, "init_from", "./" + name + ".tga");
            ReplaceTagAttribute(DocType.ENT, "Mesh", 0, name + ".dae");
            ReplaceTagAttribute(DocType.MAT, "Diffuse", 2, name + ".tga");

            try
            {
                daeDoc.Save(name + ".dae");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Whops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            entDoc.Save(name + ".ent");
            matDoc.Save(name + ".mat");

            File.Move(name + ".dae", Path.Combine(outputPath, name + ".dae"));
            File.Move(name + ".ent", Path.Combine(outputPath, name + ".ent"));
            File.Move(name + ".mat", Path.Combine(outputPath, name + ".mat"));

            if(texturePath != Path.Combine(outputPath, name + ".tga"))
                File.Copy(texturePath, Path.Combine(outputPath, name + ".tga"), true);

            MessageBox.Show("Your painting had been exported!", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReplaceTagText(DocType type, string tag, string text)
        {
            XmlDocument document = GetDocumentFromType(type);

            XmlNodeList foundTextNodes = document.GetElementsByTagName(tag);
            foundTextNodes[0].InnerText = text;
        }

        private void ReplaceTagAttribute(DocType type, string tag, int attributeIndex, string text)
        {
            XmlDocument document = GetDocumentFromType(type);

            XmlNodeList foundTextNodes = document.GetElementsByTagName(tag);
            foundTextNodes[0].Attributes[attributeIndex].InnerText = text;
        }

        private XmlDocument GetDocumentFromType(DocType type)
        {
            if (type == DocType.DAE) return daeDoc;
            else if (type == DocType.ENT) return entDoc;
            else return matDoc;
        }
    }
}
