Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Username, pwd As String
        Username = "test"
        pwd = "test"
        If UsernameTextBox.Text = Username Then
            If pwd = pwd Then
                MsgBox("这只是个Demo")
            Else
                MsgBox("密码错误", MsgBoxStyle.Critical, "错误")
            End If
        Else
            MsgBox("用户名密码错误", MsgBoxStyle.Critical, "错误")
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
