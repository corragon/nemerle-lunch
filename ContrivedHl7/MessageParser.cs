using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContrivedHl7
{
   public class MessageParser
   {
      public static string Parse(string name, int index, int field)
      {
         return string.Format("I did stuff with...\nname: {0}\nindex: {1}\nfield: {2}", name, index, field);
      }
   }
}
