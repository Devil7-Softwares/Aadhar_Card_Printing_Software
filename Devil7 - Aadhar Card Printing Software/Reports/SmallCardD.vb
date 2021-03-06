﻿'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'=========================================================================='

Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting

Public Class SmallCardD

#Region "Subs"
    Public Sub New(ByVal Item As DoubleSideItem)
        InitializeComponent()
        AddHandler PrintingSystem.PageSettingsChanged, AddressOf Redraw
        AddHandler PrintingSystem.AfterMarginsChange, AddressOf Redraw
        ReportDataSource.DataSource = Item
    End Sub

    Private Sub Redraw(ByVal sender As Object, ByVal e As EventArgs)
        Dim pageSettings As XtraPageSettingsBase = DirectCast(sender, PrintingSystemBase).PageSettings
        PaperKind = pageSettings.PaperKind
        Landscape = pageSettings.Landscape
        Margins = New System.Drawing.Printing.Margins(pageSettings.LeftMargin, pageSettings.RightMargin, pageSettings.TopMargin, pageSettings.BottomMargin)
        CreateDocument()
    End Sub
#End Region

End Class