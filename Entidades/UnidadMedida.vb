Public Class UnidadMedida
    Dim _idUnidadMedida As Integer
    Dim _nombre, _estado As String

    Public Property idUnidadMedida As Integer
        Get
            Return _idUnidadMedida
        End Get
        Set(value As Integer)
            _idUnidadMedida = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(idUnidadMedida As Integer, Nombre As String, estado As String)
        _idUnidadMedida = idUnidadMedida
        _nombre = Nombre
        _estado = estado
    End Sub
End Class
