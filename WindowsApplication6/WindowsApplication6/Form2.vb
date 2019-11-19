Public Class Form2
    Dim n = CInt(Form1.JumKotak.Text)
    Dim arr(n, n) As Button
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        For i = 0 To n - 1
            For j = 0 To n - 1
                arr(i, j) = New Button
                arr(i, j).Width = 50
                arr(i, j).Height = 50
                arr(i, j).Top = 12 + i * 60
                arr(i, j).Left = 12 + j * 60
                arr(i, j).Parent = Me
                arr(i, j).Tag = Math.Round(Rnd() * 1 + 1)
                arr(i, j).Name = i & j
                If arr(i, j).Tag = 1 Then
                    arr(i, j).BackColor = Color.Red
                ElseIf arr(i, j).Tag = 2 Then
                    arr(i, j).BackColor = Color.Blue
                End If

                AddHandler arr(i, j).Click, AddressOf Button_Click
            Next
        Next

    End Sub
    Dim menang As Integer = 0
    Dim simpan(1) As String
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If CType(sender, Button).Tag = 2 Then
            'CType(sender, Button).Tag = 1
            simpan(0) = CType(sender, Button).Name.Substring(0, 1)
            simpan(1) = CType(sender, Button).Name.Substring(1, 1)
            For i = -1 To 1
                For j = -1 To 1

                    If simpan(0) + i >= 0 And simpan(1) + j >= 0 And simpan(0) + i <= n - 1 And simpan(1) + j <= n - 1 Then
                        arr(CInt(simpan(0) + i), CInt(simpan(1) + j)).Tag = arr(CInt(simpan(0) + i), CInt(simpan(1) + j)).Tag Mod 2 + 1
                    End If


                Next
            Next


            'arr(CInt(simpan(0) - 1), CInt(simpan(1))).Tag = arr(CInt(simpan(0) - 1), CInt(simpan(1))).Tag Mod 2 + 1
            'arr(CInt(simpan(0) - 1), CInt(simpan(1) + 1)).Tag = arr(CInt(simpan(0) - 1), CInt(simpan(1) + 1)).Tag Mod 2 + 1
            'arr(CInt(simpan(0)), CInt(simpan(1) - 1)).Tag = arr(CInt(simpan(0)), CInt(simpan(1) - 1)).Tag Mod 2 + 1
            'arr(CInt(simpan(0)), CInt(simpan(1) + 1)).Tag = arr(CInt(simpan(0)), CInt(simpan(1) + 1)).Tag Mod 2 + 1
            'arr(CInt(simpan(0) + 1), CInt(simpan(1) - 1)).Tag = arr(CInt(simpan(0) + 1), CInt(simpan(1) - 1)).Tag Mod 2 + 1
            'arr(CInt(simpan(0) + 1), CInt(simpan(1))).Tag = arr(CInt(simpan(0) + 1), CInt(simpan(1))).Tag Mod 2 + 1
            'arr(CInt(simpan(0) + 1), CInt(simpan(1) + 1)).Tag = arr(CInt(simpan(0) + 1), CInt(simpan(1) + 1)).Tag Mod 2 + 1

        End If


        For i = 0 To n - 1
            For j = 0 To n - 1
                If arr(i, j).Tag = 1 Then
                    arr(i, j).BackColor = Color.Red
                ElseIf arr(i, j).Tag = 2 Then
                    arr(i, j).BackColor = Color.Blue
                End If
            Next
        Next



        'If CType(sender, Button).Text = "" Then
        '    CType(sender, Button).Text = CType(sender, Button).Name
        'Else
        '    CType(sender, Button).Text = ""
        'End If


        For i = 0 To n - 1
            For j = 0 To n - 1
                If arr(i, j).Tag = 1 Then
                    menang = menang + 1
                End If
            Next
        Next

        If menang = (n * n) Then
            MessageBox.Show("YOU WIN", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            menang = 0

        End If






    End Sub
End Class