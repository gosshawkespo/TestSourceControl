<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project1_Form1
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
        Me.btnTEST1 = New System.Windows.Forms.Button()
        Me.txtOutput1 = New System.Windows.Forms.TextBox()
        Me.sts = New System.Windows.Forms.StatusStrip()
        Me.StsLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sts.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTEST1
        '
        Me.btnTEST1.Location = New System.Drawing.Point(139, 40)
        Me.btnTEST1.Name = "btnTEST1"
        Me.btnTEST1.Size = New System.Drawing.Size(75, 23)
        Me.btnTEST1.TabIndex = 0
        Me.btnTEST1.Text = "Test1"
        Me.btnTEST1.UseVisualStyleBackColor = True
        '
        'txtOutput1
        '
        Me.txtOutput1.Location = New System.Drawing.Point(139, 79)
        Me.txtOutput1.Name = "txtOutput1"
        Me.txtOutput1.Size = New System.Drawing.Size(100, 20)
        Me.txtOutput1.TabIndex = 1
        '
        'sts
        '
        Me.sts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StsLabel1})
        Me.sts.Location = New System.Drawing.Point(0, 239)
        Me.sts.Name = "sts"
        Me.sts.Size = New System.Drawing.Size(697, 22)
        Me.sts.TabIndex = 2
        Me.sts.Text = "StatusStrip1"
        '
        'StsLabel1
        '
        Me.StsLabel1.Name = "StsLabel1"
        Me.StsLabel1.Size = New System.Drawing.Size(120, 17)
        Me.StsLabel1.Text = "ToolStripStatusLabel1"
        '
        'Project1_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 261)
        Me.Controls.Add(Me.sts)
        Me.Controls.Add(Me.txtOutput1)
        Me.Controls.Add(Me.btnTEST1)
        Me.Name = "Project1_Form1"
        Me.Text = "Project 1 Form 1"
        Me.sts.ResumeLayout(False)
        Me.sts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTEST1 As Button
    Friend WithEvents txtOutput1 As TextBox
    Friend WithEvents sts As StatusStrip
    Friend WithEvents StsLabel1 As ToolStripStatusLabel
End Class
