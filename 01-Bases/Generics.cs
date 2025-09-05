partial class Program
{
    static void Generics()
    {
        string[] names = ["Juan", "Luis", "Diana"];
        int[] numbers = [1, 2, 3, 4];

        WriteLine($"Tamaño del arreglo númerico: {GetArrayLength(numbers)}");
        WriteLine($"Tamaño del arreglo de nombres: {GetArrayLength(names)}");

        Box<int> numberBox = new() { Content = 50 };
        Box<string> stringBox = new() { Content = "Ahora soy texto" };

        numberBox.Show();
        stringBox.Show();
    }


    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;

    }


}

class Box<T>
{
    public T? Content { get; set; }
    public void Show()
    {
        WriteLine($"Contenido: {Content}");
    }
}