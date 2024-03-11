﻿using System.ComponentModel.DataAnnotations;

namespace TicketsSite.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string PictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
