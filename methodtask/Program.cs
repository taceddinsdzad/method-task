//namespace methodtask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("Cevrenin Sahesi=");
//            Console.WriteLine(GetArea(13));
//            Console.WriteLine("Duzbucawlinin sahesi=");
//            Console.WriteLine(GetArea(9, 41));
//            Console.WriteLine("Parelelipipedin sahesi=");
//            Console.WriteLine(GetArea(4, 11, 8));
//            Console.WriteLine("ucbucağın daxilinde çevre sahesi=");
//            Console.WriteLine(GetArea(5, 6, 8, 3));


//        }



//        public static int GetArea(int r)
//        {
//            int p = 3;
//            int S = p * r * r;
//            return S;
//        }
//        public static int GetArea(int a, int b)
//        {
//            int S = a * b;
//            return S;
//        }
//        public static int GetArea(int a, int b, int c)
//        {
//            int S = 2 * (a * b + c * b + a * c);
//            return S;
//        }
//        public static int GetArea(int a, int b, int c, int r)
//        {
//            int S = ((a + b + c) / 2) * r;
//            return S;
//        }
//    }
//}
//}




//TAsk2
//namespace methodwithc_
//{
//    internal class Program
//    {
//        static void Main(string[] arg)
//        {
//            int[] number = { 12, 34, 56, 12, 9, 4, 5, 7 };

//            Console.WriteLine("en kiçik=" + GetMin(number));

//        }
//        public static int GetMin(int[] array)
//        {
//            int min = array[0];
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] <= min)
//                {
//                    min = array[i];
//                }
//            }
//            return min;
//        }


//    }
//}
