<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numNCode = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bxPrefix = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstGenerated = New System.Windows.Forms.ListBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckSort = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ckHyphen = New System.Windows.Forms.CheckBox()
        Me.btnTFile = New System.Windows.Forms.Button()
        Me.fileSave = New System.Windows.Forms.SaveFileDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numNCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numNCode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.bxPrefix)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'numNCode
        '
        Me.numNCode.Location = New System.Drawing.Point(73, 45)
        Me.numNCode.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numNCode.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNCode.Name = "numNCode"
        Me.numNCode.Size = New System.Drawing.Size(43, 20)
        Me.numNCode.TabIndex = 5
        Me.numNCode.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No of Codes:"
        '
        'bxPrefix
        '
        Me.bxPrefix.Location = New System.Drawing.Point(42, 19)
        Me.bxPrefix.Name = "bxPrefix"
        Me.bxPrefix.Size = New System.Drawing.Size(194, 20)
        Me.bxPrefix.TabIndex = 1
        Me.bxPrefix.Text = "VCG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prefix:"
        '
        'lstGenerated
        '
        Me.lstGenerated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGenerated.FormattingEnabled = True
        Me.lstGenerated.ItemHeight = 15
        Me.lstGenerated.Location = New System.Drawing.Point(6, 19)
        Me.lstGenerated.Name = "lstGenerated"
        Me.lstGenerated.Size = New System.Drawing.Size(238, 199)
        Me.lstGenerated.TabIndex = 2
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(183, 450)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckSort)
        Me.GroupBox2.Controls.Add(Me.lstGenerated)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 252)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generated Codes"
        '
        'ckSort
        '
        Me.ckSort.AutoSize = True
        Me.ckSort.Location = New System.Drawing.Point(6, 225)
        Me.ckSort.Name = "ckSort"
        Me.ckSort.Size = New System.Drawing.Size(77, 17)
        Me.ckSort.TabIndex = 3
        Me.ckSort.Text = "Sort codes"
        Me.ckSort.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.ckHyphen)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 88)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prefix Case:"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(152, 63)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Regular"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(96, 63)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "lower"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(4, 63)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CAPITALISE"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ckHyphen
        '
        Me.ckHyphen.AutoSize = True
        Me.ckHyphen.Checked = True
        Me.ckHyphen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckHyphen.Location = New System.Drawing.Point(6, 19)
        Me.ckHyphen.Name = "ckHyphen"
        Me.ckHyphen.Size = New System.Drawing.Size(99, 17)
        Me.ckHyphen.TabIndex = 0
        Me.ckHyphen.Text = "Include hyphen"
        Me.ckHyphen.UseVisualStyleBackColor = True
        '
        'btnTFile
        '
        Me.btnTFile.Location = New System.Drawing.Point(96, 450)
        Me.btnTFile.Name = "btnTFile"
        Me.btnTFile.Size = New System.Drawing.Size(75, 23)
        Me.btnTFile.TabIndex = 3
        Me.btnTFile.Text = "To File"
        Me.btnTFile.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(9, 450)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear list"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "/generate"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 482)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTFile)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Voucher Code Gen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numNCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bxPrefix As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lstGenerated As ListBox
    Friend WithEvents numNCode As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ckHyphen As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnTFile As Button
    Friend WithEvents fileSave As SaveFileDialog
    Friend WithEvents ckSort As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
End Class
