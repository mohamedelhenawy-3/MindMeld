

using DeisgnStruct;

class Program
{
    static void Main()
    {
        const int N = 1_000_000;
        Console.WriteLine($"beofr=");

        long before = GC.GetAllocatedBytesForCurrentThread();
        var classArray = new LocationClass[N];
        for (int i = 0; i < N; i++)
            classArray[i] = new LocationClass("Hospital", i);   

        long classBytes = GC.GetAllocatedBytesForCurrentThread() - before;

        before = GC.GetAllocatedBytesForCurrentThread();

        var structArray = new LocationStruct[N];
        for (int i = 0; i < N; i++)
            structArray[i] = new LocationStruct("Hospital", i); // stored directly in the array

        long structBytes = GC.GetAllocatedBytesForCurrentThread() - before;

        Console.WriteLine($"class  : {classBytes / 1024 / 1024} MB, {N:N0} separate objects on the heap");
        Console.WriteLine($"struct : {structBytes / 1024 / 1024} MB, 1 single block");



        //void ShipOrder(Guid orderId, Guid userId) { Console.WriteLine($"Shipping order {orderId}"); }

        //var userId = Guid.NewGuid();
        //var orderId = Guid.NewGuid();

        //ShipOrder(userId, orderId);

        // correct
        // ShipOrder(userId, orderId);


        Point pt = new Point { x = 10 };

        Console.WriteLine($"Initial Value: {pt.x}\n");

        // 1. Testing Pass-By-Value Method
        // This passes a copy of 'X', so the original struct remains unchanged.
        pt.TryChangeByValue(pt.x);
        Console.WriteLine($"After TryChangeByValue: {pt.x} (Unchanged)");

        // 2. Testing Pass-By-Reference Method (ref)
        // This passes a reference to 'pt.X', so it modifies the real value directly.
        pt.ChangeByRef(ref pt.x);
        Console.WriteLine($"After ChangeByRef: {pt.x} (Changed!)");
        pt.ByOut(out pt);
        Console.WriteLine($"--- 4. By Out (After assignment): {pt.x} (Assigned inside method) ---");


    }
}