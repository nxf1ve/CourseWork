using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork
{
    public class HashTable
    {
        private int _size;
        private List<HashItem>[] _items;
        public List<HashItem>[] GetItems()
        {
            return _items;
        }
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
        public int Get(string key)
        {
            int index = GetHash(key);
            if (_items[index] != null)
            {
                foreach (var item in _items[index])
                {
                    if (item.Key == key)
                    {
                        return item.Value;
                    }
                }
            }
            return -1;
        }

        public void SetHashTableCondition(HashTableCondition condition)
        {
            _items = condition._hashTable.Select(bucket => bucket?.Select(item => new HashItem(item.Key, item.Value)).ToList()).ToArray();
            _size = condition.hashTablesize;
        }
        public HashTableCondition SaveHashTableCondition(EnumOperations typeOperation, HashItem item)
        {
            var itemsCopy = new List<HashItem>[_items.Length];
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] != null)
                {
                    itemsCopy[i] = new List<HashItem>();
                    foreach (var hashItem in _items[i])
                    {
                        itemsCopy[i].Add(new HashItem(hashItem.Key, hashItem.Value));
                    }
                }
            }
            if (item == null)
            {
                return new HashTableCondition(itemsCopy, typeOperation, item, _size, null);
            }
            return new HashTableCondition(itemsCopy, typeOperation, item, _size, GetHash(item.Key));
        }

    }
}
