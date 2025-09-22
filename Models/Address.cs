using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace ConsoleApp1.Models
{
    [Owned]
    internal class Address
    {
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Street { get; set; }

    }
}
