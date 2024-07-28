Public Class InhancedTreeNode
    Inherits TreeNode

    Public Property CancelConversion As New Threading.CancellationToken(False)

    Public Property OriginalImage As Bitmap
    Public Property ContrastOverlayImage As Bitmap
    Public Property PixalContrastImage As Bitmap
    Public Property ContrastMap()() Double


    Sub New(FullResImage As Image, tag As Object, text As String, name As String, imageIndex As Integer, selectedImageIndex As Integer)
        Dim x = FullResImage.Width
        Dim y = FullResImage.Height

        OriginalImage = FullResImage
        ContrastOverlayImage = New Bitmap(x, y)
        PixalContrastImage = New Bitmap(x, y)

        Me.Tag = tag
        Me.Text = text
        Me.Name = name
        Me.ImageIndex = imageIndex
        Me.SelectedImageIndex = selectedImageIndex
    End Sub
End Class
