Public Class Paddle
    Public RefForm As frmMain

    Public Size As Size
    Public DistanceFromBottom As Integer


    Public Position As PointF
    Public Velocity As Single
    Public Acceleration As Single

    Public MaxVelocity As Single



    Private Img As Image




    'actual values (after computing with the resize ratio)
    Public Function ActualSize() As Size
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return New Size(Me.Size.Width * rr.Width, Me.Size.Height * rr.Height)
    End Function
    Public Function ActualDistanceFromBottom() As Integer
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return Me.DistanceFromBottom * rr.Height
    End Function
    Public Function ActualPosition() As PointF
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return New PointF(Me.Position.X * rr.Width, Me.Position.Y * rr.Height)
    End Function
    Public Function ActualVelocity() As Single
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return Me.Velocity * rr.Width
    End Function
    Public Function ActualAcceleration() As Single
        Dim rr As SizeF = Me.RefForm.ResizeRatio
        Return Me.Acceleration * rr.Width
    End Function




    Public Sub New(ByVal RefForm As frmMain, ByVal Position As PointF)
        Me.RefForm = RefForm

        Me.Position = Position

        Me.Velocity = 0
        Me.Acceleration = 0


        Me.Img = Image.FromFile("meta\paddle.png")
    End Sub





    Public Sub DrawSimple(ByVal g As Graphics)
        Dim p As Pen = New Pen(Color.DarkKhaki)
        Dim pB As Pen = New Pen(Color.DarkRed)

        Dim rect As Rectangle = New Rectangle(Me.ActualPosition.X - Me.ActualSize.Width / 2, Me.ActualPosition.Y - Me.ActualSize.Height / 2, Me.ActualSize.Width, Me.ActualSize.Height)
        g.FillRectangle(p.Brush, rect)
        g.DrawRectangle(pB, rect)
    End Sub


    Public Sub Draw(ByVal g As Graphics)
        Dim rect As Rectangle = New Rectangle(Me.ActualPosition.X - Me.ActualSize.Width / 2, Me.ActualPosition.Y - Me.ActualSize.Height / 2, Me.ActualSize.Width, Me.ActualSize.Height)

        g.DrawImage(Me.Img, rect)
    End Sub







    Public Sub ProcessDynamics()
        'velocity increases by acceleration and drops by friction
        Me.Velocity += Me.Acceleration
        Me.Velocity /= 1.5F
        Me.Position.X += Me.Velocity

        'max velocities
        If Me.Velocity > Me.MaxVelocity Then Me.Velocity = Me.MaxVelocity
        If Me.Velocity < -Me.MaxVelocity Then Me.Velocity = -Me.MaxVelocity

        'wall limit
        If Me.Position.X + Me.Size.Width / 2 > Me.RefForm.BasicBoardWidth Then
            Me.Position.X = Me.RefForm.BasicBoardWidth - Me.Size.Width / 2
        ElseIf Me.Position.X - Me.Size.Width / 2 < 0 Then
            Me.Position.X = Me.Size.Width / 2
        End If
    End Sub

End Class
