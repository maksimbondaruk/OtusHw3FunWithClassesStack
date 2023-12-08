namespace Otus.HW_Classes
{
    internal class StackItem
    {
        //поле
        internal string[]? items;

        //конструктор
        internal StackItem(params string[]? entries)
        {
            items = new string[entries.Length];
            Array.Copy(entries, items, entries.Length);
        }

        //свойства
        internal int? CountOfElem => items.Length;
        internal string? TopElem => items.Length == 0 ? null : items[items.Length - 1];

        //методы
        internal string[]? Add(string extraElement)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = extraElement;
            return items;
        }

        internal string? Pop()
        {
            try
            {
                if (items.Length == 0)
                    throw new PopEmptyArrayException("Стек пустой");
                var retVal = items[items.Length-1];
                Array.Resize(ref items, items.Length - 1);
                return retVal;
            }
            catch (PopEmptyArrayException peaex)
            {
                Console.WriteLine(peaex.Message);
                return null;
            }
        }
    }
}
