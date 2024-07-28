<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainVodoView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainVodoView))
        Me.OpenImageFile_FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.BS_Settings = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbTreeView = New System.Windows.Forms.GroupBox()
        Me.TS_TreeView = New System.Windows.Forms.ToolStrip()
        Me.OpenFileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenImage_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ConvertToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.SelectedPicture_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ImageDisplay_TabControl = New System.Windows.Forms.TabControl()
        Me.Original_TabPage = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Splitter7 = New System.Windows.Forms.Splitter()
        Me.Splitter6 = New System.Windows.Forms.Splitter()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Splitter5 = New System.Windows.Forms.Splitter()
        Me.Original_PB = New System.Windows.Forms.PictureBox()
        Me.Original_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Contrast_ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Contrast_ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContrastOutlineColor_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContrastBackColor_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ContrastOverlay_TabPage = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.Splitter3 = New System.Windows.Forms.Splitter()
        Me.Splitter4 = New System.Windows.Forms.Splitter()
        Me.Splitter8 = New System.Windows.Forms.Splitter()
        Me.Splitter9 = New System.Windows.Forms.Splitter()
        Me.ContrastOverlay_PB = New System.Windows.Forms.PictureBox()
        Me.PixalDiffContrast_TabPage = New System.Windows.Forms.TabPage()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        Me.Splitter10 = New System.Windows.Forms.Splitter()
        Me.Splitter11 = New System.Windows.Forms.Splitter()
        Me.Splitter12 = New System.Windows.Forms.Splitter()
        Me.Splitter13 = New System.Windows.Forms.Splitter()
        Me.PixalDiffernceContrast_PB = New System.Windows.Forms.PictureBox()
        Me.SaveImage_FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.General_ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.Root_ITV = New YoloVodoSwagScienceForImages.InhancedTreeView()
        CType(Me.BS_Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTreeView.SuspendLayout()
        Me.TS_TreeView.SuspendLayout()
        Me.SelectedPicture_GroupBox.SuspendLayout()
        Me.ImageDisplay_TabControl.SuspendLayout()
        Me.Original_TabPage.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.Original_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Original_ToolStrip.SuspendLayout()
        Me.ContrastOverlay_TabPage.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.ContrastOverlay_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PixalDiffContrast_TabPage.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        CType(Me.PixalDiffernceContrast_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenImageFile_FolderBrowserDialog
        '
        Me.OpenImageFile_FolderBrowserDialog.SelectedPath = """C:\Users\Staticrysis\Desktop\TestImage"""
        '
        'gbTreeView
        '
        Me.gbTreeView.Controls.Add(Me.Root_ITV)
        Me.gbTreeView.Controls.Add(Me.TS_TreeView)
        Me.gbTreeView.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbTreeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbTreeView.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.gbTreeView.Location = New System.Drawing.Point(0, 0)
        Me.gbTreeView.Name = "gbTreeView"
        Me.gbTreeView.Size = New System.Drawing.Size(279, 452)
        Me.gbTreeView.TabIndex = 6
        Me.gbTreeView.TabStop = False
        Me.gbTreeView.Text = "TreeView"
        '
        'TS_TreeView
        '
        Me.TS_TreeView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripButton, Me.OpenImage_ToolStripButton, Me.SaveToolStripButton, Me.ConvertToolStripButton})
        Me.TS_TreeView.Location = New System.Drawing.Point(3, 16)
        Me.TS_TreeView.Name = "TS_TreeView"
        Me.TS_TreeView.Size = New System.Drawing.Size(273, 25)
        Me.TS_TreeView.TabIndex = 21
        Me.TS_TreeView.Text = "ToolStrip1"
        '
        'OpenFileToolStripButton
        '
        Me.OpenFileToolStripButton.Image = CType(resources.GetObject("OpenFileToolStripButton.Image"), System.Drawing.Image)
        Me.OpenFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenFileToolStripButton.Name = "OpenFileToolStripButton"
        Me.OpenFileToolStripButton.Size = New System.Drawing.Size(77, 22)
        Me.OpenFileToolStripButton.Text = "Open &File"
        '
        'OpenImage_ToolStripButton
        '
        Me.OpenImage_ToolStripButton.Image = CType(resources.GetObject("OpenImage_ToolStripButton.Image"), System.Drawing.Image)
        Me.OpenImage_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenImage_ToolStripButton.Name = "OpenImage_ToolStripButton"
        Me.OpenImage_ToolStripButton.Size = New System.Drawing.Size(56, 22)
        Me.OpenImage_ToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'ConvertToolStripButton
        '
        Me.ConvertToolStripButton.Image = CType(resources.GetObject("ConvertToolStripButton.Image"), System.Drawing.Image)
        Me.ConvertToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConvertToolStripButton.Name = "ConvertToolStripButton"
        Me.ConvertToolStripButton.Size = New System.Drawing.Size(69, 22)
        Me.ConvertToolStripButton.Text = "&Convert"
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.Color.White
        Me.Splitter2.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.Splitter2.Location = New System.Drawing.Point(279, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Splitter2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter2.Size = New System.Drawing.Size(5, 452)
        Me.Splitter2.TabIndex = 35
        Me.Splitter2.TabStop = False
        '
        'SelectedPicture_GroupBox
        '
        Me.SelectedPicture_GroupBox.Controls.Add(Me.ImageDisplay_TabControl)
        Me.SelectedPicture_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectedPicture_GroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SelectedPicture_GroupBox.Location = New System.Drawing.Point(284, 0)
        Me.SelectedPicture_GroupBox.Name = "SelectedPicture_GroupBox"
        Me.SelectedPicture_GroupBox.Size = New System.Drawing.Size(576, 452)
        Me.SelectedPicture_GroupBox.TabIndex = 36
        Me.SelectedPicture_GroupBox.TabStop = False
        Me.SelectedPicture_GroupBox.Text = "Selected Picture"
        '
        'ImageDisplay_TabControl
        '
        Me.ImageDisplay_TabControl.Controls.Add(Me.Original_TabPage)
        Me.ImageDisplay_TabControl.Controls.Add(Me.ContrastOverlay_TabPage)
        Me.ImageDisplay_TabControl.Controls.Add(Me.PixalDiffContrast_TabPage)
        Me.ImageDisplay_TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageDisplay_TabControl.Location = New System.Drawing.Point(3, 16)
        Me.ImageDisplay_TabControl.Name = "ImageDisplay_TabControl"
        Me.ImageDisplay_TabControl.SelectedIndex = 0
        Me.ImageDisplay_TabControl.Size = New System.Drawing.Size(570, 433)
        Me.ImageDisplay_TabControl.TabIndex = 0
        '
        'Original_TabPage
        '
        Me.Original_TabPage.Controls.Add(Me.ToolStripContainer1)
        Me.Original_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.Original_TabPage.Name = "Original_TabPage"
        Me.Original_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.Original_TabPage.Size = New System.Drawing.Size(562, 407)
        Me.Original_TabPage.TabIndex = 0
        Me.Original_TabPage.Text = "Original"
        Me.Original_TabPage.UseVisualStyleBackColor = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Splitter7)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Splitter6)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Splitter1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Splitter5)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Original_PB)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(556, 376)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(556, 401)
        Me.ToolStripContainer1.TabIndex = 30
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.Original_ToolStrip)
        '
        'Splitter7
        '
        Me.Splitter7.BackColor = System.Drawing.Color.Black
        Me.Splitter7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter7.Location = New System.Drawing.Point(5, 0)
        Me.Splitter7.Name = "Splitter7"
        Me.Splitter7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter7.Size = New System.Drawing.Size(546, 5)
        Me.Splitter7.TabIndex = 23
        Me.Splitter7.TabStop = False
        '
        'Splitter6
        '
        Me.Splitter6.BackColor = System.Drawing.Color.Black
        Me.Splitter6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter6.Location = New System.Drawing.Point(5, 371)
        Me.Splitter6.Name = "Splitter6"
        Me.Splitter6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter6.Size = New System.Drawing.Size(546, 5)
        Me.Splitter6.TabIndex = 22
        Me.Splitter6.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Black
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter1.Size = New System.Drawing.Size(5, 376)
        Me.Splitter1.TabIndex = 21
        Me.Splitter1.TabStop = False
        '
        'Splitter5
        '
        Me.Splitter5.BackColor = System.Drawing.Color.Black
        Me.Splitter5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter5.Location = New System.Drawing.Point(551, 0)
        Me.Splitter5.Name = "Splitter5"
        Me.Splitter5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter5.Size = New System.Drawing.Size(5, 376)
        Me.Splitter5.TabIndex = 20
        Me.Splitter5.TabStop = False
        '
        'Original_PB
        '
        Me.Original_PB.BackColor = System.Drawing.Color.White
        Me.Original_PB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Original_PB.Location = New System.Drawing.Point(0, 0)
        Me.Original_PB.Name = "Original_PB"
        Me.Original_PB.Size = New System.Drawing.Size(556, 376)
        Me.Original_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Original_PB.TabIndex = 1
        Me.Original_PB.TabStop = False
        '
        'Original_ToolStrip
        '
        Me.Original_ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Original_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Contrast_ToolStripLabel, Me.Contrast_ToolStripTextBox, Me.ToolStripSeparator1, Me.ContrastOutlineColor_ToolStripButton, Me.ToolStripSeparator2, Me.ContrastBackColor_ToolStripButton})
        Me.Original_ToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.Original_ToolStrip.Name = "Original_ToolStrip"
        Me.Original_ToolStrip.Size = New System.Drawing.Size(492, 25)
        Me.Original_ToolStrip.TabIndex = 1
        '
        'Contrast_ToolStripLabel
        '
        Me.Contrast_ToolStripLabel.Name = "Contrast_ToolStripLabel"
        Me.Contrast_ToolStripLabel.Size = New System.Drawing.Size(88, 22)
        Me.Contrast_ToolStripLabel.Text = "Conrast Limiter"
        '
        'Contrast_ToolStripTextBox
        '
        Me.Contrast_ToolStripTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Contrast_ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Contrast_ToolStripTextBox.Name = "Contrast_ToolStripTextBox"
        Me.Contrast_ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        Me.Contrast_ToolStripTextBox.Text = "10"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ContrastOutlineColor_ToolStripButton
        '
        Me.ContrastOutlineColor_ToolStripButton.Image = CType(resources.GetObject("ContrastOutlineColor_ToolStripButton.Image"), System.Drawing.Image)
        Me.ContrastOutlineColor_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ContrastOutlineColor_ToolStripButton.Name = "ContrastOutlineColor_ToolStripButton"
        Me.ContrastOutlineColor_ToolStripButton.Size = New System.Drawing.Size(146, 22)
        Me.ContrastOutlineColor_ToolStripButton.Text = "Contrast Outline Color"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ContrastBackColor_ToolStripButton
        '
        Me.ContrastBackColor_ToolStripButton.Image = CType(resources.GetObject("ContrastBackColor_ToolStripButton.Image"), System.Drawing.Image)
        Me.ContrastBackColor_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ContrastBackColor_ToolStripButton.Name = "ContrastBackColor_ToolStripButton"
        Me.ContrastBackColor_ToolStripButton.Size = New System.Drawing.Size(132, 22)
        Me.ContrastBackColor_ToolStripButton.Text = "Contrast Back Color"
        '
        'ContrastOverlay_TabPage
        '
        Me.ContrastOverlay_TabPage.Controls.Add(Me.ToolStripContainer2)
        Me.ContrastOverlay_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.ContrastOverlay_TabPage.Name = "ContrastOverlay_TabPage"
        Me.ContrastOverlay_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ContrastOverlay_TabPage.Size = New System.Drawing.Size(562, 407)
        Me.ContrastOverlay_TabPage.TabIndex = 1
        Me.ContrastOverlay_TabPage.Text = "Contrast Overlay"
        Me.ContrastOverlay_TabPage.UseVisualStyleBackColor = True
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Splitter3)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Splitter4)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Splitter8)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Splitter9)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.ContrastOverlay_PB)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(556, 376)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(556, 401)
        Me.ToolStripContainer2.TabIndex = 30
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'Splitter3
        '
        Me.Splitter3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Splitter3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter3.Location = New System.Drawing.Point(5, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter3.Size = New System.Drawing.Size(546, 5)
        Me.Splitter3.TabIndex = 23
        Me.Splitter3.TabStop = False
        '
        'Splitter4
        '
        Me.Splitter4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Splitter4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter4.Location = New System.Drawing.Point(5, 371)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter4.Size = New System.Drawing.Size(546, 5)
        Me.Splitter4.TabIndex = 22
        Me.Splitter4.TabStop = False
        '
        'Splitter8
        '
        Me.Splitter8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Splitter8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter8.Location = New System.Drawing.Point(0, 0)
        Me.Splitter8.Name = "Splitter8"
        Me.Splitter8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter8.Size = New System.Drawing.Size(5, 376)
        Me.Splitter8.TabIndex = 21
        Me.Splitter8.TabStop = False
        '
        'Splitter9
        '
        Me.Splitter9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Splitter9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter9.Location = New System.Drawing.Point(551, 0)
        Me.Splitter9.Name = "Splitter9"
        Me.Splitter9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter9.Size = New System.Drawing.Size(5, 376)
        Me.Splitter9.TabIndex = 20
        Me.Splitter9.TabStop = False
        '
        'ContrastOverlay_PB
        '
        Me.ContrastOverlay_PB.BackColor = System.Drawing.Color.White
        Me.ContrastOverlay_PB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContrastOverlay_PB.Location = New System.Drawing.Point(0, 0)
        Me.ContrastOverlay_PB.Name = "ContrastOverlay_PB"
        Me.ContrastOverlay_PB.Size = New System.Drawing.Size(556, 376)
        Me.ContrastOverlay_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ContrastOverlay_PB.TabIndex = 1
        Me.ContrastOverlay_PB.TabStop = False
        '
        'PixalDiffContrast_TabPage
        '
        Me.PixalDiffContrast_TabPage.Controls.Add(Me.ToolStripContainer3)
        Me.PixalDiffContrast_TabPage.Location = New System.Drawing.Point(4, 22)
        Me.PixalDiffContrast_TabPage.Name = "PixalDiffContrast_TabPage"
        Me.PixalDiffContrast_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PixalDiffContrast_TabPage.Size = New System.Drawing.Size(562, 407)
        Me.PixalDiffContrast_TabPage.TabIndex = 2
        Me.PixalDiffContrast_TabPage.Text = "Pixal Differnce Contrast"
        Me.PixalDiffContrast_TabPage.UseVisualStyleBackColor = True
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Splitter10)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Splitter11)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Splitter12)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.Splitter13)
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.PixalDiffernceContrast_PB)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(556, 376)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.Size = New System.Drawing.Size(556, 401)
        Me.ToolStripContainer3.TabIndex = 30
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'Splitter10
        '
        Me.Splitter10.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Splitter10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter10.Location = New System.Drawing.Point(5, 0)
        Me.Splitter10.Name = "Splitter10"
        Me.Splitter10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter10.Size = New System.Drawing.Size(546, 5)
        Me.Splitter10.TabIndex = 23
        Me.Splitter10.TabStop = False
        '
        'Splitter11
        '
        Me.Splitter11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Splitter11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter11.Location = New System.Drawing.Point(5, 371)
        Me.Splitter11.Name = "Splitter11"
        Me.Splitter11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter11.Size = New System.Drawing.Size(546, 5)
        Me.Splitter11.TabIndex = 22
        Me.Splitter11.TabStop = False
        '
        'Splitter12
        '
        Me.Splitter12.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Splitter12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter12.Location = New System.Drawing.Point(0, 0)
        Me.Splitter12.Name = "Splitter12"
        Me.Splitter12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter12.Size = New System.Drawing.Size(5, 376)
        Me.Splitter12.TabIndex = 21
        Me.Splitter12.TabStop = False
        '
        'Splitter13
        '
        Me.Splitter13.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Splitter13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter13.Location = New System.Drawing.Point(551, 0)
        Me.Splitter13.Name = "Splitter13"
        Me.Splitter13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter13.Size = New System.Drawing.Size(5, 376)
        Me.Splitter13.TabIndex = 20
        Me.Splitter13.TabStop = False
        '
        'PixalDiffernceContrast_PB
        '
        Me.PixalDiffernceContrast_PB.BackColor = System.Drawing.Color.White
        Me.PixalDiffernceContrast_PB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PixalDiffernceContrast_PB.Location = New System.Drawing.Point(0, 0)
        Me.PixalDiffernceContrast_PB.Name = "PixalDiffernceContrast_PB"
        Me.PixalDiffernceContrast_PB.Size = New System.Drawing.Size(556, 376)
        Me.PixalDiffernceContrast_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PixalDiffernceContrast_PB.TabIndex = 1
        Me.PixalDiffernceContrast_PB.TabStop = False
        '
        'SaveImage_FolderBrowserDialog
        '
        Me.SaveImage_FolderBrowserDialog.SelectedPath = """C:\Users\Staticrysis\Desktop\TestImage"""
        '
        'General_ColorDialog
        '
        Me.General_ColorDialog.AnyColor = True
        Me.General_ColorDialog.Color = System.Drawing.Color.White
        Me.General_ColorDialog.FullOpen = True
        '
        'Root_ITV
        '
        Me.Root_ITV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Root_ITV.ImageIndex = 0
        Me.Root_ITV.Location = New System.Drawing.Point(3, 41)
        Me.Root_ITV.Name = "Root_ITV"
        Me.Root_ITV.SelectedImageIndex = 0
        Me.Root_ITV.Size = New System.Drawing.Size(273, 408)
        Me.Root_ITV.TabIndex = 34
        '
        'MainVodoView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(860, 452)
        Me.Controls.Add(Me.SelectedPicture_GroupBox)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.gbTreeView)
        Me.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Name = "MainVodoView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainVodoView"
        CType(Me.BS_Settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTreeView.ResumeLayout(False)
        Me.gbTreeView.PerformLayout()
        Me.TS_TreeView.ResumeLayout(False)
        Me.TS_TreeView.PerformLayout()
        Me.SelectedPicture_GroupBox.ResumeLayout(False)
        Me.ImageDisplay_TabControl.ResumeLayout(False)
        Me.Original_TabPage.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.Original_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Original_ToolStrip.ResumeLayout(False)
        Me.Original_ToolStrip.PerformLayout()
        Me.ContrastOverlay_TabPage.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.ContrastOverlay_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PixalDiffContrast_TabPage.ResumeLayout(False)
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        CType(Me.PixalDiffernceContrast_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenImageFile_FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents BS_Settings As BindingSource
    Friend WithEvents gbTreeView As GroupBox
    Friend WithEvents TS_TreeView As ToolStrip
    Friend WithEvents OpenFileToolStripButton As ToolStripButton
    Friend WithEvents ConvertToolStripButton As ToolStripButton
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents SelectedPicture_GroupBox As GroupBox
    Friend WithEvents Root_ITV As InhancedTreeView
    Friend WithEvents ImageDisplay_TabControl As TabControl
    Friend WithEvents Original_TabPage As TabPage
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Splitter7 As Splitter
    Friend WithEvents Splitter6 As Splitter
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Splitter5 As Splitter
    Friend WithEvents Original_PB As PictureBox
    Friend WithEvents Original_ToolStrip As ToolStrip
    Friend WithEvents Contrast_ToolStripLabel As ToolStripLabel
    Friend WithEvents Contrast_ToolStripTextBox As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ContrastOverlay_TabPage As TabPage
    Friend WithEvents ToolStripContainer2 As ToolStripContainer
    Friend WithEvents Splitter3 As Splitter
    Friend WithEvents Splitter4 As Splitter
    Friend WithEvents Splitter8 As Splitter
    Friend WithEvents Splitter9 As Splitter
    Friend WithEvents ContrastOverlay_PB As PictureBox
    Friend WithEvents PixalDiffContrast_TabPage As TabPage
    Friend WithEvents ToolStripContainer3 As ToolStripContainer
    Friend WithEvents Splitter10 As Splitter
    Friend WithEvents Splitter11 As Splitter
    Friend WithEvents Splitter12 As Splitter
    Friend WithEvents Splitter13 As Splitter
    Friend WithEvents PixalDiffernceContrast_PB As PictureBox
    Friend WithEvents SaveImage_FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents General_ColorDialog As ColorDialog
    Friend WithEvents ContrastOutlineColor_ToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ContrastBackColor_ToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents OpenImage_ToolStripButton As ToolStripButton
End Class
