<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Button_Select_Target_Dir = New System.Windows.Forms.Button
        Me.TextBox_Path = New System.Windows.Forms.TextBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button_Open_Target_Dir = New System.Windows.Forms.Button
        Me.LinkLabel_FeedBack = New System.Windows.Forms.LinkLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button_SelectAllOrNothing = New System.Windows.Forms.Button
        Me.Button_ZipStart = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Select_Target_Dir
        '
        Me.Button_Select_Target_Dir.Location = New System.Drawing.Point(465, 22)
        Me.Button_Select_Target_Dir.Name = "Button_Select_Target_Dir"
        Me.Button_Select_Target_Dir.Size = New System.Drawing.Size(171, 25)
        Me.Button_Select_Target_Dir.TabIndex = 0
        Me.Button_Select_Target_Dir.Text = "Select Target Directory"
        Me.Button_Select_Target_Dir.UseVisualStyleBackColor = True
        '
        'TextBox_Path
        '
        Me.TextBox_Path.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox_Path.Location = New System.Drawing.Point(5, 22)
        Me.TextBox_Path.Name = "TextBox_Path"
        Me.TextBox_Path.ReadOnly = True
        Me.TextBox_Path.Size = New System.Drawing.Size(455, 20)
        Me.TextBox_Path.TabIndex = 1
        Me.TextBox_Path.Text = "Select Target Directory"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(3, 16)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(634, 240)
        Me.CheckedListBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button_Open_Target_Dir)
        Me.GroupBox1.Controls.Add(Me.Button_Select_Target_Dir)
        Me.GroupBox1.Controls.Add(Me.TextBox_Path)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 96)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(439, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Below listbox shows folders that under target directory. Please select folders yo" & _
            "u want to zip."
        '
        'Button_Open_Target_Dir
        '
        Me.Button_Open_Target_Dir.Location = New System.Drawing.Point(465, 52)
        Me.Button_Open_Target_Dir.Name = "Button_Open_Target_Dir"
        Me.Button_Open_Target_Dir.Size = New System.Drawing.Size(171, 25)
        Me.Button_Open_Target_Dir.TabIndex = 2
        Me.Button_Open_Target_Dir.Text = "Open Target Directory"
        Me.Button_Open_Target_Dir.UseVisualStyleBackColor = True
        '
        'LinkLabel_FeedBack
        '
        Me.LinkLabel_FeedBack.AutoSize = True
        Me.LinkLabel_FeedBack.Location = New System.Drawing.Point(456, 121)
        Me.LinkLabel_FeedBack.Name = "LinkLabel_FeedBack"
        Me.LinkLabel_FeedBack.Size = New System.Drawing.Size(176, 13)
        Me.LinkLabel_FeedBack.TabIndex = 3
        Me.LinkLabel_FeedBack.TabStop = True
        Me.LinkLabel_FeedBack.Text = "Feedback, Send an opinion in email"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.LinkLabel_FeedBack)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button_SelectAllOrNothing)
        Me.GroupBox2.Controls.Add(Me.Button_ZipStart)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 355)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 138)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(5, 83)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(628, 25)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gulim", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "It creates a seperate zip file for each folder you selected"
        '
        'Button_SelectAllOrNothing
        '
        Me.Button_SelectAllOrNothing.Location = New System.Drawing.Point(465, 21)
        Me.Button_SelectAllOrNothing.Name = "Button_SelectAllOrNothing"
        Me.Button_SelectAllOrNothing.Size = New System.Drawing.Size(171, 25)
        Me.Button_SelectAllOrNothing.TabIndex = 1
        Me.Button_SelectAllOrNothing.Text = "Select/Unselect All Folders"
        Me.Button_SelectAllOrNothing.UseVisualStyleBackColor = True
        '
        'Button_ZipStart
        '
        Me.Button_ZipStart.Font = New System.Drawing.Font("Gulim", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ZipStart.Location = New System.Drawing.Point(465, 52)
        Me.Button_ZipStart.Name = "Button_ZipStart"
        Me.Button_ZipStart.Size = New System.Drawing.Size(171, 25)
        Me.Button_ZipStart.TabIndex = 0
        Me.Button_ZipStart.Text = "Start Zipping Them All"
        Me.Button_ZipStart.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 259)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 493)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Massive ZIP 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Select_Target_Dir As System.Windows.Forms.Button
    Friend WithEvents TextBox_Path As System.Windows.Forms.TextBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_ZipStart As System.Windows.Forms.Button
    Friend WithEvents Button_SelectAllOrNothing As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button_Open_Target_Dir As System.Windows.Forms.Button
    Friend WithEvents LinkLabel_FeedBack As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
