namespace 泛型;
class Program
{
    static void Main(string[] args)
    {
        //泛型集合
        List<string> strings = new List<string> { "大福宝", "大聪明", "小三宝" };
        foreach (var item in strings)
        {
            Console.WriteLine(item);
        }
        //泛型字典
        Dictionary<int, string> directory = new Dictionary<int, string> { };
        int i = 0;
        foreach (var item in strings)
        {
            directory.Add(i++, item);
        }

        MyClass<int> myClass = new MyClass<int>(10);
    }
}

//泛型类
class MyClass<T>
{
    public T t;
    public MyClass(T t)
    {
        this.t = t;
        Console.WriteLine(this.t);
    }
}

