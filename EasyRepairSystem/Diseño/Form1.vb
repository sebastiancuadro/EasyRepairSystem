Public Class Form1

    Dim p As New Cliente
    Dim l As New logica
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        p.cedula = TextBox1.Text
        p.Nombre = TextBox2.Text
        p.Apellido = TextBox3.Text
        p.USUARIO = TextBox4.Text
        p.PASSWORD = TextBox5.Text


        MsgBox(l.AgregarPersona(p))

    End Sub
End Class
