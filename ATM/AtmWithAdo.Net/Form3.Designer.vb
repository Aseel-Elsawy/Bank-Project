<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        usertxt = New TextBox()
        passtxt = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.MediumBlue
        Button2.Location = New Point(290, 278)
        Button2.Margin = New Padding(8)
        Button2.Name = "Button2"
        Button2.Size = New Size(202, 45)
        Button2.TabIndex = 11
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.MediumBlue
        Button1.Location = New Point(64, 278)
        Button1.Margin = New Padding(8)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 45)
        Button1.TabIndex = 10
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.MediumBlue
        Label2.Location = New Point(29, 162)
        Label2.Margin = New Padding(8, 0, 8, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 31)
        Label2.TabIndex = 9
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.MediumBlue
        Label1.Location = New Point(29, 82)
        Label1.Margin = New Padding(8, 0, 8, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 31)
        Label1.TabIndex = 8
        Label1.Text = "Username:"
        ' 
        ' usertxt
        ' 
        usertxt.Location = New Point(196, 82)
        usertxt.Margin = New Padding(8)
        usertxt.Name = "usertxt"
        usertxt.Size = New Size(324, 38)
        usertxt.TabIndex = 7
        ' 
        ' passtxt
        ' 
        passtxt.Location = New Point(196, 165)
        passtxt.Margin = New Padding(8)
        passtxt.Name = "passtxt"
        passtxt.Size = New Size(324, 38)
        passtxt.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(542, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(354, 282)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(13F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(924, 348)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(usertxt)
        Controls.Add(passtxt)
        Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(5)
        MaximizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents usertxt As TextBox
    Friend WithEvents passtxt As TextBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
End Class
