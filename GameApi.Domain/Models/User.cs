﻿namespace GameApi.Domain.Models
{
    public class User : Entidade
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
