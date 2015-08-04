
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
	' Encapsulates the 'Equipment' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("Equipment")> _ 
	<Table(Name:="Equipment")> _ 
	Partial Public Class Equipment 
		Inherits esEquipment
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Equipment()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Guid)
			Dim obj As New Equipment()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Equipment()
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

		<Column(IsPrimaryKey: = false, CanBeNull: = false)> _
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
	<XmlType("EquipmentCollection")> _
	Partial Public Class EquipmentCollection
		Inherits esEquipmentCollection
		Implements IEnumerable(Of Equipment)
	
		Public Function FindByPrimaryKey(ByVal id As System.Guid) As Equipment
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "EquipmentQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class EquipmentQuery 
		Inherits esEquipmentQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "EquipmentQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As EquipmentQuery) As String
			Return EquipmentQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As EquipmentQuery
			Return DirectCast(EquipmentQuery.SerializeHelper.FromXml(query, GetType(EquipmentQuery)), EquipmentQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esEquipment
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
		
			Dim query As New EquipmentQuery()
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
		' Maps to Equipment.ID
		' </summary>
		
		Public Overridable Property Id As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(EquipmentMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(EquipmentMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Id)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Quantity
		' </summary>
		
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(EquipmentMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(EquipmentMetadata.ColumnNames.Quantity, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Quantity)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.RoomID
		' </summary>
		
		Public Overridable Property RoomID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(EquipmentMetadata.ColumnNames.RoomID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(EquipmentMetadata.ColumnNames.RoomID, value) Then
					Me._UpToRoomByRoomID = Nothing
					Me.OnPropertyChanged("UpToRoomByRoomID")
					OnPropertyChanged(EquipmentMetadata.PropertyNames.RoomID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Type
		' </summary>
		
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.Type, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Type)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.SerialNo
		' </summary>
		
		Public Overridable Property SerialNo As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.SerialNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.SerialNo, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.SerialNo)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Brand
		' </summary>
		
		Public Overridable Property Brand As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.Brand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.Brand, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Brand)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Model
		' </summary>
		
		Public Overridable Property Model As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.Model)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.Model, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Model)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Description
		' </summary>
		
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.Description, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Description)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.DatePurchased
		' </summary>
		
		Public Overridable Property DatePurchased As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(EquipmentMetadata.ColumnNames.DatePurchased)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				If MyBase.SetSystemDateTime(EquipmentMetadata.ColumnNames.DatePurchased, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.DatePurchased)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Cost
		' </summary>
		
		Public Overridable Property Cost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(EquipmentMetadata.ColumnNames.Cost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(EquipmentMetadata.ColumnNames.Cost, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Cost)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.FundSource
		' </summary>
		
		Public Overridable Property FundSource As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.FundSource)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.FundSource, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.FundSource)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Condition
		' </summary>
		
		Public Overridable Property Condition As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.Condition)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.Condition, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Condition)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Discard
		' </summary>
		
		Public Overridable Property Discard As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(EquipmentMetadata.ColumnNames.Discard)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(EquipmentMetadata.ColumnNames.Discard, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Discard)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Vendor
		' </summary>
		
		Public Overridable Property Vendor As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.Vendor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.Vendor, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Vendor)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Inventoried
		' </summary>
		
		Public Overridable Property Inventoried As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(EquipmentMetadata.ColumnNames.Inventoried)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(EquipmentMetadata.ColumnNames.Inventoried, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Inventoried)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Equipment.Comments
		' </summary>
		
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(EquipmentMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(EquipmentMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(EquipmentMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property		
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToRoomByRoomID As Room
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EquipmentMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As EquipmentQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EquipmentQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As EquipmentQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As EquipmentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As EquipmentQuery

	End Class



	<Serializable()> _
	MustInherit Public Class esEquipmentCollection
		Inherits esEntityCollection(Of Equipment)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return EquipmentMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "EquipmentCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As EquipmentQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New EquipmentQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As EquipmentQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New EquipmentQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As EquipmentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, EquipmentQuery))
		End Sub
		
		#End Region
						
		Private m_query As EquipmentQuery
	End Class



	<Serializable> _
	MustInherit Public Class esEquipmentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EquipmentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Id, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RoomID As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.RoomID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SerialNo As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.SerialNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Brand As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Brand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Model As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Model, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DatePurchased As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.DatePurchased, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Cost As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Cost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FundSource As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.FundSource, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Condition As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Condition, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Discard As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Discard, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Vendor As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Vendor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoried As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Inventoried, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, EquipmentMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class Equipment 
		Inherits esEquipment
		
	
		#Region "UpToRoomByRoomID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_Equipment_Room
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
	Partial Public Class EquipmentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Id, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Quantity, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Quantity
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.RoomID, 2, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = EquipmentMetadata.PropertyNames.RoomID
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Type, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Type
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.SerialNo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.SerialNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Brand, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Brand
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Model, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Model
			c.CharacterMaxLength = 100
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Description, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Description
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.DatePurchased, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = EquipmentMetadata.PropertyNames.DatePurchased
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Cost, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Cost
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.FundSource, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.FundSource
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Condition, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Condition
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Discard, 12, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Discard
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Vendor, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Vendor
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Inventoried, 14, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Inventoried
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(EquipmentMetadata.ColumnNames.Comments, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = EquipmentMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As EquipmentMetadata
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
			SyncLock GetType(EquipmentMetadata)
			
				If EquipmentMetadata.mapDelegates Is Nothing Then
					EquipmentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If EquipmentMetadata._meta Is Nothing Then
					EquipmentMetadata._meta = New EquipmentMetadata()
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
				
				
				 
				meta.Source = "Equipment"
				meta.Destination = "Equipment"
				
				meta.spInsert = "proc_EquipmentInsert"
				meta.spUpdate = "proc_EquipmentUpdate"
				meta.spDelete = "proc_EquipmentDelete"
				meta.spLoadAll = "proc_EquipmentLoadAll"
				meta.spLoadByPrimaryKey = "proc_EquipmentLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As EquipmentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
