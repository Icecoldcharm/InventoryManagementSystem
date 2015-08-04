Imports EntitySpaces.Interfaces

Public Class Startup

    Private Shared connManagement As New esConnectionElement

    Public Shared Function Connect()
        Try
            esProviderFactory.Factory = New EntitySpaces.Loader.esDataProviderFactory()

            connManagement.Name = "inventory"
            connManagement.ConnectionString = String.Format("Password={0};Persist Security Info=True;User ID={1};Initial Catalog={2};Data Source={3}", "teacher", "teacher", "Inventory", " HR2S-Store1\HSSInventory")
            connManagement.Provider = "EntitySpaces.SqlClientProvider"
            connManagement.ProviderClass = "DataProvider"
            connManagement.SqlAccessType = esSqlAccessType.DynamicSQL
            connManagement.ProviderMetadataKey = "esDefault"
            connManagement.DatabaseVersion = "2005"

            esConfigSettings.ConnectionInfo.Connections.Add(connManagement)
            esConfigSettings.ConnectionInfo.Default = "inventory"

            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

End Class
