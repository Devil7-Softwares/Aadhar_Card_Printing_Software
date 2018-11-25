Public Class frm_Main

#Region "Button Events"
    Private Sub btn_OpenPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_OpenPDF.ItemClick
        If dlg_OpenEaadhar.ShowDialog = DialogResult.OK Then
            view_PDF.LoadDocument(dlg_OpenEaadhar.FileName)
        End If
    End Sub
#End Region

End Class