<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Panel1 = New Panel()
        Panel2 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        LabelPharmacyTitle = New Label()
        LabelPersonTitle = New Label()
        Panel4 = New Panel()
        TextBoxPharmacyappUserID = New TextBox()
        Label1 = New Label()
        TextBoxPharmactName = New TextBox()
        TextBoxPharmacyUHID = New TextBox()
        ComboBoxSubcounties = New ComboBox()
        ComboBoxCounties = New ComboBox()
        ComboBoxDepartment = New ComboBox()
        LabelWS = New Label()
        Label6 = New Label()
        LabelPharmacyLocation = New Label()
        LabelPharmacyUHID = New Label()
        LabelPharmacyName = New Label()
        Panel3 = New Panel()
        TextBox1 = New TextBox()
        Label1DateRegistered = New Label()
        ComboBoxGender = New ComboBox()
        LabelFirstname = New Label()
        SignupCopyPasswordTextBox = New TextBox()
        ComboBoxRole = New ComboBox()
        LabelConfirmPassword = New Label()
        SignupPasswordTextBox = New TextBox()
        LabelLastname = New Label()
        LabelRole = New Label()
        LabelPassword = New Label()
        SignupFirstnameTextBox = New TextBox()
        SignupLastnameTextBox = New TextBox()
        LabelStaffID = New Label()
        SignupStaffIdTextBox = New TextBox()
        LabelPhoneNO = New Label()
        SignupPhoneNOTextBox = New TextBox()
        SignupAgeTextBox = New TextBox()
        LabelEmailAddress = New Label()
        SignupEmailTextBox = New TextBox()
        LabelAge = New Label()
        LabelGender = New Label()
        ButtonSignup = New Button()
        Label9 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleTurquoise
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(2, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1195, 681)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(LabelPharmacyTitle)
        Panel2.Controls.Add(LabelPersonTitle)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(ButtonSignup)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(44, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1115, 678)
        Panel2.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(785, 34)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 28
        ' 
        ' LabelPharmacyTitle
        ' 
        LabelPharmacyTitle.AutoSize = True
        LabelPharmacyTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPharmacyTitle.Location = New Point(579, 66)
        LabelPharmacyTitle.Name = "LabelPharmacyTitle"
        LabelPharmacyTitle.Size = New Size(159, 25)
        LabelPharmacyTitle.TabIndex = 27
        LabelPharmacyTitle.Text = "Pharmacy Details"
        ' 
        ' LabelPersonTitle
        ' 
        LabelPersonTitle.AutoSize = True
        LabelPersonTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPersonTitle.Location = New Point(179, 66)
        LabelPersonTitle.Name = "LabelPersonTitle"
        LabelPersonTitle.Size = New Size(116, 25)
        LabelPersonTitle.TabIndex = 26
        LabelPersonTitle.Text = "Staff Details"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TextBoxPharmacyappUserID)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(TextBoxPharmactName)
        Panel4.Controls.Add(TextBoxPharmacyUHID)
        Panel4.Controls.Add(ComboBoxSubcounties)
        Panel4.Controls.Add(ComboBoxCounties)
        Panel4.Controls.Add(ComboBoxDepartment)
        Panel4.Controls.Add(LabelWS)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(LabelPharmacyLocation)
        Panel4.Controls.Add(LabelPharmacyUHID)
        Panel4.Controls.Add(LabelPharmacyName)
        Panel4.Location = New Point(440, 94)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(459, 450)
        Panel4.TabIndex = 25
        ' 
        ' TextBoxPharmacyappUserID
        ' 
        TextBoxPharmacyappUserID.Location = New Point(163, 66)
        TextBoxPharmacyappUserID.Name = "TextBoxPharmacyappUserID"
        TextBoxPharmacyappUserID.Size = New Size(150, 31)
        TextBoxPharmacyappUserID.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 10
        Label1.Text = "APP user ID:"
        ' 
        ' TextBoxPharmactName
        ' 
        TextBoxPharmactName.Location = New Point(162, 22)
        TextBoxPharmactName.Name = "TextBoxPharmactName"
        TextBoxPharmactName.Size = New Size(150, 31)
        TextBoxPharmactName.TabIndex = 9
        ' 
        ' TextBoxPharmacyUHID
        ' 
        TextBoxPharmacyUHID.Location = New Point(153, 110)
        TextBoxPharmacyUHID.Name = "TextBoxPharmacyUHID"
        TextBoxPharmacyUHID.Size = New Size(150, 31)
        TextBoxPharmacyUHID.TabIndex = 8
        ' 
        ' ComboBoxSubcounties
        ' 
        ComboBoxSubcounties.AllowDrop = True
        ComboBoxSubcounties.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBoxSubcounties.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxSubcounties.FlatStyle = FlatStyle.Popup
        ComboBoxSubcounties.FormattingEnabled = True
        ComboBoxSubcounties.Items.AddRange(New Object() {"Changamwe,", " Jomvu", "Kisauni", " Likoni", " Mvita", " Nyali", " Kinango", " Lungalunga", "Matuga", " Msambweni", "Chonyi", " Ganze", " Kaloleni", " Kambe-Ribe", " Kauma", " Kilifi North", "Kilifi South", " Magarini", "Malindi", "Rabai", " Bura", " Galole", " Garsen", " Lamu East", " Lamu West", " Mwatate", " Taveta", " Voi", "Wundanyi", " Balambala", " Dadaab", "Fafi", "Garissa", " Hulugho", " Ijara", " Lagdera", " Buna", " Eldas", " Habaswein", " Tarbaj", " Wajir East", "Wajir North", "Wajir South", "Wajir West", " Banissa", "Lafey", " Mandera East", " Mandera North", "Mandera South", " Mandera West", " Moyale", " Laisamis", " Loiyangalani", " Moyale", "North Horr", "Saku", " Garbatulla", "Isiolo", "Merti", "Buuri", "Central Imenti", " Igembe Central", " Igembe North", " Igembe South", " North Imenti", " South Imenti", " Tigania East", " Tigania West", " Chuka/Igambang'ombe", " Maara", " Tharaka North", " Tharaka South", "Manyatta", " Mbeere North", "Mbeere South", " Runyenjes", "Central", " Kitui East", " Kitui Rural", " Kitui South", " Kitui West", " Mwingi Central", " Mwingi North", " Mwingi West", " Kathiani", " Machakos Town", " Masinga", "Matungulu", " Mavoko", " Mwala", " Yatta", " Kaiti", " Kibwezi East", " Kibwezi West", " Kilome", " Makueni", "Mbooni", " Kinangop", " Kipipiri", " Ndaragwa", "Ol Kalou", "Ol Joro Orok", "Kieni East", " Kieni West", " Mathira East", " Mathira West", " Mukurweini", "Nyeri Town", " Othaya", " Tetu", "Gichugu", " Kirinyaga Central", "Mwea", " Ndia", "Gatanga", "Kahuro", "Kandara", " Kangema", " Kigumo", " Kiharu", " Mathioya", " Murang'a South", " Gatanga", " Gatundu North", " Gatundu South", " Githunguri", " Juja", "Kabete", " Kiambaa", " Kikuyu", " Kiambu Town", " Limuru", " Lari", "Ruiru", "Thika Town", " Turkana Central,", " Turkana East", " Turkana North", " Turkana South", " Turkana West", " Kapenguria", " Pokot Central", " Pokot North", " Pokot South", "Samburu East", " Samburu North", " Samburu West", " Cherangany", "Kiminini", " Kwanza", " Saboti", " Ainabkoi", "Kapseret", "Kesses", " Moiben", " Soy", " Turbo", "Keiyo North", " Keiyo South", " Marakwet East", " Marakwet West", "Aldai", " Chesumei", " Emgwen", " Mosop", "Nandi Hills", " Tindiret", "Baringo Central", " Baringo North", " Baringo South", " Eldama Ravine", " Mogotio", "Tiaty", " Laikipia East", " Laikipia North", " Laikipia West", " Bahati", " Gilgil", " Kuresoi North", " Kuresoi South", " Molo", " Naivasha", " Nakuru Town East", "Nakuru Town West", "Njoro", "Rongai", "Subukia", " Narok East", " Narok North", " Narok South", " Narok West", " Transmara East", " Transmara West", " Kajiado Central", "Kajiado East", "Kajiado North", " Kajiado South", "Kajiado West", " Ainamoi", " Belgut", " Bureti", " Kipkelion East", " Kipkelion West", " Sigowet/Soin", " Bomet Central", " Bomet East", " Chepalungu", " Konoin", " Sotik", " Butere", " Ikolomani", " Khwisero", " Likuyani", " Lugari", " Lurambi", " Malava", " Matungu", " Mumias East", " Mumias West", " Navakholo", "Shinyalu", " Emuhaya", " Hamisi", "Mbale", " Sabatia", " Vihiga", "Bumula", " Kabuchai", " Kanduyi", " Kimilili", " Mt. Elgon", " Sirisia", " Tongaren,", " Webuye East", " Webuye West", " Budalangi", " Butula", " Funyula", " Matayos", " Nambale", " Teso North", " Teso South", "Alego Usonga", " Bondo", " Gem", " Rarieda", " Ugenya", " Ugunja", " Kisumu Central", " Kisumu East", " Kisumu West", " Muhoroni", " Nyakach", " Nyando", " Seme", "Homa Bay Town", " Kabondo Kasipul", " Kasipul", " Karachuonyo", " Mbita", " Ndhiwa", " Rangwe", " Suba North", " Suba South", " Awendo", " Kuria East", " Kuria West", " Nyatike", " Rongo", " Suna East", " Suna West", " Uriri", "Bobasi", "Bomachoge Borabu", " Bomachoge Chache", " Bonchari", " Kenyenya", " Kisii Central", " Kisii South", " Marani", " Masaba North", " Nyaribari Chache", " Nyaribari Masaba", " Nyamira North", " Nyamira South", "Borabu", " Manga", " Masaba North", " Nyamira North", " Nyamira South", " Dagoretti North", " Dagoretti South", " Embakasi Central", " Embakasi East", " Embakasi North", " Embakasi South", " Embakasi West", " Kamukunji", " Kasarani", " Kibra", " Langata", "Makadara", " Mathare", " Roysambu", " Ruaraka", " Starehe", " Westlands", "", ""})
        ComboBoxSubcounties.Location = New Point(153, 232)
        ComboBoxSubcounties.MaxDropDownItems = 20
        ComboBoxSubcounties.Name = "ComboBoxSubcounties"
        ComboBoxSubcounties.Size = New Size(182, 33)
        ComboBoxSubcounties.TabIndex = 7
        ' 
        ' ComboBoxCounties
        ' 
        ComboBoxCounties.AllowDrop = True
        ComboBoxCounties.AutoCompleteCustomSource.AddRange(New String() {"", " Mombasa County: Changamwe, Jomvu, Kisauni, Likoni, Mvita, Nyali", " Kwale County: Kinango, Lungalunga, Matuga, Msambweni", " Kilifi County: Chonyi, Ganze, Kaloleni, Kambe-Ribe, Kauma, Kilifi North, Kilifi South, Magarini, Malindi, Rabai", "Tana River County: Bura, Galole, Garsen", " Lamu County: Lamu East, Lamu West", " Taita-Taveta County: Mwatate, Taveta, Voi, Wundanyi", " Garissa County: Balambala, Dadaab, Fafi, Garissa, Hulugho, Ijara, Lagdera", " Wajir County: Buna, Eldas, Habaswein, Tarbaj, Wajir East, Wajir North, Wajir South, Wajir West", " Mandera County: Banissa, Lafey, Mandera East, Mandera North, Mandera South, Mandera West, Moyale", "Marsabit County: Laisamis, Loiyangalani, Moyale, North Horr, Saku", "Isiolo County: Garbatulla, Isiolo, Merti", "Meru County: Buuri, Central Imenti, Igembe Central, Igembe North, Igembe South, North Imenti, South Imenti, Tigania East, Tigania West", "Tharaka-Nithi County: Chuka/Igambang'ombe, Maara, Tharaka North, Tharaka South", "Embu County: Manyatta, Mbeere North, Mbeere South, Runyenjes", "Kitui County: Central, Kitui East, Kitui Rural, Kitui South, Kitui West, Mwingi Central, Mwingi North, Mwingi West", "Machakos County: Kathiani, Machakos Town, Masinga, Matungulu, Mavoko, Mwala, Yatta", "Makueni County: Kaiti, Kibwezi East, Kibwezi West, Kilome, Makueni, Mbooni", " Nyandarua County: Kinangop, Kipipiri, Ndaragwa, Ol Kalou, Ol Joro Orok", " Nyeri County: Kieni East, Kieni West, Mathira East, Mathira West, Mukurweini, Nyeri Town, Othaya, Tetu", " Kirinyaga County: Gichugu, Kirinyaga Central, Mwea, Ndia", " Murang'a County: Gatanga, Kahuro, Kandara, Kangema, Kigumo, Kiharu, Mathioya, Murang'a South", "Kiambu County: Gatanga, Gatundu North, Gatundu South, Githunguri, Juja, Kabete, Kiambaa, Kikuyu, Kiambu Town, Limuru, Lari, Ruiru, Thika Town", "Turkana County: Turkana Central, Turkana East, Turkana North, Turkana South, Turkana West", " West Pokot County: Kapenguria, Pokot Central, Pokot North, Pokot South", "Samburu County: Samburu East, Samburu North, Samburu West", "Trans Nzoia County: Cherangany, Kiminini, Kwanza, Saboti", "Uasin Gishu County: Ainabkoi, Kapseret, Kesses, Moiben, Soy, Turbo", " Elgeyo-Marakwet County: Keiyo North, Keiyo South, Marakwet East, Marakwet West", " Nandi County: Aldai, Chesumei, Emgwen, Mosop, Nandi Hills, Tindiret", "Baringo County: Baringo Central, Baringo North, Baringo South, Eldama Ravine, Mogotio, Tiaty", " Laikipia County: Laikipia East, Laikipia North, Laikipia West", " Nakuru County: Bahati, Gilgil, Kuresoi North, Kuresoi South, Molo, Naivasha, Nakuru Town East, Nakuru Town West, Njoro, Rongai, Subukia", "Narok County: Narok East, Narok North, Narok South, Narok West, Transmara East, Transmara West", " Kajiado County: Kajiado Central, Kajiado East, Kajiado North, Kajiado South, Kajiado West", " Kericho County: Ainamoi, Belgut, Bureti, Kipkelion East, Kipkelion West, Sigowet/Soin", "Bomet County: Bomet Central, Bomet East, Chepalungu, Konoin, Sotik", " Kakamega County: Butere, Ikolomani, Khwisero, Likuyani, Lugari, Lurambi, Malava, Matungu, Mumias East, Mumias West, Navakholo, Shinyalu", " Vihiga County: Emuhaya, Hamisi, Mbale, Sabatia, Vihiga", " Bungoma County: Bumula, Kabuchai, Kanduyi, Kimilili, Mt. Elgon, Sirisia, Tongaren, Webuye East, Webuye West", " Busia County: Budalangi, Butula, Funyula, Matayos, Nambale, Teso North, Teso South", "Siaya County: Alego Usonga, Bondo, Gem, Rarieda, Ugenya, Ugunja", " Kisumu County: Kisumu Central, Kisumu East, Kisumu West, Muhoroni, Nyakach, Nyando, Seme", " Homa Bay County: Homa Bay Town, Kabondo Kasipul, Kasipul, Karachuonyo, Mbita, Ndhiwa, Rangwe, Suba North, Suba South", " Migori County: Awendo, Kuria East, Kuria West, Nyatike, Rongo, Suna East, Suna West, Uriri", " Kisii County: Bobasi, Bomachoge Borabu, Bomachoge Chache, Bonchari, Kenyenya, Kisii Central, Kisii South, Marani, Masaba North, Nyaribari Chache, Nyaribari Masaba, Nyamira North, Nyamira South", " Nyamira County: Borabu, Manga, Masaba North, Nyamira North, Nyamira South", resources.GetString("ComboBoxCounties.AutoCompleteCustomSource"), ""})
        ComboBoxCounties.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBoxCounties.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxCounties.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxCounties.FlatStyle = FlatStyle.Popup
        ComboBoxCounties.FormattingEnabled = True
        ComboBoxCounties.Items.AddRange(New Object() {"Mombasa", "Kwale", "Kilifi", "Tana River", "Lamu", "Taita Taveta", "Garissa", "Wajir", "Mandera", "Marsabit", "Isiolo", "Meru", "Tharaka Nithi", "Embu", "Kitui", "Machakos", "Makueni", "Nyandarua", "Nyeri", "Kirinyaga", "Murang'a", "Kiambu", "Turkana", "West Pokot", "Samburu", "Trans Nzoia", "Uasin Gishu", "Elgeyo Marakwet", "Nandi", "Baringo", "Laikipia", "Nakuru", "Narok", "Kajiado", "Kericho", "Bomet", "Kakamega", "Vihiga", "Bungoma", "Busia", "Siaya", "Kisumu", "Homa Bay", "Migori", "Kisii", "Nyamira", "Nairobi"})
        ComboBoxCounties.Location = New Point(153, 186)
        ComboBoxCounties.MaxDropDownItems = 20
        ComboBoxCounties.Name = "ComboBoxCounties"
        ComboBoxCounties.Size = New Size(182, 33)
        ComboBoxCounties.TabIndex = 6
        ' 
        ' ComboBoxDepartment
        ' 
        ComboBoxDepartment.FormattingEnabled = True
        ComboBoxDepartment.Items.AddRange(New Object() {"Pharmacy", "Labaratory"})
        ComboBoxDepartment.Location = New Point(153, 147)
        ComboBoxDepartment.Name = "ComboBoxDepartment"
        ComboBoxDepartment.Size = New Size(182, 33)
        ComboBoxDepartment.TabIndex = 5
        ' 
        ' LabelWS
        ' 
        LabelWS.AutoSize = True
        LabelWS.Location = New Point(25, 147)
        LabelWS.Name = "LabelWS"
        LabelWS.Size = New Size(111, 25)
        LabelWS.TabIndex = 4
        LabelWS.Text = "Department:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(-1, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 25)
        Label6.TabIndex = 3
        Label6.Text = "Home Subcounty:"
        ' 
        ' LabelPharmacyLocation
        ' 
        LabelPharmacyLocation.AutoSize = True
        LabelPharmacyLocation.Location = New Point(9, 189)
        LabelPharmacyLocation.Name = "LabelPharmacyLocation"
        LabelPharmacyLocation.Size = New Size(127, 25)
        LabelPharmacyLocation.TabIndex = 2
        LabelPharmacyLocation.Text = "Home County:"
        ' 
        ' LabelPharmacyUHID
        ' 
        LabelPharmacyUHID.AutoSize = True
        LabelPharmacyUHID.Location = New Point(3, 113)
        LabelPharmacyUHID.Name = "LabelPharmacyUHID"
        LabelPharmacyUHID.Size = New Size(141, 25)
        LabelPharmacyUHID.TabIndex = 1
        LabelPharmacyUHID.Text = "Pharmacy UHID:"
        ' 
        ' LabelPharmacyName
        ' 
        LabelPharmacyName.AutoSize = True
        LabelPharmacyName.Location = New Point(14, 20)
        LabelPharmacyName.Name = "LabelPharmacyName"
        LabelPharmacyName.Size = New Size(145, 25)
        LabelPharmacyName.TabIndex = 0
        LabelPharmacyName.Text = "Pharmacy Name:"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label1DateRegistered)
        Panel3.Controls.Add(ComboBoxGender)
        Panel3.Controls.Add(LabelFirstname)
        Panel3.Controls.Add(SignupCopyPasswordTextBox)
        Panel3.Controls.Add(ComboBoxRole)
        Panel3.Controls.Add(LabelConfirmPassword)
        Panel3.Controls.Add(SignupPasswordTextBox)
        Panel3.Controls.Add(LabelLastname)
        Panel3.Controls.Add(LabelRole)
        Panel3.Controls.Add(LabelPassword)
        Panel3.Controls.Add(SignupFirstnameTextBox)
        Panel3.Controls.Add(SignupLastnameTextBox)
        Panel3.Controls.Add(LabelStaffID)
        Panel3.Controls.Add(SignupStaffIdTextBox)
        Panel3.Controls.Add(LabelPhoneNO)
        Panel3.Controls.Add(SignupPhoneNOTextBox)
        Panel3.Controls.Add(SignupAgeTextBox)
        Panel3.Controls.Add(LabelEmailAddress)
        Panel3.Controls.Add(SignupEmailTextBox)
        Panel3.Controls.Add(LabelAge)
        Panel3.Controls.Add(LabelGender)
        Panel3.Location = New Point(3, 94)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(440, 453)
        Panel3.TabIndex = 24
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(190, 414)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(241, 31)
        TextBox1.TabIndex = 26
        ' 
        ' Label1DateRegistered
        ' 
        Label1DateRegistered.AutoSize = True
        Label1DateRegistered.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1DateRegistered.Location = New Point(17, 412)
        Label1DateRegistered.Name = "Label1DateRegistered"
        Label1DateRegistered.Size = New Size(153, 25)
        Label1DateRegistered.TabIndex = 25
        Label1DateRegistered.Text = "Date Registered:"
        ' 
        ' ComboBoxGender
        ' 
        ComboBoxGender.FormattingEnabled = True
        ComboBoxGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        ComboBoxGender.Location = New Point(140, 207)
        ComboBoxGender.Name = "ComboBoxGender"
        ComboBoxGender.Size = New Size(182, 33)
        ComboBoxGender.TabIndex = 24
        ' 
        ' LabelFirstname
        ' 
        LabelFirstname.AutoSize = True
        LabelFirstname.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelFirstname.Location = New Point(-3, 6)
        LabelFirstname.Name = "LabelFirstname"
        LabelFirstname.Size = New Size(113, 25)
        LabelFirstname.TabIndex = 1
        LabelFirstname.Text = "First Name :"
        ' 
        ' SignupCopyPasswordTextBox
        ' 
        SignupCopyPasswordTextBox.Location = New Point(187, 373)
        SignupCopyPasswordTextBox.Name = "SignupCopyPasswordTextBox"
        SignupCopyPasswordTextBox.Size = New Size(245, 31)
        SignupCopyPasswordTextBox.TabIndex = 21
        ' 
        ' ComboBoxRole
        ' 
        ComboBoxRole.FormattingEnabled = True
        ComboBoxRole.Items.AddRange(New Object() {"Pharmacist", "Lab Technician"})
        ComboBoxRole.Location = New Point(110, 288)
        ComboBoxRole.Name = "ComboBoxRole"
        ComboBoxRole.Size = New Size(182, 33)
        ComboBoxRole.TabIndex = 23
        ' 
        ' LabelConfirmPassword
        ' 
        LabelConfirmPassword.AutoSize = True
        LabelConfirmPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelConfirmPassword.Location = New Point(6, 376)
        LabelConfirmPassword.Name = "LabelConfirmPassword"
        LabelConfirmPassword.Size = New Size(175, 25)
        LabelConfirmPassword.TabIndex = 19
        LabelConfirmPassword.Text = "Confirm Password :"
        ' 
        ' SignupPasswordTextBox
        ' 
        SignupPasswordTextBox.Location = New Point(106, 331)
        SignupPasswordTextBox.Name = "SignupPasswordTextBox"
        SignupPasswordTextBox.Size = New Size(245, 31)
        SignupPasswordTextBox.TabIndex = 20
        ' 
        ' LabelLastname
        ' 
        LabelLastname.AutoSize = True
        LabelLastname.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelLastname.Location = New Point(-3, 41)
        LabelLastname.Name = "LabelLastname"
        LabelLastname.Size = New Size(106, 25)
        LabelLastname.TabIndex = 2
        LabelLastname.Text = "Last Name:"
        ' 
        ' LabelRole
        ' 
        LabelRole.AutoSize = True
        LabelRole.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRole.Location = New Point(14, 288)
        LabelRole.Name = "LabelRole"
        LabelRole.Size = New Size(60, 25)
        LabelRole.TabIndex = 22
        LabelRole.Text = "Role :"
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPassword.Location = New Point(6, 334)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(102, 25)
        LabelPassword.TabIndex = 18
        LabelPassword.Text = "Password :"
        ' 
        ' SignupFirstnameTextBox
        ' 
        SignupFirstnameTextBox.Location = New Point(116, 9)
        SignupFirstnameTextBox.Name = "SignupFirstnameTextBox"
        SignupFirstnameTextBox.Size = New Size(245, 31)
        SignupFirstnameTextBox.TabIndex = 10
        ' 
        ' SignupLastnameTextBox
        ' 
        SignupLastnameTextBox.Location = New Point(116, 46)
        SignupLastnameTextBox.Name = "SignupLastnameTextBox"
        SignupLastnameTextBox.Size = New Size(241, 31)
        SignupLastnameTextBox.TabIndex = 14
        ' 
        ' LabelStaffID
        ' 
        LabelStaffID.AutoSize = True
        LabelStaffID.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelStaffID.Location = New Point(3, 84)
        LabelStaffID.Name = "LabelStaffID"
        LabelStaffID.Size = New Size(87, 25)
        LabelStaffID.TabIndex = 3
        LabelStaffID.Text = "Staff ID :"
        ' 
        ' SignupStaffIdTextBox
        ' 
        SignupStaffIdTextBox.Location = New Point(112, 84)
        SignupStaffIdTextBox.Name = "SignupStaffIdTextBox"
        SignupStaffIdTextBox.Size = New Size(245, 31)
        SignupStaffIdTextBox.TabIndex = 11
        ' 
        ' LabelPhoneNO
        ' 
        LabelPhoneNO.AutoSize = True
        LabelPhoneNO.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPhoneNO.Location = New Point(0, 122)
        LabelPhoneNO.Name = "LabelPhoneNO"
        LabelPhoneNO.Size = New Size(104, 25)
        LabelPhoneNO.TabIndex = 4
        LabelPhoneNO.Text = "PhoneNO :"
        ' 
        ' SignupPhoneNOTextBox
        ' 
        SignupPhoneNOTextBox.Location = New Point(110, 131)
        SignupPhoneNOTextBox.Name = "SignupPhoneNOTextBox"
        SignupPhoneNOTextBox.Size = New Size(245, 31)
        SignupPhoneNOTextBox.TabIndex = 12
        ' 
        ' SignupAgeTextBox
        ' 
        SignupAgeTextBox.Location = New Point(110, 245)
        SignupAgeTextBox.Name = "SignupAgeTextBox"
        SignupAgeTextBox.Size = New Size(241, 31)
        SignupAgeTextBox.TabIndex = 16
        ' 
        ' LabelEmailAddress
        ' 
        LabelEmailAddress.AutoSize = True
        LabelEmailAddress.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelEmailAddress.Location = New Point(-3, 165)
        LabelEmailAddress.Name = "LabelEmailAddress"
        LabelEmailAddress.Size = New Size(141, 25)
        LabelEmailAddress.TabIndex = 7
        LabelEmailAddress.Text = "Email Address :"
        ' 
        ' SignupEmailTextBox
        ' 
        SignupEmailTextBox.Location = New Point(144, 168)
        SignupEmailTextBox.Name = "SignupEmailTextBox"
        SignupEmailTextBox.Size = New Size(245, 31)
        SignupEmailTextBox.TabIndex = 13
        ' 
        ' LabelAge
        ' 
        LabelAge.AutoSize = True
        LabelAge.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelAge.Location = New Point(18, 245)
        LabelAge.Name = "LabelAge"
        LabelAge.Size = New Size(56, 25)
        LabelAge.TabIndex = 5
        LabelAge.Text = "Age :"
        ' 
        ' LabelGender
        ' 
        LabelGender.AutoSize = True
        LabelGender.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelGender.Location = New Point(6, 207)
        LabelGender.Name = "LabelGender"
        LabelGender.Size = New Size(84, 25)
        LabelGender.TabIndex = 6
        LabelGender.Text = "Gender :"
        ' 
        ' ButtonSignup
        ' 
        ButtonSignup.BackColor = Color.Cyan
        ButtonSignup.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSignup.Location = New Point(476, 594)
        ButtonSignup.Name = "ButtonSignup"
        ButtonSignup.Size = New Size(112, 53)
        ButtonSignup.TabIndex = 17
        ButtonSignup.Text = "SIGN UP"
        ButtonSignup.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(452, 3)
        Label9.Name = "Label9"
        Label9.Size = New Size(146, 25)
        Label9.TabIndex = 9
        Label9.Text = "SIGN UP FORM "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(512, 283)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 25)
        Label8.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1209, 705)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignUpForm"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelEmailAddress As Label
    Friend WithEvents LabelGender As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelPhoneNO As Label
    Friend WithEvents LabelStaffID As Label
    Friend WithEvents LabelLastname As Label
    Friend WithEvents LabelFirstname As Label
    Friend WithEvents ButtonSignup As Button
    Friend WithEvents SignupAgeTextBox As TextBox
    Friend WithEvents SignupLastnameTextBox As TextBox
    Friend WithEvents SignupEmailTextBox As TextBox
    Friend WithEvents SignupPhoneNOTextBox As TextBox
    Friend WithEvents SignupStaffIdTextBox As TextBox
    Friend WithEvents SignupFirstnameTextBox As TextBox
    Friend WithEvents SignupCopyPasswordTextBox As TextBox
    Friend WithEvents SignupPasswordTextBox As TextBox
    Friend WithEvents LabelConfirmPassword As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ComboBoxRole As ComboBox
    Friend WithEvents LabelRole As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LabelPharmacyTitle As Label
    Friend WithEvents LabelPersonTitle As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LabelWS As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelPharmacyLocation As Label
    Friend WithEvents LabelPharmacyUHID As Label
    Friend WithEvents Label1DateRegistered As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxPharmacyUHID As TextBox
    Friend WithEvents ComboBoxDepartment As ComboBox
    Friend WithEvents TextBoxPharmactName As TextBox
    Friend WithEvents ComboBoxSubcounties As ComboBox
    Friend WithEvents ComboBoxCounties As ComboBox
    Friend WithEvents LabelPharmacyName As Label
    Friend WithEvents TextBoxPharmacyappUserID As TextBox
    Friend WithEvents Label1 As Label
End Class
