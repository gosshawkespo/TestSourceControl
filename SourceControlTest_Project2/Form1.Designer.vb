<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project2Form1
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
        Me.btnProject2Test1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnProject2Test1
        '
        Me.btnProject2Test1.Location = New System.Drawing.Point(168, 53)
        Me.btnProject2Test1.Name = "btnProject2Test1"
        Me.btnProject2Test1.Size = New System.Drawing.Size(122, 23)
        Me.btnProject2Test1.TabIndex = 0
        Me.btnProject2Test1.Text = "Proj 2 Test 1"
        Me.btnProject2Test1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Output:"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(210, 124)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(212, 20)
        Me.txtOutput.TabIndex = 2
        '
        'Project2Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 261)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProject2Test1)
        Me.Name = "Project2Form1"
        Me.Text = "Project 2 Form 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProject2Test1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOutput As TextBox
End Class
