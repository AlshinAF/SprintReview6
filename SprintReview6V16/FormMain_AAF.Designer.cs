
namespace SprintReview6V16
{
    partial class FormMain_AAF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_AAF));
            panelTop_AAF = new Panel();
            buttonInfo_AAF = new Button();
            panelRight_AAF = new Panel();
            groupBoxValue_AAF = new GroupBox();
            buttonDone = new Button();
            buttonGenerateMatrix_AAF = new Button();
            labelL_AAF = new Label();
            labelK_AAF = new Label();
            labelC_AAF = new Label();
            labelCols_AAF = new Label();
            labelRows_AAF = new Label();
            labelN2_AAF = new Label();
            labelN1_AAF = new Label();
            textBoxL_AAF = new TextBox();
            textBoxK_AAF = new TextBox();
            textBoxC_AAF = new TextBox();
            dataGridViewMatrix_AAF = new DataGridView();
            textBoxCols_AAF = new TextBox();
            textBoxRows_AAF = new TextBox();
            textBoxN2_AAF = new TextBox();
            textBoxN1_AAF = new TextBox();
            panelLeft_AAF = new Panel();
            labelResult_AAF = new Label();
            textBoxResult_AAF = new TextBox();
            splitter1 = new Splitter();
            toolTip_AAF = new ToolTip(components);
            textBoxDescription_AAF = new TextBox();
            labelDescription_AAF = new Label();
            panelTop_AAF.SuspendLayout();
            panelRight_AAF.SuspendLayout();
            groupBoxValue_AAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AAF).BeginInit();
            panelLeft_AAF.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_AAF
            // 
            panelTop_AAF.BackColor = SystemColors.AppWorkspace;
            panelTop_AAF.Controls.Add(buttonInfo_AAF);
            panelTop_AAF.Dock = DockStyle.Top;
            panelTop_AAF.Location = new Point(0, 0);
            panelTop_AAF.Name = "panelTop_AAF";
            panelTop_AAF.Size = new Size(800, 102);
            panelTop_AAF.TabIndex = 0;
            // 
            // buttonInfo_AAF
            // 
            buttonInfo_AAF.Location = new Point(20, 37);
            buttonInfo_AAF.Name = "buttonInfo_AAF";
            buttonInfo_AAF.Size = new Size(75, 23);
            buttonInfo_AAF.TabIndex = 5;
            buttonInfo_AAF.Text = "?";
            toolTip_AAF.SetToolTip(buttonInfo_AAF, "О программе");
            buttonInfo_AAF.UseVisualStyleBackColor = true;
            buttonInfo_AAF.Click += buttonInfo_AAF_Click;
            // 
            // panelRight_AAF
            // 
            panelRight_AAF.BackColor = SystemColors.ControlLight;
            panelRight_AAF.Controls.Add(groupBoxValue_AAF);
            panelRight_AAF.Dock = DockStyle.Left;
            panelRight_AAF.Location = new Point(0, 102);
            panelRight_AAF.Name = "panelRight_AAF";
            panelRight_AAF.Size = new Size(485, 348);
            panelRight_AAF.TabIndex = 0;
            // 
            // groupBoxValue_AAF
            // 
            groupBoxValue_AAF.Controls.Add(buttonDone);
            groupBoxValue_AAF.Controls.Add(buttonGenerateMatrix_AAF);
            groupBoxValue_AAF.Controls.Add(labelL_AAF);
            groupBoxValue_AAF.Controls.Add(labelK_AAF);
            groupBoxValue_AAF.Controls.Add(labelC_AAF);
            groupBoxValue_AAF.Controls.Add(labelCols_AAF);
            groupBoxValue_AAF.Controls.Add(labelRows_AAF);
            groupBoxValue_AAF.Controls.Add(labelN2_AAF);
            groupBoxValue_AAF.Controls.Add(labelN1_AAF);
            groupBoxValue_AAF.Controls.Add(textBoxL_AAF);
            groupBoxValue_AAF.Controls.Add(textBoxK_AAF);
            groupBoxValue_AAF.Controls.Add(textBoxC_AAF);
            groupBoxValue_AAF.Controls.Add(dataGridViewMatrix_AAF);
            groupBoxValue_AAF.Controls.Add(textBoxCols_AAF);
            groupBoxValue_AAF.Controls.Add(textBoxRows_AAF);
            groupBoxValue_AAF.Controls.Add(textBoxN2_AAF);
            groupBoxValue_AAF.Controls.Add(textBoxN1_AAF);
            groupBoxValue_AAF.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxValue_AAF.Location = new Point(0, 3);
            groupBoxValue_AAF.Name = "groupBoxValue_AAF";
            groupBoxValue_AAF.Size = new Size(485, 345);
            groupBoxValue_AAF.TabIndex = 0;
            groupBoxValue_AAF.TabStop = false;
            groupBoxValue_AAF.Text = "Ввод значений:";
            groupBoxValue_AAF.Enter += groupBoxValue_AAF_Enter;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(255, 192, 128);
            buttonDone.Location = new Point(241, 264);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(152, 23);
            buttonDone.TabIndex = 17;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonGenerateMatrix_AAF
            // 
            buttonGenerateMatrix_AAF.BackColor = Color.FromArgb(192, 255, 255);
            buttonGenerateMatrix_AAF.Location = new Point(69, 264);
            buttonGenerateMatrix_AAF.Name = "buttonGenerateMatrix_AAF";
            buttonGenerateMatrix_AAF.Size = new Size(166, 23);
            buttonGenerateMatrix_AAF.TabIndex = 16;
            buttonGenerateMatrix_AAF.Text = "Создать матрицу";
            buttonGenerateMatrix_AAF.UseVisualStyleBackColor = false;
            buttonGenerateMatrix_AAF.Click += buttonGenerateMatrix_AAF_Click;
            // 
            // labelL_AAF
            // 
            labelL_AAF.AutoSize = true;
            labelL_AAF.Location = new Point(399, 36);
            labelL_AAF.Name = "labelL_AAF";
            labelL_AAF.Size = new Size(17, 17);
            labelL_AAF.TabIndex = 15;
            labelL_AAF.Text = "L:";
            // 
            // labelK_AAF
            // 
            labelK_AAF.AutoSize = true;
            labelK_AAF.Location = new Point(333, 36);
            labelK_AAF.Name = "labelK_AAF";
            labelK_AAF.Size = new Size(19, 17);
            labelK_AAF.TabIndex = 14;
            labelK_AAF.Text = "K:";
            // 
            // labelC_AAF
            // 
            labelC_AAF.AutoSize = true;
            labelC_AAF.Location = new Point(267, 36);
            labelC_AAF.Name = "labelC_AAF";
            labelC_AAF.Size = new Size(17, 17);
            labelC_AAF.TabIndex = 13;
            labelC_AAF.Text = "c:";
            // 
            // labelCols_AAF
            // 
            labelCols_AAF.AutoSize = true;
            labelCols_AAF.Location = new Point(201, 36);
            labelCols_AAF.Name = "labelCols_AAF";
            labelCols_AAF.Size = new Size(66, 17);
            labelCols_AAF.TabIndex = 12;
            labelCols_AAF.Text = "Столбцы:";
            // 
            // labelRows_AAF
            // 
            labelRows_AAF.AutoSize = true;
            labelRows_AAF.Location = new Point(135, 36);
            labelRows_AAF.Name = "labelRows_AAF";
            labelRows_AAF.Size = new Size(56, 17);
            labelRows_AAF.TabIndex = 11;
            labelRows_AAF.Text = "Строки:";
            // 
            // labelN2_AAF
            // 
            labelN2_AAF.AutoSize = true;
            labelN2_AAF.Location = new Point(69, 36);
            labelN2_AAF.Name = "labelN2_AAF";
            labelN2_AAF.Size = new Size(26, 17);
            labelN2_AAF.TabIndex = 10;
            labelN2_AAF.Text = "n2:";
            // 
            // labelN1_AAF
            // 
            labelN1_AAF.AutoSize = true;
            labelN1_AAF.Location = new Point(3, 36);
            labelN1_AAF.Name = "labelN1_AAF";
            labelN1_AAF.Size = new Size(24, 17);
            labelN1_AAF.TabIndex = 9;
            labelN1_AAF.Text = "n1:";
            // 
            // textBoxL_AAF
            // 
            textBoxL_AAF.Location = new Point(399, 56);
            textBoxL_AAF.Name = "textBoxL_AAF";
            textBoxL_AAF.Size = new Size(60, 25);
            textBoxL_AAF.TabIndex = 8;
            textBoxL_AAF.TextChanged += textBoxL_AAF_TextChanged;
            // 
            // textBoxK_AAF
            // 
            textBoxK_AAF.Location = new Point(333, 56);
            textBoxK_AAF.Name = "textBoxK_AAF";
            textBoxK_AAF.Size = new Size(60, 25);
            textBoxK_AAF.TabIndex = 7;
            // 
            // textBoxC_AAF
            // 
            textBoxC_AAF.Location = new Point(267, 56);
            textBoxC_AAF.Name = "textBoxC_AAF";
            textBoxC_AAF.Size = new Size(60, 25);
            textBoxC_AAF.TabIndex = 6;
            // 
            // dataGridViewMatrix_AAF
            // 
            dataGridViewMatrix_AAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_AAF.Location = new Point(0, 117);
            dataGridViewMatrix_AAF.Name = "dataGridViewMatrix_AAF";
            dataGridViewMatrix_AAF.Size = new Size(459, 141);
            dataGridViewMatrix_AAF.TabIndex = 5;
            dataGridViewMatrix_AAF.CellContentClick += dataGridViewMatrixAAF_CellContentClick;
            // 
            // textBoxCols_AAF
            // 
            textBoxCols_AAF.Location = new Point(201, 56);
            textBoxCols_AAF.Name = "textBoxCols_AAF";
            textBoxCols_AAF.Size = new Size(60, 25);
            textBoxCols_AAF.TabIndex = 4;
            // 
            // textBoxRows_AAF
            // 
            textBoxRows_AAF.Location = new Point(135, 56);
            textBoxRows_AAF.Name = "textBoxRows_AAF";
            textBoxRows_AAF.Size = new Size(60, 25);
            textBoxRows_AAF.TabIndex = 3;
            // 
            // textBoxN2_AAF
            // 
            textBoxN2_AAF.Location = new Point(69, 56);
            textBoxN2_AAF.Name = "textBoxN2_AAF";
            textBoxN2_AAF.Size = new Size(60, 25);
            textBoxN2_AAF.TabIndex = 2;
            // 
            // textBoxN1_AAF
            // 
            textBoxN1_AAF.Location = new Point(3, 56);
            textBoxN1_AAF.Name = "textBoxN1_AAF";
            textBoxN1_AAF.Size = new Size(60, 25);
            textBoxN1_AAF.TabIndex = 1;
            textBoxN1_AAF.TextChanged += textBoxN1_AAF_TextChanged;
            // 
            // panelLeft_AAF
            // 
            panelLeft_AAF.BackColor = SystemColors.ButtonFace;
            panelLeft_AAF.Controls.Add(labelDescription_AAF);
            panelLeft_AAF.Controls.Add(textBoxDescription_AAF);
            panelLeft_AAF.Controls.Add(labelResult_AAF);
            panelLeft_AAF.Controls.Add(textBoxResult_AAF);
            panelLeft_AAF.Dock = DockStyle.Right;
            panelLeft_AAF.Location = new Point(491, 102);
            panelLeft_AAF.Name = "panelLeft_AAF";
            panelLeft_AAF.Size = new Size(309, 348);
            panelLeft_AAF.TabIndex = 0;
            panelLeft_AAF.Paint += panelLeft_AAF_Paint;
            // 
            // labelResult_AAF
            // 
            labelResult_AAF.AutoSize = true;
            labelResult_AAF.Location = new Point(56, 15);
            labelResult_AAF.Name = "labelResult_AAF";
            labelResult_AAF.Size = new Size(63, 15);
            labelResult_AAF.TabIndex = 4;
            labelResult_AAF.Text = "Результат:";
            toolTip_AAF.SetToolTip(labelResult_AAF, "Результат метода GetMatrix");
            // 
            // textBoxResult_AAF
            // 
            textBoxResult_AAF.Location = new Point(56, 33);
            textBoxResult_AAF.Name = "textBoxResult_AAF";
            textBoxResult_AAF.ReadOnly = true;
            textBoxResult_AAF.Size = new Size(206, 23);
            textBoxResult_AAF.TabIndex = 0;
            textBoxResult_AAF.TextChanged += textBoxResult_AAF_TextChanged;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(485, 102);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 348);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // toolTip_AAF
            // 
            toolTip_AAF.ToolTipTitle = "Подсказка";
            // 
            // textBoxDescription_AAF
            // 
            textBoxDescription_AAF.BackColor = SystemColors.ControlLightLight;
            textBoxDescription_AAF.Location = new Point(56, 120);
            textBoxDescription_AAF.Multiline = true;
            textBoxDescription_AAF.Name = "textBoxDescription_AAF";
            textBoxDescription_AAF.ReadOnly = true;
            textBoxDescription_AAF.Size = new Size(206, 184);
            textBoxDescription_AAF.TabIndex = 6;
            textBoxDescription_AAF.Text = resources.GetString("textBoxDescription_AAF.Text");
            // 
            // labelDescription_AAF
            // 
            labelDescription_AAF.AutoSize = true;
            labelDescription_AAF.Location = new Point(56, 102);
            labelDescription_AAF.Name = "labelDescription_AAF";
            labelDescription_AAF.Size = new Size(56, 15);
            labelDescription_AAF.TabIndex = 7;
            labelDescription_AAF.Text = "Условие:";
            // 
            // FormMain_AAF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_AAF);
            Controls.Add(panelRight_AAF);
            Controls.Add(panelTop_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_AAF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринтревью 6 | Вариант 16 | РППб-24-1 | Альшин А. Ф.";
            Load += Form1_Load;
            panelTop_AAF.ResumeLayout(false);
            panelRight_AAF.ResumeLayout(false);
            groupBoxValue_AAF.ResumeLayout(false);
            groupBoxValue_AAF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AAF).EndInit();
            panelLeft_AAF.ResumeLayout(false);
            panelLeft_AAF.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Panel panelTop_AAF;
        private Panel panelRight_AAF;
        private Panel panelLeft_AAF;
        private Splitter splitter1;
        private GroupBox groupBoxValue_AAF;
        private DataGridView dataGridViewMatrix_AAF;
        private TextBox textBoxCols_AAF;
        private TextBox textBoxRows_AAF;
        private TextBox textBoxN2_AAF;
        private TextBox textBoxN1_AAF;
        private TextBox textBoxC_AAF;
        private TextBox textBoxL_AAF;
        private TextBox textBoxK_AAF;
        private Label labelL_AAF;
        private Label labelK_AAF;
        private Label labelC_AAF;
        private Label labelCols_AAF;
        private Label labelRows_AAF;
        private Label labelN2_AAF;
        private Label labelN1_AAF;
        private Button buttonGenerateMatrix_AAF;
        private Button buttonDone;
        private TextBox textBoxResult_AAF;
        private Label labelResult_AAF;
        private ToolTip toolTip_AAF;
        private Button buttonInfo_AAF;
        private Label labelDescription_AAF;
        private TextBox textBoxDescription_AAF;
    }
}
