using SprintReview6V16.Lib;
namespace SprintReview6V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int rows = 3;
            int cols = 5;
            int[,] array = new int[rows, cols];
            int n1 = 1;
            int n2 = 10;
            int c = 1; // ������, ��� ������� ����� �������� ������������
            int k = 1; // ��������� ������
            int l = 4; // �������� ������
            int wait = 0; // ����� ��������� ��������, ����������� �� ��������� ������
            Random random = new Random();
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


            int product = ds.GetMatrix(array, n1, n2, c, k, l);

            // ����� ����� ���������� ��������� �������� ������������
            // � ����������� �� ��������� �������� � �������
            // ��������, ����� ��������� ���������, ����� �� ���������� ������� ��������� ��� �������

            wait = array[c, 1] * array[c, 3]; // ��������, ��� k=1 � l=4
                                              // ���������� ��� ��������, ������� ������ �������������� � ������������

            Assert.AreEqual(wait, product);
        }
    }
}