<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonOrbMenuItem1 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbOptionButtonExit = New System.Windows.Forms.RibbonOrbOptionButton()
        Me.RibbonOrbRecentItem1 = New System.Windows.Forms.RibbonOrbRecentItem()
        Me.RibbonOrbRecentItem2 = New System.Windows.Forms.RibbonOrbRecentItem()
        Me.RibbonOrbRecentItem3 = New System.Windows.Forms.RibbonOrbRecentItem()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanelST1Proccess = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonST1Proccess = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanelST1Traceability = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonST1Traceability = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanelST1Tracking = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonST1Tracking = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanelST1Modbus = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonST1Modbus = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanelST1Database = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonST1Database = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonST1Printer = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.RibbonTab3 = New System.Windows.Forms.RibbonTab()
        Me.RibbonTab4 = New System.Windows.Forms.RibbonTab()
        Me.RibbonTab5 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonTraceST1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonST1Track = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButtonST2Settings = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab6 = New System.Windows.Forms.RibbonTab()
        Me.RibbonUpDown1 = New System.Windows.Forms.RibbonUpDown()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.AutoSize = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 152)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(1321, 569)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 1
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.LargeImage = CType(resources.GetObject("RibbonButton1.LargeImage"), System.Drawing.Image)
        Me.RibbonButton1.Name = "RibbonButton1"
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem1)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.OptionItems.Add(Me.RibbonOrbOptionButtonExit)
        Me.Ribbon1.OrbDropDown.RecentItems.Add(Me.RibbonOrbRecentItem1)
        Me.Ribbon1.OrbDropDown.RecentItems.Add(Me.RibbonOrbRecentItem2)
        Me.Ribbon1.OrbDropDown.RecentItems.Add(Me.RibbonOrbRecentItem3)
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 136)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1321, 153)
        Me.Ribbon1.TabIndex = 2
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab4)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab5)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab6)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        '
        'RibbonOrbMenuItem1
        '
        Me.RibbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem1.Image = CType(resources.GetObject("RibbonOrbMenuItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.LargeImage = CType(resources.GetObject("RibbonOrbMenuItem1.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Name = "RibbonOrbMenuItem1"
        Me.RibbonOrbMenuItem1.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Text = "Login"
        '
        'RibbonOrbOptionButtonExit
        '
        Me.RibbonOrbOptionButtonExit.Image = CType(resources.GetObject("RibbonOrbOptionButtonExit.Image"), System.Drawing.Image)
        Me.RibbonOrbOptionButtonExit.LargeImage = CType(resources.GetObject("RibbonOrbOptionButtonExit.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButtonExit.Name = "RibbonOrbOptionButtonExit"
        Me.RibbonOrbOptionButtonExit.SmallImage = CType(resources.GetObject("RibbonOrbOptionButtonExit.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButtonExit.Text = "Exit"
        '
        'RibbonOrbRecentItem1
        '
        Me.RibbonOrbRecentItem1.Image = CType(resources.GetObject("RibbonOrbRecentItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbRecentItem1.LargeImage = CType(resources.GetObject("RibbonOrbRecentItem1.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbRecentItem1.Name = "RibbonOrbRecentItem1"
        Me.RibbonOrbRecentItem1.SmallImage = CType(resources.GetObject("RibbonOrbRecentItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbRecentItem1.Text = "RibbonOrbRecentItem1"
        '
        'RibbonOrbRecentItem2
        '
        Me.RibbonOrbRecentItem2.Image = CType(resources.GetObject("RibbonOrbRecentItem2.Image"), System.Drawing.Image)
        Me.RibbonOrbRecentItem2.LargeImage = CType(resources.GetObject("RibbonOrbRecentItem2.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbRecentItem2.Name = "RibbonOrbRecentItem2"
        Me.RibbonOrbRecentItem2.SmallImage = CType(resources.GetObject("RibbonOrbRecentItem2.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbRecentItem2.Text = "RibbonOrbRecentItem2"
        '
        'RibbonOrbRecentItem3
        '
        Me.RibbonOrbRecentItem3.Image = CType(resources.GetObject("RibbonOrbRecentItem3.Image"), System.Drawing.Image)
        Me.RibbonOrbRecentItem3.LargeImage = CType(resources.GetObject("RibbonOrbRecentItem3.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbRecentItem3.Name = "RibbonOrbRecentItem3"
        Me.RibbonOrbRecentItem3.SmallImage = CType(resources.GetObject("RibbonOrbRecentItem3.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbRecentItem3.Text = "RibbonOrbRecentItem3"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Panels.Add(Me.RibbonPanelST1Proccess)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanelST1Traceability)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanelST1Tracking)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanelST1Modbus)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanelST1Database)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab1.Text = "Station 1"
        '
        'RibbonPanelST1Proccess
        '
        Me.RibbonPanelST1Proccess.Items.Add(Me.RibbonButtonST1Proccess)
        Me.RibbonPanelST1Proccess.Name = "RibbonPanelST1Proccess"
        Me.RibbonPanelST1Proccess.Text = "Proccess"
        '
        'RibbonButtonST1Proccess
        '
        Me.RibbonButtonST1Proccess.Image = CType(resources.GetObject("RibbonButtonST1Proccess.Image"), System.Drawing.Image)
        Me.RibbonButtonST1Proccess.LargeImage = CType(resources.GetObject("RibbonButtonST1Proccess.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonST1Proccess.Name = "RibbonButtonST1Proccess"
        Me.RibbonButtonST1Proccess.SmallImage = CType(resources.GetObject("RibbonButtonST1Proccess.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanelST1Traceability
        '
        Me.RibbonPanelST1Traceability.Items.Add(Me.RibbonButtonST1Traceability)
        Me.RibbonPanelST1Traceability.Name = "RibbonPanelST1Traceability"
        Me.RibbonPanelST1Traceability.Text = "Traceability"
        '
        'RibbonButtonST1Traceability
        '
        Me.RibbonButtonST1Traceability.Image = CType(resources.GetObject("RibbonButtonST1Traceability.Image"), System.Drawing.Image)
        Me.RibbonButtonST1Traceability.LargeImage = CType(resources.GetObject("RibbonButtonST1Traceability.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonST1Traceability.Name = "RibbonButtonST1Traceability"
        Me.RibbonButtonST1Traceability.SmallImage = CType(resources.GetObject("RibbonButtonST1Traceability.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanelST1Tracking
        '
        Me.RibbonPanelST1Tracking.Items.Add(Me.RibbonButtonST1Tracking)
        Me.RibbonPanelST1Tracking.Name = "RibbonPanelST1Tracking"
        Me.RibbonPanelST1Tracking.Text = "Tracking"
        '
        'RibbonButtonST1Tracking
        '
        Me.RibbonButtonST1Tracking.Image = CType(resources.GetObject("RibbonButtonST1Tracking.Image"), System.Drawing.Image)
        Me.RibbonButtonST1Tracking.LargeImage = CType(resources.GetObject("RibbonButtonST1Tracking.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonST1Tracking.Name = "RibbonButtonST1Tracking"
        Me.RibbonButtonST1Tracking.SmallImage = CType(resources.GetObject("RibbonButtonST1Tracking.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanelST1Modbus
        '
        Me.RibbonPanelST1Modbus.Items.Add(Me.RibbonButtonST1Modbus)
        Me.RibbonPanelST1Modbus.Name = "RibbonPanelST1Modbus"
        Me.RibbonPanelST1Modbus.Text = "Modbus"
        '
        'RibbonButtonST1Modbus
        '
        Me.RibbonButtonST1Modbus.Image = CType(resources.GetObject("RibbonButtonST1Modbus.Image"), System.Drawing.Image)
        Me.RibbonButtonST1Modbus.LargeImage = CType(resources.GetObject("RibbonButtonST1Modbus.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonST1Modbus.Name = "RibbonButtonST1Modbus"
        Me.RibbonButtonST1Modbus.SmallImage = CType(resources.GetObject("RibbonButtonST1Modbus.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanelST1Database
        '
        Me.RibbonPanelST1Database.Items.Add(Me.RibbonButtonST1Database)
        Me.RibbonPanelST1Database.Name = "RibbonPanelST1Database"
        Me.RibbonPanelST1Database.Text = "Database"
        '
        'RibbonButtonST1Database
        '
        Me.RibbonButtonST1Database.Image = CType(resources.GetObject("RibbonButtonST1Database.Image"), System.Drawing.Image)
        Me.RibbonButtonST1Database.LargeImage = CType(resources.GetObject("RibbonButtonST1Database.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonST1Database.Name = "RibbonButtonST1Database"
        Me.RibbonButtonST1Database.SmallImage = CType(resources.GetObject("RibbonButtonST1Database.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.RibbonButtonST1Printer)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Text = "Printer"
        '
        'RibbonButtonST1Printer
        '
        Me.RibbonButtonST1Printer.Image = CType(resources.GetObject("RibbonButtonST1Printer.Image"), System.Drawing.Image)
        Me.RibbonButtonST1Printer.LargeImage = CType(resources.GetObject("RibbonButtonST1Printer.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonST1Printer.Name = "RibbonButtonST1Printer"
        Me.RibbonButtonST1Printer.SmallImage = CType(resources.GetObject("RibbonButtonST1Printer.SmallImage"), System.Drawing.Image)
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Text = "Station 2"
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Name = "RibbonTab3"
        Me.RibbonTab3.Text = "Station 3"
        '
        'RibbonTab4
        '
        Me.RibbonTab4.Name = "RibbonTab4"
        Me.RibbonTab4.Text = "Station 4"
        '
        'RibbonTab5
        '
        Me.RibbonTab5.Name = "RibbonTab5"
        Me.RibbonTab5.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab5.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab5.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab5.Text = "Station 5"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.RibbonButtonTraceST1)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Text = "Traceability"
        '
        'RibbonButtonTraceST1
        '
        Me.RibbonButtonTraceST1.Image = CType(resources.GetObject("RibbonButtonTraceST1.Image"), System.Drawing.Image)
        Me.RibbonButtonTraceST1.LargeImage = CType(resources.GetObject("RibbonButtonTraceST1.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonTraceST1.Name = "RibbonButtonTraceST1"
        Me.RibbonButtonTraceST1.SmallImage = CType(resources.GetObject("RibbonButtonTraceST1.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.RibbonButtonST1Track)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Text = "Tracking"
        '
        'RibbonButtonST1Track
        '
        Me.RibbonButtonST1Track.Image = CType(resources.GetObject("RibbonButtonST1Track.Image"), System.Drawing.Image)
        Me.RibbonButtonST1Track.LargeImage = CType(resources.GetObject("RibbonButtonST1Track.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonST1Track.Name = "RibbonButtonST1Track"
        Me.RibbonButtonST1Track.SmallImage = CType(resources.GetObject("RibbonButtonST1Track.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.RibbonButtonST2Settings)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Text = "Settings"
        '
        'RibbonButtonST2Settings
        '
        Me.RibbonButtonST2Settings.Image = CType(resources.GetObject("RibbonButtonST2Settings.Image"), System.Drawing.Image)
        Me.RibbonButtonST2Settings.LargeImage = CType(resources.GetObject("RibbonButtonST2Settings.LargeImage"), System.Drawing.Image)
        Me.RibbonButtonST2Settings.Name = "RibbonButtonST2Settings"
        Me.RibbonButtonST2Settings.SmallImage = CType(resources.GetObject("RibbonButtonST2Settings.SmallImage"), System.Drawing.Image)
        '
        'RibbonTab6
        '
        Me.RibbonTab6.Name = "RibbonTab6"
        Me.RibbonTab6.Text = "Station 6"
        '
        'RibbonUpDown1
        '
        Me.RibbonUpDown1.Name = "RibbonUpDown1"
        Me.RibbonUpDown1.TextBoxText = ""
        Me.RibbonUpDown1.TextBoxWidth = 50
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 721)
        Me.Controls.Add(Me.Ribbon1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "HOME"
        Me.Text = "Traceability"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RibbonOrbMenuItem1 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbOptionButtonExit As RibbonOrbOptionButton
    Friend WithEvents RibbonOrbRecentItem1 As RibbonOrbRecentItem
    Friend WithEvents RibbonOrbRecentItem2 As RibbonOrbRecentItem
    Friend WithEvents RibbonOrbRecentItem3 As RibbonOrbRecentItem
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonTab2 As RibbonTab
    Friend WithEvents RibbonTab3 As RibbonTab
    Friend WithEvents RibbonTab4 As RibbonTab
    Friend WithEvents RibbonTab5 As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonButtonTraceST1 As RibbonButton
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents RibbonButtonST1Track As RibbonButton
    Friend WithEvents RibbonPanel3 As RibbonPanel
    Friend WithEvents RibbonButtonST2Settings As RibbonButton
    Friend WithEvents RibbonPanelST1Traceability As RibbonPanel
    Friend WithEvents RibbonButtonST1Traceability As RibbonButton
    Friend WithEvents RibbonPanelST1Tracking As RibbonPanel
    Friend WithEvents RibbonPanel6 As RibbonPanel
    Friend WithEvents RibbonButtonST1Tracking As RibbonButton
    Friend WithEvents RibbonPanelST1Modbus As RibbonPanel
    Friend WithEvents RibbonButtonST1Modbus As RibbonButton
    Friend WithEvents RibbonPanelST1Database As RibbonPanel
    Friend WithEvents RibbonButtonST1Database As RibbonButton
    Friend WithEvents RibbonPanelST1Proccess As RibbonPanel
    Friend WithEvents RibbonButtonST1Proccess As RibbonButton
    Friend WithEvents RibbonPanel4 As RibbonPanel
    Friend WithEvents RibbonButtonST1Printer As RibbonButton
    Friend WithEvents RibbonTab6 As RibbonTab
    Friend WithEvents RibbonUpDown1 As RibbonUpDown
End Class
