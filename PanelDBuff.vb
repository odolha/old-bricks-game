'A panel class that is double buffered


Public Class PanelDBuff
    Inherits Panel

    Public Sub New()
        MyBase.New()

        'Activates double buffering 
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.DoubleBuffer, True)
    End Sub

End Class
