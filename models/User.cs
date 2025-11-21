using System;

public class User
{
    // Private fields to store the data
    private int userId;
    private string firstName;
    private string lastName;
    private string age; // Kept as String per your requirements
    private string emailAddress;
    private string password;
    private string gender;

    // Constructor 1: User(userId: int)
    public User(int userId)
    {
        this.userId = userId;
    }

    // Constructor 2: User(all parameters)
    public User(int userId, string firstName, string lastName, string age, string emailAddress, string password, string gender)
    {
        this.userId = userId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.emailAddress = emailAddress;
        this.password = password;
        this.gender = gender;
    }

    // --- Getters and Setters ---

    public int getUserId()
    {
        return this.userId;
    }

    // Prompt specified parameter name 'index'
    public void setUserId(int index)
    {
        this.userId = index;
    }

    public string getFirstName()
    {
        return this.firstName;
    }

    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string getLastName()
    {
        return this.lastName;
    }

    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public string getAge()
    {
        return this.age;
    }

    public void setAge(string age)
    {
        this.age = age;
    }

    public string getEmailAddress()
    {
        return this.emailAddress;
    }

    public void setEmailAddress(string emailAddress)
    {
        this.emailAddress = emailAddress;
    }

    public string getPassword()
    {
        return this.password;
    }

    public void setPassword(string pass)
    {
        this.password = pass;
    }

    public string getGender()
    {
        return this.gender;
    }

    public void setGender(string gender)
    {
        this.gender = gender;
    }

    // --- Helper Method ---

    public string getFullName()
    {
        return $"{this.firstName} {this.lastName}";
    }
}