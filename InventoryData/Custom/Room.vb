'===============================================================================
'                   EntitySpaces 2010 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2010.1.1122.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/13/2011 1:20:27 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class Room 
        Inherits esRoom

		Public Sub New()

        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("{0}{1}", Me.UpToBuildingByBldID.BldName, RoomNo)
        End Function

        Public ReadOnly Property BuildingName()
            Get
                Return UpToBuildingByBldID.BldName
            End Get
        End Property

        Public ReadOnly Property FullName()
            Get
                Return String.Format("{0}{1}", Me.UpToBuildingByBldID.BldName, RoomNo)
            End Get
        End Property

    End Class

End Namespace