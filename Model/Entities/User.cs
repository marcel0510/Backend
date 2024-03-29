﻿using Model.Enum;

namespace Model.Entities
{
    public class User: BaseEntity
    {
        public string Email { get; set; }

        private string _password;
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                _password = BCrypt.Net.BCrypt.HashPassword(value);
            }
         } 
        public string Name { get; set; }
        public Role Role { get; set; }
        public bool Reset { get; set; }
    }
}
