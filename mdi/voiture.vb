Imports System.Drawing.Image
Imports System.IO
Imports System.Data.OleDb
Public Class voiture

    Private con As New OleDbConnection
    Private dtadapter As New OleDbDataAdapter("select *from voiture", con)
    Private dtset As New DataSet
    Dim x As DialogResult


    Private Sub voiture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.Ace.oledb.12.0;data source= location_voiture1.accdb"
        con.Open()
        dtadapter.Fill(dtset, "voiture")
        'Remplissage GridView par le Contenu de la table T1 (Nomée Grid)       
        Grid1.DataSource = dtset.Tables("voiture")

        'For s = 0 To Me.Grid1.RowCount - 2
        '    ComboBoxEx1.Items.Add(Me.Grid1.Item(2, s).Value)
        'Next
        'con.Close()

        If Me.Grid1.RowCount - 1 = 0 Then
            TB1_voi.Text = 1
        Else
            TB1_voi.Text = Me.Grid1.Item(0, Me.Grid1.RowCount - 2).Value + 1
        End If


        Panel1.Width = 62
        CB1_voi.Items.Add("ALFA ROMEO")
        CB1_voi.Items.Add("AUDI")
        CB1_voi.Items.Add("BMW")
        CB1_voi.Items.Add("CHEVROLET")
        CB1_voi.Items.Add("DACIA")
        CB1_voi.Items.Add("DODGE")
        CB1_voi.Items.Add("FERRARI")
        CB1_voi.Items.Add("FIAT")
        CB1_voi.Items.Add("FORD")
        CB1_voi.Items.Add("HONDA")
        CB1_voi.Items.Add("HUMMER")
        CB1_voi.Items.Add("HYUNDAI")
        CB1_voi.Items.Add("INFINITI")
        CB1_voi.Items.Add("JAGUAR")
        CB1_voi.Items.Add("JEEP")
        CB1_voi.Items.Add("KIA")
        CB1_voi.Items.Add("LAMBORGHINI")
        CB1_voi.Items.Add("LAND ROVER")
        CB1_voi.Items.Add("MASERATI")
        CB1_voi.Items.Add("MAZDA")
        CB1_voi.Items.Add("MERCEDES")
        CB1_voi.Items.Add("MINI")
        CB1_voi.Items.Add("MITSUBISHI")
        CB1_voi.Items.Add("NISSAN")
        CB1_voi.Items.Add("OPEL")
        CB1_voi.Items.Add("PEUGEOT")
        CB1_voi.Items.Add("PORSCHE")
        CB1_voi.Items.Add("RENAULT")
        CB1_voi.Items.Add("ROVER")
        CB1_voi.Items.Add("SEAT")
        CB1_voi.Items.Add("SUZUKI")
        CB1_voi.Items.Add("TOYOTA")
        CB1_voi.Items.Add("VOLVO")

        CB2_voi.Items.Add("Essence")
        CB2_voi.Items.Add("Diesel")

        CB3_voi.Items.Add("Argent")
        CB3_voi.Items.Add("Bleu")
        CB3_voi.Items.Add("Blanc")
        CB3_voi.Items.Add("Gris")
        CB3_voi.Items.Add("Jaune")
        CB3_voi.Items.Add("Marron")
        CB3_voi.Items.Add("Noir")
        CB3_voi.Items.Add("Orange")
        CB3_voi.Items.Add("Rose")
        CB3_voi.Items.Add("Rouge")
        CB3_voi.Items.Add("Vert")
        CB3_voi.Items.Add("Violet")


    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel1.Width = 200
        PictureBox7.Visible = False

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Panel1.Width = 62
        PictureBox7.Visible = True
    End Sub

    Private Sub Bt_Add_Pic_MouseDown(sender As Object, e As MouseEventArgs) Handles Bt_Add_Pic.MouseDown
        Bt_Add_Pic.BackgroundImage = My.Resources.add_img3
    End Sub

    Private Sub Bt_Add_Pic_MouseEnter(sender As Object, e As EventArgs) Handles Bt_Add_Pic.MouseEnter
        Bt_Add_Pic.BackgroundImage = My.Resources.add_img2
    End Sub

    Private Sub Bt_Add_Pic_MouseLeave(sender As Object, e As EventArgs) Handles Bt_Add_Pic.MouseLeave
        Bt_Add_Pic.BackgroundImage = My.Resources.add_img1
    End Sub

    Private Sub Bt_Add_Pic_MouseUp(sender As Object, e As MouseEventArgs) Handles Bt_Add_Pic.MouseUp
        Bt_Add_Pic.BackgroundImage = My.Resources.add_img2
    End Sub

    'Private Sub CB1_TextChanged(sender As Object, e As EventArgs)
    '    For s = 0 To Me.Grid1.RowCount - 2
    '        If TB1_voi.Text = Me.Grid1.Item(0, s).Value Then
    '            TB2_voi.Text = Me.Grid1.Item(1, s).Value
    '            CB1_voi.Text = Me.Grid1.Item(1, s).Value

    '        End If
    '    Next

    'End Sub

    Private Sub ButtonX7_Click(sender As Object, e As EventArgs) Handles BT_Fer.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Grid1.Visible = False
    End Sub

    Private Sub BT_Ajo_Click(sender As Object, e As EventArgs) Handles BT_Ajo.Click

        Dim sw As Integer
        If TB1_voi.Text <> "" Then
            sw = 0
            For s = 0 To Me.Grid1.RowCount - 2
                If TB1_voi.Text = Me.Grid1.Item(0, s).Value Then
                    sw = 1
                End If
            Next
            If TB1_voi.Text <> "" And TB2_voi.Text <> "" And TB3_voi.Text <> "" And TB4_voi.Text <> "" And CB1_voi.Text <> "" And CB2_voi.Text <> "" And CB3_voi.Text <> "" Then

                'If TB1_voi.Text <> "" And TB2_voi.Text <> "" And TB3_voi.Text <> "" And TB4_voi.Text <> "" And TB5_voi.Text <> "" And TB6_voi.Text <> "" And TB7_voi.Text <> "" And CB1_voi.Text <> "" And CB2_voi.Text <> "" And CB3_voi.Text <> "" And CB4_voi.Text <> "" Then
                If sw = 0 Then
                    Dim NewLigne As DataRow
                    ' Création de la nouvelle ligne 
                    NewLigne = dtset.Tables("voiture").NewRow
                    'affectation des valeurs
                    NewLigne(0) = TB1_voi.Text
                    NewLigne(1) = UCase(TB2_voi.Text)
                    NewLigne(2) = CB1_voi.Text
                    NewLigne(3) = CB2_voi.Text
                    NewLigne(4) = TB3_voi.Text
                    NewLigne(5) = CB3_voi.Text
                    NewLigne(6) = TB4_voi.Text
                    NewLigne(7) = CB4_voi.Text
                    NewLigne(8) = TB5_voi.Text
                    NewLigne(9) = TB6_voi.Text
                    NewLigne(10) = TB7_voi.Text

                    If ac.Checked = True Then
                        NewLigne(11) = 1
                    End If
                    If br.Checked = True Then
                        NewLigne(11) = 2
                    End If
                    If bd.Checked = True Then
                        NewLigne(11) = 3
                    End If

                    'NewLigne(12) = ConvertToData(Me.pic_car1.Image)
                    'NewLigne(13) = ConvertToData(Me.pic_car2.Image)

                    'Qr1.Text = "CIN :" + TB1_voi.Text() & vbCrLf & "Matricule :" + TB2_voi.Text() & vbCrLf & "Marque :" + CB1_voi.Text() & vbCrLf & "Type Carburant:" + CB2_voi.Text()
                    'NewLigne(14) = ConvertToData(Me.Qr1.Image)


                    ' Ajout de la ligne à la table
                    dtset.Tables("voiture").Rows.Add(NewLigne)
                    ' Création CommandBuilder 
                    '(genere automatiquement l'update entre le dataSet et la base de donnée
                    Dim CmdBuild As OleDb.OleDbCommandBuilder
                    CmdBuild = New OleDb.OleDbCommandBuilder(dtadapter)
                    dtadapter.InsertCommand = CmdBuild.GetInsertCommand
                    dtadapter.Update(dtset, "voiture")
                    MsgBox("Ajout Avec Succes", MsgBoxStyle.Information)

                    TB1_voi.Text = Nothing
                    TB2_voi.Text = Nothing
                    TB3_voi.Text = Nothing
                    TB4_voi.Text = Nothing
                    TB5_voi.Text = Nothing
                    TB6_voi.Text = Nothing
                    TB7_voi.Text = Nothing
                    CB1_voi.Text = Nothing
                    CB2_voi.Text = Nothing
                    CB3_voi.Text = Nothing
                    CB4_voi.Text = Nothing
                    ac.Checked = False
                    br.Checked = False
                    bd.Checked = False

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

    Public Function ConvertToImage(ByVal data() As Byte) As Image
        Dim stream As New MemoryStream(data)
        Return Image.FromStream(stream)

    End Function

    Public Function ConvertToData(ByVal myImage As Image) As Byte()
        Dim ms As New MemoryStream()
        myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        'Qr1.Image.Save(SaveFileDialog1.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim myBytes(ms.Length - 1) As Byte
        ms.Position = 0
        ms.Read(myBytes, 0, ms.Length)
        Return myBytes
    End Function

    Private Sub BT_Raz_Click(sender As Object, e As EventArgs) Handles BT_Raz.Click
        TB1_voi.Text = Nothing
        TB2_voi.Text = Nothing
        TB3_voi.Text = Nothing
        TB4_voi.Text = Nothing
        TB5_voi.Text = Nothing
        TB6_voi.Text = Nothing
        TB7_voi.Text = Nothing
        CB1_voi.Text = Nothing
        CB2_voi.Text = Nothing
        CB3_voi.Text = Nothing
        CB4_voi.Text = Nothing
        ac.Checked = False
        br.Checked = False
        bd.Checked = False
    End Sub

    Private Sub BT_Rech_TB_Click(sender As Object, e As EventArgs) Handles BT_Rech_TB.Click
        Dim sw As Integer = 0
        If TB1_voi.Text <> "" Then
            For s = 0 To Me.Grid1.RowCount - 2
                If TB1_voi.Text = Me.Grid1.Item(0, s).Value Then
                    sw = 1
                    TB2_voi.Text = Me.Grid1.Item(1, s).Value
                    CB1_voi.Text = Me.Grid1.Item(2, s).Value
                    CB2_voi.Text = Me.Grid1.Item(3, s).Value
                    TB3_voi.Text = Me.Grid1.Item(4, s).Value
                    CB3_voi.Text = Me.Grid1.Item(5, s).Value
                    TB4_voi.Text = Me.Grid1.Item(6, s).Value
                    CB4_voi.Text = Me.Grid1.Item(7, s).Value
                    TB5_voi.Text = Me.Grid1.Item(8, s).Value
                    TB6_voi.Text = Me.Grid1.Item(9, s).Value
                    TB7_voi.Text = Me.Grid1.Item(10, s).Value

                    If ac.Checked = True Then
                        Me.Grid1.Item(11, s).Value = 1
                    End If
                    If br.Checked = True Then
                        Me.Grid1.Item(11, s).Value = 2
                    End If
                    If bd.Checked = True Then
                        Me.Grid1.Item(11, s).Value = 3
                    End If

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
        Dim sw As Integer = 0
        a = InputBox("Entrer la Référence Demandé", "Auto IMEBA")

        For s = 0 To Me.Grid1.RowCount - 2
            If a = Me.Grid1.Item(0, s).Value Then
                sw = 1
                TB2_voi.Text = Me.Grid1.Item(1, s).Value
                CB1_voi.Text = Me.Grid1.Item(2, s).Value
                CB2_voi.Text = Me.Grid1.Item(3, s).Value
                TB3_voi.Text = Me.Grid1.Item(4, s).Value
                CB3_voi.Text = Me.Grid1.Item(5, s).Value
                TB4_voi.Text = Me.Grid1.Item(6, s).Value
                CB4_voi.Text = Me.Grid1.Item(7, s).Value
                TB5_voi.Text = Me.Grid1.Item(8, s).Value
                TB6_voi.Text = Me.Grid1.Item(9, s).Value
                TB7_voi.Text = Me.Grid1.Item(10, s).Value

                If ac.Checked = True Then
                    Me.Grid1.Item(11, s).Value = 1
                End If
                If br.Checked = True Then
                    Me.Grid1.Item(11, s).Value = 2
                End If
                If bd.Checked = True Then
                    Me.Grid1.Item(11, s).Value = 3
                End If

            End If
        Next
        If sw = 0 Then
            MsgBox("Référence Introuvable", MsgBoxStyle.Critical)
        End If
        Me.TopMost = True
    End Sub

    Private Sub base(ByVal adapter As OleDbDataAdapter, ByVal table As String)
        ' con.Open() 
        Dim cmdbuilder As OleDbCommandBuilder
        cmdbuilder = New OleDb.OleDbCommandBuilder(adapter)
        adapter.UpdateCommand = cmdbuilder.GetUpdateCommand
        adapter.Update(dtset, table)
    End Sub

    Private Sub BT_Mod_Click(sender As Object, e As EventArgs) Handles BT_Mod.Click
        If TB1_voi.Text <> "" And TB2_voi.Text <> "" And TB3_voi.Text <> "" And TB4_voi.Text <> "" And TB5_voi.Text <> "" And TB6_voi.Text <> "" And TB7_voi.Text <> "" And CB1_voi.Text <> "" And CB2_voi.Text <> "" And CB3_voi.Text <> "" And CB4_voi.Text <> "" And GB_etat.Text <> "" Then
            If MsgBox("voulez vous vraiment Modifier cet enregistrement", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim sw As Integer
                sw = 0
                Dim x As Integer
                For s = 0 To Me.Grid1.RowCount - 2
                    If TB1_voi.Text = Me.Grid1.Item(0, s).Value Then
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
                    matable = dtset.Tables("voiture")
                    Dim laligne As DataRow()
                    laligne = matable.Select("id_voi=" & cle)
                    laligne(0).Item(1) = TB2_voi.Text
                    laligne(0).Item(2) = CB1_voi.Text
                    laligne(0).Item(3) = CB2_voi.Text
                    laligne(0).Item(4) = TB3_voi.Text
                    laligne(0).Item(5) = CB3_voi.Text
                    laligne(0).Item(6) = TB4_voi.Text
                    laligne(0).Item(7) = CB4_voi.Text
                    laligne(0).Item(8) = TB5_voi.Text
                    laligne(0).Item(9) = TB6_voi.Text
                    laligne(0).Item(10) = TB7_voi.Text

                    If ac.Checked = True Then

                        laligne(0).Item(11) = 1
                    End If
                    If br.Checked = True Then
                        laligne(0).Item(11) = 2
                    End If
                    If bd.Checked = True Then
                        laligne(0).Item(11) = 3
                    End If

                    base(dtadapter, "voiture")
                    MsgBox("Modification Avec Succes", MsgBoxStyle.Information)
                Else
                    MsgBox("Référence N’Existe Pas", MsgBoxStyle.Critical)
                End If
            End If

        Else
            MsgBox("Vous Devez Remplir Tous Les Champs SVP", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Grid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid1.CellClick
        Dim ligneencours As Integer
        ligneencours = Grid1.CurrentRow.Index
        TB1_voi.Text = Grid1.Item(0, ligneencours).Value
        TB2_voi.Text = Grid1.Item(1, ligneencours).Value
        CB1_voi.Text = Grid1.Item(2, ligneencours).Value
        CB2_voi.Text = Grid1.Item(3, ligneencours).Value
        TB3_voi.Text = Grid1.Item(4, ligneencours).Value
        CB3_voi.Text = Grid1.Item(3, ligneencours).Value
        TB4_voi.Text = Grid1.Item(5, ligneencours).Value
        CB4_voi.Text = Grid1.Item(6, ligneencours).Value
        TB5_voi.Text = Grid1.Item(7, ligneencours).Value
        TB6_voi.Text = Grid1.Item(8, ligneencours).Value
        TB7_voi.Text = Grid1.Item(9, ligneencours).Value

        If Me.Grid1.Item(9, ligneencours).Value = 1 Then
            ac.Checked = True
        End If
        If Me.Grid1.Item(9, ligneencours).Value = 2 Then
            br.Checked = True
        End If
        If Me.Grid1.Item(9, ligneencours).Value = 3 Then
            bd.Checked = True
        End If

    End Sub

    Private Sub BT_Sup_Click(sender As Object, e As EventArgs) Handles BT_Sup.Click
        If TB1_voi.Text <> "" Then
            x = MessageBox.Show("Voulez Vous Vraiment Supprimer Cet Enregistrement", "Auto IMEBA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = MsgBoxResult.Yes Then
                Dim x As Integer
                For s = 0 To Me.Grid1.RowCount - 2
                    If TB1_voi.Text = Me.Grid1.Item(0, s).Value Then
                        x = s
                    End If
                Next

                Dim ligneencours As Integer
                ligneencours = x
                Dim cle As String
                cle = Grid1.Item(0, ligneencours).Value
                Dim ligne As DataRow()
                ligne = dtset.Tables("voiture").Select("id_voi=" & cle)
                ligne(0).Delete() 'Code uniquement pour la suppression dans la base de donnée locale
                TB1_voi.Text = Nothing
                TB2_voi.Text = Nothing
                TB3_voi.Text = Nothing
                TB4_voi.Text = Nothing
                TB5_voi.Text = Nothing
                TB6_voi.Text = Nothing
                TB7_voi.Text = Nothing
                CB1_voi.Text = Nothing
                CB2_voi.Text = Nothing
                CB3_voi.Text = Nothing
                CB4_voi.Text = Nothing
                ac.Checked = False
                br.Checked = False
                bd.Checked = False
                MsgBox("Suppression Effectuée dans la base de données Locale", MsgBoxStyle.Information)
                'con.Open() 'ici nous allons ouvrir la connexion pour accéder et utiliser la base de données distante 
                Dim cmdbuilder As OleDbCommandBuilder
                cmdbuilder = New OleDb.OleDbCommandBuilder(dtadapter)
                dtadapter.DeleteCommand = cmdbuilder.GetDeleteCommand
                dtadapter.Update(dtset, "voiture")
                MsgBox("Suppression Effectuée dans la base de données Distante", MsgBoxStyle.Information)

            End If
        Else
            MsgBox("Vous Devez Remplir Le Champ "" ID """, MsgBoxStyle.Exclamation)
        End If
        con.Close()

    End Sub

    Private Sub TB1_voi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB1_voi.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB5_voi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB5_voi.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
       AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB6_voi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB6_voi.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
       AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB7_voi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB7_voi.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
       AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub Bt_Add_Pic_Click(sender As Object, e As EventArgs) Handles Bt_Add_Pic.Click
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.ShowDialog()
        If Not Me.OpenFileDialog1.FileName = Nothing Then
            Me.pic_car1.ImageLocation = Me.OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.OpenFileDialog1.FileName = Nothing
        Me.OpenFileDialog1.ShowDialog()
        If Not Me.OpenFileDialog1.FileName = Nothing Then
            Me.pic_car2.ImageLocation = Me.OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Affecte un Nom au Fichier QR Code Exemple T3.text = CIN
        SaveFileDialog1.FileName = TB2_voi.Text

        'Convertir Qr Code Format JPG
        'Qr1.Image.Save(SaveFileDialog1.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        'Enregistrer en Tant que Objet Server Local « Debug »
        SaveFileDialog1.InitialDirectory = "C:\Users\lenovo\Desktop"
        'Enregistrement du Path pour Faciliter l’envoi pièce jointe    
        T_qr.Text = "C:\Users\lenovo\Documents\Visual Studio 2013\Projects\mdi\mdi\bin\Debug\qrcode\" + SaveFileDialog1.FileName + ".jpg"
    End Sub

End Class