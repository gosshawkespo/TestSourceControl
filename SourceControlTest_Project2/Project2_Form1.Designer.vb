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
        Me.btnTest2 = New System.Windows.Forms.Button()
        Me.txtOutput2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.txtOutput.Location = New System.Drawing.Point(223, 124)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(240, 20)
        Me.txtOutput.TabIndex = 2
        '
        'btnTest2
        '
        Me.btnTest2.Location = New System.Drawing.Point(341, 53)
        Me.btnTest2.Name = "btnTest2"
        Me.btnTest2.Size = New System.Drawing.Size(122, 23)
        Me.btnTest2.TabIndex = 3
        Me.btnTest2.Text = "Proj 2 Test 2"
        Me.btnTest2.UseVisualStyleBackColor = True
        '
        'txtOutput2
        '
        Me.txtOutput2.Location = New System.Drawing.Point(223, 150)
        Me.txtOutput2.Name = "txtOutput2"
        Me.txtOutput2.Size = New System.Drawing.Size(240, 20)
        Me.txtOutput2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Output2:"
        '
        'Project2Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 261)
        Me.Controls.Add(Me.txtOutput2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTest2)
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
    Friend WithEvents btnTest2 As Button
    Friend WithEvents txtOutput2 As TextBox
    Friend WithEvents Label2 As Label
End Class
