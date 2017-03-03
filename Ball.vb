Public Class Ball
    Public RefForm As frmMain
    Public RefPaddle As Paddle
    Public RefBoard As Board

    Public Size As Size


    Public Position As PointF
    Public Velocity As PointF


    Public MaxHorizontalDeviation As Single



    Private Img As Image





    'actual values (after computing with the resize ratio)
    Public Function ActualSize() As Size
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return New Size(Me.Size.Width * rr.Width, Me.Size.Height * rr.Height)
    End Function
    Public Function ActualPosition() As PointF
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return New PointF(Me.Position.X * rr.Width, Me.Position.Y * rr.Height)
    End Function
    Public Function ActualVelocity() As PointF
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return New PointF(Me.Velocity.X * rr.Width, Me.Velocity.Y * rr.Height)
    End Function





    Public Sub New(ByVal RefForm As frmMain, ByVal RefPaddle As Paddle, ByVal RefBoard As Board, ByVal Position As PointF, ByVal Velocity As PointF)
        Me.RefForm = RefForm
        Me.RefPaddle = RefPaddle
        Me.RefBoard = RefBoard

        Me.Position = Position

        Me.Velocity = Velocity


        Me.Img = Image.FromFile("meta\ball.png")
    End Sub







    Public Sub DrawSimple(ByVal g As Graphics)
        Dim p As Pen = New Pen(Color.Black)
        Dim pB As Pen = New Pen(Color.Gray)

        Dim rect As Rectangle = New Rectangle(Me.ActualPosition.X - Me.ActualSize.Width / 2, Me.ActualPosition.Y - Me.ActualSize.Height / 2, Me.ActualSize.Width, Me.ActualSize.Height)
        g.FillEllipse(p.Brush, rect)
        g.DrawEllipse(pB, rect)
    End Sub


    Public Sub Draw(ByVal g As Graphics)
        Dim rect As Rectangle = New Rectangle(Me.ActualPosition.X - Me.ActualSize.Width / 2, Me.ActualPosition.Y - Me.ActualSize.Height / 2, Me.ActualSize.Width, Me.ActualSize.Height)

        g.DrawImage(Me.Img, rect)
    End Sub








    Public Sub NormalizeVelocity(ByVal Vel As Single)
        Dim r As Single = Vel / Math.Sqrt(Me.Velocity.X ^ 2 + Me.Velocity.Y ^ 2)

        Me.Velocity.X *= r
        Me.Velocity.Y *= r
    End Sub








    Public Sub ProcessDynamics()
        Me.Position.X += Me.Velocity.X
        Me.Position.Y += Me.Velocity.Y

        'collision with wall
        If Me.Position.X + Me.Size.Width / 2 > Me.RefForm.BasicBoardWidth Then
            Me.Velocity.X *= -1.0F
            Me.Position.X = Me.RefForm.BasicBoardWidth - Me.Size.Width / 2
            'sound
            If Not Me.RefForm.muteChB.Checked Then SoundPlayer.sndPlaySound("meta\wall.wav", 1)
        ElseIf Me.Position.X - Me.Size.Width / 2 < 0 Then
            Me.Velocity.X *= -1.0F
            Me.Position.X = Me.Size.Width / 2
            'sound
            If Not Me.RefForm.muteChB.Checked Then SoundPlayer.sndPlaySound("meta\wall.wav", 1)
        End If
        If Me.Position.Y - Me.Size.Height / 2 < 0 Then
            Me.Velocity.Y *= -1.0F
            Me.Position.Y = Me.Size.Height / 2
            'sound
            If Not Me.RefForm.muteChB.Checked Then SoundPlayer.sndPlaySound("meta\wall.wav", 1)
        End If

        'ball lost
        If Me.Position.Y > Me.RefPaddle.Position.Y Then
            ' GAME OVER
            Me.RefForm.timeT.Stop()
            Me.RefForm.gameOverL.Visible = True
            'sound
            If Not Me.RefForm.muteChB.Checked Then SoundPlayer.sndPlaySound("meta\lose.wav", 1)
        End If

        'collision with paddle
        If Me.Position.Y + Me.Size.Height / 2 > Me.RefPaddle.Position.Y - Me.RefPaddle.Size.Height / 2 Then
            If (Me.Position.X + Me.Size.Width / 2 > Me.RefPaddle.Position.X - Me.RefPaddle.Size.Width / 2) And (Me.Position.X - Me.Size.Width / 2 < Me.RefPaddle.Position.X + Me.RefPaddle.Size.Width / 2) Then
                Me.Position.Y = Me.RefPaddle.Position.Y - Me.RefPaddle.Size.Height / 2 - Me.Size.Height / 2

                Me.Velocity.Y *= -1.0F

                'aditional horizontal deviation for the ball
                Me.Velocity.X += 2 * Me.MaxHorizontalDeviation * (Me.Position.X - Me.RefPaddle.Position.X) / Me.RefPaddle.Size.Width
                Me.NormalizeVelocity(Me.RefForm.LevelVelocity(Me.RefForm.Level))

                'sound
                If Not Me.RefForm.muteChB.Checked Then SoundPlayer.sndPlaySound("meta\paddle.wav", 1)
            End If
        End If


        'collision with bricks
        '(optimization)
        If Me.Position.Y - Me.Size.Height < Me.RefBoard.BrickHeight * Me.RefBoard.BrickNum.Height Then
            Try
                Dim p As Point

                If Me.Velocity.Y < 0 Then
                    p = Me.RefBoard.BrickAtPoint(Me.Position.X, Me.Position.Y - Me.Size.Height / 2)
                Else
                    p = Me.RefBoard.BrickAtPoint(Me.Position.X, Me.Position.Y + Me.Size.Height / 2)
                End If
                If (p.Y <= Me.RefBoard.BrickNum.Height) Then
                    If Not (Me.RefBoard.BrickGrid(p.X, p.Y) Is Nothing) Then
                        Me.Velocity.Y *= -1
                        Me.RefForm.Score += Me.RefBoard.BrickGrid(p.X, p.Y).Points
                        Me.RefBoard.BrickGrid(p.X, p.Y) = Nothing

                        'sound
                        If Not Me.RefForm.muteChB.Checked Then SoundPlayer.sndPlaySound("meta\brick.wav", 1)

                        Me.RefBoard.VerGameWon()
                    End If
                End If

                If Me.Velocity.X < 0 Then
                    p = Me.RefBoard.BrickAtPoint(Me.Position.X - Me.Size.Width, Me.Position.Y)
                Else
                    p = Me.RefBoard.BrickAtPoint(Me.Position.X + Me.Size.Width, Me.Position.Y)
                End If
                If (p.Y <= Me.RefBoard.BrickNum.Height) Then
                    If Not (Me.RefBoard.BrickGrid(p.X, p.Y) Is Nothing) Then
                        Me.Velocity.X *= -1
                        Me.RefForm.Score += Me.RefBoard.BrickGrid(p.X, p.Y).Points
                        Me.RefBoard.BrickGrid(p.X, p.Y) = Nothing

                        'sound
                        If Not Me.RefForm.muteChB.Checked Then SoundPlayer.sndPlaySound("meta\brick.wav", 1)

                        Me.RefBoard.VerGameWon()
                    End If

                End If
            Catch ex As Exception
                'if out of bounds exceptions are found
            End Try
        End If



    End Sub
End Class
