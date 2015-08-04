
'===============================================================================
'                   EntitySpaces 2010 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2010.1.1122.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/16/2011 11:00:57 AM
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
	' Encapsulates the 'UserRoom' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("UserRoom")> _ 
	<Table(Name:="UserRoom")> _ 
	Partial Public Class UserRoom 
		Inherits esUserRoom
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New UserRoom()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal userID As System.Guid, ByVal roomID As System.Guid)
			Dim obj As New UserRoom()
			obj.UserID = userID
			obj.RoomID = roomID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal userID As System.Guid, ByVal roomID As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New UserRoom()
			obj.UserID = userID
			obj.RoomID = roomID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
	
		

		#Region "LINQtoSQL overrides (shame but we must do this)"

		<Column(IsPrimaryKey: = true, CanBeNull: = false)> _
		Public Overrides Property UserID As Nullable(Of System.Guid)
			Get
				Return MyBase.UserID
			End Get
			Set
				MyBase.UserID = value
			End Set
		End Property

		<Column(IsPrimaryKey: = true, CanBeNull: = false)> _
		Public Overrides Property RoomID As Nullable(Of System.Guid)
			Get
				Return MyBase.RoomID
			End Get
			Set
				MyBase.RoomID = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Permission As System.String
			Get
				Return MyBase.Permission
			End Get
			Set
				MyBase.Permission = value
			End Set
		End Property
			
		#End Region
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<XmlType("UserRoomCollection")> _
	Partial Public Class UserRoomCollection
		Inherits esUserRoomCollection
		Implements IEnumerable(Of UserRoom)
	
		Public Function FindByPrimaryKey(ByVal userID As System.Guid, ByVal roomID As System.Guid) As UserRoom
			Return MyBase.SingleOrDefault(Function(e) e.UserID.HasValue AndAlso e.UserID.Value = userID And e.RoomID.HasValue AndAlso e.RoomID.Value = roomID)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "UserRoomQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class UserRoomQuery 
		Inherits esUserRoomQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "UserRoomQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As UserRoomQuery) As String
			Return UserRoomQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As UserRoomQuery
			Return DirectCast(UserRoomQuery.SerializeHelper.FromXml(query, GetType(UserRoomQuery)), UserRoomQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esUserRoom
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal userID As System.Guid, ByVal roomID As System.Guid) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(userID, roomID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(userID, roomID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal userID As System.Guid, ByVal roomID As System.Guid) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(userID, roomID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(userID, roomID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal userID As System.Guid, ByVal roomID As System.Guid) As Boolean
		
			Dim query As New UserRoomQuery()
			query.Where(query.UserID.Equal(userID), query.RoomID.Equal(roomID))
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal userID As System.Guid, ByVal roomID As System.Guid) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("UserID", userID)
						parms.Add("RoomID", roomID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to UserRoom.UserID
		' </summary>
		
		Public Overridable Property UserID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(UserRoomMetadata.ColumnNames.UserID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(UserRoomMetadata.ColumnNames.UserID, value) Then
					Me._UpToUserByUserID = Nothing
					Me.OnPropertyChanged("UpToUserByUserID")
					OnPropertyChanged(UserRoomMetadata.PropertyNames.UserID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to UserRoom.RoomID
		' </summary>
		
		Public Overridable Property RoomID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(UserRoomMetadata.ColumnNames.RoomID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(UserRoomMetadata.ColumnNames.RoomID, value) Then
					Me._UpToRoomByRoomID = Nothing
					Me.OnPropertyChanged("UpToRoomByRoomID")
					OnPropertyChanged(UserRoomMetadata.PropertyNames.RoomID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to UserRoom.Permission
		' </summary>
		
		Public Overridable Property Permission As System.String
			Get
				Return MyBase.GetSystemString(UserRoomMetadata.ColumnNames.Permission)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserRoomMetadata.ColumnNames.Permission, value) Then
					OnPropertyChanged(UserRoomMetadata.PropertyNames.Permission)
				End If
			End Set
		End Property		
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToRoomByRoomID As Room
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToUserByUserID As User
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return UserRoomMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As UserRoomQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New UserRoomQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As UserRoomQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As UserRoomQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As UserRoomQuery

	End Class
    

	<Serializable()> _
	MustInherit Public Class esUserRoomCollection
		Inherits esEntityCollection(Of UserRoom)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return UserRoomMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "UserRoomCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As UserRoomQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New UserRoomQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As UserRoomQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New UserRoomQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As UserRoomQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, UserRoomQuery))
		End Sub
		
		#End Region
						
		Private m_query As UserRoomQuery
	End Class



	<Serializable> _
	MustInherit Public Class esUserRoomQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return UserRoomMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property UserID As esQueryItem
			Get
				Return New esQueryItem(Me, UserRoomMetadata.ColumnNames.UserID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property RoomID As esQueryItem
			Get
				Return New esQueryItem(Me, UserRoomMetadata.ColumnNames.RoomID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property Permission As esQueryItem
			Get
				Return New esQueryItem(Me, UserRoomMetadata.ColumnNames.Permission, esSystemType.String)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class UserRoom 
		Inherits esUserRoom
		
	
		#Region "UpToRoomByRoomID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_UserRoom_Room
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

		#Region "UpToUserByUserID - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_UserRoom_User
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

		
			
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
			If Not Me.es.IsDeleted And Not Me._UpToRoomByRoomID Is Nothing Then
				Me.RoomID = Me._UpToRoomByRoomID.Id
			End If
			
			If Not Me.es.IsDeleted And Not Me._UpToUserByUserID Is Nothing Then
				Me.UserID = Me._UpToUserByUserID.Id
			End If
			
		End Sub
	End Class
	


	<Serializable> _
	Partial Public Class UserRoomMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(UserRoomMetadata.ColumnNames.UserID, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = UserRoomMetadata.PropertyNames.UserID
			c.IsInPrimaryKey = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserRoomMetadata.ColumnNames.RoomID, 1, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = UserRoomMetadata.PropertyNames.RoomID
			c.IsInPrimaryKey = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserRoomMetadata.ColumnNames.Permission, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserRoomMetadata.PropertyNames.Permission
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As UserRoomMetadata
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
			 Public Const UserID As String = "UserID"
			 Public Const RoomID As String = "RoomID"
			 Public Const Permission As String = "Permission"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const UserID As String = "UserID"
			 Public Const RoomID As String = "RoomID"
			 Public Const Permission As String = "Permission"
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
			SyncLock GetType(UserRoomMetadata)
			
				If UserRoomMetadata.mapDelegates Is Nothing Then
					UserRoomMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If UserRoomMetadata._meta Is Nothing Then
					UserRoomMetadata._meta = New UserRoomMetadata()
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


				meta.AddTypeMap("UserID", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("RoomID", new esTypeMap("uniqueidentifier", "System.Guid"))
				meta.AddTypeMap("Permission", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "UserRoom"
				meta.Destination = "UserRoom"
				
				meta.spInsert = "proc_UserRoomInsert"
				meta.spUpdate = "proc_UserRoomUpdate"
				meta.spDelete = "proc_UserRoomDelete"
				meta.spLoadAll = "proc_UserRoomLoadAll"
				meta.spLoadByPrimaryKey = "proc_UserRoomLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As UserRoomMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
