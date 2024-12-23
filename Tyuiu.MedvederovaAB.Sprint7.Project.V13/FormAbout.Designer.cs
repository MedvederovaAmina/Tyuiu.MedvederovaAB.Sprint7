namespace Tyuiu.MedvederovaAB.Sprint7.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_MAB = new Label();
            buttonOK_MAB = new Button();
            pictureBoxAvatar_MAB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MAB).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_MAB
            // 
            labelInfo_MAB.AutoSize = true;
            labelInfo_MAB.Location = new Point(205, 12);
            labelInfo_MAB.Name = "labelInfo_MAB";
            labelInfo_MAB.Size = new Size(404, 180);
            labelInfo_MAB.TabIndex = 0;
            labelInfo_MAB.Text = resources.GetString("labelInfo_MAB.Text");
            // 
            // buttonOK_MAB
            // 
            buttonOK_MAB.FlatStyle = FlatStyle.Flat;
            buttonOK_MAB.Location = new Point(484, 217);
            buttonOK_MAB.Name = "buttonOK_MAB";
            buttonOK_MAB.Size = new Size(125, 43);
            buttonOK_MAB.TabIndex = 1;
            buttonOK_MAB.Text = "OK";
            buttonOK_MAB.UseVisualStyleBackColor = true;
            buttonOK_MAB.Click += buttonOK_MAB_Click;
            // 
            // pictureBoxAvatar_MAB
            // 
            pictureBoxAvatar_MAB.Image = Properties.Resources.CmpTZLigAAM;
            pictureBoxAvatar_MAB.Location = new Point(12, 12);
            pictureBoxAvatar_MAB.Name = "pictureBoxAvatar_MAB";
            pictureBoxAvatar_MAB.Size = new Size(187, 248);
            pictureBoxAvatar_MAB.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_MAB.TabIndex = 2;
            pictureBoxAvatar_MAB.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 275);
            Controls.Add(pictureBoxAvatar_MAB);
            Controls.Add(buttonOK_MAB);
            Controls.Add(labelInfo_MAB);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MAB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_MAB;
        private Button buttonOK_MAB;
        private PictureBox pictureBoxAvatar_MAB;
    }
}