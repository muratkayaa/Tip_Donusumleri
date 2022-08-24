 class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Tur Donusuleri");
        //Implicit Conversion Bilinçsiz ya da kapalı dönüşüm
        Console.WriteLine("Implicit Conversion");
        byte a=5;
        sbyte b=30;
        short c=10;
        int d =a + b + c;
        Console.WriteLine("d:" + d);

        long h = d;
        Console.WriteLine("h:" + h);

        float i =h;
        Console.WriteLine("i:" + i);

        string e ="zikriye";
        char g = 'r' ;
        object z =e + g +d;
        Console.WriteLine("z:" + z);

        //Explicit Conversion Bilinçli ya da açık dönüşüm
         Console.WriteLine("Explicit Conversion");
         int x =4;
         byte y =(byte)x;
         Console.WriteLine("y:" + y);

          int m =100;
          byte t =(byte)m;
           Console.WriteLine("t:" + t);

        // ToString Metodu
            Console.WriteLine("ToString Metodu");
            int xx= 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);


    }
}