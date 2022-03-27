
//------------- Tamrin 1 -------------

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FatherName { get; set; }
    public string? NationalCode { get; private set; }
    public string? PhoneNumber { get; set; }
    public int[] Birthday { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }


    public Person(string? firstName, string? lastName, string? fatherName, string? nationalCode, string? phoneNum,
        int[] birthday, int height, int weight)
    {
        FirstName = firstName;
        LastName = lastName;
        FatherName = fatherName;
        PhoneNumber = phoneNum;
        Birthday = birthday;
        Height = height;
        Weight = weight;
        NationalCode = nationalCode;
    }
}