Imports System.Data.SqlClient

Public Class frmProduct
    Dim Is_Master_NewItem As Boolean
    Dim Is_Master_FirstFill As Boolean
    Dim DA_Master As SqlDataAdapter
    Dim DS_Master As DataSet
    Dim BS_Master As BindingSource = New BindingSource

    Public RwHandle_Details1 As Integer
    Public RW_Details1 As DataRow
    Dim DA_Details1 As SqlDataAdapter
    Dim DS_Details1 As DataSet
    Dim BS_Details1 As BindingSource = New BindingSource
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getForm_Load()
    End Sub

    Private Sub getForm_Load()

        getMaster_FillData()

        getDetails_FillData1()


        getFill_SearchLookUpEdit("Select CategoryID , CategoryName from tblCategory", "tblCategory", "CategoryID", "CategoryName", CategoryID_SearchLookUpEdit)


        'getFill_RepositoryItemSearchLookUpEdit(UserID_RepositoryItemSearchLookUpEdit1, "Select UserID , UserID As [#], (CAST(UserID As nvarchar(12)) + ' - ' + [AccArName]) as [ArName],[AccEnName]  from ACC_Users Where CompanyID ='" & Selected_CompanyID & "' and Isnull(IsActive,0) = 1", "UserID", "ArName", -1, 600, 300)

    End Sub
    Private Sub getMaster_FillData()

        Sql = "SELECT * from tblProduct where [ProductID] ='" & ProductID_TextEdit.EditValue & "'  "

        Dim CMD As SqlCommand = New SqlCommand(Sql, Conn)
        DA_Master = New SqlDataAdapter(CMD)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(DA_Master)
        DS_Master = New DataSet()
        DA_Master.Fill(DS_Master, "tblProduct")
        BS_Master.DataSource = DS_Master.Tables("tblProduct")
        BN_Master.BindingSource = BS_Master

        If (Is_Master_FirstFill = False) Then

            Me.ProductID_TextEdit.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "ProductID", True))
            Me.ProductName_TextEdit.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "ProductName", True))
            Me.ProductImage_TextEdit.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "ProductImage", True))
            Me.CategoryID_SearchLookUpEdit.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "CategoryID", True))
            Me.ProductCost_TextEdit.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "ProductCost", True))


            Me.Note_TextEdit1.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "Note", True))
            Me.Ck_IsActive.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "IsActive", True))

            Me.RecordAddedBy_TextEdit1.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "RecordAddedBy", True))
            Me.RecordUpdatedBy_TextEdit1.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "RecordUpdatedBy", True))
            Me.RecordEntryDate_TextEdit1.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "RecordEntryDate", True))
            Me.RecordUpdateDate_TextEdit1.DataBindings.Add(New Binding("EditValue", Me.BS_Master, "RecordUpdateDate", True))


            Is_Master_FirstFill = True
        End If

        If ProductID_TextEdit.Text = Nothing Then

            Try
                BN_Master.AddNewItem.PerformClick()

                RecordEntryDate_TextEdit1.EditValue = Date.Now
                RecordAddedBy_TextEdit1.EditValue = "Ali"

                'Dim strUID As String = Guid.NewGuid().ToString.ToUpper()
                'AttachmentUIDTextEdit.Text = strUID.ToUpper
                'ProductID_TextEdit.EditValue = strProductID
                Ck_IsActive.Checked = True

            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)

                Exit Sub
            End Try

        Else

        End If

    End Sub






    Private Function getMaster_SaveData() As Boolean



        If ProductName_TextEdit.Text = Nothing Then
            MessageBox.Show("Please insert Product name", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Try

            If ProductID_TextEdit.Text = Nothing Then


                ProductID_TextEdit.EditValue = getMax_ID_SQL("tblProduct", "ProductID", "")
            Else

                RecordUpdateDate_TextEdit1.EditValue = Date.Now
                RecordUpdatedBy_TextEdit1.EditValue = "Ali 2"


            End If




            Me.Validate()
            BS_Master.EndEdit()
            DA_Master.Update(DS_Master.Tables("tblProduct"))
            DS_Master.AcceptChanges()



        Catch ex As Exception

            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)

            Return False
        End Try
        Return True
    End Function

    Private Sub getDetails_FillData1()
        On Error Resume Next

        Sql = "SELECT  ROW_NUMBER() OVER (ORDER BY [ProductID]) AS [#],* from tblProduct  where isNull(RecordIsDeleted,0)=0 "


        Dim cmd As SqlCommand = New SqlCommand(Sql, Conn)
        DA_Details1 = New SqlDataAdapter(cmd)

        Dim cmdBuilder As SqlCommandBuilder = New SqlCommandBuilder(DA_Details1)
        DS_Details1 = New DataSet()
        DS_Details1.RemotingFormat = System.Data.SerializationFormat.Binary
        DS_Details1.EnforceConstraints = False
        DA_Details1.Fill(DS_Details1, "tblProduct")
        BS_Details1.DataSource = DS_Details1.Tables("tblProduct")
        GC_Details1.DataSource = BS_Details1



    End Sub

    Private Sub GV_Details1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GV_Details1.RowClick
        If GV_Details1.RowCount > 0 Then
            Dim RW As DataRow = GV_Details1.GetDataRow(GV_Details1.FocusedRowHandle)
            If Not RW Is Nothing Then
                ProductID_TextEdit.EditValue = RW("ProductID")
                getMaster_FillData()
            End If
        End If
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If getMaster_SaveData() = True Then
            getDetails_FillData1()
            MessageBox.Show("Data Succesfully Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNew.ItemClick
        ProductID_TextEdit.EditValue = Nothing
        getMaster_FillData()
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If MessageBox.Show("Are you sure you want to delete this Product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Dim RW As DataRow = GV_Details1.GetDataRow(GV_Details1.FocusedRowHandle)
            If Not RW Is Nothing Then

                Sql = "Update tblProduct set RecordIsDeleted='" & 1 & "',RecordDeleteDate=getdate() where ProductID='" & RW("ProductID") & "'"
                getExecuteNonQuery(Sql)
                getDetails_FillData1()

            End If
        End If
    End Sub
End Class