Public Class SmallCardItem

#Region "Fields/Properties"
    ReadOnly Property Front As Bitmap
    ReadOnly Property Back As Bitmap
#End Region

#Region "Constructors"
    Sub New(ByVal Front As Bitmap, ByVal Back As Bitmap)
        Me.Front = Front
        Me.Back = Back
    End Sub
#End Region

End Class
