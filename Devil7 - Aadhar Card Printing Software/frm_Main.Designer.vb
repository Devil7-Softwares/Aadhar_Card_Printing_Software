﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_OpenPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print_Full = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print_Card = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print_FullCard = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_PDF = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Print = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.view_PDF = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.view_Print = New System.Windows.Forms.PrintPreviewControl()
        Me.dlg_OpenEaadhar = New System.Windows.Forms.OpenFileDialog()
        Me.dlg_SaveEaadhar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_OpenPDF, Me.btn_Print_Full, Me.btn_Print_Card, Me.btn_Print_FullCard, Me.btn_Save})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home})
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.Size = New System.Drawing.Size(667, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btn_OpenPDF
        '
        Me.btn_OpenPDF.Caption = "Open"
        Me.btn_OpenPDF.Id = 1
        Me.btn_OpenPDF.ImageOptions.SvgImage = CType(resources.GetObject("btn_OpenPDF.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_OpenPDF.Name = "btn_OpenPDF"
        ToolTipTitleItem4.Text = "Open"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Open EAadhar PDF Downloaded from UIDAI Website"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btn_OpenPDF.SuperTip = SuperToolTip4
        '
        'btn_Print_Full
        '
        Me.btn_Print_Full.Caption = "Full Size"
        Me.btn_Print_Full.Id = 2
        Me.btn_Print_Full.ImageOptions.SvgImage = CType(resources.GetObject("btn_Print_Full.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Print_Full.Name = "btn_Print_Full"
        ToolTipTitleItem5.Text = "Full Size Print"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Print Full Page Aadhar In the Downloaded Format"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btn_Print_Full.SuperTip = SuperToolTip5
        '
        'btn_Print_Card
        '
        Me.btn_Print_Card.Caption = "Small Card" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1 Sided)"
        Me.btn_Print_Card.Id = 3
        Me.btn_Print_Card.ImageOptions.SvgImage = CType(resources.GetObject("btn_Print_Card.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Print_Card.Name = "btn_Print_Card"
        ToolTipTitleItem6.Text = "Small Card (1 Sided)"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Print in Small ID Card Size. Both Front & Back Sides of Aadhar will Be Printed in" &
    " Same Page."
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.btn_Print_Card.SuperTip = SuperToolTip6
        '
        'btn_Print_FullCard
        '
        Me.btn_Print_FullCard.Caption = "Full Card" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(2 Sided)"
        Me.btn_Print_FullCard.Id = 4
        Me.btn_Print_FullCard.ImageOptions.SvgImage = CType(resources.GetObject("btn_Print_FullCard.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Print_FullCard.Name = "btn_Print_FullCard"
        ToolTipTitleItem7.Text = "Full Card Print (2 Sided)"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Print Full Size Aadhar in Front & Back Format." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: You must set the followin" &
    "g Custom Paper Size in your Printer Preferences & Enable two sided printing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "SIZE : 3.5"" x 8.25"""
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.btn_Print_FullCard.SuperTip = SuperToolTip7
        '
        'btn_Save
        '
        Me.btn_Save.AllowRightClickInMenu = False
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 5
        Me.btn_Save.ImageOptions.SvgImage = CType(resources.GetObject("btn_Save.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Save.Name = "btn_Save"
        ToolTipTitleItem8.Text = "Save"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Save EAadhar PDF Without Encryption, Digital Sign Image  & Downloaded Date Time"
        SuperToolTip8.Items.Add(ToolTipTitleItem8)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.btn_Save.SuperTip = SuperToolTip8
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_PDF, Me.rpg_Print})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_PDF
        '
        Me.rpg_PDF.ItemLinks.Add(Me.btn_OpenPDF)
        Me.rpg_PDF.ItemLinks.Add(Me.btn_Save)
        Me.rpg_PDF.Name = "rpg_PDF"
        Me.rpg_PDF.ShowCaptionButton = False
        Me.rpg_PDF.Text = "EAadhar PDF"
        '
        'rpg_Print
        '
        Me.rpg_Print.ItemLinks.Add(Me.btn_Print_Full)
        Me.rpg_Print.ItemLinks.Add(Me.btn_Print_Card)
        Me.rpg_Print.ItemLinks.Add(Me.btn_Print_FullCard)
        Me.rpg_Print.Name = "rpg_Print"
        Me.rpg_Print.Text = "Print"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(667, 31)
        '
        'view_PDF
        '
        Me.view_PDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.view_PDF.Location = New System.Drawing.Point(0, 0)
        Me.view_PDF.Name = "view_PDF"
        Me.view_PDF.Size = New System.Drawing.Size(394, 275)
        Me.view_PDF.TabIndex = 2
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 143)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.view_PDF)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.view_Print)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(667, 275)
        Me.SplitContainerControl1.SplitterPosition = 268
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'view_Print
        '
        Me.view_Print.Dock = System.Windows.Forms.DockStyle.Fill
        Me.view_Print.Location = New System.Drawing.Point(0, 0)
        Me.view_Print.Name = "view_Print"
        Me.view_Print.Size = New System.Drawing.Size(268, 275)
        Me.view_Print.TabIndex = 0
        '
        'dlg_OpenEaadhar
        '
        Me.dlg_OpenEaadhar.FileName = "*.pdf"
        Me.dlg_OpenEaadhar.Filter = "Adobe Portable Document Files (*.pdf)|*.pdf"
        Me.dlg_OpenEaadhar.FilterIndex = 0
        '
        'dlg_SaveEaadhar
        '
        Me.dlg_SaveEaadhar.FileName = "*.pdf"
        Me.dlg_SaveEaadhar.Filter = "Adobe Portable Document Files (*.pdf)|*.pdf"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 449)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frm_Main"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_PDF As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents view_PDF As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents view_Print As PrintPreviewControl
    Friend WithEvents btn_OpenPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dlg_OpenEaadhar As OpenFileDialog
    Friend WithEvents btn_Print_Full As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Print As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Print_Card As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Print_FullCard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dlg_SaveEaadhar As SaveFileDialog
End Class
