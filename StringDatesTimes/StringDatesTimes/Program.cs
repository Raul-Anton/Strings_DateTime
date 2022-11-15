// 1. Create new modified strings

using StringDatesTimes;
using System.Globalization;

string firstString = "This is the first string";

string secondString = "This is the second string";

string anotherString = "This is another string";

Console.WriteLine(firstString + '\n' + secondString + '\n' + anotherString);


// 2. Create a program using Split/Join methods

string[] stringArr = new[] { "one", "two", "three", "four" };

static void JoinArrayElements(string[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}

static void SplitArrayElements(string[] arr)
{
    string joinedString = string.Join(",", arr);
    foreach (string s in joinedString.Split(','))
    {
        Console.Write(s + ' ');
    }
}

Console.WriteLine();
JoinArrayElements(stringArr);
SplitArrayElements(stringArr);


// 3. Use timespan

TimeSpan timespan1 = new TimeSpan(3,50,0);

TimeSpan timespan2 = new TimeSpan(0, 10, 0);

TimeSpan timespan3 = new TimeSpan(1, 0, 25);

TimeSpan[] timeSpanArr = new[] { timespan1,timespan2,timespan3};

static TimeSpan TotalTime(TimeSpan[] timeSpanArr)
{
    TimeSpan totalTime = new TimeSpan(0);

    foreach(TimeSpan t in timeSpanArr)
    {
        totalTime = totalTime.Add(t);
    }
    return totalTime;
}

Console.WriteLine();
Console.WriteLine(TotalTime(timeSpanArr));


// 4. Use datetime

static void ShowDateTime()
{
    Console.WriteLine("The date and time are + {0} ", DateTime.Now);
}

Console.WriteLine();
ShowDateTime();


// 5. Use datetimeOffset

static void ShowDateTimeOffset(DateTime time)
{
    DateTimeOffset timeOffset = time;
    Console.WriteLine("The offset is {0}", timeOffset.Offset);
}

Console.WriteLine();
ShowDateTimeOffset(DateTime.Now);


// 6. Use timezone

static void DayLightSavings(TimeZoneInfo timeZoneInfo)
{
    if (timeZoneInfo.SupportsDaylightSavingTime)
        Console.WriteLine("This timezone does have special rules for daylight saving");
    else
        Console.WriteLine("This timezone doesn't have any special rules for daylight saving");
}

Console.WriteLine();
TimeZoneInfo timeZoneInfo = TimeZoneInfo.Utc;
DayLightSavings(timeZoneInfo);

// 7. Use cultureinfo

CultureInfo myCulture = new CultureInfo("ro-RO", false);

Console.WriteLine();
Console.WriteLine(myCulture.Name);

foreach (var dayName in myCulture.DateTimeFormat.DayNames)
{
    Console.WriteLine(dayName);
}


// Optoonal assignment
Console.WriteLine();
string input = "<app></app></app><app><app>”";

Console.WriteLine("The number of incorrect tags are {0}",OptionalAssignment.Interpret(input));