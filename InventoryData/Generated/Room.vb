
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
	' Encapsulates the 'Room' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("Room")> _ 
	<Table(Name:="Room")> _ 
	Partial Public Class Room 
		Inherits esRoom
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Room()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Guid)
			Dim obj As New Room()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Room()
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

		<Column(IsPrimaryKey: = false, CanBeNull: = false)> _
		Public Overrides Property RoomNo As Nullable(Of System.Int32)
			Get
				Return MyBase.RoomNo
			End Get
			Set
				MyBase.RoomNo = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property BldID As Nullable(Of System.Guid)
			Get
				Return MyBase.BldID
			End Get
			Set
				MyBase.BldID = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property UserID As Nullable(Of System.Guid)
			Get
				Return MyBase.UserID
			End Get
			Set
				MyBase.UserID = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property InventoryApproved As Nullable(Of System.Boolean)
			Get
				Return MyBase.InventoryApproved
			End Get
			Set
				MyBase.InventoryApproved = value
			End Set
		End Property
			
		#End Region
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<XmlType("RoomCollection")> _
	Partial Public Class RoomCollection
		Inherits esRoomCollection
		Implements IEnumerable(Of Room)
	
		Public Function FindByPrimaryKey(ByVal id As System.Guid) As Room
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "RoomQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class RoomQuery 
		Inherits esRoomQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "RoomQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As RoomQuery) As String
			Return RoomQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As RoomQuery
			Return DirectCast(RoomQuery.SerializeHelper.FromXml(query, GetType(RoomQuery)), RoomQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esRoom
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
		
			Dim query As New RoomQuery()
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
		' Maps to Room.ID
		' </summary>
		
		Public Overridable Property Id As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(RoomMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(RoomMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(RoomMetadata.PropertyNames.Id)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Room.RoomNo
		' </summary>
		
		Public Overridable Property RoomNo As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RoomMetadata.ColumnNames.RoomNo)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(RoomMetadata.ColumnNames.RoomNo, value) Then
					OnPropertyChanged(RoomMetadata.PropertyNames.RoomNo)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Room.BldID
		' </summary>
		
		Public Overridable Property BldID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(RoomMetadata.ColumnNames.BldID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(RoomMetadata.ColumnNames.BldID, value) Then
					Me._UpToBuildingByBldID = Nothing
					Me.OnPropertyChanged("UpToBuildingByBldID")
					OnPropertyChanged(RoomMetadata.PropertyNames.BldID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Room.UserID
		' </summary>
		
		Public Overridable Property UserID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(RoomMetadata.ColumnNames.UserID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(RoomMetadata.ColumnNames.UserID, value) Then
					Me._UpToUserByUserID = Nothing
					Me.OnPropertyChanged("UpToUserByUserID")
					OnPropertyChanged(RoomMetadata.PropertyNames.UserID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Room.InventoryApproved
		' </summary>
		
		Public Overridable Property InventoryApproved As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(RoomMetadata.ColumnNames.InventoryApproved)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				If MyBase.SetSystemBoolean(RoomMetadata.ColumnNames.InventoryApproved, value) Then
					OnPropertyChanged(RoomMetadata.PropertyNames.InventoryApproved)
				End If
			End Set
		End Property		
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToBuildingByBldID As Building
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToUserByUserID As User
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return RoomMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As RoomQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New RoomQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As RoomQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As RoomQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As RoomQuery

	End Class



	<Serializable()> _
	MustInherit Public Class esRoomCollection
		Inherits esEntityCollection(Of Room)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return RoomMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "RoomCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As RoomQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New RoomQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As RoomQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New RoomQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As RoomQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, RoomQuery))
		End Sub
		
		#End Region
						
		Private m_query As RoomQuery
	End Class



	<Serializable> _
	MustInherit Public Class esRoomQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RoomMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, RoomMetadata.ColumnNames.Id, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property RoomNo As esQueryItem
			Get
				Return New esQueryItem(Me, RoomMetadata.ColumnNames.RoomNo, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property BldID As esQueryItem
			Get
				Return New esQueryItem(Me, RoomMetadata.ColumnNames.BldID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property UserID As esQueryItem
			Get
				Return New esQueryItem(Me, RoomMetadata.ColumnNames.UserID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property InventoryApproved As esQueryItem
			Get
				Return New esQueryItem(Me, RoomMetadata.ColumnNames.InventoryApproved, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class Room 
		Inherits esRoom
		
	
		#Region "AudioVideoCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_AudioVideoCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.AudioVideoCollectionByRoomID_Delegate)
				map.PropertyName = "AudioVideoCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub AudioVideoCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As AudioVideoQuery = If(data.You IsNot Nothing, TryCast(data.You, AudioVideoQuery), New AudioVideoQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_AudioVideo_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property AudioVideoCollectionByRoomID As AudioVideoCollection 
		
			Get
				If Me._AudioVideoCollectionByRoomID Is Nothing Then
					Me._AudioVideoCollectionByRoomID = New AudioVideoCollection()
					Me._AudioVideoCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("AudioVideoCollectionByRoomID", Me._AudioVideoCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._AudioVideoCollectionByRoomID.Query.Where(Me._AudioVideoCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._AudioVideoCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._AudioVideoCollectionByRoomID.fks.Add(AudioVideoMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._AudioVideoCollectionByRoomID
			End Get
			
			Set(ByVal value As AudioVideoCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._AudioVideoCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("AudioVideoCollectionByRoomID")
					Me._AudioVideoCollectionByRoomID = Nothing
					Me.OnPropertyChanged("AudioVideoCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _AudioVideoCollectionByRoomID As AudioVideoCollection
		#End Region

		#Region "ComputerCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_ComputerCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.ComputerCollectionByRoomID_Delegate)
				map.PropertyName = "ComputerCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub ComputerCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As ComputerQuery = If(data.You IsNot Nothing, TryCast(data.You, ComputerQuery), New ComputerQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Computer_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property ComputerCollectionByRoomID As ComputerCollection 
		
			Get
				If Me._ComputerCollectionByRoomID Is Nothing Then
					Me._ComputerCollectionByRoomID = New ComputerCollection()
					Me._ComputerCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("ComputerCollectionByRoomID", Me._ComputerCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._ComputerCollectionByRoomID.Query.Where(Me._ComputerCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._ComputerCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._ComputerCollectionByRoomID.fks.Add(ComputerMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._ComputerCollectionByRoomID
			End Get
			
			Set(ByVal value As ComputerCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._ComputerCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("ComputerCollectionByRoomID")
					Me._ComputerCollectionByRoomID = Nothing
					Me.OnPropertyChanged("ComputerCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _ComputerCollectionByRoomID As ComputerCollection
		#End Region

		#Region "EquipmentCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_EquipmentCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.EquipmentCollectionByRoomID_Delegate)
				map.PropertyName = "EquipmentCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub EquipmentCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As EquipmentQuery = If(data.You IsNot Nothing, TryCast(data.You, EquipmentQuery), New EquipmentQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Equipment_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property EquipmentCollectionByRoomID As EquipmentCollection 
		
			Get
				If Me._EquipmentCollectionByRoomID Is Nothing Then
					Me._EquipmentCollectionByRoomID = New EquipmentCollection()
					Me._EquipmentCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("EquipmentCollectionByRoomID", Me._EquipmentCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._EquipmentCollectionByRoomID.Query.Where(Me._EquipmentCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._EquipmentCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._EquipmentCollectionByRoomID.fks.Add(EquipmentMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._EquipmentCollectionByRoomID
			End Get
			
			Set(ByVal value As EquipmentCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._EquipmentCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("EquipmentCollectionByRoomID")
					Me._EquipmentCollectionByRoomID = Nothing
					Me.OnPropertyChanged("EquipmentCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _EquipmentCollectionByRoomID As EquipmentCollection
		#End Region

		#Region "FurnitureCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_FurnitureCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.FurnitureCollectionByRoomID_Delegate)
				map.PropertyName = "FurnitureCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub FurnitureCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As FurnitureQuery = If(data.You IsNot Nothing, TryCast(data.You, FurnitureQuery), New FurnitureQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Furniture_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property FurnitureCollectionByRoomID As FurnitureCollection 
		
			Get
				If Me._FurnitureCollectionByRoomID Is Nothing Then
					Me._FurnitureCollectionByRoomID = New FurnitureCollection()
					Me._FurnitureCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("FurnitureCollectionByRoomID", Me._FurnitureCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._FurnitureCollectionByRoomID.Query.Where(Me._FurnitureCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._FurnitureCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._FurnitureCollectionByRoomID.fks.Add(FurnitureMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._FurnitureCollectionByRoomID
			End Get
			
			Set(ByVal value As FurnitureCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._FurnitureCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("FurnitureCollectionByRoomID")
					Me._FurnitureCollectionByRoomID = Nothing
					Me.OnPropertyChanged("FurnitureCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _FurnitureCollectionByRoomID As FurnitureCollection
		#End Region

		#Region "MiscTechnologyCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_MiscTechnologyCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.MiscTechnologyCollectionByRoomID_Delegate)
				map.PropertyName = "MiscTechnologyCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub MiscTechnologyCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As MiscTechnologyQuery = If(data.You IsNot Nothing, TryCast(data.You, MiscTechnologyQuery), New MiscTechnologyQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_MiscTechnology_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property MiscTechnologyCollectionByRoomID As MiscTechnologyCollection 
		
			Get
				If Me._MiscTechnologyCollectionByRoomID Is Nothing Then
					Me._MiscTechnologyCollectionByRoomID = New MiscTechnologyCollection()
					Me._MiscTechnologyCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("MiscTechnologyCollectionByRoomID", Me._MiscTechnologyCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._MiscTechnologyCollectionByRoomID.Query.Where(Me._MiscTechnologyCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._MiscTechnologyCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._MiscTechnologyCollectionByRoomID.fks.Add(MiscTechnologyMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._MiscTechnologyCollectionByRoomID
			End Get
			
			Set(ByVal value As MiscTechnologyCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._MiscTechnologyCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("MiscTechnologyCollectionByRoomID")
					Me._MiscTechnologyCollectionByRoomID = Nothing
					Me.OnPropertyChanged("MiscTechnologyCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _MiscTechnologyCollectionByRoomID As MiscTechnologyCollection
		#End Region

		#Region "MonitorCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_MonitorCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.MonitorCollectionByRoomID_Delegate)
				map.PropertyName = "MonitorCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub MonitorCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As MonitorQuery = If(data.You IsNot Nothing, TryCast(data.You, MonitorQuery), New MonitorQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Monitor_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property MonitorCollectionByRoomID As MonitorCollection 
		
			Get
				If Me._MonitorCollectionByRoomID Is Nothing Then
					Me._MonitorCollectionByRoomID = New MonitorCollection()
					Me._MonitorCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("MonitorCollectionByRoomID", Me._MonitorCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._MonitorCollectionByRoomID.Query.Where(Me._MonitorCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._MonitorCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._MonitorCollectionByRoomID.fks.Add(MonitorMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._MonitorCollectionByRoomID
			End Get
			
			Set(ByVal value As MonitorCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._MonitorCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("MonitorCollectionByRoomID")
					Me._MonitorCollectionByRoomID = Nothing
					Me.OnPropertyChanged("MonitorCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _MonitorCollectionByRoomID As MonitorCollection
		#End Region

		#Region "PrinterCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_PrinterCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.PrinterCollectionByRoomID_Delegate)
				map.PropertyName = "PrinterCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub PrinterCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As PrinterQuery = If(data.You IsNot Nothing, TryCast(data.You, PrinterQuery), New PrinterQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Printer_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property PrinterCollectionByRoomID As PrinterCollection 
		
			Get
				If Me._PrinterCollectionByRoomID Is Nothing Then
					Me._PrinterCollectionByRoomID = New PrinterCollection()
					Me._PrinterCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("PrinterCollectionByRoomID", Me._PrinterCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._PrinterCollectionByRoomID.Query.Where(Me._PrinterCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._PrinterCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._PrinterCollectionByRoomID.fks.Add(PrinterMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._PrinterCollectionByRoomID
			End Get
			
			Set(ByVal value As PrinterCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._PrinterCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("PrinterCollectionByRoomID")
					Me._PrinterCollectionByRoomID = Nothing
					Me.OnPropertyChanged("PrinterCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _PrinterCollectionByRoomID As PrinterCollection
		#End Region

		#Region "SoftwareCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_SoftwareCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.SoftwareCollectionByRoomID_Delegate)
				map.PropertyName = "SoftwareCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub SoftwareCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As SoftwareQuery = If(data.You IsNot Nothing, TryCast(data.You, SoftwareQuery), New SoftwareQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Software_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property SoftwareCollectionByRoomID As SoftwareCollection 
		
			Get
				If Me._SoftwareCollectionByRoomID Is Nothing Then
					Me._SoftwareCollectionByRoomID = New SoftwareCollection()
					Me._SoftwareCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("SoftwareCollectionByRoomID", Me._SoftwareCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._SoftwareCollectionByRoomID.Query.Where(Me._SoftwareCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._SoftwareCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._SoftwareCollectionByRoomID.fks.Add(SoftwareMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._SoftwareCollectionByRoomID
			End Get
			
			Set(ByVal value As SoftwareCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._SoftwareCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("SoftwareCollectionByRoomID")
					Me._SoftwareCollectionByRoomID = Nothing
					Me.OnPropertyChanged("SoftwareCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _SoftwareCollectionByRoomID As SoftwareCollection
		#End Region

		#Region "TextbooksCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_TextbooksCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.TextbooksCollectionByRoomID_Delegate)
				map.PropertyName = "TextbooksCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub TextbooksCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As TextbooksQuery = If(data.You IsNot Nothing, TryCast(data.You, TextbooksQuery), New TextbooksQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Textbooks_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property TextbooksCollectionByRoomID As TextbooksCollection 
		
			Get
				If Me._TextbooksCollectionByRoomID Is Nothing Then
					Me._TextbooksCollectionByRoomID = New TextbooksCollection()
					Me._TextbooksCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("TextbooksCollectionByRoomID", Me._TextbooksCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._TextbooksCollectionByRoomID.Query.Where(Me._TextbooksCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._TextbooksCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._TextbooksCollectionByRoomID.fks.Add(TextbooksMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._TextbooksCollectionByRoomID
			End Get
			
			Set(ByVal value As TextbooksCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._TextbooksCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("TextbooksCollectionByRoomID")
					Me._TextbooksCollectionByRoomID = Nothing
					Me.OnPropertyChanged("TextbooksCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _TextbooksCollectionByRoomID As TextbooksCollection
		#End Region

		#Region "UserRoomCollectionByRoomID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_UserRoomCollectionByRoomID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Room.UserRoomCollectionByRoomID_Delegate)
				map.PropertyName = "UserRoomCollectionByRoomID"
				map.MyColumnName = "RoomID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub UserRoomCollectionByRoomID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RoomQuery(data.NextAlias())
			
			Dim mee As UserRoomQuery = If(data.You IsNot Nothing, TryCast(data.You, UserRoomQuery), New UserRoomQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.RoomID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_UserRoom_Room
		''' </summary>

		<XmlIgnore()> _ 
		Public Property UserRoomCollectionByRoomID As UserRoomCollection 
		
			Get
				If Me._UserRoomCollectionByRoomID Is Nothing Then
					Me._UserRoomCollectionByRoomID = New UserRoomCollection()
					Me._UserRoomCollectionByRoomID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("UserRoomCollectionByRoomID", Me._UserRoomCollectionByRoomID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._UserRoomCollectionByRoomID.Query.Where(Me._UserRoomCollectionByRoomID.Query.RoomID.Equal(Me.Id))
							Me._UserRoomCollectionByRoomID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._UserRoomCollectionByRoomID.fks.Add(UserRoomMetadata.ColumnNames.RoomID, Me.Id)
					End If
				End If

				Return Me._UserRoomCollectionByRoomID
			End Get
			
			Set(ByVal value As UserRoomCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._UserRoomCollectionByRoomID Is Nothing Then

					Me.RemovePostSave("UserRoomCollectionByRoomID")
					Me._UserRoomCollectionByRoomID = Nothing
					Me.OnPropertyChanged("UserRoomCollectionByRoomID")

				End If
			End Set				
			
		End Property

		private _UserRoomCollectionByRoomID As UserRoomCollection
		#End Region

		#Region "UpToBuildingByBldID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - TblRooms_FK00
		''' </summary>

		<XmlIgnore()> _
		Public Property UpToBuildingByBldID As Building
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToBuildingByBldID Is Nothing _
						 AndAlso Not BldID.Equals(Nothing)  Then
						
					Me._UpToBuildingByBldID = New Building()
					Me._UpToBuildingByBldID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToBuildingByBldID", Me._UpToBuildingByBldID)
					Me._UpToBuildingByBldID.Query.Where(Me._UpToBuildingByBldID.Query.Id.Equal(Me.BldID))
					Me._UpToBuildingByBldID.Query.Load()
				End If

				Return Me._UpToBuildingByBldID
			End Get
			
            Set(ByVal value As Building)
				Me.RemovePreSave("UpToBuildingByBldID")
				
				Dim changed as Boolean = Me._UpToBuildingByBldID IsNot value

				If value Is Nothing Then
				
					Me.BldID = Nothing
				
					Me._UpToBuildingByBldID = Nothing
				Else
				
					Me.BldID = value.Id
					
					Me._UpToBuildingByBldID = value
					Me.SetPreSave("UpToBuildingByBldID", Me._UpToBuildingByBldID)
				End If
				
				If changed Then
					Me.OnPropertyChanged("UpToBuildingByBldID")
				End If
			End Set	

		End Property
		#End Region

		#Region "UpToUserByUserID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - TblRooms_FK01
		''' </summary>

		<XmlIgnore()> _
		Public Property UpToUserByUserID As User
		
			Get
				If Me.es.IsLazyLoadDisabled Then return Nothing
				
				If Me._UpToUserByUserID Is Nothing _
						 AndAlso Not UserID.Equals(Nothing)  Then
						
					Me._UpToUserByUserID = New User()
					Me._UpToUserByUserID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToUserByUserID", Me._UpToUserByUserID)
					Me._UpToUserByUserID.Query.Where(Me._UpToUserByUserID.Query.Id.Equal(Me.UserID))
					Me._UpToUserByUserID.Query.Load()
				End If

				Return Me._UpToUserByUserID
			End Get
			
            Set(ByVal value As User)
				Me.RemovePreSave("UpToUserByUserID")
				
				Dim changed as Boolean = Me._UpToUserByUserID IsNot value

				If value Is Nothing Then
				
					Me.UserID = Nothing
				
					Me._UpToUserByUserID = Nothing
				Else
				
					Me.UserID = value.Id
					
					Me._UpToUserByUserID = value
					Me.SetPreSave("UpToUserByUserID", Me._UpToUserByUserID)
				End If
				
				If changed Then
					Me.OnPropertyChanged("UpToUserByUserID")
				End If
			End Set	

		End Property
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "AudioVideoCollectionByRoomID"
					coll = Me.AudioVideoCollectionByRoomID
					Exit Select
				Case "ComputerCollectionByRoomID"
					coll = Me.ComputerCollectionByRoomID
					Exit Select
				Case "EquipmentCollectionByRoomID"
					coll = Me.EquipmentCollectionByRoomID
					Exit Select
				Case "FurnitureCollectionByRoomID"
					coll = Me.FurnitureCollectionByRoomID
					Exit Select
				Case "MiscTechnologyCollectionByRoomID"
					coll = Me.MiscTechnologyCollectionByRoomID
					Exit Select
				Case "MonitorCollectionByRoomID"
					coll = Me.MonitorCollectionByRoomID
					Exit Select
				Case "PrinterCollectionByRoomID"
					coll = Me.PrinterCollectionByRoomID
					Exit Select
				Case "SoftwareCollectionByRoomID"
					coll = Me.SoftwareCollectionByRoomID
					Exit Select
				Case "TextbooksCollectionByRoomID"
					coll = Me.TextbooksCollectionByRoomID
					Exit Select
				Case "UserRoomCollectionByRoomID"
					coll = Me.UserRoomCollectionByRoomID
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "AudioVideoCollectionByRoomID", GetType(AudioVideoCollection), New AudioVideo()))
			props.Add(new esPropertyDescriptor(Me, "ComputerCollectionByRoomID", GetType(ComputerCollection), New Computer()))
			props.Add(new esPropertyDescriptor(Me, "EquipmentCollectionByRoomID", GetType(EquipmentCollection), New Equipment()))
			props.Add(new esPropertyDescriptor(Me, "FurnitureCollectionByRoomID", GetType(FurnitureCollection), New Furniture()))
			props.Add(new esPropertyDescriptor(Me, "MiscTechnologyCollectionByRoomID", GetType(MiscTechnologyCollection), New MiscTechnology()))
			props.Add(new esPropertyDescriptor(Me, "MonitorCollectionByRoomID", GetType(MonitorCollection), New Monitor()))
			props.Add(new esPropertyDescriptor(Me, "PrinterCollectionByRoomID", GetType(PrinterCollection), New Printer()))
			props.Add(new esPropertyDescriptor(Me, "SoftwareCollectionByRoomID", GetType(SoftwareCollection), New Software()))
			props.Add(new esPropertyDescriptor(Me, "TextbooksCollectionByRoomID", GetType(TextbooksCollection), New Textbooks()))
			props.Add(new esPropertyDescriptor(Me, "UserRoomCollectionByRoomID", GetType(UserRoomCollection), New UserRoom()))
			Return props
			
		End Function	
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
			If Not Me.es.IsDeleted And Not Me._UpToBuildingByBldID Is Nothing Then
				Me.BldID = Me._UpToBuildingByBldID.Id
			End If
			
			If Not Me.es.IsDeleted And Not Me._UpToUserByUserID Is Nothing Then
				Me.UserID = Me._UpToUserByUserID.Id
			End If
			
		End Sub
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
			If Not Me._AudioVideoCollectionByRoomID Is Nothing Then
			
				Dim obj As AudioVideo
				For Each obj In Me._AudioVideoCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._ComputerCollectionByRoomID Is Nothing Then
			
				Dim obj As Computer
				For Each obj In Me._ComputerCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._EquipmentCollectionByRoomID Is Nothing Then
			
				Dim obj As Equipment
				For Each obj In Me._EquipmentCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._FurnitureCollectionByRoomID Is Nothing Then
			
				Dim obj As Furniture
				For Each obj In Me._FurnitureCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._MiscTechnologyCollectionByRoomID Is Nothing Then
			
				Dim obj As MiscTechnology
				For Each obj In Me._MiscTechnologyCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._MonitorCollectionByRoomID Is Nothing Then
			
				Dim obj As Monitor
				For Each obj In Me._MonitorCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._PrinterCollectionByRoomID Is Nothing Then
			
				Dim obj As Printer
				For Each obj In Me._PrinterCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._SoftwareCollectionByRoomID Is Nothing Then
			
				Dim obj As Software
				For Each obj In Me._SoftwareCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._TextbooksCollectionByRoomID Is Nothing Then
			
				Dim obj As Textbooks
				For Each obj In Me._TextbooksCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
			If Not Me._UserRoomCollectionByRoomID Is Nothing Then
			
				Dim obj As UserRoom
				For Each obj In Me._UserRoomCollectionByRoomID
					If obj.es.IsAdded Then
						obj.RoomID = Me.Id
					End If
				Next
			End If
			
		End Sub
	End Class
	


	<Serializable> _
	Partial Public Class RoomMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(RoomMetadata.ColumnNames.Id, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = RoomMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.HasDefault = True
			c.Default = "(newid())"
			m_columns.Add(c)
				
			c = New esColumnMetadata(RoomMetadata.ColumnNames.RoomNo, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RoomMetadata.PropertyNames.RoomNo
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((0))"
			m_columns.Add(c)
				
			c = New esColumnMetadata(RoomMetadata.ColumnNames.BldID, 2, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = RoomMetadata.PropertyNames.BldID
			c.HasDefault = True
			c.Default = "(newid())"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RoomMetadata.ColumnNames.UserID, 3, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = RoomMetadata.PropertyNames.UserID
			c.HasDefault = True
			c.Default = "(newid())"
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(RoomMetadata.ColumnNames.InventoryApproved, 4, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = RoomMetadata.PropertyNames.InventoryApproved
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As RoomMetadata
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
			 Public Const RoomNo As String = "RoomNo"
			 Public Const BldID As String = "BldID"
			 Public Const UserID As String = "UserID"
			 Public Const InventoryApproved As String = "InventoryApproved"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const RoomNo As String = "RoomNo"
			 Public Const BldID As String = "BldID"
			 Public Const UserID As String = "UserID"
			 Public Const InventoryApproved As String = "InventoryApproved"
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
			SyncLock GetType(RoomMetadata)
			
				If RoomMetadata.mapDelegates Is Nothing Then
					RoomMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If RoomMetadata._meta Is Nothing Then
					RoomMetadata._meta = New RoomMetadata()
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
				meta.AddTypeMap("RoomNo", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("BldID", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("UserID", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("InventoryApproved", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "Room"
				meta.Destination = "Room"
				
				meta.spInsert = "proc_RoomInsert"
				meta.spUpdate = "proc_RoomUpdate"
				meta.spDelete = "proc_RoomDelete"
				meta.spLoadAll = "proc_RoomLoadAll"
				meta.spLoadByPrimaryKey = "proc_RoomLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As RoomMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
