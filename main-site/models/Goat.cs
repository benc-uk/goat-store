using System;
using System.ComponentModel.DataAnnotations;

namespace GoatStore.Models
{
    public class Goat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}