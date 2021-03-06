﻿Imports System.IO
Imports System.Data.SqlClient

Public Class MainForm
    '## fix for Debug Saver.. English Time fix and more
    Dim NowWithout As String = DateTime.Now
    Dim Now As String = NowWithout.Replace(":", "-")
    Dim Daywithout As String = DateTime.Today
    Dim Day As String = Daywithout.Replace("/", ".")
    '## error Handler
    Dim ErrorHandling As Integer
    '##### SQL Login #####
    Dim Config() As String = Split(My.Computer.FileSystem.ReadAllText("config.txt"), vbNewLine)
    Dim SQLHost As String = Config(0).Substring(Config(0).IndexOf("=") + 1)
    Dim SQLUserName As String = Config(1).Substring(Config(1).IndexOf("=") + 1)
    Dim SQLPassword As String = Config(2).Substring(Config(2).IndexOf("=") + 1)
    Dim Server As String = "w00_Character"
    Private Sub AccountNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AccountNo.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = False Then e.Handled = True
    End Sub
    Private Sub CharacterNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CharacterNo.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = False Then e.Handled = True
    End Sub
    Private Sub STR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles STR.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = False Then e.Handled = True
    End Sub
    Private Sub DEX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DEX.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = False Then e.Handled = True
    End Sub
    Private Sub END_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ENDBox.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = False Then e.Handled = True
    End Sub
    Private Sub INT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles INT.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = False Then e.Handled = True
    End Sub
    Private Sub SPR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SPR.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = False Then e.Handled = True
    End Sub
    Private Sub AdminLevel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdminLevel.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) = False Then e.Handled = True
    End Sub
    Private Sub InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoTextBox.TextChanged
        InfoTextBox.SelectionStart = InfoTextBox.Text.Length
        InfoTextBox.ScrollToCaret()
    End Sub
    Private Sub ErrorCheck()
        If Val(AdminLevel.Text) < Val("101") = False Then
            InfoTextBox.Text &= Environment.NewLine & Now & " Admin Level Number is unknow and inpossible for Fiesta!!"
            ErrorHandling = 1
        ElseIf Val(STR.Text) < Val("151") = False Then
            InfoTextBox.Text &= Environment.NewLine & Now & " Stats are overpowered for Fiesta and make your Stats to zero(0)!!"
            ErrorHandling = 1
        ElseIf Val(DEX.Text) < Val("151") = False Then
            InfoTextBox.Text &= Environment.NewLine & Now & " Stats are overpowered for Fiesta and make your Stats to zero(0)!!"
            ErrorHandling = 1
        ElseIf Val(ENDBox.Text) < Val("151") = False Then
            InfoTextBox.Text &= Environment.NewLine & Now & " Stats are overpowered for Fiesta and make your Stats to zero(0)!!"
            ErrorHandling = 1
        ElseIf Val(INT.Text) < Val("151") = False Then
            InfoTextBox.Text &= Environment.NewLine & Now & " Stats are overpowered for Fiesta and make your Stats to zero(0)!!"
            ErrorHandling = 1
        ElseIf Val(SPR.Text) < Val("151") = False Then
            InfoTextBox.Text &= Environment.NewLine & Now & " Stats are overpowered for Fiesta and make your Stats to zero(0)!!"
            ErrorHandling = 1
        ElseIf CharacterName.Text = "" Or CharacterNo.Text = "" Then
            InfoTextBox.Text &= Environment.NewLine & Now & " CharacterName OR CharacterNo are empty! I can not Update anything!"
            ErrorHandling = 1
        Else
            ErrorHandling = 0
        End If
        InfoTextBox.Text &= Environment.NewLine & Now & " Perform Error Handling ! You need to click 2 (two) times ""Done"" to recheck it ! Pleas read the Info above or below!"
    End Sub
    Private Sub CharacterSearch()
        If ServerSelect.Text = "Server 01" Then
            Server = "w00_Character"
        ElseIf ServerSelect.Text = "Server 02" Then
            Server = "w01_Character"
        End If
        Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & Server & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim AccCon As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=OdinAccounts; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim strSQL As String = "SELECT COUNT(sID) FROM dbo.tCharacter WHERE sID='" & CharacterName.Text & "';"
        Dim cdo As SqlCommand = New SqlCommand(strSQL, Con)
        Dim strSQL2 As String = "SELECT sID, nLevel, nUserNo, nCharNo, sLoginZone, nAdminLevel, nStrength, nConstitute, nDexterity, nIntelligence, nMentalPower, sKQMap, nMoney FROM dbo.tCharacter WHERE sID='" & CharacterName.Text & "' OR nCharNo='" & CharacterNo.Text & "';"
        Dim catCMD As SqlCommand = New SqlCommand(strSQL2, Con)
        Dim strSQL3 As String = "SELECT COUNT(nCharNo) FROM dbo.tCharacter WHERE nCharNo='" & CharacterNo.Text & "';"
        Dim cdo2 As SqlCommand = New SqlCommand(strSQL3, Con)
        Con.Open()
        Dim countchar As Integer = cdo.ExecuteScalar()
        Con.Close()
        Con.Open()
        Dim countchar2 As Integer = cdo2.ExecuteScalar()
        Con.Close()
        If countchar = 1 Or countchar2 = 1 Then
            Con.Open()
            Dim myReader As SqlDataReader = catCMD.ExecuteReader()
            InfoTextBox.Text &= Environment.NewLine & Now & " Character: " & CharacterName.Text & " Found"
            While myReader.Read()
                Money.Text = myReader(12)
                KQLogin.Text = myReader(11)
                SPR.Text = myReader(10)
                INT.Text = myReader(9)
                DEX.Text = myReader(8)
                ENDBox.Text = myReader(7)
                STR.Text = myReader(6)
                AdminLevel.Text = myReader(5)
                LoginZone.Text = myReader(4)
                CharacterNo.Text = myReader(3)
                AccountNo.Text = myReader(2)
                Level.Text = myReader(1)
                CharacterName.Text = myReader(0)
            End While
            myReader.Close()
            Con.Close()
            AccCon.Open()
            Dim strAccSQL As String = "SELECT sUsername FROM dbo.tAccounts WHERE nEMID='" & AccountNo.Text & "';"
            Dim catCMDAcc As SqlCommand = New SqlCommand(strAccSQL, AccCon)
            Dim myAccountReader As SqlDataReader = catCMDAcc.ExecuteReader()
            While myAccountReader.Read
                AccountID.Text = myAccountReader(0)
            End While
            myAccountReader.Close()
            AccCon.Close()
            ClassSearch()
            GuildSearch()
        Else
            InfoTextBox.Text &= Environment.NewLine & Now & "User Does not Exist!"
            Con.Close()
        End If
        AccountID.BackColor = Color.Empty
        Level.BackColor = Color.Empty
        CharacterName.BackColor = Color.Empty
    End Sub
    Private Sub ClassSearch()
        Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & Server & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim strSQL As String = "SELECT * FROM tCharacterShape WHERE nCharNo = '" & CharacterNo.Text & "'"
        Dim CatCMD As SqlCommand = New SqlCommand(strSQL, Con)
        Con.Open()
        Dim myReader As SqlDataReader = CatCMD.ExecuteReader()
        InfoTextBox.Text &= Environment.NewLine & Now & " Class Group in working!"
        While myReader.Read()
            Klasse.Text = myReader(1)
            GenderBox.Text = myReader(3)
        End While
        Con.Close()
        myReader.Close()
        If Klasse.Text = "1" Then
            Klasse.Text = "Fighter"
        ElseIf Klasse.Text = "2" Then
            Klasse.Text = "CleverFighter"
        ElseIf Klasse.Text = "3" Then
            Klasse.Text = "Warrior"
        ElseIf Klasse.Text = "4" Then
            Klasse.Text = "Gladiator"
        ElseIf Klasse.Text = "5" Then
            Klasse.Text = "Knight"
        ElseIf Klasse.Text = "8" Then
            Klasse.Text = "Cleric"
        ElseIf Klasse.Text = "9" Then
            Klasse.Text = "HighCleric"
        ElseIf Klasse.Text = "10" Then
            Klasse.Text = "Paladin"
        ElseIf Klasse.Text = "11" Then
            Klasse.Text = "HolyKnight"
        ElseIf Klasse.Text = "12" Then
            Klasse.Text = "Guardian"
        ElseIf Klasse.Text = "15" Then
            Klasse.Text = "Archer"
        ElseIf Klasse.Text = "16" Then
            Klasse.Text = "HawkArcher"
        ElseIf Klasse.Text = "17" Then
            Klasse.Text = "Scout"
        ElseIf Klasse.Text = "18" Then
            Klasse.Text = "SharpShooter"
        ElseIf Klasse.Text = "19" Then
            Klasse.Text = "Ranger"
        ElseIf Klasse.Text = "22" Then
            Klasse.Text = "Mage"
        ElseIf Klasse.Text = "23" Then
            Klasse.Text = "WizMage"
        ElseIf Klasse.Text = "24" Then
            Klasse.Text = "Enchanter"
        ElseIf Klasse.Text = "25" Then
            Klasse.Text = "Warlock"
        ElseIf Klasse.Text = "26" Then
            Klasse.Text = "Wizard"
        Else
            Klasse.Text = "unknow "
        End If
        If GenderBox.Text = "1" Then
            GenderBox.Text = "Male"
        ElseIf GenderBox.Text = "0" Then
            GenderBox.Text = "Female"
        Else
            GenderBox.Text = "unknow"
        End If
    End Sub
    Public Sub ClassUpdate()
        Dim Klassneu As Integer = 1
        Dim Genderneu As Integer = 0
        If Klasse.Text = "Fighter" Then
            Klassneu = "1"
            ErrorHandling = 0
        ElseIf Klasse.Text = "CleverFighter" Then
            Klassneu = "2"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Warrior" Then
            Klassneu = "3"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Gladiator" Then
            Klassneu = "4"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Knight" Then
            Klassneu = "5"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Cleric" Then
            Klassneu = "8"
            ErrorHandling = 0
        ElseIf Klasse.Text = "HighCleric" Then
            Klassneu = "9"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Paladin" Then
            Klassneu = "10"
            ErrorHandling = 0
        ElseIf Klasse.Text = "HolyKnight" Then
            Klassneu = "11"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Guardian" Then
            Klassneu = "12"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Archer" Then
            Klassneu = "15"
            ErrorHandling = 0
        ElseIf Klasse.Text = "HawkArcher" Then
            Klassneu = "16"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Scout" Then
            Klassneu = "17"
            ErrorHandling = 0
        ElseIf Klasse.Text = "SharpShooter" Then
            Klassneu = "18"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Ranger" Then
            Klassneu = "19"
            ErrorHandling = 0
        ElseIf Klasse.Text = "22" Then
            Klassneu = "Mage"
            ErrorHandling = 0
        ElseIf Klasse.Text = "WizMage" Then
            Klassneu = "23"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Enchanter" Then
            Klassneu = "24"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Warlock" Then
            Klassneu = "25"
            ErrorHandling = 0
        ElseIf Klasse.Text = "Wizard" Then
            Klassneu = "26"
            ErrorHandling = 0
        Else
            ErrorHandling = 1
        End If
        If GenderBox.Text = "Male" Then
            Genderneu = "1"
            ErrorHandling = 0
        ElseIf GenderBox.Text = "Female" Then
            Genderneu = "0"
            ErrorHandling = 0
        Else
            ErrorHandling = 1
        End If
        If ErrorHandling = 0 Then
            If ServerSelect.Text = "Server 01" Then
                Server = "w00_Character"
            ElseIf ServerSelect.Text = "Server 02" Then
                Server = "w01_Character"
            End If
            Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & Server & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
            Dim strSQL As String = "UPDATE tCharacterShape SET nClass = '" & Klassneu & "', nGender = '" & Genderneu & "' WHERE nCharNo = '" & CharacterNo.Text & "'"
            Dim CatCMD As SqlCommand = New SqlCommand(strSQL, Con)
            Con.Open()
            CatCMD.ExecuteNonQuery()
            InfoTextBox.Text &= Environment.NewLine & Now & " Class Group in work!"
            Con.Close()
        End If
    End Sub
    Private Sub CharacterName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CharacterName.SelectedIndexChanged
        CharacterNo.Text = ""
        CharacterSearch()
    End Sub
    Private Sub AccountSearch()
        If ServerSelect.Text = "Server 01" Then
            Server = "w00_Character"
        ElseIf ServerSelect.Text = "Server 02" Then
            Server = "w01_Character"
        End If
        Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & Server & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim AccCon As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=OdinAccounts; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim strSQL As String = "SELECT COUNT(sUsername) FROM dbo.tAccounts WHERE sUsername='" & AccountID.Text & "';"
        Dim cdo As SqlCommand = New SqlCommand(strSQL, AccCon)
        Con.Open()
        AccCon.Open()
        Dim countchar As Integer = cdo.ExecuteScalar()
        If countchar = "1" Then
            Dim strAccSQL As String = "SELECT nEMID FROM dbo.tAccounts WHERE sUsername='" & AccountID.Text & "';"
            Dim catCMDAcc As SqlCommand = New SqlCommand(strAccSQL, AccCon)
            Dim myAccountReader As SqlDataReader = catCMDAcc.ExecuteReader()
            While myAccountReader.Read
                AccountNo.Text = myAccountReader(0)
            End While
            myAccountReader.Close()
            Con.Close()
            Con.Open()
            Dim strSQL2 As String
            If ShowDeleted.Checked = True Then
                strSQL2 = "SELECT sID FROM dbo.tCharacter WHERE nUserNo='" & AccountNo.Text & "';"
            Else
                strSQL2 = "SELECT sID FROM dbo.tCharacter WHERE nUserNo='" & AccountNo.Text & "' AND bDeleted = 0;"
            End If
            Dim catCMD As SqlCommand = New SqlCommand(strSQL2, Con)
            Dim myReader As SqlDataReader = catCMD.ExecuteReader()
            InfoTextBox.Text &= Environment.NewLine & Now & " Account: " & AccountID.Text & " Found"
            CharacterName.Items.Clear()
            While myReader.Read()
                CharacterName.Items.Add(myReader(0))
            End While
            myReader.Close()
            AccCon.Close()
            Con.Close()
        Else
            InfoTextBox.Text &= Environment.NewLine & Now & " User Does not Exist!"
            AccCon.Close()
            Con.Close()
        End If
        AccountID.BackColor = Color.Empty
        Level.BackColor = Color.Empty
        CharacterName.BackColor = Color.Empty
    End Sub
    Private Sub AcocuntNoSearch()
        If ServerSelect.Text = "Server 01" Then
            Server = "w00_Character"
        ElseIf ServerSelect.Text = "Server 02" Then
            Server = "w01_Character"
        End If
        Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & Server & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim AccCon As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=OdinAccounts; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim strSQL As String = "SELECT COUNT(nEMID) FROM dbo.tAccounts WHERE nEMID='" & AccountNo.Text & "';"
        Dim cdo As SqlCommand = New SqlCommand(strSQL, AccCon)
        Con.Open()
        AccCon.Open()
        Dim countchar As Integer = cdo.ExecuteScalar()
        If countchar = "1" Then
            Dim strAccSQL As String = "SELECT sUsername FROM dbo.tAccounts WHERE nEMID='" & AccountNo.Text & "';"
            Dim catCMDAcc As SqlCommand = New SqlCommand(strAccSQL, AccCon)
            Dim myAccountReader As SqlDataReader = catCMDAcc.ExecuteReader()
            While myAccountReader.Read
                AccountID.Text = myAccountReader(0)
            End While
            myAccountReader.Close()
            Con.Close()
            Con.Open()
            Dim strSQL2 As String = "SELECT sID FROM dbo.tCharacter WHERE nEMID='" & AccountNo.Text & "';"
            Dim catCMD As SqlCommand = New SqlCommand(strSQL2, Con)
            Dim myReader As SqlDataReader = catCMD.ExecuteReader()
            InfoTextBox.Text &= Environment.NewLine & Now & " Account: " & AccountNo.Text & " Found"
            CharacterName.Items.Clear()
            While myReader.Read()
                CharacterName.Items.Add(myReader(0))
            End While
            myReader.Close()
            AccCon.Close()
            Con.Close()
        Else
            InfoTextBox.Text &= Environment.NewLine & Now & " User Does not Exist!"
            AccCon.Close()
            Con.Close()
        End If
        AccountID.BackColor = Color.Empty
        Level.BackColor = Color.Empty
        CharacterName.BackColor = Color.Empty
    End Sub
    Private Sub GuildSearch()
        If ServerSelect.Text = "Server 01" Then
            Server = "w00_Character"
        ElseIf ServerSelect.Text = "Server 02" Then
            Server = "w01_Character"
        End If
        Dim GuildNo As Integer
        Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & Server & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim strSQL As String = "SELECT nNo FROM dbo.tGuildMember WHERE nCharNo='" & CharacterNo.Text & "';"
        Dim catCMD As SqlCommand = New SqlCommand(strSQL, Con)
        Dim strSQL1 As String = "SELECT COUNT(nCharNo) FROM dbo.tGuildMember WHERE nCharNo='" & CharacterNo.Text & "';"
        Dim catCMD1 As SqlCommand = New SqlCommand(strSQL1, Con)
        Con.Open()
        Dim countchar As Integer = catCMD1.ExecuteScalar()
        Con.Close()
        If countchar = 1 Then
            Con.Open()
            Dim Reader As SqlDataReader = catCMD.ExecuteReader()
            While Reader.Read
                GuildNo = Reader(0)
            End While
            Reader.Close()
            Con.Close()
            Dim strSQL2 As String = "SELECT sName FROM dbo.tGuild WHERE nNo ='" & GuildNo & "';"
            Dim catCMD2 As SqlCommand = New SqlCommand(strSQL2, Con)
            Con.Open()
            Dim Reader2 As SqlDataReader = catCMD2.ExecuteReader()
            While Reader2.Read
                GuildLabel.Text = "User is in Guild: " & Reader2(0)
            End While
            Reader2.Close()
            Con.Close()
            Dim strSQL3 As String = "SELECT COUNT(nNo) FROM dbo.tGuildMember WHERE nNo ='" & GuildNo & "';"
            Dim catCMD3 As SqlCommand = New SqlCommand(strSQL3, Con)
            Con.Open()
            GuildMembersLabel.Visible = True
            Dim Reader3 As SqlDataReader = catCMD3.ExecuteReader()
            While Reader3.Read
                GuildMembersLabel.Text = Reader3(0) & " User(s) in the Guild"
            End While
            Reader3.Close()
            Con.Close()
        Else
            GuildLabel.Text = "No Guild Found"
        End If
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub Search_Click(sender As System.Object, e As System.EventArgs) Handles Search.Click
        GuildMembersLabel.Visible = False
        If AccountID.Text.Length > 0 Then
            AccountSearch()
        ElseIf CharacterName.Text.Length > 0 Then
            CharacterSearch()
        ElseIf CharacterNo.Text.Length > 0 Then
            CharacterSearch()
        ElseIf AccountNo.Text.Length > 0 Then
            AcocuntNoSearch()
        Else
            InfoTextBox.Text &= Environment.NewLine & Now & " Oops anything going wrong with me :S Try again!"
        End If
    End Sub

    Private Sub Done_Click(sender As System.Object, e As System.EventArgs) Handles Done.Click
        If ErrorHandling = 0 Then
            If ServerSelect.Text = "Server 01" Then
                Server = "w00_Character"
            ElseIf ServerSelect.Text = "Server 02" Then
                Server = "w01_Character"
            End If
            ErrorCheck()
            Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & Server & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
            Dim strSQL2 As String = "UPDATE dbo.tCharacter SET nLevel='" & Level.Text & "', sID='" & CharacterName.Text & "', nAdminLevel='" & AdminLevel.Text & "', nStrength='" & STR.Text & "', nConstitute='" & ENDBox.Text & "', nDexterity='" & DEX.Text & "', nIntelligence='" & INT.Text & "', nMentalPower='" & ENDBox.Text & "', sLoginZone='" & LoginZone.Text & "', sKQMap='" & KQLogin.Text & "' WHERE nCharNo='" & CharacterNo.Text & "';"
            Dim catCMD As SqlCommand = New SqlCommand(strSQL2, Con)
            Con.Open()
            catCMD.ExecuteNonQuery()
            Con.Close()
            ClassUpdate()
            InfoTextBox.Text &= Environment.NewLine & Now & " Character: " & CharacterName.Text & " have been successfully edited!"
            ErrorHandling = 1
            CharacterName.Items.Clear()
            AccountSearch()
        Else
            ErrorCheck()
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountID.TextChanged
        AccountID.BackColor = Color.Yellow
    End Sub
    Private Sub Level_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level.TextChanged
        Level.BackColor = Color.Red
    End Sub
    Private Sub CharacterName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CharacterName.BackColor = Color.Red
    End Sub
    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Directory.Exists("Debug") Then
            Directory.CreateDirectory("Debug")
        End If
        My.Computer.FileSystem.WriteAllText("Debug/" + Day + ".txt", InfoTextBox.Text, True)
        Environment.Exit(0)
    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Zählen()
        InfoTextBox.Text &= Now & " Welcome " & LoginForm.LoginID.Text
        ErrorHandling = 1
    End Sub

    Private Sub Clear_Click(sender As System.Object, e As System.EventArgs) Handles Clear.Click
        InfoTextBox.Text &= Environment.NewLine & Now & " Search Cleared"
        AccountNo.Text = ""
        AccountID.Text = ""
        CharacterName.Items.Clear()
        CharacterName.Text = ""
        CharacterNo.Text = ""
    End Sub

    Private Sub CharacterCreateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CharacterCreateToolStripMenuItem.Click
        InfoTextBox.Text &= Environment.NewLine & Now & " Character Search Open"
        CSForm.Show()
        Me.Hide()
    End Sub

    Private Sub FriendListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FriendListToolStripMenuItem.Click
        InfoTextBox.Text &= Environment.NewLine & Now & " Friend List Open"
        FriendList.Show()
        Me.Hide()
    End Sub

    Private Sub Zählen()
        Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & "OdinAccounts" & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim strSQL2 As String = "SELECT COUNT(nEMID) FROM dbo.tAccounts"
        Dim catCMD As SqlCommand = New SqlCommand(strSQL2, Con)
        Con.Open()
        Dim Reader As SqlDataReader = catCMD.ExecuteReader()
        While Reader.Read
            RegistredAccounts.Text = Reader(0)
        End While
        Reader.Close()
        Con.Close()
    End Sub

    Private Sub AccountEditorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccountEditorToolStripMenuItem.Click
        InfoTextBox.Text &= Environment.NewLine & Now & " Account Editor Open"
        AccountEditor.Show()
        Me.Hide()
    End Sub

    Private Sub Divorce_Click(sender As System.Object, e As System.EventArgs) Handles Divorce.Click
        If ErrorHandling = 0 Then
            If ServerSelect.Text = "Server 01" Then
                Server = "w00_Character"
            ElseIf ServerSelect.Text = "Server 02" Then
                Server = "w01_Character"
            End If
            ErrorCheck()
            Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=" & Server & "; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
            Dim strSQL2 As String = "DELETE FROM dbo.tMarriage WHERE nCharNo='" & CharacterNo.Text & "' OR nPartnerCharNo = '" & CharacterNo.Text & "';"
            Dim catCMD As SqlCommand = New SqlCommand(strSQL2, Con)
            Con.Open()
            catCMD.ExecuteNonQuery()
            Con.Close()
            InfoTextBox.Text &= Environment.NewLine & Now & " Character: " & CharacterName.Text & " have been successfully Divorced!"
            ErrorHandling = 1
            CharacterName.Items.Clear()
            AccountSearch()
        Else
            ErrorCheck()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles GuildEditor.Click
        GuildEditorForm.Show()
        Me.Hide()
    End Sub

    Private Sub ServerManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerManagerToolStripMenuItem.Click
        InfoTextBox.Text &= Environment.NewLine & Now & " Server Manager Open"
        ServerForm.Show()
        Me.Hide()
    End Sub
End Class