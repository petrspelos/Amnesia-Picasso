namespace AmnesiaPicasso
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TexturePreviewImageBox = new System.Windows.Forms.PictureBox();
            this.DownloadTemplateBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModelSelection = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EntityNameTextBox = new System.Windows.Forms.TextBox();
            this.NameSameAsTextureCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OutputPathTextBox = new System.Windows.Forms.TextBox();
            this.OutputPathBrowseButton = new System.Windows.Forms.Button();
            this.OutputToCurrentLocationCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TexturePathTextBox = new System.Windows.Forms.TextBox();
            this.TexturePathBrowseButton = new System.Windows.Forms.Button();
            this.GeneratePaintingBtn = new System.Windows.Forms.Button();
            this.SaveTemplateDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenTextureDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutputBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TexturePreviewImageBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TexturePreviewImageBox
            // 
            this.TexturePreviewImageBox.Image = global::AmnesiaPicasso.Properties.Resources.painting_diego_template;
            this.TexturePreviewImageBox.Location = new System.Drawing.Point(12, 12);
            this.TexturePreviewImageBox.Name = "TexturePreviewImageBox";
            this.TexturePreviewImageBox.Size = new System.Drawing.Size(262, 263);
            this.TexturePreviewImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TexturePreviewImageBox.TabIndex = 0;
            this.TexturePreviewImageBox.TabStop = false;
            // 
            // DownloadTemplateBtn
            // 
            this.DownloadTemplateBtn.Location = new System.Drawing.Point(13, 284);
            this.DownloadTemplateBtn.Name = "DownloadTemplateBtn";
            this.DownloadTemplateBtn.Size = new System.Drawing.Size(261, 60);
            this.DownloadTemplateBtn.TabIndex = 1;
            this.DownloadTemplateBtn.Text = "Save PNG Template";
            this.DownloadTemplateBtn.UseVisualStyleBackColor = true;
            this.DownloadTemplateBtn.Click += new System.EventHandler(this.DownloadTemplateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModelSelection);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.GeneratePaintingBtn);
            this.groupBox2.Location = new System.Drawing.Point(280, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 338);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // ModelSelection
            // 
            this.ModelSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelSelection.FormattingEnabled = true;
            this.ModelSelection.Items.AddRange(new object[] {
            "Painting Diego"});
            this.ModelSelection.Location = new System.Drawing.Point(12, 19);
            this.ModelSelection.Name = "ModelSelection";
            this.ModelSelection.Size = new System.Drawing.Size(434, 21);
            this.ModelSelection.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EntityNameTextBox);
            this.groupBox4.Controls.Add(this.NameSameAsTextureCheckbox);
            this.groupBox4.Location = new System.Drawing.Point(6, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 72);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output entity name";
            // 
            // EntityNameTextBox
            // 
            this.EntityNameTextBox.Enabled = false;
            this.EntityNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.EntityNameTextBox.Name = "EntityNameTextBox";
            this.EntityNameTextBox.Size = new System.Drawing.Size(434, 20);
            this.EntityNameTextBox.TabIndex = 2;
            this.EntityNameTextBox.Text = "MyPainting";
            this.EntityNameTextBox.TextChanged += new System.EventHandler(this.EntityNameTextBox_TextChanged);
            // 
            // NameSameAsTextureCheckbox
            // 
            this.NameSameAsTextureCheckbox.AutoSize = true;
            this.NameSameAsTextureCheckbox.Checked = true;
            this.NameSameAsTextureCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NameSameAsTextureCheckbox.Location = new System.Drawing.Point(6, 48);
            this.NameSameAsTextureCheckbox.Name = "NameSameAsTextureCheckbox";
            this.NameSameAsTextureCheckbox.Size = new System.Drawing.Size(102, 17);
            this.NameSameAsTextureCheckbox.TabIndex = 4;
            this.NameSameAsTextureCheckbox.Text = "Same as texture";
            this.NameSameAsTextureCheckbox.UseVisualStyleBackColor = true;
            this.NameSameAsTextureCheckbox.CheckedChanged += new System.EventHandler(this.NameSameAsTextureCheckbox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OutputPathTextBox);
            this.groupBox3.Controls.Add(this.OutputPathBrowseButton);
            this.groupBox3.Controls.Add(this.OutputToCurrentLocationCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 68);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output path";
            // 
            // OutputPathTextBox
            // 
            this.OutputPathTextBox.Enabled = false;
            this.OutputPathTextBox.Location = new System.Drawing.Point(6, 19);
            this.OutputPathTextBox.Name = "OutputPathTextBox";
            this.OutputPathTextBox.ReadOnly = true;
            this.OutputPathTextBox.Size = new System.Drawing.Size(353, 20);
            this.OutputPathTextBox.TabIndex = 2;
            this.OutputPathTextBox.Text = "C:\\";
            // 
            // OutputPathBrowseButton
            // 
            this.OutputPathBrowseButton.Enabled = false;
            this.OutputPathBrowseButton.Location = new System.Drawing.Point(365, 17);
            this.OutputPathBrowseButton.Name = "OutputPathBrowseButton";
            this.OutputPathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.OutputPathBrowseButton.TabIndex = 1;
            this.OutputPathBrowseButton.Text = "Browse";
            this.OutputPathBrowseButton.UseVisualStyleBackColor = true;
            this.OutputPathBrowseButton.Click += new System.EventHandler(this.OutputPathBrowseButton_Click);
            // 
            // OutputToCurrentLocationCheckBox
            // 
            this.OutputToCurrentLocationCheckBox.AutoSize = true;
            this.OutputToCurrentLocationCheckBox.Checked = true;
            this.OutputToCurrentLocationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OutputToCurrentLocationCheckBox.Location = new System.Drawing.Point(6, 45);
            this.OutputToCurrentLocationCheckBox.Name = "OutputToCurrentLocationCheckBox";
            this.OutputToCurrentLocationCheckBox.Size = new System.Drawing.Size(115, 17);
            this.OutputToCurrentLocationCheckBox.TabIndex = 4;
            this.OutputToCurrentLocationCheckBox.Text = "To current location";
            this.OutputToCurrentLocationCheckBox.UseVisualStyleBackColor = true;
            this.OutputToCurrentLocationCheckBox.CheckedChanged += new System.EventHandler(this.OutputToCurrentLocationCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TexturePathTextBox);
            this.groupBox1.Controls.Add(this.TexturePathBrowseButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Painting Texture";
            // 
            // TexturePathTextBox
            // 
            this.TexturePathTextBox.Location = new System.Drawing.Point(6, 19);
            this.TexturePathTextBox.Name = "TexturePathTextBox";
            this.TexturePathTextBox.Size = new System.Drawing.Size(353, 20);
            this.TexturePathTextBox.TabIndex = 2;
            this.TexturePathTextBox.Text = "C:\\Texture.tga";
            // 
            // TexturePathBrowseButton
            // 
            this.TexturePathBrowseButton.Location = new System.Drawing.Point(365, 17);
            this.TexturePathBrowseButton.Name = "TexturePathBrowseButton";
            this.TexturePathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.TexturePathBrowseButton.TabIndex = 1;
            this.TexturePathBrowseButton.Text = "Browse";
            this.TexturePathBrowseButton.UseVisualStyleBackColor = true;
            this.TexturePathBrowseButton.Click += new System.EventHandler(this.TexturePathBrowseButton_Click);
            // 
            // GeneratePaintingBtn
            // 
            this.GeneratePaintingBtn.Location = new System.Drawing.Point(6, 272);
            this.GeneratePaintingBtn.Name = "GeneratePaintingBtn";
            this.GeneratePaintingBtn.Size = new System.Drawing.Size(446, 60);
            this.GeneratePaintingBtn.TabIndex = 3;
            this.GeneratePaintingBtn.Text = "Generate Painting";
            this.GeneratePaintingBtn.UseVisualStyleBackColor = true;
            this.GeneratePaintingBtn.Click += new System.EventHandler(this.GeneratePaintingBtn_Click);
            // 
            // SaveTemplateDialog
            // 
            this.SaveTemplateDialog.DefaultExt = "png";
            this.SaveTemplateDialog.FileName = "PaintingTemplate";
            this.SaveTemplateDialog.Filter = "PNG|*.png";
            // 
            // OpenTextureDialog
            // 
            this.OpenTextureDialog.DefaultExt = "tga";
            this.OpenTextureDialog.FileName = "texture";
            this.OpenTextureDialog.Filter = "TGA|*.tga";
            // 
            // OutputBrowserDialog
            // 
            this.OutputBrowserDialog.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DownloadTemplateBtn);
            this.Controls.Add(this.TexturePreviewImageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amnesia: Picasso - 1.0.0";
            ((System.ComponentModel.ISupportInitialize)(this.TexturePreviewImageBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TexturePreviewImageBox;
        private System.Windows.Forms.Button DownloadTemplateBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TexturePathTextBox;
        private System.Windows.Forms.Button TexturePathBrowseButton;
        private System.Windows.Forms.CheckBox OutputToCurrentLocationCheckBox;
        private System.Windows.Forms.Button GeneratePaintingBtn;
        private System.Windows.Forms.TextBox OutputPathTextBox;
        private System.Windows.Forms.Button OutputPathBrowseButton;
        private System.Windows.Forms.SaveFileDialog SaveTemplateDialog;
        private System.Windows.Forms.OpenFileDialog OpenTextureDialog;
        private System.Windows.Forms.CheckBox NameSameAsTextureCheckbox;
        private System.Windows.Forms.TextBox EntityNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FolderBrowserDialog OutputBrowserDialog;
        private System.Windows.Forms.ComboBox ModelSelection;
    }
}

