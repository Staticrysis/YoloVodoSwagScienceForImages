Public Module GlobalSettingAggregate
    Dim Conversion As New ConversionSettings
    Dim General As New GeneralSettings
End Module

Public Class ConversionSettings
    Public Property ContrastLimit As Integer = 15
    Public Property ContrastParemiterCheck As Integer = 1
    Public Property ContrastBackColor As Color = Color.White
    Public Property ConstastOutline As Color = Color.Red
End Class

Public Class GeneralSettings
    Public Property SavePath As String
    Public Property OpenPath As String
End Class
