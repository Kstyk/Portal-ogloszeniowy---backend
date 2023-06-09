﻿namespace ZleceniaAPI.Entities
{
    public class UsersCategories
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public bool IsMainCategory { get; set; }
    }
}
