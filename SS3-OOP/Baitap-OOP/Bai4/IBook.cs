using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal interface IBook
    {
        string Name { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        int PublishYear { get; set; }
        string ISBN { get; set; }

    }
}
