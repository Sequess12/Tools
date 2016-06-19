﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Management

Public Class LoginForm
    '##### SQL Login #####
    Dim Config() As String = Split(My.Computer.FileSystem.ReadAllText("config.txt"), vbNewLine)
    Dim SQLHost As String = Config(0).Substring(Config(0).IndexOf("=") + 1)
    Dim SQLUserName As String = Config(1).Substring(Config(1).IndexOf("=") + 1)
    Dim SQLPassword As String = Config(2).Substring(Config(2).IndexOf("=") + 1)
    Private Sub InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoTextBox.TextChanged
        InfoTextBox.SelectionStart = InfoTextBox.Text.Length
        InfoTextBox.ScrollToCaret()
    End Sub
    Private Sub Login_Click(sender As System.Object, e As System.EventArgs) Handles Login.Click
        LoginID.Enabled = False
        LoginPW.Enabled = False
        Login.Enabled = False
        Dim Con As SqlConnection = New SqlConnection("Data Source=" & SQLHost & "; Initial Catalog=OperatorTool; User ID=" & SQLUserName & "; Password=" & SQLPassword & ";")
        Dim strSQL As String = "SELECT COUNT(sOperID) FROM dbo.tOperator WHERE sOperID='" & LoginID.Text & "' AND sOperPW='" & LoginPW.Text & "' AND nOperLevel = 9;"
        Dim cdo As SQLCommand = New SQLCommand(strSQL, Con)
        Con.Open()
        Dim countchar As Integer = cdo.ExecuteScalar()
        If countchar = "1" Then
            InfoTextBox.Text &= Environment.NewLine & "Welcome " & LoginID.Text
            ServerForm.Show()
            Con.Close()
            Me.Hide()
        Else
            InfoTextBox.Text &= Environment.NewLine & "Please check Username and Password! Check also your authentication Level!"
            LoginID.Enabled = True
            LoginPW.Enabled = True
            Login.Enabled = True
            LoginID.SelectionStart = 0
            LoginID.SelectionLength = Len(LoginID.Text)
            LoginID.Focus()
            Con.Close()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Get_MACAddress()
        HwidCheck()
        '########## Icon Change ##########
        Icon = MainForm.Icon
        AccountEditor.Icon = MainForm.Icon
        AccountLog.Icon = MainForm.Icon
        CSForm.Icon = MainForm.Icon
        FriendList.Icon = MainForm.Icon
        GuildEditorForm.Icon = MainForm.Icon
        ItemForm.Icon = MainForm.Icon
        '########## Main ##########
        Dim lines() As String = IO.File.ReadAllLines("config.txt")
        If Not lines(3) = "FirstStart=False" Then
            Dim Daywithout As String = DateTime.Today
            Dim Day As String = Daywithout.Replace("/", ".")
            If MessageBox.Show("Welcome User! Please look to the following Date that it Contains only ""."" !" & vbNewLine & "Date: " & Day & vbNewLine & vbNewLine & "When it´s not True then send me a PM with a screen or mail me at:" & vbNewLine & "Sparkblast@nanogames-online.com", "OPTool - Settings Configuration", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                lines(3) = "FirstStart=False"
                IO.File.WriteAllLines("config.txt", lines)
            Else
                End
            End If
        End If
    End Sub

    Public Function HwidCheck()
        Dim HardwareId As String = System.Security.Principal.WindowsIdentity.GetCurrent.User.Value
        If HardwareId = "S-1-5-21-484096053-2615069614-2159838862-500" And TextBox1.Text = "134.255.218.139" Then
            InfoTextBox.Text &= Environment.NewLine & "Verficated HWID!"

        Else
            MessageBox.Show("Don't leak my Files, b!tch.", _
        "[Cyrust Network] Not verificated", _
        MessageBoxButtons.OKCancel, _
        MessageBoxIcon.Warning, _
        MessageBoxDefaultButton.Button1, _
        MessageBoxOptions.DefaultDesktopOnly, _
        False)
            Environment.Exit(0)
        End If
    End Function
    Private Function Get_MACAddress() As String
        Dim Provider As String = "http://service.jan-welker.de/myip.ashx"
        TextBox1.Text = (New System.Net.WebClient().DownloadString(Provider))
    End Function
End Class
