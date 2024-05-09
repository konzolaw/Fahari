Public Class FollowupForm
    Private Sub LinkLabelAppointment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAppointment.LinkClicked
        ' Create an instance of RefferalForm
        Dim ReferralForm As New RefferalForm()

        ' Show RefferalForm and hide the current form (PatientsRegistry)
        ReferralForm.Show()
        Me.Hide()
    End Sub

End Class