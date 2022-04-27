<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shapes
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
        Me.grpBoxRect = New System.Windows.Forms.GroupBox()
        Me.lblRectAreaCalc = New System.Windows.Forms.Label()
        Me.lblRectYCalc = New System.Windows.Forms.Label()
        Me.lblRectXCalc = New System.Windows.Forms.Label()
        Me.lblRectArea = New System.Windows.Forms.Label()
        Me.lblRectY = New System.Windows.Forms.Label()
        Me.lblRectX = New System.Windows.Forms.Label()
        Me.grpBoxTriangle = New System.Windows.Forms.GroupBox()
        Me.lblTriAreaCalc = New System.Windows.Forms.Label()
        Me.lblTriArea = New System.Windows.Forms.Label()
        Me.lblTriYCalc = New System.Windows.Forms.Label()
        Me.lblTriXCalc = New System.Windows.Forms.Label()
        Me.lblTriY = New System.Windows.Forms.Label()
        Me.lblTriX = New System.Windows.Forms.Label()
        Me.grpBoxCircle = New System.Windows.Forms.GroupBox()
        Me.lblCircAreaCalc = New System.Windows.Forms.Label()
        Me.lblCircArea = New System.Windows.Forms.Label()
        Me.lblCircYCalc = New System.Windows.Forms.Label()
        Me.lblCircXCalc = New System.Windows.Forms.Label()
        Me.lblCircY = New System.Windows.Forms.Label()
        Me.lblCircX = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtDiameter = New System.Windows.Forms.TextBox()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblDiameter = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboSelect = New System.Windows.Forms.ComboBox()
        Me.grpBoxRect.SuspendLayout()
        Me.grpBoxTriangle.SuspendLayout()
        Me.grpBoxCircle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxRect
        '
        Me.grpBoxRect.Controls.Add(Me.lblRectAreaCalc)
        Me.grpBoxRect.Controls.Add(Me.lblRectYCalc)
        Me.grpBoxRect.Controls.Add(Me.lblRectXCalc)
        Me.grpBoxRect.Controls.Add(Me.lblRectArea)
        Me.grpBoxRect.Controls.Add(Me.lblRectY)
        Me.grpBoxRect.Controls.Add(Me.lblRectX)
        Me.grpBoxRect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxRect.Location = New System.Drawing.Point(12, 267)
        Me.grpBoxRect.Name = "grpBoxRect"
        Me.grpBoxRect.Size = New System.Drawing.Size(170, 248)
        Me.grpBoxRect.TabIndex = 0
        Me.grpBoxRect.TabStop = False
        Me.grpBoxRect.Text = "Rectangle"
        '
        'lblRectAreaCalc
        '
        Me.lblRectAreaCalc.AutoSize = True
        Me.lblRectAreaCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRectAreaCalc.Location = New System.Drawing.Point(20, 205)
        Me.lblRectAreaCalc.Name = "lblRectAreaCalc"
        Me.lblRectAreaCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblRectAreaCalc.TabIndex = 15
        Me.lblRectAreaCalc.Text = "0"
        '
        'lblRectYCalc
        '
        Me.lblRectYCalc.AutoSize = True
        Me.lblRectYCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRectYCalc.Location = New System.Drawing.Point(20, 137)
        Me.lblRectYCalc.Name = "lblRectYCalc"
        Me.lblRectYCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblRectYCalc.TabIndex = 14
        Me.lblRectYCalc.Text = "0"
        '
        'lblRectXCalc
        '
        Me.lblRectXCalc.AutoSize = True
        Me.lblRectXCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblRectXCalc.Location = New System.Drawing.Point(20, 61)
        Me.lblRectXCalc.Name = "lblRectXCalc"
        Me.lblRectXCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblRectXCalc.TabIndex = 13
        Me.lblRectXCalc.Text = "0"
        '
        'lblRectArea
        '
        Me.lblRectArea.AutoSize = True
        Me.lblRectArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRectArea.Location = New System.Drawing.Point(17, 175)
        Me.lblRectArea.Name = "lblRectArea"
        Me.lblRectArea.Size = New System.Drawing.Size(41, 16)
        Me.lblRectArea.TabIndex = 12
        Me.lblRectArea.Text = "Area"
        '
        'lblRectY
        '
        Me.lblRectY.AutoSize = True
        Me.lblRectY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRectY.Location = New System.Drawing.Point(17, 98)
        Me.lblRectY.Name = "lblRectY"
        Me.lblRectY.Size = New System.Drawing.Size(89, 16)
        Me.lblRectY.TabIndex = 11
        Me.lblRectY.Text = "Centroid - Y"
        '
        'lblRectX
        '
        Me.lblRectX.AutoSize = True
        Me.lblRectX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRectX.Location = New System.Drawing.Point(20, 31)
        Me.lblRectX.Name = "lblRectX"
        Me.lblRectX.Size = New System.Drawing.Size(88, 16)
        Me.lblRectX.TabIndex = 10
        Me.lblRectX.Text = "Centroid - X"
        '
        'grpBoxTriangle
        '
        Me.grpBoxTriangle.Controls.Add(Me.lblTriAreaCalc)
        Me.grpBoxTriangle.Controls.Add(Me.lblTriArea)
        Me.grpBoxTriangle.Controls.Add(Me.lblTriYCalc)
        Me.grpBoxTriangle.Controls.Add(Me.lblTriXCalc)
        Me.grpBoxTriangle.Controls.Add(Me.lblTriY)
        Me.grpBoxTriangle.Controls.Add(Me.lblTriX)
        Me.grpBoxTriangle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxTriangle.Location = New System.Drawing.Point(188, 267)
        Me.grpBoxTriangle.Name = "grpBoxTriangle"
        Me.grpBoxTriangle.Size = New System.Drawing.Size(167, 248)
        Me.grpBoxTriangle.TabIndex = 1
        Me.grpBoxTriangle.TabStop = False
        Me.grpBoxTriangle.Text = "Triangle"
        '
        'lblTriAreaCalc
        '
        Me.lblTriAreaCalc.AutoSize = True
        Me.lblTriAreaCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTriAreaCalc.Location = New System.Drawing.Point(16, 205)
        Me.lblTriAreaCalc.Name = "lblTriAreaCalc"
        Me.lblTriAreaCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblTriAreaCalc.TabIndex = 18
        Me.lblTriAreaCalc.Text = "0"
        '
        'lblTriArea
        '
        Me.lblTriArea.AutoSize = True
        Me.lblTriArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriArea.Location = New System.Drawing.Point(16, 175)
        Me.lblTriArea.Name = "lblTriArea"
        Me.lblTriArea.Size = New System.Drawing.Size(41, 16)
        Me.lblTriArea.TabIndex = 15
        Me.lblTriArea.Text = "Area"
        '
        'lblTriYCalc
        '
        Me.lblTriYCalc.AutoSize = True
        Me.lblTriYCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTriYCalc.Location = New System.Drawing.Point(16, 137)
        Me.lblTriYCalc.Name = "lblTriYCalc"
        Me.lblTriYCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblTriYCalc.TabIndex = 17
        Me.lblTriYCalc.Text = "0"
        '
        'lblTriXCalc
        '
        Me.lblTriXCalc.AutoSize = True
        Me.lblTriXCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTriXCalc.Location = New System.Drawing.Point(16, 61)
        Me.lblTriXCalc.Name = "lblTriXCalc"
        Me.lblTriXCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblTriXCalc.TabIndex = 16
        Me.lblTriXCalc.Text = "0"
        '
        'lblTriY
        '
        Me.lblTriY.AutoSize = True
        Me.lblTriY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriY.Location = New System.Drawing.Point(16, 98)
        Me.lblTriY.Name = "lblTriY"
        Me.lblTriY.Size = New System.Drawing.Size(89, 16)
        Me.lblTriY.TabIndex = 14
        Me.lblTriY.Text = "Centroid - Y"
        '
        'lblTriX
        '
        Me.lblTriX.AutoSize = True
        Me.lblTriX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriX.Location = New System.Drawing.Point(16, 31)
        Me.lblTriX.Name = "lblTriX"
        Me.lblTriX.Size = New System.Drawing.Size(88, 16)
        Me.lblTriX.TabIndex = 13
        Me.lblTriX.Text = "Centroid - X"
        '
        'grpBoxCircle
        '
        Me.grpBoxCircle.Controls.Add(Me.lblCircAreaCalc)
        Me.grpBoxCircle.Controls.Add(Me.lblCircArea)
        Me.grpBoxCircle.Controls.Add(Me.lblCircYCalc)
        Me.grpBoxCircle.Controls.Add(Me.lblCircXCalc)
        Me.grpBoxCircle.Controls.Add(Me.lblCircY)
        Me.grpBoxCircle.Controls.Add(Me.lblCircX)
        Me.grpBoxCircle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBoxCircle.Location = New System.Drawing.Point(361, 267)
        Me.grpBoxCircle.Name = "grpBoxCircle"
        Me.grpBoxCircle.Size = New System.Drawing.Size(152, 248)
        Me.grpBoxCircle.TabIndex = 1
        Me.grpBoxCircle.TabStop = False
        Me.grpBoxCircle.Text = "Circle"
        '
        'lblCircAreaCalc
        '
        Me.lblCircAreaCalc.AutoSize = True
        Me.lblCircAreaCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCircAreaCalc.Location = New System.Drawing.Point(8, 205)
        Me.lblCircAreaCalc.Name = "lblCircAreaCalc"
        Me.lblCircAreaCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblCircAreaCalc.TabIndex = 21
        Me.lblCircAreaCalc.Text = "0"
        '
        'lblCircArea
        '
        Me.lblCircArea.AutoSize = True
        Me.lblCircArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircArea.Location = New System.Drawing.Point(8, 175)
        Me.lblCircArea.Name = "lblCircArea"
        Me.lblCircArea.Size = New System.Drawing.Size(41, 16)
        Me.lblCircArea.TabIndex = 18
        Me.lblCircArea.Text = "Area"
        '
        'lblCircYCalc
        '
        Me.lblCircYCalc.AutoSize = True
        Me.lblCircYCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCircYCalc.Location = New System.Drawing.Point(8, 137)
        Me.lblCircYCalc.Name = "lblCircYCalc"
        Me.lblCircYCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblCircYCalc.TabIndex = 20
        Me.lblCircYCalc.Text = "0"
        '
        'lblCircXCalc
        '
        Me.lblCircXCalc.AutoSize = True
        Me.lblCircXCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCircXCalc.Location = New System.Drawing.Point(8, 61)
        Me.lblCircXCalc.Name = "lblCircXCalc"
        Me.lblCircXCalc.Size = New System.Drawing.Size(16, 16)
        Me.lblCircXCalc.TabIndex = 19
        Me.lblCircXCalc.Text = "0"
        '
        'lblCircY
        '
        Me.lblCircY.AutoSize = True
        Me.lblCircY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircY.Location = New System.Drawing.Point(8, 98)
        Me.lblCircY.Name = "lblCircY"
        Me.lblCircY.Size = New System.Drawing.Size(89, 16)
        Me.lblCircY.TabIndex = 17
        Me.lblCircY.Text = "Centroid - Y"
        '
        'lblCircX
        '
        Me.lblCircX.AutoSize = True
        Me.lblCircX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircX.Location = New System.Drawing.Point(8, 31)
        Me.lblCircX.Name = "lblCircX"
        Me.lblCircX.Size = New System.Drawing.Size(88, 16)
        Me.lblCircX.TabIndex = 16
        Me.lblCircX.Text = "Centroid - X"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(326, 54)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(165, 20)
        Me.txtBase.TabIndex = 2
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(326, 104)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(165, 20)
        Me.txtHeight.TabIndex = 3
        '
        'txtDiameter
        '
        Me.txtDiameter.Location = New System.Drawing.Point(326, 154)
        Me.txtDiameter.Name = "txtDiameter"
        Me.txtDiameter.Size = New System.Drawing.Size(165, 20)
        Me.txtDiameter.TabIndex = 4
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(325, 27)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(172, 24)
        Me.lblBase.TabIndex = 5
        Me.lblBase.Text = "Enter Base Value"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(325, 77)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(187, 24)
        Me.lblHeight.TabIndex = 6
        Me.lblHeight.Text = "Enter Height Value"
        '
        'lblDiameter
        '
        Me.lblDiameter.AutoSize = True
        Me.lblDiameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiameter.Location = New System.Drawing.Point(325, 127)
        Me.lblDiameter.Name = "lblDiameter"
        Me.lblDiameter.Size = New System.Drawing.Size(209, 24)
        Me.lblDiameter.TabIndex = 7
        Me.lblDiameter.Text = "Enter Diameter Value"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.Project3.My.Resources.Resources.circle_triangle_square
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(331, 249)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'cboSelect
        '
        Me.cboSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelect.FormattingEnabled = True
        Me.cboSelect.Items.AddRange(New Object() {"Centroid X", "Centroid Y", "Area"})
        Me.cboSelect.Location = New System.Drawing.Point(329, 203)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(121, 24)
        Me.cboSelect.TabIndex = 9
        Me.cboSelect.Text = "-Selection-"
        '
        'Shapes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(544, 708)
        Me.Controls.Add(Me.cboSelect)
        Me.Controls.Add(Me.lblDiameter)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.txtDiameter)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.grpBoxCircle)
        Me.Controls.Add(Me.grpBoxTriangle)
        Me.Controls.Add(Me.grpBoxRect)
        Me.Controls.Add(Me.PictureBox1)
        Me.HelpButton = True
        Me.Name = "Shapes"
        Me.Text = "CPT 341 Fall 2021 - Classes and Objects"
        Me.grpBoxRect.ResumeLayout(False)
        Me.grpBoxRect.PerformLayout()
        Me.grpBoxTriangle.ResumeLayout(False)
        Me.grpBoxTriangle.PerformLayout()
        Me.grpBoxCircle.ResumeLayout(False)
        Me.grpBoxCircle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBoxRect As GroupBox
    Friend WithEvents grpBoxTriangle As GroupBox
    Friend WithEvents grpBoxCircle As GroupBox
    Friend WithEvents txtBase As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtDiameter As TextBox
    Friend WithEvents lblBase As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblDiameter As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboSelect As ComboBox
    Friend WithEvents lblRectAreaCalc As Label
    Friend WithEvents lblRectYCalc As Label
    Friend WithEvents lblRectXCalc As Label
    Friend WithEvents lblRectArea As Label
    Friend WithEvents lblRectY As Label
    Friend WithEvents lblRectX As Label
    Friend WithEvents lblTriAreaCalc As Label
    Friend WithEvents lblTriArea As Label
    Friend WithEvents lblTriYCalc As Label
    Friend WithEvents lblTriXCalc As Label
    Friend WithEvents lblTriY As Label
    Friend WithEvents lblTriX As Label
    Friend WithEvents lblCircAreaCalc As Label
    Friend WithEvents lblCircArea As Label
    Friend WithEvents lblCircYCalc As Label
    Friend WithEvents lblCircXCalc As Label
    Friend WithEvents lblCircY As Label
    Friend WithEvents lblCircX As Label
End Class
