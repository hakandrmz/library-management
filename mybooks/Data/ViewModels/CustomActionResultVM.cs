﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mybooks.Data.Models;

namespace mybooks.Data.ViewModels
{
    public class CustomActionResultVM
    {
        public Exception Exception { get; set; }
        public Publisher Publisher { get; set; }
    }
}
