Public Class dialogHelp
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents okBut As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.okBut = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'okBut
        '
        Me.okBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okBut.Location = New System.Drawing.Point(296, 264)
        Me.okBut.Name = "okBut"
        Me.okBut.Size = New System.Drawing.Size(88, 32)
        Me.okBut.TabIndex = 0
        Me.okBut.Text = "OK"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(16, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(368, 232)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "If you are not familiar with this kind of game (Bricks) please read the following" & _
        " instructions:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "1. The primary target of the game is to achieve score points. " & _
        "A secondary target would be to finish the game, by clearing the brick board" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "2" & _
        ". Achieving score points is done by hitting the bricks with the ball. When you h" & _
        "it a brick, it dissapears from the screen. When all the bricks are gone, you hav" & _
        "e won" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "3. You lose when the ball falls out the screen through the bottom part." & _
        "" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "4. Avoid losing the ball by moving the bottom paddle with the keyboard (Left" & _
        " Arrow and Right Arrow) and catching the ball on the paddle before it goes off s" & _
        "creen. If you ever lose control of the paddle click on the game panel and you wi" & _
        "ll recieve it back"
        '
        'dialogHelp
        '
        Me.AcceptButton = Me.okBut
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.okBut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dialogHelp"
        Me.ShowInTaskbar = False
        Me.Text = "Help"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub okBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okBut.Click
        Me.Dispose(True)
    End Sub
End Class
