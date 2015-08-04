Imports DevExpress.XtraGrid.Views.Grid
Imports InventoryData

Public Class frmMisc

    Private Sub GridViewMisc_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridViewMisc.MouseDown
        Try
            Dim hi As New ViewInfo.GridHitInfo
            hi = GridViewMisc.CalcHitInfo(e.Location)

            Session.curMiscTech = Session.MiscTech(GridViewMisc.GetDataSourceRowIndex(hi.RowHandle))
            MiscBinding.DataSource = Session.curMiscTech
            navbarMisc.Enabled = True
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    ''' <summary>
    ''' Select the first item in the TechMisc grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectMiscTechItem(ByVal item As Integer)
        GridViewMisc.FocusedRowHandle = item
        If GridViewMisc.FocusedRowHandle >= 0 Then
            Session.curMiscTech = Session.MiscTech(GetSelectedHandleFromGrid(GridViewMisc))
            MiscBinding.DataSource = Session.curMiscTech
            navbarMisc.Enabled = True
        Else
            navbarMisc.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Returns the datasource index for the first selected row in the given gridview
    ''' </summary>
    ''' <param name="view"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetSelectedHandleFromGrid(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView) As Integer
        If view.SelectedRowsCount = 0 Then
            Return Nothing
        End If

        Dim rowHandle As Integer = view.GetSelectedRows()(0)

        Return view.GetDataSourceRowIndex(rowHandle)
    End Function

    Public Sub AddMiscTech()
        Dim misc As New MiscTechnology
        misc.Id = Guid.NewGuid
        misc.RoomID = Session.curRoom.Id
        Session.MiscTech.Add(misc)
        Session.Context.MiscTechnologies.AddObject(misc)
        Session.Context.SaveChanges()
        misc = Nothing

        'Display the new item
        SelectMiscTechItem(GridViewMisc.RowCount - 1)
    End Sub

    Private Sub GridViewMisc_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewMisc.CustomUnboundColumnData
        'Update the software total column
        If e.Column.FieldName = "colMiscTotal" And e.IsGetData Then
            If (Session.MiscTech.Count - 1) >= e.ListSourceRowIndex Then
                e.Value = Session.MiscTech(e.ListSourceRowIndex).Total
            End If
        End If
    End Sub

    Private Sub frmMisc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Session.MainForm
    End Sub

    Private Sub picMiscConditionHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMiscConditionHelp.Click
        Dim InformationWindow As New FrmInformation

        InformationWindow.Title = "Condition Information"
        InformationWindow.LoadMessage("Condition.rtf")
        InformationWindow.ShowDialog()
    End Sub
End Class