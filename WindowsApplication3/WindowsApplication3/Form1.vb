Public Class Form_Utama
    Private Sub Btn_Proses_Click(sender As Object, e As EventArgs) Handles Btn_Proses.Click
        MessageBox.Show(TB_Nama.Text.ToString, "Ini Judul", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If MessageBox.Show("ini text", "", MessageBoxButtons.YesNo) = DialogResult.No Then
            MsgBox("NOOOOO")
        End If
    End Sub

    Private Sub Link_FormBaru_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_FormBaru.LinkClicked
        Form2.ShowDialog()
    End Sub
End Class
