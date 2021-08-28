using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemo.Data
{
    public class Viedo
    {
        public int ViedoID { get; set; }

        public string Title { get; set; }

        public DateTime DatePublished { get; set; }

        public bool IsActive { get; set; }
    }

}
