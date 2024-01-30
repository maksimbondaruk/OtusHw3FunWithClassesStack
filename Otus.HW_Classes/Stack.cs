namespace Otus.HW_Classes
{
    public class Stack
    {
        //поля
        private Item? _head;
        private Item? _tail;
        private Item? _prev;
        private int _count;
        //Конструктор
        public Stack(params string[] entries)
        {
            foreach (var t in entries)
            {
                Add(t);
            }
        }
        //свойства
        public int? Size => _count;
        public string? Top => _tail?.Data;
        //методы
        public void Add(string? extraElement)
        {
            if (extraElement == null)
            {
                throw new ArgumentNullException(nameof(extraElement));
            }
            var item = new Item(extraElement);
            if (_head == null)
            {
                _head = item;
            }
            else
            {
                _prev = _tail ?? throw new ArgumentNullException();
                _tail.Next = item;
            }
            _tail = item;
            _tail.Prev = _prev;
            _count++;
        }

        public string? Pop()
        {
            if (_count > 0)
            {
                var deleted = _tail?.Data;
                _tail = _tail?.Prev;
                _count--;
                return deleted;
            }
            else
            {
                return null;
            }
        }
        private class Item
        {
            //свойства
            internal string Data { get; set; }
            internal Item? Next { get; set; }
            internal Item? Prev { get; set; }
            //конструктор
            internal Item(string data)
            {
                Data = data ?? throw new ArgumentNullException(nameof(data));
            }
        }
    }

}
