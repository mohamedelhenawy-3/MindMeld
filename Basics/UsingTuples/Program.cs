

using UsingTuples;

class Program
{
    static void Main()
    {
        var Facilityinfo = FacilitesDistanceCalculator.CalcFaciliriesDistance("Hospital");

        Console.WriteLine(Facilityinfo);

        Console.WriteLine("Tuple with Access with Acess Item");

        var v3 = FacilitesDistanceCalculator.CalcFaciliriesDistancev3("Hospital");

        Console.WriteLine($"{v3.Item1}  and the distance will be {v3.Item2}");



        Console.WriteLine(Equals(Facilityinfo, v3));

    }
}