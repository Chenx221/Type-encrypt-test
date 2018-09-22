Public Class Form1
    Dim minwen As String
    Dim anhao As String
    Dim miwen As String

    Dim anhao_long As Integer
    Dim mw_long As Integer
    Dim miwen_long As Integer

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        About.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        miwen = TextBox3.Text
        anhao = TextBox2.Text
        Dim ah_asc__3 As Long
        Dim pwd1 As String
        Dim wait_to_uncode As String
        Dim wait_uncode As String
        Dim uncode As String
        uncode = ""
        wait_uncode = ""
        pwd1 = ""
        For u = 1 To Len(anhao)
            ah_asc__3 = Asc(Mid(anhao, u, 1)) + 3
            pwd1 = pwd1 + Chr(ah_asc__3)
        Next

        wait_to_uncode = Replace(miwen, pwd1, "")

        For ip = 1 To Len(wait_to_uncode) Step 4
            wait_uncode = Mid(wait_to_uncode, ip, 4)
            uncode = uncode + Chr(Asc(Replace(wait_uncode, "@", "", 2, -1)) - 2)
        Next
        TextBox1.Text = uncode


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        minwen = TextBox1.Text
        anhao = TextBox2.Text
        miwen = TextBox3.Text

        mw_long = Len(minwen)
        anhao_long = Len(anhao)
        miwen_long = Len(miwen)

        Dim j As Integer
        Dim pwd As String
        Dim ah_asc_3 As Long
        pwd = ""
        For j = 1 To anhao_long
            ah_asc_3 = Asc(Mid(anhao, j, 1)) + 3
            pwd = pwd + Chr(ah_asc_3)
        Next

        '此处的pwd用来填充在原密文的首部


        Dim i As Integer
        Dim miwen_1time As String
        Dim mw(0 To i + 5) As String
        Dim b As String
        Dim c As Long
        Dim d As Long
        Dim g As String
        Dim f As String
        Dim encrypt_word As String
        miwen_1time = ""
        For i = 1 To mw_long
            b = Mid(minwen, i, 1)
            C = Asc(b)
            d = c + 2
            g = Chr(d)
            f = g

            If Len(f) = 1 Then
                f = "@@@" + f
            ElseIf Len(f) = 2 Then
                f = "@@" + f
            ElseIf Len(f) = 3 Then
                f = "@" + f
            Else
            End If

            miwen_1time = miwen_1time + f
        Next

        encrypt_word = pwd + miwen_1time
        TextBox3.Text = ""
        TextBox3.Text = encrypt_word

    End Sub
End Class
