<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        txtamount = New MaskedTextBox()
        Button5 = New Button()
        txtdate3 = New DateTimePicker()
        txtid = New TextBox()
        txtdetails = New TextBox()
        Button2 = New Button()
        Label8 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtamount
        ' 
        txtamount.HidePromptOnLeave = True
        txtamount.Location = New Point(175, 437)
        txtamount.Margin = New Padding(4)
        txtamount.Mask = "00000000"
        txtamount.Name = "txtamount"
        txtamount.Size = New Size(455, 34)
        txtamount.TabIndex = 31
        ' 
        ' Button5
        ' 
        Button5.FlatAppearance.BorderSize = 2
        Button5.FlatStyle = FlatStyle.Flat
        Button5.ForeColor = Color.MediumBlue
        Button5.Location = New Point(377, 553)
        Button5.Margin = New Padding(6)
        Button5.Name = "Button5"
        Button5.Size = New Size(217, 57)
        Button5.TabIndex = 29
        Button5.Text = "Cancel"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' txtdate3
        ' 
        txtdate3.Location = New Point(173, 154)
        txtdate3.Margin = New Padding(6)
        txtdate3.Name = "txtdate3"
        txtdate3.Size = New Size(456, 34)
        txtdate3.TabIndex = 30
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(173, 34)
        txtid.Margin = New Padding(6)
        txtid.Name = "txtid"
        txtid.ReadOnly = True
        txtid.Size = New Size(456, 34)
        txtid.TabIndex = 23
        ' 
        ' txtdetails
        ' 
        txtdetails.Location = New Point(173, 294)
        txtdetails.Margin = New Padding(6)
        txtdetails.Name = "txtdetails"
        txtdetails.Size = New Size(456, 34)
        txtdetails.TabIndex = 22
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.MediumBlue
        Button2.Location = New Point(103, 553)
        Button2.Margin = New Padding(6)
        Button2.Name = "Button2"
        Button2.Size = New Size(231, 57)
        Button2.TabIndex = 28
        Button2.Text = "Deposit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.MediumBlue
        Label8.Location = New Point(60, 34)
        Label8.Margin = New Padding(6, 0, 6, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 28)
        Label8.TabIndex = 27
        Label8.Text = "ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.MediumBlue
        Label5.Location = New Point(45, 445)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 28)
        Label5.TabIndex = 24
        Label5.Text = "Amount:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.MediumBlue
        Label6.Location = New Point(52, 294)
        Label6.Margin = New Padding(6, 0, 6, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 28)
        Label6.TabIndex = 25
        Label6.Text = "Details:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.MediumBlue
        Label7.Location = New Point(52, 154)
        Label7.Margin = New Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 28)
        Label7.TabIndex = 26
        Label7.Text = "Date:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(652, 142)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(496, 331)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1160, 639)
        Controls.Add(PictureBox1)
        Controls.Add(txtamount)
        Controls.Add(Button5)
        Controls.Add(txtdate3)
        Controls.Add(txtid)
        Controls.Add(txtdetails)
        Controls.Add(Button2)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Deposits"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtamount As MaskedTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtdate3 As DateTimePicker
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtdetails As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
