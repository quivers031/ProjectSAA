<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TB_Nama = New System.Windows.Forms.TextBox()
        Me.Btn_Proses = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Link_FormBaru = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'TB_Nama
        '
        Me.TB_Nama.Location = New System.Drawing.Point(70, 12)
        Me.TB_Nama.Name = "TB_Nama"
        Me.TB_Nama.Size = New System.Drawing.Size(100, 20)
        Me.TB_Nama.TabIndex = 0
        '
        'Btn_Proses
        '
        Me.Btn_Proses.Location = New System.Drawing.Point(86, 43)
        Me.Btn_Proses.Name = "Btn_Proses"
        Me.Btn_Proses.Size = New System.Drawing.Size(137, 93)
        Me.Btn_Proses.TabIndex = 1
        Me.Btn_Proses.Text = "Proses"
        Me.Btn_Proses.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama :"
        '
        'Link_FormBaru
        '
        Me.Link_FormBaru.AutoSize = True
        Me.Link_FormBaru.Location = New System.Drawing.Point(83, 172)
        Me.Link_FormBaru.Name = "Link_FormBaru"
        Me.Link_FormBaru.Size = New System.Drawing.Size(52, 13)
        Me.Link_FormBaru.TabIndex = 3
        Me.Link_FormBaru.TabStop = True
        Me.Link_FormBaru.Text = "FormBaru"
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Link_FormBaru)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Proses)
        Me.Controls.Add(Me.TB_Nama)
        Me.Name = "Form_Utama"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Nama As TextBox
    Friend WithEvents Btn_Proses As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Link_FormBaru As LinkLabel
End Class
