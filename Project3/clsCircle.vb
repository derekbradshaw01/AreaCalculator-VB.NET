Public Class clsCircle
    Inherits clsShape

    Public Function Area(ByVal Diameter As Single) As Single
        Return Math.PI * (Math.Pow(Diameter / 2, 2))
    End Function

    Public Function centx(Diameter) As Single
        Return (1 / 2) * Diameter
    End Function

    Public Function centy(Diameter) As Single
        Return (1 / 2) * Diameter
    End Function

End Class