﻿using SalesManagement.Data;
using SalesManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagement.Services
{
    public class SellerService
    {
        private readonly SalesManagementContext _context;

        public SellerService(SalesManagementContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
           _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
