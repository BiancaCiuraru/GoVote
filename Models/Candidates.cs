﻿using System;

namespace VotingService.Models
{
    public class Candidates
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PartyID { get; set; }
    }
}