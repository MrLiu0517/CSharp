namespace 委托基础;
class Program
{
    static void Main(string[] args)
    {
        //实例化委托并接收对应格式的方法,注意接收的方法参数不需要带（）
        
        var myDele = new MyDele(M1);

        var myDele1 = new MyDele1(Add);

        MyDele2<int> myDele2 = new MyDele2<int>(Add);
        MyDele2<double> myDele3 = new MyDele2<double>(Mul);
        //多播委托，可以接收多个参数，调用时同时执行
        Cat cat = new Cat();
        myDele += cat.Say;

        
        //调用委托
        myDele();
        int res = myDele1(20, 30);
        Console.WriteLine(res);//50

        int res1 = myDele2(100,200);
        Console.WriteLine(res1);

        double res3 = myDele3(23.5, 33.6);
        Console.WriteLine(res3);
    }


    //无返回值，无参数的方法
    static void M1()
    {
        Console.WriteLine("我是M1");
    }

    //有返回值，有参数的方法
    static int Add(int a,int b)
    {
        return a + b;
    }
    //有返回值，有参数的方法
    static double Mul(double a ,double b)
    {
        return a * b;
    }
}

class Cat
{
    public void Say() {
        Console.WriteLine("我是一只cat");
    }
}






//自定义委托delegate
//无返回值，无参数格式类型
delegate void MyDele();
//有返回值，有参数格式类型
delegate int MyDele1(int a, int b);
//泛型委托，用于接收相同格式，不同参数类型的方法
delegate T MyDele2<T>(T a, T b);


