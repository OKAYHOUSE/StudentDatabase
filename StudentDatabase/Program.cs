//StudentDatabase
//Application
Console.WriteLine("Welcome Student Database!");
bool keepLooping = true;
while(keepLooping)

{
 
 int student = 0;
 string[] name = { "Mara", "Krista", "Olukayode", "Robot", "Tolulope" };
 string[] food = { "Tacos", "Sushi", "Pounded Yam", "Bread", "Rice and Dodo" };
 string[] hometown = { "Rochester, MI", "Grosse Ile, MI", "Ibadan, Nigeria", "Green Bay, WI", "Asese, Nigeria" };

Console.WriteLine("Which student would you like to learn about? Please enter a Student number (1-5) or reply ALL for all students' info.");
string input = Console.ReadLine();

if (input.ToLower().Contains("all"))
{
    Console.WriteLine("Here is the students list");
    Allstudents();
}
else
{
        student = int.Parse(input) - 1;
        bool studentsInfo = true;
        while (studentsInfo)
    {
        if (student >= name.Length || student < 0)
        {
            Console.WriteLine("Invalid entry, please choose betweenn 1 - 5.");
            continue;
        }
        Console.WriteLine($"Student ID# {student + 1}: {name[student]}. Would you like to know the student's hometown, favorite food, or both?");

        string choice = Console.ReadLine().ToLower().Trim();

        if (choice == "home" || choice == "hometown")
        {
            Console.WriteLine($"{name[student]} is from {hometown[student]}");
            break;
        }
        else if (choice == "favorite food" || (choice == "food"))
        {
            Console.WriteLine($"{name[student]}'s favorite food is {food[student]}.");
            break;
        }
        else if (choice == "both")
        {
            Console.WriteLine($"{name[student]} is from {hometown[student]}, and {name[student]}'s favorite food is {food[student]}.");
            break;
        }
        else
        {
            Console.WriteLine("Invalid entry, please choose 'hometown' or 'favorite food'.");
            continue;
        }

    }
}

static void Allstudents()

{
        string[] student = new string[2];
        student[0] = "Mara";
        student[1] = "Krista";
        student[2] = "Olukayode";
        student[4] = "Robot"; 
        student[5] = "Tolulope";        

        for (int i = 0; i < student.Length; i++)
        {
            Console.WriteLine(student[i]);
        }

    }

    while (true)
{
    Console.WriteLine("Would you like to continue? Enter 'y' to continue, or press any key to exit.");
    if (Console.ReadLine().ToLower().Trim() == "y")
    {
        break;
    }
    else
    {
        Console.WriteLine("Thank you");
        keepLooping = false;
        break;
    }
}

}


/*Array.Reverse(friends);
for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine(friends[i]);
}

int[] FavoriteNums3 = favNumbers2;

int[] FavoriteNum4 = new int[favNumbers2.Length];
favNumbers2.CopyTo(FavoriteNum4, 0);

int[,] Excelsheet = new int[3, 2];
Console.WriteLine(Excelsheet[0, 1]);

int[][] Jagged = new int[5][];
Jagged[0] = new int[5];
Jagged[0] = new int[10];
Jagged[0] = new int[3];
Console.WriteLine(Jagged[1][7]);

int[] favNumbers = new int[5];

int[] favNumbers2 = { 0, 10, 9, 69, 420, 3 };

string sentence = "I am a teacher";
string[] words = sentence.Split(' ');

int librarySize = 100;
string[] books = new string[librarySize];

int result = favNumbers2[4];
Console.WriteLine(result);

int index = 2;
Console.WriteLine(favNumbers2[index]);

IndexOutOfRangeException means you are getting an element that is past the max index
Console.WriteLine(favNumbers2[6]);

Console Preview:
Welcome! Which student would you like to learn more about? Enter a number 1-9: 2

Student 2 is Barbara Baker. What would you like to know? Enter "hometown" or "favorite food": age

That category does not exist. Please try again. Enter "hometown" or "favorite food": hometown

Barbara Baker is from Grand Rapids

Would you like to learn about another student? Enter "y" or "n": n

Thanks!
*/