﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Abstractions.Entities
{
    public class Client : Entity, AliveEntity
    {
        public string RealName { get; set; }
        public string Username { get; set; }
        public Gender Gender { get; set; }
        public Guid? CoachId { get; init; }
    }

   
}
