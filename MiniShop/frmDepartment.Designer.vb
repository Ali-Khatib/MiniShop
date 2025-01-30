<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartment))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNew = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GC_Details1 = New DevExpress.XtraGrid.GridControl()
        Me.GV_Details1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRW_No = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Details1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(557, 135)
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDelete, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 489)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(557, 24)
        '
        'GC_Details1
        '
        Me.GC_Details1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Details1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GC_Details1.Location = New System.Drawing.Point(0, 135)
        Me.GC_Details1.MainView = Me.GV_Details1
        Me.GC_Details1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GC_Details1.MenuManager = Me.RibbonControl
        Me.GC_Details1.Name = "GC_Details1"
        Me.GC_Details1.Size = New System.Drawing.Size(557, 354)
        Me.GC_Details1.TabIndex = 2
        Me.GC_Details1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Details1})
        '
        'GV_Details1
        '
        Me.GV_Details1.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV_Details1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_Details1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentName, Me.colDepartmentID, Me.colRW_No})
        Me.GV_Details1.DetailHeight = 284
        Me.GV_Details1.GridControl = Me.GC_Details1
        Me.GV_Details1.Name = "GV_Details1"
        Me.GV_Details1.OptionsEditForm.PopupEditFormWidth = 686
        Me.GV_Details1.OptionsView.ColumnAutoWidth = False
        Me.GV_Details1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Details1.OptionsView.ShowDetailButtons = False
        Me.GV_Details1.OptionsView.ShowFooter = True
        Me.GV_Details1.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentName
        '
        Me.colDepartmentName.Caption = "Department Name"
        Me.colDepartmentName.FieldName = "DepartmentName"
        Me.colDepartmentName.MinWidth = 21
        Me.colDepartmentName.Name = "colDepartmentName"
        Me.colDepartmentName.Visible = True
        Me.colDepartmentName.VisibleIndex = 1
        Me.colDepartmentName.Width = 341
        '
        'colDepartmentID
        '
        Me.colDepartmentID.Caption = "ID"
        Me.colDepartmentID.FieldName = "DepartmentID"
        Me.colDepartmentID.MinWidth = 21
        Me.colDepartmentID.Name = "colDepartmentID"
        Me.colDepartmentID.OptionsColumn.AllowEdit = False
        Me.colDepartmentID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EmpID", "{0}")})
        Me.colDepartmentID.Visible = True
        Me.colDepartmentID.VisibleIndex = 0
        Me.colDepartmentID.Width = 87
        '
        'colRW_No
        '
        Me.colRW_No.Caption = "#"
        Me.colRW_No.FieldName = "#"
        Me.colRW_No.MinWidth = 21
        Me.colRW_No.Name = "colRW_No"
        Me.colRW_No.OptionsColumn.AllowEdit = False
        Me.colRW_No.Width = 40
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 513)
        Me.Controls.Add(Me.GC_Details1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDepartment"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Department"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Details1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents GC_Details1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Details1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colRW_No As DevExpress.XtraGrid.Columns.GridColumn
End Class
