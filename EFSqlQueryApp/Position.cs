﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSqlQueryApp
{
    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public List<Employee> Employees { get; set; } = new();
    }
}