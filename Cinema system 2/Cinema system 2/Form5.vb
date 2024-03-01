Imports System.Reflection.Emit

Public Class Form5
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public A1 As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I1 = New Form2


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1 = New Form6
        Dim d2 = New Form7
        If RadioButton1.Checked Then
            d1.Show()
            Me.Close()
        ElseIf RadioButton2.Checked Then
            d2.Label2.Text = Label4.Text
            d2.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim d1 = New Form2
        d1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d1 = New Form3
        d1.Show()
        Me.Close()
    End Sub
End Class