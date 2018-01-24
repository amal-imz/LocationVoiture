Imports System.Drawing.Image
Imports System.IO
Imports System.Data.OleDb
Imports System.Net.Mail

Public Class employe

    Private con As New OleDbConnection
    Private dtadapter As New OleDbDataAdapter("select *from employe", con)
    Private dtset As New DataSet
    Dim pos As Integer = 0
    Dim openDlg As OpenFileDialog = New OpenFileDialog
    Dim filename As String
    Dim imageCollection As New SortedList
    Dim x As DialogResult
    Private Sub employe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.Ace.oledb.12.0;data source= location.accdb"
        con.Open()
        'dtadapter.Fill(dtset, "employe")
        'Remplissage GridView par le Contenu de la table T1 (Nomée Grid)       
        Grid1.DataSource = dtset.Tables("employe")

        'For s = 0 To Me.Grid1.RowCount - 2
        '    ComboBoxEx1.Items.Add(Me.Grid1.Item(2, s).Value)
        'Next
        'con.Close()

        Panel1.Width = 62
        pic_emp.Image = pic_emp.BackgroundImage
        pic_emp.BackgroundImageLayout = ImageLayout.Stretch

        If Me.Grid1.RowCount - 1 = 0 Then
            TB1_emp.Text = 1
        Else
            TB1_emp.Text = Me.Grid1.Item(0, Me.Grid1.RowCount - 2).Value + 1
        End If


    End Sub

    Public Function ConvertToData(ByVal myImage As Image) As Byte()
        Dim ms As New MemoryStream()
        myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim myBytes(ms.Length - 1) As Byte
        ms.Position = 0
        ms.Read(myBytes, 0, ms.Length)
        Return myBytes
    End Function

    Public Function ConvertToImage(ByVal data() As Byte) As Image
        Dim stream As New MemoryStream(data)
        Return Image.FromStream(stream)
    End Function

    Private Sub TB6_emp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB5_emp.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox7_empck(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel1.Width = 200
        PictureBox7.Visible = False
    End Sub

    Private Sub PictureBox6_empck(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Panel1.Width = 62
        PictureBox7.Visible = True
    End Sub

    Private Sub BT_Ajo_empck(sender As Object, e As EventArgs) Handles BT_Ajo.Click
        Dim sw As Integer
        If TB1_emp.Text <> "" Then
            sw = 0
            For s = 0 To Me.Grid1.RowCount - 2
                If TB1_emp.Text = Me.Grid1.Item(0, s).Value Then
                    sw = 1
                End If
            Next
            If TB1_emp.Text <> "" And TB2_emp.Text <> "" And TB3_emp.Text <> "" And TB4_emp.Text <> "" And TB5_emp.Text <> "" And TB6_emp.Text <> "" And TB7_emp.Text <> "" Then
                If sw = 0 Then
                    Dim NewLigne As DataRow
                    ' Création de la nouvelle ligne 
                    NewLigne = dtset.Tables("employe").NewRow
                    'affectation des valeurs
                    NewLigne(0) = TB1_emp.Text
                    NewLigne(1) = TB2_emp.Text
                    NewLigne(2) = UCase(TB3_emp.Text)
                    NewLigne(3) = TB4_emp.Text
                    NewLigne(6) = TB5_emp.Text
                    NewLigne(7) = TB6_emp.Text
                    NewLigne(10) = TB7_emp.Text
                    NewLigne(11) = ConvertToData(Me.pic_emp.Image)
                    ' Ajout de la ligne à la table
                    dtset.Tables("employe").Rows.Add(NewLigne)
                    ' Création CommandBuilder 
                    '(genere automatiquement l'update entre le dataSet et la base de donnée
                    Dim CmdBuild As OleDb.OleDbCommandBuilder
                    CmdBuild = New OleDb.OleDbCommandBuilder(dtadapter)
                    dtadapter.InsertCommand = CmdBuild.GetInsertCommand
                    dtadapter.Update(dtset, "employe")


                    Dim mail As New MailMessage()
                    Dim smtpserver As New SmtpClient
                    'T1.text Contient Adresse E.Mail Application / T2.Text le Mot de Passe E.Mail
                    smtpserver.Credentials = New Net.NetworkCredential("batatkhalid@hotmail.com", "khalid0640562339&")
                    smtpserver.Port = 587
                    'Le Compte Gmail comme Source d’envoi
                    smtpserver.Host = "smtp.live.com"
                    smtpserver.EnableSsl = True
                    'T3.text Contient Adresse E.Mail Destinataire
                    mail.To.Add(TB6_emp.Text)
                    mail.From = New MailAddress(TB6_emp.Text)
                    'T4.text Contient Objet Envoi Destinataire
                    mail.Subject = "Bienvenue Notre Chère Client"
                    'T5.text Contient Contenu E.Mail Destinataire
                    mail.Body = "Bienvenue Chez Auto IMEBA"
                    smtpserver.Send(mail)
                    MsgBox("Votre Message est Envoyé", MsgBoxStyle.Information)


                    TB1_emp.Text = Nothing
                    TB2_emp.Text = Nothing
                    TB3_emp.Text = Nothing
                    TB4_emp.Text = Nothing
                    TB5_emp.Text = Nothing
                    TB6_emp.Text = Nothing
                    TB7_emp.Text = Nothing

                    MsgBox("Ajout Avec Succes", MsgBoxStyle.Information)
                    con.Close()
                Else
                    MsgBox("Référence Existe Déjà", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Vous Devez Remplir Tous Les Champs SVP", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Vous Devez Remplir Tous Les Champs SVP", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BT_Rech_TB_empck(sender As Object, e As EventArgs) Handles BT_Rech_TB.Click
        Dim sw As Integer = 0
        Dim ligneencours As Integer
        If TB1_emp.Text <> "" Then
            For s = 0 To Me.Grid1.RowCount - 2
                If TB1_emp.Text = Me.Grid1.Item(0, s).Value Then
                    sw = 1
                    TB2_emp.Text = Me.Grid1.Item(1, s).Value
                    TB3_emp.Text = Me.Grid1.Item(2, s).Value
                    TB4_emp.Text = Me.Grid1.Item(3, s).Value
                    TB5_emp.Text = Me.Grid1.Item(4, s).Value
                    TB6_emp.Text = Me.Grid1.Item(6, s).Value
                    TB7_emp.Text = Me.Grid1.Item(7, s).Value
                    pic_emp.Image = ConvertToImage(Grid1.Item(11, ligneencours).Value)

                End If

            Next

            If sw = 0 Then
                MsgBox("Référence Introuvable", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Vous Devez Remplir Le Champ "" ID """, MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BT_Rech_IB_empck(sender As Object, e As EventArgs) Handles BT_Rech_IB.Click
        TopMost = True
        Me.TopMost = False
        Dim a As Integer
        Dim ligneencours As Integer
        Dim sw As Integer = 0
        a = InputBox("Entrer la Référence Demandé", "Auto IMEBA")

        For s = 0 To Me.Grid1.RowCount - 2
            If a = Me.Grid1.Item(0, s).Value Then
                sw = 1
                TB1_emp.Text = Me.Grid1.Item(0, s).Value
                TB2_emp.Text = Me.Grid1.Item(1, s).Value
                TB3_emp.Text = Me.Grid1.Item(2, s).Value
                TB4_emp.Text = Me.Grid1.Item(3, s).Value
                TB5_emp.Text = Me.Grid1.Item(4, s).Value
                TB6_emp.Text = Me.Grid1.Item(6, s).Value
                TB7_emp.Text = Me.Grid1.Item(7, s).Value
                pic_emp.Image = ConvertToImage(Grid1.Item(11, ligneencours).Value)
            End If
        Next
        If sw = 0 Then
            MsgBox("Référence Introuvable", MsgBoxStyle.Critical)
        End If
        Me.TopMost = True
    End Sub

    Private Sub BT_Mod_empck(sender As Object, e As EventArgs) Handles BT_Mod.Click
        If TB1_emp.Text <> "" And TB2_emp.Text <> "" And TB3_emp.Text <> "" And TB4_emp.Text <> "" And TB5_emp.Text <> "" And TB6_emp.Text <> "" And TB7_emp.Text <> "" Then
            If MsgBox("voulez vous vraiment Modifier cet enregistrement", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim sw As Integer
                sw = 0
                Dim x As Integer
                For s = 0 To Me.Grid1.RowCount - 2
                    If TB1_emp.Text = Me.Grid1.Item(0, s).Value Then
                        sw = 1
                        x = s
                    End If
                Next
                If sw = 1 Then
                    Dim ligneencours As Integer
                    ligneencours = x
                    Dim cle As String
                    cle = Grid1.Item(0, ligneencours).Value
                    Dim matable As DataTable
                    matable = dtset.Tables("employe")
                    Dim laligne As DataRow()
                    laligne = matable.Select("ID_emp=" & cle)
                    laligne(0).Item(1) = TB2_emp.Text
                    laligne(0).Item(2) = TB3_emp.Text
                    laligne(0).Item(3) = TB4_emp.Text
                    laligne(0).Item(4) = TB5_emp.Text
                    laligne(0).Item(6) = TB6_emp.Text
                    laligne(0).Item(7) = TB7_emp.Text
                    base(dtadapter, "employe")
                    MsgBox("Modification Avec Succes", MsgBoxStyle.Information)
                Else
                    MsgBox("Référence N’Existe Pas", MsgBoxStyle.Critical)
                End If
            End If

        Else
            MsgBox("Vous Devez Remplir Tous Les Champs SVP", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub base(ByVal adapter As OleDbDataAdapter, ByVal table As String)
        ' con.Open() 
        Dim cmdbuilder As OleDbCommandBuilder
        cmdbuilder = New OleDb.OleDbCommandBuilder(adapter)
        adapter.UpdateCommand = cmdbuilder.GetUpdateCommand
        adapter.Update(dtset, table)
    End Sub

    Private Sub BT_Sup_empck(sender As Object, e As EventArgs) Handles BT_Sup.Click
        If TB1_emp.Text <> "" Then
            x = MessageBox.Show("Voulez Vous Vraiment Supprimer Cet Enregistrement", "Auto IMEBA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = MsgBoxResult.Yes Then
                Dim x As Integer
                For s = 0 To Me.Grid1.RowCount - 2
                    If TB1_emp.Text = Me.Grid1.Item(0, s).Value Then
                        x = s
                    End If
                Next

                Dim ligneencours As Integer
                ligneencours = x
                Dim cle As String
                cle = Grid1.Item(0, ligneencours).Value
                Dim ligne As DataRow()
                ligne = dtset.Tables("employe").Select("ID_emp=" & cle)
                ligne(0).Delete() 'Code uniquement pour la suppression dans la base de donnée locale
                TB1_emp.Text = Nothing
                TB2_emp.Text = Nothing
                TB3_emp.Text = Nothing
                TB4_emp.Text = Nothing
                TB5_emp.Text = Nothing
                TB6_emp.Text = Nothing
                TB7_emp.Text = Nothing
                MsgBox("Suppression Effectuée dans la base de données Locale", MsgBoxStyle.Information)
                'con.Open() 'ici nous allons ouvrir la connexion pour accéder et utiliser la base de données distante 
                Dim cmdbuilder As OleDbCommandBuilder
                cmdbuilder = New OleDb.OleDbCommandBuilder(dtadapter)
                dtadapter.DeleteCommand = cmdbuilder.GetDeleteCommand
                dtadapter.Update(dtset, "employe")
                MsgBox("Suppression Effectuée dans la base de données Distante", MsgBoxStyle.Information)

            End If
        Else
            MsgBox("Vous Devez Remplir Le Champ "" ID """, MsgBoxStyle.Exclamation)
        End If
        con.Close()
    End Sub

    Private Sub BT_Raz_empck(sender As Object, e As EventArgs) Handles BT_Raz.Click
        TB1_emp.Text = Nothing
        TB2_emp.Text = Nothing
        TB3_emp.Text = Nothing
        TB4_emp.Text = Nothing
        TB5_emp.Text = Nothing
        TB6_emp.Text = Nothing
        TB7_emp.Text = Nothing
    End Sub

    Private Sub BT_Fer_empck(sender As Object, e As EventArgs) Handles BT_Fer.Click
        Me.Close()
    End Sub

    Private Sub Grid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid1.CellClick
        Dim ligneencours As Integer
        ligneencours = Grid1.CurrentRow.Index
        TB1_emp.Text = Grid1.Item(0, ligneencours).Value
        TB2_emp.Text = Grid1.Item(1, ligneencours).Value
        TB3_emp.Text = Grid1.Item(2, ligneencours).Value
        TB4_emp.Text = Grid1.Item(3, ligneencours).Value
        TB5_emp.Text = Grid1.Item(4, ligneencours).Value
        TB6_emp.Text = Grid1.Item(6, ligneencours).Value
        TB7_emp.Text = Grid1.Item(7, ligneencours).Value
    End Sub

    Private Sub Bt_Add_Pic_Click(sender As Object, e As EventArgs) Handles Bt_Add_Pic.Click
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.ShowDialog()
        If Not Me.OpenFileDialog1.FileName = Nothing Then
            Me.pic_emp.ImageLocation = Me.OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub TB1_emp_TextChanged(sender As Object, e As EventArgs) Handles TB1_emp.TextChanged

    End Sub
End Class