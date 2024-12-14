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
            int c = 1; // Строка, для которой будем находить произведение
            int k = 1; // Начальный индекс
            int l = 4; // Конечный индекс
            int wait = 0; // Задаём ожидаемое значение, основываясь на случайных данных

            
            int product = ds.GetMatrix(array, n1, n2, c, k, l);

            // Здесь нужно рассчитать ожидаемое значение произведения
            // В зависимости от случайных значений в массиве
            // Например, чтобы проверить результат, можно до заполнения массива заполнить его вручную

            wait = array[c, 1] * array[c, 3]; // Учитывая, что k=1 и l=4
                                                         // Объединяем все значения, которые должны использоваться в произведении
            Assert.AreEqual(wait, product);
        }
    }
}