Public Class Form1
    Dim n As Byte
    Dim v() As Single

    Private Sub btn_esci_Click(sender As Object, e As EventArgs) Handles btn_esci.Click
        End
    End Sub

    Private Sub btn_carica_Click(sender As Object, e As EventArgs) Handles btn_carica.Click
        n = Val(InputBox("numero di elementi da elaborare", "input"))
        ReDim v(n - 1)
        Carica(v, n)
    End Sub

    Private Sub Carica(ByRef a() As Single, ByVal b As Byte)
        Dim i As Byte

        For i = 0 To b - 1
            a(i) = InputBox("inserire il dato n°" & CStr(i + 1), "caricamento array")
            lst_numeri.Items.Add(a(i))
        Next i

    End Sub

    Private Sub bttn_visualizza_Click(sender As Object, e As EventArgs) Handles bttn_visualizza.Click
        visualizza(v, n)
    End Sub

    Private Sub visualizza(ByRef a() As Single, ByVal b As Byte)
        Dim i As Byte
        Dim j As Byte

        For i = 0 To b - 1
            If a(i) Mod j = 0 Then
                lst_numeriPrimi.Items.Add(a(i))
            End If
        Next
    End Sub

    Private Sub btn_visualizzaPrimi_Click(sender As Object, e As EventArgs) Handles btn_visualizzaPrimi.Click
        visualizza(v, n)
    End Sub
End Class
