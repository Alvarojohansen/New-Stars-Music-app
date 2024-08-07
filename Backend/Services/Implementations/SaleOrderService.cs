﻿using Merchanmusic.Data;
using Merchanmusic.Data.Entities;
using Merchanmusic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Merchanmusic.Services.Implementations
{
   
        public class SaleOrderService : ISaleOrderService
        {
        private readonly MerchContext _context;

            public SaleOrderService(MerchContext context)
            {
                _context = context;
            }

            public List<SaleOrder> GetAllByClient(string clientId) //todas por cliente
            {
                return _context.SaleOrders
                    .Include(so => so.Client)
                    .Include(so => so.SaleOrderLines)
                    .ThenInclude(so => so.Product)
                    .Where(r => r.ClientId == clientId)
                    .ToList();
            }

            public SaleOrder? GetOne(int Id)
            {
                return _context.SaleOrders
                    .Include(r => r.SaleOrderLines)
                    .ThenInclude(so => so.Product)
                    .SingleOrDefault(x => x.Id == Id);
            }

            public List<SaleOrder> GetAllByDate(DateTime date)
            {
                return _context.SaleOrders
                    .Include(r => r.Client)
                    .Include(r => r.SaleOrderLines)
                    .ThenInclude(so => so.Product)
                    .Where(r => r.Date.Date == date.Date)
                    .ToList();
            }

            public SaleOrder CreateSaleOrder(SaleOrder saleOrder)
            {
                _context.Add(saleOrder);
                _context.SaveChanges();
                return saleOrder;
            }

            public SaleOrder UpdateSaleOrder(SaleOrder saleOrder)
            {
                _context.Update(saleOrder);
                _context.SaveChanges();
                return saleOrder;
            }

            public void DeleteSaleOrder(int id)
            {
                var saleOrderToDelete = _context.SaleOrders.SingleOrDefault(p => p.Id == id);

                if (saleOrderToDelete != null)
                {
                    _context.SaleOrders.Remove(saleOrderToDelete);
                    _context.SaveChanges();
                }

            }
        public List<SaleOrder> GetAllSaleOrders() 
        {
            return _context.SaleOrders
                .Include(so => so.Client)
                .Include(so => so.SaleOrderLines)
                .ThenInclude(so => so.Product)
                .ToList();
        }
    }
}

