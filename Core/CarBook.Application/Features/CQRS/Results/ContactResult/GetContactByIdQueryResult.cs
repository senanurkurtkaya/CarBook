﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.ContactResult
{
    public class GetContactByIdQueryResult
    {
        public int ContactID { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
