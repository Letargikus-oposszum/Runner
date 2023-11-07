using igen;

//var participants = new List<Speed>();
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Give me the gender of the runner: ");
    int genderinput = 0;
    try
    {
        string gender = Console.ReadLine();
        genderinput = Convert.ToInt32(gender);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wrong type of data or out of list, please try again!");
    }

    var speed = new Speed(genderinput);

    Console.WriteLine("What is the name of the runner: ");
    speed.Name = Console.ReadLine();

    Console.WriteLine("What is the avarage_speed of the runner: ");
    string avarage_speed = Console.ReadLine();
    speed.Runner_speed = Convert.ToInt32(avarage_speed);

    Console.WriteLine("How much time did the runner run: ");
    string time = Console.ReadLine();
    int Time = Convert.ToInt32(time);
    speed.Time = Time;

    switch (genderinput)
    {
        case 1:
            Console.WriteLine(speed.Name + " travelled " + speed.count() + " kilometers.\nThe participant's gender is man.");
            break;
        case 2:
            Console.WriteLine(speed.Name + " travelled " + speed.count() + " kilometers.\nThe participant's gender is woman.");
            break;
        default:
            Console.WriteLine(speed.Name + " travelled " + speed.count() + " kilometers.\nThe participant's gender is something else that we didn't identify yet.");
            break;
    }

}

