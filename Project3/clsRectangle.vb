Public Class clsRectangle
    Inherits clsShape

    Public Function Area(ByVal Base As Single, Height As Single) As Single
        Return Base * Height
    End Function

    Public Function centx(Base) As Single
        Return (1 / 2) * Base
    End Function

    Public Function centy(Height) As Single
        Return (1 / 2) * Height
    End Function

End Class