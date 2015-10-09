using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcZooStore.Models
{
    public class Kind
    {
        public int KindID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Pet> Pets { get; set; }
    }
}