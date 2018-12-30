using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{
    public class MyArray<T>
    {
        private T[] array; 
        public MyArray(int size) {
            array = new T[size + 1];
        }
        public T GetItem(int index) {
            return array[index];
        }
        public void SetItem(int index, T value) {
            array[index] = value;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            // 整型数组
            MyArray<int> intArray = new MyArray<int>(5);

            for (int i = 0; i < 5; i++){
                intArray.SetItem(i, i * 5);
            }

            for (int i = 0; i < 5; i++){
                Console.Write(intArray.GetItem(i) + " ");
            }
            Console.WriteLine();

            // 字符数组
            MyArray<char> charArray = new MyArray<char>(5);
            for (int i = 0; i < 5; i++){
                charArray.SetItem(i, (char)(i + 97));
            }
            for (int i = 0; i < 5; i++){
                    Console.Write(charArray.GetItem(i) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    
}
