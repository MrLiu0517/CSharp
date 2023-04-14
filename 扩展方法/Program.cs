namespace 基础方法;
class Program
{
    static void Main(string[] args)
    {
        Penrson penrson = new Penrson() { Name = "大福宝", Age = 2 };
        MyClass.PrintPen(penrson);
    }
}

//静态方法，关键字static
//特点：1，生命周期--一旦创建，应用结束才会结束。2，全局。3效率高
//用处：多用于常用的工具类。用的时候直接调用，不用在去创建
//注意：静态类型的对象创建多了占用内存会很大。



//扩展方法
//可以调用密封类中的对象，属性，方法（扩展密封）扩展接口
//定一个一个密封类
public sealed class Penrson
{
    public string? Name { get; set; }
    public int? Age { get; set; }

    public void GetPort()
    {
        Console.WriteLine("我叫{0}，我今年{1}岁了！",this.Name,this.Age);
    }
}

//定义个一个静态方法来调用密封类
public static class MyClass
{
    public static void PrintPen (this Penrson penrson)
    {
        penrson.GetPort();
    }
}