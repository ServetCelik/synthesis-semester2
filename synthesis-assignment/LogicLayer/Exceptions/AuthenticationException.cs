﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException() : base("Failed to authenticate.")
        {
        }
    }
}
