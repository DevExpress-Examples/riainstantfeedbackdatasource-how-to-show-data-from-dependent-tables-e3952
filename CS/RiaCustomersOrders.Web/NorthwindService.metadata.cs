
namespace RiaCustomersOrders.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies CustomersMetadata as the class
    // that carries additional metadata for the Customers class.
    [MetadataTypeAttribute(typeof(Customers.CustomersMetadata))]
    public partial class Customers {

        // This class allows you to attach custom attributes to properties
        // of the Customers class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CustomersMetadata {

            // Metadata classes are not meant to be instantiated.
            private CustomersMetadata() {
            }

            public string Address { get; set; }

            public string City { get; set; }

            public string CompanyName { get; set; }

            public string ContactName { get; set; }

            public string ContactTitle { get; set; }

            public string Country { get; set; }

            public string CustomerID { get; set; }

            public string Fax { get; set; }

            public EntityCollection<Orders> Orders { get; set; }

            public string Phone { get; set; }

            public string PostalCode { get; set; }

            public string Region { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies OrdersMetadata as the class
    // that carries additional metadata for the Orders class.
    [MetadataTypeAttribute(typeof(Orders.OrdersMetadata))]
    public partial class Orders {

        // This class allows you to attach custom attributes to properties
        // of the Orders class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class OrdersMetadata {

            // Metadata classes are not meant to be instantiated.
            private OrdersMetadata() {
            }

            public string CustomerID { get; set; }

            public Customers Customers { get; set; }

            public Nullable<int> EmployeeID { get; set; }

            public Nullable<decimal> Freight { get; set; }

            public Nullable<DateTime> OrderDate { get; set; }

            public int OrderID { get; set; }

            public Nullable<DateTime> RequiredDate { get; set; }

            public string ShipAddress { get; set; }

            public string ShipCity { get; set; }

            public string ShipCountry { get; set; }

            public string ShipName { get; set; }

            public Nullable<DateTime> ShippedDate { get; set; }

            public string ShipPostalCode { get; set; }

            public string ShipRegion { get; set; }

            public Nullable<int> ShipVia { get; set; }
        }
    }
}
