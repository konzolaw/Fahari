Imports System.IO

Public Class PatientTestForm


    Private Sub ButtonSavePatientDetails_Click(sender As Object, e As EventArgs)
        ' Check if any textbox is empty
        If String.IsNullOrWhiteSpace(TextBoxName.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxPhoneno.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxAge.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxHomeaddress.Text) OrElse
          String.IsNullOrWhiteSpace(TextBoxBloodpressure.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxHeight.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxWeight.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxConcerns.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxAllergies.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxCurrentmedication.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxHeartbeat.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxTemperature.Text) Then
            ' Display error message if any field is empty
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            ' Display success message
            MessageBox.Show("Patient details successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Optionally, you can add code here to save the patient details to your database or perform any other actions
        End If
    End Sub



    Private Sub RefferalButton_Click(sender As Object, e As EventArgs) Handles RefferalButton.Click
        ' Hide the current PatientTestForm
        Me.Hide()

        ' Create a new instance of AppointmentForm and show it
        Dim RefferalForm As New RefferalForm()
        RefferalForm.Show()
    End Sub

    Private Sub ButtonMakePurchase_Click(sender As Object, e As EventArgs) Handles ButtonMakePurchase.Click
        ' Display a message indicating that this system version only performs referrals
        MessageBox.Show("Sorry, This System Version only Performs Referrals.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabelHomeEsc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelHomeEsc.LinkClicked
        ' Create an instance of the PatientRegistry form
        Dim PatientRegistry As New PatientsRegistry()

        ' Show the desired tab (TabPage1)
        PatientRegistry.PatientRegistryTabControl.SelectedTab = PatientsRegistry.PatientQueueList

        ' Show the PatientRegistry form and hide the current form
        PatientsRegistry.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabelEscAppointment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEscAppointment.LinkClicked
        ' Create an instance of RefferalForm
        Dim RefferalForm As New RefferalForm()

        ' Show RefferalForm and hide the current form (PatientsRegistry)
        RefferalForm.Show()
        Me.Hide()
    End Sub

End Class