using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Worker : BackgroundService
    {
        private readonly ExampleDbContext _context;

        public Worker(ExampleDbContext context)
        {
            _context = context;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Grab all example records and iterate through them
            List<ExampleTable> records = _context.ExampleTables.ToList();

            foreach (var record in records)
            {
                Console.WriteLine($"Record ID {record.Id}: {record.Name}");
            }

            Console.ReadKey();

            return;
        }
    }
}
