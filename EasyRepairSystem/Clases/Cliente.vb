Public Class Cliente
    Private _nombre As String
    Private _apellido As String
    Private _cedula As Integer
    Private _usuario As String
    Private _password As String
    Private _orden As New Orden

    Public Property ORden As Orden
        Get
            Return _orden
        End Get
        Set(ByVal value As Orden)
            _orden = value
        End Set
    End Property


    Public Property Nombre As String
        Get
            Return _nombre

        End Get
        Set(ByVal value As String)
            _nombre = value

        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido

        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property
    Public Property cedula As Integer
        Get
            Return _cedula

        End Get
        Set(ByVal value As Integer)
            _cedula = value
        End Set
    End Property


    Public Property USUARIO As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property PASSWORD As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value

        End Set
    End Property

    Public Sub New()

    End Sub

End Class
