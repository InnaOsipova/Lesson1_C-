int count = 0;
Console.Writedouble("На каком растоянии друзья находятся друг от друга (в метрах): ");
distans = Convert.ToDouble(Console.ReadLine());
Console.Write("Скорость первого друга м.с: ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Скорость первого друга м.с: ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());

if(firstFriendSpeed > 4)
{
    Console.WriteLine("Человек не может ходить с такой скоростью");
}
else 
{
    if(secondFriendSpeed > 4)
    {
        Console.WriteLine("Человек не может ходить с такой скоростью");
    }
    else
    {
    //double secondFriendSpeed = 2;
        double dogSpeed = 5;
        int friend = 2;
        double time = 0;
    
        while(distans > 10)
        {
            if (friend == 1)
            {
                time = distans / (firstFriendSpeed + dogSpeed);
                friend = 2;
            }

            else
            {
               time = distans / (secondFriendSpeed + dogSpeed);
               friend = 1;
            }

           distans = distans - (firstFriendSpeed + secondFriendSpeed) * time;
           count = count + 1;
        }

    Console.Write("Собака пробежала  ");
    Console.Write(count);
    Console.WriteLine(" раз (а)");
    }
}
