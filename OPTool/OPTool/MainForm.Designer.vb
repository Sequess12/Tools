﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.InfoTextBox = New System.Windows.Forms.TextBox()
        Me.Character = New System.Windows.Forms.GroupBox()
        Me.ShowDeleted = New System.Windows.Forms.CheckBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.CharacterName = New System.Windows.Forms.ComboBox()
        Me.CharacterNo = New System.Windows.Forms.TextBox()
        Me.AccountNo = New System.Windows.Forms.TextBox()
        Me.CharacterNoLabel = New System.Windows.Forms.Label()
        Me.AccountNoLabel = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.Button()
        Me.AccountID = New System.Windows.Forms.TextBox()
        Me.AccountIDLabel = New System.Windows.Forms.Label()
        Me.CharacterNameLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CharacterCreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriendListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemCreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Done = New System.Windows.Forms.Button()
        Me.GAMEditor = New System.Windows.Forms.GroupBox()
        Me.ServerSelect = New System.Windows.Forms.ComboBox()
        Me.GuildEditor = New System.Windows.Forms.Button()
        Me.GuildMembersLabel = New System.Windows.Forms.Label()
        Me.GuildLabel = New System.Windows.Forms.Label()
        Me.Divorce = New System.Windows.Forms.Button()
        Me.CharacterEditor = New System.Windows.Forms.GroupBox()
        Me.Money = New System.Windows.Forms.TextBox()
        Me.MoneyLabel = New System.Windows.Forms.Label()
        Me.KQLogin = New System.Windows.Forms.TextBox()
        Me.Level = New System.Windows.Forms.ComboBox()
        Me.KQLabel = New System.Windows.Forms.Label()
        Me.AdminLevelLabel = New System.Windows.Forms.Label()
        Me.SPR = New System.Windows.Forms.ComboBox()
        Me.AdminLevel = New System.Windows.Forms.TextBox()
        Me.SPRLabel = New System.Windows.Forms.Label()
        Me.LoginZoneLabel = New System.Windows.Forms.Label()
        Me.INT = New System.Windows.Forms.ComboBox()
        Me.LoginZone = New System.Windows.Forms.TextBox()
        Me.ENDBox = New System.Windows.Forms.ComboBox()
        Me.STRLabel = New System.Windows.Forms.Label()
        Me.DEX = New System.Windows.Forms.ComboBox()
        Me.DexLabel = New System.Windows.Forms.Label()
        Me.STR = New System.Windows.Forms.ComboBox()
        Me.ENDLabel = New System.Windows.Forms.Label()
        Me.INTLabel = New System.Windows.Forms.Label()
        Me.CharacterShape = New System.Windows.Forms.GroupBox()
        Me.Gender = New System.Windows.Forms.Label()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.KlasseLabel = New System.Windows.Forms.Label()
        Me.Klasse = New System.Windows.Forms.ComboBox()
        Me.RegistredAccounts = New System.Windows.Forms.Label()
        Me.Character.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GAMEditor.SuspendLayout()
        Me.CharacterEditor.SuspendLayout()
        Me.CharacterShape.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfoTextBox
        '
        Me.InfoTextBox.Location = New System.Drawing.Point(12, 365)
        Me.InfoTextBox.Multiline = True
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.ReadOnly = True
        Me.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InfoTextBox.Size = New System.Drawing.Size(913, 48)
        Me.InfoTextBox.TabIndex = 0
        '
        'Character
        '
        Me.Character.Controls.Add(Me.ShowDeleted)
        Me.Character.Controls.Add(Me.Clear)
        Me.Character.Controls.Add(Me.CharacterName)
        Me.Character.Controls.Add(Me.CharacterNo)
        Me.Character.Controls.Add(Me.AccountNo)
        Me.Character.Controls.Add(Me.CharacterNoLabel)
        Me.Character.Controls.Add(Me.AccountNoLabel)
        Me.Character.Controls.Add(Me.Search)
        Me.Character.Controls.Add(Me.AccountID)
        Me.Character.Controls.Add(Me.AccountIDLabel)
        Me.Character.Controls.Add(Me.CharacterNameLabel)
        Me.Character.Location = New System.Drawing.Point(6, 21)
        Me.Character.Name = "Character"
        Me.Character.Size = New System.Drawing.Size(357, 107)
        Me.Character.TabIndex = 1
        Me.Character.TabStop = False
        Me.Character.Text = "Search:"
        '
        'ShowDeleted
        '
        Me.ShowDeleted.AutoSize = True
        Me.ShowDeleted.Location = New System.Drawing.Point(6, 82)
        Me.ShowDeleted.Name = "ShowDeleted"
        Me.ShowDeleted.Size = New System.Drawing.Size(147, 17)
        Me.ShowDeleted.TabIndex = 24
        Me.ShowDeleted.Text = "Show Deleted Characters"
        Me.ShowDeleted.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(175, 78)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 23
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'CharacterName
        '
        Me.CharacterName.FormattingEnabled = True
        Me.CharacterName.Location = New System.Drawing.Point(99, 53)
        Me.CharacterName.Name = "CharacterName"
        Me.CharacterName.Size = New System.Drawing.Size(106, 21)
        Me.CharacterName.TabIndex = 5
        '
        'CharacterNo
        '
        Me.CharacterNo.Location = New System.Drawing.Point(284, 53)
        Me.CharacterNo.Name = "CharacterNo"
        Me.CharacterNo.Size = New System.Drawing.Size(67, 20)
        Me.CharacterNo.TabIndex = 5
        '
        'AccountNo
        '
        Me.AccountNo.Location = New System.Drawing.Point(284, 26)
        Me.AccountNo.Name = "AccountNo"
        Me.AccountNo.Size = New System.Drawing.Size(67, 20)
        Me.AccountNo.TabIndex = 4
        '
        'CharacterNoLabel
        '
        Me.CharacterNoLabel.AutoSize = True
        Me.CharacterNoLabel.Location = New System.Drawing.Point(211, 56)
        Me.CharacterNoLabel.Name = "CharacterNoLabel"
        Me.CharacterNoLabel.Size = New System.Drawing.Size(73, 13)
        Me.CharacterNoLabel.TabIndex = 4
        Me.CharacterNoLabel.Text = "Character No:"
        '
        'AccountNoLabel
        '
        Me.AccountNoLabel.AutoSize = True
        Me.AccountNoLabel.Location = New System.Drawing.Point(211, 29)
        Me.AccountNoLabel.Name = "AccountNoLabel"
        Me.AccountNoLabel.Size = New System.Drawing.Size(67, 13)
        Me.AccountNoLabel.TabIndex = 4
        Me.AccountNoLabel.Text = "Account No:"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(256, 78)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(75, 23)
        Me.Search.TabIndex = 3
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'AccountID
        '
        Me.AccountID.Location = New System.Drawing.Point(99, 26)
        Me.AccountID.Name = "AccountID"
        Me.AccountID.Size = New System.Drawing.Size(106, 20)
        Me.AccountID.TabIndex = 3
        '
        'AccountIDLabel
        '
        Me.AccountIDLabel.AutoSize = True
        Me.AccountIDLabel.Location = New System.Drawing.Point(6, 29)
        Me.AccountIDLabel.Name = "AccountIDLabel"
        Me.AccountIDLabel.Size = New System.Drawing.Size(64, 13)
        Me.AccountIDLabel.TabIndex = 3
        Me.AccountIDLabel.Text = "Account ID:"
        '
        'CharacterNameLabel
        '
        Me.CharacterNameLabel.AutoSize = True
        Me.CharacterNameLabel.Location = New System.Drawing.Point(6, 56)
        Me.CharacterNameLabel.Name = "CharacterNameLabel"
        Me.CharacterNameLabel.Size = New System.Drawing.Size(87, 13)
        Me.CharacterNameLabel.TabIndex = 3
        Me.CharacterNameLabel.Text = "Character Name:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.CharacterEditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(937, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountEditorToolStripMenuItem, Me.ServerManagerToolStripMenuItem, Me.ToolStripSeparator3, Me.CharacterCreateToolStripMenuItem, Me.FriendListToolStripMenuItem, Me.ToolStripSeparator2, Me.CloseToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AccountEditorToolStripMenuItem
        '
        Me.AccountEditorToolStripMenuItem.Name = "AccountEditorToolStripMenuItem"
        Me.AccountEditorToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AccountEditorToolStripMenuItem.Text = "Account Editor"
        '
        'ServerManagerToolStripMenuItem
        '
        Me.ServerManagerToolStripMenuItem.Name = "ServerManagerToolStripMenuItem"
        Me.ServerManagerToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ServerManagerToolStripMenuItem.Text = "Server Manager"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(160, 6)
        '
        'CharacterCreateToolStripMenuItem
        '
        Me.CharacterCreateToolStripMenuItem.Name = "CharacterCreateToolStripMenuItem"
        Me.CharacterCreateToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CharacterCreateToolStripMenuItem.Text = "Character Search"
        '
        'FriendListToolStripMenuItem
        '
        Me.FriendListToolStripMenuItem.Name = "FriendListToolStripMenuItem"
        Me.FriendListToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.FriendListToolStripMenuItem.Text = "Friend List"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'CharacterEditToolStripMenuItem
        '
        Me.CharacterEditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemCreateToolStripMenuItem})
        Me.CharacterEditToolStripMenuItem.Name = "CharacterEditToolStripMenuItem"
        Me.CharacterEditToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.CharacterEditToolStripMenuItem.Text = "Editor"
        '
        'ItemCreateToolStripMenuItem
        '
        Me.ItemCreateToolStripMenuItem.Name = "ItemCreateToolStripMenuItem"
        Me.ItemCreateToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ItemCreateToolStripMenuItem.Text = "Item Create"
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(9, 24)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(36, 13)
        Me.LevelLabel.TabIndex = 0
        Me.LevelLabel.Text = "Level:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RegistredAccounts)
        Me.GroupBox1.Controls.Add(Me.Done)
        Me.GroupBox1.Controls.Add(Me.GAMEditor)
        Me.GroupBox1.Controls.Add(Me.CharacterEditor)
        Me.GroupBox1.Controls.Add(Me.Character)
        Me.GroupBox1.Controls.Add(Me.CharacterShape)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(913, 332)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Character Edit"
        '
        'Done
        '
        Me.Done.Location = New System.Drawing.Point(15, 303)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(75, 23)
        Me.Done.TabIndex = 4
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = True
        '
        'GAMEditor
        '
        Me.GAMEditor.Controls.Add(Me.ServerSelect)
        Me.GAMEditor.Controls.Add(Me.GuildEditor)
        Me.GAMEditor.Controls.Add(Me.GuildMembersLabel)
        Me.GAMEditor.Controls.Add(Me.GuildLabel)
        Me.GAMEditor.Controls.Add(Me.Divorce)
        Me.GAMEditor.Location = New System.Drawing.Point(380, 184)
        Me.GAMEditor.Name = "GAMEditor"
        Me.GAMEditor.Size = New System.Drawing.Size(527, 148)
        Me.GAMEditor.TabIndex = 25
        Me.GAMEditor.TabStop = False
        Me.GAMEditor.Text = "Guild and Marriage Editor"
        '
        'ServerSelect
        '
        Me.ServerSelect.FormattingEnabled = True
        Me.ServerSelect.Items.AddRange(New Object() {"Server 01", "Server 02"})
        Me.ServerSelect.Location = New System.Drawing.Point(400, 19)
        Me.ServerSelect.Name = "ServerSelect"
        Me.ServerSelect.Size = New System.Drawing.Size(121, 21)
        Me.ServerSelect.TabIndex = 5
        Me.ServerSelect.Text = "Server 01"
        '
        'GuildEditor
        '
        Me.GuildEditor.Location = New System.Drawing.Point(14, 59)
        Me.GuildEditor.Name = "GuildEditor"
        Me.GuildEditor.Size = New System.Drawing.Size(75, 23)
        Me.GuildEditor.TabIndex = 4
        Me.GuildEditor.Text = "GuildEditor"
        Me.GuildEditor.UseVisualStyleBackColor = True
        '
        'GuildMembersLabel
        '
        Me.GuildMembersLabel.AutoSize = True
        Me.GuildMembersLabel.Location = New System.Drawing.Point(11, 124)
        Me.GuildMembersLabel.Name = "GuildMembersLabel"
        Me.GuildMembersLabel.Size = New System.Drawing.Size(117, 13)
        Me.GuildMembersLabel.TabIndex = 3
        Me.GuildMembersLabel.Text = "Guild Members Counter"
        Me.GuildMembersLabel.Visible = False
        '
        'GuildLabel
        '
        Me.GuildLabel.AutoSize = True
        Me.GuildLabel.Location = New System.Drawing.Point(11, 99)
        Me.GuildLabel.Name = "GuildLabel"
        Me.GuildLabel.Size = New System.Drawing.Size(150, 13)
        Me.GuildLabel.TabIndex = 1
        Me.GuildLabel.Text = "Please search for a Character!"
        '
        'Divorce
        '
        Me.Divorce.Location = New System.Drawing.Point(12, 30)
        Me.Divorce.Name = "Divorce"
        Me.Divorce.Size = New System.Drawing.Size(75, 23)
        Me.Divorce.TabIndex = 0
        Me.Divorce.Text = "Divorce"
        Me.Divorce.UseVisualStyleBackColor = True
        '
        'CharacterEditor
        '
        Me.CharacterEditor.Controls.Add(Me.Money)
        Me.CharacterEditor.Controls.Add(Me.MoneyLabel)
        Me.CharacterEditor.Controls.Add(Me.LevelLabel)
        Me.CharacterEditor.Controls.Add(Me.KQLogin)
        Me.CharacterEditor.Controls.Add(Me.Level)
        Me.CharacterEditor.Controls.Add(Me.KQLabel)
        Me.CharacterEditor.Controls.Add(Me.AdminLevelLabel)
        Me.CharacterEditor.Controls.Add(Me.SPR)
        Me.CharacterEditor.Controls.Add(Me.AdminLevel)
        Me.CharacterEditor.Controls.Add(Me.SPRLabel)
        Me.CharacterEditor.Controls.Add(Me.LoginZoneLabel)
        Me.CharacterEditor.Controls.Add(Me.INT)
        Me.CharacterEditor.Controls.Add(Me.LoginZone)
        Me.CharacterEditor.Controls.Add(Me.ENDBox)
        Me.CharacterEditor.Controls.Add(Me.STRLabel)
        Me.CharacterEditor.Controls.Add(Me.DEX)
        Me.CharacterEditor.Controls.Add(Me.DexLabel)
        Me.CharacterEditor.Controls.Add(Me.STR)
        Me.CharacterEditor.Controls.Add(Me.ENDLabel)
        Me.CharacterEditor.Controls.Add(Me.INTLabel)
        Me.CharacterEditor.Location = New System.Drawing.Point(380, 30)
        Me.CharacterEditor.Name = "CharacterEditor"
        Me.CharacterEditor.Size = New System.Drawing.Size(527, 148)
        Me.CharacterEditor.TabIndex = 24
        Me.CharacterEditor.TabStop = False
        Me.CharacterEditor.Text = "Character Editor"
        '
        'Money
        '
        Me.Money.Location = New System.Drawing.Point(224, 114)
        Me.Money.Name = "Money"
        Me.Money.Size = New System.Drawing.Size(100, 20)
        Me.Money.TabIndex = 25
        '
        'MoneyLabel
        '
        Me.MoneyLabel.AutoSize = True
        Me.MoneyLabel.Location = New System.Drawing.Point(179, 114)
        Me.MoneyLabel.Name = "MoneyLabel"
        Me.MoneyLabel.Size = New System.Drawing.Size(39, 13)
        Me.MoneyLabel.TabIndex = 24
        Me.MoneyLabel.Text = "Money"
        '
        'KQLogin
        '
        Me.KQLogin.Location = New System.Drawing.Point(97, 111)
        Me.KQLogin.Name = "KQLogin"
        Me.KQLogin.Size = New System.Drawing.Size(76, 20)
        Me.KQLogin.TabIndex = 23
        '
        'Level
        '
        Me.Level.FormattingEnabled = True
        Me.Level.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150"})
        Me.Level.Location = New System.Drawing.Point(51, 21)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(100, 21)
        Me.Level.TabIndex = 3
        '
        'KQLabel
        '
        Me.KQLabel.AutoSize = True
        Me.KQLabel.Location = New System.Drawing.Point(9, 114)
        Me.KQLabel.Name = "KQLabel"
        Me.KQLabel.Size = New System.Drawing.Size(82, 13)
        Me.KQLabel.TabIndex = 22
        Me.KQLabel.Text = "KQ Login Zone:"
        '
        'AdminLevelLabel
        '
        Me.AdminLevelLabel.AutoSize = True
        Me.AdminLevelLabel.Location = New System.Drawing.Point(9, 54)
        Me.AdminLevelLabel.Name = "AdminLevelLabel"
        Me.AdminLevelLabel.Size = New System.Drawing.Size(68, 13)
        Me.AdminLevelLabel.TabIndex = 5
        Me.AdminLevelLabel.Text = "Admin Level:"
        '
        'SPR
        '
        Me.SPR.FormattingEnabled = True
        Me.SPR.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150"})
        Me.SPR.Location = New System.Drawing.Point(300, 48)
        Me.SPR.Name = "SPR"
        Me.SPR.Size = New System.Drawing.Size(55, 21)
        Me.SPR.TabIndex = 18
        '
        'AdminLevel
        '
        Me.AdminLevel.Location = New System.Drawing.Point(83, 51)
        Me.AdminLevel.Name = "AdminLevel"
        Me.AdminLevel.Size = New System.Drawing.Size(68, 20)
        Me.AdminLevel.TabIndex = 6
        '
        'SPRLabel
        '
        Me.SPRLabel.AutoSize = True
        Me.SPRLabel.Location = New System.Drawing.Point(266, 51)
        Me.SPRLabel.Name = "SPRLabel"
        Me.SPRLabel.Size = New System.Drawing.Size(32, 13)
        Me.SPRLabel.TabIndex = 17
        Me.SPRLabel.Text = "SPR:"
        '
        'LoginZoneLabel
        '
        Me.LoginZoneLabel.AutoSize = True
        Me.LoginZoneLabel.Location = New System.Drawing.Point(9, 83)
        Me.LoginZoneLabel.Name = "LoginZoneLabel"
        Me.LoginZoneLabel.Size = New System.Drawing.Size(64, 13)
        Me.LoginZoneLabel.TabIndex = 7
        Me.LoginZoneLabel.Text = "Login Zone:"
        '
        'INT
        '
        Me.INT.FormattingEnabled = True
        Me.INT.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150"})
        Me.INT.Location = New System.Drawing.Point(300, 21)
        Me.INT.Name = "INT"
        Me.INT.Size = New System.Drawing.Size(55, 21)
        Me.INT.TabIndex = 16
        '
        'LoginZone
        '
        Me.LoginZone.Location = New System.Drawing.Point(79, 80)
        Me.LoginZone.Name = "LoginZone"
        Me.LoginZone.Size = New System.Drawing.Size(72, 20)
        Me.LoginZone.TabIndex = 8
        '
        'ENDBox
        '
        Me.ENDBox.FormattingEnabled = True
        Me.ENDBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150"})
        Me.ENDBox.Location = New System.Drawing.Point(205, 79)
        Me.ENDBox.Name = "ENDBox"
        Me.ENDBox.Size = New System.Drawing.Size(55, 21)
        Me.ENDBox.TabIndex = 15
        '
        'STRLabel
        '
        Me.STRLabel.AutoSize = True
        Me.STRLabel.Location = New System.Drawing.Point(167, 24)
        Me.STRLabel.Name = "STRLabel"
        Me.STRLabel.Size = New System.Drawing.Size(32, 13)
        Me.STRLabel.TabIndex = 9
        Me.STRLabel.Text = "STR:"
        '
        'DEX
        '
        Me.DEX.FormattingEnabled = True
        Me.DEX.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150"})
        Me.DEX.Location = New System.Drawing.Point(205, 48)
        Me.DEX.Name = "DEX"
        Me.DEX.Size = New System.Drawing.Size(55, 21)
        Me.DEX.TabIndex = 14
        '
        'DexLabel
        '
        Me.DexLabel.AutoSize = True
        Me.DexLabel.Location = New System.Drawing.Point(167, 51)
        Me.DexLabel.Name = "DexLabel"
        Me.DexLabel.Size = New System.Drawing.Size(32, 13)
        Me.DexLabel.TabIndex = 10
        Me.DexLabel.Text = "DEX:"
        '
        'STR
        '
        Me.STR.FormattingEnabled = True
        Me.STR.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150"})
        Me.STR.Location = New System.Drawing.Point(205, 21)
        Me.STR.Name = "STR"
        Me.STR.Size = New System.Drawing.Size(55, 21)
        Me.STR.TabIndex = 13
        '
        'ENDLabel
        '
        Me.ENDLabel.AutoSize = True
        Me.ENDLabel.Location = New System.Drawing.Point(167, 83)
        Me.ENDLabel.Name = "ENDLabel"
        Me.ENDLabel.Size = New System.Drawing.Size(33, 13)
        Me.ENDLabel.TabIndex = 11
        Me.ENDLabel.Text = "END:"
        '
        'INTLabel
        '
        Me.INTLabel.AutoSize = True
        Me.INTLabel.Location = New System.Drawing.Point(266, 24)
        Me.INTLabel.Name = "INTLabel"
        Me.INTLabel.Size = New System.Drawing.Size(28, 13)
        Me.INTLabel.TabIndex = 12
        Me.INTLabel.Text = "INT:"
        '
        'CharacterShape
        '
        Me.CharacterShape.Controls.Add(Me.Gender)
        Me.CharacterShape.Controls.Add(Me.GenderBox)
        Me.CharacterShape.Controls.Add(Me.KlasseLabel)
        Me.CharacterShape.Controls.Add(Me.Klasse)
        Me.CharacterShape.Location = New System.Drawing.Point(6, 134)
        Me.CharacterShape.Name = "CharacterShape"
        Me.CharacterShape.Size = New System.Drawing.Size(357, 162)
        Me.CharacterShape.TabIndex = 21
        Me.CharacterShape.TabStop = False
        Me.CharacterShape.Text = "Character Shape"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Location = New System.Drawing.Point(185, 26)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(45, 13)
        Me.Gender.TabIndex = 22
        Me.Gender.Text = "Gender:"
        '
        'GenderBox
        '
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderBox.Location = New System.Drawing.Point(230, 23)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(121, 21)
        Me.GenderBox.TabIndex = 22
        '
        'KlasseLabel
        '
        Me.KlasseLabel.AutoSize = True
        Me.KlasseLabel.Location = New System.Drawing.Point(6, 26)
        Me.KlasseLabel.Name = "KlasseLabel"
        Me.KlasseLabel.Size = New System.Drawing.Size(27, 13)
        Me.KlasseLabel.TabIndex = 20
        Me.KlasseLabel.Text = "Job:"
        '
        'Klasse
        '
        Me.Klasse.FormattingEnabled = True
        Me.Klasse.Items.AddRange(New Object() {"Fighter", "CleverFighter", "Warrior", "Gladiator", "Knight", "------", "Cleric", "HighCleric", "Paladin", "HolyKnight", "Guardian", "------", "Archer", "HawkArcher", "Scout", "SharpShooter", "Ranger", "------", "Mage", "WizMage", "Enchanter", "Warlock", "Wizard"})
        Me.Klasse.Location = New System.Drawing.Point(39, 23)
        Me.Klasse.Name = "Klasse"
        Me.Klasse.Size = New System.Drawing.Size(121, 21)
        Me.Klasse.TabIndex = 19
        '
        'RegistredAccounts
        '
        Me.RegistredAccounts.AutoSize = True
        Me.RegistredAccounts.Location = New System.Drawing.Point(197, 313)
        Me.RegistredAccounts.Name = "RegistredAccounts"
        Me.RegistredAccounts.Size = New System.Drawing.Size(39, 13)
        Me.RegistredAccounts.TabIndex = 26
        Me.RegistredAccounts.Text = "Label1"
        Me.RegistredAccounts.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 425)
        Me.Controls.Add(Me.InfoTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Xara Online - Cyrust Network [Main Form]"
        Me.Character.ResumeLayout(False)
        Me.Character.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GAMEditor.ResumeLayout(False)
        Me.GAMEditor.PerformLayout()
        Me.CharacterEditor.ResumeLayout(False)
        Me.CharacterEditor.PerformLayout()
        Me.CharacterShape.ResumeLayout(False)
        Me.CharacterShape.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Character As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents AccountID As System.Windows.Forms.TextBox
    Friend WithEvents AccountIDLabel As System.Windows.Forms.Label
    Friend WithEvents CharacterNameLabel As System.Windows.Forms.Label
    Friend WithEvents CharacterEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LevelLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Level As System.Windows.Forms.ComboBox
    Friend WithEvents CharacterNoLabel As System.Windows.Forms.Label
    Friend WithEvents AccountNoLabel As System.Windows.Forms.Label
    Friend WithEvents CharacterNo As System.Windows.Forms.TextBox
    Friend WithEvents AccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Done As System.Windows.Forms.Button
    Friend WithEvents CharacterName As System.Windows.Forms.ComboBox
    Friend WithEvents AdminLevel As System.Windows.Forms.TextBox
    Friend WithEvents AdminLevelLabel As System.Windows.Forms.Label
    Friend WithEvents LoginZone As System.Windows.Forms.TextBox
    Friend WithEvents LoginZoneLabel As System.Windows.Forms.Label
    Friend WithEvents INTLabel As System.Windows.Forms.Label
    Friend WithEvents ENDLabel As System.Windows.Forms.Label
    Friend WithEvents DexLabel As System.Windows.Forms.Label
    Friend WithEvents STRLabel As System.Windows.Forms.Label
    Friend WithEvents STR As System.Windows.Forms.ComboBox
    Friend WithEvents DEX As System.Windows.Forms.ComboBox
    Friend WithEvents ENDBox As System.Windows.Forms.ComboBox
    Friend WithEvents SPR As System.Windows.Forms.ComboBox
    Friend WithEvents SPRLabel As System.Windows.Forms.Label
    Friend WithEvents INT As System.Windows.Forms.ComboBox
    Friend WithEvents KlasseLabel As System.Windows.Forms.Label
    Friend WithEvents Klasse As System.Windows.Forms.ComboBox
    Friend WithEvents CharacterShape As System.Windows.Forms.GroupBox
    Friend WithEvents ItemCreateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gender As System.Windows.Forms.Label
    Friend WithEvents GenderBox As System.Windows.Forms.ComboBox
    Friend WithEvents KQLogin As System.Windows.Forms.TextBox
    Friend WithEvents KQLabel As System.Windows.Forms.Label
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents CharacterCreateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FriendListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AccountEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GAMEditor As System.Windows.Forms.GroupBox
    Friend WithEvents CharacterEditor As System.Windows.Forms.GroupBox
    Friend WithEvents Divorce As System.Windows.Forms.Button
    Friend WithEvents GuildLabel As System.Windows.Forms.Label
    Friend WithEvents GuildMembersLabel As System.Windows.Forms.Label
    Friend WithEvents GuildEditor As System.Windows.Forms.Button
    Friend WithEvents ShowDeleted As System.Windows.Forms.CheckBox
    Friend WithEvents ServerSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Money As System.Windows.Forms.TextBox
    Friend WithEvents MoneyLabel As System.Windows.Forms.Label
    Friend WithEvents ServerManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistredAccounts As System.Windows.Forms.Label
End Class
