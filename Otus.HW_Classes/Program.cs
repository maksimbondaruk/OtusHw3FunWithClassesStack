namespace Otus.HW_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("a", "b", "c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            var deleted = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");   // Извлек верхний элемент 'c' Size = 2
            s.Add("d");
            Console.WriteLine($"size = {s.Size}, добавлен элемент '{s.Top}'");                     // size = 3, Top = 'd'
            deleted = s.Pop();
            Console.WriteLine($"size = {s.Size}, Top = {s.Top ?? "null"}, извлечен '{deleted ?? "null"}'"); // size = 2, Top = 'b'
            deleted = s.Pop();
            Console.WriteLine($"size = {s.Size}, Top = {s.Top ?? "null"}, извлечен '{deleted ?? "null"}'"); // size = 1, Top = 'a'
            deleted = s.Pop();
            Console.WriteLine($"size = {s.Size}, Top = {s.Top ?? "null"}, извлечен '{deleted ?? "null"}'"); // size = 0, Top = null
            deleted = s.Pop();
            Console.WriteLine($"size = {s.Size}, Top = {s.Top ?? "null"}, извлечен '{deleted ?? "null"}'"); // size = 0, Top = null
        }
    }
}