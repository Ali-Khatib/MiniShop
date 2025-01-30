Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns

Module modFunctions
    Public Sql As String = Nothing
    Public Conn As New SqlConnection(My.Settings.MyConnection)
    Public Function getReturnData(ByVal sql As String, ByRef ds As DataSet) As Boolean
        Dim dt As New SqlDataAdapter(sql, Conn)
        ds = New DataSet
        Dim cmd = Conn.CreateCommand()
        cmd.CommandTimeout = 0
        Try
            dt.SelectCommand.CommandTimeout = 0
            ds.EnforceConstraints = False
                dt.Fill(ds)
            Catch ex As Exception
                Return False
            Finally
                Conn.Close()
            End Try

        Return True
    End Function
    Public Function getMax_ID_SQL(ByVal tblName As String, ByVal tblID As String, ByVal SQlStr As String) As String
        Dim ds As New DataSet
        Dim txtMaxID As String = ""
        Sql = "select ISNULL(Max(" & tblID & "),0 )+1  from " & tblName & " "
        Sql += SQlStr
        If (getReturnData(Sql, ds) = True) Then
            If (ds.Tables(0).Rows.Count > 0) Then
                txtMaxID = ds.Tables(0).Rows(0)(0).ToString
                If (txtMaxID = Nothing Or txtMaxID = "0" Or IsNumeric(txtMaxID) = False) Then
                    txtMaxID = "1"
                End If
            Else
                txtMaxID = "1"
            End If
        Else
            txtMaxID = "Null"
            'DevExpress.XtraEditors.XtraMessageBox.Show("You Can't Insert Data !", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return txtMaxID
            Exit Function
        End If
        ds.Dispose()
        Return txtMaxID
    End Function




    Public Function getFill_SearchLookUpEdit(ByVal sql As String, ByVal tblName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByRef ListName As DevExpress.XtraEditors.SearchLookUpEdit, Optional strWidth As Integer = 450, Optional strHeight As Integer = 300, Optional ByVal IsUseCachedDatatable As Boolean = False, Optional ByRef DV_CachedDatatable As DataView = Nothing, Optional IsHideOnly_ValueMember As Boolean = True, Optional ByVal IsKeep_ColumnWidth As Boolean = False) As String
        Try
            Dim memoEdit As New RepositoryItemMemoEdit
            Dim txtAmount As New RepositoryItemTextEdit


            memoEdit.WordWrap = True
            memoEdit.AutoHeight = True
            Dim ds As New DataSet

            If (getReturnDataTabels(sql, ds, tblName) = True) Then
                With ListName
                    .Properties.DataSource = ds.Tables(0)
                    .Properties.DisplayMember = DisplayMember
                    .Properties.ValueMember = ValueMember
                    .Properties.ViewType = GridLookUpViewType.GridView
                    .Properties.View.OptionsView.ShowAutoFilterRow = True
                    .Properties.NullText = Nothing
                    .Properties.View.OptionsView.RowAutoHeight = True
                    .Properties.BestFitMode = BestFitMode.None

                    .Properties.PopupFormSize = New Size(strWidth, strHeight)

                    .Properties.View.PopulateColumns(.Properties.DataSource)

                    .Properties.AutoHeight = True

                End With

            Else
                Return "0"
                Exit Function
            End If
        Catch ex As System.Exception

        End Try

        Return "1"
    End Function



    Public Function getReturnDataTabels(ByVal sql As String, ByRef ds As DataSet, ByVal tabelName As String) As Boolean


        Try
            Dim dt As New SqlDataAdapter(sql, Conn)

            ds.Clear()

            Dim cmd = Conn.CreateCommand()
            cmd.CommandTimeout = 0
            ds.EnforceConstraints = False
            dt.SelectCommand.CommandTimeout = 0

            dt.Fill(ds, tabelName)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Return Data Faild ,Please Try Again ! ", "Return Data Tables", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False
        Finally
            Conn.Close()
        End Try

        Return True
    End Function


    Public Function getExecuteNonQuery(ByVal sql As String) As Boolean


        Try
            If Conn.State = ConnectionState.Open Then

                ' Close the connection
                Conn.Close()
            End If

            Dim cmd As New SqlCommand(sql, Conn)
            Conn.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
            DevExpress.XtraEditors.XtraMessageBox.Show("Execute Data Faild ,Please Try Again ! ", "Execute Data ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Finally
            Conn.Close()
            End Try

        Return True
    End Function
End Module
