﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieApplication.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategory { get; }
    }
}
