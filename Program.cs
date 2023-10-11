namespace CollectionPractice;
class Program
{
    static void Main(string[] args)
    {
        //arreglos o matrices
        int[] numbers = new int[10];
        for (int x = 0; x < numbers.Length; x++)
        {
            numbers[x] = x;
        }
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        bool[] bools = new bool[10];
        for (int x = 0; x < bools.Length; x++)
        {
            if (x % 2 == 0)
            {
                bools[x] = true;
            }
            else
            {
                bools[x] = false;
            }
        }

        foreach (bool bo in bools)
        {
            Console.WriteLine(bo);
        }

        // listas
        List<string> sabores = new List<string> { "Chocolate", "Menta", "Dulce de Leche", "Frambuesa", "Vainilla" };
        Console.WriteLine(sabores.Count);
        Console.WriteLine(sabores[2]);
        sabores.RemoveAt(2);
        Console.WriteLine(sabores.Count);

        // diccionarios
        Dictionary<string, string> heladosFavoritos = new Dictionary<string, string>();
        Random rand = new();
        foreach (string name in names)
        {
             heladosFavoritos.Add(name, sabores[rand.Next(sabores.Count)]);
        }

        foreach (KeyValuePair<string, string> entry in heladosFavoritos) {
            Console.WriteLine($"{entry.Key} -- {entry.Value}");
        }
    }
}
