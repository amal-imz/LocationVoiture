Imports System.Data.OleDb
Public Class login
    Private con As New OleDbConnection
    Private dtadapter As New OleDbDataAdapter("select *from EMPLOYE", con)
    Private dtset As New DataSet
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.Ace.oledb.12.0;data source= MIAGE.accdb"
        con.Open()
        'Identification Table ou requête Exemple la Table T1
        dtadapter.Fill(dtset, "EMPLOYE")
        'Remplissage GridView par le Contenu de la table T1 (Nomée Grid)       
        G_EMP.DataSource = dtset.Tables("EMPLOYE")
        'Rechargement Combo : pour la Préparer à la recherche.
        For s = 0 To Me.G_EMP.RowCount - 2
            C_LOGIN.Items.Add(Me.G_EMP.Item(0, s).Value)
        Next
        BackColor = Color.Blue
        TransparencyKey = BackColor
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        BackColor = Color.Turquoise
        TransparencyKey = BackColor
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = My.Resources.login_button_3
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = My.Resources.login_button_2
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.login_button_1
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        Button1.BackgroundImage = My.Resources.login_button_2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For s = 0 To Me.G_EMP.RowCount - 2
            If C_LOGIN.Text = Me.G_EMP.Item(0, s).Value Then
                If T_CODE.Text = Me.G_EMP.Item(4, s).Value Then
                    If Me.G_EMP.Item(6, s).Value = 0 Then
                        Timer1.Enabled = True
                        If Me.G_EMP.Item(5, s).Value = 1 Then
                            Form1.BT_Acc.Enabled = True
                            Form1.BT_Voi.Enabled = True
                            Form1.BT_Cli.Enabled = True
                            Form1.BT_Emp.Enabled = True
                            Form1.BT_Empr.Enabled = True
                            Form1.BT_About.Enabled = True
                            Form1.BT_Exit.Enabled = True
                        End If
                        If Me.G_EMP.Item(5, s).Value = 2 Then
                            Form1.BT_Acc.Enabled = True
                            Form1.BT_Voi.Enabled = True
                            Form1.BT_Cli.Enabled = True
                            Form1.BT_Emp.Enabled = False
                            Form1.BT_Empr.Enabled = True
                            Form1.BT_About.Enabled = True
                            Form1.BT_Exit.Enabled = True
                        End If
                    Else
                        MsgBox("Compte Bloqué SVP Contacter L'Admin")
                    End If
                Else
                    MsgBox("Code Invalide")
                    T_CODE.Text = Nothing
                End If
            End If
        Next
        Form1.BT_Login.Visible = False
        Form1.BT_Logout.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Pic_Progress.Visible = True
        Timer1.Interval = Timer1.Interval + 100
        If Timer1.Interval >= 800 Then

            Form1.Show()
            Timer1.Enabled = False
            Pic_Progress.Visible = False
            Me.Hide()
            'Form1.MnConnecter.Enabled = False
            'Form1.MnDéconnecter.Enabled = True
        End If
    End Sub

    Private Sub T_CODE_KeyDown(sender As Object, e As KeyEventArgs) Handles T_CODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            For s = 0 To Me.G_EMP.RowCount - 2
                If C_LOGIN.Text = Me.G_EMP.Item(0, s).Value Then
                    If T_CODE.Text = Me.G_EMP.Item(4, s).Value Then
                        If Me.G_EMP.Item(6, s).Value = 0 Then
                            Timer1.Enabled = True
                            If Me.G_EMP.Item(5, s).Value = 1 Then
                                Form1.BT_Acc.Enabled = True
                                Form1.BT_Voi.Enabled = True
                                Form1.BT_Cli.Enabled = True
                                Form1.BT_Emp.Enabled = True
                                Form1.BT_Empr.Enabled = True
                                Form1.BT_About.Enabled = True
                                Form1.BT_Exit.Enabled = True
                            End If
                            If Me.G_EMP.Item(5, s).Value = 2 Then
                                Form1.BT_Acc.Enabled = True
                                Form1.BT_Voi.Enabled = True
                                Form1.BT_Cli.Enabled = True
                                Form1.BT_Emp.Enabled = False
                                Form1.BT_Empr.Enabled = True
                                Form1.BT_About.Enabled = True
                                Form1.BT_Exit.Enabled = True
                            End If
                        Else
                            MsgBox("Compte Bloqué SVP Contacter L'Admin")
                        End If
                    Else
                        MsgBox("Code Invalide")
                        T_CODE.Text = Nothing
                    End If
                End If
            Next
            Form1.BT_Login.Visible = False
            Form1.BT_Logout.Visible = True
        End If
    End Sub

    Private Sub C_LOGIN_KeyDown(sender As Object, e As KeyEventArgs) Handles C_LOGIN.KeyDown
        If e.KeyCode = Keys.Enter Then
            For s = 0 To Me.G_EMP.RowCount - 2
                If C_LOGIN.Text = Me.G_EMP.Item(0, s).Value Then
                    If T_CODE.Text = Me.G_EMP.Item(4, s).Value Then
                        If Me.G_EMP.Item(6, s).Value = 0 Then
                            Timer1.Enabled = True
                            If Me.G_EMP.Item(5, s).Value = 1 Then
                                Form1.BT_Acc.Enabled = True
                                Form1.BT_Voi.Enabled = True
                                Form1.BT_Cli.Enabled = True
                                Form1.BT_Emp.Enabled = True
                                Form1.BT_Empr.Enabled = True
                                Form1.BT_About.Enabled = True
                                Form1.BT_Exit.Enabled = True
                            End If
                            If Me.G_EMP.Item(5, s).Value = 2 Then
                                Form1.BT_Acc.Enabled = True
                                Form1.BT_Voi.Enabled = True
                                Form1.BT_Cli.Enabled = True
                                Form1.BT_Emp.Enabled = False
                                Form1.BT_Empr.Enabled = True
                                Form1.BT_About.Enabled = True
                                Form1.BT_Exit.Enabled = True
                            End If
                        Else
                            MsgBox("Compte Bloqué SVP Contacter L'Admin")
                        End If
                    Else
                        MsgBox("Code Invalide")
                        T_CODE.Text = Nothing
                    End If
                End If
            Next
            Form1.BT_Login.Visible = False
            Form1.BT_Logout.Visible = True
        End If
    End Sub

    Private Sub T_CODE_TextChanged(sender As Object, e As EventArgs) Handles T_CODE.TextChanged

    End Sub

    Private Sub C_LOGIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_LOGIN.SelectedIndexChanged

    End Sub
End Class