using System;
using System.Collections.Generic;
namespace Stack
{
    public class Stack<T>
    {
        private T[] items; // элементы стека
        private int count;  // количество элементов
        const int n = 20;   // количество элементов в массиве по умолчанию
        public Stack()
        {
            items = new T[n];
        }
        public Stack(int length)
        {
            items = new T[length];
        }
        // пуст ли стек
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        // размер стека
        public int Count
        {
            get { return count; }
        }
        // добвление элемента
        public void Push(T item)
        {
            // если стек заполнен, выбрасываем исключение
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count++] = item;
            Console.WriteLine(item);
        }
        // извлечение элемента
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку
            return item;
        }
        // возвращаем элемент из верхушки стека
        public T Peek()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return items[count - 1];
        }
        public void Show()
        {
            Console.WriteLine(Push);
        }
       
    }
    class Program
    {
        static void Main()
        {
           Stack<int> st = new Stack<int>(15);
            st.Push(6);
            st.Push(9);
            st.Push(340);
            st.Push(500);
            st.Push(3);

                // извлекаем один элемент
                var head = st.Pop();
                Console.WriteLine($"\n{head}");
          
                // просто получаем верхушку стека без извлечения
                head = st.Peek();
                Console.WriteLine($"\n{head}");
            st.Show();
           
        }
           
    
    }

}