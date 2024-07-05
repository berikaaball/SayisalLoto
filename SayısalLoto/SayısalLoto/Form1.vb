Public Class Form1
    Private Sub OynaBtn_Click(sender As Object, e As EventArgs) Handles OynaBtn.Click
        Dim rnd As New Random
        Dim sayi, superstarsayi As Integer
        Dim sayilar(5) As Integer
        Dim eslesme As Boolean = False
        Dim mesaj1, mesaj2 As String
        mesaj1 = "EŞLEŞME VAR,KAZANDINIZ! TEBRİKLER!"
        mesaj2 = "Eşleşme yok. Kazanamadınız."

        For i = 0 To sayilar.Count - 1
            Do
                sayi = rnd.Next(1, 91)
            Loop While sayilar.Contains(sayi)
            sayilar(i) = sayi
        Next
        Array.Sort(sayilar)

        For Each lbl As Label In Me.Controls.OfType(Of Label)
            If IsNumeric(lbl.Tag) Then
                If lbl.Tag >= 0 AndAlso lbl.Tag < 6 Then
                    lbl.Text = sayilar(lbl.Tag)
                End If
            End If
        Next

        If SuperStarCBox.Checked Then
            superstarsayi = rnd.Next(1, 91)
        End If
        SStarLbl.Text = superstarsayi

        eslesme = eslesmekontrolu()
        If eslesme = True Then
            TextBox1.Text = mesaj1
        Else
            TextBox1.Text = mesaj2
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Rnd As New Random
        Dim sayi2 As Integer
        Dim sayilar2(12) As Integer

        For i = 0 To sayilar2.Count - 1
            Do
                sayi2 = Rnd.Next(1, 91)
            Loop While sayilar2.Contains(sayi2)
            sayilar2(i) = sayi2
        Next
        Array.Sort(sayilar2)

        For Each lbl2 As Label In Me.Controls.OfType(Of Label)
            If IsNumeric(lbl2.Tag) Then
                If lbl2.Tag > 5 AndAlso lbl2.Tag < 12 Then
                    lbl2.Text = sayilar2(lbl2.Tag)
                End If
            End If
        Next
    End Sub

    Private Function eslesmekontrolu() As Boolean
        'If Sayi1Lbl.Text = lbl2.text Then
        '    eslesme = True
        '    ListView1.Items.Add("KAZANDINIZ! TEBRİKLER!")
        'End If
        Dim mesaj1, mesaj2 As String
        mesaj1 = "KAZANDINIZ! TEBRİKLER!"
        mesaj2 = "Eşleşme yok. Kazanamadınız."
        For Each lbl As Label In Me.Controls.OfType(Of Label)
            If IsNumeric(lbl.Tag) AndAlso (lbl.Tag) >= 0 AndAlso (lbl.Tag) <= 5 Then
                For Each lbl2 As Label In Me.Controls.OfType(Of Label)
                    If IsNumeric(lbl2.Tag) AndAlso (lbl2.Tag) >= 6 AndAlso (lbl2.Tag) <= 11 Then
                        If lbl.Text = lbl2.Text Then
                            Return True
                            TextBox1.Text = mesaj1
                        End If
                    End If
                Next
            End If
        Next
        Return False
        TextBox1.Text = mesaj2
    End Function
End Class
