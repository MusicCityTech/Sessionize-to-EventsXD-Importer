using System.Collections.Generic;

namespace SessionizeWrapper.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IList<Item> Items { get; set; }
        public int Sort { get; set; }
    }
}
