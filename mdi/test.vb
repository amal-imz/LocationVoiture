Imports System.Drawing.Image
Imports System.IO
Imports System.Data.OleDb
Public Class test

    Private con As New OleDbConnection
    Private dtadapter As New OleDbDataAdapter("select *from voiture14", con)
    Private dtset As New DataSet
    Dim pos As Integer = 0
    Dim openDlg As OpenFileDialog = New OpenFileDialog
    Dim filename As String
    Dim imageCollection As New SortedList
    Dim x As DialogResult
    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.Ace.oledb.12.0;data source= ana.accdb"
        con.Open()
        dtadapter.Fill(dtset, "voiture14")
        'Remplissage GridView par le Contenu de la table T1 (Nomée Grid)       
        Grid1.DataSource = dtset.Tables("voiture14")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewLigne As DataRow
        ' Création de la nouvelle ligne 
        NewLigne = dtset.Tables("voiture14").NewRow
        'affectation des valeurs
        NewLigne(0) = CB4_voi.Text


        ' Ajout de la ligne à la table
        dtset.Tables("voiture14").Rows.Add(NewLigne)
        ' Création CommandBuilder 
        '(genere automatiquement l'update entre le dataSet et la base de donnée
        Dim CmdBuild As OleDb.OleDbCommandBuilder
        CmdBuild = New OleDb.OleDbCommandBuilder(dtadapter)
        dtadapter.InsertCommand = CmdBuild.GetInsertCommand
        dtadapter.Update(dtset, "voiture14")
        MsgBox("Ajout Avec Succes", MsgBoxStyle.Information)
    End Sub
End Class