Public Class GotoSearch
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Create an instance of Form1
        Dim RefferalForm As New RefferalForm()

        ' Show Form1 and hide the current form
        RefferalForm.Show()
        Me.Hide()
    End Sub

End Class