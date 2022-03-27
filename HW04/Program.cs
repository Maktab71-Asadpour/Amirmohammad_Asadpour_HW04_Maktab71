
List<Person> personList = new List<Person>();
bool canContinue = true;

while (canContinue)
{
    //---------------- Tamrin 1.1 ----------------
    Console.Write("Enter your first name: ");
    string firstName = Console.ReadLine();
    Console.Write("Enter your last name: ");
    string lastName = Console.ReadLine();
    Console.Write("Enter your father name : ");
    string fatherName = Console.ReadLine();
    Console.Write("Enter your natonal code : ");
    string natonalCode = Console.ReadLine();
    Console.Write("Enter your phone number : ");
    string phoneNumber = Console.ReadLine();
    Console.WriteLine("Enter your birthday");
    int[] birthday = new int[3];
    Console.Write("Year: "); birthday[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Month : "); birthday[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Day : "); birthday[2] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter your height : ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter your weight : ");
    int weight = Convert.ToInt32(Console.ReadLine());

    personList.Add(new Person(firstName, lastName, fatherName, natonalCode, phoneNumber, birthday, height, weight));
    var personListStringObj = Newtonsoft.Json.JsonConvert.SerializeObject(personList);
    File.WriteAllText("Persons.txt", personListStringObj);
    Console.WriteLine("\n");



    //---------------- Tamrin 1.2 ----------------
    List<Person>? fileQueryPersonList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("Persons.txt"));
    foreach (var personItem in fileQueryPersonList)
    {
        Console.WriteLine($"Name is {personItem.FirstName + " " + personItem.LastName} and National Code is {personItem.NationalCode}");
    }
    Console.WriteLine("\n");



    //---------------- Tamrin 1.3 ----------------
    Console.Write("Do you want to exit ? (y = yes)  ");
    if (Console.ReadKey().Key == ConsoleKey.Y)
    {
        File.WriteAllText("Persons.txt", "");
        canContinue = false;
    }
    Console.WriteLine("\n");

}

