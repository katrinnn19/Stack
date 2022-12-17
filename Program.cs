using System;
using System.Collections.Generic;
namespace Stack
{
    public class Stack<T>
    {
        private T[] stack;
        private int count;  
        const int el = 20;  //по умолчанию
        public Stack()
        {
            stack = new T[el];
        }
        public Stack(int length)
        {
            stack = new T[length];
        }
       
        public bool IsEmpty
        {
            get { return count == 0; }
        }
       
        public int Count
        {
            get { return count; }
        }
       
        public void Push(T st)
        {
            
            if (count == stack.Length)
                throw new InvalidOperationException("Переполнение стека");
            stack[count++] = st;
            Console.WriteLine(st);
        }
        
        public T Pop()
        {
             if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T st = stack[--count];
            stack[count] = default(T); // сбрасываем ссылку
            return st;
        }
        // возвращаем элемент из верхушки стека
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return stack[count - 1];
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

            var head = st.Pop();
            Console.WriteLine($"\nИзвлекаем:{head}");
            head = st.Peek();
            Console.WriteLine($"\nНовая верхушка: {head}");
          
           
        }
           
    
    }

}