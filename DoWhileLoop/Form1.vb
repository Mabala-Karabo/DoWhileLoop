Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = 1

        Do While (x < 10)
            MsgBox("The value of X is " & x)
            x += 1
        Loop
        ' the following code is the same as the prev ones 
        ' Do While Not (x > 10)
        'MsgBox("The value of X is " & x)
        'x += 1
        'Loop
    End Sub
End Class
