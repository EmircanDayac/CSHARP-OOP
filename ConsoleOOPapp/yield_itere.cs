using System.Collections;
using System.Collections.Generic;

namespace ConsoleOOPapp
{
  class itere
  {
    public IEnumerable metot1(int[] dizi)
    {
      for (int i = 0; i < dizi.Length; i++)
      {
        if (dizi[i]>0)
        {
          yield return dizi[i];
        }
      }

      yield return null;
    }
  }
}