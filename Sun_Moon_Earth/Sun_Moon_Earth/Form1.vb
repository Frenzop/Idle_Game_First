Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub chkMoon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMoon.CheckedChanged
        picSun.Hide()
        PicEarth.Hide()
        If chkEarth.CheckState = 1 Then
            PicEarth.Show()
        End If
        If chkSun.CheckState = 1 Then
            picSun.Show()
        End If
        If chkEarth.CheckState = 0 Then
            PicEarth.Hide()
        End If
        If chkSun.CheckState = 0 Then
            picSun.Hide()
        End If
        PicMoon.Show()
        If chkMoon.CheckState = 0 Then
            PicMoon.Hide()
        End If
        If chkMoon.CheckState = 0 And chkEarth.CheckState = 0 And chkSun.CheckState = 0 Then
            PicEarth.Show()
            PicMoon.Show()
            picSun.Show()
        End If
    End Sub

    Private Sub chkSun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSun.CheckedChanged
        PicMoon.Hide()
        PicEarth.Hide()
        If chkEarth.CheckState = 1 Then
            PicEarth.Show()
        End If
        If chkMoon.CheckState = 1 Then
            PicMoon.Show()
        End If
        If chkEarth.CheckState = 0 Then
            PicEarth.Hide()
        End If
        If chkMoon.CheckState = 0 Then
            PicMoon.Hide()
        End If
        picSun.Show()
        If chkSun.CheckState = 0 Then
            picSun.Hide()
        End If
        If chkMoon.CheckState = 0 And chkEarth.CheckState = 0 And chkSun.CheckState = 0 Then
            PicEarth.Show()
            PicMoon.Show()
            picSun.Show()
        End If
    End Sub

    Private Sub chkEarth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEarth.CheckedChanged
        PicMoon.Hide()
        picSun.Hide()
        If chkMoon.CheckState = 1 Then
            PicMoon.Show()
        End If
        If chkSun.CheckState = 1 Then
            picSun.Show()
        End If
        If chkMoon.CheckState = 0 Then
            PicMoon.Hide()
        End If
        If chkSun.CheckState = 0 Then
            picSun.Hide()
        End If
        PicEarth.Show()
        If chkEarth.CheckState = 0 Then
            PicEarth.Hide()
        End If
        If chkMoon.CheckState = 0 And chkEarth.CheckState = 0 And chkSun.CheckState = 0 Then
            PicEarth.Show()
            PicMoon.Show()
            picSun.Show()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
