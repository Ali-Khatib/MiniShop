Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Utils.Behaviors
Imports DevExpress.XtraEditors


Partial Public Class frmMain
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnEmployees_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmployees.ItemClick
        Dim frm As New frmEmployee
        frm.ShowDialog()

    End Sub

    Private Sub btnDepartment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDepartment.ItemClick
        Dim frm As New frmDepartment
        frm.ShowDialog()
    End Sub

    Private Sub btnCity_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCity.ItemClick
        Dim frm As New frmCity
        frm.ShowDialog()
    End Sub

    Private Sub btnPosition_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPosition.ItemClick
        Dim frm As New frmPosition
        frm.ShowDialog()
    End Sub

    Private Sub btnCategory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCategory.ItemClick
        Dim frm As New frmCategory
        frm.ShowDialog()
    End Sub

    Private Sub btnProduct_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProduct.ItemClick
        Dim frm As New frmProduct
        frm.ShowDialog()
    End Sub


    Private Sub btnCustomer_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCustomer.ItemClick
        Dim frm As New frmCustomer
        frm.ShowDialog()
    End Sub

    Private Sub btnSupplier_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSupplier.ItemClick
        Dim frm As New frmSupplier
        frm.ShowDialog()
    End Sub


    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim frm As New frmVoucherStatus
        frm.ShowDialog()
    End Sub

    Private Sub btnSale_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSale.ItemClick
        Dim frm As New frmSale
        frm.ShowDialog()
    End Sub
End Class
