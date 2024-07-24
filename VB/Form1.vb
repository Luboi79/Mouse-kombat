Public Class Form1
    Dim Click = 0
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Click += 1
        Label1.Text = Click
        If (Click = 50) Then
            PictureBox1.Image = VB.My.Resources.Resources.photo_2024_07_24_10_45_29
        End If

        If (Click = 100) Then
            PictureBox1.Image = VB.My.Resources.Resources.photo_2024_07_24_11_00_03
        End If



        If (Click = 100) Then
            PictureBox1.Image = VB.My.Resources.Resources.photo_2024_07_24_11_00_03
        End If

        If (Click = 150) Then
            PictureBox1.Image = VB.My.Resources.Resources.photo_2024_07_24_11_13_37
            Label2.Text = "Mira kombat"
        End If



        If (Click >= 150) Then
            Click += 1
        End If





        If (Click = 250) Then
            PictureBox1.Image = VB.My.Resources.Resources.photo_2024_07_24_11_17_17__2_
            Label2.Text = "Mouse kombat"
        End If

        If (Click = 400) Then
            PictureBox1.Image = VB.My.Resources.Resources.photo_2024_07_24_11_17_17
        End If

        If (Click = 550) Then
            PictureBox1.Image = VB.My.Resources.Resources.photo_2024_06_10_12_05_52
        End If



        If (Click >= 550) Then
            Click += 2
        End If
















        If (Click >= 10) Then
            Label4.Visible = True
            Label3.Text = "0.000000000000000000000000000000000" + Label1.Text + " RUB"
        Else
            Label3.Text = "0.000" + Label1.Text + " RUB"
        End If



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
