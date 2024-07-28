Module ConversionTools
    'Public Async Function ImageStatsAsync(rootImage As Bitmap, cancelToken As Threading.CancellationToken, Optional ContrastThreshold As Integer = 25, Optional adjacentPixalCheck As Integer = 1) As Task(Of Tuple(Of Bitmap, Bitmap, Bitmap, Double(,)))
    Public Function ImageStatsAsync(rootImage As Bitmap, cancelToken As Threading.CancellationToken, Optional ContrastThreshold As Integer = 25, Optional adjacentPixalCheck As Integer = 1) As Tuple(Of Bitmap, Bitmap, Bitmap, Double(,))
        ' Return Await Task.Run(Of Tuple(Of Bitmap, Bitmap, Bitmap, Double(,)))(

        Dim contrastOverlay As Bitmap = rootImage.Clone
        Dim contrastImage = GetCustomBitmap(rootImage.Width, rootImage.Height, My.Settings.ContrastBackColor)
        Dim contrastMap(rootImage.Width, rootImage.Height) As Double

        Dim h As Integer = rootImage.Height
        Dim w As Integer = rootImage.Width

        For x As Integer = 1 To w - 2
            For y As Integer = 1 To h - 2
                If IsHighColorContrast(rootImage, x, y, ContrastThreshold) Then
                    contrastOverlay.SetPixel(x, y, My.Settings.ContrastOutline)
                    contrastImage.SetPixel(x, y, My.Settings.ContrastOutline)
                End If
            Next
        Next

        Return Tuple.Create(rootImage, contrastOverlay, contrastImage, contrastMap)
        'End Function, cancelToken)
    End Function

    Dim span = 1 'More then one will greatly reduce performance
    Private Function IsHighColorContrast(ByRef Image As Bitmap, ByRef x As Integer, ByRef y As Integer, ByRef ContrastThreshold As Double) As Boolean
        For xIndex As Integer = -span To span
            For yIndex As Integer = -span To span
                If GetColorContrast(Image.GetPixel(x, y), Image.GetPixel(xIndex + x, yIndex + y)) > ContrastThreshold Then Return True
            Next
        Next
        Return False
    End Function

    Private Function GetColorContrast(ByRef respectedColor As Color, ByRef offColor As Color) As Double
        Return _
    ((respectedColor.R * 0.3) - (offColor.R * 0.3) +
    (respectedColor.G * 0.59) - (offColor.G * 0.59) +
    (respectedColor.B * 0.11) - (offColor.B * 0.11)) * 100 / 256
    End Function
End Module
