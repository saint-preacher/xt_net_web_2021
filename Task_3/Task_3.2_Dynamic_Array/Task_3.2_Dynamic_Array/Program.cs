using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._3
{
    class DynamicArray<T> : IEnumerable<T>
    {
        private T[] _array;
        //Variables for length and capacity
        private int _length;
        private int _capacity;
        //8. Property gets length
        public int Length
        {
            get { return _length; }
        }
        //9. Property gets capacity
        public int Capacity
        {
            get { return _capacity; }
        }
        //1. Constructor without parameters. Creates array with capacity 8
        public DynamicArray()
        {
            _array = new T[8];
            _capacity = 8;
        }
        //2. Constructor with parameters. Creates array with capacity n
        public DynamicArray(int n)
        {
            _array = new T[n];
            _capacity = n;
        }
        //3. Constructor to create array with values from IEnumerable<T> collection 
        public DynamicArray(IEnumerable<T> collection)
        {
            int countOfElements = collection.Count();
            _array = new T[countOfElements];
            _capacity = countOfElements;
            _length = countOfElements;
            //Adding elements from collection to array
            int index = 0;

            foreach (T elem in collection)
            {
                _array[index++] = elem;
            }

        }
        //4. Add element
        public void Add(T elem)
        {
            if (_length + 1 > _capacity) _capacity *= 2;

            T[] mas = new T[_capacity];

            for (int i = 0; i < _length; i++)
            {
                mas[i] = _array[i];
            }

            _array = mas;

            _array[_length++] = elem;

        }
        //5. Add range of elements
        public void AddRange(IEnumerable<T> collection)
        {
            if (_length + collection.Count() < _capacity)
                _capacity += collection.Count() - _capacity;

            foreach (T elem in collection)
            {
                this.Add(elem);
            }
        }

        //Methods to remove elements
        //Shifts array to the left
        private void ShiftArrayLeft(int index)
        {
            for (int i = index; i < _length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

        }
        //
        //6. Remove the element
        public bool Remove(T elem)
        {
            for (int i = 0; i < _length; i++)
            {
                if (_array[i].Equals(elem))
                {
                    ShiftArrayLeft(i);
                    _length--;
                    return true;
                }
            }
            return false;
        }
        //
        //Methods to insert the element
        //Shifts array to the right
        private void ShiftArrayRight(int index)
        {
            for (int i = index; i < _length - 1; i++)
            {
                _array[i + 1] = _array[i];
            }
        }
        //
        //7. Insert the element
        public bool Insert(T elem, int index)
        {
            if (index < 0 || index > _length - 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_length + 1 > _capacity)
            {
                _capacity *= 2;
            }
            ShiftArrayRight(index);
            _array[index] = elem;
            _length++;
            return true;
        }
        //
        //10. IEnumerable and IEnumerable<T>
        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)_array).GetEnumerator();
        }
        //
        //11. Indexer
        public T this[int i]
        {
            get
            {
                if (i < 0 || i > _length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _array[i];
            }
            set
            {
                if (i < 0 || i > _length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _array[i] = value;
            }
        }
        //Show the results
        public void Show()
        {
            for (int i = 0; i < _length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>();

            for (int i = 0; i < 5; i++) collection.Add(i);

            DynamicArray<int> test1 = new DynamicArray<int>(collection);
            Console.WriteLine("Output of collection");
            test1.Show();

            test1.Add(6);
            Console.WriteLine("Output after add");
            test1.Show();

            Console.WriteLine("Output after remove");
            test1.Remove(3);
            test1.Show();

            Console.WriteLine("Output after insert");
            test1.Insert(100, 4);
            test1.Show();

        }
    }
}
