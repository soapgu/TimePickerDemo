using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMetro
{
    public class MyViewModel
    {
        public static readonly IEnumerable<int> AMHours = new List<int> { 9, 10, 11 };

        public static readonly IEnumerable<int> PMHours = new List<int> { 12, 13, 14, 15, 16, 17 };

        public DateTime? AMTimePickerDate
        {
            get;
            set;
        }

        public DateTime? PMTimePickerDate
        {
            get;
            set;
        }
    }
}
