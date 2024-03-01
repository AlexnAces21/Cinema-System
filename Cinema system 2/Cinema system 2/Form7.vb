Public Class Form7
    Dim dd As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim see = New Form1
        Dim f1 = New Form2
        Dim f2 = New Form5
        Dim ammount As String
        Dim dd As Double
        Dim ddt As Double
        ammount = Val(TextBox1.Text)
        dd = Convert.ToDouble(Label2.Text)

        If ammount >= dd Then
            ddt = ammount - dd
            MsgBox("Processed successfully! Enjoy the show" & " Total Amount for change:" & ddt)
            see.Show()
            Me.Close()

        Else
            MsgBox("An error has ocurred please try again or ask for assistance!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d1 = New Form5
        d1.Show()
        Me.Close()
    End Sub
End Class