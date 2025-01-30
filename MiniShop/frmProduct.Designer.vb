<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduct
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNew = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GC_Details1 = New DevExpress.XtraGrid.GridControl()
        Me.GV_Details1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdcutID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRW_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductID_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ProductName_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CategoryID_SearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.ProductCost_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.Note_TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ProductImage_TextEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.Ck_IsActive = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.RecordUpdateDate_TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.RecordEntryDate_TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.RecordUpdatedBy_TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.RecordAddedBy_TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.BN_Master = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductID_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductName_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryID_SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCost_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Note_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductImage_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_IsActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RecordUpdateDate_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordEntryDate_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordUpdatedBy_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordAddedBy_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BN_Master, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BN_Master.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnSave, Me.btnNew, Me.btnDelete})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl.ShowQatLocationSelector = False
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(1022, 166)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.SvgImage = CType(resources.GetObject("btnSave.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnSave.Name = "btnSave"
        '
        'btnNew
        '
        Me.btnNew.Caption = "New"
        Me.btnNew.Id = 2
        Me.btnNew.ImageOptions.SvgImage = CType(resources.GetObject("btnNew.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnNew.Name = "btnNew"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 3
        Me.btnDelete.ImageOptions.SvgImage = CType(resources.GetObject("btnDelete.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnDelete.Name = "btnDelete"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNew, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDelete, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 615)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1022, 30)
        '
        'GC_Details1
        '
        Me.GC_Details1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GC_Details1.Location = New System.Drawing.Point(0, 166)
        Me.GC_Details1.MainView = Me.GV_Details1
        Me.GC_Details1.MenuManager = Me.RibbonControl
        Me.GC_Details1.Name = "GC_Details1"
        Me.GC_Details1.Size = New System.Drawing.Size(361, 449)
        Me.GC_Details1.TabIndex = 2
        Me.GC_Details1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Details1})
        '
        'GV_Details1
        '
        Me.GV_Details1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colProdcutID, Me.colRW_No})
        Me.GV_Details1.GridControl = Me.GC_Details1
        Me.GV_Details1.Name = "GV_Details1"
        Me.GV_Details1.OptionsBehavior.ReadOnly = True
        Me.GV_Details1.OptionsView.ColumnAutoWidth = False
        Me.GV_Details1.OptionsView.ShowDetailButtons = False
        Me.GV_Details1.OptionsView.ShowFooter = True
        Me.GV_Details1.OptionsView.ShowGroupPanel = False
        '
        'colProductName
        '
        Me.colProductName.Caption = "Name"
        Me.colProductName.FieldName = "ProductName"
        Me.colProductName.MinWidth = 25
        Me.colProductName.Name = "colProductName"
        Me.colProductName.OptionsColumn.AllowEdit = False
        Me.colProductName.Visible = True
        Me.colProductName.VisibleIndex = 2
        Me.colProductName.Width = 212
        '
        'colProdcutID
        '
        Me.colProdcutID.Caption = "ID"
        Me.colProdcutID.FieldName = "ProdcutID"
        Me.colProdcutID.MinWidth = 25
        Me.colProdcutID.Name = "colProdcutID"
        Me.colProdcutID.OptionsColumn.AllowEdit = False
        Me.colProdcutID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EmpID", "{0}")})
        Me.colProdcutID.Visible = True
        Me.colProdcutID.VisibleIndex = 1
        Me.colProdcutID.Width = 44
        '
        'colRW_No
        '
        Me.colRW_No.Caption = "#"
        Me.colRW_No.FieldName = "#"
        Me.colRW_No.MinWidth = 25
        Me.colRW_No.Name = "colRW_No"
        Me.colRW_No.OptionsColumn.AllowEdit = False
        Me.colRW_No.Visible = True
        Me.colRW_No.VisibleIndex = 0
        Me.colRW_No.Width = 47
        '
        'ProductID_TextEdit
        '
        Me.ProductID_TextEdit.Location = New System.Drawing.Point(451, 213)
        Me.ProductID_TextEdit.MenuManager = Me.RibbonControl
        Me.ProductID_TextEdit.Name = "ProductID_TextEdit"
        Me.ProductID_TextEdit.Properties.ReadOnly = True
        Me.ProductID_TextEdit.Size = New System.Drawing.Size(125, 22)
        Me.ProductID_TextEdit.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(428, 216)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(17, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "ID:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(407, 244)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 16)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Name:"
        '
        'ProductName_TextEdit
        '
        Me.ProductName_TextEdit.Location = New System.Drawing.Point(451, 241)
        Me.ProductName_TextEdit.MenuManager = Me.RibbonControl
        Me.ProductName_TextEdit.Name = "ProductName_TextEdit"
        Me.ProductName_TextEdit.Size = New System.Drawing.Size(253, 22)
        Me.ProductName_TextEdit.TabIndex = 7
        '
        'CategoryID_SearchLookUpEdit
        '
        Me.CategoryID_SearchLookUpEdit.Location = New System.Drawing.Point(451, 269)
        Me.CategoryID_SearchLookUpEdit.MenuManager = Me.RibbonControl
        Me.CategoryID_SearchLookUpEdit.Name = "CategoryID_SearchLookUpEdit"
        Me.CategoryID_SearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CategoryID_SearchLookUpEdit.Properties.NullText = "Insert Category"
        Me.CategoryID_SearchLookUpEdit.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.CategoryID_SearchLookUpEdit.Size = New System.Drawing.Size(253, 22)
        Me.CategoryID_SearchLookUpEdit.TabIndex = 11
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(389, 272)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Category:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(415, 300)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Cost:"
        '
        'ProductCost_TextEdit
        '
        Me.ProductCost_TextEdit.Location = New System.Drawing.Point(451, 297)
        Me.ProductCost_TextEdit.MenuManager = Me.RibbonControl
        Me.ProductCost_TextEdit.Name = "ProductCost_TextEdit"
        Me.ProductCost_TextEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.ProductCost_TextEdit.Properties.MaskSettings.Set("mask", "n")
        Me.ProductCost_TextEdit.Properties.UseMaskAsDisplayFormat = True
        Me.ProductCost_TextEdit.Size = New System.Drawing.Size(253, 22)
        Me.ProductCost_TextEdit.TabIndex = 13
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(414, 328)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "Note:"
        '
        'Note_TextEdit1
        '
        Me.Note_TextEdit1.Location = New System.Drawing.Point(451, 325)
        Me.Note_TextEdit1.MenuManager = Me.RibbonControl
        Me.Note_TextEdit1.Name = "Note_TextEdit1"
        Me.Note_TextEdit1.Size = New System.Drawing.Size(368, 22)
        Me.Note_TextEdit1.TabIndex = 23
        '
        'ProductImage_TextEdit
        '
        Me.ProductImage_TextEdit.Location = New System.Drawing.Point(825, 216)
        Me.ProductImage_TextEdit.MenuManager = Me.RibbonControl
        Me.ProductImage_TextEdit.Name = "ProductImage_TextEdit"
        Me.ProductImage_TextEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.ProductImage_TextEdit.Size = New System.Drawing.Size(136, 127)
        Me.ProductImage_TextEdit.TabIndex = 25
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(781, 219)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "Image:"
        '
        'Ck_IsActive
        '
        Me.Ck_IsActive.Location = New System.Drawing.Point(451, 353)
        Me.Ck_IsActive.MenuManager = Me.RibbonControl
        Me.Ck_IsActive.Name = "Ck_IsActive"
        Me.Ck_IsActive.Properties.Caption = "Active"
        Me.Ck_IsActive.Size = New System.Drawing.Size(94, 24)
        Me.Ck_IsActive.TabIndex = 27
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.RecordUpdateDate_TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.RecordEntryDate_TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.RecordUpdatedBy_TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.RecordAddedBy_TextEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(375, 523)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(586, 86)
        Me.GroupControl1.TabIndex = 28
        Me.GroupControl1.Text = "Audit_History"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(369, 62)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl15.TabIndex = 36
        Me.LabelControl15.Text = "Update Date:"
        '
        'RecordUpdateDate_TextEdit1
        '
        Me.RecordUpdateDate_TextEdit1.Location = New System.Drawing.Point(450, 59)
        Me.RecordUpdateDate_TextEdit1.MenuManager = Me.RibbonControl
        Me.RecordUpdateDate_TextEdit1.Name = "RecordUpdateDate_TextEdit1"
        Me.RecordUpdateDate_TextEdit1.Properties.ReadOnly = True
        Me.RecordUpdateDate_TextEdit1.Size = New System.Drawing.Size(125, 22)
        Me.RecordUpdateDate_TextEdit1.TabIndex = 35
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(380, 34)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl14.TabIndex = 34
        Me.LabelControl14.Text = "Date Entry:"
        '
        'RecordEntryDate_TextEdit1
        '
        Me.RecordEntryDate_TextEdit1.Location = New System.Drawing.Point(450, 31)
        Me.RecordEntryDate_TextEdit1.MenuManager = Me.RibbonControl
        Me.RecordEntryDate_TextEdit1.Name = "RecordEntryDate_TextEdit1"
        Me.RecordEntryDate_TextEdit1.Properties.ReadOnly = True
        Me.RecordEntryDate_TextEdit1.Size = New System.Drawing.Size(125, 22)
        Me.RecordEntryDate_TextEdit1.TabIndex = 33
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(18, 62)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl13.TabIndex = 32
        Me.LabelControl13.Text = "Update By:"
        '
        'RecordUpdatedBy_TextEdit1
        '
        Me.RecordUpdatedBy_TextEdit1.Location = New System.Drawing.Point(86, 59)
        Me.RecordUpdatedBy_TextEdit1.MenuManager = Me.RibbonControl
        Me.RecordUpdatedBy_TextEdit1.Name = "RecordUpdatedBy_TextEdit1"
        Me.RecordUpdatedBy_TextEdit1.Properties.ReadOnly = True
        Me.RecordUpdatedBy_TextEdit1.Size = New System.Drawing.Size(193, 22)
        Me.RecordUpdatedBy_TextEdit1.TabIndex = 31
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(36, 31)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(44, 16)
        Me.LabelControl12.TabIndex = 30
        Me.LabelControl12.Text = "Add By:"
        '
        'RecordAddedBy_TextEdit1
        '
        Me.RecordAddedBy_TextEdit1.Location = New System.Drawing.Point(86, 31)
        Me.RecordAddedBy_TextEdit1.MenuManager = Me.RibbonControl
        Me.RecordAddedBy_TextEdit1.Name = "RecordAddedBy_TextEdit1"
        Me.RecordAddedBy_TextEdit1.Properties.ReadOnly = True
        Me.RecordAddedBy_TextEdit1.Size = New System.Drawing.Size(193, 22)
        Me.RecordAddedBy_TextEdit1.TabIndex = 29
        '
        'BN_Master
        '
        Me.BN_Master.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BN_Master.CountItem = Me.BindingNavigatorCountItem
        Me.BN_Master.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BN_Master.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BN_Master.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BN_Master.Location = New System.Drawing.Point(361, 166)
        Me.BN_Master.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BN_Master.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BN_Master.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BN_Master.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BN_Master.Name = "BN_Master"
        Me.BN_Master.PositionItem = Me.BindingNavigatorPositionItem
        Me.BN_Master.Size = New System.Drawing.Size(661, 31)
        Me.BN_Master.TabIndex = 31
        Me.BN_Master.Text = "BindingNavigator1"
        Me.BN_Master.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 645)
        Me.Controls.Add(Me.BN_Master)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Ck_IsActive)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.ProductImage_TextEdit)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.Note_TextEdit1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.ProductCost_TextEdit)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.CategoryID_SearchLookUpEdit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.ProductName_TextEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ProductID_TextEdit)
        Me.Controls.Add(Me.GC_Details1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmProduct"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Product"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductID_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductName_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryID_SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCost_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Note_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductImage_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_IsActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.RecordUpdateDate_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordEntryDate_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordUpdatedBy_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordAddedBy_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BN_Master, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BN_Master.ResumeLayout(False)
        Me.BN_Master.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents GC_Details1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Details1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdcutID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductID_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProductName_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CategoryID_SearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ProductCost_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Note_TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductImage_TextEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Ck_IsActive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RecordUpdateDate_TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RecordEntryDate_TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RecordUpdatedBy_TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RecordAddedBy_TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BN_Master As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents colRW_No As DevExpress.XtraGrid.Columns.GridColumn
End Class
