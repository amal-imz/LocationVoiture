<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employe
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employe))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pic_emp = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_Fer = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Raz = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Ajo = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Rech_IB = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Sup = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Mod = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.BT_Rech_TB = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Bt_Add_Pic = New System.Windows.Forms.Button()
        Me.TB7_emp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB6_emp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB2_emp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB1_emp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TB4_emp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB3_emp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB5_emp = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Grid1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        CType(Me.pic_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_emp
        '
        Me.pic_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_emp.Image = Global.mdi.My.Resources.Resources.client_img
        Me.pic_emp.Location = New System.Drawing.Point(328, 95)
        Me.pic_emp.Name = "pic_emp"
        Me.pic_emp.Size = New System.Drawing.Size(200, 200)
        Me.pic_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_emp.TabIndex = 105
        Me.pic_emp.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.BT_Fer)
        Me.Panel1.Controls.Add(Me.BT_Raz)
        Me.Panel1.Controls.Add(Me.BT_Ajo)
        Me.Panel1.Controls.Add(Me.BT_Rech_IB)
        Me.Panel1.Controls.Add(Me.BT_Sup)
        Me.Panel1.Controls.Add(Me.BT_Mod)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.BT_Rech_TB)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(900, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 640)
        Me.Panel1.TabIndex = 110
        '
        'BT_Fer
        '
        Me.BT_Fer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Fer.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Fer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Fer.FocusCuesEnabled = False
        Me.BT_Fer.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Fer.Image = Global.mdi.My.Resources.Resources.close_form
        Me.BT_Fer.ImageTextSpacing = 5
        Me.BT_Fer.Location = New System.Drawing.Point(0, 570)
        Me.BT_Fer.Name = "BT_Fer"
        Me.BT_Fer.Size = New System.Drawing.Size(200, 54)
        Me.BT_Fer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Fer.TabIndex = 8
        Me.BT_Fer.Text = "  Fermer"
        Me.BT_Fer.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Fer.TextColor = System.Drawing.Color.Gray
        Me.ToolTip1.SetToolTip(Me.BT_Fer, "Fermer")
        '
        'BT_Raz
        '
        Me.BT_Raz.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Raz.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Raz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Raz.FocusCuesEnabled = False
        Me.BT_Raz.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Raz.Image = Global.mdi.My.Resources.Resources.raz
        Me.BT_Raz.ImageTextSpacing = 5
        Me.BT_Raz.Location = New System.Drawing.Point(-1, 499)
        Me.BT_Raz.Name = "BT_Raz"
        Me.BT_Raz.Size = New System.Drawing.Size(200, 54)
        Me.BT_Raz.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Raz.TabIndex = 7
        Me.BT_Raz.Text = "  Raz"
        Me.BT_Raz.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Raz.TextColor = System.Drawing.Color.Gray
        Me.ToolTip1.SetToolTip(Me.BT_Raz, "Raz")
        '
        'BT_Ajo
        '
        Me.BT_Ajo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Ajo.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Ajo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Ajo.FocusCuesEnabled = False
        Me.BT_Ajo.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Ajo.Image = Global.mdi.My.Resources.Resources.add
        Me.BT_Ajo.ImageTextSpacing = 5
        Me.BT_Ajo.Location = New System.Drawing.Point(0, 143)
        Me.BT_Ajo.Name = "BT_Ajo"
        Me.BT_Ajo.Size = New System.Drawing.Size(200, 54)
        Me.BT_Ajo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Ajo.TabIndex = 8
        Me.BT_Ajo.Text = "  Ajouter"
        Me.BT_Ajo.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Ajo.TextColor = System.Drawing.Color.Gray
        Me.ToolTip1.SetToolTip(Me.BT_Ajo, "Ajouter")
        '
        'BT_Rech_IB
        '
        Me.BT_Rech_IB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Rech_IB.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Rech_IB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Rech_IB.FocusCuesEnabled = False
        Me.BT_Rech_IB.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Rech_IB.Image = CType(resources.GetObject("BT_Rech_IB.Image"), System.Drawing.Image)
        Me.BT_Rech_IB.ImageTextSpacing = 5
        Me.BT_Rech_IB.Location = New System.Drawing.Point(0, 287)
        Me.BT_Rech_IB.Name = "BT_Rech_IB"
        Me.BT_Rech_IB.Size = New System.Drawing.Size(200, 54)
        Me.BT_Rech_IB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Rech_IB.TabIndex = 6
        Me.BT_Rech_IB.Text = "  Rech. InputBox"
        Me.BT_Rech_IB.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Rech_IB.TextColor = System.Drawing.Color.Gray
        Me.ToolTip1.SetToolTip(Me.BT_Rech_IB, "Recherche InputBox")
        '
        'BT_Sup
        '
        Me.BT_Sup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Sup.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Sup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Sup.FocusCuesEnabled = False
        Me.BT_Sup.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Sup.Image = Global.mdi.My.Resources.Resources.delete
        Me.BT_Sup.ImageTextSpacing = 5
        Me.BT_Sup.Location = New System.Drawing.Point(-1, 428)
        Me.BT_Sup.Name = "BT_Sup"
        Me.BT_Sup.Size = New System.Drawing.Size(200, 54)
        Me.BT_Sup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Sup.TabIndex = 6
        Me.BT_Sup.Text = "  Supprimer"
        Me.BT_Sup.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Sup.TextColor = System.Drawing.Color.Gray
        Me.ToolTip1.SetToolTip(Me.BT_Sup, "Supprimer")
        '
        'BT_Mod
        '
        Me.BT_Mod.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Mod.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Mod.FocusCuesEnabled = False
        Me.BT_Mod.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Mod.Image = Global.mdi.My.Resources.Resources.edit
        Me.BT_Mod.ImageTextSpacing = 5
        Me.BT_Mod.Location = New System.Drawing.Point(0, 356)
        Me.BT_Mod.Name = "BT_Mod"
        Me.BT_Mod.Size = New System.Drawing.Size(200, 54)
        Me.BT_Mod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Mod.TabIndex = 7
        Me.BT_Mod.Text = "  Modifier"
        Me.BT_Mod.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Mod.TextColor = System.Drawing.Color.Gray
        Me.ToolTip1.SetToolTip(Me.BT_Mod, "Modifier")
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.mdi.My.Resources.Resources.expand_menu_button
        Me.PictureBox6.Location = New System.Drawing.Point(78, 20)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Masquer")
        '
        'BT_Rech_TB
        '
        Me.BT_Rech_TB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Rech_TB.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Rech_TB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Rech_TB.FocusCuesEnabled = False
        Me.BT_Rech_TB.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Rech_TB.Image = Global.mdi.My.Resources.Resources.search
        Me.BT_Rech_TB.ImageTextSpacing = 5
        Me.BT_Rech_TB.Location = New System.Drawing.Point(0, 216)
        Me.BT_Rech_TB.Name = "BT_Rech_TB"
        Me.BT_Rech_TB.Size = New System.Drawing.Size(200, 54)
        Me.BT_Rech_TB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Rech_TB.TabIndex = 5
        Me.BT_Rech_TB.Text = "  Rech. TextBox"
        Me.BT_Rech_TB.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Rech_TB.TextColor = System.Drawing.Color.Gray
        Me.ToolTip1.SetToolTip(Me.BT_Rech_TB, "Recherche TextBox")
        '
        'PictureBox7
        '
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.mdi.My.Resources.Resources.expand_menu_button
        Me.PictureBox7.Location = New System.Drawing.Point(7, 20)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox7.TabIndex = 4
        Me.PictureBox7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox7, "Afficher")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 30000
        Me.ToolTip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.StripAmpersands = True
        '
        'Bt_Add_Pic
        '
        Me.Bt_Add_Pic.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Add_Pic.BackgroundImage = Global.mdi.My.Resources.Resources.add_img1
        Me.Bt_Add_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Bt_Add_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Add_Pic.FlatAppearance.BorderSize = 0
        Me.Bt_Add_Pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Bt_Add_Pic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Bt_Add_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Add_Pic.Location = New System.Drawing.Point(406, 4)
        Me.Bt_Add_Pic.Name = "Bt_Add_Pic"
        Me.Bt_Add_Pic.Size = New System.Drawing.Size(42, 42)
        Me.Bt_Add_Pic.TabIndex = 99
        Me.ToolTip1.SetToolTip(Me.Bt_Add_Pic, "Ajouter des Images")
        Me.Bt_Add_Pic.UseVisualStyleBackColor = False
        '
        'TB7_emp
        '
        Me.TB7_emp.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB7_emp.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_emp.Border.BorderBottomWidth = 2
        Me.TB7_emp.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB7_emp.Border.BorderGradientAngle = 0
        Me.TB7_emp.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_emp.Border.BorderLeftWidth = 2
        Me.TB7_emp.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_emp.Border.BorderRightWidth = 2
        Me.TB7_emp.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_emp.Border.BorderTopWidth = 2
        Me.TB7_emp.Border.Class = "TextBoxBorder"
        Me.TB7_emp.Border.CornerDiameter = 10
        Me.TB7_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB7_emp.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB7_emp.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB7_emp.Location = New System.Drawing.Point(584, 238)
        Me.TB7_emp.Name = "TB7_emp"
        Me.TB7_emp.Size = New System.Drawing.Size(273, 43)
        Me.TB7_emp.TabIndex = 102
        Me.TB7_emp.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB7_emp.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB7_emp.WatermarkImage = Global.mdi.My.Resources.Resources.prix
        Me.TB7_emp.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB7_emp.WatermarkText = " Etat"
        '
        'TB6_emp
        '
        Me.TB6_emp.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB6_emp.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_emp.Border.BorderBottomWidth = 2
        Me.TB6_emp.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB6_emp.Border.BorderGradientAngle = 0
        Me.TB6_emp.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_emp.Border.BorderLeftWidth = 2
        Me.TB6_emp.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_emp.Border.BorderRightWidth = 2
        Me.TB6_emp.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_emp.Border.BorderTopWidth = 2
        Me.TB6_emp.Border.Class = "TextBoxBorder"
        Me.TB6_emp.Border.CornerDiameter = 10
        Me.TB6_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB6_emp.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB6_emp.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB6_emp.Location = New System.Drawing.Point(584, 177)
        Me.TB6_emp.Name = "TB6_emp"
        Me.TB6_emp.Size = New System.Drawing.Size(273, 43)
        Me.TB6_emp.TabIndex = 97
        Me.TB6_emp.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB6_emp.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB6_emp.WatermarkImage = Global.mdi.My.Resources.Resources.kilometrage
        Me.TB6_emp.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB6_emp.WatermarkText = " E-mail"
        '
        'TB2_emp
        '
        Me.TB2_emp.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB2_emp.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_emp.Border.BorderBottomWidth = 2
        Me.TB2_emp.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB2_emp.Border.BorderGradientAngle = 0
        Me.TB2_emp.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_emp.Border.BorderLeftWidth = 2
        Me.TB2_emp.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_emp.Border.BorderRightWidth = 2
        Me.TB2_emp.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_emp.Border.BorderTopWidth = 2
        Me.TB2_emp.Border.Class = "TextBoxBorder"
        Me.TB2_emp.Border.CornerDiameter = 10
        Me.TB2_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB2_emp.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB2_emp.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB2_emp.Location = New System.Drawing.Point(1, 145)
        Me.TB2_emp.Name = "TB2_emp"
        Me.TB2_emp.Size = New System.Drawing.Size(273, 43)
        Me.TB2_emp.TabIndex = 96
        Me.TB2_emp.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB2_emp.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB2_emp.WatermarkImage = CType(resources.GetObject("TB2_emp.WatermarkImage"), System.Drawing.Image)
        Me.TB2_emp.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB2_emp.WatermarkText = " CIN"
        '
        'TB1_emp
        '
        Me.TB1_emp.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB1_emp.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_emp.Border.BorderBottomWidth = 2
        Me.TB1_emp.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB1_emp.Border.BorderGradientAngle = 0
        Me.TB1_emp.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_emp.Border.BorderLeftWidth = 2
        Me.TB1_emp.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_emp.Border.BorderRightWidth = 2
        Me.TB1_emp.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_emp.Border.BorderTopWidth = 2
        Me.TB1_emp.Border.Class = "TextBoxBorder"
        Me.TB1_emp.Border.CornerDiameter = 10
        Me.TB1_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB1_emp.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB1_emp.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB1_emp.Location = New System.Drawing.Point(1, 84)
        Me.TB1_emp.Name = "TB1_emp"
        Me.TB1_emp.Size = New System.Drawing.Size(273, 43)
        Me.TB1_emp.TabIndex = 95
        Me.TB1_emp.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB1_emp.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB1_emp.WatermarkImage = CType(resources.GetObject("TB1_emp.WatermarkImage"), System.Drawing.Image)
        Me.TB1_emp.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB1_emp.WatermarkText = " ID"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.mdi.My.Resources.Resources.border_add_img3
        Me.PictureBox2.Location = New System.Drawing.Point(316, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(223, 286)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'TB4_emp
        '
        Me.TB4_emp.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB4_emp.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_emp.Border.BorderBottomWidth = 2
        Me.TB4_emp.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB4_emp.Border.BorderGradientAngle = 0
        Me.TB4_emp.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_emp.Border.BorderLeftWidth = 2
        Me.TB4_emp.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_emp.Border.BorderRightWidth = 2
        Me.TB4_emp.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_emp.Border.BorderTopWidth = 2
        Me.TB4_emp.Border.Class = "TextBoxBorder"
        Me.TB4_emp.Border.CornerDiameter = 10
        Me.TB4_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB4_emp.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB4_emp.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB4_emp.Location = New System.Drawing.Point(1, 267)
        Me.TB4_emp.Name = "TB4_emp"
        Me.TB4_emp.Size = New System.Drawing.Size(273, 43)
        Me.TB4_emp.TabIndex = 108
        Me.TB4_emp.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB4_emp.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB4_emp.WatermarkImage = Global.mdi.My.Resources.Resources.model
        Me.TB4_emp.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB4_emp.WatermarkText = " Prénom"
        '
        'TB3_emp
        '
        Me.TB3_emp.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB3_emp.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_emp.Border.BorderBottomWidth = 2
        Me.TB3_emp.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB3_emp.Border.BorderGradientAngle = 0
        Me.TB3_emp.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_emp.Border.BorderLeftWidth = 2
        Me.TB3_emp.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_emp.Border.BorderRightWidth = 2
        Me.TB3_emp.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_emp.Border.BorderTopWidth = 2
        Me.TB3_emp.Border.Class = "TextBoxBorder"
        Me.TB3_emp.Border.CornerDiameter = 10
        Me.TB3_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB3_emp.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB3_emp.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB3_emp.Location = New System.Drawing.Point(1, 206)
        Me.TB3_emp.Name = "TB3_emp"
        Me.TB3_emp.Size = New System.Drawing.Size(273, 43)
        Me.TB3_emp.TabIndex = 107
        Me.TB3_emp.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB3_emp.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB3_emp.WatermarkImage = Global.mdi.My.Resources.Resources.model
        Me.TB3_emp.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB3_emp.WatermarkText = " Nom"
        '
        'TB5_emp
        '
        Me.TB5_emp.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB5_emp.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_emp.Border.BorderBottomWidth = 2
        Me.TB5_emp.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB5_emp.Border.BorderGradientAngle = 0
        Me.TB5_emp.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_emp.Border.BorderLeftWidth = 2
        Me.TB5_emp.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_emp.Border.BorderRightWidth = 2
        Me.TB5_emp.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_emp.Border.BorderTopWidth = 2
        Me.TB5_emp.Border.Class = "TextBoxBorder"
        Me.TB5_emp.Border.CornerDiameter = 10
        Me.TB5_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB5_emp.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB5_emp.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB5_emp.Location = New System.Drawing.Point(584, 116)
        Me.TB5_emp.Name = "TB5_emp"
        Me.TB5_emp.Size = New System.Drawing.Size(273, 43)
        Me.TB5_emp.TabIndex = 106
        Me.TB5_emp.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB5_emp.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB5_emp.WatermarkImage = Global.mdi.My.Resources.Resources.date_dachat
        Me.TB5_emp.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB5_emp.WatermarkText = " Téléphone"
        '
        'Grid1
        '
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Grid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Grid1.Location = New System.Drawing.Point(1, 428)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(856, 212)
        Me.Grid1.TabIndex = 98
        '
        'employe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1100, 640)
        Me.Controls.Add(Me.pic_emp)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TB7_emp)
        Me.Controls.Add(Me.Bt_Add_Pic)
        Me.Controls.Add(Me.TB6_emp)
        Me.Controls.Add(Me.TB2_emp)
        Me.Controls.Add(Me.TB1_emp)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TB4_emp)
        Me.Controls.Add(Me.TB3_emp)
        Me.Controls.Add(Me.TB5_emp)
        Me.Controls.Add(Me.Grid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(247, 95)
        Me.Name = "employe"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "employe"
        Me.TopMost = True
        CType(Me.pic_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic_emp As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BT_Fer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BT_Raz As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Ajo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Rech_IB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Sup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Mod As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_Rech_TB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Bt_Add_Pic As System.Windows.Forms.Button
    Friend WithEvents TB7_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB6_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB2_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB1_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TB4_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB3_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB5_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Grid1 As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
