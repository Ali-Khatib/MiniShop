<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNew = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GC_Details1 = New DevExpress.XtraGrid.GridControl()
        Me.GV_Details1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmpName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRW_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmpID_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.EmpName_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.EmpAddress_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CityID_SearchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.EmpMobile_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.EmpPhone_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.DepartmentID_SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.PositionID_SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.EmpPassword_TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.Note_TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.EmpImage_PictureEdit = New DevExpress.XtraEditors.PictureEdit()
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
        Me.EmpStartDate_DateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.EmpEndDate_DateEdit = New DevExpress.XtraEditors.DateEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpID_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpName_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpAddress_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityID_SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpMobile_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpPhone_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentID_SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionID_SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpPassword_TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Note_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpImage_PictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_IsActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RecordUpdateDate_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordEntryDate_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordUpdatedBy_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordAddedBy_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BN_Master, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BN_Master.SuspendLayout()
        CType(Me.EmpStartDate_DateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpStartDate_DateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpEndDate_DateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpEndDate_DateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(26, 24, 26, 24)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnSave, Me.btnNew, Me.btnDelete})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.OptionsMenuMinWidth = 283
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl.ShowQatLocationSelector = False
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(876, 135)
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 500)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(876, 24)
        '
        'GC_Details1
        '
        Me.GC_Details1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GC_Details1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GC_Details1.Location = New System.Drawing.Point(0, 135)
        Me.GC_Details1.MainView = Me.GV_Details1
        Me.GC_Details1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GC_Details1.MenuManager = Me.RibbonControl
        Me.GC_Details1.Name = "GC_Details1"
        Me.GC_Details1.Size = New System.Drawing.Size(309, 365)
        Me.GC_Details1.TabIndex = 2
        Me.GC_Details1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Details1})
        '
        'GV_Details1
        '
        Me.GV_Details1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmpName, Me.colEmpPhone, Me.colEmpAddress, Me.colEmpID, Me.colRW_No})
        Me.GV_Details1.DetailHeight = 284
        Me.GV_Details1.GridControl = Me.GC_Details1
        Me.GV_Details1.Name = "GV_Details1"
        Me.GV_Details1.OptionsBehavior.ReadOnly = True
        Me.GV_Details1.OptionsEditForm.PopupEditFormWidth = 686
        Me.GV_Details1.OptionsView.ColumnAutoWidth = False
        Me.GV_Details1.OptionsView.ShowDetailButtons = False
        Me.GV_Details1.OptionsView.ShowFooter = True
        Me.GV_Details1.OptionsView.ShowGroupPanel = False
        '
        'colEmpName
        '
        Me.colEmpName.Caption = "Name"
        Me.colEmpName.FieldName = "EmpName"
        Me.colEmpName.MinWidth = 21
        Me.colEmpName.Name = "colEmpName"
        Me.colEmpName.OptionsColumn.AllowEdit = False
        Me.colEmpName.Visible = True
        Me.colEmpName.VisibleIndex = 2
        Me.colEmpName.Width = 182
        '
        'colEmpPhone
        '
        Me.colEmpPhone.Caption = "Phone"
        Me.colEmpPhone.FieldName = "EmpPhone"
        Me.colEmpPhone.MinWidth = 21
        Me.colEmpPhone.Name = "colEmpPhone"
        Me.colEmpPhone.Visible = True
        Me.colEmpPhone.VisibleIndex = 3
        Me.colEmpPhone.Width = 190
        '
        'colEmpAddress
        '
        Me.colEmpAddress.Caption = "Address"
        Me.colEmpAddress.FieldName = "EmpAddress"
        Me.colEmpAddress.MinWidth = 21
        Me.colEmpAddress.Name = "colEmpAddress"
        Me.colEmpAddress.Visible = True
        Me.colEmpAddress.VisibleIndex = 4
        Me.colEmpAddress.Width = 283
        '
        'colEmpID
        '
        Me.colEmpID.Caption = "ID"
        Me.colEmpID.FieldName = "EmpID"
        Me.colEmpID.MinWidth = 21
        Me.colEmpID.Name = "colEmpID"
        Me.colEmpID.OptionsColumn.AllowEdit = False
        Me.colEmpID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EmpID", "{0}")})
        Me.colEmpID.Visible = True
        Me.colEmpID.VisibleIndex = 1
        Me.colEmpID.Width = 38
        '
        'colRW_No
        '
        Me.colRW_No.Caption = "#"
        Me.colRW_No.FieldName = "#"
        Me.colRW_No.MinWidth = 21
        Me.colRW_No.Name = "colRW_No"
        Me.colRW_No.OptionsColumn.AllowEdit = False
        Me.colRW_No.Visible = True
        Me.colRW_No.VisibleIndex = 0
        Me.colRW_No.Width = 40
        '
        'EmpID_TextEdit
        '
        Me.EmpID_TextEdit.Location = New System.Drawing.Point(387, 173)
        Me.EmpID_TextEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpID_TextEdit.MenuManager = Me.RibbonControl
        Me.EmpID_TextEdit.Name = "EmpID_TextEdit"
        Me.EmpID_TextEdit.Properties.ReadOnly = True
        Me.EmpID_TextEdit.Size = New System.Drawing.Size(107, 20)
        Me.EmpID_TextEdit.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(367, 176)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "ID:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(349, 198)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Name:"
        '
        'EmpName_TextEdit
        '
        Me.EmpName_TextEdit.Location = New System.Drawing.Point(387, 196)
        Me.EmpName_TextEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpName_TextEdit.MenuManager = Me.RibbonControl
        Me.EmpName_TextEdit.Name = "EmpName_TextEdit"
        Me.EmpName_TextEdit.Size = New System.Drawing.Size(217, 20)
        Me.EmpName_TextEdit.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(338, 221)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Address:"
        '
        'EmpAddress_TextEdit
        '
        Me.EmpAddress_TextEdit.Location = New System.Drawing.Point(387, 219)
        Me.EmpAddress_TextEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpAddress_TextEdit.MenuManager = Me.RibbonControl
        Me.EmpAddress_TextEdit.Name = "EmpAddress_TextEdit"
        Me.EmpAddress_TextEdit.Size = New System.Drawing.Size(217, 20)
        Me.EmpAddress_TextEdit.TabIndex = 9
        '
        'CityID_SearchLookUpEdit
        '
        Me.CityID_SearchLookUpEdit.Location = New System.Drawing.Point(387, 241)
        Me.CityID_SearchLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CityID_SearchLookUpEdit.MenuManager = Me.RibbonControl
        Me.CityID_SearchLookUpEdit.Name = "CityID_SearchLookUpEdit"
        Me.CityID_SearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CityID_SearchLookUpEdit.Properties.NullText = "Insert City"
        Me.CityID_SearchLookUpEdit.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.CityID_SearchLookUpEdit.Size = New System.Drawing.Size(217, 20)
        Me.CityID_SearchLookUpEdit.TabIndex = 11
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.DetailHeight = 284
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 686
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(359, 244)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "City:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(345, 289)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Mobile:"
        '
        'EmpMobile_TextEdit
        '
        Me.EmpMobile_TextEdit.Location = New System.Drawing.Point(387, 287)
        Me.EmpMobile_TextEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpMobile_TextEdit.MenuManager = Me.RibbonControl
        Me.EmpMobile_TextEdit.Name = "EmpMobile_TextEdit"
        Me.EmpMobile_TextEdit.Size = New System.Drawing.Size(217, 20)
        Me.EmpMobile_TextEdit.TabIndex = 15
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(349, 266)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Phone:"
        '
        'EmpPhone_TextEdit
        '
        Me.EmpPhone_TextEdit.Location = New System.Drawing.Point(387, 264)
        Me.EmpPhone_TextEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpPhone_TextEdit.MenuManager = Me.RibbonControl
        Me.EmpPhone_TextEdit.Name = "EmpPhone_TextEdit"
        Me.EmpPhone_TextEdit.Size = New System.Drawing.Size(217, 20)
        Me.EmpPhone_TextEdit.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(321, 314)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Department:"
        '
        'DepartmentID_SearchLookUpEdit1
        '
        Me.DepartmentID_SearchLookUpEdit1.Location = New System.Drawing.Point(387, 310)
        Me.DepartmentID_SearchLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DepartmentID_SearchLookUpEdit1.MenuManager = Me.RibbonControl
        Me.DepartmentID_SearchLookUpEdit1.Name = "DepartmentID_SearchLookUpEdit1"
        Me.DepartmentID_SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DepartmentID_SearchLookUpEdit1.Properties.NullText = "Insert Department"
        Me.DepartmentID_SearchLookUpEdit1.Properties.PopupView = Me.GridView1
        Me.DepartmentID_SearchLookUpEdit1.Size = New System.Drawing.Size(217, 20)
        Me.DepartmentID_SearchLookUpEdit1.TabIndex = 17
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 284
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 686
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(339, 335)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl8.TabIndex = 20
        Me.LabelControl8.Text = "Position:"
        '
        'PositionID_SearchLookUpEdit1
        '
        Me.PositionID_SearchLookUpEdit1.Location = New System.Drawing.Point(387, 332)
        Me.PositionID_SearchLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PositionID_SearchLookUpEdit1.MenuManager = Me.RibbonControl
        Me.PositionID_SearchLookUpEdit1.Name = "PositionID_SearchLookUpEdit1"
        Me.PositionID_SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PositionID_SearchLookUpEdit1.Properties.NullText = "Insert Position"
        Me.PositionID_SearchLookUpEdit1.Properties.PopupView = Me.GridView2
        Me.PositionID_SearchLookUpEdit1.Size = New System.Drawing.Size(217, 20)
        Me.PositionID_SearchLookUpEdit1.TabIndex = 19
        '
        'GridView2
        '
        Me.GridView2.DetailHeight = 284
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsEditForm.PopupEditFormWidth = 686
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(330, 358)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl9.TabIndex = 22
        Me.LabelControl9.Text = "Password:"
        '
        'EmpPassword_TextEdit
        '
        Me.EmpPassword_TextEdit.Location = New System.Drawing.Point(387, 355)
        Me.EmpPassword_TextEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpPassword_TextEdit.MenuManager = Me.RibbonControl
        Me.EmpPassword_TextEdit.Name = "EmpPassword_TextEdit"
        Me.EmpPassword_TextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EmpPassword_TextEdit.Size = New System.Drawing.Size(217, 20)
        Me.EmpPassword_TextEdit.TabIndex = 21
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(355, 380)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "Note:"
        '
        'Note_TextEdit1
        '
        Me.Note_TextEdit1.Location = New System.Drawing.Point(387, 378)
        Me.Note_TextEdit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Note_TextEdit1.MenuManager = Me.RibbonControl
        Me.Note_TextEdit1.Name = "Note_TextEdit1"
        Me.Note_TextEdit1.Size = New System.Drawing.Size(437, 20)
        Me.Note_TextEdit1.TabIndex = 23
        '
        'EmpImage_PictureEdit
        '
        Me.EmpImage_PictureEdit.Location = New System.Drawing.Point(707, 176)
        Me.EmpImage_PictureEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpImage_PictureEdit.MenuManager = Me.RibbonControl
        Me.EmpImage_PictureEdit.Name = "EmpImage_PictureEdit"
        Me.EmpImage_PictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.EmpImage_PictureEdit.Size = New System.Drawing.Size(117, 103)
        Me.EmpImage_PictureEdit.TabIndex = 25
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(669, 178)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "Image:"
        '
        'Ck_IsActive
        '
        Me.Ck_IsActive.Location = New System.Drawing.Point(387, 401)
        Me.Ck_IsActive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Ck_IsActive.MenuManager = Me.RibbonControl
        Me.Ck_IsActive.Name = "Ck_IsActive"
        Me.Ck_IsActive.Properties.Caption = "Active"
        Me.Ck_IsActive.Size = New System.Drawing.Size(81, 20)
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
        Me.GroupControl1.Location = New System.Drawing.Point(321, 425)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(502, 70)
        Me.GroupControl1.TabIndex = 28
        Me.GroupControl1.Text = "Audit_History"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(316, 50)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl15.TabIndex = 36
        Me.LabelControl15.Text = "Update Date:"
        '
        'RecordUpdateDate_TextEdit1
        '
        Me.RecordUpdateDate_TextEdit1.Location = New System.Drawing.Point(386, 48)
        Me.RecordUpdateDate_TextEdit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RecordUpdateDate_TextEdit1.MenuManager = Me.RibbonControl
        Me.RecordUpdateDate_TextEdit1.Name = "RecordUpdateDate_TextEdit1"
        Me.RecordUpdateDate_TextEdit1.Properties.ReadOnly = True
        Me.RecordUpdateDate_TextEdit1.Size = New System.Drawing.Size(107, 20)
        Me.RecordUpdateDate_TextEdit1.TabIndex = 35
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(326, 28)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl14.TabIndex = 34
        Me.LabelControl14.Text = "Date Entry:"
        '
        'RecordEntryDate_TextEdit1
        '
        Me.RecordEntryDate_TextEdit1.Location = New System.Drawing.Point(386, 25)
        Me.RecordEntryDate_TextEdit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RecordEntryDate_TextEdit1.MenuManager = Me.RibbonControl
        Me.RecordEntryDate_TextEdit1.Name = "RecordEntryDate_TextEdit1"
        Me.RecordEntryDate_TextEdit1.Properties.ReadOnly = True
        Me.RecordEntryDate_TextEdit1.Size = New System.Drawing.Size(107, 20)
        Me.RecordEntryDate_TextEdit1.TabIndex = 33
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(15, 50)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl13.TabIndex = 32
        Me.LabelControl13.Text = "Update By:"
        '
        'RecordUpdatedBy_TextEdit1
        '
        Me.RecordUpdatedBy_TextEdit1.Location = New System.Drawing.Point(74, 48)
        Me.RecordUpdatedBy_TextEdit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RecordUpdatedBy_TextEdit1.MenuManager = Me.RibbonControl
        Me.RecordUpdatedBy_TextEdit1.Name = "RecordUpdatedBy_TextEdit1"
        Me.RecordUpdatedBy_TextEdit1.Properties.ReadOnly = True
        Me.RecordUpdatedBy_TextEdit1.Size = New System.Drawing.Size(165, 20)
        Me.RecordUpdatedBy_TextEdit1.TabIndex = 31
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(31, 25)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl12.TabIndex = 30
        Me.LabelControl12.Text = "Add By:"
        '
        'RecordAddedBy_TextEdit1
        '
        Me.RecordAddedBy_TextEdit1.Location = New System.Drawing.Point(74, 25)
        Me.RecordAddedBy_TextEdit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RecordAddedBy_TextEdit1.MenuManager = Me.RibbonControl
        Me.RecordAddedBy_TextEdit1.Name = "RecordAddedBy_TextEdit1"
        Me.RecordAddedBy_TextEdit1.Properties.ReadOnly = True
        Me.RecordAddedBy_TextEdit1.Size = New System.Drawing.Size(165, 20)
        Me.RecordAddedBy_TextEdit1.TabIndex = 29
        '
        'BN_Master
        '
        Me.BN_Master.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BN_Master.CountItem = Me.BindingNavigatorCountItem
        Me.BN_Master.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BN_Master.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BN_Master.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BN_Master.Location = New System.Drawing.Point(309, 135)
        Me.BN_Master.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BN_Master.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BN_Master.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BN_Master.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BN_Master.Name = "BN_Master"
        Me.BN_Master.PositionItem = Me.BindingNavigatorPositionItem
        Me.BN_Master.Size = New System.Drawing.Size(567, 22)
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 19)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(43, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
        '
        'EmpStartDate_DateEdit
        '
        Me.EmpStartDate_DateEdit.EditValue = Nothing
        Me.EmpStartDate_DateEdit.Location = New System.Drawing.Point(707, 287)
        Me.EmpStartDate_DateEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpStartDate_DateEdit.MenuManager = Me.RibbonControl
        Me.EmpStartDate_DateEdit.Name = "EmpStartDate_DateEdit"
        Me.EmpStartDate_DateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpStartDate_DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpStartDate_DateEdit.Size = New System.Drawing.Size(117, 20)
        Me.EmpStartDate_DateEdit.TabIndex = 32
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(647, 289)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl16.TabIndex = 33
        Me.LabelControl16.Text = "Start Date:"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(653, 314)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl17.TabIndex = 35
        Me.LabelControl17.Text = "End Date:"
        '
        'EmpEndDate_DateEdit
        '
        Me.EmpEndDate_DateEdit.EditValue = Nothing
        Me.EmpEndDate_DateEdit.Location = New System.Drawing.Point(707, 312)
        Me.EmpEndDate_DateEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmpEndDate_DateEdit.MenuManager = Me.RibbonControl
        Me.EmpEndDate_DateEdit.Name = "EmpEndDate_DateEdit"
        Me.EmpEndDate_DateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpEndDate_DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmpEndDate_DateEdit.Size = New System.Drawing.Size(117, 20)
        Me.EmpEndDate_DateEdit.TabIndex = 34
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 524)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.EmpEndDate_DateEdit)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.EmpStartDate_DateEdit)
        Me.Controls.Add(Me.BN_Master)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Ck_IsActive)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.EmpImage_PictureEdit)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.Note_TextEdit1)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.EmpPassword_TextEdit)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.PositionID_SearchLookUpEdit1)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.DepartmentID_SearchLookUpEdit1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.EmpMobile_TextEdit)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.EmpPhone_TextEdit)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.CityID_SearchLookUpEdit)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.EmpAddress_TextEdit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.EmpName_TextEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.EmpID_TextEdit)
        Me.Controls.Add(Me.GC_Details1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmEmployee"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Employee"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpID_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpName_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpAddress_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityID_SearchLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpMobile_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpPhone_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentID_SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionID_SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpPassword_TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Note_TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpImage_PictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.EmpStartDate_DateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpStartDate_DateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpEndDate_DateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpEndDate_DateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents GC_Details1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Details1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmpName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmpID_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmpName_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmpAddress_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CityID_SearchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmpMobile_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmpPhone_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DepartmentID_SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PositionID_SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmpPassword_TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Note_TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmpImage_PictureEdit As DevExpress.XtraEditors.PictureEdit
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
    Friend WithEvents EmpStartDate_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmpEndDate_DateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colRW_No As DevExpress.XtraGrid.Columns.GridColumn
End Class
