namespace Tyuiu.MedvederovaAB.Sprint7.Project.V13
{
    partial class FormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            labelTask_MAB = new Label();
            buttonOk_MAB = new Button();
            SuspendLayout();
            // 
            // labelTask_MAB
            // 
            labelTask_MAB.AutoSize = true;
            labelTask_MAB.Location = new Point(12, 9);
            labelTask_MAB.Name = "labelTask_MAB";
            labelTask_MAB.Size = new Size(970, 380);
            labelTask_MAB.TabIndex = 0;
            labelTask_MAB.Text = resources.GetString("labelTask_MAB.Text");
            // 
            // buttonOk_MAB
            // 
            buttonOk_MAB.FlatStyle = FlatStyle.Flat;
            buttonOk_MAB.Location = new Point(847, 372);
            buttonOk_MAB.Name = "buttonOk_MAB";
            buttonOk_MAB.Size = new Size(135, 48);
            buttonOk_MAB.TabIndex = 1;
            buttonOk_MAB.Text = "OK";
            buttonOk_MAB.UseVisualStyleBackColor = true;
            buttonOk_MAB.Click += buttonOk_MAB_Click;
            // 
            // FormTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 432);
            Controls.Add(buttonOk_MAB);
            Controls.Add(labelTask_MAB);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Техническое задание";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTask_MAB;
        private Button buttonOk_MAB;
    }
}