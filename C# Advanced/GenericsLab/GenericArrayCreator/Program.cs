using System;

namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] newArray = new T[length];
            for (int i = 0; i < length; i++)
            {
                newArray[i] = item;
            }
            return newArray;
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
        }
    }
}
