using SprintReview6V16.Lib;
namespace SprintReview6V16
{
    public partial class FormMain_AAF : Form
    {
        public FormMain_AAF()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panelLeft_AAF_Paint(object sender, PaintEventArgs e)
        {

        }


        private void textBoxN1_AAF_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxL_AAF_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatrixAAF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxValue_AAF_Enter(object sender, EventArgs e)
        {

        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // ��������� ��������� �� TextBox
                    int n1 = int.Parse(textBoxN1_AAF.Text);
                    int n2 = int.Parse(textBoxN2_AAF.Text);
                    int rows = int.Parse(textBoxRows_AAF.Text);
                    int cols = int.Parse(textBoxCols_AAF.Text);
                    int c = int.Parse(textBoxC_AAF.Text);
                    int k = int.Parse(textBoxK_AAF.Text);
                    int l = int.Parse(textBoxL_AAF.Text);

                    // ������� ��������� ������
                    int[,] array = new int[rows, cols];
                    Random random = new Random();

                    // ��������� ������ ���������� ������� � �������� ���������
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (j < 2)
                            {
                                array[i, j] = random.Next(n1, n2 + 1);
                            }
                            else
                            {
                                // ������������ �������� � ������ �������� ���������
                                array[i, j] = array[i, j - 1] * array[i, j - 1] - array[i, j - 2] * array[i, j - 2];
                            }
                        }
                    }
                    // ��������� DataGridView ���������� �������
                    dataGridViewMatrix_AAF.ColumnCount = cols;
                    dataGridViewMatrix_AAF.RowCount = rows;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dataGridViewMatrix_AAF.Rows[i].Cells[j].Value = array[i, j];
                        }
                    }

                    int product = ds.GetMatrix(array, n1, n2, c, k, l);
                    textBoxResult_AAF.Text = product.ToString();
                }
                catch
                {
                    MessageBox.Show("������� ������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



        private void textBoxResult_AAF_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_AAF_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
