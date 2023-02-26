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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.foodicon1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.foodicon = New System.Windows.Forms.Label()
        Me.FoodsListBox1 = New System.Windows.Forms.ListBox()
        Me.Drinkicon = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DrinksListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.paragelia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posotita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimiMonadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stimi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-4, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(804, 453)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(796, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ΦΟΡΜΑ ΠΑΡΑΓΓΕΛΙΑΣ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AccessibleName = ""
        Me.SplitContainer1.Panel1.Controls.Add(Me.foodicon1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.foodicon)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FoodsListBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Drinkicon)
        Me.SplitContainer1.Panel2.Controls.Add(Me.NumericUpDown2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DrinksListBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(790, 418)
        Me.SplitContainer1.SplitterDistance = 359
        Me.SplitContainer1.TabIndex = 0
        '
        'foodicon1
        '
        Me.foodicon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.foodicon1.Location = New System.Drawing.Point(132, 79)
        Me.foodicon1.Name = "foodicon1"
        Me.foodicon1.Size = New System.Drawing.Size(207, 225)
        Me.foodicon1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Προσθέστε στη παραγγελία"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(141, 51)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 22)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'foodicon
        '
        Me.foodicon.AutoSize = True
        Me.foodicon.Location = New System.Drawing.Point(225, 79)
        Me.foodicon.Name = "foodicon"
        Me.foodicon.Size = New System.Drawing.Size(0, 17)
        Me.foodicon.TabIndex = 1
        '
        'FoodsListBox1
        '
        Me.FoodsListBox1.AccessibleName = "Foods"
        Me.FoodsListBox1.FormattingEnabled = True
        Me.FoodsListBox1.ItemHeight = 16
        Me.FoodsListBox1.Location = New System.Drawing.Point(9, 51)
        Me.FoodsListBox1.Name = "FoodsListBox1"
        Me.FoodsListBox1.Size = New System.Drawing.Size(117, 84)
        Me.FoodsListBox1.TabIndex = 0
        '
        'Drinkicon
        '
        Me.Drinkicon.Enabled = False
        Me.Drinkicon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(200, Byte), True)
        Me.Drinkicon.Location = New System.Drawing.Point(149, 79)
        Me.Drinkicon.Name = "Drinkicon"
        Me.Drinkicon.Size = New System.Drawing.Size(207, 228)
        Me.Drinkicon.TabIndex = 3
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(154, 51)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(53, 22)
        Me.NumericUpDown2.TabIndex = 2
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(212, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Προσθέστε στη παραγγελία"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DrinksListBox1
        '
        Me.DrinksListBox1.AccessibleName = "Drinks"
        Me.DrinksListBox1.FormattingEnabled = True
        Me.DrinksListBox1.ItemHeight = 16
        Me.DrinksListBox1.Location = New System.Drawing.Point(18, 51)
        Me.DrinksListBox1.Name = "DrinksListBox1"
        Me.DrinksListBox1.Size = New System.Drawing.Size(120, 84)
        Me.DrinksListBox1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(796, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ΣΥΝΟΛΙΚΗ ΠΑΡΑΓΓΕΛΙΑ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.paragelia, Me.Posotita, Me.TimiMonadas})
        Me.DataGridView1.Location = New System.Drawing.Point(61, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(429, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'paragelia
        '
        Me.paragelia.HeaderText = "Παραγγελία"
        Me.paragelia.MinimumWidth = 6
        Me.paragelia.Name = "paragelia"
        Me.paragelia.Width = 125
        '
        'Posotita
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Posotita.DefaultCellStyle = DataGridViewCellStyle1
        Me.Posotita.HeaderText = "Ποσότητα"
        Me.Posotita.MinimumWidth = 6
        Me.Posotita.Name = "Posotita"
        Me.Posotita.Width = 125
        '
        'TimiMonadas
        '
        DataGridViewCellStyle2.NullValue = "0"
        Me.TimiMonadas.DefaultCellStyle = DataGridViewCellStyle2
        Me.TimiMonadas.HeaderText = "Τιμή Μονάδας"
        Me.TimiMonadas.MinimumWidth = 6
        Me.TimiMonadas.Name = "TimiMonadas"
        Me.TimiMonadas.Width = 125
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.stimi)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(61, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 119)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ευρώ"
        '
        'stimi
        '
        Me.stimi.AutoSize = True
        Me.stimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.stimi.Location = New System.Drawing.Point(211, 26)
        Me.stimi.Name = "stimi"
        Me.stimi.Size = New System.Drawing.Size(17, 17)
        Me.stimi.TabIndex = 1
        Me.stimi.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Συνολική τιμή:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Ο ΚΩΣΤΑΣ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FoodsListBox1 As ListBox
    Friend WithEvents foodicon As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DrinksListBox1 As ListBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents Drinkicon As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents stimi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents paragelia As DataGridViewTextBoxColumn
    Friend WithEvents Posotita As DataGridViewTextBoxColumn
    Friend WithEvents TimiMonadas As DataGridViewTextBoxColumn
    Friend WithEvents foodicon1 As Label
End Class
