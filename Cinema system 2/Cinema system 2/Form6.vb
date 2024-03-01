Imports System.Reflection.Metadata.Ecma335
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim close = New Form1
        Dim num As String
        Dim mm2 As String
        Dim yy2 As String
        Dim ccv2 As String
        num = Val(TextBox1.Text)
        mm2 = Val(MM.Text)
        yy2 = Val(YY.Text)
        ccv2 = Val(ccv.Text)
        If (String.IsNullOrEmpty(ComboBox1.Text)) Then
            MsgBox("Error:Please select a card name and try again.")
        Else
            If (num > 1111111111111111) Then
                If (mm2 >= 1) Then
                    If (yy2 > 1111) Then
                        If (ccv2 > 111) Then
                            MsgBox("Process complete!\n Enjoy the show!")
                            close.Show()
                            Me.Close()
                        Else MsgBox("There was a problem with the ccv please try again or call for asistance.")
                        End If
                    Else MsgBox("There was a problem with the mm part, please try again or call for asistance.")
                    End If
                Else MsgBox("There was a problem with the yyyy part, please try again or call for asistance.")
                End If
            Else MsgBox("There was a problem with the Card Number, please try again or call for asistance.")
            End If
        End If


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d1 = New Form5
        d1.Show()
        Me.Close()
    End Sub
End Class