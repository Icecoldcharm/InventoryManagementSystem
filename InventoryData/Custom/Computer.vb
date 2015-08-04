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

	Partial Public Class Computer 
		Inherits esComputer

        ''' <summary>
        ''' The total price of the line item (cost * quantity)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Total As Double
            Get
                If Cost IsNot Nothing And Quantity IsNot Nothing Then
                    Return (Cost * Quantity)
                Else
                    Return 0.0
                End If
            End Get
        End Property

		Public Sub New()

        End Sub

	End Class

End Namespace
