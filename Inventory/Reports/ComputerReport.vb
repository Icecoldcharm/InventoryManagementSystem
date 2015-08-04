Imports InventoryData

Public Class ComputerReport

    Dim curPC As New Computer

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        curPC = CType(GetCurrentRow(), Computer)

        If curPC Is Nothing Then Exit Sub

        If curPC.Brand = String.Empty Then
            lblBrand1.Text = Nothing
            lblBrand2.Text = Nothing
        Else
            lblBrand1.Text = "Brand:"
        End If

        If curPC.Model = String.Empty Then
            lblModel1.Text = Nothing
            lblModel2.Text = Nothing
        Else
            lblModel1.Text = "Model:"
        End If

        If curPC.Os = String.Empty Then
            lblOS1.Text = Nothing
            lblOS2.Text = Nothing
        Else
            lblOS1.Text = "OS:"
        End If

        If curPC.WinLicense = String.Empty Then
            lblLicense1.Text = Nothing
            lblLicense2.Text = Nothing
        Else
            lblLicense1.Text = "License:"
        End If

        If curPC.Ram = String.Empty Then
            lblRAM1.Text = Nothing
            lblRAM2.Text = Nothing
        Else
            lblRAM1.Text = "RAM:"
        End If

        If curPC.SerialNo = String.Empty Then
            lblSerial1.Text = Nothing
            lblSerial2.Text = Nothing
        Else
            lblSerial1.Text = "Serial:"
        End If

        If curPC.Cost Is Nothing Then
            lblCost1.Text = Nothing
            lblCost2.Text = Nothing
        Else
            lblCost1.Text = "Cost:"
        End If

        If curPC.FundSource = String.Empty Then
            lblFundSource1.Text = Nothing
            lblFundSource2.Text = Nothing
        Else
            lblFundSource1.Text = "Fund Source:"
        End If

        If curPC.FundSource = String.Empty Then
            lblFundSource1.Text = Nothing
            lblFundSource2.Text = Nothing
        Else
            lblFundSource1.Text = "Fund Source:"
        End If

        If curPC.Description = String.Empty Then
            lblDescription1.Text = Nothing
            lblDescription2.Text = Nothing
        Else
            lblDescription1.Text = "Description:"
        End If

        If curPC.Comments = String.Empty Then
            lblComments1.Text = Nothing
            lblComments2.Text = Nothing
        Else
            lblComments1.Text = "Comments:"
        End If
    End Sub
End Class