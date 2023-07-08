using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_Cap3
{
    internal class Calcola : IComparer<int>
    {
         public int Compare(int x, int y)
    {
        return x.ToString().Length.CompareTo(y.ToString().Length);
    }
    }
}