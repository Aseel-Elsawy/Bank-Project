<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form11))
        txtamount1 = New MaskedTextBox()
        txtdate2 = New DateTimePicker()
        Button4 = New Button()
        Button3 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        ID = New Label()
        txtdate1 = New Label()
        txtdetails1 = New TextBox()
        txtid1 = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtamount1
        ' 
        txtamount1.HidePromptOnLeave = True
        txtamount1.Location = New Point(186, 399)
        txtamount1.Margin = New Padding(4)
        txtamount1.Mask = "000000000"
        txtamount1.Name = "txtamount1"
        txtamount1.Size = New Size(452, 34)
        txtamount1.TabIndex = 32
        ' 
        ' txtdate2
        ' 
        txtdate2.Location = New Point(186, 161)
        txtdate2.Margin = New Padding(4)
        txtdate2.Name = "txtdate2"
        txtdate2.Size = New Size(455, 34)
        txtdate2.TabIndex = 31
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 2
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.MediumBlue
        Button4.Location = New Point(512, 522)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(126, 43)
        Button4.TabIndex = 30
        Button4.Text = "Cancel"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.MediumBlue
        Button3.Location = New Point(340, 522)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(164, 43)
        Button3.TabIndex = 29
        Button3.Text = "Withdraw"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.MediumBlue
        Label4.Location = New Point(41, 274)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 28)
        Label4.TabIndex = 28
        Label4.Text = "Details:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.MediumBlue
        Label3.Location = New Point(41, 399)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 28)
        Label3.TabIndex = 27
        Label3.Text = "Amount:"
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.ForeColor = Color.MediumBlue
        ID.Location = New Point(54, 56)
        ID.Margin = New Padding(4, 0, 4, 0)
        ID.Name = "ID"
        ID.Size = New Size(31, 28)
        ID.TabIndex = 26
        ID.Text = "ID"
        ' 
        ' txtdate1
        ' 
        txtdate1.AutoSize = True
        txtdate1.ForeColor = Color.MediumBlue
        txtdate1.Location = New Point(44, 161)
        txtdate1.Margin = New Padding(4, 0, 4, 0)
        txtdate1.Name = "txtdate1"
        txtdate1.Size = New Size(57, 28)
        txtdate1.TabIndex = 25
        txtdate1.Text = "Date:"
        ' 
        ' txtdetails1
        ' 
        txtdetails1.Location = New Point(186, 274)
        txtdetails1.Margin = New Padding(4)
        txtdetails1.Name = "txtdetails1"
        txtdetails1.Size = New Size(452, 34)
        txtdetails1.TabIndex = 24
        ' 
        ' txtid1
        ' 
        txtid1.Location = New Point(186, 52)
        txtid1.Margin = New Padding(4)
        txtid1.Name = "txtid1"
        txtid1.ReadOnly = True
        txtid1.Size = New Size(455, 34)
        txtid1.TabIndex = 23
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(771, 78)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(355, 434)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1178, 605)
        Controls.Add(PictureBox1)
        Controls.Add(txtamount1)
        Controls.Add(txtdate2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ID)
        Controls.Add(txtdate1)
        Controls.Add(txtdetails1)
        Controls.Add(txtid1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "Form11"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Withdrawals"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtamount1 As MaskedTextBox
    Friend WithEvents txtdate2 As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ID As Label
    Friend WithEvents txtdate1 As Label
    Friend WithEvents txtdetails1 As TextBox
    Friend WithEvents txtid1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
