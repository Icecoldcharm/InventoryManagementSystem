Imports InventoryData

Public Class TextbookReport

    Dim curItem As New Textbook

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        curItem = CType(GetCurrentRow(), Textbook)

        If curItem Is Nothing Then Exit Sub

        If curItem.Publisher = String.Empty Then
            lblPublisher1.Text = Nothing
            lblPublisher2.Text = Nothing
        Else
            lblPublisher1.Text = "Brand:"
        End If

        If curItem.CopyrightDate Is Nothing Then
            lblCopyright1.Text = Nothing
            lblCopyright2.Text = Nothing
        Else
            lblCopyright1.Text = "Model:"
        End If

        If curItem.DatePurchased Is Nothing Then
            lblDatePurchased1.Text = Nothing
            lblDatePurchased2.Text = Nothing
        Else
            lblDatePurchased1.Text = "Date Purchased:"
        End If

        If curItem.Condition = String.Empty Then
            lblCondition1.Text = Nothing
            lblCondition2.Text = Nothing
        Else
            lblCondition1.Text = "Condition:"
        End If

        If curItem.Isbn = String.Empty Then
            lblISBN1.Text = Nothing
            lblISBN2.Text = Nothing
        Else
            lblISBN1.Text = "ISBN:"
        End If

        If curItem.Cost Is Nothing Then
            lblCost1.Text = Nothing
            lblCost2.Text = Nothing
        Else
            lblCost1.Text = "Cost:"
        End If

        If curItem.Quantity Is Nothing Then
            lblQuantity1.Text = Nothing
            lblQuantity2.Text = Nothing
        Else
            lblQuantity1.Text = "Quantity:"
        End If

        If curItem.FundSource = String.Empty Then
            lblFundSource1.Text = Nothing
            lblFundSource2.Text = Nothing
        Else
            lblFundSource1.Text = "Fund Source:"
        End If

        If curItem.Cost Is Nothing Or curItem.Quantity Is Nothing Then
            lblTotal1.Text = Nothing
            lblTotal2.Text = Nothing
        Else
            lblTotal1.Text = "Total:"
            lblTotal2.Text = String.Format("{0:C}", (curItem.Cost * curItem.Quantity))
        End If

        If curItem.Description = String.Empty Then
            lblDescription1.Text = Nothing
            lblDescription2.Text = Nothing
        Else
            lblDescription1.Text = "Description:"
        End If

        If curItem.Comments = String.Empty Then
            lblComments1.Text = Nothing
            lblComments2.Text = Nothing
        Else
            lblComments1.Text = "Comments:"
        End If
    End Sub
End Class