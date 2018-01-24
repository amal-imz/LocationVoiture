Public Class splash

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = Timer1.Interval + 100
        If Timer1.Interval >= 1100 Then
            Timer1.Enabled = False
            Me.Hide()
            Form1.Show()
            Form1.BT_Acc.Enabled = False
            Form1.BT_Voi.Enabled = False
            Form1.BT_Cli.Enabled = False
            Form1.BT_Emp.Enabled = False
            Form1.BT_Empr.Enabled = False
            Form1.BT_About.Enabled = False
            Form1.BT_Exit.Enabled = True
        End If
    End Sub
End Class