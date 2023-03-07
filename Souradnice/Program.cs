using Souradnice;
Bod c1 = new Bod(10, 10);
Bod c2 = new Bod(10, 10);
  
//if (c1.X.Equals(c2.X)) Console.WriteLine("ne");
//else if (!c1.X.Equals(c2.X)) Console.WriteLine("ne");
Console.WriteLine( Bod.Equals(c1, c2)); // Equals
Console.WriteLine(Bod.KdoJeDál(c1,c2)); // porovná kdo je dál
Console.WriteLine(Bod.Equals(c1.Násobení(4), c2.Násobení(4))); 

