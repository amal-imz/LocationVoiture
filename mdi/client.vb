Imports System.Drawing.Image
Imports System.IO
Imports System.Data.OleDb
Imports System.Net.Mail
Public Class client

    Private con As New OleDbConnection
    Private dtadapter As New OleDbDataAdapter("select *from client", con)
    Private dtset As New DataSet
    Dim pos As Integer = 0
    Dim openDlg As OpenFileDialog = New OpenFileDialog
    Dim filename As String
    Dim imageCollection As New SortedList
    Dim x As DialogResult

    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.Ace.oledb.12.0;data source= location.accdb"
        con.Open()
        dtadapter.Fill(dtset, "client")
        'Remplissage GridView par le Contenu de la table T1 (Nomée Grid)       
        Grid1.DataSource = dtset.Tables("client")

        'For s = 0 To Me.Grid1.RowCount - 2
        '    ComboBox1.Items.Add(Me.Grid1.Item(2, s).Value)
        'Next
        'con.Close()

        Panel1.Width = 62
        pic_client.Image = pic_client.BackgroundImage
        pic_client.BackgroundImageLayout = ImageLayout.Stretch
        Grid1.Visible = False
        CB1_cli.Items.Add("Agadir")
        CB1_cli.Items.Add("Beni Mellal")
        CB1_cli.Items.Add("Berkane")
        CB1_cli.Items.Add("Casablanca")
        CB1_cli.Items.Add("El Jadida")
        CB1_cli.Items.Add("Fès")
        CB1_cli.Items.Add("Kénitra")
        CB1_cli.Items.Add("Khémisset")
        CB1_cli.Items.Add("Khouribga")
        CB1_cli.Items.Add("Laâyoune")
        CB1_cli.Items.Add("Marrakech")
        CB1_cli.Items.Add("Meknes")
        CB1_cli.Items.Add("Mohammédia")
        CB1_cli.Items.Add("Nador")
        CB1_cli.Items.Add("Oujda")
        CB1_cli.Items.Add("Rabat")
        CB1_cli.Items.Add("Safi")
        CB1_cli.Items.Add("Salé")
        CB1_cli.Items.Add("Tanger")
        CB1_cli.Items.Add("Taourirt")
        CB1_cli.Items.Add("Taza")
        CB1_cli.Items.Add("Témara")
        CB1_cli.Items.Add("Tétouan")

        If Me.Grid1.RowCount - 1 = 0 Then
            TB1_cli.Text = 1
        Else
            TB1_cli.Text = Me.Grid1.Item(0, Me.Grid1.RowCount - 2).Value + 1
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


    Private Sub BT_Ajo_Click(sender As Object, e As EventArgs) Handles BT_Ajo.Click
        Dim sw As Integer
        If TB1_cli.Text <> "" Then
            sw = 0
            For s = 0 To Me.Grid1.RowCount - 2
                If TB1_cli.Text = Me.Grid1.Item(0, s).Value Then
                    sw = 1
                End If
            Next
            If TB1_cli.Text <> "" And TB2_cli.Text <> "" And TB3_cli.Text <> "" And TB4_cli.Text <> "" And TB5_cli.Text <> "" And TB6_cli.Text <> "" And TB7_cli.Text <> "" And TB8_cli.Text <> "" And CB1_cli.Text <> "" And TB9_cli.Text <> "" Then
                If Me.pic_client.ImageLocation <> "" Then
                    'If TB1_cli.Text <> "" And TB2_cli.Text <> "" And TB3_cli.Text <> "" And TB4_cli.Text <> "" And TB5_cli.Text <> "" And TB6_cli.Text <> "" And TB7_cli.Text <> "" And TB8_cli.Text <> "" And CB1_cli.Text <> "" And TB9_cli.Text <> "" And TB10_cli.Text <> "" Then
                    If sw = 0 Then
                        Dim NewLigne As DataRow
                        ' Création de la nouvelle ligne 
                        NewLigne = dtset.Tables("client").NewRow
                        'affectation des valeurs
                        NewLigne(0) = TB1_cli.Text
                        NewLigne(1) = UCase(TB2_cli.Text)
                        NewLigne(2) = UCase(TB3_cli.Text)
                        NewLigne(3) = TB4_cli.Text
                        NewLigne(4) = TB5_cli.Text
                        NewLigne(5) = CB1_cli.Text
                        NewLigne(6) = TB6_cli.Text
                        NewLigne(7) = TB7_cli.Text
                        NewLigne(8) = TB8_cli.Text
                        NewLigne(9) = TB9_cli.Text

                        If ca.Checked = True Then
                            NewLigne(10) = 1
                        End If
                        If cbr.Checked = True Then
                            NewLigne(10) = 2
                        End If
                        If cbd.Checked = True Then
                            NewLigne(10) = 3
                        End If


                        NewLigne(11) = ConvertToData(Me.pic_client.Image)
                        Qr1.Text = "CIN : " + TB1_cli.Text() & vbCrLf & "Nom : " + TB2_cli.Text() & vbCrLf & "Prénom : " + TB4_cli.Text() & vbCrLf & "Adresse : " + TB5_cli.Text() & vbCrLf & "Ville : " + CB1_cli.Text() & vbCrLf & "Téléphone : " + TB6_cli.Text() & vbCrLf & "E-Mail : " + TB7_cli.Text() & vbCrLf & "N° De Permis : " + TB8_cli.Text() & vbCrLf & "Date Prendre Permis : " + TB9_cli.Text()
                        NewLigne(12) = ConvertToData(Me.Qr1.Image)
                        ' Ajout de la ligne à la table
                        dtset.Tables("client").Rows.Add(NewLigne)
                        ' Création CommandBuilder 
                        '(genere automatiquement l'update entre le dataSet et la base de donnée
                        Dim CmdBuild As OleDb.OleDbCommandBuilder
                        CmdBuild = New OleDb.OleDbCommandBuilder(dtadapter)
                        dtadapter.InsertCommand = CmdBuild.GetInsertCommand
                        dtadapter.Update(dtset, "client")



                        MsgBox("Ajout Avec Succes", MsgBoxStyle.Information)
                        'Dim mail As New MailMessage()
                        'Dim smtpserver As New SmtpClient
                        ''T1.text Contient Adresse E.Mail Application / T2.Text le Mot de Passe E.Mail
                        'smtpserver.Credentials = New Net.NetworkCredential("batatkhalid@hotmail.com", "khalid0640562339&")
                        'smtpserver.Port = 587
                        ''Le Compte Gmail comme Source d’envoi
                        'smtpserver.Host = "smtp.live.com"
                        'smtpserver.EnableSsl = True
                        ''T3.text Contient Adresse E.Mail Destinataire
                        'mail.To.Add(TB7_cli.Text)
                        'mail.From = New MailAddress(TB7_cli.Text)
                        ''T4.text Contient Objet Envoi Destinataire
                        'mail.Subject = "Bienvenue Notre Chère Client"
                        ''T5.text Contient Contenu E.Mail Destinataire
                        'mail.Body = "Bienvenue Chez Auto IMEBA"
                        'smtpserver.Send(mail)
                        'MsgBox("Votre Message est Envoyé", MsgBoxStyle.Information)

                        TB1_cli.Text = Nothing
                        TB2_cli.Text = Nothing
                        TB3_cli.Text = Nothing
                        TB4_cli.Text = Nothing
                        TB5_cli.Text = Nothing
                        TB6_cli.Text = Nothing
                        TB7_cli.Text = Nothing
                        TB8_cli.Text = Nothing
                        TB9_cli.Text = Nothing
                        CB1_cli.Text = Nothing
                        pic_client.Image = pic_client.BackgroundImage
                        pic_client.BackgroundImageLayout = ImageLayout.Stretch
                        Qr1.Image = Qr1.BackgroundImage
                        Qr1.BackgroundImageLayout = ImageLayout.Stretch
                        ca.Checked = False
                        cbr.Checked = False
                        cbd.Checked = False
                        con.Close()
                    Else
                        MsgBox("Référence Existe Déjà", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Vous Devez Ajouter Un Photo de Client", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("Vous Devez Remplir Tous Les Champs SVP", MsgBoxStyle.Exclamation)
            End If

        Else
            MsgBox("Vous Devez Remplir Tous Les Champs SVP", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BT_Rech_TB_Click(sender As Object, e As EventArgs) Handles BT_Rech_TB.Click
        Dim sw As Integer = 0
        Dim ligneencours As Integer
        If TB1_cli.Text <> "" Then
            For s = 0 To Me.Grid1.RowCount - 2
                If TB1_cli.Text = Me.Grid1.Item(0, s).Value Then
                    sw = 1
                    TB2_cli.Text = Me.Grid1.Item(1, s).Value
                    TB3_cli.Text = Me.Grid1.Item(2, s).Value
                    TB4_cli.Text = Me.Grid1.Item(3, s).Value
                    TB5_cli.Text = Me.Grid1.Item(4, s).Value
                    CB1_cli.Text = Me.Grid1.Item(5, s).Value
                    TB6_cli.Text = Me.Grid1.Item(6, s).Value
                    TB7_cli.Text = Me.Grid1.Item(7, s).Value
                    TB8_cli.Text = Me.Grid1.Item(8, s).Value
                    TB9_cli.Text = Me.Grid1.Item(9, s).Value
                    If ca.Checked = True Then
                        Me.Grid1.Item(10, s).Value = 1
                    End If
                    If cbr.Checked = True Then
                        Me.Grid1.Item(10, s).Value = 2
                    End If
                    If cbd.Checked = True Then
                        Me.Grid1.Item(10, s).Value = 3
                    End If
                    pic_client.Image = ConvertToImage(Grid1.Item(11, ligneencours).Value)
                    Me.Qr1.Image = ConvertToImage(Grid1.Item(12, ligneencours).Value)

                End If

            Next

            If sw = 0 Then
                MsgBox("Référence Introuvable", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Vous Devez Remplir Le Champ "" ID """, MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BT_Rech_IB_Click(sender As Object, e As EventArgs) Handles BT_Rech_IB.Click
        TopMost = True
        Me.TopMost = False
        Dim a As Integer
        Dim ligneencours As Integer
        Dim sw As Integer = 0
        a = InputBox("Entrer la Référence Demandé", "Auto IMEBA")

        For s = 0 To Me.Grid1.RowCount - 2
            If a = Me.Grid1.Item(0, s).Value Then
                sw = 1
                TB1_cli.Text = Me.Grid1.Item(0, s).Value
                TB2_cli.Text = Me.Grid1.Item(1, s).Value
                TB3_cli.Text = Me.Grid1.Item(2, s).Value
                TB4_cli.Text = Me.Grid1.Item(3, s).Value
                TB5_cli.Text = Me.Grid1.Item(4, s).Value
                CB1_cli.Text = Me.Grid1.Item(5, s).Value
                TB6_cli.Text = Me.Grid1.Item(6, s).Value
                TB7_cli.Text = Me.Grid1.Item(7, s).Value
                TB8_cli.Text = Me.Grid1.Item(8, s).Value
                TB9_cli.Text = Me.Grid1.Item(9, s).Value
                pic_client.Image = ConvertToImage(Grid1.Item(11, ligneencours).Value)
                Qr1.Image = ConvertToImage(Grid1.Item(12, ligneencours).Value)

                If ca.Checked = True Then
                    Me.Grid1.Item(10, s).Value = 1
                End If
                If cbr.Checked = True Then
                    Me.Grid1.Item(10, s).Value = 2
                End If
                If cbd.Checked = True Then
                    Me.Grid1.Item(10, s).Value = 3
                End If
            End If
        Next
        If sw = 0 Then
            MsgBox("Référence Introuvable", MsgBoxStyle.Critical)
        End If
        Me.TopMost = True
    End Sub

    Private Sub BT_Mod_Click(sender As Object, e As EventArgs) Handles BT_Mod.Click
        If TB1_cli.Text <> "" And TB2_cli.Text <> "" And TB3_cli.Text <> "" And TB4_cli.Text <> "" And TB5_cli.Text <> "" And TB6_cli.Text <> "" And TB7_cli.Text <> "" And TB8_cli.Text <> "" And CB1_cli.Text <> "" And TB9_cli.Text <> "" And G1.Text <> "" Then
            If MsgBox("voulez vous vraiment Modifier cet enregistrement", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim sw As Integer
                sw = 0
                Dim x As Integer
                For s = 0 To Me.Grid1.RowCount - 2
                    If TB1_cli.Text = Me.Grid1.Item(0, s).Value Then
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
                    matable = dtset.Tables("client")
                    Dim laligne As DataRow()
                    laligne = matable.Select("ID_cli=" & cle)
                    laligne(0).Item(1) = TB2_cli.Text
                    laligne(0).Item(2) = TB3_cli.Text
                    laligne(0).Item(3) = TB4_cli.Text
                    laligne(0).Item(4) = TB5_cli.Text
                    laligne(0).Item(5) = CB1_cli.Text
                    laligne(0).Item(6) = TB6_cli.Text
                    laligne(0).Item(7) = TB7_cli.Text
                    laligne(0).Item(8) = TB8_cli.Text
                    laligne(0).Item(9) = TB9_cli.Text

                    If ca.Checked = True Then

                        laligne(0).Item(10) = 1
                    End If
                    If cbr.Checked = True Then
                        laligne(0).Item(10) = 2
                    End If
                    If cbd.Checked = True Then
                        laligne(0).Item(10) = 3
                    End If

                    laligne(0).Item(11) = ConvertToData(Me.pic_client.Image)
                    laligne(0).Item(12) = ConvertToData(Me.Qr1.Image)

                    base(dtadapter, "client")
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

    Private Sub BT_Sup_Click(sender As Object, e As EventArgs) Handles BT_Sup.Click
        If TB1_cli.Text <> "" Then
            x = MessageBox.Show("Voulez Vous Vraiment Supprimer Cet Enregistrement", "Auto IMEBA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = MsgBoxResult.Yes Then
                Dim x As Integer
                For s = 0 To Me.Grid1.RowCount - 2
                    If TB1_cli.Text = Me.Grid1.Item(0, s).Value Then
                        x = s
                    End If
                Next

                Dim ligneencours As Integer
                ligneencours = x
                Dim cle As String
                cle = Grid1.Item(0, ligneencours).Value
                Dim ligne As DataRow()
                ligne = dtset.Tables("client").Select("ID_cli=" & cle)
                ligne(0).Delete() 'Code uniquement pour la suppression dans la base de donnée locale
                TB1_cli.Text = Nothing
                TB2_cli.Text = Nothing
                TB3_cli.Text = Nothing
                TB4_cli.Text = Nothing
                TB5_cli.Text = Nothing
                TB6_cli.Text = Nothing
                TB7_cli.Text = Nothing
                TB8_cli.Text = Nothing
                TB9_cli.Text = Nothing
                CB1_cli.Text = Nothing
                pic_client.Image = pic_client.BackgroundImage
                pic_client.BackgroundImageLayout = ImageLayout.Stretch
                Qr1.Image = Qr1.BackgroundImage
                Qr1.BackgroundImageLayout = ImageLayout.Stretch
                ca.Checked = False
                cbr.Checked = False
                cbd.Checked = False
                MsgBox("Suppression Effectuée dans la base de données Locale", MsgBoxStyle.Information)
                'con.Open() 'ici nous allons ouvrir la connexion pour accéder et utiliser la base de données distante 
                Dim cmdbuilder As OleDbCommandBuilder
                cmdbuilder = New OleDb.OleDbCommandBuilder(dtadapter)
                dtadapter.DeleteCommand = cmdbuilder.GetDeleteCommand
                dtadapter.Update(dtset, "client")
                MsgBox("Suppression Effectuée dans la base de données Distante", MsgBoxStyle.Information)

            End If
        Else
            MsgBox("Vous Devez Remplir Le Champ "" ID """, MsgBoxStyle.Exclamation)
        End If
        con.Close()
    End Sub

    Private Sub BT_Raz_Click(sender As Object, e As EventArgs) Handles BT_Raz.Click
        TB1_cli.Text = Nothing
        TB2_cli.Text = Nothing
        TB3_cli.Text = Nothing
        TB4_cli.Text = Nothing
        TB5_cli.Text = Nothing
        TB6_cli.Text = Nothing
        TB7_cli.Text = Nothing
        TB8_cli.Text = Nothing
        TB9_cli.Text = Nothing
        CB1_cli.Text = Nothing
        pic_client.Image = pic_client.BackgroundImage
        pic_client.BackgroundImageLayout = ImageLayout.Stretch
        Qr1.Image = Qr1.BackgroundImage
        Qr1.BackgroundImageLayout = ImageLayout.Stretch
        ca.Checked = False
        cbr.Checked = False
        cbd.Checked = False
    End Sub

    Private Sub BT_Fer_Click(sender As Object, e As EventArgs) Handles BT_Fer.Click
        Me.Close()
    End Sub

    Private Sub Grid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid1.CellClick
        Dim ligneencours As Integer
        ligneencours = Grid1.CurrentRow.Index
        TB1_cli.Text = Grid1.Item(0, ligneencours).Value
        TB2_cli.Text = Grid1.Item(1, ligneencours).Value
        TB3_cli.Text = Grid1.Item(2, ligneencours).Value
        TB4_cli.Text = Grid1.Item(3, ligneencours).Value
        TB5_cli.Text = Grid1.Item(4, ligneencours).Value
        CB1_cli.Text = Grid1.Item(5, ligneencours).Value
        TB6_cli.Text = Grid1.Item(6, ligneencours).Value
        TB7_cli.Text = Grid1.Item(7, ligneencours).Value
        TB8_cli.Text = Grid1.Item(8, ligneencours).Value
        TB9_cli.Text = Grid1.Item(9, ligneencours).Value

        If Me.Grid1.Item(10, ligneencours).Value = 1 Then
            ca.Checked = True
        End If
        If Me.Grid1.Item(10, ligneencours).Value = 2 Then
            cbr.Checked = True
        End If
        If Me.Grid1.Item(10, ligneencours).Value = 3 Then
            cbd.Checked = True
        End If

        pic_client.Image = ConvertToImage(Grid1.Item(11, ligneencours).Value)
        Qr1.Image = ConvertToImage(Grid1.Item(12, ligneencours).Value)

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel1.Width = 200
        PictureBox7.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Panel1.Width = 62
        PictureBox7.Visible = True
    End Sub

    Private Sub Bt_Add_Pic_Click(sender As Object, e As EventArgs) Handles Bt_Add_Pic.Click
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.ShowDialog()
        If Not Me.OpenFileDialog1.FileName = Nothing Then
            Me.pic_client.ImageLocation = Me.OpenFileDialog1.FileName
        End If

    End Sub


    Private Sub TB6_cli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB6_cli.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB1_cli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB1_cli.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim mail As New MailMessage()
        Dim smtpserver As New SmtpClient
        'T1.text Contient Adresse E.Mail Application / T2.Text le Mot de Passe E.Mail
        smtpserver.Credentials = New Net.NetworkCredential("batatkhalid@hotmail.com", "khalid0640562339&")
        smtpserver.Port = 587
        'Le Compte Gmail comme Source d’envoi
        smtpserver.Host = "smtp.live.com"
        smtpserver.EnableSsl = True
        'T3.text Contient Adresse E.Mail Destinataire
        mail.To.Add("batatkhalid@gmail.com")
        mail.From = New MailAddress("batatkhalid@gmail.com")
        'T4.text Contient Objet Envoi Destinataire
        mail.Subject = "Bienvenue Notre Chère Client"
        'T5.text Contient Contenu E.Mail Destinataire
        mail.Body = "Bienvenue Chez Auto IMEBA"
        smtpserver.Send(mail)
        MsgBox("Votre Message est Envoyé", MsgBoxStyle.Information)
    End Sub

    Private Sub Bt_less_Click(sender As Object, e As EventArgs) Handles Bt_less.Click
        Grid1.Visible = False
        T_qr.Visible = True
        Qr1.Visible = True
        PictureBox1.Visible = True

        Bt_less.Visible = False
        Bt_plus.Visible = True
    End Sub

    Private Sub Bt_plus_Click(sender As Object, e As EventArgs) Handles Bt_plus.Click
        Grid1.Visible = True
        T_qr.Visible = False
        Qr1.Visible = False
        PictureBox1.Visible = False
        Bt_plus.Visible = False
        Bt_less.Visible = True
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Qr1.Text = "CIN : " + TB2_cli.Text() & vbCrLf & "Nom : " + TB2_cli.Text() & vbCrLf & "Prénom : " + TB4_cli.Text() & vbCrLf & "Adresse : " + TB5_cli.Text() & vbCrLf & "Ville : " + CB1_cli.Text() & vbCrLf & "Téléphone : " + TB6_cli.Text() & vbCrLf & "E-Mail : " + TB7_cli.Text() & vbCrLf & "N° De Permis : " + TB8_cli.Text() & vbCrLf & "Date Prendre Permis : " + TB9_cli.Text()

        'Affecte un Nom au Fichier QR Code Exemple T3.text = CIN
        SaveFileDialog1.FileName = TB2_cli.Text

        'Convertir Qr Code Format JPG
        Me.Qr1.Image.Save(SaveFileDialog1.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        'Enregistrer en Tant que Objet Server Local « Debug »
        SaveFileDialog1.InitialDirectory = "C:\Users\lenovo\Desktop"
        'Enregistrement du Path pour Faciliter l’envoi pièce jointe    
        T_qr.Text = "C:\Users\lenovo\Documents\Visual Studio 2013\Projects\mdi\mdi\bin\Debug\" + SaveFileDialog1.FileName + ".jpg"

    End Sub

    Private Sub TB1_cli_TextChanged(sender As Object, e As EventArgs) Handles TB1_cli.TextChanged

    End Sub
End Class