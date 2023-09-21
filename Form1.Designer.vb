<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.btnCheckValidity = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(366, 82)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(95, 20)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Enter SA ID"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(540, 79)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(213, 26)
        Me.txtIDNumber.TabIndex = 1
        '
        'btnCheckValidity
        '
        Me.btnCheckValidity.Location = New System.Drawing.Point(370, 189)
        Me.btnCheckValidity.Name = "btnCheckValidity"
        Me.btnCheckValidity.Size = New System.Drawing.Size(161, 40)
        Me.btnCheckValidity.TabIndex = 2
        Me.btnCheckValidity.Text = "Check Validity"
        Me.btnCheckValidity.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(406, 298)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(55, 20)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCheckValidity)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents btnCheckValidity As Button
    Friend WithEvents lblResult As Label
End Class
