
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
	' Encapsulates the 'User' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("User")> _ 
	<Table(Name:="User")> _ 
	Partial Public Class User 
		Inherits esUser
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New User()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal id As System.Guid)
			Dim obj As New User()
			obj.Id = id
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal id As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New User()
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
		Public Overrides Property FirstName As System.String
			Get
				Return MyBase.FirstName
			End Get
			Set
				MyBase.FirstName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property LastName As System.String
			Get
				Return MyBase.LastName
			End Get
			Set
				MyBase.LastName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property BldName As System.String
			Get
				Return MyBase.BldName
			End Get
			Set
				MyBase.BldName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property DeptID As System.String
			Get
				Return MyBase.DeptID
			End Get
			Set
				MyBase.DeptID = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property HomePhone As System.String
			Get
				Return MyBase.HomePhone
			End Get
			Set
				MyBase.HomePhone = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property BusNo As System.String
			Get
				Return MyBase.BusNo
			End Get
			Set
				MyBase.BusNo = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property UserName As System.String
			Get
				Return MyBase.UserName
			End Get
			Set
				MyBase.UserName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Password As System.String
			Get
				Return MyBase.Password
			End Get
			Set
				MyBase.Password = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property AccountType As System.String
			Get
				Return MyBase.AccountType
			End Get
			Set
				MyBase.AccountType = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property UserDirectory As System.String
			Get
				Return MyBase.UserDirectory
			End Get
			Set
				MyBase.UserDirectory = value
			End Set
		End Property
			
		#End Region
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<XmlType("UserCollection")> _
	Partial Public Class UserCollection
		Inherits esUserCollection
		Implements IEnumerable(Of User)
	
		Public Function FindByPrimaryKey(ByVal id As System.Guid) As User
			Return MyBase.SingleOrDefault(Function(e) e.Id.HasValue AndAlso e.Id.Value = id)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "UserQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class UserQuery 
		Inherits esUserQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "UserQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As UserQuery) As String
			Return UserQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As UserQuery
			Return DirectCast(UserQuery.SerializeHelper.FromXml(query, GetType(UserQuery)), UserQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esUser
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
		
			Dim query As New UserQuery()
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
		' Maps to User.ID
		' </summary>
		
		Public Overridable Property Id As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(UserMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(UserMetadata.ColumnNames.Id, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.Id)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.FirstName
		' </summary>
		
		Public Overridable Property FirstName As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.FirstName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.FirstName, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.FirstName)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.LastName
		' </summary>
		
		Public Overridable Property LastName As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.LastName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.LastName, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.LastName)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.BldName
		' </summary>
		
		Public Overridable Property BldName As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.BldName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.BldName, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.BldName)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.DeptID
		' </summary>
		
		Public Overridable Property DeptID As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.DeptID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.DeptID, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.DeptID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.HomePhone
		' </summary>
		
		Public Overridable Property HomePhone As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.HomePhone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.HomePhone, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.HomePhone)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.BusNo
		' </summary>
		
		Public Overridable Property BusNo As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.BusNo)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.BusNo, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.BusNo)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.UserName
		' </summary>
		
		Public Overridable Property UserName As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.UserName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.UserName, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.UserName)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.Password
		' </summary>
		
		Public Overridable Property Password As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.Password)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.Password, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.Password)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.AccountType
		' </summary>
		
		Public Overridable Property AccountType As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.AccountType)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.AccountType, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.AccountType)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to User.UserDirectory
		' </summary>
		
		Public Overridable Property UserDirectory As System.String
			Get
				Return MyBase.GetSystemString(UserMetadata.ColumnNames.UserDirectory)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserMetadata.ColumnNames.UserDirectory, value) Then
					OnPropertyChanged(UserMetadata.PropertyNames.UserDirectory)
				End If
			End Set
		End Property		
		
