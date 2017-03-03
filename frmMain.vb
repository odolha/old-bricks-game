
Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents mainMnu As System.Windows.Forms.MainMenu
    Friend WithEvents muteChB As System.Windows.Forms.CheckBox
    Friend WithEvents startBut As System.Windows.Forms.Button
    Friend WithEvents levelBut As System.Windows.Forms.Button
    Friend WithEvents pauseBut As System.Windows.Forms.Button
    Friend WithEvents cancelBut As System.Windows.Forms.Button
    Friend WithEvents scoreLab As System.Windows.Forms.Label
    Friend WithEvents menuFile As System.Windows.Forms.MenuItem
    Friend WithEvents menuExit As System.Windows.Forms.MenuItem
    Friend WithEvents menuView As System.Windows.Forms.MenuItem
    Friend WithEvents menuFullScreen As System.Windows.Forms.MenuItem
    Friend WithEvents menuTools As System.Windows.Forms.MenuItem
    Friend WithEvents menuLevel As System.Windows.Forms.MenuItem
    Friend WithEvents menuEasy As System.Windows.Forms.MenuItem
    Friend WithEvents menuIntermediate As System.Windows.Forms.MenuItem
    Friend WithEvents menuHard As System.Windows.Forms.MenuItem
    Friend WithEvents menuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents gamePanel As PanelDBuff
    Friend WithEvents soundPanel As System.Windows.Forms.Panel
    Friend WithEvents optionsPanel As System.Windows.Forms.Panel
    Friend WithEvents timeT As System.Windows.Forms.Timer
    Friend WithEvents scoreL As System.Windows.Forms.Label
    Friend WithEvents controlTB As System.Windows.Forms.TextBox
    Friend WithEvents gameOverL As System.Windows.Forms.Label
    Friend WithEvents levelL As System.Windows.Forms.Label
    Friend WithEvents levelCMnu As System.Windows.Forms.ContextMenu
    Friend WithEvents cMenuEasy As System.Windows.Forms.MenuItem
    Friend WithEvents cMenuIntermediate As System.Windows.Forms.MenuItem
    Friend WithEvents cMenuHard As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mainMnu = New System.Windows.Forms.MainMenu
        Me.menuFile = New System.Windows.Forms.MenuItem
        Me.menuExit = New System.Windows.Forms.MenuItem
        Me.menuView = New System.Windows.Forms.MenuItem
        Me.menuFullScreen = New System.Windows.Forms.MenuItem
        Me.menuTools = New System.Windows.Forms.MenuItem
        Me.menuLevel = New System.Windows.Forms.MenuItem
        Me.menuEasy = New System.Windows.Forms.MenuItem
        Me.menuIntermediate = New System.Windows.Forms.MenuItem
        Me.menuHard = New System.Windows.Forms.MenuItem
        Me.menuHelp = New System.Windows.Forms.MenuItem
        Me.gamePanel = New Bricks.PanelDBuff
        Me.gameOverL = New System.Windows.Forms.Label
        Me.controlTB = New System.Windows.Forms.TextBox
        Me.soundPanel = New System.Windows.Forms.Panel
        Me.levelL = New System.Windows.Forms.Label
        Me.muteChB = New System.Windows.Forms.CheckBox
        Me.optionsPanel = New System.Windows.Forms.Panel
        Me.scoreL = New System.Windows.Forms.Label
        Me.scoreLab = New System.Windows.Forms.Label
        Me.startBut = New System.Windows.Forms.Button
        Me.levelBut = New System.Windows.Forms.Button
        Me.levelCMnu = New System.Windows.Forms.ContextMenu
        Me.cMenuEasy = New System.Windows.Forms.MenuItem
        Me.cMenuIntermediate = New System.Windows.Forms.MenuItem
        Me.cMenuHard = New System.Windows.Forms.MenuItem
        Me.pauseBut = New System.Windows.Forms.Button
        Me.cancelBut = New System.Windows.Forms.Button
        Me.timeT = New System.Windows.Forms.Timer(Me.components)
        Me.gamePanel.SuspendLayout()
        Me.soundPanel.SuspendLayout()
        Me.optionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMnu
        '
        Me.mainMnu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFile, Me.menuView, Me.menuTools, Me.menuHelp})
        '
        'menuFile
        '
        Me.menuFile.Index = 0
        Me.menuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuExit})
        Me.menuFile.Text = "File"
        '
        'menuExit
        '
        Me.menuExit.Index = 0
        Me.menuExit.Text = "Exit"
        '
        'menuView
        '
        Me.menuView.Index = 1
        Me.menuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFullScreen})
        Me.menuView.Text = "View"
        '
        'menuFullScreen
        '
        Me.menuFullScreen.Index = 0
        Me.menuFullScreen.Text = "Full-Screen"
        '
        'menuTools
        '
        Me.menuTools.Index = 2
        Me.menuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuLevel})
        Me.menuTools.Text = "Tools"
        '
        'menuLevel
        '
        Me.menuLevel.Index = 0
        Me.menuLevel.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuEasy, Me.menuIntermediate, Me.menuHard})
        Me.menuLevel.Text = "Level"
        '
        'menuEasy
        '
        Me.menuEasy.Index = 0
        Me.menuEasy.Text = "Easy"
        '
        'menuIntermediate
        '
        Me.menuIntermediate.Index = 1
        Me.menuIntermediate.Text = "Intermediate"
        '
        'menuHard
        '
        Me.menuHard.Index = 2
        Me.menuHard.Text = "Hard"
        '
        'menuHelp
        '
        Me.menuHelp.Index = 3
        Me.menuHelp.Text = "Help"
        '
        'gamePanel
        '
        Me.gamePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gamePanel.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gamePanel.Controls.Add(Me.gameOverL)
        Me.gamePanel.Location = New System.Drawing.Point(150, 10)
        Me.gamePanel.Name = "gamePanel"
        Me.gamePanel.Size = New System.Drawing.Size(600, 430)
        Me.gamePanel.TabIndex = 0
        '
        'gameOverL
        '
        Me.gameOverL.BackColor = System.Drawing.Color.Transparent
        Me.gameOverL.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameOverL.ForeColor = System.Drawing.Color.Red
        Me.gameOverL.Location = New System.Drawing.Point(10, 160)
        Me.gameOverL.Name = "gameOverL"
        Me.gameOverL.Size = New System.Drawing.Size(580, 90)
        Me.gameOverL.TabIndex = 0
        Me.gameOverL.Text = "GAME OVER"
        Me.gameOverL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'controlTB
        '
        Me.controlTB.Location = New System.Drawing.Point(-100, -100)
        Me.controlTB.Name = "controlTB"
        Me.controlTB.Size = New System.Drawing.Size(27, 20)
        Me.controlTB.TabIndex = 0
        Me.controlTB.Text = "controlTB"
        '
        'soundPanel
        '
        Me.soundPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.soundPanel.Controls.Add(Me.levelL)
        Me.soundPanel.Controls.Add(Me.muteChB)
        Me.soundPanel.Location = New System.Drawing.Point(150, 449)
        Me.soundPanel.Name = "soundPanel"
        Me.soundPanel.Size = New System.Drawing.Size(600, 40)
        Me.soundPanel.TabIndex = 1
        '
        'levelL
        '
        Me.levelL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelL.Location = New System.Drawing.Point(10, 0)
        Me.levelL.Name = "levelL"
        Me.levelL.Size = New System.Drawing.Size(290, 40)
        Me.levelL.TabIndex = 1
        Me.levelL.Text = "Level: "
        Me.levelL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'muteChB
        '
        Me.muteChB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.muteChB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.muteChB.Location = New System.Drawing.Point(480, 10)
        Me.muteChB.Name = "muteChB"
        Me.muteChB.Size = New System.Drawing.Size(120, 24)
        Me.muteChB.TabIndex = 0
        Me.muteChB.Text = "Mute Sound"
        '
        'optionsPanel
        '
        Me.optionsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optionsPanel.Controls.Add(Me.scoreL)
        Me.optionsPanel.Controls.Add(Me.scoreLab)
        Me.optionsPanel.Controls.Add(Me.startBut)
        Me.optionsPanel.Controls.Add(Me.levelBut)
        Me.optionsPanel.Controls.Add(Me.pauseBut)
        Me.optionsPanel.Controls.Add(Me.cancelBut)
        Me.optionsPanel.Location = New System.Drawing.Point(10, 10)
        Me.optionsPanel.Name = "optionsPanel"
        Me.optionsPanel.Size = New System.Drawing.Size(130, 479)
        Me.optionsPanel.TabIndex = 2
        '
        'scoreL
        '
        Me.scoreL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scoreL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scoreL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreL.Location = New System.Drawing.Point(10, 440)
        Me.scoreL.Name = "scoreL"
        Me.scoreL.Size = New System.Drawing.Size(110, 30)
        Me.scoreL.TabIndex = 2
        Me.scoreL.Text = "0"
        Me.scoreL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'scoreLab
        '
        Me.scoreLab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scoreLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLab.Location = New System.Drawing.Point(10, 409)
        Me.scoreLab.Name = "scoreLab"
        Me.scoreLab.Size = New System.Drawing.Size(110, 23)
        Me.scoreLab.TabIndex = 1
        Me.scoreLab.Text = "Score:"
        Me.scoreLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startBut
        '
        Me.startBut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.startBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startBut.Location = New System.Drawing.Point(10, 10)
        Me.startBut.Name = "startBut"
        Me.startBut.Size = New System.Drawing.Size(110, 40)
        Me.startBut.TabIndex = 0
        Me.startBut.Text = "Start"
        '
        'levelBut
        '
        Me.levelBut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.levelBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelBut.Location = New System.Drawing.Point(10, 60)
        Me.levelBut.Name = "levelBut"
        Me.levelBut.Size = New System.Drawing.Size(110, 40)
        Me.levelBut.TabIndex = 0
        Me.levelBut.Text = "Level"
        '
        'levelCMnu
        '
        Me.levelCMnu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cMenuEasy, Me.cMenuIntermediate, Me.cMenuHard})
        '
        'cMenuEasy
        '
        Me.cMenuEasy.Index = 0
        Me.cMenuEasy.Text = "Easy"
        '
        'cMenuIntermediate
        '
        Me.cMenuIntermediate.Index = 1
        Me.cMenuIntermediate.Text = "Intermediate"
        '
        'cMenuHard
        '
        Me.cMenuHard.Index = 2
        Me.cMenuHard.Text = "Hard"
        '
        'pauseBut
        '
        Me.pauseBut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pauseBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pauseBut.Location = New System.Drawing.Point(10, 110)
        Me.pauseBut.Name = "pauseBut"
        Me.pauseBut.Size = New System.Drawing.Size(110, 40)
        Me.pauseBut.TabIndex = 0
        Me.pauseBut.Text = "Pause"
        '
        'cancelBut
        '
        Me.cancelBut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBut.Location = New System.Drawing.Point(10, 160)
        Me.cancelBut.Name = "cancelBut"
        Me.cancelBut.Size = New System.Drawing.Size(110, 40)
        Me.cancelBut.TabIndex = 0
        Me.cancelBut.Text = "Cancel"
        '
        'timeT
        '
        Me.timeT.Interval = 30
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 495)
        Me.Controls.Add(Me.gamePanel)
        Me.Controls.Add(Me.optionsPanel)
        Me.Controls.Add(Me.soundPanel)
        Me.Controls.Add(Me.controlTB)
        Me.Menu = Me.mainMnu
        Me.Name = "frmMain"
        Me.Text = "Bricks"
        Me.gamePanel.ResumeLayout(False)
        Me.soundPanel.ResumeLayout(False)
        Me.optionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum DiffLevel
        Easy = 0
        Intermediate = 1
        Hard = 2
    End Enum



    'size of the board agains which every other dimension is given
    Public Const BasicBoardWidth As Integer = 1600
    Public Const BasicBoardHeight As Integer = 1200
    '---

    'it contains at each time the ratio between the actual size of the game panel and the base size of the game (in which every value is given)
    Public ResizeRatio As SizeF


    'game constants (given according to BasicBoardWidth and BasicBoardHeight)
    Public Const BrickRows As Integer = 5
    Public Const BrickColumns As Integer = 10

    Private Const InitialBallVelocityX As Single = 8.0F
    Private Const InitialBallVelocityY As Single = -10.0F

    Public LevelVelocity As Single() = New Single(2) {7.0F, 12.8F, 20.0F}
    '---


    'dimensions for the game (given according to BasicBoardWidth and BasicBoardHeight)
    Private BallWidth As Integer = 60
    Private BallHeight As Integer = 60
    Private BallMaxHorizontalDeviation As Single = 20.0F

    Private BrickHeight As Integer = 80

    Private PaddleWidth As Integer = 320
    Private PaddleHeight As Integer = 60
    Private PaddleDistanceFromBottom As Integer = 40
    Private PaddleMaxVelocity As Single = 40
    '---





    'game fields
    Public Score As Integer
    Public Level As DiffLevel

    Private Board As Board
    Private Ball As Ball
    Private Paddle As Paddle
    '---





    'double buffering variables
    Public DrawingArea As Graphics
    Private BackBuffer As Bitmap





    'resets the game to an initial state
    Public Sub ResetGame()
        Me.gameOverL.Visible = False

        Me.Board = New Board(Me, New Size(Me.BrickColumns, Me.BrickRows))
        Me.Board.BrickHeight = Me.BrickHeight

        Me.Paddle = New Paddle(Me, New PointF(Me.BasicBoardWidth / 2, Me.BasicBoardHeight - Me.PaddleDistanceFromBottom - Me.PaddleHeight / 2))
        Me.Paddle.Size = New Size(Me.PaddleWidth, Me.PaddleHeight)
        Me.Paddle.DistanceFromBottom = Me.PaddleDistanceFromBottom
        Me.Paddle.MaxVelocity = Me.PaddleMaxVelocity

        Me.Ball = New Ball(Me, Me.Paddle, Me.Board, New PointF(Me.BasicBoardWidth / 2, Me.BasicBoardHeight / 2), New PointF(Me.InitialBallVelocityX, Me.InitialBallVelocityY))
        Me.Ball.Size = New Size(Me.BallWidth, Me.BallHeight)
        Me.Ball.MaxHorizontalDeviation = Me.BallMaxHorizontalDeviation

        Me.Score = 0
        Me.UpdateLevel()
        Me.UpdateResizeFactor()
    End Sub




    'updates the resize factor for all elements
    Public Sub UpdateResizeFactor()
        Me.ResizeRatio = New SizeF(Me.gamePanel.Width / Me.BasicBoardWidth, Me.gamePanel.Height / Me.BasicBoardHeight)
    End Sub



    Public Sub UpdateLevel()
        Me.levelL.Text = "Difficulty Level: " + Me.Level.ToString
        Me.Ball.NormalizeVelocity(Me.LevelVelocity(Me.Level))
    End Sub






    'what happens at each frame of the game time
    Private Sub timeT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeT.Tick
        'Dynamics
        Me.Ball.ProcessDynamics()
        Me.Paddle.ProcessDynamics()


        Me.DrawingArea.Clear(Me.gamePanel.BackColor)
        If Not (Me.Board Is Nothing) Then Me.Board.Draw(Me.DrawingArea)
        If Not (Me.Ball Is Nothing) Then Me.Ball.Draw(Me.DrawingArea)
        If Not (Me.Paddle Is Nothing) Then Me.Paddle.Draw(Me.DrawingArea)

        Me.scoreL.Text = Me.Score

        Me.Refresh()
    End Sub






    'when the application starts
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackBuffer = New Bitmap(Me.gamePanel.Size.Width, Me.gamePanel.Size.Height)
        Me.DrawingArea = Graphics.FromImage(BackBuffer)

        Me.Level = DiffLevel.Intermediate

        Me.ResetGame()
    End Sub





    'resizes the panel of the board so all elements of the game must update their ResizeRatio factor
    Private Sub gamePanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles gamePanel.Resize
        Me.UpdateResizeFactor()

        Me.BackBuffer = New Bitmap(Me.gamePanel.Size.Width, Me.gamePanel.Size.Height)
        Me.DrawingArea = Graphics.FromImage(BackBuffer)

        Me.Refresh()
    End Sub





    'painting the game panel
    Private Sub gamePanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles gamePanel.Paint
        e.Graphics.DrawImageUnscaled(Me.BackBuffer, 0, 0)
    End Sub





    'keyboard input

    Private Sub controlTB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles controlTB.KeyDown
        If e.KeyCode = Keys.Left Then
            Me.Paddle.Acceleration = -18.0F
        ElseIf e.KeyCode = Keys.Right Then
            Me.Paddle.Acceleration = 18.0F
        End If
    End Sub

    Private Sub controlTB_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles controlTB.KeyUp
        If (e.KeyCode = Keys.Left) Or (e.KeyCode = Keys.Right) Then
            Me.Paddle.Acceleration = 0.0F
        End If
    End Sub

    '---






    'button pressing

    Private Sub startBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startBut.Click
        Me.ResetGame()
        Me.timeT.Start()

        Me.controlTB.Focus()
    End Sub

    Private Sub pauseBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pauseBut.Click
        If Me.timeT.Enabled Then
            Me.timeT.Stop()
            Me.pauseBut.Text = "Resume"
        Else
            Me.timeT.Start()
            Me.pauseBut.Text = "Pause"

            Me.controlTB.Focus()
        End If
    End Sub

    Private Sub cancelBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBut.Click
        Me.ResetGame()

        Me.controlTB.Focus()
    End Sub

    Private Sub levelBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles levelBut.Click
        levelCMnu.Show(Me.levelBut, New Point(Me.controlTB.Location.X + Me.levelBut.Location.X + Me.levelBut.Width \ 2, Me.controlTB.Location.Y + Me.levelBut.Location.Y + Me.levelBut.Height / 2))

        Me.controlTB.Focus()
    End Sub

    '---





    'menu

    Private Sub menuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuExit.Click
        Me.Dispose(True)
    End Sub


    Private fullScreen As Boolean = False
    Private Sub menuFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFullScreen.Click
        If fullScreen Then
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.menuFullScreen.Text = "Full-Screen"
        Else
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Me.menuFullScreen.Text = "Windowed"
        End If

        Me.fullScreen = Not (Me.fullScreen)

        Me.controlTB.Focus()
    End Sub

    Private Sub menuEasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEasy.Click
        Me.Level = DiffLevel.Easy
        Me.UpdateLevel()

        Me.controlTB.Focus()
    End Sub

    Private Sub menuIntermediate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuIntermediate.Click
        Me.Level = DiffLevel.Intermediate
        Me.UpdateLevel()

        Me.controlTB.Focus()
    End Sub

    Private Sub menuHard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHard.Click
        Me.Level = DiffLevel.Hard
        Me.UpdateLevel()

        Me.controlTB.Focus()
    End Sub



    '-

    Private Sub cMenuEasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cMenuEasy.Click
        Me.Level = DiffLevel.Easy
        Me.UpdateLevel()

        Me.controlTB.Focus()
    End Sub

    Private Sub cMenuIntermediate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cMenuIntermediate.Click
        Me.Level = DiffLevel.Intermediate
        Me.UpdateLevel()

        Me.controlTB.Focus()
    End Sub

    Private Sub cMenuHard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cMenuHard.Click
        Me.Level = DiffLevel.Hard
        Me.UpdateLevel()

        Me.controlTB.Focus()
    End Sub


    Private Sub menuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHelp.Click
        Dim en As Boolean = Me.timeT.Enabled
        Me.timeT.Stop()

        Dim dh As New dialogHelp
        dh.ShowDialog()

        If en Then Me.timeT.Start()
    End Sub

    '---







    Private Sub muteChB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles muteChB.Click
        Me.controlTB.Focus()
    End Sub





    'when click on game panel, you must get control for keyboard
    Private Sub gamePanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gamePanel.Click
        Me.controlTB.Focus()
    End Sub
End Class
