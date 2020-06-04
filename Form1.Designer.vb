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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTurnCount = New System.Windows.Forms.Label()
        Me.lblSquareOne = New System.Windows.Forms.Label()
        Me.lblSquareTwo = New System.Windows.Forms.Label()
        Me.lblSquareFour = New System.Windows.Forms.Label()
        Me.lblSquareThree = New System.Windows.Forms.Label()
        Me.lblSquareFive = New System.Windows.Forms.Label()
        Me.lblSquareSix = New System.Windows.Forms.Label()
        Me.lblSquareSeven = New System.Windows.Forms.Label()
        Me.lblEight = New System.Windows.Forms.Label()
        Me.lblNine = New System.Windows.Forms.Label()
        Me.Grpbox = New System.Windows.Forms.GroupBox()
        Me.lblPlayerTurn = New System.Windows.Forms.Label()
        Me.Grpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(274, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 50)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Tictactoe"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button1.Location = New System.Drawing.Point(67, 676)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "start game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button2.Location = New System.Drawing.Point(485, 676)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "clear game"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblTurnCount
        '
        Me.lblTurnCount.AutoSize = True
        Me.lblTurnCount.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTurnCount.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblTurnCount.Location = New System.Drawing.Point(24, 30)
        Me.lblTurnCount.Name = "lblTurnCount"
        Me.lblTurnCount.Size = New System.Drawing.Size(190, 42)
        Me.lblTurnCount.TabIndex = 5
        Me.lblTurnCount.Text = "turn count"
        '
        'lblSquareOne
        '
        Me.lblSquareOne.BackColor = System.Drawing.Color.Gray
        Me.lblSquareOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareOne.ForeColor = System.Drawing.Color.Gray
        Me.lblSquareOne.Location = New System.Drawing.Point(48, 56)
        Me.lblSquareOne.Name = "lblSquareOne"
        Me.lblSquareOne.Size = New System.Drawing.Size(155, 108)
        Me.lblSquareOne.TabIndex = 0
        '
        'lblSquareTwo
        '
        Me.lblSquareTwo.BackColor = System.Drawing.Color.Gray
        Me.lblSquareTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareTwo.ForeColor = System.Drawing.Color.Gray
        Me.lblSquareTwo.Location = New System.Drawing.Point(272, 56)
        Me.lblSquareTwo.Name = "lblSquareTwo"
        Me.lblSquareTwo.Size = New System.Drawing.Size(155, 108)
        Me.lblSquareTwo.TabIndex = 1
        '
        'lblSquareFour
        '
        Me.lblSquareFour.BackColor = System.Drawing.Color.Gray
        Me.lblSquareFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareFour.ForeColor = System.Drawing.Color.Gray
        Me.lblSquareFour.Location = New System.Drawing.Point(48, 217)
        Me.lblSquareFour.Name = "lblSquareFour"
        Me.lblSquareFour.Size = New System.Drawing.Size(155, 108)
        Me.lblSquareFour.TabIndex = 2
        '
        'lblSquareThree
        '
        Me.lblSquareThree.BackColor = System.Drawing.Color.Gray
        Me.lblSquareThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareThree.ForeColor = System.Drawing.Color.Gray
        Me.lblSquareThree.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblSquareThree.Location = New System.Drawing.Point(483, 56)
        Me.lblSquareThree.Name = "lblSquareThree"
        Me.lblSquareThree.Size = New System.Drawing.Size(155, 108)
        Me.lblSquareThree.TabIndex = 2
        '
        'lblSquareFive
        '
        Me.lblSquareFive.BackColor = System.Drawing.Color.Gray
        Me.lblSquareFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareFive.ForeColor = System.Drawing.Color.Gray
        Me.lblSquareFive.Location = New System.Drawing.Point(273, 217)
        Me.lblSquareFive.Name = "lblSquareFive"
        Me.lblSquareFive.Size = New System.Drawing.Size(155, 108)
        Me.lblSquareFive.TabIndex = 3
        '
        'lblSquareSix
        '
        Me.lblSquareSix.BackColor = System.Drawing.Color.Gray
        Me.lblSquareSix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareSix.ForeColor = System.Drawing.Color.Gray
        Me.lblSquareSix.Location = New System.Drawing.Point(483, 217)
        Me.lblSquareSix.Name = "lblSquareSix"
        Me.lblSquareSix.Size = New System.Drawing.Size(155, 108)
        Me.lblSquareSix.TabIndex = 4
        '
        'lblSquareSeven
        '
        Me.lblSquareSeven.BackColor = System.Drawing.Color.Gray
        Me.lblSquareSeven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareSeven.ForeColor = System.Drawing.Color.Gray
        Me.lblSquareSeven.Location = New System.Drawing.Point(48, 379)
        Me.lblSquareSeven.Name = "lblSquareSeven"
        Me.lblSquareSeven.Size = New System.Drawing.Size(155, 115)
        Me.lblSquareSeven.TabIndex = 5
        '
        'lblEight
        '
        Me.lblEight.BackColor = System.Drawing.Color.Gray
        Me.lblEight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEight.ForeColor = System.Drawing.Color.Gray
        Me.lblEight.Location = New System.Drawing.Point(273, 379)
        Me.lblEight.Name = "lblEight"
        Me.lblEight.Size = New System.Drawing.Size(155, 108)
        Me.lblEight.TabIndex = 6
        '
        'lblNine
        '
        Me.lblNine.BackColor = System.Drawing.Color.Gray
        Me.lblNine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNine.ForeColor = System.Drawing.Color.Gray
        Me.lblNine.Location = New System.Drawing.Point(483, 379)
        Me.lblNine.Name = "lblNine"
        Me.lblNine.Size = New System.Drawing.Size(155, 108)
        Me.lblNine.TabIndex = 7
        '
        'Grpbox
        '
        Me.Grpbox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Grpbox.Controls.Add(Me.lblNine)
        Me.Grpbox.Controls.Add(Me.lblEight)
        Me.Grpbox.Controls.Add(Me.lblSquareSeven)
        Me.Grpbox.Controls.Add(Me.lblSquareSix)
        Me.Grpbox.Controls.Add(Me.lblSquareFive)
        Me.Grpbox.Controls.Add(Me.lblSquareThree)
        Me.Grpbox.Controls.Add(Me.lblSquareFour)
        Me.Grpbox.Controls.Add(Me.lblSquareTwo)
        Me.Grpbox.Controls.Add(Me.lblSquareOne)
        Me.Grpbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Grpbox.Location = New System.Drawing.Point(31, 90)
        Me.Grpbox.Name = "Grpbox"
        Me.Grpbox.Size = New System.Drawing.Size(719, 559)
        Me.Grpbox.TabIndex = 1
        Me.Grpbox.TabStop = False
        '
        'lblPlayerTurn
        '
        Me.lblPlayerTurn.AutoSize = True
        Me.lblPlayerTurn.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlayerTurn.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblPlayerTurn.Location = New System.Drawing.Point(554, 28)
        Me.lblPlayerTurn.Name = "lblPlayerTurn"
        Me.lblPlayerTurn.Size = New System.Drawing.Size(196, 42)
        Me.lblPlayerTurn.TabIndex = 6
        Me.lblPlayerTurn.Text = "Player turn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 729)
        Me.Controls.Add(Me.lblPlayerTurn)
        Me.Controls.Add(Me.lblTurnCount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Grpbox)
        Me.Name = "Form1"
        Me.Text = "FrmTicTacToe"
        Me.Grpbox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTurnCount As Label
    Friend WithEvents lblSquareOne As Label
    Friend WithEvents lblSquareTwo As Label
    Friend WithEvents lblSquareFour As Label
    Friend WithEvents lblSquareThree As Label
    Friend WithEvents lblSquareFive As Label
    Friend WithEvents lblSquareSix As Label
    Friend WithEvents lblSquareSeven As Label
    Friend WithEvents lblEight As Label
    Friend WithEvents lblNine As Label
    Friend WithEvents Grpbox As GroupBox
    Friend WithEvents lblPlayerTurn As Label
End Class
