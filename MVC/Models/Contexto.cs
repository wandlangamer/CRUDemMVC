﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

    }
}