<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        txtpass = New TextBox()
        txtcity = New TextBox()
        txtuser = New TextBox()
        txtjob = New TextBox()
        txtname = New TextBox()
        txtaddrs = New TextBox()
        txtemail = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button6 = New Button()
        txtphone = New MaskedTextBox()
        PictureBox1 = New PictureBox()
        txtid = New MaskedTextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(533, 333)
        txtpass.Margin = New Padding(4, 5, 4, 5)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(239, 34)
        txtpass.TabIndex = 1
        ' 
        ' txtcity
        ' 
        txtcity.Location = New Point(137, 341)
        txtcity.Margin = New Padding(4, 5, 4, 5)
        txtcity.Name = "txtcity"
        txtcity.Size = New Size(252, 34)
        txtcity.TabIndex = 2
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(533, 255)
        txtuser.Margin = New Padding(4, 5, 4, 5)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(239, 34)
        txtuser.TabIndex = 3
        ' 
        ' txtjob
        ' 
        txtjob.Location = New Point(533, 179)
        txtjob.Margin = New Padding(4, 5, 4, 5)
        txtjob.Name = "txtjob"
        txtjob.Size = New Size(239, 34)
        txtjob.TabIndex = 4
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(137, 97)
        txtname.Margin = New Padding(4, 5, 4, 5)
        txtname.Name = "txtname"
        txtname.Size = New Size(635, 34)
        txtname.TabIndex = 6
        ' 
        ' txtaddrs
        ' 
        txtaddrs.Location = New Point(137, 255)
        txtaddrs.Margin = New Padding(4, 5, 4, 5)
        txtaddrs.Name = "txtaddrs"
        txtaddrs.Size = New Size(252, 34)
        txtaddrs.TabIndex = 7
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(137, 420)
        txtemail.Margin = New Padding(4, 5, 4, 5)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(642, 34)
        txtemail.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.MediumBlue
        Label1.Location = New Point(47, 26)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 28)
        Label1.TabIndex = 10
        Label1.Text = "ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.MediumBlue
        Label2.Location = New Point(46, 97)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 28)
        Label2.TabIndex = 11
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.MediumBlue
        Label3.Location = New Point(47, 182)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 28)
        Label3.TabIndex = 12
        Label3.Text = "Phone:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.MediumBlue
        Label4.Location = New Point(46, 420)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 28)
        Label4.TabIndex = 13
        Label4.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.MediumBlue
        Label5.Location = New Point(456, 179)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 28)
        Label5.TabIndex = 14
        Label5.Text = "Job:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.MediumBlue
        Label6.Location = New Point(46, 257)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 28)
        Label6.TabIndex = 15
        Label6.Text = "Address:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.MediumBlue
        Label7.Location = New Point(428, 257)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 28)
        Label7.TabIndex = 16
        Label7.Text = "Username:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.MediumBlue
        Label8.Location = New Point(47, 341)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 28)
        Label8.TabIndex = 17
        Label8.Text = "City:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.MediumBlue
        Label9.Location = New Point(430, 336)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(97, 28)
        Label9.TabIndex = 18
        Label9.Text = "Password:"
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.MediumBlue
        Button1.Location = New Point(166, 487)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 40)
        Button1.TabIndex = 20
        Button1.Text = "New"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.MediumBlue
        Button2.Location = New Point(331, 487)
        Button2.Margin = New Padding(4, 5, 4, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 40)
        Button2.TabIndex = 21
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.FlatAppearance.BorderSize = 2
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.MediumBlue
        Button6.Location = New Point(481, 487)
        Button6.Margin = New Padding(4, 5, 4, 5)
        Button6.Name = "Button6"
        Button6.Size = New Size(129, 40)
        Button6.TabIndex = 25
        Button6.Text = "Back"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' txtphone
        ' 
        txtphone.HidePromptOnLeave = True
        txtphone.Location = New Point(137, 184)
        txtphone.Mask = "00000000000"
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(252, 34)
        txtphone.TabIndex = 26
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(806, 107)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(360, 347)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' txtid
        ' 
        txtid.HidePromptOnLeave = True
        txtid.Location = New Point(137, 26)
        txtid.Mask = "00000000000"
        txtid.Name = "txtid"
        txtid.ReadOnly = True
        txtid.Size = New Size(252, 34)
        txtid.TabIndex = 28
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1202, 555)
        Controls.Add(txtid)
        Controls.Add(PictureBox1)
        Controls.Add(txtphone)
        Controls.Add(Button6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtemail)
        Controls.Add(txtaddrs)
        Controls.Add(txtname)
        Controls.Add(txtjob)
        Controls.Add(txtuser)
        Controls.Add(txtcity)
        Controls.Add(txtpass)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add New Client"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtcity As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtjob As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtaddrs As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtphone As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtid As MaskedTextBox
End Class
