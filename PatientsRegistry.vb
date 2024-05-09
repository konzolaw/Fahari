Imports System.Net
Imports System.Net.Http
Imports System.Text.Json.Nodes
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json.Linq


Public Class PatientsRegistry




    Private Sub LinkLabelEscLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEscLogin.LinkClicked
        ' Create an instance of Form1
        Dim Form1 As New Form1()

        ' Show Form1 and hide the current form (PatientsRegistry)
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Display the selected date in the TextBox
        TextBoxDateOfVisit.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub
    Private Sub DateTimePicker1_Enter(sender As Object, e As EventArgs) Handles DateTimePicker1.Enter
        ' Display the selected date in the TextBoxDateOfBirth
        TextBoxDateOfBirth.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub CheckedListBoxVisittype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckBoxVisitType.SelectedIndexChanged
        Dim checkedItemIndex As Integer = CheckBoxVisitType.SelectedIndex

        ' Uncheck all items except the one that is currently checked
        For i As Integer = 0 To CheckBoxVisitType.Items.Count - 1
            If i <> checkedItemIndex Then
                CheckBoxVisitType.SetItemChecked(i, False)
            End If
        Next
    End Sub

    Private visitCounter As Integer = 1 ' Counter for visit number
    Private queueCounter As Integer = 1 ' Counter for queue number
    Private visitNumber As String = "" ' Generated visit number
    Private queueNumber As Integer = 0 ' Generated queue number

    Private Sub PatientsRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Perform visit number and queue number generation when the form loads
        GenerateVisitAndQueueNumbers()

    End Sub


    Private Sub PatientRegistryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if the AddPatients tab is selected
        If PatientRegistryTabControl.SelectedTab IsNot Nothing AndAlso PatientRegistryTabControl.SelectedTab.Name = "AddPatients" Then
            ' If AddPatients tab is selected, display the visit number and queue number in the TextBoxes
            TextBoxPatientVisitNo.Text = visitNumber
            TextBoxQueueNo.Text = queueNumber.ToString()
        End If
    End Sub
      Dim connectionString As String = "server=localhost;database=pharmacydb;user=root;password=Irke@12843"

    Private Sub ButtonSendQueue_Click(sender As Object, e As EventArgs) Handles ButtonSendQueue.Click
        ' Retrieve data from form controls
        Dim patientUPI As String = TextBoxPatientUPI.Text
        Dim nationalID As String = TextBoxNationalID.Text
        Dim firstName As String = TextBoxFirstName.Text
        Dim lastName As String = TextBoxLastName.Text
        Dim phoneNumber As String = TextBoxPhoneNo.Text
        Dim email As String = TextBoxEmail.Text
        Dim gender As String = ComboBoxGender.SelectedItem.ToString()
        Dim dateOfBirth As Date = DateTime.Parse(TextBoxDateOfBirth.Text)
        Dim Homeaddress As String = TextBoxHomeAddress.Text
        Dim queueNo As String = TextBoxQueueNo.Text
        Dim visitNo As String = TextBoxPatientVisitNo.Text
        Dim nextOfKinName As String = TextBoxNextofKin.Text
        Dim relationship As String = TextBoxRelation2Kin.Text
        Dim nextOfKinContacts As String = TextBoxNOKcontacts.Text
        Dim nextOfKinAddress As String = TextBoxNextofkinaddress.Text
        Dim bloodPressure As String = TextBoxBloodPressure.Text
        Dim heartbeat As Integer = Integer.Parse(TextBoxHeartBeat.Text)
        Dim temperature As Decimal = Decimal.Parse(TextBoxTemperature.Text)
        Dim height As Decimal = Decimal.Parse(TextBoxHeight.Text)
        Dim weight As Decimal = Decimal.Parse(TextBoxWeight.Text)
        Dim allergies As String = TextBoxAllergies.Text
        Dim currentMedications As String = TextBoxCurrentMedication.Text
        Dim visitType As String = CheckBoxVisitType.ToString()
        Dim departmentFrom As String = ComboBoxDepartmentFrom.SelectedItem.ToString()
        Dim departmentTo As String = ComboBoxDepartmentTO.SelectedItem.ToString()
        Dim queueStatus As String = ComboBoxQueueStatus.SelectedItem.ToString()

        ' Validate the data (you can add more validation as needed)
        If String.IsNullOrWhiteSpace(patientUPI) OrElse String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update the data in the database
        Try
            ' Open connection to the database
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Insert data into Patients table
                Dim insertPatientQuery As String = "INSERT INTO Patients (PatientUPI, NationalID, FirstName, LastName, PhoneNumber, Email, Gender, DateOfBirth, Homeaddress, QueueNo, VisitNo, NextOfKinName, Relationship, NextOfKinContacts, NextOfKinaddress) VALUES (@PatientUPI, @NationalID, @FirstName, @LastName, @PhoneNumber, @Email, @Gender, @DateOfBirth, @Homeaddress, @QueueNo, @VisitNo, @NextOfKinName, @Relationship, @NextOfKinContacts, @NextOfKinaddress)"
                Using insertPatientCommand As New MySqlCommand(insertPatientQuery, connection)
                    insertPatientCommand.Parameters.AddWithValue("@PatientUPI", patientUPI)
                    insertPatientCommand.Parameters.AddWithValue("@NationalID", nationalID)
                    insertPatientCommand.Parameters.AddWithValue("@FirstName", firstName)
                    insertPatientCommand.Parameters.AddWithValue("@LastName", lastName)
                    insertPatientCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                    insertPatientCommand.Parameters.AddWithValue("@Email", email)
                    insertPatientCommand.Parameters.AddWithValue("@Gender", gender)
                    insertPatientCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                    insertPatientCommand.Parameters.AddWithValue("@homeaddress", Homeaddress)
                    insertPatientCommand.Parameters.AddWithValue("@QueueNo", queueNo)
                    insertPatientCommand.Parameters.AddWithValue("@VisitNo", visitNo)
                    insertPatientCommand.Parameters.AddWithValue("@NextOfKinName", nextOfKinName)
                    insertPatientCommand.Parameters.AddWithValue("@Relationship", relationship)
                    insertPatientCommand.Parameters.AddWithValue("@NextOfKinContacts", nextOfKinContacts)
                    insertPatientCommand.Parameters.AddWithValue("@NextOfKinaddress", nextOfKinAddress)
                    insertPatientCommand.ExecuteNonQuery()
                End Using

                ' Insert data into Visits table
                Dim insertVisitQuery As String = "INSERT INTO Visits (VisitID, PatientUPI, Date, Notes,VisitTypes) VALUES (@VisitID, @PatientUPI, @Date, @Notes)"
                Using insertVisitCommand As New MySqlCommand(insertVisitQuery, connection)
                    ' Generate a unique visit ID (e.g., using the current date and time)
                    Dim visitID As String = DateTime.Now.ToString("yyyyMMddHHmmss")
                    insertVisitCommand.Parameters.AddWithValue("@VisitID", visitID)
                    insertVisitCommand.Parameters.AddWithValue("@PatientUPI", patientUPI)
                    insertVisitCommand.Parameters.AddWithValue("@visitType", visitType)
                    insertVisitCommand.Parameters.AddWithValue("@Date", DateOfVisit) ' Use date of birth for demonstration
                    insertVisitCommand.Parameters.AddWithValue("@Notes", "") ' You can add notes here if needed
                    insertVisitCommand.ExecuteNonQuery()
                End Using

                ' Insert data into Queues table
                Dim insertQueueQuery As String = "INSERT INTO Queues (QueueID, QueueNumber, QueueStatus, DepartmentFrom, DepartmentTo, PatientUPI) VALUES (@QueueID, @QueueNumber, @QueueStatus, @DepartmentFrom, @DepartmentTo, @PatientUPI)"
                Using insertQueueCommand As New MySqlCommand(insertQueueQuery, connection)
                    ' Generate a unique queue ID (e.g., using the current date)
                    Dim queueID As String = DateTime.Now.ToString("ddMMyyyy")
                    insertQueueCommand.Parameters.AddWithValue("@QueueID", queueID)
                    insertQueueCommand.Parameters.AddWithValue("@QueueNumber", queueNo)
                    insertQueueCommand.Parameters.AddWithValue("@QueueStatus", queueStatus)
                    insertQueueCommand.Parameters.AddWithValue("@DepartmentFrom", departmentFrom)
                    insertQueueCommand.Parameters.AddWithValue("@DepartmentTo", departmentTo)
                    insertQueueCommand.Parameters.AddWithValue("@PatientUPI", patientUPI)
                    insertQueueCommand.ExecuteNonQuery()
                End Using

                ' Insert data into MedicalDetails table
                Dim insertMedicalDetailsQuery As String = "INSERT INTO MedicalDetails (PatientUPI, BloodPressure, HeartbeatRate, Temperature, Height, Weight, Allergies, CurrentMedication) VALUES (@PatientUPI, @BloodPressure, @HeartbeatRate, @Temperature, @Height, @Weight, @Allergies, @CurrentMedication)"
                Using insertMedicalDetailsCommand As New MySqlCommand(insertMedicalDetailsQuery, connection)
                    insertMedicalDetailsCommand.Parameters.AddWithValue("@PatientUPI", patientUPI)
                    insertMedicalDetailsCommand.Parameters.AddWithValue("@BloodPressure", bloodPressure)
                    insertMedicalDetailsCommand.Parameters.AddWithValue("@HeartbeatRate", heartbeat)
                    insertMedicalDetailsCommand.Parameters.AddWithValue("@Temperature", temperature)
                    insertMedicalDetailsCommand.Parameters.AddWithValue("@Height", height)
                    insertMedicalDetailsCommand.Parameters.AddWithValue("@Weight", weight)
                    insertMedicalDetailsCommand.Parameters.AddWithValue("@Allergies", allergies)
                    insertMedicalDetailsCommand.Parameters.AddWithValue("@CurrentMedication", currentMedications)
                    insertMedicalDetailsCommand.ExecuteNonQuery()
                End Using
            End Using

            ' Show success message
            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Show error message if an exception occurs
            MessageBox.Show("Error updating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateVisitAndQueueNumbers()
        ' Generate visit number
        Dim currentDateTime As DateTime = DateTime.Now
        visitNumber = currentDateTime.ToString("yyyyMMddHHmmss") & visitCounter.ToString("D3")
        visitCounter += 1

        ' Generate queue number based on the current count of queue numbers in the database
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Count the number of existing queue entries
                Dim countQuery As String = "SELECT COUNT(*) FROM Queues"
                Using countCommand As New MySqlCommand(countQuery, connection)
                    Dim queueCount As Integer = Convert.ToInt32(countCommand.ExecuteScalar())

                    ' Increment the queue number based on the count
                    queueNumber = queueCount + 1
                End Using
            End Using
        Catch ex As Exception
            ' Show error message if an exception occurs
            MessageBox.Show("Error generating queue number: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub LinkLabelPatientDetails_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelPatientDetails.LinkClicked
        ' Create an instance of PatientTestForm
        Dim PatientTestForm As New PatientTestForm()

        ' Show PatientTestForm and hide the current form (PatientsRegistry)
        PatientTestForm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBoxDateOfBirth_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxDateOfBirth.KeyDown
        ' Check if any key is pressed
        If e.KeyCode <> Keys.None Then
            ' Set focus to the DateTimePicker
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub ClearAllFields()
        ' Clear TextBoxes
        TextBoxPatientUPI.Clear()
        TextBoxNationalID.Clear()
        TextBoxFirstName.Clear()
        TextBoxLastName.Clear()
        TextBoxPhoneNo.Clear()
        TextBoxEmail.Clear()
        ComboBoxGender.SelectedIndex = -1
        TextBoxDateOfBirth.Clear()
        TextBoxHomeAddress.Clear()
        TextBoxQueueNo.Clear()
        TextBoxPatientVisitNo.Clear()
        TextBoxNextofKin.Clear()
        TextBoxRelation2Kin.Clear()
        TextBoxNOKcontacts.Clear()
        TextBoxNextofkinaddress.Clear()
        TextBoxBloodPressure.Clear()
        TextBoxHeartBeat.Clear()
        TextBoxTemperature.Clear()
        TextBoxHeight.Clear()
        TextBoxWeight.Clear()
        TextBoxAllergies.Clear()
        TextBoxCurrentMedication.Clear()
        CheckBoxVisitType.ClearSelected()

        ComboBoxDepartmentFrom.SelectedIndex = -1
        ComboBoxDepartmentTO.SelectedIndex = -1
        ComboBoxQueueStatus.SelectedIndex = -1
    End Sub



End Class
