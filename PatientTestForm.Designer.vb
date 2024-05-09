<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientTestForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientTestForm))
        Panel1 = New Panel()
        Panel2 = New Panel()
        LinkLabelHomeEsc = New LinkLabel()
        ButtonMakePurchase = New Button()
        RefferalButton = New Button()
        DateTimePicker = New DateTimePicker()
        Panel5 = New Panel()
        TextBoxLabTestNo = New TextBox()
        TextBoxStaffID = New TextBox()
        TextBoxLabTechName = New TextBox()
        LabelLabTestNo = New Label()
        LabelStaffID = New Label()
        LabelTechName = New Label()
        TextBoxDiagnosis = New TextBox()
        Label1 = New Label()
        TextBoxConcerns = New TextBox()
        LabelLabresults = New Label()
        LabelConcerns = New Label()
        PanelVitals = New Panel()
        TextBoxCurrentmedication = New TextBox()
        TextBoxAllergies = New TextBox()
        TextBoxWeight = New TextBox()
        TextBoxHeight = New TextBox()
        TextBoxTemperature = New TextBox()
        TextBoxHeartbeat = New TextBox()
        TextBoxBloodpressure = New TextBox()
        LabelCurrentmedication = New Label()
        LabelAllergies = New Label()
        LabelWeight = New Label()
        LabelHeight = New Label()
        LabelTemperature = New Label()
        LabelHeartbeat = New Label()
        LabelBloodpressure = New Label()
        LabelVitals = New Label()
        PanelPatientDetaisl = New Panel()
        ComboBoxPatientStatus = New ComboBox()
        ComboBoxComingFrom = New ComboBox()
        LabelStatus = New Label()
        LabelComingFrom = New Label()
        TextBoxName = New TextBox()
        TextBoxHomeaddress = New TextBox()
        TextBoxAge = New TextBox()
        TextBoxPhoneno = New TextBox()
        LabelHomeaddress = New Label()
        LabelAge = New Label()
        LabelPhoneno = New Label()
        LabelName = New Label()
        TextBoxPatientUPI = New TextBox()
        LabelPatientUPI = New Label()
        LabelPatientDetails = New Label()
        LabelPatientRefferalForm = New Label()
        TextBoxPrescription = New TextBox()
        PictureBox1 = New PictureBox()
        LabelPrescription = New Label()
        OpenFileDialog = New OpenFileDialog()
        LinkLabelEscAppointment = New LinkLabel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        PanelVitals.SuspendLayout()
        PanelPatientDetaisl.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.AutoSize = True
        Panel1.BackColor = Color.PaleTurquoise
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1205, 831)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.AutoSize = True
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(LinkLabelEscAppointment)
        Panel2.Controls.Add(LinkLabelHomeEsc)
        Panel2.Controls.Add(ButtonMakePurchase)
        Panel2.Controls.Add(RefferalButton)
        Panel2.Controls.Add(DateTimePicker)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(PanelVitals)
        Panel2.Controls.Add(PanelPatientDetaisl)
        Panel2.Controls.Add(LabelPatientRefferalForm)
        Panel2.Controls.Add(TextBoxPrescription)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(LabelPrescription)
        Panel2.Location = New Point(27, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1174, 819)
        Panel2.TabIndex = 0
        ' 
        ' LinkLabelHomeEsc
        ' 
        LinkLabelHomeEsc.AutoSize = True
        LinkLabelHomeEsc.Location = New Point(181, 27)
        LinkLabelHomeEsc.Name = "LinkLabelHomeEsc"
        LinkLabelHomeEsc.Size = New Size(127, 25)
        LinkLabelHomeEsc.TabIndex = 24
        LinkLabelHomeEsc.TabStop = True
        LinkLabelHomeEsc.Text = "Back to Queue"
        ' 
        ' ButtonMakePurchase
        ' 
        ButtonMakePurchase.BackColor = Color.MediumSpringGreen
        ButtonMakePurchase.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonMakePurchase.Location = New Point(471, 671)
        ButtonMakePurchase.Name = "ButtonMakePurchase"
        ButtonMakePurchase.Size = New Size(112, 70)
        ButtonMakePurchase.TabIndex = 23
        ButtonMakePurchase.Text = "Make Purchase"
        ButtonMakePurchase.UseVisualStyleBackColor = False
        ' 
        ' RefferalButton
        ' 
        RefferalButton.BackColor = Color.MediumSpringGreen
        RefferalButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RefferalButton.Location = New Point(765, 695)
        RefferalButton.Name = "RefferalButton"
        RefferalButton.Size = New Size(112, 34)
        RefferalButton.TabIndex = 21
        RefferalButton.Text = "Refer"
        RefferalButton.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Location = New Point(840, 21)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(300, 31)
        DateTimePicker.TabIndex = 5
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(TextBoxLabTestNo)
        Panel5.Controls.Add(TextBoxStaffID)
        Panel5.Controls.Add(TextBoxLabTechName)
        Panel5.Controls.Add(LabelLabTestNo)
        Panel5.Controls.Add(LabelStaffID)
        Panel5.Controls.Add(LabelTechName)
        Panel5.Controls.Add(TextBoxDiagnosis)
        Panel5.Controls.Add(Label1)
        Panel5.Controls.Add(TextBoxConcerns)
        Panel5.Controls.Add(LabelLabresults)
        Panel5.Controls.Add(LabelConcerns)
        Panel5.Location = New Point(386, 71)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(773, 354)
        Panel5.TabIndex = 4
        ' 
        ' TextBoxLabTestNo
        ' 
        TextBoxLabTestNo.Location = New Point(145, 122)
        TextBoxLabTestNo.Multiline = True
        TextBoxLabTestNo.Name = "TextBoxLabTestNo"
        TextBoxLabTestNo.Size = New Size(541, 46)
        TextBoxLabTestNo.TabIndex = 27
        ' 
        ' TextBoxStaffID
        ' 
        TextBoxStaffID.Location = New Point(145, 84)
        TextBoxStaffID.Name = "TextBoxStaffID"
        TextBoxStaffID.Size = New Size(150, 31)
        TextBoxStaffID.TabIndex = 26
        ' 
        ' TextBoxLabTechName
        ' 
        TextBoxLabTechName.Location = New Point(226, 36)
        TextBoxLabTechName.Name = "TextBoxLabTechName"
        TextBoxLabTechName.Size = New Size(150, 31)
        TextBoxLabTechName.TabIndex = 25
        ' 
        ' LabelLabTestNo
        ' 
        LabelLabTestNo.AutoSize = True
        LabelLabTestNo.Location = New Point(21, 125)
        LabelLabTestNo.Name = "LabelLabTestNo"
        LabelLabTestNo.Size = New Size(118, 25)
        LabelLabTestNo.TabIndex = 23
        LabelLabTestNo.Text = "LabTest NO's:"
        ' 
        ' LabelStaffID
        ' 
        LabelStaffID.AutoSize = True
        LabelStaffID.Location = New Point(44, 84)
        LabelStaffID.Name = "LabelStaffID"
        LabelStaffID.Size = New Size(70, 25)
        LabelStaffID.TabIndex = 22
        LabelStaffID.Text = "StaffID:"
        ' 
        ' LabelTechName
        ' 
        LabelTechName.AutoSize = True
        LabelTechName.Location = New Point(44, 43)
        LabelTechName.Name = "LabelTechName"
        LabelTechName.Size = New Size(185, 25)
        LabelTechName.TabIndex = 21
        LabelTechName.Text = "Lab Technician Name :"
        ' 
        ' TextBoxDiagnosis
        ' 
        TextBoxDiagnosis.Location = New Point(145, 188)
        TextBoxDiagnosis.Multiline = True
        TextBoxDiagnosis.Name = "TextBoxDiagnosis"
        TextBoxDiagnosis.Size = New Size(565, 64)
        TextBoxDiagnosis.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 25)
        Label1.TabIndex = 17
        Label1.Text = "Diagnosis :"
        ' 
        ' TextBoxConcerns
        ' 
        TextBoxConcerns.Location = New Point(141, 281)
        TextBoxConcerns.Multiline = True
        TextBoxConcerns.Name = "TextBoxConcerns"
        TextBoxConcerns.Size = New Size(569, 54)
        TextBoxConcerns.TabIndex = 16
        ' 
        ' LabelLabresults
        ' 
        LabelLabresults.AutoSize = True
        LabelLabresults.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelLabresults.Location = New Point(152, 0)
        LabelLabresults.Name = "LabelLabresults"
        LabelLabresults.Size = New Size(119, 28)
        LabelLabresults.TabIndex = 0
        LabelLabresults.Text = "Lab Results"
        ' 
        ' LabelConcerns
        ' 
        LabelConcerns.AutoSize = True
        LabelConcerns.Location = New Point(40, 284)
        LabelConcerns.Name = "LabelConcerns"
        LabelConcerns.Size = New Size(94, 25)
        LabelConcerns.TabIndex = 8
        LabelConcerns.Text = "Concerns :"
        ' 
        ' PanelVitals
        ' 
        PanelVitals.Controls.Add(TextBoxCurrentmedication)
        PanelVitals.Controls.Add(TextBoxAllergies)
        PanelVitals.Controls.Add(TextBoxWeight)
        PanelVitals.Controls.Add(TextBoxHeight)
        PanelVitals.Controls.Add(TextBoxTemperature)
        PanelVitals.Controls.Add(TextBoxHeartbeat)
        PanelVitals.Controls.Add(TextBoxBloodpressure)
        PanelVitals.Controls.Add(LabelCurrentmedication)
        PanelVitals.Controls.Add(LabelAllergies)
        PanelVitals.Controls.Add(LabelWeight)
        PanelVitals.Controls.Add(LabelHeight)
        PanelVitals.Controls.Add(LabelTemperature)
        PanelVitals.Controls.Add(LabelHeartbeat)
        PanelVitals.Controls.Add(LabelBloodpressure)
        PanelVitals.Controls.Add(LabelVitals)
        PanelVitals.Location = New Point(7, 397)
        PanelVitals.Name = "PanelVitals"
        PanelVitals.Size = New Size(382, 332)
        PanelVitals.TabIndex = 3
        ' 
        ' TextBoxCurrentmedication
        ' 
        TextBoxCurrentmedication.Location = New Point(196, 271)
        TextBoxCurrentmedication.Name = "TextBoxCurrentmedication"
        TextBoxCurrentmedication.Size = New Size(150, 31)
        TextBoxCurrentmedication.TabIndex = 15
        ' 
        ' TextBoxAllergies
        ' 
        TextBoxAllergies.Location = New Point(196, 231)
        TextBoxAllergies.Name = "TextBoxAllergies"
        TextBoxAllergies.Size = New Size(150, 31)
        TextBoxAllergies.TabIndex = 14
        ' 
        ' TextBoxWeight
        ' 
        TextBoxWeight.Location = New Point(196, 188)
        TextBoxWeight.Name = "TextBoxWeight"
        TextBoxWeight.Size = New Size(150, 31)
        TextBoxWeight.TabIndex = 13
        ' 
        ' TextBoxHeight
        ' 
        TextBoxHeight.Location = New Point(196, 149)
        TextBoxHeight.Name = "TextBoxHeight"
        TextBoxHeight.Size = New Size(150, 31)
        TextBoxHeight.TabIndex = 12
        ' 
        ' TextBoxTemperature
        ' 
        TextBoxTemperature.Location = New Point(196, 110)
        TextBoxTemperature.Name = "TextBoxTemperature"
        TextBoxTemperature.Size = New Size(150, 31)
        TextBoxTemperature.TabIndex = 11
        ' 
        ' TextBoxHeartbeat
        ' 
        TextBoxHeartbeat.Location = New Point(196, 73)
        TextBoxHeartbeat.Name = "TextBoxHeartbeat"
        TextBoxHeartbeat.Size = New Size(150, 31)
        TextBoxHeartbeat.TabIndex = 10
        ' 
        ' TextBoxBloodpressure
        ' 
        TextBoxBloodpressure.Location = New Point(196, 36)
        TextBoxBloodpressure.Name = "TextBoxBloodpressure"
        TextBoxBloodpressure.Size = New Size(150, 31)
        TextBoxBloodpressure.TabIndex = 9
        ' 
        ' LabelCurrentmedication
        ' 
        LabelCurrentmedication.AutoSize = True
        LabelCurrentmedication.Location = New Point(0, 274)
        LabelCurrentmedication.Name = "LabelCurrentmedication"
        LabelCurrentmedication.Size = New Size(172, 25)
        LabelCurrentmedication.TabIndex = 7
        LabelCurrentmedication.Text = "Current Medication :"
        ' 
        ' LabelAllergies
        ' 
        LabelAllergies.AutoSize = True
        LabelAllergies.Location = New Point(9, 234)
        LabelAllergies.Name = "LabelAllergies"
        LabelAllergies.Size = New Size(88, 25)
        LabelAllergies.TabIndex = 6
        LabelAllergies.Text = "Allergies :"
        ' 
        ' LabelWeight
        ' 
        LabelWeight.AutoSize = True
        LabelWeight.Location = New Point(9, 194)
        LabelWeight.Name = "LabelWeight"
        LabelWeight.Size = New Size(77, 25)
        LabelWeight.TabIndex = 5
        LabelWeight.Text = "Weight :"
        ' 
        ' LabelHeight
        ' 
        LabelHeight.AutoSize = True
        LabelHeight.Location = New Point(6, 157)
        LabelHeight.Name = "LabelHeight"
        LabelHeight.Size = New Size(74, 25)
        LabelHeight.TabIndex = 4
        LabelHeight.Text = "Height :"
        ' 
        ' LabelTemperature
        ' 
        LabelTemperature.AutoSize = True
        LabelTemperature.Location = New Point(6, 116)
        LabelTemperature.Name = "LabelTemperature"
        LabelTemperature.Size = New Size(119, 25)
        LabelTemperature.TabIndex = 3
        LabelTemperature.Text = "Temperature :"
        ' 
        ' LabelHeartbeat
        ' 
        LabelHeartbeat.AutoSize = True
        LabelHeartbeat.Location = New Point(6, 79)
        LabelHeartbeat.Name = "LabelHeartbeat"
        LabelHeartbeat.Size = New Size(103, 25)
        LabelHeartbeat.TabIndex = 2
        LabelHeartbeat.Text = "Heart Beat :"
        ' 
        ' LabelBloodpressure
        ' 
        LabelBloodpressure.AutoSize = True
        LabelBloodpressure.Location = New Point(6, 42)
        LabelBloodpressure.Name = "LabelBloodpressure"
        LabelBloodpressure.Size = New Size(139, 25)
        LabelBloodpressure.TabIndex = 1
        LabelBloodpressure.Text = "Blood Pressure :"
        ' 
        ' LabelVitals
        ' 
        LabelVitals.AutoSize = True
        LabelVitals.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelVitals.Location = New Point(131, 5)
        LabelVitals.Name = "LabelVitals"
        LabelVitals.Size = New Size(137, 28)
        LabelVitals.TabIndex = 0
        LabelVitals.Text = "Vitals Details"
        ' 
        ' PanelPatientDetaisl
        ' 
        PanelPatientDetaisl.Controls.Add(ComboBoxPatientStatus)
        PanelPatientDetaisl.Controls.Add(ComboBoxComingFrom)
        PanelPatientDetaisl.Controls.Add(LabelStatus)
        PanelPatientDetaisl.Controls.Add(LabelComingFrom)
        PanelPatientDetaisl.Controls.Add(TextBoxName)
        PanelPatientDetaisl.Controls.Add(TextBoxHomeaddress)
        PanelPatientDetaisl.Controls.Add(TextBoxAge)
        PanelPatientDetaisl.Controls.Add(TextBoxPhoneno)
        PanelPatientDetaisl.Controls.Add(LabelHomeaddress)
        PanelPatientDetaisl.Controls.Add(LabelAge)
        PanelPatientDetaisl.Controls.Add(LabelPhoneno)
        PanelPatientDetaisl.Controls.Add(LabelName)
        PanelPatientDetaisl.Controls.Add(TextBoxPatientUPI)
        PanelPatientDetaisl.Controls.Add(LabelPatientUPI)
        PanelPatientDetaisl.Controls.Add(LabelPatientDetails)
        PanelPatientDetaisl.Location = New Point(3, 71)
        PanelPatientDetaisl.Name = "PanelPatientDetaisl"
        PanelPatientDetaisl.Size = New Size(377, 320)
        PanelPatientDetaisl.TabIndex = 2
        ' 
        ' ComboBoxPatientStatus
        ' 
        ComboBoxPatientStatus.FormattingEnabled = True
        ComboBoxPatientStatus.Items.AddRange(New Object() {"Checked in", "Inline", "Checked Out"})
        ComboBoxPatientStatus.Location = New Point(166, 268)
        ComboBoxPatientStatus.Name = "ComboBoxPatientStatus"
        ComboBoxPatientStatus.Size = New Size(182, 33)
        ComboBoxPatientStatus.TabIndex = 21
        ' 
        ' ComboBoxComingFrom
        ' 
        ComboBoxComingFrom.FormattingEnabled = True
        ComboBoxComingFrom.Items.AddRange(New Object() {"Reception", "Lab", "Pharmacy"})
        ComboBoxComingFrom.Location = New Point(166, 224)
        ComboBoxComingFrom.Name = "ComboBoxComingFrom"
        ComboBoxComingFrom.Size = New Size(182, 33)
        ComboBoxComingFrom.TabIndex = 20
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Location = New Point(10, 268)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(126, 25)
        LabelStatus.TabIndex = 19
        LabelStatus.Text = "Queue Status :"
        ' 
        ' LabelComingFrom
        ' 
        LabelComingFrom.AutoSize = True
        LabelComingFrom.Location = New Point(7, 227)
        LabelComingFrom.Name = "LabelComingFrom"
        LabelComingFrom.Size = New Size(131, 25)
        LabelComingFrom.TabIndex = 18
        LabelComingFrom.Text = "Coming From :"
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(166, 33)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(182, 31)
        TextBoxName.TabIndex = 17
        ' 
        ' TextBoxHomeaddress
        ' 
        TextBoxHomeaddress.Location = New Point(166, 188)
        TextBoxHomeaddress.Name = "TextBoxHomeaddress"
        TextBoxHomeaddress.Size = New Size(182, 31)
        TextBoxHomeaddress.TabIndex = 12
        ' 
        ' TextBoxAge
        ' 
        TextBoxAge.Location = New Point(166, 151)
        TextBoxAge.Name = "TextBoxAge"
        TextBoxAge.Size = New Size(182, 31)
        TextBoxAge.TabIndex = 11
        ' 
        ' TextBoxPhoneno
        ' 
        TextBoxPhoneno.Location = New Point(166, 113)
        TextBoxPhoneno.Name = "TextBoxPhoneno"
        TextBoxPhoneno.Size = New Size(182, 31)
        TextBoxPhoneno.TabIndex = 10
        ' 
        ' LabelHomeaddress
        ' 
        LabelHomeaddress.AutoSize = True
        LabelHomeaddress.Location = New Point(4, 194)
        LabelHomeaddress.Name = "LabelHomeaddress"
        LabelHomeaddress.Size = New Size(135, 25)
        LabelHomeaddress.TabIndex = 5
        LabelHomeaddress.Text = "Home Address:"
        ' 
        ' LabelAge
        ' 
        LabelAge.AutoSize = True
        LabelAge.Location = New Point(4, 155)
        LabelAge.Name = "LabelAge"
        LabelAge.Size = New Size(53, 25)
        LabelAge.TabIndex = 4
        LabelAge.Text = "Age :"
        ' 
        ' LabelPhoneno
        ' 
        LabelPhoneno.AutoSize = True
        LabelPhoneno.Location = New Point(4, 116)
        LabelPhoneno.Name = "LabelPhoneno"
        LabelPhoneno.Size = New Size(98, 25)
        LabelPhoneno.TabIndex = 3
        LabelPhoneno.Text = "Phone NO:"
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(7, 42)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(68, 25)
        LabelName.TabIndex = 1
        LabelName.Text = "Name :"
        ' 
        ' TextBoxPatientUPI
        ' 
        TextBoxPatientUPI.Location = New Point(166, 70)
        TextBoxPatientUPI.Name = "TextBoxPatientUPI"
        TextBoxPatientUPI.ReadOnly = True
        TextBoxPatientUPI.Size = New Size(182, 31)
        TextBoxPatientUPI.TabIndex = 15
        ' 
        ' LabelPatientUPI
        ' 
        LabelPatientUPI.AutoSize = True
        LabelPatientUPI.Font = New Font("Segoe UI", 9F)
        LabelPatientUPI.Location = New Point(4, 79)
        LabelPatientUPI.Name = "LabelPatientUPI"
        LabelPatientUPI.Size = New Size(101, 25)
        LabelPatientUPI.TabIndex = 8
        LabelPatientUPI.Text = "Patient UPI:"
        ' 
        ' LabelPatientDetails
        ' 
        LabelPatientDetails.AutoSize = True
        LabelPatientDetails.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPatientDetails.Location = New Point(158, 2)
        LabelPatientDetails.Name = "LabelPatientDetails"
        LabelPatientDetails.Size = New Size(152, 28)
        LabelPatientDetails.TabIndex = 0
        LabelPatientDetails.Text = "Patient Details"
        ' 
        ' LabelPatientRefferalForm
        ' 
        LabelPatientRefferalForm.AutoSize = True
        LabelPatientRefferalForm.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPatientRefferalForm.Location = New Point(177, -3)
        LabelPatientRefferalForm.Name = "LabelPatientRefferalForm"
        LabelPatientRefferalForm.Size = New Size(0, 28)
        LabelPatientRefferalForm.TabIndex = 1
        ' 
        ' TextBoxPrescription
        ' 
        TextBoxPrescription.Location = New Point(531, 451)
        TextBoxPrescription.Multiline = True
        TextBoxPrescription.Name = "TextBoxPrescription"
        TextBoxPrescription.Size = New Size(566, 62)
        TextBoxPrescription.TabIndex = 19
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' LabelPrescription
        ' 
        LabelPrescription.AutoSize = True
        LabelPrescription.Location = New Point(386, 459)
        LabelPrescription.Name = "LabelPrescription"
        LabelPrescription.Size = New Size(114, 25)
        LabelPrescription.TabIndex = 18
        LabelPrescription.Text = "Prescription :"
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "OpenFileDialog"
        OpenFileDialog.Filter = "*.pdf)|*.pdf|All Files (*.*)|*.*"""
        ' 
        ' LinkLabelEscAppointment
        ' 
        LinkLabelEscAppointment.AutoSize = True
        LinkLabelEscAppointment.Location = New Point(998, 777)
        LinkLabelEscAppointment.Name = "LinkLabelEscAppointment"
        LinkLabelEscAppointment.Size = New Size(160, 25)
        LinkLabelEscAppointment.TabIndex = 25
        LinkLabelEscAppointment.TabStop = True
        LinkLabelEscAppointment.Text = "AppointmentForm"
        ' 
        ' PatientTestForm
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        ClientSize = New Size(1273, 630)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientTestForm"
        Text = "PatientTestForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        PanelVitals.ResumeLayout(False)
        PanelVitals.PerformLayout()
        PanelPatientDetaisl.ResumeLayout(False)
        PanelPatientDetaisl.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LabelLabresults As Label
    Friend WithEvents PanelVitals As Panel
    Friend WithEvents LabelVitals As Label
    Friend WithEvents LabelPatientRefferalForm As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents LabelAllergies As Label
    Friend WithEvents LabelWeight As Label
    Friend WithEvents LabelHeight As Label
    Friend WithEvents LabelTemperature As Label
    Friend WithEvents LabelHeartbeat As Label
    Friend WithEvents LabelBloodpressure As Label
    Friend WithEvents LabelConcerns As Label
    Friend WithEvents LabelCurrentmedication As Label
    Friend WithEvents TextBoxConcerns As TextBox
    Friend WithEvents TextBoxCurrentmedication As TextBox
    Friend WithEvents TextBoxAllergies As TextBox
    Friend WithEvents TextBoxWeight As TextBox
    Friend WithEvents TextBoxHeight As TextBox
    Friend WithEvents TextBoxTemperature As TextBox
    Friend WithEvents TextBoxHeartbeat As TextBox
    Friend WithEvents TextBoxBloodpressure As TextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents RefferalButton As Button
    Friend WithEvents TextBoxDiagnosis As TextBox
    Friend WithEvents TextBoxPrescription As TextBox
    Friend WithEvents LabelPrescription As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelPatientDetaisl As Panel
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxHomeaddress As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxPhoneno As TextBox
    Friend WithEvents LabelHomeaddress As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelPhoneno As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents TextBoxPatientUPI As TextBox
    Friend WithEvents LabelPatientUPI As Label
    Friend WithEvents LabelPatientDetails As Label
    Friend WithEvents LabelLabTestNo As Label
    Friend WithEvents LabelStaffID As Label
    Friend WithEvents LabelTechName As Label
    Friend WithEvents TextBoxLabTestNo As TextBox
    Friend WithEvents TextBoxStaffID As TextBox
    Friend WithEvents TextBoxLabTechName As TextBox
    Friend WithEvents ButtonMakePurchase As Button
    Friend WithEvents LabelComingFrom As Label
    Friend WithEvents LinkLabelHomeEsc As LinkLabel
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ComboBoxPatientStatus As ComboBox
    Friend WithEvents ComboBoxComingFrom As ComboBox
    Friend WithEvents LinkLabelEscAppointment As LinkLabel
End Class
