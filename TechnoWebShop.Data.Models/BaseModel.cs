using System;
using System.ComponentModel.DataAnnotations;

namespace TechnoWebShop.Data.Models
{
    public class BaseModel<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
