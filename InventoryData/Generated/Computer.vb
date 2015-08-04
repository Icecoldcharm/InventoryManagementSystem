
'===============================================================================
'                   EntitySpaces 2010 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2010.1.1122.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/16/2011 10:57:34 AM
'===============================================================================

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports System.Linq
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery



Namespace BusinessObjects

	' <summary>
	' Encapsulates the 'Computer' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("Computer")> _ 
	<Table(Name:="Computer")> _ 
	Partial Public Class Computer 
		Inherits esComputer
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Computer()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Guid)
			Dim obj As New Computer()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Computer()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		

		#Region "LINQtoSQL overrides (shame but we must do this)"

		<Column(IsPrimaryKey: = true, CanBeNull: = false)> _
		Public Overrides Property Id As Nullable(Of System.Guid)
			Get
				Return MyBase.Id
			End Get
			Set
				MyBase.Id = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.Quantity
			End Get
			Set
				MyBase.Quantity = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property ComputerName As System.String
			Get
				Return MyBase.ComputerName
			End Get
			Set
				MyBase.ComputerName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Processor As System.String
			Get
				Return MyBase.Processor
			End Get
			Set
				MyBase.Processor = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property MACAddressOne As System.String
			Get
				Return MyBase.MACAddressOne
			End Get
			Set
				MyBase.MACAddressOne = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property MACAddressTwo As System.String
			Get
				Return MyBase.MACAddressTwo
			End Get
			Set
				MyBase.MACAddressTwo = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property MACAddressWLAN As System.String
			Get
				Return MyBase.MACAddressWLAN
			End Get
			Set
				MyBase.MACAddressWLAN = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property IPAddress As System.String
			Get
				Return MyBase.IPAddress
			End Get
			Set
				MyBase.IPAddress = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Ram As System.String
			Get
				Return MyBase.Ram
			End Get
			Set
				MyBase.Ram = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Os As System.String
			Get
				Return MyBase.Os
			End Get
			Set
				MyBase.Os = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property WinLicense As System.String
			Get
				Return MyBase.WinLicense
			End Get
			Set
				MyBase.WinLicense = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Type As System.String
			Get
				Return MyBase.Type
			End Get
			Set
				MyBase.Type = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property RoomID As Nullable(Of System.Guid)
			Get
				Return MyBase.RoomID
			End Get
			Set
				MyBase.RoomID = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property SerialNo As System.String
			Get
				Return MyBase.SerialNo
			End Get
			Set
				MyBase.SerialNo = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Brand As System.String
			Get
				Return MyBase.Brand
			End Get
			Set
				MyBase.Brand = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Model As System.String
			Get
				Return MyBase.Model
			End Get
			Set
				MyBase.Model = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Description As System.String
			Get
				Return MyBase.Description
			End Get
			Set
				MyBase.Description = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property DatePurchased As Nullable(Of System.DateTime)
			Get
				Return MyBase.DatePurchased
			End Get
			Set
				MyBase.DatePurchased = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Cost As Nullable(Of System.Decimal)
			Get
				Return MyBase.Cost
			End Get
			Set
				MyBase.Cost = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property FundSource As System.String
			Get
				Return MyBase.FundSource
			End Get
			Set
				MyBase.FundSource = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Condition As System.String
			Get
				Return MyBase.Condition
			End Get
			Set
				MyBase.Condition = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Discard As Nullable(Of System.Boolean)
			Get
				Return MyBase.Discard
			End Get
			Set
				MyBase.Discard = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Vendor As System.String
			Get
				Return MyBase.Vendor
			End Get
			Set
				MyBase.Vendor = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Inventoried As Nullable(Of System.Boolean)
			Get
				Return MyBase.Inventoried
			End Get
			Set
				MyBase.Inventoried = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Comments As System.String
			Get
				Return MyBase.Comments
			End Get
			Set
				MyBase.Comments = value
			End Set
		End Property
			
		#End Region
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<XmlType("ComputerCollection")> _
	Partial Public Class ComputerCollection
		Inherits esComputerCollection
		Implements IEnumerable(Of Computer)
	
		Public Function FindByPrimaryKey(ByVal id As System.Guid) As Computer
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "ComputerQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class ComputerQuery 
		Inherits esComputerQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "ComputerQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As ComputerQuery) As String
			Return ComputerQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As ComputerQuery
			Return DirectCast(ComputerQuery.SerializeHelper.FromXml(query, GetType(ComputerQuery)), ComputerQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esComputer
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Guid) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Guid) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Guid) As Boolean
		
			Dim query As New ComputerQuery()
			query.Where(query.Id.Equal(id))
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Guid) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Computer.ID
		' </summary>
		
		Public Overridable Property Id As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(ComputerMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(ComputerMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Id)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Quantity
		' </summary>
		
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ComputerMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ComputerMetadata.ColumnNames.Quantity, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Quantity)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.ComputerName
		' </summary>
		
		Public Overridable Property ComputerName As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.ComputerName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.ComputerName, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.ComputerName)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Processor
		' </summary>
		
		Public Overridable Property Processor As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Processor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Processor, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Processor)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.MACAddressOne
		' </summary>
		
		Public Overridable Property MACAddressOne As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.MACAddressOne)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.MACAddressOne, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.MACAddressOne)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.MACAddressTwo
		' </summary>
		
		Public Overridable Property MACAddressTwo As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.MACAddressTwo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.MACAddressTwo, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.MACAddressTwo)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.MACAddressWLAN
		' </summary>
		
		Public Overridable Property MACAddressWLAN As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.MACAddressWLAN)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.MACAddressWLAN, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.MACAddressWLAN)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.IPAddress
		' </summary>
		
		Public Overridable Property IPAddress As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.IPAddress)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.IPAddress, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.IPAddress)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.RAM
		' </summary>
		
		Public Overridable Property Ram As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Ram)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Ram, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Ram)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.OS
		' </summary>
		
		Public Overridable Property Os As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Os)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Os, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Os)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.WinLicense
		' </summary>
		
		Public Overridable Property WinLicense As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.WinLicense)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.WinLicense, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.WinLicense)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Type
		' </summary>
		
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Type, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Type)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.RoomID
		' </summary>
		
		Public Overridable Property RoomID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(ComputerMetadata.ColumnNames.RoomID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(ComputerMetadata.ColumnNames.RoomID, value) Then
					Me._UpToRoomByRoomID = Nothing
					Me.OnPropertyChanged("UpToRoomByRoomID")
					OnPropertyChanged(ComputerMetadata.PropertyNames.RoomID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.SerialNo
		' </summary>
		
		Public Overridable Property SerialNo As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.SerialNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.SerialNo, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.SerialNo)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Brand
		' </summary>
		
		Public Overridable Property Brand As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Brand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Brand, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Brand)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Model
		' </summary>
		
		Public Overridable Property Model As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Model)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Model, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Model)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Description
		' </summary>
		
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Description, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Description)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.DatePurchased
		' </summary>
		
		Public Overridable Property DatePurchased As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ComputerMetadata.ColumnNames.DatePurchased)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(ComputerMetadata.ColumnNames.DatePurchased, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.DatePurchased)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.cost
		' </summary>
		
		Public Overridable Property Cost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ComputerMetadata.ColumnNames.Cost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(ComputerMetadata.ColumnNames.Cost, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Cost)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.FundSource
		' </summary>
		
		Public Overridable Property FundSource As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.FundSource)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.FundSource, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.FundSource)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Condition
		' </summary>
		
		Public Overridable Property Condition As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Condition)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Condition, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Condition)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Discard
		' </summary>
		
		Public Overridable Property Discard As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ComputerMetadata.ColumnNames.Discard)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ComputerMetadata.ColumnNames.Discard, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Discard)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Vendor
		' </summary>
		
		Public Overridable Property Vendor As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Vendor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Vendor, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Vendor)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Inventoried
		' </summary>
		
		Public Overridable Property Inventoried As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ComputerMetadata.ColumnNames.Inventoried)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(ComputerMetadata.ColumnNames.Inventoried, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Inventoried)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Computer.Comments
		' </summary>
		
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ComputerMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(ComputerMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(ComputerMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property		
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToRoomByRoomID As Room
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ComputerMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As ComputerQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ComputerQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As ComputerQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As ComputerQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As ComputerQuery

	End Class



	<Serializable()> _
	MustInherit Public Class esComputerCollection
		Inherits esEntityCollection(Of Computer)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return ComputerMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "ComputerCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As ComputerQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New ComputerQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As ComputerQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New ComputerQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As ComputerQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, ComputerQuery))
		End Sub
		
		#End Region
						
		Private m_query As ComputerQuery
	End Class



	<Serializable> _
	MustInherit Public Class esComputerQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ComputerMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Id, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ComputerName As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.ComputerName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Processor As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Processor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MACAddressOne As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.MACAddressOne, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MACAddressTwo As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.MACAddressTwo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MACAddressWLAN As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.MACAddressWLAN, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IPAddress As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.IPAddress, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ram As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Ram, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Os As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Os, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WinLicense As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.WinLicense, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RoomID As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.RoomID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property SerialNo As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.SerialNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Brand As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Brand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Model As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Model, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DatePurchased As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.DatePurchased, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Cost As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Cost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FundSource As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.FundSource, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Condition As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Condition, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Discard As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Discard, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Vendor As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Vendor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoried As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Inventoried, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ComputerMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class Computer 
		Inherits esComputer
		
	
		#Region "UpToRoomByRoomID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_Computer_Room
		''' </summary>

		<XmlIgnore()> _
		Public Property UpToRoomByRoomID As Room
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToRoomByRoomID Is Nothing _
						 AndAlso Not RoomID.Equals(Nothing)  Then
						
					Me._UpToRoomByRoomID = New Room()
					Me._UpToRoomByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToRoomByRoomID", Me._UpToRoomByRoomID)
					Me._UpToRoomByRoomID.Query.Where(Me._UpToRoomByRoomID.Query.Id.Equal(Me.RoomID))
					Me._UpToRoomByRoomID.Query.Load()
				End If

				Return Me._UpToRoomByRoomID
			End Get
			
            Set(ByVal value As Room)
				Me.RemovePreSave("UpToRoomByRoomID")
				
				Dim changed as Boolean = Me._UpToRoomByRoomID IsNot value

				If value Is Nothing Then
				
					Me.RoomID = Nothing
				
					Me._UpToRoomByRoomID = Nothing
				Else
				
					Me.RoomID = value.Id
					
					Me._UpToRoomByRoomID = value
					Me.SetPreSave("UpToRoomByRoomID", Me._UpToRoomByRoomID)
				End If
				
				If changed Then
					Me.OnPropertyChanged("UpToRoomByRoomID")
				End If
			End Set	

		End Property
		#End Region

		
			
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
			If Not Me.es.IsDeleted And Not Me._UpToRoomByRoomID Is Nothing Then
				Me.RoomID = Me._UpToRoomByRoomID.Id
			End If
			
		End Sub
	End Class
	


	<Serializable> _
	Partial Public Class ComputerMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Id, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = ComputerMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.HasDefault = True
			c.Default = "(newid())"
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Quantity, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ComputerMetadata.PropertyNames.Quantity
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.ComputerName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.ComputerName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Processor, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Processor
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.MACAddressOne, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.MACAddressOne
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.MACAddressTwo, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.MACAddressTwo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.MACAddressWLAN, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.MACAddressWLAN
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.IPAddress, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.IPAddress
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Ram, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Ram
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Os, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Os
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.WinLicense, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.WinLicense
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Type, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Type
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.RoomID, 12, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = ComputerMetadata.PropertyNames.RoomID
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.SerialNo, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.SerialNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Brand, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Brand
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Model, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Model
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Description, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Description
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.DatePurchased, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ComputerMetadata.PropertyNames.DatePurchased
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Cost, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ComputerMetadata.PropertyNames.Cost
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.FundSource, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.FundSource
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Condition, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Condition
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Discard, 21, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ComputerMetadata.PropertyNames.Discard
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Vendor, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Vendor
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Inventoried, 23, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ComputerMetadata.PropertyNames.Inventoried
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(ComputerMetadata.ColumnNames.Comments, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComputerMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As ComputerMetadata
			Return _meta
		End Function
		
		Public ReadOnly Property DataID() As System.Guid Implements IMetadata.DataID
			Get
				Return MyBase.m_dataID
			End Get
		End Property

		Public ReadOnly Property MultiProviderMode() As Boolean Implements IMetadata.MultiProviderMode
			Get
				Return false
			End Get
		End Property

		Public ReadOnly Property Columns() As esColumnMetadataCollection Implements IMetadata.Columns
			Get
				Return MyBase.m_columns
			End Get
		End Property

#Region "ColumnNames"
		Public Class ColumnNames
			 Public Const Id As String = "ID"
			 Public Const Quantity As String = "Quantity"
			 Public Const ComputerName As String = "ComputerName"
			 Public Const Processor As String = "Processor"
			 Public Const MACAddressOne As String = "MACAddressOne"
			 Public Const MACAddressTwo As String = "MACAddressTwo"
			 Public Const MACAddressWLAN As String = "MACAddressWLAN"
			 Public Const IPAddress As String = "IPAddress"
			 Public Const Ram As String = "RAM"
			 Public Const Os As String = "OS"
			 Public Const WinLicense As String = "WinLicense"
			 Public Const Type As String = "Type"
			 Public Const RoomID As String = "RoomID"
			 Public Const SerialNo As String = "SerialNo"
			 Public Const Brand As String = "Brand"
			 Public Const Model As String = "Model"
			 Public Const Description As String = "Description"
			 Public Const DatePurchased As String = "DatePurchased"
			 Public Const Cost As String = "cost"
			 Public Const FundSource As String = "FundSource"
			 Public Const Condition As String = "Condition"
			 Public Const Discard As String = "Discard"
			 Public Const Vendor As String = "Vendor"
			 Public Const Inventoried As String = "Inventoried"
			 Public Const Comments As String = "Comments"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const Quantity As String = "Quantity"
			 Public Const ComputerName As String = "ComputerName"
			 Public Const Processor As String = "Processor"
			 Public Const MACAddressOne As String = "MACAddressOne"
			 Public Const MACAddressTwo As String = "MACAddressTwo"
			 Public Const MACAddressWLAN As String = "MACAddressWLAN"
			 Public Const IPAddress As String = "IPAddress"
			 Public Const Ram As String = "Ram"
			 Public Const Os As String = "Os"
			 Public Const WinLicense As String = "WinLicense"
			 Public Const Type As String = "Type"
			 Public Const RoomID As String = "RoomID"
			 Public Const SerialNo As String = "SerialNo"
			 Public Const Brand As String = "Brand"
			 Public Const Model As String = "Model"
			 Public Const Description As String = "Description"
			 Public Const DatePurchased As String = "DatePurchased"
			 Public Const Cost As String = "Cost"
			 Public Const FundSource As String = "FundSource"
			 Public Const Condition As String = "Condition"
			 Public Const Discard As String = "Discard"
			 Public Const Vendor As String = "Vendor"
			 Public Const Inventoried As String = "Inventoried"
			 Public Const Comments As String = "Comments"
		End Class
#End Region	

		Public Function GetProviderMetadata(ByVal mapName As String) As esProviderSpecificMetadata _
			Implements IMetadata.GetProviderMetadata

			Dim mapMethod As MapToMeta = mapDelegates(mapName)

			If (Not mapMethod = Nothing) Then
				Return mapMethod(mapName)
			Else
				Return Nothing
			End If

		End Function
		
#Region "MAP esDefault"

		Private Shared Function RegisterDelegateesDefault() As Integer
		
			' This is only executed once per the life of the application
			SyncLock GetType(ComputerMetadata)
			
				If ComputerMetadata.mapDelegates Is Nothing Then
					ComputerMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If ComputerMetadata._meta Is Nothing Then
					ComputerMetadata._meta = New ComputerMetadata()
				End If

				Dim mapMethod As New MapToMeta(AddressOf _meta.esDefault)
				mapDelegates.Add("esDefault", mapMethod)
				mapMethod("esDefault")
				Return 0

			End SyncLock
			
		End Function

		Private Function esDefault(ByVal mapName As String) As esProviderSpecificMetadata

			If (Not m_providerMetadataMaps.ContainsKey(mapName)) Then
			
				Dim meta As esProviderSpecificMetadata = New esProviderSpecificMetadata()


				meta.AddTypeMap("Id", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("Quantity", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("ComputerName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Processor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MACAddressOne", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MACAddressTwo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("MACAddressWLAN", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("IPAddress", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Ram", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Os", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("WinLicense", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RoomID", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("SerialNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Brand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Model", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DatePurchased", new esTypeMap("date", "System.DateTime"))
				meta.AddTypeMap("Cost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FundSource", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Condition", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Discard", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Vendor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Inventoried", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Comments", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Computer"
				meta.Destination = "Computer"
				
				meta.spInsert = "proc_ComputerInsert"
				meta.spUpdate = "proc_ComputerUpdate"
				meta.spDelete = "proc_ComputerDelete"
				meta.spLoadAll = "proc_ComputerLoadAll"
				meta.spLoadByPrimaryKey = "proc_ComputerLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As ComputerMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
