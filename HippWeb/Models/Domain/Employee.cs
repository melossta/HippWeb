﻿namespace HippWeb.Models.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Manager Supervisor { get; set; }
    }
}
