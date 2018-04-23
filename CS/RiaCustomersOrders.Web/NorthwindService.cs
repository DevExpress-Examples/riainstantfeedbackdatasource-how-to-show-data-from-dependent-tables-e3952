
namespace RiaCustomersOrders.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the NorthwindEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class NorthwindService : DomainService {
        NorthwindEntities entities;

        protected override int Count<T>(IQueryable<T> query) {
            return query.Count();
        }

        public NorthwindService() {
            entities = new NorthwindEntities();
        }

        [Query(IsComposable = true)]
        public IQueryable<CustomerOrders> GetCustomerOrders() {
            return entities.Orders.Join(entities.Customers,
                order => order.CustomerID,
                customer => customer.CustomerID,
                (order, customer) => new CustomerOrders {
                    OrderID = order.OrderID,
                    CompanyName = customer.CompanyName, ContactName = customer.ContactName, OrderDate = order.OrderDate
                });
        }
        public string GetCustomerOrdersExtendedData(string extendedDataInfo) {
            return DevExpress.Xpf.Core.ServerMode.ExtendedDataHelper.GetExtendedData(GetCustomerOrders(), extendedDataInfo);
        }
    }

    public class CustomerOrders {
        [Key]
        public int OrderID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}


