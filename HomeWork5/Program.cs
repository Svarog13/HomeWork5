using System;

Console.WriteLine("Enter the date in format dd.mm.yyyy.");
string dateInput = Console.ReadLine();
if (DateTime.TryParseExact(dateInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
{
  
    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

    string dayOfWeek = date.ToString("dddd", culture);

    int month = date.Month;
    string season = "";
    switch (month)
    {
        case 12:
        case 1:
        case 2:
            season = "Winter";
            break;
        case 3:
        case 4:
        case 5:
            season = "Spring";
            break;
        case 6:
        case 7:
        case 8:
            season = "Summer";
            break;
        case 9:
        case 10:
        case 11:
            season = "Autumn";
            break;
    }
    Console.WriteLine($"Day of week: {dayOfWeek}");
    Console.WriteLine($"Season of year: {season}");
}
else
{
    Console.WriteLine("Entered incorrect format of date.");
}