#End Region	

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return UserMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As UserQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New UserQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As UserQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As UserQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As UserQuery

	End Class



	<Serializable()> _
	MustInherit Public Class esUserCollection
		Inherits esEntityCollection(Of User)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return UserMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "UserCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As UserQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New UserQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As UserQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New UserQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As UserQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, UserQuery))
		End Sub
		
		#End Region
						
		Private m_query As UserQuery
	End Class



	<Serializable> _
	MustInherit Public Class esUserQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return UserMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.Id, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property FirstName As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.FirstName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LastName As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.LastName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BldName As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.BldName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DeptID As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.DeptID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HomePhone As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.HomePhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BusNo As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.BusNo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UserName As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.UserName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Password As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.Password, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AccountType As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.AccountType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UserDirectory As esQueryItem
			Get
				Return New esQueryItem(Me, UserMetadata.ColumnNames.UserDirectory, esSystemType.String)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class User 
		Inherits esUser
		
	
		#Region "RoomCollectionByUserID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_RoomCollectionByUserID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.User.RoomCollectionByUserID_Delegate)
				map.PropertyName = "RoomCollectionByUserID"
				map.MyColumnName = "UserID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub RoomCollectionByUserID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New UserQuery(data.NextAlias())
			
			Dim mee As RoomQuery = If(data.You IsNot Nothing, TryCast(data.You, RoomQuery), New RoomQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.UserID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - TblRooms_FK01
		''' </summary>

		<XmlIgnore()> _ 
		Public Property RoomCollectionByUserID As RoomCollection 
		
			Get
				If Me._RoomCollectionByUserID Is Nothing Then
					Me._RoomCollectionByUserID = New RoomCollection()
					Me._RoomCollectionByUserID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("RoomCollectionByUserID", Me._RoomCollectionByUserID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._RoomCollectionByUserID.Query.Where(Me._RoomCollectionByUserID.Query.UserID.Equal(Me.Id))
							Me._RoomCollectionByUserID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._RoomCollectionByUserID.fks.Add(RoomMetadata.ColumnNames.UserID, Me.Id)
					End If
				End If

				Return Me._RoomCollectionByUserID
			End Get
			
			Set(ByVal value As RoomCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._RoomCollectionByUserID Is Nothing Then

					Me.RemovePostSave("RoomCollectionByUserID")
					Me._RoomCollectionByUserID = Nothing
					Me.OnPropertyChanged("RoomCollectionByUserID")

				End If
			End Set				
			
		End Property

		private _RoomCollectionByUserID As RoomCollection
		#End Region

		#Region "UserRoomCollectionByUserID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_UserRoomCollectionByUserID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.User.UserRoomCollectionByUserID_Delegate)
				map.PropertyName = "UserRoomCollectionByUserID"
				map.MyColumnName = "UserID"
				map.ParentColumnName = "ID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub UserRoomCollectionByUserID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New UserQuery(data.NextAlias())
			
			Dim mee As UserRoomQuery = If(data.You IsNot Nothing, TryCast(data.You, UserRoomQuery), New UserRoomQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.Id = mee.UserID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_UserRoom_User
		''' </summary>

		<XmlIgnore()> _ 
		Public Property UserRoomCollectionByUserID As UserRoomCollection 
		
			Get
				If Me._UserRoomCollectionByUserID Is Nothing Then
					Me._UserRoomCollectionByUserID = New UserRoomCollection()
					Me._UserRoomCollectionByUserID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("UserRoomCollectionByUserID", Me._UserRoomCollectionByUserID)
				
					If Not Me.Id.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._UserRoomCollectionByUserID.Query.Where(Me._UserRoomCollectionByUserID.Query.UserID.Equal(Me.Id))
							Me._UserRoomCollectionByUserID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._UserRoomCollectionByUserID.fks.Add(UserRoomMetadata.ColumnNames.UserID, Me.Id)
					End If
				End If

				Return Me._UserRoomCollectionByUserID
			End Get
			
			Set(ByVal value As UserRoomCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._UserRoomCollectionByUserID Is Nothing Then

					Me.RemovePostSave("UserRoomCollectionByUserID")
					Me._UserRoomCollectionByUserID = Nothing
					Me.OnPropertyChanged("UserRoomCollectionByUserID")

				End If
			End Set				
			
		End Property

		private _UserRoomCollectionByUserID As UserRoomCollection
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "RoomCollectionByUserID"
					coll = Me.RoomCollectionByUserID
					Exit Select
				Case "UserRoomCollectionByUserID"
					coll = Me.UserRoomCollectionByUserID
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "RoomCollectionByUserID", GetType(RoomCollection), New Room()))
			props.Add(new esPropertyDescriptor(Me, "UserRoomCollectionByUserID", GetType(UserRoomCollection), New UserRoom()))
			Return props
			
		End Function
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
			If Not Me._RoomCollectionByUserID Is Nothing Then
			
				Dim obj As Room
				For Each obj In Me._RoomCollectionByUserID
					If obj.es.IsAdded Then
						obj.UserID = Me.Id
					End If
				Next
			End If
			
			If Not Me._UserRoomCollectionByUserID Is Nothing Then
			
				Dim obj As UserRoom
				For Each obj In Me._UserRoomCollectionByUserID
					If obj.es.IsAdded Then
						obj.UserID = Me.Id
					End If
				Next
			End If
			
		End Sub
	End Class
	


	<Serializable> _
	Partial Public Class UserMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(UserMetadata.ColumnNames.Id, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = UserMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.HasDefault = True
			c.Default = "(newid())"
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.FirstName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.FirstName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.LastName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.LastName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.BldName, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.BldName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.DeptID, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.DeptID
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.HomePhone, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.HomePhone
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.BusNo, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.BusNo
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.UserName, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.UserName
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.Password, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.Password
			c.CharacterMaxLength = 25
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.AccountType, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.AccountType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserMetadata.ColumnNames.UserDirectory, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserMetadata.PropertyNames.UserDirectory
			c.CharacterMaxLength = 255
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As UserMetadata
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
			 Public Const FirstName As String = "FirstName"
			 Public Const LastName As String = "LastName"
			 Public Const BldName As String = "BldName"
			 Public Const DeptID As String = "DeptID"
			 Public Const HomePhone As String = "HomePhone"
			 Public Const BusNo As String = "BusNo"
			 Public Const UserName As String = "UserName"
			 Public Const Password As String = "Password"
			 Public Const AccountType As String = "AccountType"
			 Public Const UserDirectory As String = "UserDirectory"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const FirstName As String = "FirstName"
			 Public Const LastName As String = "LastName"
			 Public Const BldName As String = "BldName"
			 Public Const DeptID As String = "DeptID"
			 Public Const HomePhone As String = "HomePhone"
			 Public Const BusNo As String = "BusNo"
			 Public Const UserName As String = "UserName"
			 Public Const Password As String = "Password"
			 Public Const AccountType As String = "AccountType"
			 Public Const UserDirectory As String = "UserDirectory"
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
			SyncLock GetType(UserMetadata)
			
				If UserMetadata.mapDelegates Is Nothing Then
					UserMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If UserMetadata._meta Is Nothing Then
					UserMetadata._meta = New UserMetadata()
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
				meta.AddTypeMap("FirstName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("LastName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BldName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("DeptID", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("HomePhone", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("BusNo", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("UserName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Password", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("AccountType", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("UserDirectory", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "User"
				meta.Destination = "User"
				
				meta.spInsert = "proc_UserInsert"
				meta.spUpdate = "proc_UserUpdate"
				meta.spDelete = "proc_UserDelete"
				meta.spLoadAll = "proc_UserLoadAll"
				meta.spLoadByPrimaryKey = "proc_UserLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As UserMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
