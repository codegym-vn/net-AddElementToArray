using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElementToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[99];
            int i, lenght, index, value;
            Console.Write("\nChen phan tu vao mang trong C#: \n");
            Console.Write("--------------------------------\n");
            Console.Write("Nhap kich thuoc mang: ");
            lenght = Convert.ToInt32(Console.ReadLine());
            /* Nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang:\n", lenght);
            for (i = 0; i < lenght; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Nhap gia tri phan tu moi can chen: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri can chen phan tu moi nay: ");
            index = Convert.ToInt32(Console.ReadLine());
            if (index >= lenght || index == 0)
                Console.Write("Khong chen duoc phan tu vao mang\n");
            else
            {
                Console.Write("In mang ban dau:\n");
                for (i = 0; i < lenght; i++)
                {
                    Console.Write("{0} ", myArray[i]);
                }
                /* Di chuyen vi tri cac phan tu ben phai cua mang */
                for (i = lenght; i >= index; i--)
                    myArray[i] = myArray[i - 1];
                /* Chen gia tri vao vi tri da cho */
                myArray[index - 1] = value;
                Console.Write("\n\nSau khi chen phan tu, mang co dang:\n");
                for (i = 0; i <= lenght; i++)
                    Console.Write("{0} ", myArray[i]);
                Console.Write("\n\n");

            }
            Console.ReadKey();
        }
    }
}
