<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Button1.FlatAppearance.BorderSize = 3
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.MediumBlue
        Button1.Location = New Point(32, 92)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 41)
        Button1.TabIndex = 0
        Button1.Text = "New Client"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatAppearance.BorderSize = 3
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.MediumBlue
        Button2.Location = New Point(197, 92)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 41)
        Button2.TabIndex = 1
        Button2.Text = "Search For Client"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.FlatAppearance.BorderSize = 3
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.MediumBlue
        Button3.Location = New Point(403, 92)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 41)
        Button3.TabIndex = 2
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(565, 207)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.Black
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "Form10"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Clients"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
