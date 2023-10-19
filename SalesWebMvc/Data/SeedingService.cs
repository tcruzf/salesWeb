using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;
namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }
                Department d1 = new Department(1, "Computer");
                Department d2 = new Department(2, "Eletronics");
                Department d3 = new Department(3, "Fashion");
                Department d4 = new Department(4, "Books");

                Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1995, 3, 30), 1000.0, d1);
                Seller s2 = new Seller(2, "Ana Beatriz", "ana@gmail.com", new DateTime(2000, 11, 11), 1200.0, d2);
                Seller s3 = new Seller(3, "Carlos Henrique", "c.henrique1994@gmail.com", new DateTime(1994, 2, 5), 1200.0, d3);
                Seller s4 = new Seller(4, "Alex Cooper", "alex2002@gmail.com", new DateTime(2002, 1, 28), 1200.0, d4);

                SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 09, 25), 1100.0, SaleStatus.Billed, s1);
                SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 12, 29), 11100.0, SaleStatus.Pending, s2);
                SalesRecord sr3 = new SalesRecord(3, new DateTime(2019, 09, 23), 1100.0, SaleStatus.Pending, s3);
                SalesRecord sr4 = new SalesRecord(4, new DateTime(2023, 05, 25), 2000.0, SaleStatus.Canceled, s4);
                _context.Department.AddRange(d1, d2, d3, d4);
                _context.Seller.AddRange(s1, s2, s3, s4);
                _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4);
                _context.SaveChanges();
            
        }
    }
}
