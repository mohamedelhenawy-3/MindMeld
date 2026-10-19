using ValueTuples;

class Program
{
    static void Main()
    {

        Tuple<string, double> t1 = new Tuple<string, double>("hosi",23.23);
        ValueTuple<string,double>t2=new ValueTuple<string, double>("hosi", 23.23);

        Console.WriteLine($"{t1} : {t2}");



        var t3 = CalcFacility.CalcFaciliriesDistance("hostibat");
        Console.WriteLine(t3);

        var t4 = CalcFacility.CalcFaciliriesDistancev2("hostibat");
        Console.WriteLine(t4);
        var t5 = CalcFacility.CalcFaciliriesDistancev3("hostibat");
        Console.WriteLine(t5.distanceinkm);


        (string nm, string km) = t5;
        Console.WriteLine($"{nm} : {km}");



    }
}