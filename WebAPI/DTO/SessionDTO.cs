﻿using Model.Enum;

namespace WebAPI.DTO
{
    public class SessionDTO
    {
        public Day Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}