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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_OpenPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print_Full = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print_Card = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print_FullCard = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.Menu_SaveAs = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_SaveAs_Image = New DevExpress.XtraBars.BarButtonItem()
        Me.Menu_SaveAs_Image = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_SaveAs_Image_JPEG = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SaveAs_Image_PNG = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SaveAs_Image_BMP = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_About = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_PDF = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Print = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rp_Misc = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_About = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.view_PDF = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.dlg_OpenEaadhar = New System.Windows.Forms.OpenFileDialog()
        Me.dlg_SaveEaadhar = New System.Windows.Forms.SaveFileDialog()
        Me.dlg_SaveImage = New System.Windows.Forms.SaveFileDialog()
        Me.btn_SaveAs_Image_GIF = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SaveAs_Image_TIFF = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_SaveAs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_SaveAs_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_OpenPDF, Me.btn_Print_Full, Me.btn_Print_Card, Me.btn_Print_FullCard, Me.btn_Save, Me.btn_About, Me.btn_SaveAs_Image, Me.btn_SaveAs_Image_JPEG, Me.btn_SaveAs_Image_PNG, Me.btn_SaveAs_Image_BMP, Me.btn_SaveAs_Image_GIF, Me.btn_SaveAs_Image_TIFF})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 13
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home, Me.rp_Misc})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
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
        ToolTipTitleItem1.Text = "Open"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Open EAadhar PDF Downloaded from UIDAI Website"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btn_OpenPDF.SuperTip = SuperToolTip1
        '
        'btn_Print_Full
        '
        Me.btn_Print_Full.Caption = "Full Size"
        Me.btn_Print_Full.Id = 2
        Me.btn_Print_Full.ImageOptions.SvgImage = CType(resources.GetObject("btn_Print_Full.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Print_Full.Name = "btn_Print_Full"
        ToolTipTitleItem2.Text = "Full Size Print"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Print Full Page Aadhar In the Downloaded Format"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btn_Print_Full.SuperTip = SuperToolTip2
        '
        'btn_Print_Card
        '
        Me.btn_Print_Card.Caption = "Small Card" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1 Sided)"
        Me.btn_Print_Card.Id = 3
        Me.btn_Print_Card.ImageOptions.SvgImage = CType(resources.GetObject("btn_Print_Card.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Print_Card.Name = "btn_Print_Card"
        ToolTipTitleItem3.Text = "Small Card (1 Sided)"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Print in Small ID Card Size. Both Front & Back Sides of Aadhar will Be Printed in" &
    " Same Page."
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btn_Print_Card.SuperTip = SuperToolTip3
        '
        'btn_Print_FullCard
        '
        Me.btn_Print_FullCard.Caption = "Full Card" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(2 Sided)"
        Me.btn_Print_FullCard.Id = 4
        Me.btn_Print_FullCard.ImageOptions.SvgImage = CType(resources.GetObject("btn_Print_FullCard.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Print_FullCard.Name = "btn_Print_FullCard"
        ToolTipTitleItem4.Text = "Full Card Print (2 Sided)"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Print Full Size Aadhar in Front & Back Format." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Note: You must set the followin" &
    "g Custom Paper Size in your Printer Preferences & Enable two sided printing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "SIZE : 3.5"" x 8.25"""
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btn_Print_FullCard.SuperTip = SuperToolTip4
        '
        'btn_Save
        '
        Me.btn_Save.ActAsDropDown = True
        Me.btn_Save.AllowRightClickInMenu = False
        Me.btn_Save.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.DropDownControl = Me.Menu_SaveAs
        Me.btn_Save.Id = 5
        Me.btn_Save.ImageOptions.SvgImage = CType(resources.GetObject("btn_Save.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_Save.Name = "btn_Save"
        ToolTipTitleItem5.Text = "Save"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Save EAadhar PDF Without Encryption, Digital Sign Image  & Downloaded Date Time"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btn_Save.SuperTip = SuperToolTip5
        '
        'Menu_SaveAs
        '
        Me.Menu_SaveAs.ItemLinks.Add(Me.btn_SaveAs_Image)
        Me.Menu_SaveAs.Name = "Menu_SaveAs"
        Me.Menu_SaveAs.Ribbon = Me.RibbonControl
        '
        'btn_SaveAs_Image
        '
        Me.btn_SaveAs_Image.ActAsDropDown = True
        Me.btn_SaveAs_Image.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_SaveAs_Image.Caption = "Save As Image"
        Me.btn_SaveAs_Image.DropDownControl = Me.Menu_SaveAs_Image
        Me.btn_SaveAs_Image.Id = 7
        Me.btn_SaveAs_Image.ImageOptions.SvgImage = CType(resources.GetObject("btn_SaveAs_Image.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_SaveAs_Image.Name = "btn_SaveAs_Image"
        '
        'Menu_SaveAs_Image
        '
        Me.Menu_SaveAs_Image.ItemLinks.Add(Me.btn_SaveAs_Image_JPEG)
        Me.Menu_SaveAs_Image.ItemLinks.Add(Me.btn_SaveAs_Image_PNG)
        Me.Menu_SaveAs_Image.ItemLinks.Add(Me.btn_SaveAs_Image_BMP)
        Me.Menu_SaveAs_Image.ItemLinks.Add(Me.btn_SaveAs_Image_GIF)
        Me.Menu_SaveAs_Image.ItemLinks.Add(Me.btn_SaveAs_Image_TIFF)
        Me.Menu_SaveAs_Image.Name = "Menu_SaveAs_Image"
        Me.Menu_SaveAs_Image.Ribbon = Me.RibbonControl
        '
        'btn_SaveAs_Image_JPEG
        '
        Me.btn_SaveAs_Image_JPEG.Caption = "JPEG"
        Me.btn_SaveAs_Image_JPEG.Id = 8
        Me.btn_SaveAs_Image_JPEG.Name = "btn_SaveAs_Image_JPEG"
        '
        'btn_SaveAs_Image_PNG
        '
        Me.btn_SaveAs_Image_PNG.Caption = "PNG"
        Me.btn_SaveAs_Image_PNG.Id = 9
        Me.btn_SaveAs_Image_PNG.Name = "btn_SaveAs_Image_PNG"
        '
        'btn_SaveAs_Image_BMP
        '
        Me.btn_SaveAs_Image_BMP.Caption = "BMP"
        Me.btn_SaveAs_Image_BMP.Id = 10
        Me.btn_SaveAs_Image_BMP.Name = "btn_SaveAs_Image_BMP"
        '
        'btn_About
        '
        Me.btn_About.Caption = "About"
        Me.btn_About.Id = 6
        Me.btn_About.ImageOptions.SvgImage = CType(resources.GetObject("btn_About.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_About.Name = "btn_About"
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
        'rp_Misc
        '
        Me.rp_Misc.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_About})
        Me.rp_Misc.Name = "rp_Misc"
        Me.rp_Misc.Text = "Misc"
        '
        'rpg_About
        '
        Me.rpg_About.ItemLinks.Add(Me.btn_About)
        Me.rpg_About.Name = "rpg_About"
        Me.rpg_About.ShowCaptionButton = False
        Me.rpg_About.Text = "About && Support"
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
        Me.view_PDF.Location = New System.Drawing.Point(0, 143)
        Me.view_PDF.Name = "view_PDF"
        Me.view_PDF.Size = New System.Drawing.Size(667, 275)
        Me.view_PDF.TabIndex = 2
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
        'btn_SaveAs_Image_GIF
        '
        Me.btn_SaveAs_Image_GIF.Caption = "GIF"
        Me.btn_SaveAs_Image_GIF.Id = 11
        Me.btn_SaveAs_Image_GIF.Name = "btn_SaveAs_Image_GIF"
        '
        'btn_SaveAs_Image_TIFF
        '
        Me.btn_SaveAs_Image_TIFF.Caption = "TIFF"
        Me.btn_SaveAs_Image_TIFF.Id = 12
        Me.btn_SaveAs_Image_TIFF.Name = "btn_SaveAs_Image_TIFF"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 449)
        Me.Controls.Add(Me.view_PDF)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Devil7 - Aadhar Card Printing Software"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_SaveAs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_SaveAs_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_PDF As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents view_PDF As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents btn_OpenPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dlg_OpenEaadhar As OpenFileDialog
    Friend WithEvents btn_Print_Full As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Print As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Print_Card As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Print_FullCard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dlg_SaveEaadhar As SaveFileDialog
    Friend WithEvents btn_About As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rp_Misc As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_About As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Menu_SaveAs As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_SaveAs_Image As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_SaveAs_Image As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_SaveAs_Image_JPEG As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SaveAs_Image_PNG As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SaveAs_Image_BMP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dlg_SaveImage As SaveFileDialog
    Friend WithEvents btn_SaveAs_Image_GIF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SaveAs_Image_TIFF As DevExpress.XtraBars.BarButtonItem
End Class
