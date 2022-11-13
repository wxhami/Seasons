Console.WriteLine("Enter date your birthday");

DateTime dateTime = new DateTime();

try
{
    dateTime = DateTime.Parse(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("incorrect date");
    return;
}

ProcessTime(dateTime);



void ProcessTime(DateTime dateTime)
{
   
    
    switch (dateTime.Month)
    {
        case 1:
        case 2:
        case 12:
            Console.WriteLine("Winter");
            break;

        case 3:
        case 4:
        case 5:
            Console.WriteLine("spring");
            break;

        case 6:
        case 7:
        case 8:
            Console.WriteLine("summer");
            break;

        case 9:
        case 10:
        case 11:
            Console.WriteLine("autumn");
            break;
    }
}