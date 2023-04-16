namespace 委托基础;
class Program
{
    static void Main(string[] args)
    {
        //无返回值，0-16个参数的委托
        Action action = new Action(M1);
        action();
        //有返回值，有参数格式的委托
        Func<int, int, int> func = new Func<int, int, int>(Add);
        int res = func(200, 120);
        Console.WriteLine(res);

        //Lambda表达式  (int a, int b) => { return a + b; }
        Func<int, int, int> func1 = new Func<int, int, int>((int a, int b) => { return a + b; });
        int res1 = func1(10, 30);
        Console.WriteLine(res1);//40
        func1 = new Func<int, int, int>((a,b) => { return a * b; });
        int res2 = func1(200, 100);
        Console.WriteLine(res2);//20000
        //简写形式，但是一定要严格按照func1的定义格式写
        func1 = (x, y) => { return x * y; };
        int res3 = func1(3, 5);
        Console.WriteLine(res3);//15


        DoSome<int>((x, y) => { return x + y; }, 100, 200);//300
        

    }

    //泛型类，泛型委托参数
    static void DoSome<T>(Func<T,T,T> func,T x,T y)
    {
        T res = func(x, y);
        Console.WriteLine(res);//300
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







