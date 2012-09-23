'METROFORM V1.2
'Glimmer Studios (formerly The Dream Factory)
'
'You are required to credit the author ('Glimmer Studios') unless an exception has been provided by a company representative
'(e.g. Maxwilly).
'Feel free to remove any comments, but they are for your information and removal is therefore not recommended.
'The following people may use this without crediting us (if they wish):
' *Chrisco97
' *eNs
' *Simek
'
'What's Already Here?
'To reduce RAM usage, you can call MinimizeFootprint() in any event. This will clear the working set and significantly reduce
'system load. Thanks to VisualTech48 for this method (http://www.visualtech48.net.tc/)
'
'To truly immerse your users into the metro design language, we have created a metro-styled context menu which can be customised
'to suit your application's functions. For an example of how this works, debug the project and hold down the mouse button on the
''tab two' button for a few seconds - the menu will slide into view. Check out the mousedown event for the code.
'
'There is also a selection of gradients available in the resources which you can use on the TopGradient Panel (top left-hand side,
'under the title). Provided alongside this project is the Metro Icons pack, slightly modified by us. Feel free to use these
'for commercial purposes without crediting back; these are the license specifications of the original author.
'
'One appealing feature of Metro is the use of subtle backgrounds. In the resources, alongside the gradients, you will find
'a collection of backgrounds. Set the form BackgroundImage as any of these if you wish; you may also have a settings form
'in which the user may select a background themselves at runtime.
'
'Thanks for using ConvertXpress_Pro!
'-The Glimmer Studios Team
Imports System.Runtime.InteropServices
Class Form1
    Dim TL As Integer
    Dim SelectItem As String
    Dim IMG As Image
    'The code below draws and allows you to control the form. Please do not modify it.
    Dim AppLocation, CursLocation As New Point(0, 0)
    <Runtime.InteropServices.DllImport("psapi.dll")> _
    Private Shared Function EmptyWorkingSet(ByVal hwProc As IntPtr) As Integer
    End Function
    Private Shared Sub MinimizeFootprint()
        EmptyWorkingSet(Process.GetCurrentProcess().Handle)
    End Sub
    <DllImport("dwmapi.dll", PreserveSig:=True)> _
    Public Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function

    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    Private Sub Sync()
        AppLocation = Me.Location
        CursLocation = Cursor.Position
    End Sub

    Private Sub FormMove_Tick(sender As System.Object, e As System.EventArgs) Handles FormMove.Tick
        Me.Location = AppLocation - CursLocation + Cursor.Position
    End Sub

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure

    Private Sub Form1_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        If InterfaceContext.Visible = True Then
            TL = 300
            InterfaceContext.Height = 0
            InterfaceContext.Visible = False
        End If
    End Sub

    Private Sub ShellWindow_SourceInitialized(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        TL = 300
        FormTitle.Text = Me.Text
        If My.Settings.Maximized = True Then
            Me.Location = New Point(0, 0)
            Me.Size = My.Computer.Screen.WorkingArea.Size
        End If
        'This is the FormLoad event. Do not remove any of the code between this comment and the next one.
        Dim val As Integer = 2
        DwmSetWindowAttribute(Me.Handle, 2, val, 4)
        Dim m = New MARGINS()
        m.cxLeftWidth = 1
        m.cxRightWidth = 1
        m.cyBottomHeight = 1
        m.cyTopHeight = 1
        DwmExtendFrameIntoClientArea(Me.Handle, m)
        'Below is the fade-in code.
        Dim tmr As New Timer
        tmr.Interval = 1
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity += 0.05
                                 If Me.Opacity = 1 Then tmr.Stop()
                             End Sub
        'Below is the code which makes the big labels slide into view. Modify at your own risk!
        'The labels, by default, do not animate when a background has been applied (due to lag).
        Try
            If Me.BackgroundImage.Width = 1024 Then

            End If
        Catch ex As Exception
            Dim pictimer1 As New Timer
            pictimer1.Interval = 1
            pictimer1.Start()
            Dim p1 As New Point
            Dim op1 As New Point
            op1 = tab1.Location
            p1 = tab1.Location
            p1.X = op1.X - 30
            AddHandler pictimer1.Tick, Sub()
                                           tab1.Location = p1
                                           p1.X += 1
                                           If p1.X = op1.X Then
                                               pictimer1.Stop()
                                           End If
                                       End Sub
            Dim PicTimer2 As New Timer
            PicTimer2.Interval = 1
            PicTimer2.Start()
            Dim p2 As New Point
            Dim op2 As New Point
            op2 = tab2.Location
            p2 = tab2.Location
            p2.X = op2.X - 30
            AddHandler PicTimer2.Tick, Sub()
                                           tab2.Location = p2
                                           p2.X += 1
                                           If p2.X = op2.X Then
                                               PicTimer2.Stop()
                                           End If
                                       End Sub
            Dim PT3 As New Timer
            PT3.Interval = 1
            PT3.Start()
            Dim P3 As New Point
            Dim OP3 As New Point
            OP3 = tab3.Location
            P3 = tab3.Location
            P3.X = OP3.X - 30
            AddHandler PT3.Tick, Sub()
                                     tab3.Location = P3
                                     P3.X += 1
                                     If P3.X = OP3.X Then
                                         PT3.Stop()
                                     End If
                                 End Sub
            Dim PT4 As New Timer
            PT4.Interval = 1
            PT4.Start()
            Dim P4 As New Point
            Dim OP4 As New Point
            OP4 = tab4.Location
            P4 = tab4.Location
            P4.X = OP4.X - 30
            AddHandler PT4.Tick, Sub()
                                     tab4.Location = P4
                                     P4.X += 1
                                     If P4.X = OP4.X Then
                                         PT4.Stop()
                                     End If
                                 End Sub
        End Try
        'Here is an example of using the workset-clearing method:
        MinimizeFootprint()
        'Yes, it's really that simple.

        InterfaceContext.Visible = False

        ' Start ConvertXpress Pro Code
        ComboBox1.SelectedIndex = 0
        TextBox2.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
    End Sub

    'This is the form moving code. When the mouse is down on the panel at the top of the form, the user can drag the form around the screen.
    Private Sub FormMovePanel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles FormMovePanel.MouseDown
        FormMove.Start()
        Sync()
    End Sub

    Private Sub FormMovePanel_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles FormMovePanel.MouseUp
        FormMove.Stop()
        Sync()
    End Sub

    'This is the closing button, with the fade-out code.
    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        Try
            Me.BackgroundImageLayout = ImageLayout.None
            Me.BackgroundImage = Nothing
            Dim iCount As Integer
            For iCount = 100 To 10 Step -10
                Me.Opacity = iCount / 100
                Me.Refresh()
                Threading.Thread.Sleep(20)
            Next
            Me.Close()
        Catch ex As Exception
            Dim iCount As Integer
            For iCount = 100 To 10 Step -10
                Me.Opacity = iCount / 100
                Me.Refresh()
                Threading.Thread.Sleep(20)
            Next
            Me.Close()
        End Try
    End Sub

    'The following series of repetitive code makes the labels change colour when the cursor is over them.
    Private Sub CloseButton_MouseEnter(sender As Object, e As System.EventArgs) Handles CloseButton.MouseEnter
        CloseButton.ForeColor = Color.Black
    End Sub

    Private Sub CloseButtonMouseLeave(sender As Object, e As System.EventArgs) Handles CloseButton.MouseLeave
        CloseButton.ForeColor = Color.Gray
    End Sub

    Private Sub MaximiseButton_MouseEnter(sender As Object, e As System.EventArgs) Handles MaximiseButton.MouseEnter
        MaximiseButton.ForeColor = Color.Black
    End Sub

    Private Sub MaximiseButtonMouseLeave(sender As Object, e As System.EventArgs) Handles MaximiseButton.MouseLeave
        MaximiseButton.ForeColor = Color.Gray
    End Sub

    Private Sub MinimiseButton_MouseEnter(sender As Object, e As System.EventArgs) Handles MinimiseButton.MouseEnter
        MinimiseButton.ForeColor = Color.Black
    End Sub

    Private Sub MinimiseButtonMouseLeave(sender As Object, e As System.EventArgs) Handles MinimiseButton.MouseLeave
        MinimiseButton.ForeColor = Color.Gray
    End Sub

    Private Sub OpenInNewTab_MouseEnter(sender As Object, e As System.EventArgs) Handles OpenInNewTab.MouseEnter
        OpenInNewTab.ForeColor = Color.Gray
    End Sub

    Private Sub OpenInNewTab_MouseLeave(sender As Object, e As System.EventArgs) Handles OpenInNewTab.MouseLeave
        OpenInNewTab.ForeColor = Color.Black
    End Sub

    Private Sub OpenInNewWindow_MouseEnter(sender As Object, e As System.EventArgs) Handles OpenInNewWindow.MouseEnter
        OpenInNewWindow.ForeColor = Color.Gray
    End Sub

    Private Sub OpenInNewWindow_MouseLeave(sender As Object, e As System.EventArgs) Handles OpenInNewWindow.MouseLeave
        OpenInNewWindow.ForeColor = Color.Black
    End Sub

    Private Sub CopyURL_MouseEnter(sender As Object, e As System.EventArgs) Handles CopyURL.MouseEnter
        CopyURL.ForeColor = Color.Gray
    End Sub

    Private Sub CopyURL_MouseLeave(sender As Object, e As System.EventArgs) Handles CopyURL.MouseLeave
        CopyURL.ForeColor = Color.Black
    End Sub

    Private Sub CopyTitle_MouseEnter(sender As Object, e As System.EventArgs) Handles CopyTitle.MouseEnter
        CopyTitle.ForeColor = Color.Gray
    End Sub

    Private Sub CopyTitle_MouseLeave(sender As Object, e As System.EventArgs) Handles CopyTitle.MouseLeave
        CopyTitle.ForeColor = Color.Black
    End Sub

    Private Sub AddToFavourites_MouseEnter(sender As Object, e As System.EventArgs) Handles CloseMenu.MouseEnter
        CloseMenu.ForeColor = Color.Gray
    End Sub

    Private Sub AddToFavourites_MouseLeave(sender As Object, e As System.EventArgs) Handles CloseMenu.MouseLeave
        CloseMenu.ForeColor = Color.Black
    End Sub

    Private Sub RemoveBookmark_MouseEnter(sender As Object, e As System.EventArgs) Handles RemoveBookmark.MouseEnter
        RemoveBookmark.ForeColor = Color.Gray
    End Sub

    Private Sub RemoveBookmark_MouseLeave(sender As Object, e As System.EventArgs) Handles RemoveBookmark.MouseLeave
        RemoveBookmark.ForeColor = Color.Black
    End Sub

    Private Sub tab2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles tab2.MouseDown
        SelectItem = "tab2"
        HoldDown.Start()
    End Sub

    Private Sub tab2_MouseEnter(sender As Object, e As System.EventArgs) Handles tab2.MouseEnter
        tab2.ForeColor = Color.Gray
    End Sub

    Private Sub tab2_MouseLeave(sender As Object, e As System.EventArgs) Handles tab2.MouseLeave
        tab2.ForeColor = Color.Silver
    End Sub

    Private Sub tab3_MouseEnter(sender As Object, e As System.EventArgs) Handles tab3.MouseEnter
        tab3.ForeColor = Color.Gray
    End Sub

    Private Sub tab3_MouseLeave(sender As Object, e As System.EventArgs) Handles tab3.MouseLeave
        tab3.ForeColor = Color.Silver
    End Sub

    Private Sub tab4_MouseEnter(sender As Object, e As System.EventArgs) Handles tab4.MouseEnter
        tab4.ForeColor = Color.Gray
    End Sub

    Private Sub tab4_MouseLeave(sender As Object, e As System.EventArgs) Handles tab4.MouseLeave
        tab4.ForeColor = Color.Silver
    End Sub

    Private Sub subitem1_MouseEnter(sender As Object, e As System.EventArgs) Handles subitem1.MouseEnter
        subitem1.ForeColor = Color.Gray
    End Sub

    Private Sub subitem1_MouseLeave(sender As Object, e As System.EventArgs) Handles subitem1.MouseLeave
        subitem1.ForeColor = Color.Silver
    End Sub

    Private Sub subitem3_MouseEnter(sender As Object, e As System.EventArgs) Handles subitem3.MouseEnter
        subitem3.ForeColor = Color.Gray
    End Sub

    Private Sub subitem3_MouseLeave(sender As Object, e As System.EventArgs) Handles subitem3.MouseLeave
        subitem3.ForeColor = Color.Silver
    End Sub

    Private Sub subitem4_MouseEnter(sender As Object, e As System.EventArgs) Handles subitem4.MouseEnter
        subitem4.ForeColor = Color.Gray
    End Sub

    Private Sub subitem4_MouseLeave(sender As Object, e As System.EventArgs) Handles subitem4.MouseLeave
        subitem4.ForeColor = Color.Silver
    End Sub

    Private Sub MinimiseButton_Click(sender As System.Object, e As System.EventArgs) Handles MinimiseButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SettingsButton_MouseEnter(sender As Object, e As System.EventArgs) Handles SettingsButton.MouseEnter
        SettingsButton.ForeColor = Color.Gray
    End Sub

    Private Sub SettingsButton_MouseLeave(sender As Object, e As System.EventArgs) Handles SettingsButton.MouseLeave
        SettingsButton.ForeColor = Color.Silver
    End Sub

    'This code maximises/demaximises the form. Likewise, it dynamically remembers whether or not the form is maximised on close,
    'and remains that way on next startup.
    Private Sub MaximiseButton_Click(sender As System.Object, e As System.EventArgs) Handles MaximiseButton.Click
        'If My.Settings.Maximized = False Then
        'ResizeBoxBR.Visible = False
        '  Me.WindowState = FormWindowState.Normal
        '  Me.Location = New Point(0, 0)
        '  Me.Size = My.Computer.Screen.WorkingArea.Size
        ' My.Settings.Maximized = True
        ' ElseIf My.Settings.Maximized = True Then
        '   ResizeBoxBR.Visible = True
        ' Me.WindowState = FormWindowState.Normal
        ' Me.Width = 1024
        ' Me.Height = 768
        '  Me.Left = CInt((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2)
        '  Me.Top = CInt((Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        ' My.Settings.Maximized = False
        ' End If
    End Sub

    'Below is the code responsible for closing the context menu.
    Private Sub CloseMenu_Click(sender As System.Object, e As System.EventArgs) Handles CloseMenu.Click
        TL = 300
        InterfaceContext.Height = 0
        InterfaceContext.Visible = False
    End Sub

    'This is the code responsible for showing the context menu on the item that you hold the cursor down on...Adapt it for other controls!
    Private Sub HoldDown_Tick(sender As System.Object, e As System.EventArgs) Handles HoldDown.Tick
        If TL > 0 Then
            TL -= 100
        Else
            TL = 300
            InterfaceContext.Height = 0
            HoldDown.Stop()
            If SelectItem = "tab2" Then
                Dim T2 As New Point
                T2 = tab2.Location
                T2.Y = tab2.Location.Y + tab2.Height
                InterfaceContext.Location = T2
                InterfaceContext.Visible = True
                Dim SlideAnim As New Timer
                SlideAnim.Interval = 1
                SlideAnim.Start()
                Dim OP4 As New Point
                OP4.Y = 0
                OP4.X = 0
                AddHandler SlideAnim.Tick, Sub()
                                               InterfaceContext.Height = OP4.Y
                                               OP4.Y += 10
                                               If InterfaceContext.Height = 150 Then
                                                   SlideAnim.Stop()
                                               End If
                                           End Sub
            End If
        End If
    End Sub

    Private Sub tab2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles tab2.MouseUp
        TL = 300
        HoldDown.Stop()
    End Sub

    'The following code resizes the form when the picturebox at the bottom right-hand corner's mousedown event is active.
    Private Sub ResizeBoxBR_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ResizeBoxBR.MouseDown
        IMG = Me.BackgroundImage
        ResizeBR.Start()
    End Sub

    Private Sub ResizeBoxBR_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ResizeBoxBR.MouseUp
        ResizeBR.Stop()
        Me.BackgroundImage = IMG
    End Sub

    'By default, the background image (if applicable) is set as a temporary file, and then cleared from view. Once the form is no longer
    'being resized, the background image is restored. This prevents lag while resizing.
    Private Sub ResizeBR_Tick(sender As System.Object, e As System.EventArgs) Handles ResizeBR.Tick
        Me.BackgroundImage = Nothing
        Dim CL As New Point
        Dim DL As New Point
        CL.X = System.Windows.Forms.Cursor.Position.X - Me.Left
        CL.Y = System.Windows.Forms.Cursor.Position.Y - Me.Top
        Me.Size = CL
    End Sub

    Private Sub ResizeBoxBR_Click(sender As Object, e As EventArgs) Handles ResizeBoxBR.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConvertButton_MouseHover(sender As Object, e As EventArgs) Handles ConvertButton.MouseHover
        ConvertButton.ForeColor = Color.Black
    End Sub

    Private Sub ConvertButton_MouseLeave(sender As Object, e As EventArgs) Handles ConvertButton.MouseLeave
        ConvertButton.ForeColor = Color.DarkGray
    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        ' Do the conversion pre-checks
        If TextBox1.Text = "" Then
            MsgBox("Please enter a valid file to convert.", MsgBoxStyle.Critical, "ConvertXpress Error")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Please enter a valid output directory.", MsgBoxStyle.Critical, "ConvertXpress Error")
            Exit Sub
        End If

        ' Disable
        ConvertButton.Enabled = False
        ConvertButton.Text = "converting..."
        Button1.Enabled = False
        FileBrowserButton.Enabled = False

        ' Show the status bars
        Label5.Visible = True
        ProgressBar1.Visible = True

        ' All good, run the converter
        ConverterWorker.RunWorkerAsync()
    End Sub

    Private Sub FileBrowserButton_Click(sender As Object, e As EventArgs) Handles FileBrowserButton.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        Else
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then
            Exit Sub
        Else
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub ConverterWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ConverterWorker.DoWork
        ' Build the FFMPEG Path
        Dim FFMPEG_Path As String = Application.StartupPath + "\FFMPEG\FFMPEG.EXE"

        ' Output Filename

        ' Build the command
        Dim ConvCommand As String = """" + FFMPEG_Path + """ -i """ + TextBox1.Text + """"

        ' Commands for formats
        Dim AppleConvCommand As String = ConvCommand + " -y -sameq -ar 22050 -vcodec libx264 "
        Dim PSPConvCommand As String = ConvCommand + " -y -sameq -ar 22050 -vcodec libx264 "
        Dim MP3ConvCommand As String = ConvCommand + " -y -vn -ar 44100 -ac 2 -ab 192 -f mp3 "
        Dim GenericMP4ConvCommand As String = ConvCommand + " -y -sameq -ar 22050 "
        Dim SGPConvCommand As String = ConvCommand + " -y -f avi -vcodec libxvid -acodec mp3 -ar 22050 "
        Dim WMVConvCommand As String = ConvCommand + " -y -sameq -ar 22050 "

        Dim FileExt As String = System.IO.Path.GetExtension(TextBox1.Text)

        ' Convert
        If ComboBox1.SelectedIndex = 0 Then
            ' This is Apple
            Dim OutputFile As String = Replace(OpenFileDialog1.SafeFileName, FileExt, ".mp4")
            Dim TheFile As String = """" + TextBox2.Text + "\" + OutputFile + """"

            ' Run the command
            Shell(AppleConvCommand + TheFile, AppWinStyle.Hide, True)
        End If

        If ComboBox1.SelectedIndex = 1 Then
            ' MP3 Only
            Dim OutputFile As String = Replace(OpenFileDialog1.SafeFileName, FileExt, ".mp3")
            Dim TheFile As String = """" + TextBox2.Text + "\" + OutputFile + """"

            ' Run the command
            Shell(MP3ConvCommand + TheFile, AppWinStyle.Hide, True)
        End If

        If ComboBox1.SelectedIndex = 2 Then
            ' MP4 Generic
            Dim OutputFile As String = Replace(OpenFileDialog1.SafeFileName, FileExt, ".mp4")
            Dim TheFile As String = """" + TextBox2.Text + "\" + OutputFile + """"

            ' Run the command
            Shell(GenericMP4ConvCommand + TheFile, AppWinStyle.Hide, True)
        End If

        If ComboBox1.SelectedIndex = 3 Then
            ' GIF
            Dim OutputFile As String = Replace(OpenFileDialog1.SafeFileName, FileExt, ".gif")
            Dim TheFile As String = """" + TextBox2.Text + "\" + OutputFile + """"

            ' Run the command
            Shell(ConvCommand + " -y -pix_fmt rgb24 " + TheFile, AppWinStyle.Hide, True)
        End If

        If ComboBox1.SelectedIndex = 4 Then
            ' 3GP Old-Style
            Dim OutputFile As String = Replace(OpenFileDialog1.SafeFileName, FileExt, ".3gp")
            Dim TheFile As String = """" + TextBox2.Text + "\" + OutputFile + """"

            ' Run the command
            Shell(SGPConvCommand + TheFile, AppWinStyle.Hide, True)
        End If

        If ComboBox1.SelectedIndex = 5 Then
            ' PSP
            Dim OutputFile As String = Replace(OpenFileDialog1.SafeFileName, FileExt, ".mp4")
            Dim TheFile As String = """" + TextBox2.Text + "\" + OutputFile + """"

            ' Run the command
            Shell(PSPConvCommand + TheFile, AppWinStyle.Hide, True)
        End If

        If ComboBox1.SelectedIndex = 6 Then
            ' WMV
            Dim OutputFile As String = Replace(OpenFileDialog1.SafeFileName, FileExt, ".wmv")
            Dim TheFile As String = """" + TextBox2.Text + "\" + OutputFile + """"

            ' Run the command
            Shell(WMVConvCommand + TheFile, AppWinStyle.Hide, True)

        End If
    End Sub

    Private Sub ConverterWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ConverterWorker.RunWorkerCompleted
        MsgBox("Conversion complete!", MsgBoxStyle.Information, "ConvertXpress Pro")
        ' Enable
        ConvertButton.Enabled = True
        ConvertButton.Text = "convert now"
        Button1.Enabled = True
        FileBrowserButton.Enabled = True

        ' Show the status bars
        Label5.Visible = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://www.xenliam.com/")
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Panel1.Visible = False
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        Panel1.Visible = True
    End Sub
End Class