<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.T_CODE = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.G_EMP = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.C_LOGIN = New System.Windows.Forms.ComboBox()
        Me.Pic_Progress = New System.Windows.Forms.PictureBox()
        CType(Me.G_EMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Progress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.mdi.My.Resources.Resources.login_button_1
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Location = New System.Drawing.Point(88, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'T_CODE
        '
        Me.T_CODE.BackColor = System.Drawing.Color.White
        Me.T_CODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T_CODE.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_CODE.ForeColor = System.Drawing.SystemColors.GrayText
        Me.T_CODE.Location = New System.Drawing.Point(89, 233)
        Me.T_CODE.Name = "T_CODE"
        Me.T_CODE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.T_CODE.Size = New System.Drawing.Size(201, 26)
        Me.T_CODE.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.mdi.My.Resources.Resources.close_kkkicon
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(156, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = False
        '
        'G_EMP
        '
        Me.G_EMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.G_EMP.Location = New System.Drawing.Point(12, 448)
        Me.G_EMP.Name = "G_EMP"
        Me.G_EMP.Size = New System.Drawing.Size(326, 107)
        Me.G_EMP.TabIndex = 5
        '
        'Timer1
        '
        '
        'C_LOGIN
        '
        Me.C_LOGIN.BackColor = System.Drawing.Color.White
        Me.C_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C_LOGIN.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.C_LOGIN.ForeColor = System.Drawing.SystemColors.GrayText
        Me.C_LOGIN.FormattingEnabled = True
        Me.C_LOGIN.Location = New System.Drawing.Point(88, 181)
        Me.C_LOGIN.Name = "C_LOGIN"
        Me.C_LOGIN.Size = New System.Drawing.Size(219, 34)
        Me.C_LOGIN.TabIndex = 1
        '
        'Pic_Progress
        '
        Me.Pic_Progress.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Progress.Image = Global.mdi.My.Resources.Resources.loading___1
        Me.Pic_Progress.Location = New System.Drawing.Point(151, 364)
        Me.Pic_Progress.Name = "Pic_Progress"
        Me.Pic_Progress.Size = New System.Drawing.Size(50, 50)
        Me.Pic_Progress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Progress.TabIndex = 9
        Me.Pic_Progress.TabStop = False
        Me.Pic_Progress.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.mdi.My.Resources.Resources.login_form_new_blanc_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(350, 517)
        Me.Controls.Add(Me.Pic_Progress)
        Me.Controls.Add(Me.C_LOGIN)
        Me.Controls.Add(Me.G_EMP)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.T_CODE)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.G_EMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents T_CODE As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents G_EMP As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents C_LOGIN As System.Windows.Forms.ComboBox
    Friend WithEvents Pic_Progress As System.Windows.Forms.PictureBox
End Class
