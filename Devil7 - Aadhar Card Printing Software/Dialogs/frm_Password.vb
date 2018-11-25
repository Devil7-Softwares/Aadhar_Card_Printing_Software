Public Class frm_Password

#Region "Fields/Properties"
    Property Password As String
        Get
            Return txt_Password.Text
        End Get
        Set(value As String)
            txt_Password.Text = value
        End Set
    End Property
#End Region

#Region "Button Events"
    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub
#End Region

End Class