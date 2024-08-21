<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWordApp_Load
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
        lblCount = New Label()
        lblQuestion = New Label()
        txtAnswer = New TextBox()
        btnAnswer = New Button()
        lblAnswer = New Label()
        lblGood = New Label()
        btnBefore = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Location = New Point(64, 53)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(52, 15)
        lblCount.TabIndex = 0
        lblCount.Text = "lblCount"
        ' 
        ' lblQuestion
        ' 
        lblQuestion.AutoSize = True
        lblQuestion.Location = New Point(105, 115)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(68, 15)
        lblQuestion.TabIndex = 1
        lblQuestion.Text = "lblQuestion"
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Location = New Point(247, 112)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(100, 23)
        txtAnswer.TabIndex = 2
        ' 
        ' btnAnswer
        ' 
        btnAnswer.Location = New Point(91, 186)
        btnAnswer.Name = "btnAnswer"
        btnAnswer.Size = New Size(75, 23)
        btnAnswer.TabIndex = 3
        btnAnswer.Text = "答え"
        btnAnswer.UseVisualStyleBackColor = True
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.Location = New Point(237, 198)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(59, 15)
        lblAnswer.TabIndex = 4
        lblAnswer.Text = "lblAnswer"
        ' 
        ' lblGood
        ' 
        lblGood.AutoSize = True
        lblGood.Location = New Point(356, 198)
        lblGood.Name = "lblGood"
        lblGood.Size = New Size(49, 15)
        lblGood.TabIndex = 5
        lblGood.Text = "lblGood"
        ' 
        ' btnBefore
        ' 
        btnBefore.Location = New Point(102, 286)
        btnBefore.Name = "btnBefore"
        btnBefore.Size = New Size(75, 23)
        btnBefore.TabIndex = 6
        btnBefore.Text = "btnBefore"
        btnBefore.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(311, 286)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(75, 23)
        btnNext.TabIndex = 7
        btnNext.Text = "btnNext"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' FrmWordApp_Load
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(btnBefore)
        Controls.Add(lblGood)
        Controls.Add(lblAnswer)
        Controls.Add(btnAnswer)
        Controls.Add(txtAnswer)
        Controls.Add(lblQuestion)
        Controls.Add(lblCount)
        Name = "FrmWordApp_Load"
        Text = "FrmWordApp_Load"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCount As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnAnswer As Button
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblGood As Label
    Friend WithEvents btnBefore As Button
    Friend WithEvents btnNext As Button

End Class
