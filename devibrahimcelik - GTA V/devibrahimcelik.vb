Imports System.Runtime.InteropServices

Public Class devibrahimcelik

    '   Software Developer IBRAHIM CELIK
    'Github: @SoftwareDEVibrahimcelik
    'Donation: https://www.patreon.com/devibrahimcelik
    'Instagram: https://www.instagram.com/softwaredevic/p/C2pOtE4MN10/
    'YouTube: https://www.youtube.com/@devibrahimcelik
    'Github Link: https://github.com/SoftwareDEVibrahimcelik

    'Bitcoin Address: 3H2iUqWmQ2RGTYDjJwceVeEFT8XMTafjrk

    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("You can subscribe my patreon account")
        System.Diagnostics.Process.Start("https://www.patreon.com/devibrahimcelik")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("https://discord.gg/devic")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("https://github.com/SoftwareDEVibrahimcelik")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://www.youtube.com/@devibrahimcelik")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next

        Dim aprocess As Process = Process.GetProcessesByName("GTA5")(0)
        For Each amodule As System.Diagnostics.ProcessModule In aprocess.Modules
            If amodule.FileName.IndexOf("GTA5.exe") <> -1 Then
                Label7.Text = amodule.BaseAddress.ToString
            End If

        Next
    End Sub

    Private Sub devibrahimcelik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        Dim aprocess As Process = Process.GetProcessesByName("GTA5")(0)
        For Each amodule As System.Diagnostics.ProcessModule In aprocess.Modules
            If amodule.FileName.IndexOf("GTA5.exe") <> -1 Then
                Label7.Text = amodule.BaseAddress.ToString
            End If

        Next
    End Sub

    Private Sub renk_Tick(sender As Object, e As EventArgs) Handles renk.Tick
        Dim RanNum As New Random
        Label5.ForeColor = System.Drawing.Color.FromArgb(255, RanNum.Next(0, 255), RanNum.Next(0, 255), RanNum.Next(0, 255))
    End Sub

    Private Sub Switch1_CheckedChanged(sender As Object, e As EventArgs) Handles Switch1.CheckedChanged
        If Switch1.Checked = True Then
            WriteDMAInteger("GTA5.exe", Label7.Text + &H2579E68, {&H30, &H278, &H10, &H88, &H280}, 1232348144, 5)
            Timer2.Start()
        End If
        'HP
        If Switch1.Checked = False Then
            WriteDMAInteger("GTA5.exe", Label7.Text + &H2579E68, {&H30, &H278, &H10, &H88, &H280}, 1134821376, 5)
            Timer2.Stop()
        End If
    End Sub

    Private Sub Switch2_CheckedChanged(sender As Object, e As EventArgs) Handles Switch2.CheckedChanged
        WriteDMAInteger("GTA5.exe", Label7.Text + &H2579E68, {&H30, &H278, &H10, &H88, &H280}, 0, 5)


        Switch2.Checked = False

        Switch1.Checked = False
        Timer2.Stop()
    End Sub

    Private Sub Switch3_CheckedChanged(sender As Object, e As EventArgs) Handles Switch3.CheckedChanged
        If Switch3.Checked = True Then
            Timer3.Start()
        End If
        'POLIS
        If Switch3.Checked = False Then
            Timer3.Stop()
            WriteDMAInteger("GTA5.exe", Label7.Text + &H2579C68, {&H8, &H60, &H8D8}, 0, 3)
        End If
    End Sub

    Private Sub Switch4_CheckedChanged(sender As Object, e As EventArgs) Handles Switch4.CheckedChanged
        If Switch4.Checked = True Then
            anahtar.Start()
        End If

        If Switch4.Checked = False Then
            anahtar.Stop()
        End If

    End Sub

    Private Sub anahtar_Tick(sender As Object, e As EventArgs) Handles anahtar.Tick
        If GetAsyncKeyState(Keys.F3) Then
            WriteDMAInteger("GTA5.exe", Label7.Text + &H257BCE8, {&H18, &H10, &H20, &H1420, &H378, &H980}, 1000000, 6)
            WriteDMAInteger("GTA5.exe", Label7.Text + &H29BD898, {&H28, &H48, &H18, &H10, &H378, &H970}, 1000000, 6)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        WriteDMAInteger("GTA5.exe", Label7.Text + &H2579E68, {&H30, &H278, &H10, &H88, &H280}, 1232348144, 5)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Label8.Text = ReadDMAInteger("GTA5.exe", Label7.Text + &H2579C68, {&H8, &H60, &H8D8}, 3)

        If Label8.Text >= 0 Then
            WriteDMAInteger("GTA5.exe", Label7.Text + &H2579C68, {&H8, &H60, &H8D8}, 0, 3)
        End If

    End Sub

    Private Sub Switch5_CheckedChanged(sender As Object, e As EventArgs) Handles Switch5.CheckedChanged

        If Switch5.Checked = True Then
            Me.TopMost = True
        End If

        If Switch5.Checked = False Then
            Me.TopMost = False
        End If
    End Sub
End Class