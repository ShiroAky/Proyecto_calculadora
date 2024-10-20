Public Class Calculadora

    ' Estas son las variables que se utilizarán en la calculadora
    Private operacion As String = ""
    Private primer_numero As Double = 0
    Private segundo_numero As Double = 0

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' En esta parte no ponemos nada, pero se mantiene para que no se borre el evento
    End Sub

    ' Este es el evento que detecta cuando se presiona un botón de la calculadora
    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Numero0.Click, Numero1.Click, Numero2.Click, Numero3.Click, Numero4.Click, Numero5.Click, Numero6.Click, Numero7.Click, Numero8.Click, Numero9.Click
        Dim Numero As Button = CType(sender, Button)
        If operaciones.Text = "0" Then
            operaciones.Text = Numero.Text
        Else
            operaciones.Text &= Numero.Text
        End If
    End Sub

    ' Este es el evento que detecta cuando se presiona un botón de operación
    Private Sub Operacion_Click(sender As Object, e As EventArgs) Handles Signo_division.Click, Signo_multiplicacion.Click, Signo_resta.Click, Signo_suma.Click
        Dim Numero As Button = CType(sender, Button)
        primer_numero = Double.Parse(operaciones.Text)
        operacion = Numero.Text
        operaciones.Text = "0"
    End Sub

    ' Este es el evento que detecta cuando se presiona el botón de igual
    Private Sub Boton_Igual(sender As Object, e As EventArgs) Handles Signo_igual.Click
        segundo_numero = Double.Parse(operaciones.Text)
        Select Case operacion
            Case "+"
                operaciones.Text = (primer_numero + segundo_numero).ToString()
            Case "-"
                operaciones.Text = (primer_numero - segundo_numero).ToString()
            Case "*"
                operaciones.Text = (primer_numero * segundo_numero).ToString()
            Case "/"
                If segundo_numero <> 0 Then
                    operaciones.Text = (primer_numero / segundo_numero).ToString()
                Else
                    operaciones.Text = "Error"
                End If
        End Select
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        operaciones.Text = "0"
        primer_numero = 0
        segundo_numero = 0
        operacion = ""
    End Sub
End Class
