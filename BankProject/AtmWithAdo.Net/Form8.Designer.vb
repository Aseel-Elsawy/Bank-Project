<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.MediumBlue
        Button1.Location = New Point(41, 94)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 51)
        Button1.TabIndex = 7
        Button1.Text = "deposits"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.MediumBlue
        Button2.Location = New Point(287, 94)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 51)
        Button2.TabIndex = 8
        Button2.Text = "Withdrawals"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.FlatAppearance.BorderSize = 2
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.MediumBlue
        Button3.Location = New Point(551, 94)
        Button3.Name = "Button3"
        Button3.Size = New Size(133, 51)
        Button3.TabIndex = 9
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(13F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(745, 212)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(5)
        MaximizeBox = False
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Choose Your Action"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
