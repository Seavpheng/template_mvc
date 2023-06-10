using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace template.Models
{
    [Table("item")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemCode { get; set; }


        //public int ItemGroupId { get; set; }

        [ForeignKey("ItemGroupId")]
        public virtual ItemGroup ItemGroup { get; set; }

       
       
    }

    [Table("item_group")]
    public class ItemGroup {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }   
        public ICollection<Item> Items { get; set; }
    }
}