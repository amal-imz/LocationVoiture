Public Class Form1
    Dim x As DialogResult
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Width = 62
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel1.Width = 200
        PictureBox3.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel1.Width = 62
        PictureBox3.Visible = True
    End Sub

    Private Sub ButtonX7_Click(sender As Object, e As EventArgs) Handles BT_Exit.Click
        voiture.Close()
        client.Close()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clock.Text = TimeOfDay
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = My.Resources.close3
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = My.Resources.close2
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.close1
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        Button1.BackgroundImage = My.Resources.close2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles BT_Voi.Click
        PictureBox5.Visible = False
        PictureBox4.Visible = False
        voiture.Show()
        client.Close()
        employe.Close()
        emprunt.Close()
        about.Close()
        BT_Acc.Checked = False
        BT_Voi.Checked = True
        BT_Cli.Checked = False
        BT_Empr.Checked = False
        BT_Emp.Checked = False
        BT_About.Checked = False
        BT_Exit.Checked = False
    End Sub

    Private Sub ButtonX5_Click(sender As Object, e As EventArgs) Handles BT_Acc.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        voiture.Close()
        client.Close()
        BT_Acc.Checked = True
        BT_Voi.Checked = False
        BT_Cli.Checked = False
        BT_Empr.Checked = False
        BT_Emp.Checked = False
        BT_About.Checked = False
        BT_Exit.Checked = False

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles BT_Cli.Click
        PictureBox5.Visible = False
        PictureBox4.Visible = False
        voiture.Close()
        client.Show()
        employe.Close()
        emprunt.Close()
        about.Close()
        BT_Acc.Checked = False
        BT_Voi.Checked = False
        BT_Cli.Checked = True
        BT_Empr.Checked = False
        BT_Emp.Checked = False
        BT_About.Checked = False
        BT_Exit.Checked = False
    End Sub


    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles BT_Login.Click
        login.Show()
    End Sub

    Private Sub BT_Logout_Click(sender As Object, e As EventArgs) Handles BT_Logout.Click
        x = MessageBox.Show("Voulez Vous Vraiment Decc Cet Compte", "Auto IMEBA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = MsgBoxResult.Yes Then
            BT_Logout.Visible = False
            BT_Login.Visible = True
            BT_Acc.Enabled = False
            BT_Voi.Enabled = False
            BT_Cli.Enabled = False
            BT_Emp.Enabled = False
            BT_Empr.Enabled = False
            BT_About.Enabled = False
            BT_Exit.Enabled = True
            login.Close()
        End If
    End Sub

    Private Sub BT_Emp_Click(sender As Object, e As EventArgs) Handles BT_Emp.Click
        PictureBox5.Visible = False
        PictureBox4.Visible = False
        voiture.Close()
        client.Close()
        employe.Show()
        emprunt.Close()
        about.Close()
    End Sub

    Private Sub BT_Empr_Click(sender As Object, e As EventArgs) Handles BT_Empr.Click
        PictureBox5.Visible = False
        PictureBox4.Visible = False
        voiture.Close()
        client.Close()
        employe.Close()
        emprunt.Show()
        about.Close()
    End Sub

    Private Sub BT_About_Click(sender As Object, e As EventArgs) Handles BT_About.Click
        PictureBox5.Visible = False
        PictureBox4.Visible = False
        voiture.Close()
        client.Close()
        employe.Close()
        emprunt.Close()
        about.Show()
    End Sub
End Class
