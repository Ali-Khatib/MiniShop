Imports System.Data.SqlClient

Public Class frmPosition

    Public RwHandle_Details1 As Integer
    Public RW_Details1 As DataRow
    Dim DA_Details1 As SqlDataAdapter
    Dim DS_Details1 As DataSet
    Dim BS_Details1 As BindingSource = New BindingSource
    Private Sub frmPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getForm_Load()
    End Sub

    Private Sub getForm_Load()


        getDetails_FillData1()


        'getFill_RepositoryItemSearchLookUpEdit(UserID_RepositoryItemSearchLookUpEdit1, "SELECT UserID ,UserID AS [#],(CAST(UserID AS nvarchar(12)) + ' - ' + [AccArName]) as [ArName],[AccEnName]  from ACC_Users Where CompanyID ='" & Selected_CompanyID & "' and Isnull(IsActive,0) = 1", "UserID", "ArName", -1, 600, 300)

    End Sub


    Private Sub getDetails_FillData1()
        On Error Resume Next

        Sql = "SELECT  ROW_NUMBER() OVER (ORDER BY [PositionID]) AS [#],* from tblPosition   "


        Dim cmd As SqlCommand = New SqlCommand(Sql, Conn)
        DA_Details1 = New SqlDataAdapter(cmd)

        Dim cmdBuilder As SqlCommandBuilder = New SqlCommandBuilder(DA_Details1)
        DS_Details1 = New DataSet()
        DS_Details1.RemotingFormat = System.Data.SerializationFormat.Binary
        DS_Details1.EnforceConstraints = False
        DA_Details1.Fill(DS_Details1, "tblPosition")
        BS_Details1.DataSource = DS_Details1.Tables("tblPosition")
        GC_Details1.DataSource = BS_Details1



    End Sub



    Private Sub getSave_Details1()


        Try

            GV_Details1.PostEditor()


            Me.Validate()
            BS_Details1.EndEdit()
            DA_Details1.Update(DS_Details1.Tables("tblPosition"))

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        getSave_Details1()
        getDetails_FillData1()

    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If GV_Details1.RowCount > 0 Then
            GV_Details1.DeleteSelectedRows()
        End If
    End Sub
End Class