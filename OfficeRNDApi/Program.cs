using System;

namespace OfficeRndApi {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
      var token = OfficeRndApiHandler.GetToken(
          "o2cBTqaINCOWVBCd", "89c7n4zyKuegDE0wA2J40oDgcXmVUQvH");
      Console.WriteLine(token.access_token);
    }
  }
}
