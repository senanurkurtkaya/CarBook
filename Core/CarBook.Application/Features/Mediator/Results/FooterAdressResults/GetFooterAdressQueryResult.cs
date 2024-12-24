﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.FooterAdressResults
{
    public class GetFooterAdressQueryResult 
    {
        public int FooterAddressID { get; set; }
        public string Description { get; set; }

        public String Address { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
