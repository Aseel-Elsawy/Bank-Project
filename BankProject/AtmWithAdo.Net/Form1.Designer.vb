<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.FlatAppearance.BorderSize = 3
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.MediumBlue
        Button3.Location = New Point(486, 81)
        Button3.Margin = New Padding(5)
        Button3.Name = "Button3"
        Button3.Size = New Size(153, 45)
        Button3.TabIndex = 5
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatAppearance.BorderSize = 3
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.MediumBlue
        Button2.Location = New Point(289, 81)
        Button2.Margin = New Padding(5)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 45)
        Button2.TabIndex = 4
        Button2.Text = "Client"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatAppearance.BorderSize = 3
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.MediumBlue
        Button1.Location = New Point(86, 81)
        Button1.Margin = New Padding(5)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 45)
        Button1.TabIndex = 3
        Button1.Text = "Employee"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(744, 203)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(5)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Welcome To AGC Bank"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
