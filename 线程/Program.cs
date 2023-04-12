namespace 异步委托;
class Program
{
    static void Main(string[] args)
    {
        //线程类，接收要启动的线程

        //{ IsBackground= true}表示为把这个线程变成后台线程
        //它的作用是当主线程结束后它的线程如果没有执行完毕，也会结束
        //如果不写默认是前台线程，或者把值设为fals,也代表是前台线程
        //前台线程的行为是，即使主线程运行结束也会等待前台线程执行完毕后，在结束程序
        Thread thread = new Thread(Test) { IsBackground=true};
        //启动线程
        thread.Start();

        Console.WriteLine("主程序结束");
    }



    static void Test()
    {
        Console.WriteLine("启动程序");


        Console.WriteLine("运行中！");
        Thread.Sleep(3000);

        Console.WriteLine("程序结束");
    }
}

