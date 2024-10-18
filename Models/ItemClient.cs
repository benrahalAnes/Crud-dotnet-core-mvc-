using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class ItemClient
    {
        public int ItemId { get; set; }
        public Item? Item { get; set; }
        public int ClientId { get; set; }
        public Client? client{ get; set; } 
    }
}