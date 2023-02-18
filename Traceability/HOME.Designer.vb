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
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonOrbOptionButton1 = New System.Windows.Forms.RibbonOrbOptionButton()
        Me.RibbonOrbMenuItem1 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbRecentItem1 = New System.Windows.Forms.RibbonOrbRecentItem()
        Me.RibbonOrbRecentItem2 = New System.Windows.Forms.RibbonOrbRecentItem()
        Me.RibbonOrbRecentItem3 = New System.Windows.Forms.RibbonOrbRecentItem()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(1321, 721)
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
        Me.Ribbon1.OrbDropDown.OptionItems.Add(Me.RibbonOrbOptionButton1)
        Me.Ribbon1.OrbDropDown.RecentItems.Add(Me.RibbonOrbRecentItem1)
        Me.Ribbon1.OrbDropDown.RecentItems.Add(Me.RibbonOrbRecentItem2)
        Me.Ribbon1.OrbDropDown.RecentItems.Add(Me.RibbonOrbRecentItem3)
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 136)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1321, 153)
        Me.Ribbon1.TabIndex = 2
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "RibbonTab1"
        '
        'RibbonOrbOptionButton1
        '
        Me.RibbonOrbOptionButton1.Image = CType(resources.GetObject("RibbonOrbOptionButton1.Image"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.LargeImage = CType(resources.GetObject("RibbonOrbOptionButton1.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.Name = "RibbonOrbOptionButton1"
        Me.RibbonOrbOptionButton1.SmallImage = CType(resources.GetObject("RibbonOrbOptionButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbOptionButton1.Text = "RibbonOrbOptionButton1"
        '
        'RibbonOrbMenuItem1
        '
        Me.RibbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem1.Image = CType(resources.GetObject("RibbonOrbMenuItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.LargeImage = CType(resources.GetObject("RibbonOrbMenuItem1.LargeImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Name = "RibbonOrbMenuItem1"
        Me.RibbonOrbMenuItem1.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Text = "RibbonOrbMenuItem1"
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
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 721)
        Me.Controls.Add(Me.Ribbon1)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Name = "HOME"
        Me.Text = "Traceability"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RibbonOrbMenuItem1 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbOptionButton1 As RibbonOrbOptionButton
    Friend WithEvents RibbonOrbRecentItem1 As RibbonOrbRecentItem
    Friend WithEvents RibbonOrbRecentItem2 As RibbonOrbRecentItem
    Friend WithEvents RibbonOrbRecentItem3 As RibbonOrbRecentItem
    Friend WithEvents RibbonTab1 As RibbonTab
End Class
