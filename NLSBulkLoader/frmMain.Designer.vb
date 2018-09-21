<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstItems = New System.Windows.Forms.ListView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadXmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.lblHowToTitle = New System.Windows.Forms.Label()
        Me.lblHowTo1 = New System.Windows.Forms.Label()
        Me.lblHowTo2 = New System.Windows.Forms.Label()
        Me.lblHowTo3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstItems
        '
        Me.lstItems.AllowDrop = True
        Me.lstItems.FullRowSelect = True
        Me.lstItems.GridLines = True
        Me.lstItems.Location = New System.Drawing.Point(10, 117)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(779, 358)
        Me.lstItems.TabIndex = 1
        Me.lstItems.UseCompatibleStateImageBehavior = False
        Me.lstItems.View = System.Windows.Forms.View.Details
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadXmlToolStripMenuItem, Me.LoadCSVToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveXMLToolStripMenuItem, Me.SaveCSVToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoadXmlToolStripMenuItem
        '
        Me.LoadXmlToolStripMenuItem.Name = "LoadXmlToolStripMenuItem"
        Me.LoadXmlToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadXmlToolStripMenuItem.Text = "Open NLS &XML"
        '
        'LoadCSVToolStripMenuItem
        '
        Me.LoadCSVToolStripMenuItem.Name = "LoadCSVToolStripMenuItem"
        Me.LoadCSVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadCSVToolStripMenuItem.Text = "Open &CSV"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'SaveXMLToolStripMenuItem
        '
        Me.SaveXMLToolStripMenuItem.Name = "SaveXMLToolStripMenuItem"
        Me.SaveXMLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveXMLToolStripMenuItem.Text = "Save X&ML"
        '
        'SaveCSVToolStripMenuItem
        '
        Me.SaveCSVToolStripMenuItem.Name = "SaveCSVToolStripMenuItem"
        Me.SaveCSVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveCSVToolStripMenuItem.Text = "Save C&SV"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InfoToolStripMenuItem.Text = "&Info"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(100, 24)
        Me.ToolStripButton1.Text = "Open NLS &XML"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(79, 24)
        Me.ToolStripButton2.Text = "Open &CSV"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(98, 24)
        Me.ToolStripButton3.Text = "Save NLS X&ML"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(77, 24)
        Me.ToolStripButton4.Text = "Save C&SV"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripLabel1, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton5})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(30, 20)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(75, 24)
        Me.ToolStripButton5.Text = "Clea&r List"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(280, 20)
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.ForeColor = System.Drawing.Color.Gray
        Me.lblTip.Location = New System.Drawing.Point(12, 478)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(186, 13)
        Me.lblTip.TabIndex = 8
        Me.lblTip.Text = "Tip: Drag and drop files to the list area"
        '
        'lblHowToTitle
        '
        Me.lblHowToTitle.AutoSize = True
        Me.lblHowToTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowToTitle.Location = New System.Drawing.Point(12, 62)
        Me.lblHowToTitle.Name = "lblHowToTitle"
        Me.lblHowToTitle.Size = New System.Drawing.Size(86, 13)
        Me.lblHowToTitle.TabIndex = 9
        Me.lblHowToTitle.Text = "How to use it:"
        '
        'lblHowTo1
        '
        Me.lblHowTo1.AutoSize = True
        Me.lblHowTo1.Location = New System.Drawing.Point(12, 75)
        Me.lblHowTo1.Name = "lblHowTo1"
        Me.lblHowTo1.Size = New System.Drawing.Size(435, 13)
        Me.lblHowTo1.TabIndex = 10
        Me.lblHowTo1.Text = "1 - Open the NLS Resource Manager aspect on 800xA and navigate to the 'XML Data' " &
    "tab"
        '
        'lblHowTo2
        '
        Me.lblHowTo2.AutoSize = True
        Me.lblHowTo2.Location = New System.Drawing.Point(12, 88)
        Me.lblHowTo2.Name = "lblHowTo2"
        Me.lblHowTo2.Size = New System.Drawing.Size(242, 13)
        Me.lblHowTo2.TabIndex = 11
        Me.lblHowTo2.Text = "2 - Click on the 'Extract' button to export it as XML"
        '
        'lblHowTo3
        '
        Me.lblHowTo3.AutoSize = True
        Me.lblHowTo3.Location = New System.Drawing.Point(12, 101)
        Me.lblHowTo3.Name = "lblHowTo3"
        Me.lblHowTo3.Size = New System.Drawing.Size(273, 13)
        Me.lblHowTo3.TabIndex = 12
        Me.lblHowTo3.Text = "3 - Use the 'Open NLS XML' button here to start working"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.lblHowTo3)
        Me.Controls.Add(Me.lblHowTo2)
        Me.Controls.Add(Me.lblHowTo1)
        Me.Controls.Add(Me.lblHowToTitle)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(808, 521)
        Me.Name = "frmMain"
        Me.Text = "NLS Resource Manager Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstItems As ListView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadXmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveXMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblTip As Label
    Friend WithEvents lblHowToTitle As Label
    Friend WithEvents lblHowTo1 As Label
    Friend WithEvents lblHowTo2 As Label
    Friend WithEvents lblHowTo3 As Label
End Class
