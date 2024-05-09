<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Panel1 = New Panel()
        Panel2 = New Panel()
        TextBoxPassword = New MaskedTextBox()
        TextBoxPharmacyUHID = New TextBox()
        LabelPharmacyName = New Label()
        ComboBoxUser = New ComboBox()
        TextboxUsername = New TextBox()
        LoginButton = New Button()
        LnkSignUp = New LinkLabel()
        Label4 = New Label()
        txtPassword = New Label()
        txtUsername = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleTurquoise
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-12, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1144, 729)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(TextBoxPassword)
        Panel2.Controls.Add(TextBoxPharmacyUHID)
        Panel2.Controls.Add(LabelPharmacyName)
        Panel2.Controls.Add(ComboBoxUser)
        Panel2.Controls.Add(TextboxUsername)
        Panel2.Controls.Add(LoginButton)
        Panel2.Controls.Add(LnkSignUp)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(24, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1092, 692)
        Panel2.TabIndex = 0
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(143, 313)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(375, 31)
        TextBoxPassword.TabIndex = 12
        ' 
        ' TextBoxPharmacyUHID
        ' 
        TextBoxPharmacyUHID.Location = New Point(168, 256)
        TextBoxPharmacyUHID.Name = "TextBoxPharmacyUHID"
        TextBoxPharmacyUHID.Size = New Size(362, 31)
        TextBoxPharmacyUHID.TabIndex = 11
        ' 
        ' LabelPharmacyName
        ' 
        LabelPharmacyName.AutoSize = True
        LabelPharmacyName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPharmacyName.Location = New Point(10, 259)
        LabelPharmacyName.Name = "LabelPharmacyName"
        LabelPharmacyName.Size = New Size(152, 25)
        LabelPharmacyName.TabIndex = 10
        LabelPharmacyName.Text = "Pharmacy UHID:"
        ' 
        ' ComboBoxUser
        ' 
        ComboBoxUser.FormattingEnabled = True
        ComboBoxUser.Items.AddRange(New Object() {"Pharmacist", "Lab Technician"})
        ComboBoxUser.Location = New Point(12, 157)
        ComboBoxUser.Name = "ComboBoxUser"
        ComboBoxUser.Size = New Size(182, 33)
        ComboBoxUser.TabIndex = 9
        ComboBoxUser.Text = "Pharmacist"
        ' 
        ' TextboxUsername
        ' 
        TextboxUsername.Location = New Point(127, 210)
        TextboxUsername.Name = "TextboxUsername"
        TextboxUsername.Size = New Size(364, 31)
        TextboxUsername.TabIndex = 7
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.Cyan
        LoginButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.Location = New Point(47, 411)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(133, 54)
        LoginButton.TabIndex = 6
        LoginButton.Text = "LOGIN"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' LnkSignUp
        ' 
        LnkSignUp.AutoSize = True
        LnkSignUp.Location = New Point(248, 527)
        LnkSignUp.Name = "LnkSignUp"
        LnkSignUp.Size = New Size(71, 25)
        LnkSignUp.TabIndex = 5
        LnkSignUp.TabStop = True
        LnkSignUp.Text = "sign up"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(7, 527)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 25)
        Label4.TabIndex = 4
        Label4.Text = "Dont have an account ?"
        ' 
        ' txtPassword
        ' 
        txtPassword.AutoSize = True
        txtPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(12, 311)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(102, 25)
        txtPassword.TabIndex = 3
        txtPassword.Text = "Password :"
        ' 
        ' txtUsername
        ' 
        txtUsername.AutoSize = True
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(6, 216)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(115, 25)
        txtUsername.TabIndex = 2
        txtUsername.Text = "UserName  :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(7, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 28)
        Label1.TabIndex = 1
        Label1.Text = "Sign In as :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(159, 123)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        AcceptButton = LoginButton
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1159, 696)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "LoginForm"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As Label
    Friend WithEvents LnkSignUp As LinkLabel
    Friend WithEvents LoginButton As Button
    Friend WithEvents TextboxUsername As TextBox
    Friend WithEvents ComboBoxUser As ComboBox
    Friend WithEvents TextBoxPassword As MaskedTextBox
    Friend WithEvents TextBoxPharmacyUHID As TextBox
    Friend WithEvents LabelPharmacyName As Label

End Class
