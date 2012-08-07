using System;

namespace CSharp
{
   class Program
   {
      static void Main(string[] args)
      {
         var block = new Cube(4.0f, 5.0f, 6.0f, 1.4f);
         Console.WriteLine(block.GetVolumeIn(Cube.CubicUnit.Meter));
         Console.Read();
      }
   }
}
