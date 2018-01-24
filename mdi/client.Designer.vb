<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(client))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Bt_plus = New System.Windows.Forms.Button()
        Me.BT_Fer = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Raz = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Ajo = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Rech_IB = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Sup = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Mod = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.BT_Rech_TB = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Bt_Add_Pic = New System.Windows.Forms.Button()
        Me.Bt_less = New System.Windows.Forms.Button()
        Me.CB1_cli = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Grid1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TB9_cli = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.G1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cbd = New System.Windows.Forms.RadioButton()
        Me.cbr = New System.Windows.Forms.RadioButton()
        Me.ca = New System.Windows.Forms.RadioButton()
        Me.T_qr = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Qr1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.pic_client = New System.Windows.Forms.PictureBox()
        Me.TB66_voi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB8_cli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB4_cli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB3_cli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB6_cli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB5_cli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB7_cli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB2_cli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TB1_cli = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TB9_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.G1.SuspendLayout()
        CType(Me.Qr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_client, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.mdi.My.Resources.Resources.qr_code1
        Me.ButtonX1.ImageTextSpacing = 5
        Me.ButtonX1.Location = New System.Drawing.Point(316, 365)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20)
        Me.ButtonX1.Size = New System.Drawing.Size(223, 54)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 12
        Me.ButtonX1.Text = "  Créer Un Qr Code"
        Me.ButtonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.ButtonX1.TextColor = System.Drawing.Color.Gray
        Me.ToolTip1.SetToolTip(Me.ButtonX1, "Créer Un Qr Code")
        '
        'Bt_plus
        '
        Me.Bt_plus.BackColor = System.Drawing.Color.Transparent
        Me.Bt_plus.BackgroundImage = Global.mdi.My.Resources.Resources.plus
        Me.Bt_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Bt_plus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_plus.FlatAppearance.BorderSize = 0
        Me.Bt_plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Bt_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Bt_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_plus.Location = New System.Drawing.Point(814, 387)
        Me.Bt_plus.Name = "Bt_plus"
        Me.Bt_plus.Size = New System.Drawing.Size(32, 32)
        Me.Bt_plus.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Bt_plus, "Ajouter des Images")
        Me.Bt_plus.UseVisualStyleBackColor = False
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
        Me.BT_Fer.TabIndex = 20
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
        Me.BT_Raz.TabIndex = 19
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
        Me.BT_Ajo.TabIndex = 14
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
        Me.BT_Rech_IB.TabIndex = 16
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
        Me.BT_Sup.TabIndex = 18
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
        Me.BT_Mod.TabIndex = 17
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
        Me.BT_Rech_TB.TabIndex = 15
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
        Me.Bt_Add_Pic.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.Bt_Add_Pic, "Ajouter des Images")
        Me.Bt_Add_Pic.UseVisualStyleBackColor = False
        '
        'Bt_less
        '
        Me.Bt_less.BackColor = System.Drawing.Color.Transparent
        Me.Bt_less.BackgroundImage = Global.mdi.My.Resources.Resources.less
        Me.Bt_less.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Bt_less.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_less.FlatAppearance.BorderSize = 0
        Me.Bt_less.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Bt_less.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Bt_less.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_less.Location = New System.Drawing.Point(814, 387)
        Me.Bt_less.Name = "Bt_less"
        Me.Bt_less.Size = New System.Drawing.Size(32, 32)
        Me.Bt_less.TabIndex = 99
        Me.ToolTip1.SetToolTip(Me.Bt_less, "Ajouter des Images")
        Me.Bt_less.UseVisualStyleBackColor = False
        '
        'CB1_cli
        '
        Me.CB1_cli.DisabledBackColor = System.Drawing.SystemColors.WindowFrame
        Me.CB1_cli.DisabledForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CB1_cli.DisplayMember = "Text"
        Me.CB1_cli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB1_cli.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.CB1_cli.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CB1_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.CB1_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CB1_cli.FormattingEnabled = True
        Me.CB1_cli.IntegralHeight = False
        Me.CB1_cli.ItemHeight = 27
        Me.CB1_cli.Location = New System.Drawing.Point(7, 315)
        Me.CB1_cli.MaxDropDownItems = 9
        Me.CB1_cli.Name = "CB1_cli"
        Me.CB1_cli.Size = New System.Drawing.Size(259, 33)
        Me.CB1_cli.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB1_cli.TabIndex = 6
        Me.CB1_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.CB1_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.CB1_cli.WatermarkText = " Ville"
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
        Me.Grid1.TabIndex = 62
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.Panel1.TabIndex = 92
        '
        'TB9_cli
        '
        '
        '
        '
        Me.TB9_cli.BackgroundStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TB9_cli.BackgroundStyle.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.TB9_cli.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TB9_cli.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TB9_cli.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.TB9_cli.ButtonDropDown.Visible = True
        Me.TB9_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB9_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB9_cli.IsPopupCalendarOpen = False
        Me.TB9_cli.Location = New System.Drawing.Point(590, 192)
        '
        '
        '
        Me.TB9_cli.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TB9_cli.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TB9_cli.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.TB9_cli.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.TB9_cli.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.TB9_cli.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.TB9_cli.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.TB9_cli.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB9_cli.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.TB9_cli.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.TB9_cli.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TB9_cli.MonthCalendar.DisplayMonth = New Date(2017, 4, 1, 0, 0, 0, 0)
        Me.TB9_cli.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.TB9_cli.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.TB9_cli.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.TB9_cli.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.TB9_cli.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.TB9_cli.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.TB9_cli.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TB9_cli.MonthCalendar.TodayButtonVisible = True
        Me.TB9_cli.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.TB9_cli.Name = "TB9_cli"
        Me.TB9_cli.Size = New System.Drawing.Size(224, 33)
        Me.TB9_cli.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TB9_cli.TabIndex = 10
        Me.TB9_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB9_cli.WatermarkText = " Date prendre permis"
        '
        'G1
        '
        Me.G1.CanvasColor = System.Drawing.SystemColors.Control
        Me.G1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.G1.Controls.Add(Me.cbd)
        Me.G1.Controls.Add(Me.cbr)
        Me.G1.Controls.Add(Me.ca)
        Me.G1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.G1.Location = New System.Drawing.Point(584, 248)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(273, 105)
        '
        '
        '
        Me.G1.Style.BackColor = System.Drawing.Color.WhiteSmoke
        Me.G1.Style.BackColorGradientAngle = 90
        Me.G1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.G1.Style.BorderBottomWidth = 2
        Me.G1.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.G1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.G1.Style.BorderLeftWidth = 2
        Me.G1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.G1.Style.BorderRightWidth = 2
        Me.G1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.G1.Style.BorderTopWidth = 2
        Me.G1.Style.CornerDiameter = 10
        Me.G1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.G1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.G1.Style.TextColor = System.Drawing.SystemColors.GrayText
        '
        '
        '
        Me.G1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.G1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.G1.TabIndex = 11
        Me.G1.Text = "Etat"
        '
        'cbd
        '
        Me.cbd.AutoSize = True
        Me.cbd.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbd.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbd.Location = New System.Drawing.Point(13, 40)
        Me.cbd.Name = "cbd"
        Me.cbd.Size = New System.Drawing.Size(175, 23)
        Me.cbd.TabIndex = 2
        Me.cbd.TabStop = True
        Me.cbd.Text = "Bloque Définitivement"
        Me.cbd.UseVisualStyleBackColor = True
        '
        'cbr
        '
        Me.cbr.AutoSize = True
        Me.cbr.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbr.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbr.Location = New System.Drawing.Point(13, 18)
        Me.cbr.Name = "cbr"
        Me.cbr.Size = New System.Drawing.Size(154, 23)
        Me.cbr.TabIndex = 1
        Me.cbr.TabStop = True
        Me.cbr.Text = "Bloque Reservation"
        Me.cbr.UseVisualStyleBackColor = True
        '
        'ca
        '
        Me.ca.AutoSize = True
        Me.ca.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ca.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ca.Location = New System.Drawing.Point(13, -4)
        Me.ca.Name = "ca"
        Me.ca.Size = New System.Drawing.Size(58, 23)
        Me.ca.TabIndex = 0
        Me.ca.TabStop = True
        Me.ca.Text = "Actif"
        Me.ca.UseVisualStyleBackColor = True
        '
        'T_qr
        '
        Me.T_qr.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.T_qr.Border.BorderBottomWidth = 2
        Me.T_qr.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.T_qr.Border.BorderLeftWidth = 2
        Me.T_qr.Border.BorderRightWidth = 2
        Me.T_qr.Border.BorderTopWidth = 2
        Me.T_qr.Border.Class = "TextBoxBorder"
        Me.T_qr.Border.CornerDiameter = 10
        Me.T_qr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.T_qr.ForeColor = System.Drawing.Color.DimGray
        Me.T_qr.Location = New System.Drawing.Point(318, 426)
        Me.T_qr.Name = "T_qr"
        Me.T_qr.Size = New System.Drawing.Size(221, 30)
        Me.T_qr.TabIndex = 104
        Me.T_qr.WatermarkText = "  Path Image Qr Code"
        '
        'Qr1
        '
        Me.Qr1.BackColor = System.Drawing.Color.White
        Me.Qr1.BackgroundImage = Global.mdi.My.Resources.Resources.qr_code_variant1
        Me.Qr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Qr1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.Qr1.Image = CType(resources.GetObject("Qr1.Image"), System.Drawing.Image)
        Me.Qr1.Location = New System.Drawing.Point(361, 476)
        Me.Qr1.Name = "Qr1"
        Me.Qr1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.Qr1.Size = New System.Drawing.Size(136, 136)
        Me.Qr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Qr1.TabIndex = 105
        Me.Qr1.TabStop = False
        Me.Qr1.Text = "Qr1"
        '
        'pic_client
        '
        Me.pic_client.BackgroundImage = Global.mdi.My.Resources.Resources.client_img
        Me.pic_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_client.Image = Global.mdi.My.Resources.Resources.client_img
        Me.pic_client.Location = New System.Drawing.Point(330, 95)
        Me.pic_client.Name = "pic_client"
        Me.pic_client.Size = New System.Drawing.Size(200, 200)
        Me.pic_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_client.TabIndex = 78
        Me.pic_client.TabStop = False
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
        Me.TB66_voi.Location = New System.Drawing.Point(584, 187)
        Me.TB66_voi.Name = "TB66_voi"
        Me.TB66_voi.Size = New System.Drawing.Size(273, 43)
        Me.TB66_voi.TabIndex = 93
        Me.TB66_voi.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB66_voi.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB66_voi.WatermarkImage = Global.mdi.My.Resources.Resources.date_dachat
        Me.TB66_voi.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'TB8_cli
        '
        Me.TB8_cli.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB8_cli.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB8_cli.Border.BorderBottomWidth = 2
        Me.TB8_cli.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB8_cli.Border.BorderGradientAngle = 0
        Me.TB8_cli.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB8_cli.Border.BorderLeftWidth = 2
        Me.TB8_cli.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB8_cli.Border.BorderRightWidth = 2
        Me.TB8_cli.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB8_cli.Border.BorderTopWidth = 2
        Me.TB8_cli.Border.Class = "TextBoxBorder"
        Me.TB8_cli.Border.CornerDiameter = 10
        Me.TB8_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB8_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB8_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB8_cli.Location = New System.Drawing.Point(584, 126)
        Me.TB8_cli.Name = "TB8_cli"
        Me.TB8_cli.Size = New System.Drawing.Size(273, 43)
        Me.TB8_cli.TabIndex = 9
        Me.TB8_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB8_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB8_cli.WatermarkImage = Global.mdi.My.Resources.Resources.driver_license
        Me.TB8_cli.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB8_cli.WatermarkText = " Numéro de permis"
        '
        'TB4_cli
        '
        Me.TB4_cli.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB4_cli.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_cli.Border.BorderBottomWidth = 2
        Me.TB4_cli.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB4_cli.Border.BorderGradientAngle = 0
        Me.TB4_cli.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_cli.Border.BorderLeftWidth = 2
        Me.TB4_cli.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_cli.Border.BorderRightWidth = 2
        Me.TB4_cli.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB4_cli.Border.BorderTopWidth = 2
        Me.TB4_cli.Border.Class = "TextBoxBorder"
        Me.TB4_cli.Border.CornerDiameter = 10
        Me.TB4_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB4_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB4_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB4_cli.Location = New System.Drawing.Point(1, 187)
        Me.TB4_cli.Name = "TB4_cli"
        Me.TB4_cli.Size = New System.Drawing.Size(273, 43)
        Me.TB4_cli.TabIndex = 4
        Me.TB4_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB4_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB4_cli.WatermarkImage = Global.mdi.My.Resources.Resources.user_name
        Me.TB4_cli.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB4_cli.WatermarkText = " Prénom"
        '
        'TB3_cli
        '
        Me.TB3_cli.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB3_cli.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_cli.Border.BorderBottomWidth = 2
        Me.TB3_cli.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB3_cli.Border.BorderGradientAngle = 0
        Me.TB3_cli.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_cli.Border.BorderLeftWidth = 2
        Me.TB3_cli.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_cli.Border.BorderRightWidth = 2
        Me.TB3_cli.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB3_cli.Border.BorderTopWidth = 2
        Me.TB3_cli.Border.Class = "TextBoxBorder"
        Me.TB3_cli.Border.CornerDiameter = 10
        Me.TB3_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB3_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB3_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB3_cli.Location = New System.Drawing.Point(1, 126)
        Me.TB3_cli.Name = "TB3_cli"
        Me.TB3_cli.Size = New System.Drawing.Size(273, 43)
        Me.TB3_cli.TabIndex = 3
        Me.TB3_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB3_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB3_cli.WatermarkImage = Global.mdi.My.Resources.Resources.user_name
        Me.TB3_cli.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB3_cli.WatermarkText = " Nom"
        '
        'TB6_cli
        '
        Me.TB6_cli.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB6_cli.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_cli.Border.BorderBottomWidth = 2
        Me.TB6_cli.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB6_cli.Border.BorderGradientAngle = 0
        Me.TB6_cli.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_cli.Border.BorderLeftWidth = 2
        Me.TB6_cli.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_cli.Border.BorderRightWidth = 2
        Me.TB6_cli.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB6_cli.Border.BorderTopWidth = 2
        Me.TB6_cli.Border.Class = "TextBoxBorder"
        Me.TB6_cli.Border.CornerDiameter = 10
        Me.TB6_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB6_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB6_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB6_cli.Location = New System.Drawing.Point(584, 4)
        Me.TB6_cli.Name = "TB6_cli"
        Me.TB6_cli.Size = New System.Drawing.Size(273, 43)
        Me.TB6_cli.TabIndex = 7
        Me.TB6_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB6_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB6_cli.WatermarkImage = Global.mdi.My.Resources.Resources.telephone_of_old_design
        Me.TB6_cli.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB6_cli.WatermarkText = " Téléphone"
        '
        'TB5_cli
        '
        Me.TB5_cli.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB5_cli.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_cli.Border.BorderBottomWidth = 2
        Me.TB5_cli.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB5_cli.Border.BorderGradientAngle = 0
        Me.TB5_cli.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_cli.Border.BorderLeftWidth = 2
        Me.TB5_cli.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_cli.Border.BorderRightWidth = 2
        Me.TB5_cli.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB5_cli.Border.BorderTopWidth = 2
        Me.TB5_cli.Border.Class = "TextBoxBorder"
        Me.TB5_cli.Border.CornerDiameter = 10
        Me.TB5_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB5_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB5_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB5_cli.Location = New System.Drawing.Point(1, 248)
        Me.TB5_cli.Name = "TB5_cli"
        Me.TB5_cli.Size = New System.Drawing.Size(273, 43)
        Me.TB5_cli.TabIndex = 5
        Me.TB5_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB5_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB5_cli.WatermarkImage = Global.mdi.My.Resources.Resources.address
        Me.TB5_cli.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB5_cli.WatermarkText = " Adresse"
        '
        'TB7_cli
        '
        Me.TB7_cli.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB7_cli.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_cli.Border.BorderBottomWidth = 2
        Me.TB7_cli.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB7_cli.Border.BorderGradientAngle = 0
        Me.TB7_cli.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_cli.Border.BorderLeftWidth = 2
        Me.TB7_cli.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_cli.Border.BorderRightWidth = 2
        Me.TB7_cli.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB7_cli.Border.BorderTopWidth = 2
        Me.TB7_cli.Border.Class = "TextBoxBorder"
        Me.TB7_cli.Border.CornerDiameter = 10
        Me.TB7_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB7_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB7_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB7_cli.Location = New System.Drawing.Point(584, 65)
        Me.TB7_cli.Name = "TB7_cli"
        Me.TB7_cli.Size = New System.Drawing.Size(273, 43)
        Me.TB7_cli.TabIndex = 8
        Me.TB7_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB7_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB7_cli.WatermarkImage = Global.mdi.My.Resources.Resources.email_envelope
        Me.TB7_cli.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB7_cli.WatermarkText = " E-mail"
        '
        'TB2_cli
        '
        Me.TB2_cli.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB2_cli.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_cli.Border.BorderBottomWidth = 2
        Me.TB2_cli.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB2_cli.Border.BorderGradientAngle = 0
        Me.TB2_cli.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_cli.Border.BorderLeftWidth = 2
        Me.TB2_cli.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_cli.Border.BorderRightWidth = 2
        Me.TB2_cli.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB2_cli.Border.BorderTopWidth = 2
        Me.TB2_cli.Border.Class = "TextBoxBorder"
        Me.TB2_cli.Border.CornerDiameter = 10
        Me.TB2_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB2_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB2_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB2_cli.Location = New System.Drawing.Point(1, 65)
        Me.TB2_cli.Name = "TB2_cli"
        Me.TB2_cli.Size = New System.Drawing.Size(273, 43)
        Me.TB2_cli.TabIndex = 2
        Me.TB2_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB2_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB2_cli.WatermarkImage = Global.mdi.My.Resources.Resources.id_card1
        Me.TB2_cli.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB2_cli.WatermarkText = " CIN"
        '
        'TB1_cli
        '
        Me.TB1_cli.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.TB1_cli.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_cli.Border.BorderBottomWidth = 2
        Me.TB1_cli.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TB1_cli.Border.BorderGradientAngle = 0
        Me.TB1_cli.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_cli.Border.BorderLeftWidth = 2
        Me.TB1_cli.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_cli.Border.BorderRightWidth = 2
        Me.TB1_cli.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.TB1_cli.Border.BorderTopWidth = 2
        Me.TB1_cli.Border.Class = "TextBoxBorder"
        Me.TB1_cli.Border.CornerDiameter = 10
        Me.TB1_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.TB1_cli.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.TB1_cli.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TB1_cli.Location = New System.Drawing.Point(1, 4)
        Me.TB1_cli.Name = "TB1_cli"
        Me.TB1_cli.Size = New System.Drawing.Size(273, 43)
        Me.TB1_cli.TabIndex = 1
        Me.TB1_cli.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.TB1_cli.WatermarkColor = System.Drawing.Color.DarkGray
        Me.TB1_cli.WatermarkImage = CType(resources.GetObject("TB1_cli.WatermarkImage"), System.Drawing.Image)
        Me.TB1_cli.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TB1_cli.WatermarkText = " ID"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.mdi.My.Resources.Resources.border_tb
        Me.PictureBox5.Location = New System.Drawing.Point(1, 310)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(273, 43)
        Me.PictureBox5.TabIndex = 74
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.mdi.My.Resources.Resources.border_add_img3
        Me.PictureBox2.Location = New System.Drawing.Point(318, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(223, 286)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mdi.My.Resources.Resources.border_qr1
        Me.PictureBox1.Location = New System.Drawing.Point(354, 461)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 164)
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1100, 640)
        Me.Controls.Add(Me.Qr1)
        Me.Controls.Add(Me.T_qr)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.Bt_plus)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.pic_client)
        Me.Controls.Add(Me.TB9_cli)
        Me.Controls.Add(Me.TB66_voi)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TB8_cli)
        Me.Controls.Add(Me.TB4_cli)
        Me.Controls.Add(Me.TB3_cli)
        Me.Controls.Add(Me.TB6_cli)
        Me.Controls.Add(Me.CB1_cli)
        Me.Controls.Add(Me.TB5_cli)
        Me.Controls.Add(Me.Bt_Add_Pic)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.TB7_cli)
        Me.Controls.Add(Me.TB2_cli)
        Me.Controls.Add(Me.TB1_cli)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Bt_less)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(247, 95)
        Me.Name = "client"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TB9_cli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.G1.ResumeLayout(False)
        Me.G1.PerformLayout()
        CType(Me.Qr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_client, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TB6_cli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Bt_Add_Pic As System.Windows.Forms.Button
    Friend WithEvents CB1_cli As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TB5_cli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Grid1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TB7_cli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB2_cli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB1_cli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TB3_cli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB4_cli As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TB8_cli As DevComponents.DotNetBar.Controls.TextBoxX
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
    Friend WithEvents TB9_cli As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents TB66_voi As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents pic_client As System.Windows.Forms.PictureBox
    Friend WithEvents G1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cbd As System.Windows.Forms.RadioButton
    Friend WithEvents cbr As System.Windows.Forms.RadioButton
    Friend WithEvents ca As System.Windows.Forms.RadioButton
    Friend WithEvents Bt_plus As System.Windows.Forms.Button
    Friend WithEvents Bt_less As System.Windows.Forms.Button
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents T_qr As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Qr1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
End Class
