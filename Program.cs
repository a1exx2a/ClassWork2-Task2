namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {10,2,3,4,5};
        int y = x[0];
        foreach (int i in x) {
            if (i > y) {
                y = i;
            }
        
        }
        Console.WriteLine(y);
    }
}
