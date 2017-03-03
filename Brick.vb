Imports System.Drawing


Public Class Brick

    Public Color As Color
    Public Points As Integer


    Private Img As Image





    Public Sub New(ByVal Color As Color, ByVal Points As Integer)
        Me.Color = Color
        Me.Points = Points


        'make a colored brick
        Me.Img = Image.FromFile("meta\brick.jpg")
        Dim bm As Bitmap = Me.Img

        Dim i, j As Integer
        For j = 0 To bm.Height - 1
            For i = 0 To bm.Width - 1
                Dim lum As Integer = bm.GetPixel(i, j).R

                Dim med As Integer = (CType(Me.Color.R, Integer) + CType(Me.Color.G, Integer) + CType(Me.Color.B, Integer)) / 3
                Dim dif As Integer = (lum - med) / 3

                Dim r, g, b As Integer
                r = Me.Color.R + dif
                g = Me.Color.G + dif
                b = Me.Color.B + dif

                If r < 0 Then r = 0
                If r > 255 Then r = 255
                If g < 0 Then g = 0
                If g > 255 Then g = 255
                If b < 0 Then b = 0
                If b > 255 Then b = 255

                bm.SetPixel(i, j, Color.FromArgb(r, g, b))
            Next
        Next

        Me.Img = bm
    End Sub





    Public Sub DrawSimple(ByVal g As Graphics, ByVal Area As Rectangle)
        Dim p As Pen = New Pen(Me.Color)
        Dim pB As Pen = New Pen(Color.Silver)

        g.FillRectangle(p.Brush, Area)
        g.DrawRectangle(pB, Area)
    End Sub

    Public Sub Draw(ByVal g As Graphics, ByVal Area As Rectangle)
        g.DrawImage(Me.Img, Area)
    End Sub
End Class
