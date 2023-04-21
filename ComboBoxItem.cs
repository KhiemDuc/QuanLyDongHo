using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class ComboBoxItem
    {
        public string Value { get; set; }
        public string ID { get; set; }

        public override string ToString()
        {
            return Value;
        }

    }
}
