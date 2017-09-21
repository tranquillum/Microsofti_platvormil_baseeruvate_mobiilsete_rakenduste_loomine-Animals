using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    interface IWalker
    {
        void Walk();
        void Walk(int meters);
        int LastWalkingDistance { get; set; }
        string GetWalkingPlaceName();
    }
}
