Public Class logica
    Dim D As New Datos
    Public Function AgregarPersona(ByVal P As Cliente) As String
        Dim Paux = D.BuscarPersona(P.cedula)

        If Paux.cedula = P.cedula Then
            Return "Ya existe"
        Else
            Dim Resultado As Integer
            Resultado = D.AgregarPersona(P)
            If Resultado = 1 Then
                Return "se guardo "
            Else
                Return "no se guardo"
            End If
        End If

    End Function

    Public Function BorrarPersona(ByVal P) As String
        Dim resultado = D.BorrarPersona(P)
        If resultado = 1 Then
            Return "Se borro"
        Else
            Return "No se Borro"
        End If
    End Function
    Public Sub New()

    End Sub
End Class
