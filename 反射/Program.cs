using System.Reflection;

namespace CSharp基础;
class Program
{
    static void Main(string[] args)
    {
        //反射基础使用
        //获取一个类的信息
        Type type = typeof(MyClass);
        //获取它的类名
        Console.WriteLine(type.Name);
        //获取它的命名空间
        Console.WriteLine(type.Namespace);
        //获取它程序集的属性说明
        Console.WriteLine(type.Assembly);
        //获取它的的字段，返回一个数组
        FieldInfo[]  fields= type.GetFields();
        foreach (var item in fields)
        {
            //注意这里可以拿到的是公开字段，拿不到私有字段
            Console.WriteLine(item.Name);
        }

    }
}

