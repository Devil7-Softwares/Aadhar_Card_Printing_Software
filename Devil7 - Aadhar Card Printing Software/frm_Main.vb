Imports DevExpress.Pdf

Public Class frm_Main

#Region "Variables"
    Private Password As String = ""
#End Region

#Region "Button Events"
    Private Sub btn_OpenPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_OpenPDF.ItemClick
        If dlg_OpenEaadhar.ShowDialog = DialogResult.OK Then
            OpenFile(dlg_OpenEaadhar.FileName)
        End If
    End Sub

    Private Sub view_PDF_PasswordRequested(sender As Object, e As PdfPasswordRequestedEventArgs) Handles view_PDF.PasswordRequested
        Dim dlg As New frm_Password
        If dlg.ShowDialog = DialogResult.OK Then
            Password = dlg.Password
            e.PasswordString = dlg.Password
        End If
    End Sub

    Private Sub btn_Print_Full_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_Full.ItemClick
        If view_PDF.IsDocumentOpened Then view_PDF.Print()
    End Sub

    Private Sub btn_Print_Card_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_Card.ItemClick
        If view_PDF.IsDocumentOpened Then
            Dim Full As Bitmap = view_PDF.CreateBitmap(1, 3506)
            Dim Front As Bitmap = Full.Clone(New Rectangle(118, 1930, 1012, 672), Full.PixelFormat)
            Dim Back As Bitmap = Full.Clone(New Rectangle(1156, 1930, 1012, 672), Full.PixelFormat)
            Dim dlg As New frm_ReportViewer(New SmallCard(New SmallCardItem(Front, Back)))
            dlg.Show()
        End If
    End Sub

    Private Sub btn_Print_FullCard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_FullCard.ItemClick
        If view_PDF.IsDocumentOpened Then
            Dim Full As Bitmap = view_PDF.CreateBitmap(1, 3506)
            Dim Front As Bitmap = Full.Clone(New Rectangle(118, 118, 1012, 2485), Full.PixelFormat)
            Dim Back As Bitmap = Full.Clone(New Rectangle(1156, 118, 1012, 2485), Full.PixelFormat)
            Dim dlg As New frm_ReportViewer(New BigCard(New BigCardItem(Front, Back)))
            dlg.Show()
        End If
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim Filename As String = My.Application.CommandLineArgs(0)
            If My.Computer.FileSystem.FileExists(Filename) Then
                OpenFile(Filename)
            End If
        End If
    End Sub
#End Region

#Region "Subs"
    Sub OpenFile(ByVal Filename As String)
        Try
            Using Processor As New PdfDocumentProcessor
                AddHandler Processor.PasswordRequested, AddressOf view_PDF_PasswordRequested
                Processor.LoadDocument(Filename)
                Processor.RemoveFormField("Signature1")

                Dim encryptionOptions As PdfEncryptionOptions = New PdfEncryptionOptions()
                encryptionOptions.PrintingPermissions = PdfDocumentPrintingPermissions.Allowed
                encryptionOptions.DataExtractionPermissions = PdfDocumentDataExtractionPermissions.Allowed
                encryptionOptions.ModificationPermissions = PdfDocumentModificationPermissions.Allowed
                encryptionOptions.InteractivityPermissions = PdfDocumentInteractivityPermissions.Allowed
                encryptionOptions.OwnerPasswordString = ""
                encryptionOptions.UserPasswordString = ""

                Using MS As New IO.MemoryStream
                    Processor.SaveDocument(MS, New PdfSaveOptions With {.EncryptionOptions = encryptionOptions})
                    If view_PDF.IsDocumentOpened Then view_PDF.CloseDocument()
                    view_PDF.LoadDocument(MS)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
#End Region

End Class