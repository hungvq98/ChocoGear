﻿using ChocoGear.Models.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChocoGear.Models.Dao
{
    public sealed class OrderDao : IRepository<ModelView.OrderView>
    {
        Models.Entity.ChocoGearEntities database = new Entity.ChocoGearEntities();
        private static OrderDao instance = null;
        private OrderDao()
        {

        }
        public static OrderDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDao();
                }
                return instance;
            }
        }

        public int Create(OrderView item)
        {
            Models.Entity.Order order = new Entity.Order() { id = item.id,email_order = item.email_order, address_order = item.address_order, phone_order = item.phone_order, id_customer = item.id_customer, order_date = item.order_date, total = item.total, status = item.status };
            database.Orders.Add(order);
            database.SaveChanges();
            return order.id;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderView GetId(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderView> Gets()
        {
            throw new NotImplementedException();
        }

        public int Update(OrderView item)
        {
            throw new NotImplementedException();
        }
    }
}