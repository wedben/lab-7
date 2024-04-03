using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeessss 
{

    public class employees
{
    private string name = "";
    private string surname = "";
    private string patronymic = "";
    private ТРПО_Лаба_2_вариант_10__должность_ Position;

    public employees(string name, string surname, string patronymic, string post)
    {
        Name = name;
        Surname = surname;
        Patronymic = patronymic;
        Post = Position;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }
    public string Patronymic
    {
        get { return patronymic; }
        set { patronymic = value; }
    }
    public string Position
    {
        get { return post.ToString(); }
        set { post = Var10_Post.ToString(value); }
    }
    internal static ТРПО_Лаба_2_вариант_10__должность_ ToString(string value)
    {
        throw new NotImplementedException();
    }
}
}
