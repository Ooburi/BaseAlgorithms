namespace BaseAlgorithms
{
    internal class Program
    {
        // InsertionSort
        // Input: Sequence of N numbers (a1,a2,...,aN)
        // Output: Reordering of input sequence, such that a11<=a12<=...<=a1N

        // Advantages: Simple. Good for small N.
        // Drawbacks: very long for big N
        static void Main(string[] args)
        {
            // example of using an algorithm
            int[] arr = { 0,2,1, 7, 3, 9, 2, 7, 1, 5, 6, 7, 7, 7, 4, 22, 1, 41, 8 };
            
            foreach(int i in InsertionSortUp(arr))
            {
                Console.Write(i +",");
            }
            Console.WriteLine();

            foreach (int i in InsertionSortDown(arr))
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        static int[] InsertionSortUp(int[] array)
        {
            for(int j = 1; j < array.Length; j++)
            {
                int key = array[j];
                int i = j - 1;
                while(i>=0 && key < array[i])
                {
                    array[i + 1] = array[i];
                    i--;
                }
                array[i + 1] = key;
            }

            return array;
        }
        static int[] InsertionSortDown(int[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                int key = array[j];
                int i = j - 1;
                while (i >= 0 && key > array[i])
                {
                    array[i + 1] = array[i];
                    i--;
                }
                array[i + 1] = key;
            }

            return array;
        }
    }
}