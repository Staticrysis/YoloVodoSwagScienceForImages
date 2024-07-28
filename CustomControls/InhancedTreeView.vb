Public Class InhancedTreeView
    Inherits TreeView
    'Root number, Root Image, List of sub image numbers
    'Dim DictionaryRootImages As New Dictionary(Of Integer, Tuple(Of Image, List(Of Integer)))
    Public Property MyImageList As New ImageList() With {.ImageSize = New Size(32, 32)}
    Private Delegate Sub ImageNodeClickedDel()
    Public Event ImageNodeCliced()

    Public Sub New()
        Me.ImageList = MyImageList
    End Sub

    Public Function PopulateRootImages(path As String) As Boolean
        If Not IO.File.Exists(path) Then
            DisposeImages()
            Dim Paths = System.IO.Directory.GetFiles(path)

            For i As Integer = 0 To Paths.Count - 1 Step 1
                If Paths(i).Contains(".png") Or Paths(i).Contains(".jpg") Then
                    Dim PathName = GetPathName(Paths(i))
                    Dim currImage = Image.FromFile(Paths(i))
                    ' WriteLine(PathName)


                    Dim Node As New InhancedTreeNode(currImage, Paths(i), PathName, PathName, i, i)
                    MyImageList.Images.Add(i, currImage)
                    Me.Nodes.Add(Node)
                End If
            Next
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub DisposeImages()
        MyImageList.Images.Clear()
        Me.Nodes.Clear()
    End Sub
End Class
