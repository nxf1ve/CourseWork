using System.Collections.Generic;
using System.Linq;

namespace CourseWork
{
    public class HashTable
    {
        private int _size;
        private List<HashItem>[] _items;

       // public IReadOnlyCollection<KeyValuePair<int, List<HashItem>>> Items => _items?.Select((list, index) => new KeyValuePair<int, List<HashItem>>(index, list)).ToList().AsReadOnly();
        public HashTable(int size)
        {
            _size = size;
            _items = new List<HashItem>[_size];
        }

        private int GetHash(string key)
        {
            int hash = 0;
            foreach (char c in key.ToString())
            {
                hash += c;
            }
            return Math.Abs(hash % _size);
        }

        public void Insert(string key, int value)
        {
            var item = new HashItem(key, value);
            var hash = GetHash(key);

            if (_items[hash] == null)
            {
                _items[hash] = new List<HashItem>();
            }

            _items[hash].Add(item);
        }

        public void Delete(string key)
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

        public void SetHashTableCondition(List<HashItem>[] items)
        {
            _items = items;
        }
        public HashTableCondition SaveHashTableCondition(EnumOperations typeOperation)
        {
            return new HashTableCondition(_items, typeOperation);
        }
       
       
    }
}
