Public Class Form1
    Private Sub tickets_Click(sender As Object, e As EventArgs) Handles tickets.Click
        Dim ticket = New Form2()
        ticket.Show()
        Me.Hide()

    End Sub

    Private Sub food_Click(sender As Object, e As EventArgs) Handles food.Click
        Dim foods = New Form3()
        foods.Show()
        Me.Hide()
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        End
    End Sub
End Class
