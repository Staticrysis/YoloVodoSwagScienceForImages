Public Class MainVodoView
    'Dim bitImage As Bitmap = Image.FromFile("C:\Users\Staticrysis\Desktop\TestImage\15156.png")
    Dim bitImage As Bitmap '= Image.FromFile("C:\Users\Staticrysis\Desktop\TestImage\4292.jpg")
    Dim convertedImage As Bitmap
    Dim PosativeContrast As Bitmap
    Dim NegativeContrast As Bitmap
    Dim fd As New OpenFileDialog With {.InitialDirectory = "C:\Users\Staticrysis\Desktop\TestImage"}
    Dim ContrastLimit As Integer = 45
    Dim ContrastMap As Double()()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        InitializeGlobalSettings()

        ' Add any initialization after the InitializeComponent() call.
        PostComponentInitialization()
        LoadComponent()
    End Sub

    Private Sub InitializeGlobalSettings()
        With My.Settings
            If .GlobalColorDialog Is Nothing Then .GlobalColorDialog = New ColorDialog With {.FullOpen = True, .AnyColor = True}
        End With
    End Sub

    Private Sub PostComponentInitialization()
        ContrastOutlineColor_ToolStripButton.Image = GetCustomBitmap(ContrastOutlineColor_ToolStripButton.Image.Width, ContrastOutlineColor_ToolStripButton.Image.Height, My.Settings.ContrastOutline)
        ContrastBackColor_ToolStripButton.Image = GetCustomBitmap(ContrastBackColor_ToolStripButton.Image.Width, ContrastBackColor_ToolStripButton.Image.Height, My.Settings.ContrastBackColor)
    End Sub

    Private Sub LoadComponent()
        LoadImages(Nothing, Nothing, True)
    End Sub

    Private Sub LoadImages(Optional obj As Object = Nothing, Optional e As EventArgs = Nothing, Optional IsFromInitialization As Boolean = False) Handles OpenFileToolStripButton.Click
        Try
            If IsFromInitialization AndAlso Not String.IsNullOrEmpty(My.Settings.OpenPath) Then
                If Not Root_ITV.PopulateRootImages(My.Settings.OpenPath) Then MsgBox("Unable to load images from " & My.Settings.OpenPath & ".")
            Else
                If OpenImageFile_FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
                    My.Settings.OpenPath = OpenImageFile_FolderBrowserDialog.SelectedPath
                    If Not Root_ITV.PopulateRootImages(My.Settings.OpenPath) Then MsgBox("Unable to load images from " & My.Settings.OpenPath & ".")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RootImage_TV_NodeMouseClick(sender As InhancedTreeView, e As TreeNodeMouseClickEventArgs) Handles Root_ITV.NodeMouseClick
        Original_PB.Image = DirectCast(e.Node, InhancedTreeNode).OriginalImage
    End Sub

    Private Sub ConvertImage(sender As Object, e As EventArgs) Handles ConvertToolStripButton.Click
        Dim InhNode = CType(Root_ITV.SelectedNode, InhancedTreeNode)
        Dim stats = ConversionTools.ImageStatsAsync(InhNode.OriginalImage, InhNode.CancelConversion, Integer.Parse(Contrast_ToolStripTextBox.Text))

        InhNode.ContrastOverlayImage = stats.Item2
        InhNode.PixalContrastImage = stats.Item3
        InhNode.ContrastMap = stats.Item4

        ContrastOverlay_PB.Image = stats.Item2
        PixalDiffernceContrast_PB.Image = stats.Item3
    End Sub

    Private Sub Root_ITV_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Root_ITV.AfterSelect
        Dim InhNode = DirectCast(e.Node, InhancedTreeNode)
        Original_PB.Image = InhNode.OriginalImage
        ContrastOverlay_PB.Image = InhNode.ContrastOverlayImage
        PixalDiffernceContrast_PB.Image = InhNode.PixalContrastImage
    End Sub

    Private Sub SelectBackColor_ToolStripButton1_Click(sender As ToolStripButton, e As EventArgs) Handles ContrastBackColor_ToolStripButton.Click
        If My.Settings.GlobalColorDialog.ShowDialog() = DialogResult.OK Then sender.Image = GetCustomBitmap(sender.Image.Size.Width, sender.Image.Size.Height, My.Settings.GlobalColorDialog.Color) : My.Settings.ContrastBackColor = My.Settings.GlobalColorDialog.Color
    End Sub

    Private Sub ContrastOutlineColor_ToolStripButton_Click(sender As Object, e As EventArgs) Handles ContrastOutlineColor_ToolStripButton.Click
        If My.Settings.GlobalColorDialog.ShowDialog() = DialogResult.OK Then sender.Image = GetCustomBitmap(sender.Image.Size.Width, sender.Image.Size.Height, My.Settings.GlobalColorDialog.Color) : My.Settings.ContrastOutline = My.Settings.GlobalColorDialog.Color
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            If SaveImage_FolderBrowserDialog.ShowDialog = vbOK Then
                My.Settings.SavePath = SaveImage_FolderBrowserDialog.SelectedPath
                Select Case (ImageDisplay_TabControl.SelectedIndex)
                    Case 0 : Exit Sub 'Original_PB.Image.Save(My.Settings.SavePath & "\" & Date.Now.ToString("yyyyMMdd_hhmmss") & ".png")
                    Case 1 : ContrastOverlay_PB.Image.Save(My.Settings.SavePath & "\" & Date.Now.ToString("yyyyMMdd_hhmmss") & ".png")
                    Case 2 : PixalDiffernceContrast_PB.Image.Save(My.Settings.SavePath & "\" & Date.Now.ToString("yyyy-MM-dd_hh-mm-ss") & ".png")
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RootImage_TV_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles Root_ITV.NodeMouseClick

    End Sub
End Class