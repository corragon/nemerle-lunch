using System;
using NemerleWorld;

namespace CSharpWorld
{
   public class BestOfBothWorlds
   {
      public static void Part1()
      {
         var coolBike = new BatPod();
         Console.WriteLine(string.Format("I use my cool bike for: {0}", coolBike.UsedFor()));
         Console.WriteLine(string.Format("Suspicious looking volume: {0}", coolBike.VolumeM3()));
      }
   }

   class BatPod : IPod
   {
      public string UsedFor()
      {
         return "Sweet jumps and looking cool while driving through explosions";
      }

      public double VolumeM3()
      {
         return 3.1415926535897932384626433838795028841971;
      }
   }
}
