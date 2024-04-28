using System.Collections.Generic;
using System.Linq;

namespace CourseWork
{
    public class HashTable
    {
        private readonly int _maxSize = 32;

        private List<HashItem>[] _items = null;

        public IReadOnlyCollection<KeyValuePair<int, List<HashItem>>> Items => _items?.Select((list, index) => new KeyValuePair<int, List<HashItem>>(index, list)).ToList().AsReadOnly();

        public HashTable()
        {
            _items = new List<HashItem>[_maxSize];
        }

        private int GetHash(int value)
        {
            return value % _maxSize;
        }

        public void Insert(int key, int value)
        {
            var item = new HashItem(key, value);
            var hash = GetHash(item.Key);

            if (_items[hash] == null)
            {
                _items[hash] = new List<HashItem>();
            }

            _items[hash].Add(item);
        }

        public void Delete(int key)
        {
            // Вычисляем хеш ключа
            var hash = GetHash(key);

            // Проверяем, существует ли цепочка для этого хеша
            if (_items[hash] == null)
            {
                return;
            }

            // Находим цепочку элементов
            var chain = _items[hash];

            // Ищем элемент с нужным ключом в цепочке
            var itemToRemove = chain.FirstOrDefault(item => item.Key == key);

            // Если элемент найден, удаляем его из цепочки
            if (itemToRemove != null)
            {
                chain.Remove(itemToRemove);
            }
        }
    }
}
