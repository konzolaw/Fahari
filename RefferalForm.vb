Public Class RefferalForm
    Private Sub ButtonSearchForHospital_Click(sender As Object, e As EventArgs) Handles ButtonSearchForHospital.Click
        ' Create an instance of the Gotosearch form
        Dim GotoSearchForm As New GotoSearch()

        ' Show the Gotosearch form
        GotoSearchForm.Show()
        Me.Hide()
    End Sub

    Private Sub LinkFollowUP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkFollowUP.LinkClicked
        ' Create an instance of the Followup form
        Dim FollowupForm As New FollowupForm()

        ' Show the Followup form
        FollowupForm.Show()
        Me.Hide()
    End Sub

    Private Sub LinkPatientRegistry_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPatientRegistry.LinkClicked
        ' Create an instance of the PatientsRegistry form
        Dim PatientsRegistry As New PatientsRegistry()

        ' Show the PatientsRegistry form
        PatientsRegistry.Show()
        Me.Hide()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Display the selected date in the TextBox
        TextBoxProposedDate.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub

End Class