Partial Public Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnEmployees = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSettings = New DevExpress.XtraBars.BarSubItem()
        Me.btnDepartment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCity = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPosition = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCategory = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSupplier = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaleDetails = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSale = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(35, 37, 35, 37)
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.btnEmployees, Me.btnSettings, Me.btnDepartment, Me.btnCity, Me.btnPosition, Me.btnCategory, Me.btnProduct, Me.BarButtonItem1, Me.BarButtonItem2, Me.btnCustomer, Me.btnSupplier, Me.btnSaleDetails, Me.BarButtonItem3, Me.BarButtonItem4, Me.btnSale})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.ribbonControl1.MaxItemId = 24
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.OptionsMenuMinWidth = 385
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl1.ShowQatLocationSelector = False
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(1060, 166)
        Me.ribbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'btnEmployees
        '
        Me.btnEmployees.Caption = "Employees"
        Me.btnEmployees.Id = 1
        Me.btnEmployees.ImageOptions.SvgImage = CType(resources.GetObject("btnEmployees.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnEmployees.Name = "btnEmployees"
        '
        'btnSettings
        '
        Me.btnSettings.Caption = "Settings"
        Me.btnSettings.Id = 3
        Me.btnSettings.ImageOptions.SvgImage = CType(resources.GetObject("btnSettings.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSettings.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDepartment), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCity), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPosition), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCategory), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.btnSettings.Name = "btnSettings"
        '
        'btnDepartment
        '
        Me.btnDepartment.Caption = "Department"
        Me.btnDepartment.Id = 4
        Me.btnDepartment.ImageOptions.SvgImage = CType(resources.GetObject("btnDepartment.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnDepartment.Name = "btnDepartment"
        '
        'btnCity
        '
        Me.btnCity.Caption = "City"
        Me.btnCity.Id = 5
        Me.btnCity.ImageOptions.SvgImage = CType(resources.GetObject("btnCity.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCity.Name = "btnCity"
        '
        'btnPosition
        '
        Me.btnPosition.Caption = "Position"
        Me.btnPosition.Id = 6
        Me.btnPosition.ImageOptions.SvgImage = CType(resources.GetObject("btnPosition.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnPosition.Name = "btnPosition"
        '
        'btnCategory
        '
        Me.btnCategory.Caption = "Category"
        Me.btnCategory.Id = 7
        Me.btnCategory.ImageOptions.SvgImage = CType(resources.GetObject("btnCategory.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCategory.Name = "btnCategory"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Voucher Status"
        Me.BarButtonItem4.Id = 21
        Me.BarButtonItem4.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'btnProduct
        '
        Me.btnProduct.Caption = "Product"
        Me.btnProduct.Id = 8
        Me.btnProduct.ImageOptions.SvgImage = CType(resources.GetObject("btnProduct.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnProduct.Name = "btnProduct"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 12
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 13
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'btnCustomer
        '
        Me.btnCustomer.Caption = "Customer"
        Me.btnCustomer.Id = 17
        Me.btnCustomer.ImageOptions.SvgImage = CType(resources.GetObject("btnCustomer.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCustomer.Name = "btnCustomer"
        '
        'btnSupplier
        '
        Me.btnSupplier.Caption = "Supplier"
        Me.btnSupplier.Id = 18
        Me.btnSupplier.ImageOptions.SvgImage = CType(resources.GetObject("btnSupplier.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSupplier.Name = "btnSupplier"
        '
        'btnSaleDetails
        '
        Me.btnSaleDetails.Caption = "Sale Details"
        Me.btnSaleDetails.Id = 19
        Me.btnSaleDetails.ImageOptions.SvgImage = CType(resources.GetObject("btnSaleDetails.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSaleDetails.Name = "btnSaleDetails"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Voucher Status"
        Me.BarButtonItem3.Id = 20
        Me.BarButtonItem3.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnSale
        '
        Me.btnSale.Caption = "Sale"
        Me.btnSale.Id = 22
        Me.btnSale.ImageOptions.SvgImage = CType(resources.GetObject("btnSale.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSale.Name = "btnSale"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ribbonPage1"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnSettings)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnEmployees)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnProduct)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnCustomer)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnSupplier)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnSale)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.btnSaleDetails)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 671)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Mini Shop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnEmployees As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSettings As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnDepartment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCity As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPosition As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCategory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSupplier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaleDetails As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSale As DevExpress.XtraBars.BarButtonItem
End Class
