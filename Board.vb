Public Class Board
    Public RefForm As frmMain

    Public BrickHeight As Integer

    Public BrickWidth As Single


    Public BrickNum As Size

    Public BrickGrid(,) As Brick



    'actual values (after computing with the resize ratio)
    Public Function ActualBrickHeight() As Integer
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return Me.BrickHeight * rr.Height
    End Function






    Public Sub New(ByVal RefForm As frmMain)
        Me.New(RefForm, New Size(5, 3))
    End Sub

    Public Sub New(ByVal RefForm As frmMain, ByVal BrickNum As Size)
        Me.RefForm = RefForm

        Me.BrickNum = BrickNum

        Me.BrickGrid = New Brick(Me.BrickNum.Width, Me.BrickNum.Height) {}

        Dim r As Random = New Random

        Dim i, j As Integer
        For j = 1 To Me.BrickNum.Height
            For i = 1 To Me.BrickNum.Width
                Me.BrickGrid(i, j) = New Brick(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)), r.Next(1, 5))
            Next i
        Next j


        Me.BrickWidth = Me.RefForm.BasicBoardWidth / Me.BrickNum.Width 'gets the width of a brick
    End Sub






    Public Sub Draw(ByVal g As Graphics)
        Dim x As Integer = 0

        Dim i, j As Integer
        For i = 1 To Me.BrickNum.Width
            Dim w As Integer = (Me.RefForm.gamePanel.Width - x) / (Me.BrickNum.Width - i + 1)

            For j = 1 To Me.BrickNum.Height
                If Not (Me.BrickGrid(i, j) Is Nothing) Then Me.BrickGrid(i, j).Draw(g, New Rectangle(x, (j - 1) * Me.ActualBrickHeight(), w, Me.ActualBrickHeight()))
            Next

            x = x + w
        Next

    End Sub





    Public Function BrickAtPoint(ByVal x As Single, ByVal y As Single) As Point
        Dim c As Integer = x \ Me.BrickWidth + 1
        Dim r As Integer = y \ Me.BrickHeight + 1

        'If r < 1 Then r = 1
        'If c > Me.BrickNum.Width Then c = Me.BrickWidth
        'If c < 1 Then c = 1

        Return New Point(c, r)
    End Function






    Public Sub VerGameWon()
        Dim i, j As Integer
        For j = 1 To Me.BrickNum.Height
            For i = 1 To Me.BrickNum.Width
                If Not (Me.BrickGrid(i, j) Is Nothing) Then Exit Sub
            Next
        Next

        'game won
        'sound
        If Not Me.RefForm.muteChB.Checked Then SoundPlayer.sndPlaySound("meta\won.wav", 1)
    End Sub
End Class
