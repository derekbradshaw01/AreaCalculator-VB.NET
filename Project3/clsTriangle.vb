Public Class clsTriangle
    Inherits clsShape

    Public Function Area(ByVal Base As Single, Height As Single) As Single
        Return (Base * Height) / 2
    End Function

    Public Function centx(Base) As Single
        Return Base / 3
    End Function

    Public Function centy(Height) As Single
        Return Height / 3
    End Function

End Class