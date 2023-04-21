using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class MyEventArgs: EventArgs
    {
        public string Id { get; set ; }

        public MyEventArgs(string id)
        {
            this.Id = id ;
        }

    }
}
