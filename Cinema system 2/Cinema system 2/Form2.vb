Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Public d1 As String
    Public d2 As Double
    Public d3 As String
    Public d4 As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub a65_Click(sender As Object, e As EventArgs) Handles a65.Click
        Dim i1 = New Form5
        Dim i2 As Integer
        Dim i3 As Integer
        Dim i4 As Integer
        Dim i5 As Integer
        i2 = Convert.ToInt16(adm.SelectedItem)
        i3 = Convert.ToInt16(ma.SelectedItem)
        i4 = Convert.ToInt16(dnd1.SelectedItem)
        i5 = Convert.ToInt16(creed3.SelectedItem)
        If (String.IsNullOrEmpty(ComboBox2.Text)) Then
            MsgBox("Error:Please select a seat")
        Else
            d3 = ComboBox2.SelectedItem
            If i2 = 1 Then
                d1 = "65= 7.00$"
                i1.ListBox1.Items.Add(d1)
                i1.ListBox1.Items.Add(d3)
                d2 = 7.0
                i1.Label4.Text = d2
                i1.Show()
                Me.Close()
            ElseIf i3 = 1 Then
                d1 = "The Super Mario Movie= 7.00$"

                i1.ListBox1.Items.Add(d1)
                i1.ListBox1.Items.Add(d3)
                d2 = 7.0
                i1.Label4.Text = d2
                i1.Show()
                Me.Close()
            ElseIf i4 = 1 Then
                d1 = "Dungeons and Dragons Honor Among Thieves= 7.00$"
                i1.ListBox1.Items.Add(d1)
                i1.ListBox1.Items.Add(d3)
                d2 = 7.0
                i1.Label4.Text = d2
                i1.Show()
                Me.Close()
            ElseIf i5 = 1 Then
                d1 = "creed III= 7.00$"

                i1.ListBox1.Items.Add(d1)
                i1.ListBox1.Items.Add(d3)
                d2 = 7.0
                i1.Label4.Text = d2
                i1.Show()
                Me.Close()
            Else
                MsgBox("Error:No movie selected, please try again")
            End If
        End If





    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i1 = New Form1
        i1.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub





    Private Sub adm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles adm.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
    End Sub
End Class