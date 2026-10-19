using enumerations;

class Program
{
    static void Main()
    {
        var today = Season.Autumn;
        Console.WriteLine(DescribeSeason(today));

        Console.WriteLine((int)Season.Spring);









    }
    static string DescribeSeason(Season season) => season switch
    {
        Season.Spring => "Flowers bloom and temperatures rise.",
        Season.Summer => "Long days and warm weather.",
        Season.Autumn => "Leaves change color and fall.",
        Season.Winter => "Short days and cold temperatures.",
        _ => throw new ArgumentOutOfRangeException(nameof(season))

    };

}