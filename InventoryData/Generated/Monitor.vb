
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
	' Encapsulates the 'Monitor' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("Monitor")> _ 
	<Table(Name:="Monitor")> _ 
	Partial Public Class Monitor 
		Inherits esMonitor
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Monitor()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Guid)
			Dim obj As New Monitor()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Monitor()
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
		Public Overrides Property MonitorName As System.String
			Get
				Return MyBase.MonitorName
			End Get
			Set
				MyBase.MonitorName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Size As Nullable(Of System.Int16)
			Get
				Return MyBase.Size
			End Get
			Set
				MyBase.Size = value
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
		Public Overrides Property DatePurchased As System.String
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
	<XmlType("MonitorCollection")> _
	Partial Public Class MonitorCollection
		Inherits esMonitorCollection
		Implements IEnumerable(Of Monitor)
	
		Public Function FindByPrimaryKey(ByVal id As System.Guid) As Monitor
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "MonitorQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class MonitorQuery 
		Inherits esMonitorQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "MonitorQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As MonitorQuery) As String
			Return MonitorQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As MonitorQuery
			Return DirectCast(MonitorQuery.SerializeHelper.FromXml(query, GetType(MonitorQuery)), MonitorQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esMonitor
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
		
			Dim query As New MonitorQuery()
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
		' Maps to Monitor.ID
		' </summary>
		
		Public Overridable Property Id As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(MonitorMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(MonitorMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Id)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Quantity
		' </summary>
		
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(MonitorMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(MonitorMetadata.ColumnNames.Quantity, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Quantity)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.MonitorName
		' </summary>
		
		Public Overridable Property MonitorName As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.MonitorName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.MonitorName, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.MonitorName)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Size
		' </summary>
		
		Public Overridable Property Size As Nullable(Of System.Int16)
			Get
				Return MyBase.GetSystemInt16(MonitorMetadata.ColumnNames.Size)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int16))
				If MyBase.SetSystemInt16(MonitorMetadata.ColumnNames.Size, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Size)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Type
		' </summary>
		
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.Type, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Type)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.RoomID
		' </summary>
		
		Public Overridable Property RoomID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(MonitorMetadata.ColumnNames.RoomID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(MonitorMetadata.ColumnNames.RoomID, value) Then
					Me._UpToRoomByRoomID = Nothing
					Me.OnPropertyChanged("UpToRoomByRoomID")
					OnPropertyChanged(MonitorMetadata.PropertyNames.RoomID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.SerialNo
		' </summary>
		
		Public Overridable Property SerialNo As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.SerialNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.SerialNo, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.SerialNo)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Brand
		' </summary>
		
		Public Overridable Property Brand As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.Brand)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.Brand, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Brand)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Model
		' </summary>
		
		Public Overridable Property Model As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.Model)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.Model, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Model)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Description
		' </summary>
		
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.Description, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Description)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.DatePurchased
		' </summary>
		
		Public Overridable Property DatePurchased As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.DatePurchased)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.DatePurchased, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.DatePurchased)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Cost
		' </summary>
		
		Public Overridable Property Cost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(MonitorMetadata.ColumnNames.Cost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				If MyBase.SetSystemDecimal(MonitorMetadata.ColumnNames.Cost, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Cost)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.FundSource
		' </summary>
		
		Public Overridable Property FundSource As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.FundSource)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.FundSource, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.FundSource)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Condition
		' </summary>
		
		Public Overridable Property Condition As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.Condition)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.Condition, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Condition)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Discard
		' </summary>
		
		Public Overridable Property Discard As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(MonitorMetadata.ColumnNames.Discard)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(MonitorMetadata.ColumnNames.Discard, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Discard)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Vendor
		' </summary>
		
		Public Overridable Property Vendor As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.Vendor)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.Vendor, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Vendor)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Inventoried
		' </summary>
		
		Public Overridable Property Inventoried As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(MonitorMetadata.ColumnNames.Inventoried)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(MonitorMetadata.ColumnNames.Inventoried, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Inventoried)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Monitor.Comments
		' </summary>
		
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(MonitorMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(MonitorMetadata.ColumnNames.Comments, value) Then
					OnPropertyChanged(MonitorMetadata.PropertyNames.Comments)
				End If
			End Set
		End Property		
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToRoomByRoomID As Room
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return MonitorMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As MonitorQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New MonitorQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As MonitorQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As MonitorQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As MonitorQuery

	End Class



	<Serializable()> _
	MustInherit Public Class esMonitorCollection
		Inherits esEntityCollection(Of Monitor)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return MonitorMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "MonitorCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As MonitorQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New MonitorQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As MonitorQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New MonitorQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As MonitorQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, MonitorQuery))
		End Sub
		
		#End Region
						
		Private m_query As MonitorQuery
	End Class



	<Serializable> _
	MustInherit Public Class esMonitorQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return MonitorMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Id, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property MonitorName As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.MonitorName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Size As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Size, esSystemType.Int16)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RoomID As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.RoomID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property SerialNo As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.SerialNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Brand As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Brand, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Model As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Model, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DatePurchased As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.DatePurchased, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Cost As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Cost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FundSource As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.FundSource, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Condition As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Condition, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Discard As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Discard, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Vendor As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Vendor, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoried As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Inventoried, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, MonitorMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class Monitor 
		Inherits esMonitor
		
	
		#Region "UpToRoomByRoomID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_Monitor_Room
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
	Partial Public Class MonitorMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Id, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = MonitorMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.HasDefault = True
			c.Default = "(newid())"
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Quantity, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = MonitorMetadata.PropertyNames.Quantity
			c.NumericPrecision = 10
			c.NumericScale = 2
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.MonitorName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.MonitorName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Size, 3, GetType(System.Int16), esSystemType.Int16)	
			c.PropertyName = MonitorMetadata.PropertyNames.Size
			c.NumericPrecision = 5
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Type, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.Type
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.RoomID, 5, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = MonitorMetadata.PropertyNames.RoomID
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.SerialNo, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.SerialNo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Brand, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.Brand
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Model, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.Model
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Description, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.Description
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.DatePurchased, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.DatePurchased
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Cost, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = MonitorMetadata.PropertyNames.Cost
			c.NumericPrecision = 19
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.FundSource, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.FundSource
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Condition, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.Condition
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Discard, 14, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = MonitorMetadata.PropertyNames.Discard
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Vendor, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.Vendor
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Inventoried, 16, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = MonitorMetadata.PropertyNames.Inventoried
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(MonitorMetadata.ColumnNames.Comments, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = MonitorMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 1073741823
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As MonitorMetadata
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
			 Public Const MonitorName As String = "MonitorName"
			 Public Const Size As String = "Size"
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
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const Quantity As String = "Quantity"
			 Public Const MonitorName As String = "MonitorName"
			 Public Const Size As String = "Size"
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
			SyncLock GetType(MonitorMetadata)
			
				If MonitorMetadata.mapDelegates Is Nothing Then
					MonitorMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If MonitorMetadata._meta Is Nothing Then
					MonitorMetadata._meta = New MonitorMetadata()
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
				meta.AddTypeMap("MonitorName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Size", new esTypeMap("smallint", "System.Int16"))
				meta.AddTypeMap("Type", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("RoomID", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("SerialNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Brand", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Model", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DatePurchased", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Cost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("FundSource", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Condition", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Discard", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Vendor", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Inventoried", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Comments", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Monitor"
				meta.Destination = "Monitor"
				
				meta.spInsert = "proc_MonitorInsert"
				meta.spUpdate = "proc_MonitorUpdate"
				meta.spDelete = "proc_MonitorDelete"
				meta.spLoadAll = "proc_MonitorLoadAll"
				meta.spLoadByPrimaryKey = "proc_MonitorLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As MonitorMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
