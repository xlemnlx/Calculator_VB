Public Class Form1
    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Dim n As Int64
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button12.Click, Button10.Click
        Dim b As Button = sender
        If Label1.Text = "0" Then
            Label1.Text = b.Text
        Else
            Label1.Text = Label1.Text + b.Text
        End If
    End Sub
    Private Sub arithmetic_function(sender As Object, e As EventArgs) Handles butun_plus.Click, butun_times.Click, butun_mod.Click, butun_minus.Click, butun_divide.Click, buton_exp.Click
        Dim ops As Button = sender
        f = Label1.Text
        Label3.Text = Label1.Text
        Label1.Text = ""
        op = ops.Text
        Label3.Text = Label3.Text + " " + op
    End Sub
    Private Sub butun_equal_Click(sender As Object, e As EventArgs) Handles butun_equal.Click
        s = Label1.Text
        If op = "+" Then
            a = f + s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "-" Then
            a = f - s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "*" Then
            a = f * s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "/" Then
            a = f / s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "Mod" Then
            a = f Mod s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "Exp" Then
            a = f ^ s
            Label1.Text = a
            Label3.Text = ""
        End If
    End Sub
    Private Sub butun_binary_Click(sender As Object, e As EventArgs) Handles butun_binary.Click
        If Int64.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 2)
        Else
            Label1.Text = ""
        End If
    End Sub
    Private Sub butun_oct_Click(sender As Object, e As EventArgs) Handles butun_oct.Click
        If Int64.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 8)
        Else
            Label1.Text = ""
        End If
    End Sub
    Private Sub butun_hex_Click(sender As Object, e As EventArgs) Handles butun_hex.Click
        If Int64.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 16)
        Else
            Label1.Text = ""
        End If
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        a = Math.Sin(Label1.Text * Math.PI / 180)
        Label1.Text = a
        Label3.Text = ""
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        a = Math.Cos(Label1.Text * Math.PI / 180)
        Label1.Text = a
        Label3.Text = ""
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        a = Math.Tan(Label1.Text * Math.PI / 180)
        Label1.Text = a
        Label3.Text = ""
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        a = Math.Log(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub
    Private Sub butun_C_Click(sender As Object, e As EventArgs) Handles butun_C.Click
        Label1.Text = Label1.Text.Substring(0, Label1.Text.Length - 1)
        If Label1.Text = "" Then
            MessageBox.Show("InputBox number first!")
        End If
    End Sub
    Private Sub butun_CE_Click(sender As Object, e As EventArgs) Handles butun_CE.Click
        Label1.Text = "0"
        Label3.Text = ""
    End Sub
    Private Sub butun_PositiveOrNegative_Click(sender As Object, e As EventArgs) Handles butun_PositiveOrNegative.Click
        Label1.Text = "-"
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        a = Math.Sqrt(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub
End Class
