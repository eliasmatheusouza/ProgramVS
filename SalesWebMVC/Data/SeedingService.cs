using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1,"Computers");
            Department d2 = new Department(2, "Electronis");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1,"Bob Brown","bob@gmail.com", new DateTime(1998,4,21),1000.0,d1);
            Seller s2 = new Seller(2, "Luiz", "luiz@gmail.com", new DateTime(1998, 4, 21), 2000.0, d2);
            Seller s3 = new Seller(3, "Elias", "elias@gmail.com", new DateTime(1999, 4, 21), 3000.0, d3);
            Seller s4 = new Seller(4, "Matheus", "matheus@gmail.com", new DateTime(2000, 4, 21), 4000.0, d4);
            Seller s5 = new Seller(5, "Jose", "jose@gmail.com", new DateTime(2001, 4, 21), 5000.0, d2);
            Seller s6 = new Seller(6, "Maria", "maria@gmail.com", new DateTime(2002, 4, 21), 6000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2012, 4, 21), 11000.0, SaleStatus.Canceled, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2011, 4, 21), 12000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2010, 4, 21), 13000.0, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2009, 4, 21), 14000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2008, 4, 21), 15000.0, SaleStatus.Canceled, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2007, 4, 21), 16000.0, SaleStatus.Pending, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2006, 4, 21), 17000.0, SaleStatus.Pending, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2005, 4, 21), 18000.0, SaleStatus.Canceled, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2004, 4, 21), 19000.0, SaleStatus.Billed, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2003, 4, 21), 21000.0, SaleStatus.Canceled, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);

            _context.SaveChanges();

        }
    }
}
