Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Введите значение!")
        Else
            Dim a, h, r, Ro, S As Double
            Dim F = ComboBox1.SelectedIndex
            Select Case F
                Case 0
                    a = CDbl(TextBox1.Text)
                    h = h_St(a)
                    r = r_St(a)
                    Ro = Ro_St(a)
                    S = S_St(a)
                    Out_Label(a, h, S, r, Ro)
                Case 1
                    h = CInt(TextBox1.Text)
                    a = Math.Round(h * 2 / Math.Sqrt(3), 3)
                    r = r_St(a)
                    Ro = Ro_St(a)
                    S = S_St(a)
                    Out_Label(a, h, S, r, Ro)
                Case 2
                    S = CInt(TextBox1.Text)
                    a = Math.Round(Math.Sqrt(S * 4 / Math.Sqrt(3)), 3)
                    r = r_St(a)
                    Ro = Ro_St(a)
                    h = h_St(a)
                    Out_Label(a, h, S, r, Ro)
                Case 3
                    r = CInt(TextBox1.Text)
                    a = Math.Round(r * 6 / Math.Sqrt(3), 3)
                    S = S_St(a)
                    Ro = Ro_St(a)
                    h = h_St(a)
                    Out_Label(a, h, S, r, Ro)
                Case 4
                    Ro = CInt(TextBox1.Text)
                    a = Math.Round(Ro * 3 / Math.Sqrt(3), 3)
                    S = S_St(a)
                    r = r_St(a)
                    h = h_St(a)
                    Out_Label(a, h, S, r, Ro)
                Case Else
                    MsgBox("Выберите элемент треугольника!")
            End Select
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.Text = ""
        ComboBox1.Text = ""
        Label8.Text = "Параметры: "
    End Sub
    Private Function r_St(a As Double) As Double
        Return Math.Round(a * Math.Sqrt(3) / 6, 3)
    End Function
    Private Function S_St(a As Double) As Double
        Return Math.Round(Math.Pow(a, 2) * Math.Sqrt(3) / 4, 3)
    End Function
    Private Function Ro_St(a As Double) As Double
        Return Math.Round(a * Math.Sqrt(3) / 3, 3)
    End Function
    Private Function h_St(a As Double) As Double
        Return Math.Round(a * Math.Sqrt(3) / 2, 3)
    End Function

    Private Sub Out_Label(a As Double, h As Double, S As Double, r As Double, Ro As Double)
        Label8.Text = Format("Параметры: " & vbCrLf &
                                     "сторона а = " + CStr(a) & vbCrLf &
                                     "высота h = " + CStr(h) & vbCrLf &
                                     "площадь S = " + CStr(S) & vbCrLf &
                                     "радиус r = " + CStr(r) & vbCrLf &
                                     "радиус R = " + CStr(Ro))
    End Sub
End Class