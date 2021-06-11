using System;

class Classe {
    static void Main() {
      decimal v1,v2;
        string[] line = Console.ReadLine().Split(" ");
        v1 = decimal.Parse(line[0]);
        v2 = decimal.Parse(line[1]);
        
        decimal total = v1/v2;
        Console.WriteLine(total.ToString("N2"));
    }
}