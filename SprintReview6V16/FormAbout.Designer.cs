
namespace SprintReview6V16
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
            buttonExit_AAF = new Button();
            textBoxInfo_AAF = new TextBox();
            pictureBoxAvatar_AAF = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AAF).BeginInit();
            SuspendLayout();
            // 
            // buttonExit_AAF
            // 
            buttonExit_AAF.Location = new Point(272, 341);
            buttonExit_AAF.Name = "buttonExit_AAF";
            buttonExit_AAF.Size = new Size(234, 39);
            buttonExit_AAF.TabIndex = 0;
            buttonExit_AAF.Text = "Выйти";
            buttonExit_AAF.UseVisualStyleBackColor = true;
            buttonExit_AAF.Click += buttonExit_AAF_Click;
            // 
            // textBoxInfo_AAF
            // 
            textBoxInfo_AAF.Location = new Point(359, 73);
            textBoxInfo_AAF.Multiline = true;
            textBoxInfo_AAF.Name = "textBoxInfo_AAF";
            textBoxInfo_AAF.ReadOnly = true;
            textBoxInfo_AAF.Size = new Size(242, 163);
            textBoxInfo_AAF.TabIndex = 1;
            textBoxInfo_AAF.Text = resources.GetString("textBoxInfo_AAF.Text");
            textBoxInfo_AAF.TextChanged += textBox1_TextChanged;
            // 
            // pictureBoxAvatar_AAF
            // 
            pictureBoxAvatar_AAF.Image = (Image)resources.GetObject("pictureBoxAvatar_AAF.Image");
            pictureBoxAvatar_AAF.Location = new Point(169, 73);
            pictureBoxAvatar_AAF.Name = "pictureBoxAvatar_AAF";
            pictureBoxAvatar_AAF.Size = new Size(174, 163);
            pictureBoxAvatar_AAF.TabIndex = 2;
            pictureBoxAvatar_AAF.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 425);
            Controls.Add(pictureBoxAvatar_AAF);
            Controls.Add(textBoxInfo_AAF);
            Controls.Add(buttonExit_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AAF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button buttonExit_AAF;
        private TextBox textBoxInfo_AAF;
        private PictureBox pictureBoxAvatar_AAF;
    }
}