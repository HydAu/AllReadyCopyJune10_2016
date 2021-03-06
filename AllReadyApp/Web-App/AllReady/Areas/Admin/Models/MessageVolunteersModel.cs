﻿using System.ComponentModel.DataAnnotations;

namespace AllReady.Areas.Admin.Models
{
    public class MessageEventVolunteersModel
    {
        public int EventId { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
