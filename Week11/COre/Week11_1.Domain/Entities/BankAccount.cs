﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week11_1.Domain.Common;

namespace Week11_1.Domain.Entities
{
    public class BankAccount:EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneName { get; set; }
        public decimal Balance{ get; set; }


    }
}
