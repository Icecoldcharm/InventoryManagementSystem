
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
	' Encapsulates the 'Building' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("Building")> _ 
	<Table(Name:="Building")> _ 
	Partial Public Class Building 
		Inherits esBuilding
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Building()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Guid)
			Dim obj As New Building()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Building()
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
		Public Overrides Property BldName As System.String
			Get
				Return MyBase.BldName
			End Get
			Set
				MyBase.BldName = value
			End Set
		End Property
			
		#End Region
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<XmlType("BuildingCollection")> _
	Partial Public Class BuildingCollection
		Inherits esBuildingCollection
		Implements IEnumerable(Of Building)
	
		Public Function FindByPrimaryKey(ByVal id As System.Guid) As Building
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "BuildingQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class BuildingQuery 
		Inherits esBuildingQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "BuildingQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As BuildingQuery) As String
			Return BuildingQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As BuildingQuery
			Return DirectCast(BuildingQuery.SerializeHelper.FromXml(query, GetType(BuildingQuery)), BuildingQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esBuilding
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
		
			Dim query As New BuildingQuery()
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
		' Maps to Building.ID
		' </summary>
		
		Public Overridable Property Id As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(BuildingMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(BuildingMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(BuildingMetadata.PropertyNames.Id)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to Building.BldName
		' </summary>
		
		Public Overridable Property BldName As System.String
			Get
				Return MyBase.GetSystemString(BuildingMetadata.ColumnNames.BldName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(BuildingMetadata.ColumnNames.BldName, value) Then
					OnPropertyChanged(BuildingMetadata.PropertyNames.BldName)
				End If
			End Set
		End Property		
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BuildingMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As BuildingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BuildingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As BuildingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As BuildingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As BuildingQuery

	End Class



	<Serializable()> _
	MustInherit Public Class esBuildingCollection
		Inherits esEntityCollection(Of Building)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return BuildingMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "BuildingCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As BuildingQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New BuildingQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As BuildingQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New BuildingQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As BuildingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, BuildingQuery))
		End Sub
		
		#End Region
						
		Private m_query As BuildingQuery
	End Class



	<Serializable> _
	MustInherit Public Class esBuildingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BuildingMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, BuildingMetadata.ColumnNames.Id, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property BldName As esQueryItem
			Get
				Return New esQueryItem(Me, BuildingMetadata.ColumnNames.BldName, esSystemType.String)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class Building 
		Inherits esBuilding
		
	
		#Region "RoomCollectionByBldID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_RoomCollectionByBldID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Building.RoomCollectionByBldID_Delegate)
				map.PropertyName = "RoomCollectionByBldID"
				map.MyColumnName = "BldID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub RoomCollectionByBldID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New BuildingQuery(data.NextAlias())
			
			Dim mee As RoomQuery = If(data.You IsNot Nothing, TryCast(data.You, RoomQuery), New RoomQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.BldID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - TblRooms_FK00
		''' </summary>

		<XmlIgnore()> _ 
		Public Property RoomCollectionByBldID As RoomCollection 
		
			Get
				If Me._RoomCollectionByBldID Is Nothing Then
					Me._RoomCollectionByBldID = New RoomCollection()
					Me._RoomCollectionByBldID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("RoomCollectionByBldID", Me._RoomCollectionByBldID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._RoomCollectionByBldID.Query.Where(Me._RoomCollectionByBldID.Query.BldID.Equal(Me.Id))
							Me._RoomCollectionByBldID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._RoomCollectionByBldID.fks.Add(RoomMetadata.ColumnNames.BldID, Me.Id)
					End If
				End If

				Return Me._RoomCollectionByBldID
			End Get
			
			Set(ByVal value As RoomCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._RoomCollectionByBldID Is Nothing Then

					Me.RemovePostSave("RoomCollectionByBldID")
					Me._RoomCollectionByBldID = Nothing
					Me.OnPropertyChanged("RoomCollectionByBldID")

				End If
			End Set				
			
		End Property

		private _RoomCollectionByBldID As RoomCollection
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "RoomCollectionByBldID"
					coll = Me.RoomCollectionByBldID
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "RoomCollectionByBldID", GetType(RoomCollection), New Room()))
			Return props
			
		End Function
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
			If Not Me._RoomCollectionByBldID Is Nothing Then
			
				Dim obj As Room
				For Each obj In Me._RoomCollectionByBldID
					If obj.es.IsAdded Then
						obj.BldID = Me.Id
					End If
				Next
			End If
			
		End Sub
	End Class
	


	<Serializable> _
	Partial Public Class BuildingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BuildingMetadata.ColumnNames.Id, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = BuildingMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.HasDefault = True
			c.Default = "(newid())"
			m_columns.Add(c)
				
			c = New esColumnMetadata(BuildingMetadata.ColumnNames.BldName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BuildingMetadata.PropertyNames.BldName
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As BuildingMetadata
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
			 Public Const BldName As String = "BldName"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const BldName As String = "BldName"
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
			SyncLock GetType(BuildingMetadata)
			
				If BuildingMetadata.mapDelegates Is Nothing Then
					BuildingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If BuildingMetadata._meta Is Nothing Then
					BuildingMetadata._meta = New BuildingMetadata()
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
				meta.AddTypeMap("BldName", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "Building"
				meta.Destination = "Building"
				
				meta.spInsert = "proc_BuildingInsert"
				meta.spUpdate = "proc_BuildingUpdate"
				meta.spDelete = "proc_BuildingDelete"
				meta.spLoadAll = "proc_BuildingLoadAll"
				meta.spLoadByPrimaryKey = "proc_BuildingLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As BuildingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
