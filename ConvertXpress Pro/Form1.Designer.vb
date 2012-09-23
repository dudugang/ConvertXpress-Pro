<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim VisualTip1 As Skybound.VisualTips.VisualTip = New Skybound.VisualTips.VisualTip()
        Dim VisualTip2 As Skybound.VisualTips.VisualTip = New Skybound.VisualTips.VisualTip()
        Dim VisualTip3 As Skybound.VisualTips.VisualTip = New Skybound.VisualTips.VisualTip()
        Dim VisualTip4 As Skybound.VisualTips.VisualTip = New Skybound.VisualTips.VisualTip()
        Dim VisualTip5 As Skybound.VisualTips.VisualTip = New Skybound.VisualTips.VisualTip()
        Dim VisualTipOfficeRenderer1 As Skybound.VisualTips.Rendering.VisualTipOfficeRenderer = New Skybound.VisualTips.Rendering.VisualTipOfficeRenderer()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.MaximiseButton = New System.Windows.Forms.Label()
        Me.MinimiseButton = New System.Windows.Forms.Label()
        Me.FormTitle = New System.Windows.Forms.Label()
        Me.FormMovePanel = New System.Windows.Forms.Panel()
        Me.SettingsButton = New System.Windows.Forms.Label()
        Me.FormMove = New System.Windows.Forms.Timer(Me.components)
        Me.TopGradient = New System.Windows.Forms.Panel()
        Me.tab1 = New System.Windows.Forms.Label()
        Me.subitem1 = New System.Windows.Forms.Label()
        Me.InterfaceContext = New System.Windows.Forms.Panel()
        Me.CloseMenu = New System.Windows.Forms.Label()
        Me.RemoveBookmark = New System.Windows.Forms.Label()
        Me.CopyTitle = New System.Windows.Forms.Label()
        Me.CopyURL = New System.Windows.Forms.Label()
        Me.OpenInNewWindow = New System.Windows.Forms.Label()
        Me.OpenInNewTab = New System.Windows.Forms.Label()
        Me.HoldDown = New System.Windows.Forms.Timer(Me.components)
        Me.ResizeBR = New System.Windows.Forms.Timer(Me.components)
        Me.ResizeBoxBR = New System.Windows.Forms.PictureBox()
        Me.subitem4 = New System.Windows.Forms.Label()
        Me.subitem3 = New System.Windows.Forms.Label()
        Me.subitem2 = New System.Windows.Forms.Label()
        Me.tab4 = New System.Windows.Forms.Label()
        Me.tab3 = New System.Windows.Forms.Label()
        Me.tab2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FileBrowserButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ConvertButton = New System.Windows.Forms.Label()
        Me.VisualTipProvider1 = New Skybound.VisualTips.VisualTipProvider(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ConverterWorker = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FormMovePanel.SuspendLayout()
        Me.InterfaceContext.SuspendLayout()
        CType(Me.ResizeBoxBR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.AutoSize = True
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Silver
        Me.CloseButton.Location = New System.Drawing.Point(586, 1)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(16, 16)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "X"
        '
        'MaximiseButton
        '
        Me.MaximiseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximiseButton.AutoSize = True
        Me.MaximiseButton.BackColor = System.Drawing.Color.Transparent
        Me.MaximiseButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximiseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximiseButton.ForeColor = System.Drawing.Color.Silver
        Me.MaximiseButton.Location = New System.Drawing.Point(571, -5)
        Me.MaximiseButton.Name = "MaximiseButton"
        Me.MaximiseButton.Size = New System.Drawing.Size(21, 24)
        Me.MaximiseButton.TabIndex = 2
        Me.MaximiseButton.Text = "□"
        Me.MaximiseButton.Visible = False
        '
        'MinimiseButton
        '
        Me.MinimiseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimiseButton.AutoSize = True
        Me.MinimiseButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimiseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimiseButton.ForeColor = System.Drawing.Color.Silver
        Me.MinimiseButton.Location = New System.Drawing.Point(572, -1)
        Me.MinimiseButton.Name = "MinimiseButton"
        Me.MinimiseButton.Size = New System.Drawing.Size(15, 16)
        Me.MinimiseButton.TabIndex = 3
        Me.MinimiseButton.Text = "_"
        '
        'FormTitle
        '
        Me.FormTitle.AutoSize = True
        Me.FormTitle.BackColor = System.Drawing.Color.Transparent
        Me.FormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormTitle.ForeColor = System.Drawing.Color.Silver
        Me.FormTitle.Location = New System.Drawing.Point(3, 2)
        Me.FormTitle.Name = "FormTitle"
        Me.FormTitle.Size = New System.Drawing.Size(115, 15)
        Me.FormTitle.TabIndex = 4
        Me.FormTitle.Text = "FORM TITLE HERE"
        '
        'FormMovePanel
        '
        Me.FormMovePanel.BackColor = System.Drawing.Color.Transparent
        Me.FormMovePanel.Controls.Add(Me.MinimiseButton)
        Me.FormMovePanel.Controls.Add(Me.CloseButton)
        Me.FormMovePanel.Controls.Add(Me.MaximiseButton)
        Me.FormMovePanel.Controls.Add(Me.FormTitle)
        Me.FormMovePanel.Controls.Add(Me.SettingsButton)
        Me.FormMovePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel.Location = New System.Drawing.Point(0, 0)
        Me.FormMovePanel.Name = "FormMovePanel"
        Me.FormMovePanel.Size = New System.Drawing.Size(606, 23)
        Me.FormMovePanel.TabIndex = 5
        '
        'SettingsButton
        '
        Me.SettingsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsButton.AutoSize = True
        Me.SettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingsButton.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.ForeColor = System.Drawing.Color.Silver
        Me.SettingsButton.Location = New System.Drawing.Point(517, 6)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(33, 11)
        Me.SettingsButton.TabIndex = 15
        Me.SettingsButton.Text = "ABOUT"
        '
        'FormMove
        '
        Me.FormMove.Interval = 1
        '
        'TopGradient
        '
        Me.TopGradient.BackgroundImage = Global.ConvertXpress_Pro.My.Resources.Resources.BlueGradient
        Me.TopGradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopGradient.Location = New System.Drawing.Point(0, 30)
        Me.TopGradient.Name = "TopGradient"
        Me.TopGradient.Size = New System.Drawing.Size(15, 69)
        Me.TopGradient.TabIndex = 6
        '
        'tab1
        '
        Me.tab1.AutoSize = True
        Me.tab1.BackColor = System.Drawing.Color.Transparent
        Me.tab1.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1.ForeColor = System.Drawing.Color.Black
        Me.tab1.Location = New System.Drawing.Point(21, 30)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(215, 37)
        Me.tab1.TabIndex = 7
        Me.tab1.Text = "convertxpress pro"
        '
        'subitem1
        '
        Me.subitem1.AutoSize = True
        Me.subitem1.BackColor = System.Drawing.Color.Transparent
        Me.subitem1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subitem1.ForeColor = System.Drawing.Color.Silver
        Me.subitem1.Location = New System.Drawing.Point(24, 74)
        Me.subitem1.Name = "subitem1"
        Me.subitem1.Size = New System.Drawing.Size(309, 13)
        Me.subitem1.TabIndex = 11
        Me.subitem1.Text = "CONVERT YOUR FILES TO ANY OTHER SUPPORTED FORMAT."
        '
        'InterfaceContext
        '
        Me.InterfaceContext.BackColor = System.Drawing.Color.White
        Me.InterfaceContext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InterfaceContext.Controls.Add(Me.CloseMenu)
        Me.InterfaceContext.Controls.Add(Me.RemoveBookmark)
        Me.InterfaceContext.Controls.Add(Me.CopyTitle)
        Me.InterfaceContext.Controls.Add(Me.CopyURL)
        Me.InterfaceContext.Controls.Add(Me.OpenInNewWindow)
        Me.InterfaceContext.Controls.Add(Me.OpenInNewTab)
        Me.InterfaceContext.Location = New System.Drawing.Point(23, 364)
        Me.InterfaceContext.Name = "InterfaceContext"
        Me.InterfaceContext.Size = New System.Drawing.Size(150, 10)
        Me.InterfaceContext.TabIndex = 16
        '
        'CloseMenu
        '
        Me.CloseMenu.AutoSize = True
        Me.CloseMenu.BackColor = System.Drawing.Color.Transparent
        Me.CloseMenu.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseMenu.ForeColor = System.Drawing.Color.Black
        Me.CloseMenu.Location = New System.Drawing.Point(1, 143)
        Me.CloseMenu.Name = "CloseMenu"
        Me.CloseMenu.Size = New System.Drawing.Size(86, 21)
        Me.CloseMenu.TabIndex = 16
        Me.CloseMenu.Text = "close menu"
        '
        'RemoveBookmark
        '
        Me.RemoveBookmark.AutoSize = True
        Me.RemoveBookmark.BackColor = System.Drawing.Color.Transparent
        Me.RemoveBookmark.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBookmark.ForeColor = System.Drawing.Color.Black
        Me.RemoveBookmark.Location = New System.Drawing.Point(1, 120)
        Me.RemoveBookmark.Name = "RemoveBookmark"
        Me.RemoveBookmark.Size = New System.Drawing.Size(82, 21)
        Me.RemoveBookmark.TabIndex = 15
        Me.RemoveBookmark.Text = "menu item"
        '
        'CopyTitle
        '
        Me.CopyTitle.AutoSize = True
        Me.CopyTitle.BackColor = System.Drawing.Color.Transparent
        Me.CopyTitle.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyTitle.ForeColor = System.Drawing.Color.Black
        Me.CopyTitle.Location = New System.Drawing.Point(1, 84)
        Me.CopyTitle.Name = "CopyTitle"
        Me.CopyTitle.Size = New System.Drawing.Size(82, 21)
        Me.CopyTitle.TabIndex = 14
        Me.CopyTitle.Text = "menu item"
        '
        'CopyURL
        '
        Me.CopyURL.AutoSize = True
        Me.CopyURL.BackColor = System.Drawing.Color.Transparent
        Me.CopyURL.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyURL.ForeColor = System.Drawing.Color.Black
        Me.CopyURL.Location = New System.Drawing.Point(1, 60)
        Me.CopyURL.Name = "CopyURL"
        Me.CopyURL.Size = New System.Drawing.Size(82, 21)
        Me.CopyURL.TabIndex = 13
        Me.CopyURL.Text = "menu item"
        '
        'OpenInNewWindow
        '
        Me.OpenInNewWindow.AutoSize = True
        Me.OpenInNewWindow.BackColor = System.Drawing.Color.Transparent
        Me.OpenInNewWindow.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenInNewWindow.ForeColor = System.Drawing.Color.Black
        Me.OpenInNewWindow.Location = New System.Drawing.Point(1, 25)
        Me.OpenInNewWindow.Name = "OpenInNewWindow"
        Me.OpenInNewWindow.Size = New System.Drawing.Size(82, 21)
        Me.OpenInNewWindow.TabIndex = 12
        Me.OpenInNewWindow.Text = "menu item"
        '
        'OpenInNewTab
        '
        Me.OpenInNewTab.AutoSize = True
        Me.OpenInNewTab.BackColor = System.Drawing.Color.Transparent
        Me.OpenInNewTab.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenInNewTab.ForeColor = System.Drawing.Color.Black
        Me.OpenInNewTab.Location = New System.Drawing.Point(1, 1)
        Me.OpenInNewTab.Name = "OpenInNewTab"
        Me.OpenInNewTab.Size = New System.Drawing.Size(82, 21)
        Me.OpenInNewTab.TabIndex = 11
        Me.OpenInNewTab.Text = "menu item"
        '
        'HoldDown
        '
        '
        'ResizeBR
        '
        Me.ResizeBR.Interval = 1
        '
        'ResizeBoxBR
        '
        Me.ResizeBoxBR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResizeBoxBR.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.ResizeBoxBR.Enabled = False
        Me.ResizeBoxBR.Location = New System.Drawing.Point(596, 265)
        Me.ResizeBoxBR.Name = "ResizeBoxBR"
        Me.ResizeBoxBR.Size = New System.Drawing.Size(10, 12)
        Me.ResizeBoxBR.TabIndex = 18
        Me.ResizeBoxBR.TabStop = False
        Me.ResizeBoxBR.Visible = False
        '
        'subitem4
        '
        Me.subitem4.AutoSize = True
        Me.subitem4.BackColor = System.Drawing.Color.Transparent
        Me.subitem4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subitem4.ForeColor = System.Drawing.Color.Silver
        Me.subitem4.Location = New System.Drawing.Point(171, 74)
        Me.subitem4.Name = "subitem4"
        Me.subitem4.Size = New System.Drawing.Size(52, 13)
        Me.subitem4.TabIndex = 14
        Me.subitem4.Text = "SUBITEM"
        Me.subitem4.Visible = False
        '
        'subitem3
        '
        Me.subitem3.AutoSize = True
        Me.subitem3.BackColor = System.Drawing.Color.Transparent
        Me.subitem3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subitem3.ForeColor = System.Drawing.Color.Silver
        Me.subitem3.Location = New System.Drawing.Point(121, 74)
        Me.subitem3.Name = "subitem3"
        Me.subitem3.Size = New System.Drawing.Size(52, 13)
        Me.subitem3.TabIndex = 13
        Me.subitem3.Text = "SUBITEM"
        Me.subitem3.Visible = False
        '
        'subitem2
        '
        Me.subitem2.AutoSize = True
        Me.subitem2.BackColor = System.Drawing.Color.Transparent
        Me.subitem2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subitem2.ForeColor = System.Drawing.Color.Black
        Me.subitem2.Location = New System.Drawing.Point(69, 74)
        Me.subitem2.Name = "subitem2"
        Me.subitem2.Size = New System.Drawing.Size(54, 13)
        Me.subitem2.TabIndex = 12
        Me.subitem2.Text = "SUBITEM"
        Me.subitem2.Visible = False
        '
        'tab4
        '
        Me.tab4.AutoSize = True
        Me.tab4.BackColor = System.Drawing.Color.Transparent
        Me.tab4.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab4.ForeColor = System.Drawing.Color.Silver
        Me.tab4.Location = New System.Drawing.Point(310, 30)
        Me.tab4.Name = "tab4"
        Me.tab4.Size = New System.Drawing.Size(105, 37)
        Me.tab4.TabIndex = 10
        Me.tab4.Text = "tab four"
        Me.tab4.Visible = False
        '
        'tab3
        '
        Me.tab3.AutoSize = True
        Me.tab3.BackColor = System.Drawing.Color.Transparent
        Me.tab3.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3.ForeColor = System.Drawing.Color.Silver
        Me.tab3.Location = New System.Drawing.Point(256, 30)
        Me.tab3.Name = "tab3"
        Me.tab3.Size = New System.Drawing.Size(118, 37)
        Me.tab3.TabIndex = 9
        Me.tab3.Text = "tab three"
        Me.tab3.Visible = False
        '
        'tab2
        '
        Me.tab2.AutoSize = True
        Me.tab2.BackColor = System.Drawing.Color.Transparent
        Me.tab2.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2.ForeColor = System.Drawing.Color.Silver
        Me.tab2.Location = New System.Drawing.Point(110, 30)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(101, 37)
        Me.tab2.TabIndex = 8
        Me.tab2.Text = "tab two"
        Me.tab2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "File to Convert:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(137, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(407, 23)
        Me.TextBox1.TabIndex = 20
        VisualTip1.AccessKey = System.Windows.Forms.Shortcut.None
        VisualTip1.FooterText = "ConvertXpress Pro"
        VisualTip1.Text = "Enter the complete address of the file you want to convert (ex. C:\Videos\video.f" & _
    "lv). Press the button on the right to browse for a file."
        VisualTip1.Title = "File to Convert"
        Me.VisualTipProvider1.SetVisualTip(Me.TextBox1, VisualTip1)
        '
        'FileBrowserButton
        '
        Me.FileBrowserButton.Location = New System.Drawing.Point(550, 112)
        Me.FileBrowserButton.Name = "FileBrowserButton"
        Me.FileBrowserButton.Size = New System.Drawing.Size(27, 23)
        Me.FileBrowserButton.TabIndex = 21
        Me.FileBrowserButton.Text = "..."
        Me.FileBrowserButton.UseVisualStyleBackColor = True
        VisualTip2.FooterText = "ConvertXpress Pro"
        VisualTip2.Text = "Click to open the file browser to select the file you want to convert."
        VisualTip2.Title = "Browse for a File"
        Me.VisualTipProvider1.SetVisualTip(Me.FileBrowserButton, VisualTip2)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Output Format:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Apple-compatible iPod/iPad (MP4 HQ)", "Audio-Only (MP3 HQ)", "Generic MP4 Encoding (MP4 Medium Quality)", "Graphics Interchange Format (GIF Uncompressed)", "Old-Style 3GP Format (3GP Low Quality)", "PSP-compatible (MP4 HQ)", "Windows Media Video (WMV HQ)"})
        Me.ComboBox1.Location = New System.Drawing.Point(137, 148)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(440, 23)
        Me.ComboBox1.TabIndex = 23
        VisualTip3.FooterText = "ConvertXpress Pro"
        VisualTip3.Text = "Select your preferred output format. If you are not sure, leave the default setti" & _
    "ng (Apple-compatible MP4) as it will most probably work on most devices."
        VisualTip3.Title = "Output File Format"
        Me.VisualTipProvider1.SetVisualTip(Me.ComboBox1, VisualTip3)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Output Directory:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(137, 189)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(407, 23)
        Me.TextBox2.TabIndex = 25
        VisualTip4.FooterText = "ConvertXpress Pro"
        VisualTip4.Text = "This is where the newly-converted file will go to. To choose a directory, click o" & _
    "n the button at the right side."
        VisualTip4.Title = "Output Directory"
        Me.VisualTipProvider1.SetVisualTip(Me.TextBox2, VisualTip4)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(550, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        VisualTip5.FooterText = "ConvertXpress Pro"
        VisualTip5.Text = "Browse for a directory to place newly-converted videos, or create a new one."
        VisualTip5.Title = "Output Directory Browser"
        Me.VisualTipProvider1.SetVisualTip(Me.Button1, VisualTip5)
        '
        'ConvertButton
        '
        Me.ConvertButton.AutoSize = True
        Me.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConvertButton.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConvertButton.ForeColor = System.Drawing.Color.DarkGray
        Me.ConvertButton.Location = New System.Drawing.Point(438, 226)
        Me.ConvertButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(140, 32)
        Me.ConvertButton.TabIndex = 27
        Me.ConvertButton.Text = "convert now"
        '
        'VisualTipProvider1
        '
        Me.VisualTipProvider1.InitialDelay = 100
        Me.VisualTipProvider1.Opacity = 1.0R
        Me.VisualTipProvider1.Renderer = VisualTipOfficeRenderer1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(29, 241)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(406, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 30
        Me.ProgressBar1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Converting..."
        Me.Label5.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Video Files(*.flv, *.mp4, *.avi, *.wmv, *.mkv) |*.flv;*.mp4;*.avi;*.wmv;*.mkv;*.F" & _
    "LV;*.MP4;*.AVI;*.WMV;*.MKV"
        Me.OpenFileDialog1.Title = "Select File to Convert..."
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select a folder to place your newly-converted files."
        '
        'ConverterWorker
        '
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(27, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 152)
        Me.Panel1.TabIndex = 32
        Me.Panel1.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(529, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "X"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(305, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(226, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Dedicated to my friends at UE-Manila NCP1."
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(17, 118)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(131, 15)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "http://www.xenliam.com/"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Licensed under the GNU LGPL v3 (Freeware)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Created by Liam Demafelix (xenLiam)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Version 1.10 Stable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ConvertXpress Pro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "What's New?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(305, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 45)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "* Added support for MKV Videos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Improved compression levels" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Fixed UI Issues"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(606, 277)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ConvertButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FileBrowserButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResizeBoxBR)
        Me.Controls.Add(Me.InterfaceContext)
        Me.Controls.Add(Me.subitem4)
        Me.Controls.Add(Me.subitem3)
        Me.Controls.Add(Me.subitem2)
        Me.Controls.Add(Me.subitem1)
        Me.Controls.Add(Me.tab4)
        Me.Controls.Add(Me.tab3)
        Me.Controls.Add(Me.TopGradient)
        Me.Controls.Add(Me.FormMovePanel)
        Me.Controls.Add(Me.tab1)
        Me.Controls.Add(Me.tab2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConvertXpress Pro"
        Me.FormMovePanel.ResumeLayout(False)
        Me.FormMovePanel.PerformLayout()
        Me.InterfaceContext.ResumeLayout(False)
        Me.InterfaceContext.PerformLayout()
        CType(Me.ResizeBoxBR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Label
    Friend WithEvents MaximiseButton As System.Windows.Forms.Label
    Friend WithEvents MinimiseButton As System.Windows.Forms.Label
    Friend WithEvents FormTitle As System.Windows.Forms.Label
    Friend WithEvents FormMovePanel As System.Windows.Forms.Panel
    Friend WithEvents FormMove As System.Windows.Forms.Timer
    Friend WithEvents TopGradient As System.Windows.Forms.Panel
    Friend WithEvents tab1 As System.Windows.Forms.Label
    Friend WithEvents SettingsButton As System.Windows.Forms.Label
    Friend WithEvents subitem1 As System.Windows.Forms.Label
    Friend WithEvents InterfaceContext As System.Windows.Forms.Panel
    Friend WithEvents CloseMenu As System.Windows.Forms.Label
    Friend WithEvents RemoveBookmark As System.Windows.Forms.Label
    Friend WithEvents CopyTitle As System.Windows.Forms.Label
    Friend WithEvents CopyURL As System.Windows.Forms.Label
    Friend WithEvents OpenInNewWindow As System.Windows.Forms.Label
    Friend WithEvents OpenInNewTab As System.Windows.Forms.Label
    Friend WithEvents HoldDown As System.Windows.Forms.Timer
    Friend WithEvents ResizeBR As System.Windows.Forms.Timer
    Friend WithEvents ResizeBoxBR As System.Windows.Forms.PictureBox
    Friend WithEvents subitem4 As System.Windows.Forms.Label
    Friend WithEvents subitem3 As System.Windows.Forms.Label
    Friend WithEvents subitem2 As System.Windows.Forms.Label
    Friend WithEvents tab4 As System.Windows.Forms.Label
    Friend WithEvents tab3 As System.Windows.Forms.Label
    Friend WithEvents tab2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FileBrowserButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ConvertButton As System.Windows.Forms.Label
    Friend WithEvents VisualTipProvider1 As Skybound.VisualTips.VisualTipProvider
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ConverterWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
