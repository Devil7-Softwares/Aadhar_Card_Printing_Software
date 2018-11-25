Imports DevExpress.Pdf

Public Class frm_Main

#Region "Variables"
    Private Password As String = ""
#End Region

#Region "Button Events"
    Private Sub btn_OpenPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_OpenPDF.ItemClick
        If dlg_OpenEaadhar.ShowDialog = DialogResult.OK Then
            view_PDF.LoadDocument(dlg_OpenEaadhar.FileName)
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
#End Region

End Class