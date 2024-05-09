<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RefferalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RefferalForm))
        Panel1 = New Panel()
        LinkPatientRegistry = New LinkLabel()
        LinkFollowUP = New LinkLabel()
        TextBox3 = New TextBox()
        LabelAppointmentID = New Label()
        TextBox2 = New TextBox()
        TextBoxPatientUPI = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        LabelRefferalID = New Label()
        LabelPatientUPI = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        ButtonSendAppointment = New Button()
        Panel4 = New Panel()
        ButtonSearchForHospital = New Button()
        TextBox13 = New TextBox()
        LabelAppointmentNote = New Label()
        Label10 = New Label()
        Label8 = New Label()
        ComboBox1 = New ComboBox()
        TextBoxHospitalName = New TextBox()
        TextBoxProposedDate = New TextBox()
        Label7 = New Label()
        TextBoxHospitalUHID = New TextBox()
        Label6 = New Label()
        TextBoxRequestedService = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        TextBoxPharmacyUHI = New TextBox()
        LabelPharmacyUHI = New Label()
        TextBoxPharmacyAddress = New TextBox()
        LabelPharmacyAddress = New Label()
        TextBoxPharmacyContacts = New TextBox()
        TextBoxStaffID = New TextBox()
        TextBoxPharmacyName = New TextBox()
        LabelPharmacyName = New Label()
        LabelPharmacyContact = New Label()
        Label15 = New Label()
        LabelStaffID = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleTurquoise
        Panel1.Controls.Add(LinkPatientRegistry)
        Panel1.Controls.Add(LinkFollowUP)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(LabelAppointmentID)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBoxPatientUPI)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(LabelRefferalID)
        Panel1.Controls.Add(LabelPatientUPI)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1249, 600)
        Panel1.TabIndex = 0
        ' 
        ' LinkPatientRegistry
        ' 
        LinkPatientRegistry.AutoSize = True
        LinkPatientRegistry.Location = New Point(230, 562)
        LinkPatientRegistry.Name = "LinkPatientRegistry"
        LinkPatientRegistry.Size = New Size(133, 25)
        LinkPatientRegistry.TabIndex = 10
        LinkPatientRegistry.TabStop = True
        LinkPatientRegistry.Text = "Patient Registry"
        ' 
        ' LinkFollowUP
        ' 
        LinkFollowUP.AutoSize = True
        LinkFollowUP.Location = New Point(1069, 568)
        LinkFollowUP.Name = "LinkFollowUP"
        LinkFollowUP.Size = New Size(91, 25)
        LinkFollowUP.TabIndex = 9
        LinkFollowUP.TabStop = True
        LinkFollowUP.Text = "Follow UP"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(730, 6)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 8
        ' 
        ' LabelAppointmentID
        ' 
        LabelAppointmentID.AutoSize = True
        LabelAppointmentID.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelAppointmentID.Location = New Point(565, 6)
        LabelAppointmentID.Name = "LabelAppointmentID"
        LabelAppointmentID.Size = New Size(159, 25)
        LabelAppointmentID.TabIndex = 7
        LabelAppointmentID.Text = "Appointment ID :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(369, 40)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 6
        ' 
        ' TextBoxPatientUPI
        ' 
        TextBoxPatientUPI.Location = New Point(369, 6)
        TextBoxPatientUPI.Name = "TextBoxPatientUPI"
        TextBoxPatientUPI.ReadOnly = True
        TextBoxPatientUPI.Size = New Size(150, 31)
        TextBoxPatientUPI.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(946, 3)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 4
        ' 
        ' LabelRefferalID
        ' 
        LabelRefferalID.AutoSize = True
        LabelRefferalID.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRefferalID.Location = New Point(214, 49)
        LabelRefferalID.Name = "LabelRefferalID"
        LabelRefferalID.Size = New Size(114, 25)
        LabelRefferalID.TabIndex = 3
        LabelRefferalID.Text = "Refferal ID :"
        ' 
        ' LabelPatientUPI
        ' 
        LabelPatientUPI.AutoSize = True
        LabelPatientUPI.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPatientUPI.Location = New Point(214, 3)
        LabelPatientUPI.Name = "LabelPatientUPI"
        LabelPatientUPI.Size = New Size(118, 25)
        LabelPatientUPI.TabIndex = 2
        LabelPatientUPI.Text = "Patient UPI :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(ButtonSendAppointment)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(13, 77)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1221, 474)
        Panel2.TabIndex = 0
        ' 
        ' ButtonSendAppointment
        ' 
        ButtonSendAppointment.BackColor = Color.MediumSpringGreen
        ButtonSendAppointment.Location = New Point(933, 347)
        ButtonSendAppointment.Name = "ButtonSendAppointment"
        ButtonSendAppointment.Size = New Size(135, 99)
        ButtonSendAppointment.TabIndex = 2
        ButtonSendAppointment.Text = "Save and send appointment request"
        ButtonSendAppointment.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(ButtonSearchForHospital)
        Panel4.Controls.Add(TextBox13)
        Panel4.Controls.Add(LabelAppointmentNote)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(ComboBox1)
        Panel4.Controls.Add(TextBoxHospitalName)
        Panel4.Controls.Add(TextBoxProposedDate)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(TextBoxHospitalUHID)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(TextBoxRequestedService)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(444, 24)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(363, 450)
        Panel4.TabIndex = 1
        ' 
        ' ButtonSearchForHospital
        ' 
        ButtonSearchForHospital.BackColor = Color.MediumAquamarine
        ButtonSearchForHospital.Location = New Point(90, 363)
        ButtonSearchForHospital.Name = "ButtonSearchForHospital"
        ButtonSearchForHospital.Size = New Size(177, 68)
        ButtonSearchForHospital.TabIndex = 3
        ButtonSearchForHospital.Text = "SearchForHospital"
        ButtonSearchForHospital.UseVisualStyleBackColor = False
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(152, 229)
        TextBox13.Multiline = True
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(196, 69)
        TextBox13.TabIndex = 13
        ' 
        ' LabelAppointmentNote
        ' 
        LabelAppointmentNote.AutoSize = True
        LabelAppointmentNote.Location = New Point(3, 232)
        LabelAppointmentNote.Name = "LabelAppointmentNote"
        LabelAppointmentNote.Size = New Size(118, 50)
        LabelAppointmentNote.TabIndex = 12
        LabelAppointmentNote.Text = "Appointment" & vbCrLf & "Note :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(79, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(247, 25)
        Label10.TabIndex = 11
        Label10.Text = "Receiving Hospitals Details "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(22, 323)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 25)
        Label8.TabIndex = 5
        Label8.Text = "Priority :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"URGENT ", "REGULAR "})
        ComboBox1.Location = New Point(152, 315)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 10
        ' 
        ' TextBoxHospitalName
        ' 
        TextBoxHospitalName.Location = New Point(173, 77)
        TextBoxHospitalName.Name = "TextBoxHospitalName"
        TextBoxHospitalName.Size = New Size(187, 31)
        TextBoxHospitalName.TabIndex = 6
        ' 
        ' TextBoxProposedDate
        ' 
        TextBoxProposedDate.Location = New Point(163, 188)
        TextBoxProposedDate.Name = "TextBoxProposedDate"
        TextBoxProposedDate.ReadOnly = True
        TextBoxProposedDate.Size = New Size(197, 31)
        TextBoxProposedDate.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 191)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 25)
        Label7.TabIndex = 4
        Label7.Text = "Proposed Date :"
        ' 
        ' TextBoxHospitalUHID
        ' 
        TextBoxHospitalUHID.Location = New Point(173, 114)
        TextBoxHospitalUHID.Name = "TextBoxHospitalUHID"
        TextBoxHospitalUHID.Size = New Size(187, 31)
        TextBoxHospitalUHID.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 157)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 25)
        Label6.TabIndex = 3
        Label6.Text = "Requested Service :"
        ' 
        ' TextBoxRequestedService
        ' 
        TextBoxRequestedService.Location = New Point(173, 151)
        TextBoxRequestedService.Name = "TextBoxRequestedService"
        TextBoxRequestedService.Size = New Size(187, 31)
        TextBoxRequestedService.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 25)
        Label5.TabIndex = 2
        Label5.Text = "Hospital UHID :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(22, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 25)
        Label4.TabIndex = 1
        Label4.Text = "Hospital Name:"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TextBoxPharmacyUHI)
        Panel3.Controls.Add(LabelPharmacyUHI)
        Panel3.Controls.Add(TextBoxPharmacyAddress)
        Panel3.Controls.Add(LabelPharmacyAddress)
        Panel3.Controls.Add(TextBoxPharmacyContacts)
        Panel3.Controls.Add(TextBoxStaffID)
        Panel3.Controls.Add(TextBoxPharmacyName)
        Panel3.Controls.Add(LabelPharmacyName)
        Panel3.Controls.Add(LabelPharmacyContact)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(LabelStaffID)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(3, 24)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(435, 450)
        Panel3.TabIndex = 0
        ' 
        ' TextBoxPharmacyUHI
        ' 
        TextBoxPharmacyUHI.Location = New Point(174, 273)
        TextBoxPharmacyUHI.Name = "TextBoxPharmacyUHI"
        TextBoxPharmacyUHI.ReadOnly = True
        TextBoxPharmacyUHI.Size = New Size(150, 31)
        TextBoxPharmacyUHI.TabIndex = 26
        ' 
        ' LabelPharmacyUHI
        ' 
        LabelPharmacyUHI.AutoSize = True
        LabelPharmacyUHI.Location = New Point(17, 273)
        LabelPharmacyUHI.Name = "LabelPharmacyUHI"
        LabelPharmacyUHI.Size = New Size(133, 25)
        LabelPharmacyUHI.TabIndex = 25
        LabelPharmacyUHI.Text = "Pharmacy UHI :"
        ' 
        ' TextBoxPharmacyAddress
        ' 
        TextBoxPharmacyAddress.Location = New Point(187, 229)
        TextBoxPharmacyAddress.Name = "TextBoxPharmacyAddress"
        TextBoxPharmacyAddress.ReadOnly = True
        TextBoxPharmacyAddress.Size = New Size(150, 31)
        TextBoxPharmacyAddress.TabIndex = 23
        ' 
        ' LabelPharmacyAddress
        ' 
        LabelPharmacyAddress.AutoSize = True
        LabelPharmacyAddress.Location = New Point(17, 229)
        LabelPharmacyAddress.Name = "LabelPharmacyAddress"
        LabelPharmacyAddress.Size = New Size(168, 25)
        LabelPharmacyAddress.TabIndex = 24
        LabelPharmacyAddress.Text = "Pharmacy Address :"
        ' 
        ' TextBoxPharmacyContacts
        ' 
        TextBoxPharmacyContacts.Location = New Point(187, 188)
        TextBoxPharmacyContacts.Name = "TextBoxPharmacyContacts"
        TextBoxPharmacyContacts.ReadOnly = True
        TextBoxPharmacyContacts.Size = New Size(150, 31)
        TextBoxPharmacyContacts.TabIndex = 22
        ' 
        ' TextBoxStaffID
        ' 
        TextBoxStaffID.Location = New Point(187, 145)
        TextBoxStaffID.Name = "TextBoxStaffID"
        TextBoxStaffID.ReadOnly = True
        TextBoxStaffID.Size = New Size(150, 31)
        TextBoxStaffID.TabIndex = 21
        ' 
        ' TextBoxPharmacyName
        ' 
        TextBoxPharmacyName.Location = New Point(187, 103)
        TextBoxPharmacyName.Name = "TextBoxPharmacyName"
        TextBoxPharmacyName.ReadOnly = True
        TextBoxPharmacyName.Size = New Size(150, 31)
        TextBoxPharmacyName.TabIndex = 20
        ' 
        ' LabelPharmacyName
        ' 
        LabelPharmacyName.AutoSize = True
        LabelPharmacyName.Location = New Point(17, 106)
        LabelPharmacyName.Name = "LabelPharmacyName"
        LabelPharmacyName.Size = New Size(154, 25)
        LabelPharmacyName.TabIndex = 19
        LabelPharmacyName.Text = "Pharmacist Name:"
        ' 
        ' LabelPharmacyContact
        ' 
        LabelPharmacyContact.AutoSize = True
        LabelPharmacyContact.Location = New Point(11, 194)
        LabelPharmacyContact.Name = "LabelPharmacyContact"
        LabelPharmacyContact.Size = New Size(172, 25)
        LabelPharmacyContact.TabIndex = 18
        LabelPharmacyContact.Text = "Pharmacy Contacts :"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(142, 58)
        Label15.Name = "Label15"
        Label15.Size = New Size(195, 25)
        Label15.TabIndex = 17
        Label15.Text = "Pharmacy infomation"
        ' 
        ' LabelStaffID
        ' 
        LabelStaffID.AutoSize = True
        LabelStaffID.Location = New Point(17, 151)
        LabelStaffID.Name = "LabelStaffID"
        LabelStaffID.Size = New Size(80, 25)
        LabelStaffID.TabIndex = 16
        LabelStaffID.Text = "Staff ID :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(105, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(232, 25)
        Label3.TabIndex = 0
        Label3.Text = "Appointment Information"
        ' 
        ' RefferalForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1273, 624)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RefferalForm"
        Text = "RefferalForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBoxPatientUPI As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelRefferalID As Label
    Friend WithEvents LabelPatientUPI As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LabelAppointmentID As Label
    Friend WithEvents TextBoxProposedDate As TextBox
    Friend WithEvents TextBoxRequestedService As TextBox
    Friend WithEvents TextBoxHospitalUHID As TextBox
    Friend WithEvents TextBoxHospitalName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents LabelAppointmentNote As Label
    Friend WithEvents TextBoxPharmacyUHI As TextBox
    Friend WithEvents LabelPharmacyUHI As Label
    Friend WithEvents TextBoxPharmacyAddress As TextBox
    Friend WithEvents LabelPharmacyAddress As Label
    Friend WithEvents TextBoxPharmacyContacts As TextBox
    Friend WithEvents TextBoxStaffID As TextBox
    Friend WithEvents TextBoxPharmacyName As TextBox
    Friend WithEvents LabelPharmacyName As Label
    Friend WithEvents LabelPharmacyContact As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LabelStaffID As Label
    Friend WithEvents ButtonSendAppointment As Button
    Friend WithEvents LinkFollowUP As LinkLabel
    Friend WithEvents LinkPatientRegistry As LinkLabel
    Friend WithEvents ButtonSearchForHospital As Button
End Class
