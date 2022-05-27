using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Seller> Sellers { get; set; } = new List<Seller>(); //lista vendedores / ligação com a tabela de vendedores

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }

    //public class aula
    //{


    //    public aula()
    //    {
    //        Department depart = new Department(1, "elias");
    //        //depart.Id = 123;
    //        //salvar no banco
    //        depart.Sellers = new List<Seller>()
    //        {
    //        new Seller(), new Seller(), new Seller()
    //        };



    //    }

    //}
}
