namespace apbdcwiczenie;

public class Student
{
    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public string getName()=>this.name;
    public int getAge()=>this.age;
}