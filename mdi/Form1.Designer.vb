<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_Exit = New DevComponents.DotNetBar.ButtonX()
        Me.BT_About = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Acc = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Cli = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Empr = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Emp = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BT_Voi = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clock = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BT_Login = New DevComponents.DotNetBar.ButtonX()
        Me.BT_Logout = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BT_Exit)
        Me.Panel1.Controls.Add(Me.BT_About)
        Me.Panel1.Controls.Add(Me.BT_Acc)
        Me.Panel1.Controls.Add(Me.BT_Cli)
        Me.Panel1.Controls.Add(Me.BT_Empr)
        Me.Panel1.Controls.Add(Me.BT_Emp)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BT_Voi)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 696)
        Me.Panel1.TabIndex = 0
        '
        'BT_Exit
        '
        Me.BT_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Exit.FocusCuesEnabled = False
        Me.BT_Exit.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BT_Exit.Image = Global.mdi.My.Resources.Resources.inside_logout_icon
        Me.BT_Exit.ImageTextSpacing = 5
        Me.BT_Exit.Location = New System.Drawing.Point(0, 570)
        Me.BT_Exit.Name = "BT_Exit"
        Me.BT_Exit.Size = New System.Drawing.Size(200, 54)
        Me.BT_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Exit.TabIndex = 7
        Me.BT_Exit.Text = "  Quitter"
        Me.BT_Exit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Exit.TextColor = System.Drawing.Color.White
        '
        'BT_About
        '
        Me.BT_About.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_About.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_About.FocusCuesEnabled = False
        Me.BT_About.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BT_About.Image = Global.mdi.My.Resources.Resources.info_icon
        Me.BT_About.ImageTextSpacing = 5
        Me.BT_About.Location = New System.Drawing.Point(-1, 499)
        Me.BT_About.Name = "BT_About"
        Me.BT_About.Size = New System.Drawing.Size(200, 54)
        Me.BT_About.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_About.TabIndex = 6
        Me.BT_About.Text = "  A Propos"
        Me.BT_About.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_About.TextColor = System.Drawing.Color.White
        '
        'BT_Acc
        '
        Me.BT_Acc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Acc.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Acc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Acc.FocusCuesEnabled = False
        Me.BT_Acc.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Acc.Image = Global.mdi.My.Resources.Resources._7HXDQx7x
        Me.BT_Acc.ImageTextSpacing = 5
        Me.BT_Acc.Location = New System.Drawing.Point(0, 143)
        Me.BT_Acc.Name = "BT_Acc"
        Me.BT_Acc.Size = New System.Drawing.Size(200, 54)
        Me.BT_Acc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Acc.TabIndex = 1
        Me.BT_Acc.Text = "  Accueil"
        Me.BT_Acc.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Acc.TextColor = System.Drawing.Color.White
        '
        'BT_Cli
        '
        Me.BT_Cli.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Cli.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Cli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Cli.FocusCuesEnabled = False
        Me.BT_Cli.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BT_Cli.Image = Global.mdi.My.Resources.Resources._20150831_55e46b1f4a412
        Me.BT_Cli.ImageTextSpacing = 5
        Me.BT_Cli.Location = New System.Drawing.Point(0, 215)
        Me.BT_Cli.Name = "BT_Cli"
        Me.BT_Cli.Size = New System.Drawing.Size(200, 54)
        Me.BT_Cli.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Cli.TabIndex = 2
        Me.BT_Cli.Text = "  Client"
        Me.BT_Cli.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Cli.TextColor = System.Drawing.Color.White
        '
        'BT_Empr
        '
        Me.BT_Empr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Empr.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Empr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Empr.FocusCuesEnabled = False
        Me.BT_Empr.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BT_Empr.Image = Global.mdi.My.Resources.Resources.lend_icon
        Me.BT_Empr.ImageTextSpacing = 5
        Me.BT_Empr.Location = New System.Drawing.Point(-1, 428)
        Me.BT_Empr.Name = "BT_Empr"
        Me.BT_Empr.Size = New System.Drawing.Size(200, 54)
        Me.BT_Empr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Empr.TabIndex = 5
        Me.BT_Empr.Text = "  Emprunt"
        Me.BT_Empr.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Empr.TextColor = System.Drawing.Color.White
        '
        'BT_Emp
        '
        Me.BT_Emp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Emp.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Emp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Emp.FocusCuesEnabled = False
        Me.BT_Emp.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BT_Emp.Image = Global.mdi.My.Resources.Resources._20161014_58006bff8b1de
        Me.BT_Emp.ImageTextSpacing = 5
        Me.BT_Emp.Location = New System.Drawing.Point(0, 286)
        Me.BT_Emp.Name = "BT_Emp"
        Me.BT_Emp.Size = New System.Drawing.Size(200, 54)
        Me.BT_Emp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Emp.TabIndex = 3
        Me.BT_Emp.Text = "  Employer"
        Me.BT_Emp.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Emp.TextColor = System.Drawing.Color.White
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.mdi.My.Resources.Resources.topnav_menu_icon1
        Me.PictureBox1.Location = New System.Drawing.Point(77, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BT_Voi
        '
        Me.BT_Voi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Voi.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BT_Voi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Voi.FocusCuesEnabled = False
        Me.BT_Voi.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BT_Voi.Image = Global.mdi.My.Resources.Resources.car_flat_car_icon_car_png_web_icon_png
        Me.BT_Voi.ImageTextSpacing = 5
        Me.BT_Voi.Location = New System.Drawing.Point(0, 357)
        Me.BT_Voi.Name = "BT_Voi"
        Me.BT_Voi.Size = New System.Drawing.Size(200, 54)
        Me.BT_Voi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Voi.TabIndex = 4
        Me.BT_Voi.Text = "  Voiture"
        Me.BT_Voi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Voi.TextColor = System.Drawing.Color.White
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.mdi.My.Resources.Resources.topnav_menu_icon1
        Me.PictureBox3.Location = New System.Drawing.Point(7, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.clock)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 52)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1310, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'clock
        '
        Me.clock.AutoSize = True
        Me.clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clock.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.clock.Location = New System.Drawing.Point(605, 8)
        Me.clock.Name = "clock"
        Me.clock.Size = New System.Drawing.Size(111, 37)
        Me.clock.TabIndex = 2
        Me.clock.Text = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.mdi.My.Resources.Resources.clock_effect1
        Me.PictureBox2.Location = New System.Drawing.Point(477, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(400, 45)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.mdi.My.Resources.Resources.hhf
        Me.PictureBox5.Location = New System.Drawing.Point(394, 169)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(629, 567)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.mdi.My.Resources.Resources.welcome
        Me.PictureBox4.Location = New System.Drawing.Point(452, 93)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(515, 45)
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'BT_Login
        '
        Me.BT_Login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Login.FocusCuesEnabled = False
        Me.BT_Login.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BT_Login.Image = Global.mdi.My.Resources.Resources.logout_button_small
        Me.BT_Login.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BT_Login.ImageTextSpacing = 5
        Me.BT_Login.Location = New System.Drawing.Point(1170, 645)
        Me.BT_Login.Name = "BT_Login"
        Me.BT_Login.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(30, 10, 30, 10)
        Me.BT_Login.Size = New System.Drawing.Size(168, 66)
        Me.BT_Login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Login.TabIndex = 9
        Me.BT_Login.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Login.TextColor = System.Drawing.Color.White
        '
        'BT_Logout
        '
        Me.BT_Logout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BT_Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_Logout.FocusCuesEnabled = False
        Me.BT_Logout.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BT_Logout.Image = Global.mdi.My.Resources.Resources.login_button_small
        Me.BT_Logout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BT_Logout.ImageTextSpacing = 5
        Me.BT_Logout.Location = New System.Drawing.Point(1170, 645)
        Me.BT_Logout.Name = "BT_Logout"
        Me.BT_Logout.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(30, 10, 30, 10)
        Me.BT_Logout.Size = New System.Drawing.Size(168, 66)
        Me.BT_Logout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BT_Logout.TabIndex = 9
        Me.BT_Logout.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        Me.BT_Logout.TextColor = System.Drawing.Color.White
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1370, 748)
        Me.Controls.Add(Me.BT_Login)
        Me.Controls.Add(Me.BT_Logout)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_Voi As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_Acc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Cli As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Empr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Emp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_About As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Exit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents clock As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_Login As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BT_Logout As DevComponents.DotNetBar.ButtonX


End Class
