namespace Struct_class_june_140824
{
    internal class Program
    {
        class abc
        {
            int x;
        }
        struct xyz
        {
            int x;
        }
        struct student
        {
            public int roll;
            public string name;
        }

        struct st1
        {
            public int i;
            public string name;
            public st1()//default or parameterless constructor
            {
                Console.WriteLine("constructor of st1 executed!!!!!");
            }
            public st1(int a,string nm)//default or parameterless constructor
            {
                i = a;
                name=nm;
                Console.WriteLine("parameterised constructor of st1 executed i="+i+" name="+name);
            }
            public void show()
            {
                Console.WriteLine("show from st1");
            }
        }
        static void Main(string[] args)
        {
            //Int32
            //abc obj=new abc();
            ////obj.x = 100;//

            //Console.WriteLine("******************************");
            ////1
            //st1 v2=new st1(100,"rajesh");// variable obj2          
            //int W = v2.i;
            //Console.WriteLine("w="+W);

            //Console.WriteLine("################################");
            ////2 
            //st1 v3;//variable
            //v3.i = 123;
            //int Q = v3.i;
            //Console.WriteLine("Q="+Q);
            //unsafe
            //{
            //    Console.WriteLine("size of class abc=" + sizeof(abc));
            //    Console.WriteLine("size of structure  xyz=" + sizeof(xyz));
            //}

            //array of structure


            int[] IArray1 = new int[5];

            st1[]stArray=new st1[5];
            stArray[0].i = 100;
            stArray[0].name = "rajesh";

            stArray[2].i = 88;
            
        }
    }
}
