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
        btnNg = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNg = New TextBox()
        lblNg = New Label()
        lblNg2 = New Label()
        SuspendLayout()
        ' 
        ' btnNg
        ' 
        btnNg.Location = New Point(190, 221)
        btnNg.Name = "btnNg"
        btnNg.Size = New Size(75, 23)
        btnNg.TabIndex = 1
        btnNg.Text = "実行"
        btnNg.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(487, 187)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 65)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 30F)
        Label2.Location = New Point(153, -3)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 54)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 30F)
        Label3.Location = New Point(153, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 54)
        Label3.TabIndex = 4
        Label3.Text = "Label3"
        ' 
        ' txtNg
        ' 
        txtNg.Location = New Point(52, 221)
        txtNg.Name = "txtNg"
        txtNg.Size = New Size(76, 23)
        txtNg.TabIndex = 5
        ' 
        ' lblNg
        ' 
        lblNg.AutoSize = True
        lblNg.Location = New Point(317, 225)
        lblNg.Name = "lblNg"
        lblNg.Size = New Size(41, 15)
        lblNg.TabIndex = 6
        lblNg.Text = "Label4"
        ' 
        ' lblNg2
        ' 
        lblNg2.AutoSize = True
        lblNg2.Location = New Point(384, 225)
        lblNg2.Name = "lblNg2"
        lblNg2.Size = New Size(13, 15)
        lblNg2.TabIndex = 7
        lblNg2.Text = "1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 287)
        Controls.Add(lblNg2)
        Controls.Add(lblNg)
        Controls.Add(txtNg)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnNg)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnNg As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNg As TextBox
    Friend WithEvents lblNg As Label
    Friend WithEvents lblNg2 As Label

End Class
