using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Basic
{
   public class Cube
   {
      public static void WhatIsACube()
      {
         Console.WriteLine("A really ugly car (in C#!)");
      }

      private float density;

      public Cube(float height, float width, float depth, float mass)
      {
         Height = height;
         Width = width;
         Depth = depth;
         Mass = mass;
         density = mass / Volume;
      }

      public float Width { get; set; }
      public float Height { get; set; }
      public float Depth { get; set; }
      public float Mass { get; set; }

      public float Volume
      {
         get { return Height * Width * Depth; }
      }

      public enum CubicUnit
      {
         Meter,
         Centemeter,
         Millimeter
      }

      public float GetVolumeIn(CubicUnit units)
      {
         float temp = Height * Width * Depth;
         // some calculation
         return temp;
      }

   }
}
