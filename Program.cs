using System;

namespace gbkontrolnaya
{
    class Program
    {
        static string[] ReadArray(){
            return Console.ReadLine().Split();
        }

        static string[] LengthLessThanOrEqualTo3(string[] array){
            string[] result = new string[array.Length];
            int j = 0;
            for(int i = 0; i < array.Length; i++){
                if (array[i].Length <= 3)
                {
                    result[j] = array[i];
                    j++;
                }
            }
            return result;
        }

        static void WriteArray(string[] array){
            for(int i = 0; i < array.Length; i++){
                Console.Write(array[i] + ", ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array: ");
            WriteArray(LengthLessThanOrEqualTo3(ReadArray()));
        }
    }
}
