using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBinaryTree
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<keyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<keyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (keyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> LinkedList = GetLinkedList(position);
            keyValue<K, V> item = new keyValue<K, V>() { key = key, Value = value };
            LinkedList.AddLast(item);
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            keyValue<K, V> foundItem = default(keyValue<K, V>);
            foreach (keyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        protected LinkedList<keyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<keyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<keyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
    }
    public struct keyValue<k, V>
    {
        public k key { get; set; }
        public V Value { get; set; }
    }
}
