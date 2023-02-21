﻿namespace API.DTOs.Users
{
    public class GetUserResponse
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Role { get; set; }
    }
}
