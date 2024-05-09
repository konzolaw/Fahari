Imports MySql.Data.MySqlClient

Public Class SignUpForm

    ' Connection string for MySQL database
    Dim connectionString As String = "server=localhost;database=pharmacydb;user=root;password=Irke@12843"

    Private Sub ButtonSignup_Click(sender As Object, e As EventArgs) Handles ButtonSignup.Click
        ' Retrieve data from form fields
        Dim firstName As String = SignupFirstnameTextBox.Text
        Dim lastName As String = SignupLastnameTextBox.Text
        Dim password As String = SignupPasswordTextBox.Text
        Dim email As String = SignupEmailTextBox.Text
        Dim age As Integer = Convert.ToInt32(SignupAgeTextBox.Text)
        Dim phoneNo As String = SignupPhoneNOTextBox.Text
        Dim staffId As String = SignupStaffIdTextBox.Text
        Dim department As String = ComboBoxDepartment.SelectedItem.ToString()
        Dim PharmacyName As String = TextBoxPharmactName.Text
        Dim PharmacyUHID As String = TextBoxPharmacyUHID.Text
        Dim gender As String = ComboBoxGender.SelectedItem.ToString()
        Dim role As String = ComboBoxRole.SelectedItem.ToString()
        Dim dateRegistered As Date = DateTimePicker1.Value.Date
        Dim HomeCounty As String = ComboBoxCounties.SelectedItem.ToString()
        Dim HomeSubcounty As String = ComboBoxSubcounties.SelectedItem.ToString()
        Dim confirmPassword As String = SignupCopyPasswordTextBox.Text

        ' Validate input fields
        If String.IsNullOrWhiteSpace(firstName) OrElse
           String.IsNullOrWhiteSpace(lastName) OrElse
           String.IsNullOrWhiteSpace(password) OrElse
           String.IsNullOrWhiteSpace(email) OrElse
           age <= 0 OrElse
           String.IsNullOrWhiteSpace(phoneNo) OrElse
           String.IsNullOrWhiteSpace(staffId) OrElse
           String.IsNullOrWhiteSpace(gender) OrElse
           String.IsNullOrWhiteSpace(PharmacyUHID) OrElse
           String.IsNullOrWhiteSpace(PharmacyName) OrElse
           String.IsNullOrWhiteSpace(role) OrElse
           password <> confirmPassword OrElse
           String.IsNullOrWhiteSpace(confirmPassword) OrElse
           String.IsNullOrWhiteSpace(HomeCounty) OrElse
           String.IsNullOrWhiteSpace(HomeSubcounty) Then
            MessageBox.Show("Please fill in all fields Or Check if the passwords Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Insert data into Pharmacist or LabTechnician table based on role
        Dim signupSuccessful As Boolean
        If role = "Pharmacist" Then
            signupSuccessful = InsertPharmacistsData(firstName, lastName, password, email, age, phoneNo, staffId, role, gender, department, dateRegistered, HomeCounty, HomeSubcounty, PharmacyUHID)
        ElseIf role = "Lab Technician" Then
            signupSuccessful = InsertLabTechnicianData(firstName, lastName, password, email, age, phoneNo, staffId, role, gender, department, dateRegistered, HomeCounty, HomeSubcounty, PharmacyUHID)
        Else
            MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If signupSuccessful Then
            clearFields()
            MessageBox.Show("Successfully signed up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Close the SignupForm
            Me.Hide()

            ' Show the new form
            Dim LoginForm As New LoginForm()
            LoginForm.Show()
        Else
            MessageBox.Show("Signup failed. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function InsertPharmacistsData(firstName As String, lastName As String, password As String, email As String, age As Integer, phoneNo As String, staffId As String, role As String, gender As String, department As String, dateRegistered As Date, homeCounty As String, homeSubcounty As String, PharmacyUHID As String) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Pharmacists (FirstName, LastName, Password, Email, Age, PhoneNumber, StaffID, Role, Gender, Department, DateRegistered, HomeCounty, HomeSubcounty, PharmacyUHID) VALUES (@FirstName, @LastName, @Password, @Email, @Age, @PhoneNumber, @StaffID, @Role, @Gender, @Department, @DateRegistered, @HomeCounty, @HomeSubcounty, @PharmacyUHID)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Age", age)
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNo)
                    command.Parameters.AddWithValue("@StaffID", staffId)
                    command.Parameters.AddWithValue("@Role", role)
                    command.Parameters.AddWithValue("@Gender", gender)
                    command.Parameters.AddWithValue("@Department", department)
                    command.Parameters.AddWithValue("@DateRegistered", dateRegistered)
                    command.Parameters.AddWithValue("@HomeCounty", homeCounty)
                    command.Parameters.AddWithValue("@HomeSubcounty", homeSubcounty)
                    command.Parameters.AddWithValue("@PharmacyUHID", PharmacyUHID)

                    command.ExecuteNonQuery()
                End Using
            End Using

            Return True ' Signup successful
        Catch ex As Exception
            MessageBox.Show("Error inserting data into Pharmacist table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Signup failed
        End Try
    End Function

    Private Function InsertLabTechnicianData(firstName As String, lastName As String, password As String, email As String, age As Integer, phoneNo As String, staffId As String, role As String, gender As String, department As String, dateRegistered As Date, homeCounty As String, homeSubcounty As String, PharmacyUHID As String) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO LabTechnicians (FirstName, LastName, Password, Email, Age, PhoneNumber, StaffID, Role, Gender, Department, DateRegistered, HomeCounty, HomeSubcounty, PharmacyUHID) VALUES (@FirstName, @LastName, @Password, @Email, @Age, @PhoneNumber, @StaffID, @Role, @Gender, @Department, @DateRegistered, @HomeCounty, @HomeSubcounty, @PharmacyUHID)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Age", age)
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNo)
                    command.Parameters.AddWithValue("@StaffID", staffId)
                    command.Parameters.AddWithValue("@Role", role)
                    command.Parameters.AddWithValue("@Gender", gender)
                    command.Parameters.AddWithValue("@Department", department)
                    command.Parameters.AddWithValue("@DateRegistered", dateRegistered)
                    command.Parameters.AddWithValue("@HomeCounty", homeCounty)
                    command.Parameters.AddWithValue("@HomeSubcounty", homeSubcounty)
                    command.Parameters.AddWithValue("@PharmacyUHID", PharmacyUHID)

                    command.ExecuteNonQuery()
                End Using
            End Using

            Return True ' Signup successful
        Catch ex As Exception
            MessageBox.Show("Error inserting data into Lab Technician table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Signup failed
        End Try
    End Function

    Private Sub clearFields()
        ' Clear all input fields
        SignupFirstnameTextBox.Text = ""
        SignupLastnameTextBox.Text = ""
        SignupPasswordTextBox.Text = ""
        SignupEmailTextBox.Text = ""
        SignupAgeTextBox.Text = ""
        SignupPhoneNOTextBox.Text = ""
        SignupStaffIdTextBox.Text = ""
        TextBoxPharmactName.Text = ""
        TextBoxPharmacyUHID.Text = ""
        ComboBoxGender.SelectedItem = Nothing
        ComboBoxRole.SelectedItem = Nothing
        DateTimePicker1.Value = DateTime.Today
        ComboBoxCounties.SelectedItem = Nothing
        ComboBoxSubcounties.SelectedItem = Nothing
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Display selected date in TextBox1
        TextBox1.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub


End Class
