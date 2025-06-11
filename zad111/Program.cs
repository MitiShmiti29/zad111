for (int i = 1; i <= 13; i++)
{
    Random random = new Random();
    int ocenka = random.Next(2 , 7);
    int ocenka2 = random.Next(2, 7);
    int ocenka3 = random.Next(2, 7);
    int ocenka4 = random.Next(2, 7);
    int srednaOcenka = (ocenka + ocenka2 + ocenka3 + ocenka4) / 4;
    if (srednaOcenka <=2.99)
        Console.WriteLine(i + " - оценка - " + ocenka + "," + ocenka2 + "," + ocenka3 + "," + ocenka4 + ":" + srednaOcenka + " слаб 2");
    else if (srednaOcenka <=3.49)
        Console.WriteLine(i + " - оценка - " + ocenka + "," + ocenka2 + "," + ocenka3 + "," + ocenka4 + ":" + srednaOcenka + " среден 3");
    else if (srednaOcenka <= 4.49)
        Console.WriteLine(i + " - оценка - " + ocenka + "," + ocenka2 + "," + ocenka3 + "," + ocenka4 + ":" + srednaOcenka + " добър 4");
    else if (srednaOcenka <= 5.49)
        Console.WriteLine(i + " - оценка - " + ocenka + "," + ocenka2 + "," + ocenka3 + "," + ocenka4 + ":" + srednaOcenka + " много добър 5");
    else if (srednaOcenka <= 6)
        Console.WriteLine(i + " - оценка - " + ocenka + "," + ocenka2 + "," + ocenka3 + "," + ocenka4 + ":" + srednaOcenka + " отличен 6");
}