Public Class Main



    Public Shared Sub Main()
        Randomize()


        Dim f As frmMain = New frmMain

        f.Show()

        While f.Created
            Application.DoEvents()
        End While
    End Sub

End Class
