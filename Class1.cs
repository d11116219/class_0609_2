public virtual string GetName()
{
    return "Person";
}

public interface IName
{
    public string GetName();
}

public class Student : Person, IName
{
    public override string GetName()
    {
        return "Student";
    }
}

public class Teacher : Person, IName
{
    public override string GetName()
    {
        return "Teacher";
    }
}