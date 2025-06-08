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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NsTheme1 = New BlackBinder.NSTheme()
        Me.NsSeperator1 = New BlackBinder.NSSeperator()
        Me.NsLabel1 = New BlackBinder.NSLabel()
        Me.NsComboBox1 = New BlackBinder.NSComboBox()
        Me.NsButton3 = New BlackBinder.NSButton()
        Me.NsButton2 = New BlackBinder.NSButton()
        Me.NsControlButton1 = New BlackBinder.NSControlButton()
        Me.KachClazz1 = New BlackBinder.KachClazz()
        Me.NsButton1 = New BlackBinder.NSButton()
        Me.NsListView1 = New BlackBinder.NSListView()
        Me.NsTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New BlackBinder.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.NsSeperator1)
        Me.NsTheme1.Controls.Add(Me.NsLabel1)
        Me.NsTheme1.Controls.Add(Me.NsComboBox1)
        Me.NsTheme1.Controls.Add(Me.NsButton3)
        Me.NsTheme1.Controls.Add(Me.NsButton2)
        Me.NsTheme1.Controls.Add(Me.NsControlButton1)
        Me.NsTheme1.Controls.Add(Me.KachClazz1)
        Me.NsTheme1.Controls.Add(Me.NsButton1)
        Me.NsTheme1.Controls.Add(Me.NsListView1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(377, 274)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Black Binder v1.0"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'NsSeperator1
        '
        Me.NsSeperator1.Location = New System.Drawing.Point(12, 223)
        Me.NsSeperator1.Name = "NsSeperator1"
        Me.NsSeperator1.Size = New System.Drawing.Size(353, 14)
        Me.NsSeperator1.TabIndex = 8
        Me.NsSeperator1.Text = "NsSeperator1"
        '
        'NsLabel1
        '
        Me.NsLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NsLabel1.Location = New System.Drawing.Point(11, 194)
        Me.NsLabel1.Name = "NsLabel1"
        Me.NsLabel1.Size = New System.Drawing.Size(37, 23)
        Me.NsLabel1.TabIndex = 7
        Me.NsLabel1.Text = "NsLabel1"
        Me.NsLabel1.Value1 = "Path: "
        Me.NsLabel1.Value2 = ""
        '
        'NsComboBox1
        '
        Me.NsComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.NsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NsComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NsComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.NsComboBox1.FormattingEnabled = True
        Me.NsComboBox1.Items.AddRange(New Object() {"Temp ", "AppData", "UserProfile", "ProgramData", "WinDir"})
        Me.NsComboBox1.Location = New System.Drawing.Point(54, 196)
        Me.NsComboBox1.Name = "NsComboBox1"
        Me.NsComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.NsComboBox1.TabIndex = 6
        '
        'NsButton3
        '
        Me.NsButton3.Location = New System.Drawing.Point(306, 196)
        Me.NsButton3.Name = "NsButton3"
        Me.NsButton3.Size = New System.Drawing.Size(59, 23)
        Me.NsButton3.TabIndex = 5
        Me.NsButton3.Text = "Del File"
        '
        'NsButton2
        '
        Me.NsButton2.Location = New System.Drawing.Point(256, 243)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(109, 23)
        Me.NsButton2.TabIndex = 4
        Me.NsButton2.Text = "Compile Dropper"
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = BlackBinder.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(350, 5)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 3
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'KachClazz1
        '
        Me.KachClazz1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.KachClazz1.Location = New System.Drawing.Point(12, 243)
        Me.KachClazz1.Name = "KachClazz1"
        Me.KachClazz1.Size = New System.Drawing.Size(91, 23)
        Me.KachClazz1.TabIndex = 2
        Me.KachClazz1.Text = "KachClazz1"
        Me.KachClazz1.Value1 = "Black"
        Me.KachClazz1.Value2 = "Hacker"
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(241, 196)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(59, 23)
        Me.NsButton1.TabIndex = 1
        Me.NsButton1.Text = "Add File"
        '
        'NsListView1
        '
        Me.NsListView1.Columns = New BlackBinder.NSListView.NSListViewColumnHeader(-1) {}
        Me.NsListView1.Items = New BlackBinder.NSListView.NSListViewItem(-1) {}
        Me.NsListView1.Location = New System.Drawing.Point(12, 41)
        Me.NsListView1.MultiSelect = True
        Me.NsListView1.Name = "NsListView1"
        Me.NsListView1.Size = New System.Drawing.Size(353, 149)
        Me.NsListView1.TabIndex = 0
        Me.NsListView1.Text = "NsListView1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 274)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Black Binder v1.0"
        Me.NsTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NsTheme1 As BlackBinder.NSTheme
    Friend WithEvents NsButton1 As BlackBinder.NSButton
    Friend WithEvents NsListView1 As BlackBinder.NSListView
    Friend WithEvents NsControlButton1 As BlackBinder.NSControlButton
    Friend WithEvents KachClazz1 As BlackBinder.KachClazz
    Friend WithEvents NsButton2 As BlackBinder.NSButton
    Friend WithEvents NsButton3 As BlackBinder.NSButton
    Friend WithEvents NsComboBox1 As BlackBinder.NSComboBox
    Friend WithEvents NsLabel1 As BlackBinder.NSLabel
    Friend WithEvents NsSeperator1 As BlackBinder.NSSeperator

End Class
