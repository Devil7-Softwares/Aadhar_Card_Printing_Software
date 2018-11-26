Imports DevExpress.Pdf
Imports DevExpress.XtraBars
Imports DevExpress.XtraPdfViewer

Public Class frm_Main

#Region "Variables"
    Private Password As String = ""
#End Region

#Region "Other Events"
    Private Sub view_PDF_DocumentChanged(sender As Object, e As PdfDocumentChangedEventArgs) Handles view_PDF.DocumentChanged
        If view_PDF.IsDocumentOpened Then
            btn_Save.Enabled = True
            rpg_Print.Enabled = True
        Else
            btn_Save.Enabled = False
            rpg_Print.Enabled = False
        End If
    End Sub

    Private Sub view_PDF_PasswordRequested(sender As Object, e As PdfPasswordRequestedEventArgs) Handles view_PDF.PasswordRequested
        Dim dlg As New frm_Password
        If dlg.ShowDialog = DialogResult.OK Then
            Password = dlg.Password
            e.PasswordString = dlg.Password
        End If
    End Sub
#End Region

#Region "Button Events"
    Private Sub btn_OpenPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_OpenPDF.ItemClick
        If dlg_OpenEaadhar.ShowDialog = DialogResult.OK Then
            OpenFile(dlg_OpenEaadhar.FileName)

            My.Settings.OpenCount += 1
            My.Settings.Save()
            If (My.Settings.OpenCount Mod 5) = 0 Then
                If Not My.Settings.FeedBackShown Then
                    Dim Result = MsgBox("Every single feedback from users mean a lot to us. Would you mind to spare a minute to write a feedback to us...?" & vbNewLine & vbNewLine & "Click 'No' to never show this dialog again.", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Feedback")
                    If Result = MsgBoxResult.Yes Then
                        Invoke(Sub() btn_Feedback.PerformClick())
                    ElseIf Result = MsgBoxResult.No Then
                        My.Settings.FeedBackShown = True
                        My.Settings.Save()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_Print_Full_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_Full.ItemClick
        If view_PDF.IsDocumentOpened Then view_PDF.Print()
    End Sub

    Private Sub btn_Print_Card_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_Card.ItemClick
        If view_PDF.IsDocumentOpened Then
            Dim Full As Bitmap = PrepImage(view_PDF.CreateBitmap(1, 3506))
            Dim Point As Point = GetTopLeftCorner(Full)
            Dim Front As Bitmap = Full.Clone(New Rectangle(Point.X, Point.Y + 1812, 1012, 672), Full.PixelFormat)
            Dim Back As Bitmap = Full.Clone(New Rectangle(Point.X + 1038, Point.Y + 1812, 1012, 672), Full.PixelFormat)
            Dim dlg As New frm_ReportViewer(New SmallCard(New SmallCardItem(Front, Back)))
            dlg.Show()
        End If
    End Sub

    Private Sub btn_Print_FullCard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_FullCard.ItemClick
        If view_PDF.IsDocumentOpened Then
            Dim Full As Bitmap = PrepImage(view_PDF.CreateBitmap(1, 3506))
            Dim Point As Point = GetTopLeftCorner(Full)
            Dim Front As Bitmap = Full.Clone(New Rectangle(Point.X, Point.Y, 1012, 2485), Full.PixelFormat)
            Dim Back As Bitmap = Full.Clone(New Rectangle(Point.X + 1038, Point.Y, 1012, 2485), Full.PixelFormat)
            Dim dlg As New frm_ReportViewer(New BigCard(New BigCardItem(Front, Back)))
            dlg.Show()
        End If
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If view_PDF.IsDocumentOpened Then
            If dlg_SaveEaadhar.ShowDialog = DialogResult.OK Then
                view_PDF.SaveDocument(dlg_SaveEaadhar.FileName)
            End If
        End If
    End Sub

    Private Sub btn_About_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_About.ItemClick
        frm_About.ShowDialog()
    End Sub

    Private Sub btn_SaveAs_Image_JPEG_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SaveAs_Image_JPEG.ItemClick
        dlg_SaveImage.Filter = "JPEG Image Files (*.jpeg)|*.jpeg"
        If dlg_SaveImage.ShowDialog = DialogResult.OK Then
            view_PDF.CreateBitmap(1, 3506).Save(dlg_SaveImage.FileName, Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub btn_SaveAs_Image_PNG_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SaveAs_Image_PNG.ItemClick
        dlg_SaveImage.Filter = "PNG Image Files (*.png)|*.png"
        If dlg_SaveImage.ShowDialog = DialogResult.OK Then
            view_PDF.CreateBitmap(1, 3506).Save(dlg_SaveImage.FileName, Imaging.ImageFormat.Png)
        End If
    End Sub

    Private Sub btn_SaveAs_Image_BMP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SaveAs_Image_BMP.ItemClick
        dlg_SaveImage.Filter = "Bitmap Image Files (*.bmp)|*.bmp"
        If dlg_SaveImage.ShowDialog = DialogResult.OK Then
            view_PDF.CreateBitmap(1, 3506).Save(dlg_SaveImage.FileName, Imaging.ImageFormat.Bmp)
        End If
    End Sub

    Private Sub btn_SaveAs_Image_GIF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SaveAs_Image_GIF.ItemClick
        dlg_SaveImage.Filter = "GIF Image Files (*.gif)|*.gif"
        If dlg_SaveImage.ShowDialog = DialogResult.OK Then
            view_PDF.CreateBitmap(1, 3506).Save(dlg_SaveImage.FileName, Imaging.ImageFormat.Gif)
        End If
    End Sub

    Private Sub btn_SaveAs_Image_TIFF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_SaveAs_Image_TIFF.ItemClick
        dlg_SaveImage.Filter = "TIFF Image Files (*.tiff)|*.tiff"
        If dlg_SaveImage.ShowDialog = DialogResult.OK Then
            view_PDF.CreateBitmap(1, 3506).Save(dlg_SaveImage.FileName, Imaging.ImageFormat.Tiff)
        End If
    End Sub

    Private Sub btn_Feedback_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Feedback.ItemClick
        Dim dlg As New frm_Feedback
        dlg.ShowDialog()
        My.Settings.FeedBackShown = True
        My.Settings.Save()
    End Sub
#End Region

#Region "Form Events"
    Private Sub frm_Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If My.Settings.Skin <> "" Then
                Theme.LookAndFeel.SetSkinStyle(My.Settings.Skin)
            End If
        Catch ex As Exception

        End Try
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim Filename As String = My.Application.CommandLineArgs(0)
            If My.Computer.FileSystem.FileExists(Filename) Then
                OpenFile(Filename)
            End If
        End If
    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            My.Settings.Skin = Me.GetSkin.Name
            My.Settings.Save()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Subs"
    Function PrepImage(ByVal Image As Bitmap) As Bitmap
        Dim G As Graphics = Graphics.FromImage(Image)
        G.FillRectangle(Brushes.White, New Rectangle(202, 758, 65, 710))
        G.Dispose()
        Return Image
    End Function

    Function GetTopLeftCorner(ByVal Image As Bitmap) As Point
        For x As Integer = 10 To 250
            For y As Integer = 10 To 250
                If Image.GetPixel(x, y).ToArgb = -16777216 Then Return New Point(x, y)
            Next
        Next
        Return New Point(0, 0)
    End Function

    Sub OpenFile(ByVal Filename As String)
        Try
            Using Processor As New PdfDocumentProcessor
                AddHandler Processor.PasswordRequested, AddressOf view_PDF_PasswordRequested
                Processor.LoadDocument(Filename)
                Processor.RemoveForm()
                Using MS As New IO.MemoryStream
                    Processor.SaveDocument(MS)
                    view_PDF.LoadDocument(New IO.MemoryStream(MS.ToArray))
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
#End Region

End Class