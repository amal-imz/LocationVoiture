<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voiture
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(voiture))
        Me.Grid1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CB1_voi = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CB2_voi = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CB3_voi = New DevComponents.DotNetBar.Controls.ComboBoxEx()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CB4_voi = New System.Windows.Forms.CheckedListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Bt_Add_Pic = New System.Windows.Forms.Button()
        Me.TB4_voi = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.PropertySettings1 = New DevComponents.DotNetBar.PropertySettings()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.GB_etat = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.bd = New System.Windows.Forms.RadioButton()
        Me.br = New System.Windows.Forms.RadioButton()
        Me.ac = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.T_qr = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.TB6_voi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB66_voi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.pic_car2 = New System.Windows.Forms.PictureBox()
        Me.pic_car1 = New System.Windows.Forms.PictureBox()
        Me.TB3_voi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB7_voi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB5_voi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB2_voi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB1_voi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB4_voi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_etat.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Grid1.Location = New System.Drawing.Point(1, 550)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(856, 90)
        Me.Grid1.TabIndex = 17
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CB1_voi
        '
        Me.CB1_voi.DisabledBackColor = System.Drawing.SystemColors.WindowFrame
        Me.CB1_voi.DisabledForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CB1_voi.DisplayMember = "Text"
        Me.CB1_voi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB1_voi.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CB1_voi.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CB1_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CB1_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CB1_voi.FormattingEnabled = True
        Me.CB1_voi.IntegralHeight = False
        Me.CB1_voi.ItemHeight = 27
        Me.CB1_voi.Location = New System.Drawing.Point(7, 131)
        Me.CB1_voi.MaxDropDownItems = 9
        Me.CB1_voi.Name = "CB1_voi"
        Me.CB1_voi.Size = New System.Drawing.Size(259, 33)
        Me.CB1_voi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB1_voi.TabIndex = 30
        Me.CB1_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.CB1_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.CB1_voi.WatermarkText = " Marque"
        '
        'CB2_voi
        '
        Me.CB2_voi.DisabledBackColor = System.Drawing.SystemColors.WindowFrame
        Me.CB2_voi.DisabledForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CB2_voi.DisplayMember = "Text"
        Me.CB2_voi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB2_voi.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CB2_voi.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CB2_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CB2_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CB2_voi.FormattingEnabled = True
        Me.CB2_voi.ItemHeight = 27
        Me.CB2_voi.Location = New System.Drawing.Point(7, 192)
        Me.CB2_voi.Name = "CB2_voi"
        Me.CB2_voi.Size = New System.Drawing.Size(259, 33)
        Me.CB2_voi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB2_voi.TabIndex = 31
        Me.CB2_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.CB2_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.CB2_voi.WatermarkText = " Type carburant"
        '
        'CB3_voi
        '
        Me.CB3_voi.DisabledBackColor = System.Drawing.SystemColors.WindowFrame
        Me.CB3_voi.DisabledForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CB3_voi.DisplayMember = "Text"
        Me.CB3_voi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB3_voi.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CB3_voi.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CB3_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CB3_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CB3_voi.FormattingEnabled = True
        Me.CB3_voi.IntegralHeight = False
        Me.CB3_voi.ItemHeight = 27
        Me.CB3_voi.Location = New System.Drawing.Point(7, 314)
        Me.CB3_voi.MaxDropDownItems = 9
        Me.CB3_voi.Name = "CB3_voi"
        Me.CB3_voi.Size = New System.Drawing.Size(259, 33)
        Me.CB3_voi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB3_voi.TabIndex = 32
        Me.CB3_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.CB3_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.CB3_voi.WatermarkText = " Couleur"
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
        Me.Panel1.TabIndex = 40
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
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 30000
        Me.ToolTip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.StripAmpersands = True
        '
        'CB4_voi
        '
        Me.CB4_voi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CB4_voi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CB4_voi.CheckOnClick = True
        Me.CB4_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CB4_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CB4_voi.FormattingEnabled = True
        Me.CB4_voi.Items.AddRange(New Object() {"Airbag", "Antibrouillards", "Boîte automatique", "Climatisation", "GPS", "Kit fumeur", "Régulateur"})
        Me.CB4_voi.Location = New System.Drawing.Point(591, 76)
        Me.CB4_voi.Name = "CB4_voi"
        Me.CB4_voi.Size = New System.Drawing.Size(259, 84)
        Me.CB4_voi.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.CB4_voi, "Option")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.mdi.My.Resources.Resources.add_img1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(516, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 42)
        Me.Button3.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.Button3, "Ajouter des Images")
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.Bt_Add_Pic.Location = New System.Drawing.Point(408, 4)
        Me.Bt_Add_Pic.Name = "Bt_Add_Pic"
        Me.Bt_Add_Pic.Size = New System.Drawing.Size(42, 42)
        Me.Bt_Add_Pic.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Bt_Add_Pic, "Ajouter des Images")
        Me.Bt_Add_Pic.UseVisualStyleBackColor = False
        '
        'TB4_voi
        '
        '
        '
        '
        Me.TB4_voi.BackgroundStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TB4_voi.BackgroundStyle.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.TB4_voi.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TB4_voi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TB4_voi.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.TB4_voi.ButtonDropDown.Visible = True
        Me.TB4_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB4_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB4_voi.IsPopupCalendarOpen = False
        Me.TB4_voi.Location = New System.Drawing.Point(590, 9)
        '
        '
        '
        Me.TB4_voi.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TB4_voi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TB4_voi.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.TB4_voi.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.TB4_voi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.TB4_voi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.TB4_voi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.TB4_voi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_voi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.TB4_voi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.TB4_voi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TB4_voi.MonthCalendar.DisplayMonth = New Date(2017, 4, 1, 0, 0, 0, 0)
        Me.TB4_voi.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.TB4_voi.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.TB4_voi.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TB4_voi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TB4_voi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.TB4_voi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TB4_voi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TB4_voi.MonthCalendar.TodayButtonVisible = True
        Me.TB4_voi.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.TB4_voi.Name = "TB4_voi"
        Me.TB4_voi.Size = New System.Drawing.Size(224, 33)
        Me.TB4_voi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TB4_voi.TabIndex = 58
        Me.TB4_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB4_voi.WatermarkText = " Date d'achat"
        '
        'PropertySettings1
        '
        Me.PropertySettings1.PropertyName = ""
        '
        'GB_etat
        '
        Me.GB_etat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GB_etat.CanvasColor = System.Drawing.Color.Maroon
        Me.GB_etat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.GB_etat.Controls.Add(Me.bd)
        Me.GB_etat.Controls.Add(Me.br)
        Me.GB_etat.Controls.Add(Me.ac)
        Me.GB_etat.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GB_etat.Location = New System.Drawing.Point(107, 381)
        Me.GB_etat.Name = "GB_etat"
        Me.GB_etat.Size = New System.Drawing.Size(200, 150)
        '
        '
        '
        Me.GB_etat.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GB_etat.Style.BackColorGradientAngle = 90
        Me.GB_etat.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GB_etat.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GB_etat.Style.BorderBottomWidth = 1
        Me.GB_etat.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GB_etat.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GB_etat.Style.BorderLeftWidth = 1
        Me.GB_etat.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GB_etat.Style.BorderRightWidth = 1
        Me.GB_etat.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GB_etat.Style.BorderTopWidth = 1
        Me.GB_etat.Style.CornerDiameter = 4
        Me.GB_etat.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GB_etat.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GB_etat.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GB_etat.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GB_etat.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GB_etat.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GB_etat.TabIndex = 64
        Me.GB_etat.Text = "Etat"
        '
        'bd
        '
        Me.bd.AutoSize = True
        Me.bd.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bd.Location = New System.Drawing.Point(3, 86)
        Me.bd.Name = "bd"
        Me.bd.Size = New System.Drawing.Size(175, 23)
        Me.bd.TabIndex = 2
        Me.bd.TabStop = True
        Me.bd.Text = "Bloque Définitivement"
        Me.bd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bd.UseVisualStyleBackColor = True
        '
        'br
        '
        Me.br.AutoSize = True
        Me.br.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.br.Location = New System.Drawing.Point(3, 51)
        Me.br.Name = "br"
        Me.br.Size = New System.Drawing.Size(154, 23)
        Me.br.TabIndex = 1
        Me.br.TabStop = True
        Me.br.Text = "Bloque Reservation"
        Me.br.UseVisualStyleBackColor = True
        '
        'ac
        '
        Me.ac.AutoSize = True
        Me.ac.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ac.Location = New System.Drawing.Point(4, 15)
        Me.ac.Name = "ac"
        Me.ac.Size = New System.Drawing.Size(58, 23)
        Me.ac.TabIndex = 0
        Me.ac.TabStop = True
        Me.ac.Text = "Actif"
        Me.ac.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 32)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(335, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 32)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(616, 400)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "creer qr"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'T_qr
        '
        Me.T_qr.Location = New System.Drawing.Point(616, 466)
        Me.T_qr.Name = "T_qr"
        Me.T_qr.Size = New System.Drawing.Size(157, 20)
        Me.T_qr.TabIndex = 71
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.mdi.My.Resources.Resources.border_tb1
        Me.PictureBox9.Location = New System.Drawing.Point(584, 65)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(275, 104)
        Me.PictureBox9.TabIndex = 63
        Me.PictureBox9.TabStop = False
        '
        'TB6_voi
        '
        Me.TB6_voi.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB6_voi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_voi.Border.BorderBottomWidth = 2
        Me.TB6_voi.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB6_voi.Border.BorderGradientAngle = 0
        Me.TB6_voi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_voi.Border.BorderLeftWidth = 2
        Me.TB6_voi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_voi.Border.BorderRightWidth = 2
        Me.TB6_voi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_voi.Border.BorderTopWidth = 2
        Me.TB6_voi.Border.Class = "TextBoxBorder"
        Me.TB6_voi.Border.CornerDiameter = 10
        Me.TB6_voi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB6_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB6_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB6_voi.Location = New System.Drawing.Point(584, 248)
        Me.TB6_voi.Name = "TB6_voi"
        Me.TB6_voi.Size = New System.Drawing.Size(273, 43)
        Me.TB6_voi.TabIndex = 61
        Me.TB6_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB6_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB6_voi.WatermarkImage = Global.mdi.My.Resources.Resources.car_seat
        Me.TB6_voi.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB6_voi.WatermarkText = " Nombre de port"
        '
        'TB66_voi
        '
        Me.TB66_voi.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB66_voi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB66_voi.Border.BorderBottomWidth = 2
        Me.TB66_voi.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB66_voi.Border.BorderGradientAngle = 0
        Me.TB66_voi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB66_voi.Border.BorderLeftWidth = 2
        Me.TB66_voi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB66_voi.Border.BorderRightWidth = 2
        Me.TB66_voi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB66_voi.Border.BorderTopWidth = 2
        Me.TB66_voi.Border.Class = "TextBoxBorder"
        Me.TB66_voi.Border.CornerDiameter = 10
        Me.TB66_voi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB66_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB66_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB66_voi.Location = New System.Drawing.Point(584, 4)
        Me.TB66_voi.Name = "TB66_voi"
        Me.TB66_voi.Size = New System.Drawing.Size(273, 43)
        Me.TB66_voi.TabIndex = 49
        Me.TB66_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB66_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB66_voi.WatermarkImage = Global.mdi.My.Resources.Resources.date_dachat
        Me.TB66_voi.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'pic_car2
        '
        Me.pic_car2.Image = Global.mdi.My.Resources.Resources.voiture_img
        Me.pic_car2.Location = New System.Drawing.Point(325, 400)
        Me.pic_car2.Name = "pic_car2"
        Me.pic_car2.Size = New System.Drawing.Size(94, 104)
        Me.pic_car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_car2.TabIndex = 45
        Me.pic_car2.TabStop = False
        '
        'pic_car1
        '
        Me.pic_car1.Image = Global.mdi.My.Resources.Resources.voiture_img
        Me.pic_car1.Location = New System.Drawing.Point(325, 96)
        Me.pic_car1.Name = "pic_car1"
        Me.pic_car1.Size = New System.Drawing.Size(202, 206)
        Me.pic_car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_car1.TabIndex = 0
        Me.pic_car1.TabStop = False
        '
        'TB3_voi
        '
        Me.TB3_voi.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB3_voi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_voi.Border.BorderBottomWidth = 2
        Me.TB3_voi.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB3_voi.Border.BorderGradientAngle = 0
        Me.TB3_voi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_voi.Border.BorderLeftWidth = 2
        Me.TB3_voi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_voi.Border.BorderRightWidth = 2
        Me.TB3_voi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_voi.Border.BorderTopWidth = 2
        Me.TB3_voi.Border.Class = "TextBoxBorder"
        Me.TB3_voi.Border.CornerDiameter = 10
        Me.TB3_voi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB3_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB3_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB3_voi.Location = New System.Drawing.Point(1, 248)
        Me.TB3_voi.Name = "TB3_voi"
        Me.TB3_voi.Size = New System.Drawing.Size(273, 43)
        Me.TB3_voi.TabIndex = 26
        Me.TB3_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB3_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB3_voi.WatermarkImage = Global.mdi.My.Resources.Resources.model
        Me.TB3_voi.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB3_voi.WatermarkText = " Modéle"
        '
        'TB7_voi
        '
        Me.TB7_voi.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB7_voi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_voi.Border.BorderBottomWidth = 2
        Me.TB7_voi.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB7_voi.Border.BorderGradientAngle = 0
        Me.TB7_voi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_voi.Border.BorderLeftWidth = 2
        Me.TB7_voi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_voi.Border.BorderRightWidth = 2
        Me.TB7_voi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_voi.Border.BorderTopWidth = 2
        Me.TB7_voi.Border.Class = "TextBoxBorder"
        Me.TB7_voi.Border.CornerDiameter = 10
        Me.TB7_voi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB7_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB7_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB7_voi.Location = New System.Drawing.Point(584, 309)
        Me.TB7_voi.Name = "TB7_voi"
        Me.TB7_voi.Size = New System.Drawing.Size(273, 43)
        Me.TB7_voi.TabIndex = 10
        Me.TB7_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB7_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB7_voi.WatermarkImage = Global.mdi.My.Resources.Resources.kilometrage
        Me.TB7_voi.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB7_voi.WatermarkText = " Kilométrage"
        '
        'TB5_voi
        '
        Me.TB5_voi.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB5_voi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_voi.Border.BorderBottomWidth = 2
        Me.TB5_voi.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB5_voi.Border.BorderGradientAngle = 0
        Me.TB5_voi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_voi.Border.BorderLeftWidth = 2
        Me.TB5_voi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_voi.Border.BorderRightWidth = 2
        Me.TB5_voi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_voi.Border.BorderTopWidth = 2
        Me.TB5_voi.Border.Class = "TextBoxBorder"
        Me.TB5_voi.Border.CornerDiameter = 10
        Me.TB5_voi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB5_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB5_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB5_voi.Location = New System.Drawing.Point(584, 187)
        Me.TB5_voi.Name = "TB5_voi"
        Me.TB5_voi.Size = New System.Drawing.Size(273, 43)
        Me.TB5_voi.TabIndex = 9
        Me.TB5_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB5_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB5_voi.WatermarkImage = Global.mdi.My.Resources.Resources.car_seat
        Me.TB5_voi.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB5_voi.WatermarkText = " Nombre de place"
        '
        'TB2_voi
        '
        Me.TB2_voi.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB2_voi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_voi.Border.BorderBottomWidth = 2
        Me.TB2_voi.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB2_voi.Border.BorderGradientAngle = 0
        Me.TB2_voi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_voi.Border.BorderLeftWidth = 2
        Me.TB2_voi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_voi.Border.BorderRightWidth = 2
        Me.TB2_voi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_voi.Border.BorderTopWidth = 2
        Me.TB2_voi.Border.Class = "TextBoxBorder"
        Me.TB2_voi.Border.CornerDiameter = 10
        Me.TB2_voi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB2_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB2_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB2_voi.Location = New System.Drawing.Point(1, 65)
        Me.TB2_voi.Name = "TB2_voi"
        Me.TB2_voi.Size = New System.Drawing.Size(273, 43)
        Me.TB2_voi.TabIndex = 3
        Me.TB2_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB2_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB2_voi.WatermarkImage = CType(resources.GetObject("TB2_voi.WatermarkImage"), System.Drawing.Image)
        Me.TB2_voi.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB2_voi.WatermarkText = " Matricule"
        '
        'TB1_voi
        '
        Me.TB1_voi.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB1_voi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_voi.Border.BorderBottomWidth = 2
        Me.TB1_voi.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB1_voi.Border.BorderGradientAngle = 0
        Me.TB1_voi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_voi.Border.BorderLeftWidth = 2
        Me.TB1_voi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_voi.Border.BorderRightWidth = 2
        Me.TB1_voi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_voi.Border.BorderTopWidth = 2
        Me.TB1_voi.Border.Class = "TextBoxBorder"
        Me.TB1_voi.Border.CornerDiameter = 10
        Me.TB1_voi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB1_voi.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB1_voi.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB1_voi.Location = New System.Drawing.Point(1, 4)
        Me.TB1_voi.Name = "TB1_voi"
        Me.TB1_voi.ReadOnly = True
        Me.TB1_voi.Size = New System.Drawing.Size(273, 43)
        Me.TB1_voi.TabIndex = 2
        Me.TB1_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB1_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB1_voi.WatermarkImage = CType(resources.GetObject("TB1_voi.WatermarkImage"), System.Drawing.Image)
        Me.TB1_voi.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB1_voi.WatermarkText = " ID"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.mdi.My.Resources.Resources.border_tb
        Me.PictureBox3.Location = New System.Drawing.Point(1, 126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(273, 43)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.mdi.My.Resources.Resources.border_tb
        Me.PictureBox4.Location = New System.Drawing.Point(1, 187)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(273, 43)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.mdi.My.Resources.Resources.border_tb
        Me.PictureBox5.Location = New System.Drawing.Point(1, 309)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(273, 43)
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.mdi.My.Resources.Resources.border_add_img3
        Me.PictureBox2.Location = New System.Drawing.Point(316, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(223, 286)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'voiture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1100, 640)
        Me.Controls.Add(Me.T_qr)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.pic_car2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GB_etat)
        Me.Controls.Add(Me.CB4_voi)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.TB6_voi)
        Me.Controls.Add(Me.TB4_voi)
        Me.Controls.Add(Me.TB66_voi)
        Me.Controls.Add(Me.pic_car1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CB1_voi)
        Me.Controls.Add(Me.CB3_voi)
        Me.Controls.Add(Me.CB2_voi)
        Me.Controls.Add(Me.TB3_voi)
        Me.Controls.Add(Me.Bt_Add_Pic)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.TB7_voi)
        Me.Controls.Add(Me.TB5_voi)
        Me.Controls.Add(Me.TB2_voi)
        Me.Controls.Add(Me.TB1_voi)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(247, 95)
        Me.Name = "voiture"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB4_voi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_etat.ResumeLayout(False)
        Me.GB_etat.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_car1 As System.Windows.Forms.PictureBox
    Friend WithEvents TB1_voi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB2_voi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB5_voi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB7_voi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Grid1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Bt_Add_Pic As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TB3_voi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CB1_voi As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CB2_voi As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CB3_voi As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BT_Fer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Raz As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Ajo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Rech_IB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Sup As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Mod As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_Rech_TB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_car2 As System.Windows.Forms.PictureBox
    Friend WithEvents TB66_voi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TB4_voi As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TB6_voi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CB4_voi As System.Windows.Forms.CheckedListBox
    Friend WithEvents PropertySettings1 As DevComponents.DotNetBar.PropertySettings
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents GB_etat As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents bd As System.Windows.Forms.RadioButton
    Friend WithEvents br As System.Windows.Forms.RadioButton
    Friend WithEvents ac As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents T_qr As System.Windows.Forms.TextBox
End Class
