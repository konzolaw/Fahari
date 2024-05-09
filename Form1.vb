Imports MySql.Data.MySqlClient

Public Class LoginForm
    ' Connection string for MySQL database
    Dim connectionString As String = "server=localhost;database=pharmacydb;user=root;password=Irke@12843"

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = TextboxUsername.Text
        Dim password As String = TextBoxPassword.Text
        Dim pharmacyUHID As String = TextBoxPharmacyUHID.Text

        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Please fill in the username field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in the password field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrWhiteSpace(pharmacyUHID) Then
            MessageBox.Show("Please fill in the PharmacyUHID field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Retrieve the selected role from ComboBoxUser
            Dim selectedRole As String = ComboBoxUser.SelectedItem.ToString()

            ' Split the username into first name and last name
            Dim names() As String = username.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            Dim firstName As String = names(0)
            Dim lastName As String = ""
            If names.Length > 1 Then
                lastName = names(1)
            End If

            ' Validate login credentials
            Dim authenticated As Boolean = AuthenticateUser(firstName, lastName, password, pharmacyUHID, selectedRole)

            If authenticated Then
                ' Open the corresponding form based on the user's role
                Select Case selectedRole
                    Case "Pharmacist"
                        Dim PatientsRegistry As New PatientsRegistry()
                        PatientsRegistry.Show()
                    Case "Lab Technician"
                        Dim Form2 As New Form2()
                        Form2.Show()
                    Case Else
                        MessageBox.Show("Invalid user role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
                MessageBox.Show("Welcome to Connect, " & username & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Hide the login form
                Me.Hide()
            Else
                MessageBox.Show("Invalid username, password, or PharmacyUHID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function AuthenticateUser(firstName As String, lastName As String, password As String, pharmacyUHID As String, role As String) As Boolean
        Dim query As String = ""
        If role = "Pharmacist" Then
            query = "SELECT * FROM Pharmacists WHERE FirstName = @FirstName AND LastName = @LastName AND Password = @Password AND PharmacyUHID = @PharmacyUHID"
        ElseIf role = "Lab Technician" Then
            query = "SELECT * FROM LabTechnicians WHERE FirstName = @FirstName AND LastName = @LastName AND Password = @Password AND PharmacyUHID = @PharmacyUHID"
        Else
            MessageBox.Show("Invalid user role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Parameters.AddWithValue("@PharmacyUHID", pharmacyUHID)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' User found in database, authentication successful
                            Return True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("LOGIN error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' User not found in database or error occurred
        Return False
    End Function

    Private Sub LnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSignUp.LinkClicked
        Dim signUpForm As New SignUpForm()
        signUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBoxPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.Enter
        ' Set the UseSystemPasswordChar property to true to hide the text
        TextBoxPassword.UseSystemPasswordChar = True
    End Sub
End Class
