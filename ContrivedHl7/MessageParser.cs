using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContrivedHl7
{
   public class MessageParser
   {
      public static string Parse(string name, int index, int field, int repetition, int component, int subcomp)
      {
         return string.Format("Do something with...\n" +
                              "name: {0}\n" +
                              "index: {1}\n" +
                              "field: {2}\n" +
                              "repeat: {3}\n" +
                              "component: {4}\n" +
                              "subcomp: {5}", name, index, field, repetition, component, subcomp);
      }
   }
}
