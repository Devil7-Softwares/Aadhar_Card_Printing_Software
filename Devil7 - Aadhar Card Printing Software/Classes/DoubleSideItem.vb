Public Class DoubleSideItem

#Region "Properties/Fields"
    ReadOnly Property Images As List(Of ImageWrapper)
#End Region

#Region "Constructors"
    Sub New(ByVal Front As Bitmap, ByVal Back As Bitmap)
        Images = New List(Of ImageWrapper)
        Images.Add(New ImageWrapper(Front))
        Images.Add(New ImageWrapper(Back))
    End Sub
#End Region

    Class ImageWrapper

#Region "Properties/Fields"
        ReadOnly Property Image As Image
#End Region

#Region "Constructors"
        Sub New(ByVal Image As Image)
            Me.Image = Image
        End Sub
#End Region

    End Class

End Class
