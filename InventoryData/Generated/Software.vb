
'===============================================================================
'                   EntitySpaces 2010 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2010.1.1122.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/16/2011 10:57:35 AM
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
	' Encapsulates the 'Software' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("Software")> _ 
	<Table(Name:="Software")> _ 
	Partial Public Class Software 
		Inherits esSoftware
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Software()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Guid)
			Dim obj As New Software()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Software()
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
		Public Overrides Property SoftwareName As System.String
			Get
				Return MyBase.SoftwareName
			End Get
			Set
				MyBase.SoftwareName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property NumberOfLicenses As Nullable(Of System.Int16)
			Get
				Return MyBase.NumberOfLicenses
			End Get
			Set
				MyBase.NumberOfLicenses = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property ProductKey As System.String
			Get
				Return MyBase.ProductKey
			End Get
			Set
				MyBase.ProductKey = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property CostPerLicense As System.String
			Get
				Return MyBase.CostPerLicense
			End Get
			Set
				MyBase.CostPerLicense = value
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
		Public Overrides Property Type As System.String
			Get
				Return MyBase.Type
			End Get
			Set
				MyBase.Type = value
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
	<XmlType("SoftwareCollection")> _
	Partial Public Class SoftwareCollection
		Inherits esSoftwareCollection
		Implements IEnumerable(Of Software)
	
		Public Function FindByPrimaryKey(ByVal id As System.Guid) As Software
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "SoftwareQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class SoftwareQuery 
		Inherits esSoftwareQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "SoftwareQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As SoftwareQuery) As String
			Return SoftwareQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As SoftwareQuery
			Return DirectCast(SoftwareQuery.SerializeHelper.FromXml(query, GetType(SoftwareQuery)), SoftwareQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esSoftware
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
		
			Dim query As New SoftwareQuery()
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
		' Maps to Software.ID
		' </summary>
		
		Public Overridable Property Id As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(SoftwareMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(SoftwareMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Id)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Quantity
		' </summary>
		
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(SoftwareMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(SoftwareMetadata.ColumnNames.Quantity, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Quantity)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.SoftwareName
		' </summary>
		
		Public Overridable Property SoftwareName As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.SoftwareName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.SoftwareName, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.SoftwareName)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.NumberOfLicenses
		' </summary>
		
		Public Overridable Property NumberOfLicenses As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(SoftwareMetadata.ColumnNames.NumberOfLicenses)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(SoftwareMetadata.ColumnNames.NumberOfLicenses, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.NumberOfLicenses)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.ProductKey
		' </summary>
		
		Public Overridable Property ProductKey As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.ProductKey)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.ProductKey, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.ProductKey)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.CostPerLicense
		' </summary>
		
		Public Overridable Property CostPerLicense As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.CostPerLicense)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.CostPerLicense, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.CostPerLicense)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.RoomID
		' </summary>
		
		Public Overridable Property RoomID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(SoftwareMetadata.ColumnNames.RoomID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(SoftwareMetadata.ColumnNames.RoomID, value) Then
					Me._UpToRoomByRoomID = Nothing
					Me.OnPropertyChanged("UpToRoomByRoomID")
					OnPropertyChanged(SoftwareMetadata.PropertyNames.RoomID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Type
		' </summary>
		
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.Type, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Type)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.SerialNo
		' </summary>
		
		Public Overridable Property SerialNo As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.SerialNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.SerialNo, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.SerialNo)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Brand
		' </summary>
		
		Public Overridable Property Brand As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.Brand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.Brand, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Brand)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Model
		' </summary>
		
		Public Overridable Property Model As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.Model)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.Model, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Model)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Description
		' </summary>
		
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.Description, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Description)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.DatePurchased
		' </summary>
		
		Public Overridable Property DatePurchased As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(SoftwareMetadata.ColumnNames.DatePurchased)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(SoftwareMetadata.ColumnNames.DatePurchased, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.DatePurchased)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Cost
		' </summary>
		
		Public Overridable Property Cost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(SoftwareMetadata.ColumnNames.Cost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(SoftwareMetadata.ColumnNames.Cost, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Cost)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.FundSource
		' </summary>
		
		Public Overridable Property FundSource As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.FundSource)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.FundSource, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.FundSource)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Condition
		' </summary>
		
		Public Overridable Property Condition As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.Condition)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.Condition, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Condition)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Discard
		' </summary>
		
		Public Overridable Property Discard As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(SoftwareMetadata.ColumnNames.Discard)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(SoftwareMetadata.ColumnNames.Discard, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Discard)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Vendor
		' </summary>
		
		Public Overridable Property Vendor As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.Vendor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.Vendor, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Vendor)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Inventoried
		' </summary>
		
		Public Overridable Property Inventoried As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(SoftwareMetadata.ColumnNames.Inventoried)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(SoftwareMetadata.ColumnNames.Inventoried, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Inventoried)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Software.Comments
		' </summary>
		
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(SoftwareMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(SoftwareMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(SoftwareMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property		
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToRoomByRoomID As Room
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return SoftwareMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As SoftwareQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New SoftwareQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As SoftwareQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As SoftwareQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As SoftwareQuery

	End Class



	<Serializable()> _
	MustInherit Public Class esSoftwareCollection
		Inherits esEntityCollection(Of Software)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return SoftwareMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "SoftwareCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As SoftwareQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New SoftwareQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As SoftwareQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New SoftwareQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As SoftwareQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, SoftwareQuery))
		End Sub
		
		#End Region
						
		Private m_query As SoftwareQuery
	End Class



	<Serializable> _
	MustInherit Public Class esSoftwareQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return SoftwareMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Id, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SoftwareName As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.SoftwareName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NumberOfLicenses As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.NumberOfLicenses, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property ProductKey As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.ProductKey, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CostPerLicense As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.CostPerLicense, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RoomID As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.RoomID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SerialNo As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.SerialNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Brand As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Brand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Model As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Model, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DatePurchased As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.DatePurchased, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Cost As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Cost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FundSource As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.FundSource, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Condition As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Condition, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Discard As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Discard, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Vendor As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Vendor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoried As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Inventoried, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, SoftwareMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class Software 
		Inherits esSoftware
		
	
		#Region "UpToRoomByRoomID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_Software_Room
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
	Partial Public Class SoftwareMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Id, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.HasDefault = True
			c.Default = "(newid())"
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Quantity, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Quantity
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.SoftwareName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.SoftwareName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.NumberOfLicenses, 3, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = SoftwareMetadata.PropertyNames.NumberOfLicenses
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.ProductKey, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.ProductKey
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.CostPerLicense, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.CostPerLicense
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.RoomID, 6, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = SoftwareMetadata.PropertyNames.RoomID
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Type, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Type
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.SerialNo, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.SerialNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Brand, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Brand
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Model, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Model
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Description, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Description
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.DatePurchased, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = SoftwareMetadata.PropertyNames.DatePurchased
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Cost, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Cost
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.FundSource, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.FundSource
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Condition, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Condition
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Discard, 16, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Discard
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Vendor, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Vendor
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Inventoried, 18, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Inventoried
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(SoftwareMetadata.ColumnNames.Comments, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = SoftwareMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As SoftwareMetadata
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
			 Public Const SoftwareName As String = "SoftwareName"
			 Public Const NumberOfLicenses As String = "NumberOfLicenses"
			 Public Const ProductKey As String = "ProductKey"
			 Public Const CostPerLicense As String = "CostPerLicense"
			 Public Const RoomID As String = "RoomID"
			 Public Const Type As String = "Type"
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
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const Quantity As String = "Quantity"
			 Public Const SoftwareName As String = "SoftwareName"
			 Public Const NumberOfLicenses As String = "NumberOfLicenses"
			 Public Const ProductKey As String = "ProductKey"
			 Public Const CostPerLicense As String = "CostPerLicense"
			 Public Const RoomID As String = "RoomID"
			 Public Const Type As String = "Type"
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
			SyncLock GetType(SoftwareMetadata)
			
				If SoftwareMetadata.mapDelegates Is Nothing Then
					SoftwareMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If SoftwareMetadata._meta Is Nothing Then
					SoftwareMetadata._meta = New SoftwareMetadata()
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
				meta.AddTypeMap("SoftwareName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("NumberOfLicenses", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("ProductKey", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("CostPerLicense", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RoomID", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.String"))
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
				
				
				 
				meta.Source = "Software"
				meta.Destination = "Software"
				
				meta.spInsert = "proc_SoftwareInsert"
				meta.spUpdate = "proc_SoftwareUpdate"
				meta.spDelete = "proc_SoftwareDelete"
				meta.spLoadAll = "proc_SoftwareLoadAll"
				meta.spLoadByPrimaryKey = "proc_SoftwareLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As SoftwareMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
