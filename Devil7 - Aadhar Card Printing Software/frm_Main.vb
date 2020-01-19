Imports DevExpress.Pdf
Imports DevExpress.XtraBars
Imports DevExpress.XtraPdfViewer

Public Class frm_Main

#Region "Variables"
    Private Password As String = ""

    Private Const AadharPerSideWidth As Integer = 1091
    Private Const AadharCenterExclusion As Integer = 33
    Private Const AadharSmallHeight As Integer = 692

    Private MaskingAreas As Rectangle() = {
        New Rectangle(230, 1180, 40, 715), 'Downloaded & issue date in big card
        New Rectangle(150, 2560, 40, 340), 'Downloaded date in small card left side
        New Rectangle(1100, 2600, 40, 280) 'Issued date in small card right side
        }
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

    Private Sub btn_Print_CardS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_CardS.ItemClick
        If view_PDF.IsDocumentOpened Then
            Dim Full As Bitmap = PrepImage(view_PDF.CreateBitmap(1, 3506))
            Dim Point_Top As Point = GetTopLeftCorner(Full)
            Dim Point_Bottom As Point = GetBottomLeftCorner(Full)
            Dim Height As Single = Point_Bottom.Y - Point_Top.Y
            Dim Front As Bitmap = Full.Clone(New Rectangle(Point_Top.X, Point_Top.Y + (Height - AadharSmallHeight), AadharPerSideWidth, AadharSmallHeight), Full.PixelFormat)
            Dim Back As Bitmap = Full.Clone(New Rectangle(Point_Top.X + AadharPerSideWidth + AadharCenterExclusion, Point_Top.Y + (Height - AadharSmallHeight), AadharPerSideWidth, AadharSmallHeight), Full.PixelFormat)
            PrepImage({Front, Back})
            Dim dlg As New frm_ReportViewer(New SmallCardS(New SingleSideItem(Front, Back)))
            dlg.Show()
        End If
    End Sub

    Private Sub btn_Print_FullCard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_FullCard.ItemClick
        If view_PDF.IsDocumentOpened Then
            Dim Full As Bitmap = PrepImage(view_PDF.CreateBitmap(1, 3506))

            Dim Point_Top As Point = GetTopLeftCorner(Full)
            Dim Point_Bottom As Point = GetBottomLeftCorner(Full)
            Dim Height As Single = Point_Bottom.Y - Point_Top.Y
            Dim Width As Single = AadharPerSideWidth
            Dim Size As New Size(Width, Height)
            Dim Rect_Front As New Rectangle(Point_Top, Size)
            Dim Rect_Back As New Rectangle(New Point(Point_Top.X + AadharPerSideWidth + AadharCenterExclusion, Point_Top.Y), Size)

            Dim Front As Bitmap = Full.Clone(Rect_Front, Full.PixelFormat)
            Dim Back As Bitmap = Full.Clone(Rect_Back, Full.PixelFormat)
            Dim dlg As New frm_ReportViewer(New BigCard(New DoubleSideItem(Front, Back)))
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

    Private Sub btn_Print_CardD_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Print_CardD.ItemClick
        If view_PDF.IsDocumentOpened Then
            Dim Full As Bitmap = PrepImage(view_PDF.CreateBitmap(1, 3506))
            Dim Point_Top As Point = GetTopLeftCorner(Full)
            Dim Point_Bottom As Point = GetBottomLeftCorner(Full)
            Dim Height As Single = Point_Bottom.Y - Point_Top.Y
            Dim Front As Bitmap = Full.Clone(New Rectangle(Point_Top.X, Point_Top.Y + (Height - AadharSmallHeight), AadharPerSideWidth, AadharSmallHeight), Full.PixelFormat)
            Dim Back As Bitmap = Full.Clone(New Rectangle(Point_Top.X + AadharPerSideWidth + AadharCenterExclusion, Point_Top.Y + (Height - AadharSmallHeight), AadharPerSideWidth, AadharSmallHeight), Full.PixelFormat)
            PrepImage({Front, Back})
            Dim dlg As New frm_ReportViewer(New SmallCardD(New DoubleSideItem(Front, Back)))
            dlg.Show()
        End If
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
        Dim Color As Color = Image.GetPixel(200, 1200) ' Get background color of Aadhar from any empty place within content area
#If DEBUG Then
        Color = Color.FromArgb(100, Color.Red)
#End If
        Using G As Graphics = Graphics.FromImage(Image)
            ' Mask all areas that has unwanted information
            For Each Rectangle As Rectangle In MaskingAreas
                G.FillRectangle(New SolidBrush(Color), Rectangle)
            Next
        End Using

        Return Image
    End Function

    Function GetTopLeftCorner(ByVal Image As Bitmap) As Point
        For x As Integer = 1 To Image.Width - 1
            For y As Integer = 1 To Image.Height - 1
                Dim clr As Integer = Image.GetPixel(x, y).ToArgb
                If clr = -11316397 Or clr = -7368817 Or clr = -16777216 Or clr = -3355444 Then Return New Point(x, y)
            Next
        Next
        Return New Point(0, 0)
    End Function

    Function GetBottomLeftCorner(ByVal Image As Bitmap) As Point
        For x As Integer = 1 To Image.Width - 1
            For y As Integer = Image.Height - 1 To 1 Step -1
                Dim clr As Integer = Image.GetPixel(x, y).ToArgb
                If clr = -11316397 Or clr = -7368817 Or clr = -16777216 Then Return New Point(x, y)
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

    Private Sub PrepImage(ByVal Images As Bitmap())
        Dim Width As Single = 5

        For Each i As Bitmap In Images
            Using G As Graphics = Graphics.FromImage(i)
                G.FillRectangle(Brushes.White, 7, 0, i.Width - 14, 10)
                G.DrawLine(New Pen(Brushes.Black, Width), New Point(0, (Width / 2)), New Point(i.Width, (Width / 2)))
            End Using
        Next
    End Sub
#End Region

End Class