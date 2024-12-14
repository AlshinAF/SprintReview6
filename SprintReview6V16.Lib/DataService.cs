namespace SprintReview6V16.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            // Проверка условий для n1 и n2
            if (rows <= 1 || cols <= 1 || n1 >= n2)
            {
                throw new ArgumentException("Некорректные параметры для создания массива.");
            }

            

            // Произведение элементов с нечетными индексами от K до L в строке C
            if (c < 0 || c >= rows || k < 0 || l >= cols || k > l)
            {
                throw new ArgumentOutOfRangeException("Некорректные параметры для произведения.");
            }

            int product = 1;
            for (int index = k; index <= l; index++)
            {
                if (index % 2 != 0) // Проверяем на нечетный индекс
                {
                    product *= array[c, index];
                }
            }

            return product;
        }
    }
}
