Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Data.Objects.DataClasses
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace RiaCustomersOrders.Web


	' The MetadataTypeAttribute identifies CustomersMetadata as the class
	' that carries additional metadata for the Customers class.
	<MetadataTypeAttribute(GetType(Customers.CustomersMetadata))> _
	Partial Public Class Customers

		' This class allows you to attach custom attributes to properties
		' of the Customers class.
		'
		' For example, the following marks the Xyz property as a
		' required property and specifies the format for valid values:
		'    [Required]
		'    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		'    [StringLength(32)]
		'    public string Xyz { get; set; }
		Friend NotInheritable Class CustomersMetadata

			' Metadata classes are not meant to be instantiated.
			Private Sub New()
			End Sub

			Private privateAddress As String
			Public Property Address() As String
				Get
					Return privateAddress
				End Get
				Set(ByVal value As String)
					privateAddress = value
				End Set
			End Property

			Private privateCity As String
			Public Property City() As String
				Get
					Return privateCity
				End Get
				Set(ByVal value As String)
					privateCity = value
				End Set
			End Property

			Private privateCompanyName As String
			Public Property CompanyName() As String
				Get
					Return privateCompanyName
				End Get
				Set(ByVal value As String)
					privateCompanyName = value
				End Set
			End Property

			Private privateContactName As String
			Public Property ContactName() As String
				Get
					Return privateContactName
				End Get
				Set(ByVal value As String)
					privateContactName = value
				End Set
			End Property

			Private privateContactTitle As String
			Public Property ContactTitle() As String
				Get
					Return privateContactTitle
				End Get
				Set(ByVal value As String)
					privateContactTitle = value
				End Set
			End Property

			Private privateCountry As String
			Public Property Country() As String
				Get
					Return privateCountry
				End Get
				Set(ByVal value As String)
					privateCountry = value
				End Set
			End Property

			Private privateCustomerID As String
			Public Property CustomerID() As String
				Get
					Return privateCustomerID
				End Get
				Set(ByVal value As String)
					privateCustomerID = value
				End Set
			End Property

			Private privateFax As String
			Public Property Fax() As String
				Get
					Return privateFax
				End Get
				Set(ByVal value As String)
					privateFax = value
				End Set
			End Property

			Private privateOrders As EntityCollection(Of Orders)
			Public Property Orders() As EntityCollection(Of Orders)
				Get
					Return privateOrders
				End Get
				Set(ByVal value As EntityCollection(Of Orders))
					privateOrders = value
				End Set
			End Property

			Private privatePhone As String
			Public Property Phone() As String
				Get
					Return privatePhone
				End Get
				Set(ByVal value As String)
					privatePhone = value
				End Set
			End Property

			Private privatePostalCode As String
			Public Property PostalCode() As String
				Get
					Return privatePostalCode
				End Get
				Set(ByVal value As String)
					privatePostalCode = value
				End Set
			End Property

			Private privateRegion As String
			Public Property Region() As String
				Get
					Return privateRegion
				End Get
				Set(ByVal value As String)
					privateRegion = value
				End Set
			End Property
		End Class
	End Class

	' The MetadataTypeAttribute identifies OrdersMetadata as the class
	' that carries additional metadata for the Orders class.
	<MetadataTypeAttribute(GetType(Orders.OrdersMetadata))> _
	Partial Public Class Orders

		' This class allows you to attach custom attributes to properties
		' of the Orders class.
		'
		' For example, the following marks the Xyz property as a
		' required property and specifies the format for valid values:
		'    [Required]
		'    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		'    [StringLength(32)]
		'    public string Xyz { get; set; }
		Friend NotInheritable Class OrdersMetadata

			' Metadata classes are not meant to be instantiated.
			Private Sub New()
			End Sub

			Private privateCustomerID As String
			Public Property CustomerID() As String
				Get
					Return privateCustomerID
				End Get
				Set(ByVal value As String)
					privateCustomerID = value
				End Set
			End Property

			Private privateCustomers As Customers
			Public Property Customers() As Customers
				Get
					Return privateCustomers
				End Get
				Set(ByVal value As Customers)
					privateCustomers = value
				End Set
			End Property

			Private privateEmployeeID? As Integer
			Public Property EmployeeID() As Integer?
				Get
					Return privateEmployeeID
				End Get
				Set(ByVal value? As Integer)
					privateEmployeeID = value
				End Set
			End Property

			Private privateFreight? As Decimal
			Public Property Freight() As Decimal?
				Get
					Return privateFreight
				End Get
				Set(ByVal value? As Decimal)
					privateFreight = value
				End Set
			End Property

			Private privateOrderDate? As DateTime
			Public Property OrderDate() As DateTime?
				Get
					Return privateOrderDate
				End Get
				Set(ByVal value? As DateTime)
					privateOrderDate = value
				End Set
			End Property

			Private privateOrderID As Integer
			Public Property OrderID() As Integer
				Get
					Return privateOrderID
				End Get
				Set(ByVal value As Integer)
					privateOrderID = value
				End Set
			End Property

			Private privateRequiredDate? As DateTime
			Public Property RequiredDate() As DateTime?
				Get
					Return privateRequiredDate
				End Get
				Set(ByVal value? As DateTime)
					privateRequiredDate = value
				End Set
			End Property

			Private privateShipAddress As String
			Public Property ShipAddress() As String
				Get
					Return privateShipAddress
				End Get
				Set(ByVal value As String)
					privateShipAddress = value
				End Set
			End Property

			Private privateShipCity As String
			Public Property ShipCity() As String
				Get
					Return privateShipCity
				End Get
				Set(ByVal value As String)
					privateShipCity = value
				End Set
			End Property

			Private privateShipCountry As String
			Public Property ShipCountry() As String
				Get
					Return privateShipCountry
				End Get
				Set(ByVal value As String)
					privateShipCountry = value
				End Set
			End Property

			Private privateShipName As String
			Public Property ShipName() As String
				Get
					Return privateShipName
				End Get
				Set(ByVal value As String)
					privateShipName = value
				End Set
			End Property

			Private privateShippedDate? As DateTime
			Public Property ShippedDate() As DateTime?
				Get
					Return privateShippedDate
				End Get
				Set(ByVal value? As DateTime)
					privateShippedDate = value
				End Set
			End Property

			Private privateShipPostalCode As String
			Public Property ShipPostalCode() As String
				Get
					Return privateShipPostalCode
				End Get
				Set(ByVal value As String)
					privateShipPostalCode = value
				End Set
			End Property

			Private privateShipRegion As String
			Public Property ShipRegion() As String
				Get
					Return privateShipRegion
				End Get
				Set(ByVal value As String)
					privateShipRegion = value
				End Set
			End Property

			Private privateShipVia? As Integer
			Public Property ShipVia() As Integer?
				Get
					Return privateShipVia
				End Get
				Set(ByVal value? As Integer)
					privateShipVia = value
				End Set
			End Property
		End Class
	End Class
End Namespace
