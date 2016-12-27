Public Class Empleado
    Private _nombre, _apellido, _tipoDocumento, _sexo, _direccion, _email, _login, _pass, _tipoUsuario, _estado As String
    Private _idUsuario, _numDocumento, _telefono As Integer


    Public Property idUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(Value As Integer)
            _idUsuario = Value
        End Set
    End Property
    Public Property numDocumento As Integer
        Get
            Return _numDocumento
        End Get
        Set(Value As Integer)
            _numDocumento = Value
        End Set
    End Property

    Public Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set(Value As Integer)
            _telefono = Value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(Value As String)
            _nombre = Value
        End Set
    End Property
    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(Value As String)
            _apellido = Value
        End Set
    End Property
    Public Property tipoDocumento As String
        Get
            Return _tipoDocumento
        End Get
        Set(Value As String)
            _tipoDocumento = Value
        End Set
    End Property
    Public Property sexo As String
        Get
            Return _sexo
        End Get
        Set(Value As String)
            _sexo = Value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(Value As String)
            _direccion = Value
        End Set
    End Property
    Public Property email As String
        Get
            Return _email
        End Get
        Set(Value As String)
            _email = Value
        End Set
    End Property
    Public Property login As String
        Get
            Return _login
        End Get
        Set(Value As String)
            _login = Value
        End Set
    End Property
    Public Property pass As String
        Get
            Return _pass
        End Get
        Set(Value As String)
            _pass = Value
        End Set
    End Property
    Public Property tipoUsuario As String
        Get
            Return _tipoUsuario
        End Get
        Set(Value As String)
            _tipoUsuario = Value
        End Set
    End Property
    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(Value As String)
            _estado = Value
        End Set
    End Property
    Public Sub New()
    End Sub

    Public Sub New(idUsuario As Integer, Nombre As String, Apellidos As String, tipoDocumento As String, numDocumento As Integer, sexo As String, Direccion As String, telefono As Integer, email As String, login As String, password As String, tipoUsuario As String, estado As String)

        _idUsuario = idUsuario
        _nombre = nombre
        _apellido = Apellidos
        _tipoDocumento = tipoDocumento
        _numDocumento = numDocumento
        _sexo = sexo
        _direccion = Direccion
        _telefono = telefono
        _email = email
        _login = login
        _pass = password
        _tipoUsuario = tipoUsuario
        _estado = estado
    End Sub

End Class
