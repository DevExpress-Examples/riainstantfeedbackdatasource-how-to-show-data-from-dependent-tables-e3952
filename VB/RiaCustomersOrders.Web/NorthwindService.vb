Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Data
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.EntityFramework
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace RiaCustomersOrders.Web


	' Implements application logic using the NorthwindEntities context.
	' TODO: Add your application logic to these methods or in additional methods.
	' TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
	' Also consider adding roles to restrict access as appropriate.
	' [RequiresAuthentication]
	<EnableClientAccess()> _
	Public Class NorthwindService
		Inherits DomainService
		Private entities As NorthwindEntities

		Protected Overrides Function Count(Of T)(ByVal query As IQueryable(Of T)) As Integer
			Return query.Count()
		End Function

		Public Sub New()
			entities = New NorthwindEntities()
		End Sub

		<Query(IsComposable := True)> _
		Public Function GetCustomerOrders() As IQueryable(Of CustomerOrders)
			Return entities.Orders.Join(entities.Customers, Function(order) order.CustomerID, Function(customer) customer.CustomerID, Function(order, customer) New CustomerOrders With {.OrderID = order.OrderID, .CompanyName = customer.CompanyName, .ContactName = customer.ContactName, .OrderDate = order.OrderDate})
		End Function
		Public Function GetCustomerOrdersExtendedData(ByVal extendedDataInfo As String) As String
			Return DevExpress.Xpf.Core.ServerMode.ExtendedDataHelper.GetExtendedData(GetCustomerOrders(), extendedDataInfo)
		End Function
	End Class

	Public Class CustomerOrders
		Private privateOrderID As Integer
		<Key> _
		Public Property OrderID() As Integer
			Get
				Return privateOrderID
			End Get
			Set(ByVal value As Integer)
				privateOrderID = value
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
		Private privateOrderDate? As DateTime
		Public Property OrderDate() As DateTime?
			Get
				Return privateOrderDate
			End Get
			Set(ByVal value? As DateTime)
				privateOrderDate = value
			End Set
		End Property
	End Class
End Namespace


