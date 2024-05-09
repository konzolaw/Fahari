<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FollowupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FollowupForm))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabControl2 = New TabControl()
        TabPage3 = New TabPage()
        DataGridView1 = New DataGridView()
        AppointmentID = New DataGridViewTextBoxColumn()
        PatientUPI = New DataGridViewTextBoxColumn()
        From = New DataGridViewTextBoxColumn()
        ApoointmentNote = New DataGridViewTextBoxColumn()
        AppointmentDate = New DataGridViewTextBoxColumn()
        AppointmentPriority = New DataGridViewTextBoxColumn()
        Admit = New DataGridViewButtonColumn()
        TabPage2 = New TabPage()
        TabControl3 = New TabControl()
        TabPage5 = New TabPage()
        LinkLabelAppointment = New LinkLabel()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewButtonColumn1 = New DataGridViewButtonColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabControl2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabControl3.SuspendLayout()
        TabPage5.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(306, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 25)
        Label1.TabIndex = 0
        Label1.Text = "Notifications"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(0, 81)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1233, 679)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(TabControl2)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1225, 641)
        TabPage1.TabIndex = 0
        TabPage1.Text = "INBOX"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabControl2
        ' 
        TabControl2.Controls.Add(TabPage3)
        TabControl2.Location = New Point(6, 6)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(1213, 614)
        TabControl2.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(DataGridView1)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1205, 576)
        TabPage3.TabIndex = 0
        TabPage3.Text = "Appointment"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {AppointmentID, PatientUPI, From, ApoointmentNote, AppointmentDate, AppointmentPriority, Admit})
        DataGridView1.Location = New Point(6, 6)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1174, 535)
        DataGridView1.TabIndex = 0
        ' 
        ' AppointmentID
        ' 
        AppointmentID.HeaderText = "AppointmentID"
        AppointmentID.MinimumWidth = 8
        AppointmentID.Name = "AppointmentID"
        AppointmentID.Width = 150
        ' 
        ' PatientUPI
        ' 
        PatientUPI.HeaderText = "PatientUPI"
        PatientUPI.MinimumWidth = 8
        PatientUPI.Name = "PatientUPI"
        PatientUPI.Width = 150
        ' 
        ' From
        ' 
        From.HeaderText = "From"
        From.MinimumWidth = 8
        From.Name = "From"
        From.Width = 150
        ' 
        ' ApoointmentNote
        ' 
        ApoointmentNote.HeaderText = "ApoointmentNote"
        ApoointmentNote.MinimumWidth = 8
        ApoointmentNote.Name = "ApoointmentNote"
        ApoointmentNote.Width = 150
        ' 
        ' AppointmentDate
        ' 
        AppointmentDate.HeaderText = "AppointmentDate"
        AppointmentDate.MinimumWidth = 8
        AppointmentDate.Name = "AppointmentDate"
        AppointmentDate.Width = 150
        ' 
        ' AppointmentPriority
        ' 
        AppointmentPriority.HeaderText = "AppointmentPriority"
        AppointmentPriority.MinimumWidth = 8
        AppointmentPriority.Name = "AppointmentPriority"
        AppointmentPriority.Width = 150
        ' 
        ' Admit
        ' 
        Admit.HeaderText = "Admit"
        Admit.MinimumWidth = 8
        Admit.Name = "Admit"
        Admit.Width = 150
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(TabControl3)
        TabPage2.ForeColor = SystemColors.ControlText
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1225, 641)
        TabPage2.TabIndex = 1
        TabPage2.Text = "SENT"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabControl3
        ' 
        TabControl3.Controls.Add(TabPage5)
        TabControl3.Location = New Point(6, 6)
        TabControl3.Name = "TabControl3"
        TabControl3.SelectedIndex = 0
        TabControl3.Size = New Size(1213, 629)
        TabControl3.TabIndex = 0
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(DataGridView2)
        TabPage5.Location = New Point(4, 34)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(1205, 591)
        TabPage5.TabIndex = 0
        TabPage5.Text = "Appointment"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' LinkLabelAppointment
        ' 
        LinkLabelAppointment.AutoSize = True
        LinkLabelAppointment.Location = New Point(1028, 785)
        LinkLabelAppointment.Name = "LinkLabelAppointment"
        LinkLabelAppointment.Size = New Size(166, 25)
        LinkLabelAppointment.TabIndex = 3
        LinkLabelAppointment.TabStop = True
        LinkLabelAppointment.Text = "Make Appointment"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewButtonColumn1})
        DataGridView2.Location = New Point(15, 28)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 62
        DataGridView2.Size = New Size(1174, 535)
        DataGridView2.TabIndex = 1
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "AppointmentID"
        DataGridViewTextBoxColumn1.MinimumWidth = 8
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Width = 150
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "PatientUPI"
        DataGridViewTextBoxColumn2.MinimumWidth = 8
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.Width = 150
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "To"
        DataGridViewTextBoxColumn3.MinimumWidth = 8
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.Width = 150
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "ApoointmentNote"
        DataGridViewTextBoxColumn4.MinimumWidth = 8
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.Width = 150
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "AppointmentDate"
        DataGridViewTextBoxColumn5.MinimumWidth = 8
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.Width = 150
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.HeaderText = "AppointmentPriority"
        DataGridViewTextBoxColumn6.MinimumWidth = 8
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.Width = 150
        ' 
        ' DataGridViewButtonColumn1
        ' 
        DataGridViewButtonColumn1.HeaderText = "Follow UP"
        DataGridViewButtonColumn1.MinimumWidth = 8
        DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        DataGridViewButtonColumn1.Width = 150
        ' 
        ' FollowupForm
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(1245, 876)
        Controls.Add(LinkLabelAppointment)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FollowupForm"
        Text = "FollowupForm"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabControl2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabControl3.ResumeLayout(False)
        TabPage5.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LinkLabelAppointment As LinkLabel
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AppointmentID As DataGridViewTextBoxColumn
    Friend WithEvents PatientUPI As DataGridViewTextBoxColumn
    Friend WithEvents From As DataGridViewTextBoxColumn
    Friend WithEvents ApoointmentNote As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDate As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentPriority As DataGridViewTextBoxColumn
    Friend WithEvents Admit As DataGridViewButtonColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
End Class
