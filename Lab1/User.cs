namespace Lab1;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public int Age { get; set; }
    public string FullName => $"{LastName} {FirstName} {MiddleName}";

    public User(string firstName, string lastName, string middleName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Age = age;
    }
    public User() : this(string.Empty, string.Empty, string.Empty, 0)
    {
    }

    public User(User user) :
        this(user.FirstName, user.LastName, user.MiddleName, user.Age)
    {
    }

    public User Clone()
    {
        return new User(this);
    }
}