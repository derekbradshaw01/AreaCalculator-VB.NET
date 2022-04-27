Public Class clsShape
    'Instance (message) variables 
    Dim m_base, m_height, m_diameter As Single

    Public Property Base() As Single
        Get
            Return m_base
        End Get
        Set(ByVal value As Single)
            m_base = value
        End Set
    End Property

    Public Property Height() As Single
        Get
            Return m_height
        End Get
        Set(ByVal value As Single)
            m_height = value
        End Set
    End Property

    Public Property Diameter() As Single
        Get
            Return m_diameter
        End Get
        Set(ByVal value As Single)
            m_diameter = value
        End Set
    End Property
End Class