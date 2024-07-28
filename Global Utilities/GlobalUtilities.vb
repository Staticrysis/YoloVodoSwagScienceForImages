Module GlobalUtilities
    Function GetPathName(ByVal path As String)
        Dim iStart = CInt(path.LastIndexOf("\") + 1)
        Dim iEnd = CInt(path.IndexOf("."))
        Dim subStr = CType(path.Substring(iStart, iEnd - iStart), String)

        Return subStr
    End Function

    Function GetCustomBitmap(w As Integer, h As Integer, backColor As Color) As Bitmap
        Dim Bmp As New Bitmap(w, h)
        Using gfx As Graphics = Graphics.FromImage(Bmp)
            Using brush As New SolidBrush(backColor)
                gfx.FillRectangle(brush, 0, 0, w, h)
            End Using
        End Using

        Return Bmp
    End Function


    Async Function RunThreadedMethod(methodName As String, obj As Object, ParameterArray As Object(), Optional RunMultiThreads As Boolean = False) As Task(Of Object)
        Dim LogicalProcessorCount = Environment.ProcessorCount
        Dim cancelation As New Threading.CancellationToken

        Return Await Task.Run(Of Object)(Function()
                                             Return obj.GetType.GetMethod(methodName).Invoke(obj, ParameterArray)
                                         End Function)
    End Function
End Module
