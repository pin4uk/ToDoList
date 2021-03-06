﻿namespace Epam.Wunderlist.Services.Interface.Entities
{
    public class UserEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public int PhotoId { get; set; }
    }
}
