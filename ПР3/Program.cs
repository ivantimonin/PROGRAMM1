using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор пункта домашнего задания");
            
            Console.WriteLine("2. Cоздать переменные всех базовых типов, присвоить им значения");
            Console.WriteLine("3. Сделать приведение типов");
            Console.WriteLine("4. Запросить ввод с консоли: Имя, Фамилия, Отчество");
            Console.WriteLine("5. Калькулятор");
            Console.WriteLine("Введите 2 или 3 или 4 или 5...");


            int vibor=Convert.ToInt32(Console.ReadLine());
            switch(vibor)
                {
                case 2:TASK_2.base_type(); break;
                case 3:TASK_3.type_to_type(); break;
                case 4:TASK_4.FIO(); break;
                case 5:TASK_5.calculation(); break;
                }
                       
            

            Console.ReadLine();
            
            
        }
       
        
    }
    class TASK_2
        {
        public static void base_type()
            {
            Console.WriteLine("Вы выбрали задание 2 (Базовые типы)");
            byte a1=10;
            Console.WriteLine($"Размер типа {a1.GetType()} (byte) {sizeof(byte)} байт, значение {a1}");
            int a2=10;
            Console.WriteLine($"Размер типа {a2.GetType()} (int) {sizeof(int)} байт, значение {a2}");
            double a3=10.325486545;
            Console.WriteLine($"Размер типа {a3.GetType()} (double) {sizeof(double)} байт, значение {a3}");
            uint a4=10;
            Console.WriteLine($"Размер типа {a4.GetType()} (uint) {sizeof(uint)} байт, значение {a4}");
            char a5 ='g';
            Console.WriteLine($"Размер типа {a5.GetType()} (char) {sizeof(char)} байт, значение {a5}");
            float a6=10.32f;
            Console.WriteLine($"Размер типа {a6.GetType()} (float) {sizeof(float)} байт, значение {a6}");
            long a7 =5;
            Console.WriteLine($"Размер типа {a7.GetType()} (long) {sizeof(long)} байт, значение {a7}");
            sbyte a8=6;
            Console.WriteLine($"Размер типа {a8.GetType()} (sbyte) {sizeof(sbyte)} байт, значение {a8}");
            short a9=87;
            Console.WriteLine($"Размер типа {a9.GetType()} (short) {sizeof(short)} байт, значение {a9}");
            ushort a10=18;
            Console.WriteLine($"Размер типа {a10.GetType()} (ushort) {sizeof(ushort)} байт, значение {a10}");
            ulong a11=19;
            Console.WriteLine($"Размер типа {a11.GetType()} (ulong) {sizeof(ulong)} байт, значение {a11}");
            decimal a12=14.154448M;
            Console.WriteLine($"Размер типа {a12.GetType()} (decimal) {sizeof(decimal)} байт, значение {a12}");
            }

        }
    class TASK_3
    {
        public static void type_to_type()
        {
            Console.WriteLine("Вы выбрали задание 3 (Приведение типов)");
            byte a_0=10;
            Console.WriteLine($"a)Тип данных {a_0} был: {a_0.GetType()}");
            short a_1 = (short)a_0;
            Console.WriteLine($"a)Тип данных {a_1} стал: {a_1.GetType()}");

            byte b_0=10;
            Console.WriteLine($"b)Тип данных {b_0} был: {b_0.GetType()}");
            int b_1 = (int)b_0;
            Console.WriteLine($"b)Тип данных {b_1} стал: {b_1.GetType()}");

            byte c_0=10;
            Console.WriteLine($"c)Тип данных {c_0} был: {c_0.GetType()}");
            long c_1 = (long)c_0;
            Console.WriteLine($"c)Тип данных {c_1} стал: {c_1.GetType()}");

            int d_0=10;
            Console.WriteLine($"d)Тип данных {d_0} был: {d_0.GetType()}");
            short d_1 = (short)d_0;
            Console.WriteLine($"d)Тип данных {d_1} стал: {d_1.GetType()}");

            int e_0=10;
            Console.WriteLine($"e)Тип данных {e_0} был: {e_0.GetType()}");
            long e_1 = (long)e_0;
            Console.WriteLine($"e)Тип данных {e_1} стал: {e_1.GetType()}");

            uint f_0=10;
            Console.WriteLine($"f)Тип данных {f_0} был: {f_0.GetType()}");
            long f_1 = (long)f_0;
            Console.WriteLine($"f)Тип данных {f_1} стал: {f_1.GetType()}");

            double g_0=10.325486545;
            Console.WriteLine($"g)Тип данных {g_0} был: {g_0.GetType()}");
            float g_1 = (float)g_0;
            Console.WriteLine($"g)Тип данных {g_1} стал: {g_1.GetType()}");

            float h_0=10.32f;
            Console.WriteLine($"h)Тип данных {h_0} был: {h_0.GetType()}");
            double h_1 = (double)h_0;
            Console.WriteLine($"h)Тип данных {h_1} стал: {h_1.GetType()}");

            char i_0 ='g';
            Console.WriteLine($"i)Тип данных {i_0} был: {i_0.GetType()}");
            int i_1 = (int)i_0;
            Console.WriteLine($"i)Тип данных {i_1} стал: {i_1.GetType()}");

            int j_0 =25;
            Console.WriteLine($"j)Тип данных {j_0} был: {j_0.GetType()}");
            char j_1 = (char)i_0;
            Console.WriteLine($"j)Тип данных {j_1} стал: {j_1.GetType()}");
                                             
                       

        }
    }
    class TASK_4
    {
        public static void FIO()
        {
            Console.WriteLine("Вы выбрали задание 4 (ВВОД ФИО)");
            Console.WriteLine("Введите вашу фамилию:");
            string F = Console.ReadLine();
            Console.WriteLine("Введите ваше имя:");
            string I = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество:");
            string O = Console.ReadLine();
            Console.WriteLine($"Добро пожаловать: {F} {I} {O}");
            
        }
    }
    class TASK_5
    {        
        public static void calculation ()

        {
            Console.WriteLine("Вы выбрали задание 5 (Калькулятор)");
            Console.WriteLine("Введите число a");
            var a =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак");
            char znak = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите число b");
            var b =Convert.ToDouble(Console.ReadLine());           
             
            
            if (znak == ('*')) {
                Console.WriteLine($"Ответ:{a}*{b} = {a * b}");
            }
            if (znak == ('/')) {
                Console.WriteLine($"Ответ:{a}/{b} = {a / b}");
            }
            if (znak == ('+')) {
                Console.WriteLine($"Ответ:{a}+{b} = {a + b}");
            }
            if (znak == ('-')) {
                Console.WriteLine($"Ответ:{a}-{b} = {a - b}");
            }
            

        }
    }
}

