
'===============================================================================
'                   EntitySpaces 2010 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2010.1.1122.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/11/2011 1:20:58 PM
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
	' Encapsulates the 'UserGridLayout' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _ 
	<XmlType("UserGridLayout")> _ 
	<Table(Name:="UserGridLayout")> _ 
	Partial Public Class UserGridLayout 
		Inherits esUserGridLayout
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New UserGridLayout()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal userID As System.Guid)
			Dim obj As New UserGridLayout()
			obj.UserID = userID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal userID As System.Guid, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New UserGridLayout()
			obj.UserID = userID
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

		<Column(IsPrimaryKey: = false, CanBeNull: = false)> _
		Public Overrides Property Grid As System.String
			Get
				Return MyBase.Grid
			End Get
			Set
				MyBase.Grid = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = false)> _
		Public Overrides Property Layout As System.Byte()
			Get
				Return MyBase.Layout
			End Get
			Set
				MyBase.Layout = value
			End Set
		End Property
			
		#End Region
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<Serializable> _
	<XmlType("UserGridLayoutCollection")> _
	Partial Public Class UserGridLayoutCollection
		Inherits esUserGridLayoutCollection
		Implements IEnumerable(Of UserGridLayout)
	
		Public Function FindByPrimaryKey(ByVal userID As System.Guid) As UserGridLayout
			Return MyBase.SingleOrDefault(Function(e) e.UserID.HasValue AndAlso e.UserID.Value = userID)
		End Function

		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "UserGridLayoutQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class UserGridLayoutQuery 
		Inherits esUserGridLayoutQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "UserGridLayoutQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As UserGridLayoutQuery) As String
			Return UserGridLayoutQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As UserGridLayoutQuery
			Return DirectCast(UserGridLayoutQuery.SerializeHelper.FromXml(query, GetType(UserGridLayoutQuery)), UserGridLayoutQuery)
		End Operator

		#End Region
			
	End Class



	<Serializable()> _
	MustInherit Public Class esUserGridLayout
		Inherits esEntity
		Implements INotifyPropertyChanged
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal userID As System.Guid) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(userID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(userID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal userID As System.Guid) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(userID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(userID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal userID As System.Guid) As Boolean
		
			Dim query As New UserGridLayoutQuery()
			query.Where(query.UserID.Equal(userID))
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal userID As System.Guid) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("UserID", userID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to UserGridLayout.UserID
		' </summary>
		
		Public Overridable Property UserID As Nullable(Of System.Guid)
			Get
				Return MyBase.GetSystemGuid(UserGridLayoutMetadata.ColumnNames.UserID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Guid))
				If MyBase.SetSystemGuid(UserGridLayoutMetadata.ColumnNames.UserID, value) Then
					OnPropertyChanged(UserGridLayoutMetadata.PropertyNames.UserID)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to UserGridLayout.grid
		' </summary>
		
		Public Overridable Property Grid As System.String
			Get
				Return MyBase.GetSystemString(UserGridLayoutMetadata.ColumnNames.Grid)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(UserGridLayoutMetadata.ColumnNames.Grid, value) Then
					OnPropertyChanged(UserGridLayoutMetadata.PropertyNames.Grid)
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to UserGridLayout.layout
		' </summary>
		
		Public Overridable Property Layout As System.Byte()
			Get
				Return MyBase.GetSystemByteArray(UserGridLayoutMetadata.ColumnNames.Layout)
			End Get
			
			Set(ByVal value As System.Byte())
				If MyBase.SetSystemByteArray(UserGridLayoutMetadata.ColumnNames.Layout, value) Then
					OnPropertyChanged(UserGridLayoutMetadata.PropertyNames.Layout)
				End If
			End Set
		End Property		
		
#End Region	

#Region ".str() Properties"

		Public Overrides Sub SetProperties(values as IDictionary)

		Dim propertyName As String
			For Each propertyName In values.Keys
				Me.SetProperty(propertyName, values(propertyName))
			Next

		End Sub

		Public Overrides Sub SetProperty(name as string, value as object)

			Dim col As esColumnMetadata = Me.Meta.Columns.FindByPropertyName(name)
			If Not col Is Nothing Then

				If value Is Nothing OrElse value.GetType().ToString() = "System.String" Then

					' Use the strongly typed property
					Select Case name
												
						Case "UserID"
							Me.str().UserID = CType(value, string)
												
						Case "Grid"
							Me.str().Grid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "UserID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Guid" Then
								Me.UserID = CType(value, Nullable(Of System.Guid))
								OnPropertyChanged(UserGridLayoutMetadata.PropertyNames.UserID)
							End If
						
						Case "Layout"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte()" Then
								Me.Layout = CType(value, System.Byte())
								OnPropertyChanged(UserGridLayoutMetadata.PropertyNames.Layout)
							End If
						
					
						Case Else
						
					End Select
				End If

			Else If Me.ContainsColumn(name) Then
				Me.SetColumn(name, value)
			Else
				throw New Exception("SetProperty Error: '" + name + "' not found")
			End If	

		End Sub

		Public Function str() As esStrings
		
			If _esstrings Is Nothing Then
				_esstrings = New esStrings(Me)
			End If
			Return _esstrings
			
		End Function

		NotInheritable Public Class esStrings
		
			Public Sub New(ByVal entity As esUserGridLayout)
				Me.entity = entity
			End Sub				
		
	
			Public Property UserID As System.String 
				Get
					Dim data_ As Nullable(Of System.Guid) = entity.UserID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UserID = Nothing
					Else
						entity.UserID = new Guid(Value)
					End If
				End Set
			End Property
		  	
			Public Property Grid As System.String 
				Get
					Dim data_ As System.String = entity.Grid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Grid = Nothing
					Else
						entity.Grid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esUserGridLayout
		End Class
		
		<NonSerialized()> _	
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return UserGridLayoutMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As UserGridLayoutQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New UserGridLayoutQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As UserGridLayoutQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As UserGridLayoutQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        Private m_query As UserGridLayoutQuery

	End Class



	<Serializable()> _
	MustInherit Public Class esUserGridLayoutCollection
		Inherits esEntityCollection(Of UserGridLayout)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return UserGridLayoutMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "UserGridLayoutCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As UserGridLayoutQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New UserGridLayoutQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As UserGridLayoutQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New UserGridLayoutQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As UserGridLayoutQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, UserGridLayoutQuery))
		End Sub
		
		#End Region
						
		Private m_query As UserGridLayoutQuery
	End Class



	<Serializable> _
	MustInherit Public Class esUserGridLayoutQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return UserGridLayoutMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property UserID As esQueryItem
			Get
				Return New esQueryItem(Me, UserGridLayoutMetadata.ColumnNames.UserID, esSystemType.Guid)
			End Get
		End Property 
		
		Public ReadOnly Property Grid As esQueryItem
			Get
				Return New esQueryItem(Me, UserGridLayoutMetadata.ColumnNames.Grid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Layout As esQueryItem
			Get
				Return New esQueryItem(Me, UserGridLayoutMetadata.ColumnNames.Layout, esSystemType.ByteArray)
			End Get
		End Property 
		
	End Class


	
	Partial Public Class UserGridLayout 
		Inherits esUserGridLayout
		
	
		
		
	End Class
	


	<Serializable> _
	Partial Public Class UserGridLayoutMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(UserGridLayoutMetadata.ColumnNames.UserID, 0, GetType(System.Guid), esSystemType.Guid)	
			c.PropertyName = UserGridLayoutMetadata.PropertyNames.UserID
			c.IsInPrimaryKey = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserGridLayoutMetadata.ColumnNames.Grid, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = UserGridLayoutMetadata.PropertyNames.Grid
			c.CharacterMaxLength = 100
			m_columns.Add(c)
				
			c = New esColumnMetadata(UserGridLayoutMetadata.ColumnNames.Layout, 2, GetType(System.Byte()), esSystemType.ByteArray)	
			c.PropertyName = UserGridLayoutMetadata.PropertyNames.Layout
			c.CharacterMaxLength = 2147483647
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As UserGridLayoutMetadata
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
			 Public Const Grid As String = "grid"
			 Public Const Layout As String = "layout"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const UserID As String = "UserID"
			 Public Const Grid As String = "Grid"
			 Public Const Layout As String = "Layout"
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
			SyncLock GetType(UserGridLayoutMetadata)
			
				If UserGridLayoutMetadata.mapDelegates Is Nothing Then
					UserGridLayoutMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If UserGridLayoutMetadata._meta Is Nothing Then
					UserGridLayoutMetadata._meta = New UserGridLayoutMetadata()
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
				meta.AddTypeMap("Grid", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Layout", new esTypeMap("varbinary", "System.Byte()"))			
				
				
				 
				meta.Source = "UserGridLayout"
				meta.Destination = "UserGridLayout"
				
				meta.spInsert = "proc_UserGridLayoutInsert"
				meta.spUpdate = "proc_UserGridLayoutUpdate"
				meta.spDelete = "proc_UserGridLayoutDelete"
				meta.spLoadAll = "proc_UserGridLayoutLoadAll"
				meta.spLoadByPrimaryKey = "proc_UserGridLayoutLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As UserGridLayoutMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
