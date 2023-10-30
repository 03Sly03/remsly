﻿using System.ComponentModel.DataAnnotations;

namespace RemSlyApi.DTOs
{
    public class LoginRequestDTO
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
