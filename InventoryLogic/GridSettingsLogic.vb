Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData
Imports System.IO

Public Class GridSettingsLogic
    Implements IDisposable

    Public Sub LoadGridSettings(ByVal usr As User, ByVal view As GridView)
        Try
            'Save grid layouts
            If Directory.Exists("\\hartville-srv2\Users\" & usr.UserDirectory & "\" & usr.UserName & "\Inventory Application Settings\") = False Then
                Directory.CreateDirectory("\\hartville-srv2\Users\" & usr.UserDirectory & "\" & usr.UserName & "\Inventory Application Settings\")
            End If

            view.RestoreLayoutFromXml("\\hartville-srv2\Users\" & usr.UserDirectory & "\" & usr.UserName & "\Inventory Application Settings\" & view.Name & ".xml")
        Catch ex As Exception
            'Ignore errors, this isn't a critical function
        End Try
    End Sub

    Public Sub SaveGridSettings(ByVal usr As User, ByVal view As GridView)
        Try
            'Save grid layouts
            If Directory.Exists("\\hartville-srv2\Users\" & usr.UserDirectory & "\" & usr.UserName & "\Inventory Application Settings\") = False Then
                Directory.CreateDirectory("\\hartville-srv2\Users\" & usr.UserDirectory & "\" & usr.UserName & "\Inventory Application Settings\")
            End If

            view.SaveLayoutToXml("\\hartville-srv2\Users\" & usr.UserDirectory & "\" & usr.UserName & "\Inventory Application Settings\" & view.Name & ".xml")
        Catch ex As Exception
            'Ignore errors, this isn't a critical function
        End Try
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
