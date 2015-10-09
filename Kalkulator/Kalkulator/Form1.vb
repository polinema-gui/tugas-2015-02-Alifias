Public Class Form1

    Dim a, b, c As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        a = 0
        b = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        tombolklik(1)
    End Sub


    Private Sub Tombol2_Click(sender As Object, e As EventArgs) Handles button2.Click
        tombolklik(2)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tombolklik(3)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tombolklik(4)
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tombolklik(5)
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        tombolklik(6)
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        tombolklik(7)
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        tombolklik(8)
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        tombolklik(9)
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button0.Click
        tombolklik(0)
    End Sub

    Private Sub tombolklik(ByVal e As String)
        If b > 0 Then
            Isi.Text = 0
            If Isi.Text = 0 Then
                Isi.Text = e
            Else
                Isi.Text = Isi.Text + e
            End If
        Else
            If Isi.Text = 0 Then
                Isi.Text = e
            Else
                Isi.Text = Isi.Text + e
            End If
        End If
        b = 0
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        If c = 1 Then
            a = a - Convert.ToDouble(Isi.Text)
            Isi.Text = a
        ElseIf c = 3 Then
            a = Isi.Text
        Else
            a = a + Convert.ToDouble(Isi.Text)
            Isi.Text = a

        End If
        b = 1
        c = 2
    End Sub

    Private Sub equalButton_Click(sender As Object, e As EventArgs) Handles equalButton.Click
        If c = 2 Then
            a = a + Convert.ToDouble(Isi.Text)
            Isi.Text = a
        Elseif c = 1 Then
            a = a - Convert.ToDouble(Isi.Text)
            Isi.Text = a
        End If
        a = 0
        c = 3
        b = 1
    End Sub


    Private Sub pointButton_Click(sender As Object, e As EventArgs) Handles pointButton.Click
        If c = 2 Then
            a = a + Convert.ToDouble(Isi.Text)
            Isi.Text = a

        ElseIf c = 3 Then
            a = Isi.Text
        Else
            a = a - Convert.ToDouble(Isi.Text)
            Isi.Text = a

        End If
        b = 1
        c = 1
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Isi.Clear()
        Isi.Text = 0
    End Sub
End Class
