Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = DateTime.Now
        DataGridView1.Columns.Add("qty", "Quantity")
        DataGridView1.Rows.Add("", "Nadif", "3")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(DateTimePicker1.Value.Year)
        'MsgBox(DateTimePicker1.Value.ToString("ssss dddd MMMMM yyyy"))
        MsgBox(DataGridView1.Rows(0).Cells(2).Value.ToString)
    End Sub
    Dim a As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a += 15
        Label1.Text = DateTime.Now.ToString("hh mm ss : ") & a
        If a >= 1000 Then
            a = 0
        End If
    End Sub
End Class
