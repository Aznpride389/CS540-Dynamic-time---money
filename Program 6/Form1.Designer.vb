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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.usaFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.indiaFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.disneylandFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.albaniaFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.dateTimeCaptionLabel = New System.Windows.Forms.Label()
        Me.costCaptionLabel = New System.Windows.Forms.Label()
        Me.costDisplayLabel = New System.Windows.Forms.Label()
        Me.amountSoldCaptionLabel = New System.Windows.Forms.Label()
        Me.dateTimeLabel = New System.Windows.Forms.Label()
        Me.dateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.amountSoldLabel = New System.Windows.Forms.Label()
        Me.valuesTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.usaFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.indiaFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disneylandFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albaniaFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usaFlagPictureBox
        '
        Me.usaFlagPictureBox.Image = CType(resources.GetObject("usaFlagPictureBox.Image"), System.Drawing.Image)
        Me.usaFlagPictureBox.Location = New System.Drawing.Point(52, 27)
        Me.usaFlagPictureBox.Name = "usaFlagPictureBox"
        Me.usaFlagPictureBox.Size = New System.Drawing.Size(204, 144)
        Me.usaFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usaFlagPictureBox.TabIndex = 0
        Me.usaFlagPictureBox.TabStop = False
        '
        'indiaFlagPictureBox
        '
        Me.indiaFlagPictureBox.Image = CType(resources.GetObject("indiaFlagPictureBox.Image"), System.Drawing.Image)
        Me.indiaFlagPictureBox.Location = New System.Drawing.Point(52, 302)
        Me.indiaFlagPictureBox.Name = "indiaFlagPictureBox"
        Me.indiaFlagPictureBox.Size = New System.Drawing.Size(204, 144)
        Me.indiaFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.indiaFlagPictureBox.TabIndex = 1
        Me.indiaFlagPictureBox.TabStop = False
        '
        'disneylandFlagPictureBox
        '
        Me.disneylandFlagPictureBox.Image = CType(resources.GetObject("disneylandFlagPictureBox.Image"), System.Drawing.Image)
        Me.disneylandFlagPictureBox.Location = New System.Drawing.Point(355, 27)
        Me.disneylandFlagPictureBox.Name = "disneylandFlagPictureBox"
        Me.disneylandFlagPictureBox.Size = New System.Drawing.Size(204, 144)
        Me.disneylandFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.disneylandFlagPictureBox.TabIndex = 2
        Me.disneylandFlagPictureBox.TabStop = False
        '
        'albaniaFlagPictureBox
        '
        Me.albaniaFlagPictureBox.Image = CType(resources.GetObject("albaniaFlagPictureBox.Image"), System.Drawing.Image)
        Me.albaniaFlagPictureBox.Location = New System.Drawing.Point(355, 302)
        Me.albaniaFlagPictureBox.Name = "albaniaFlagPictureBox"
        Me.albaniaFlagPictureBox.Size = New System.Drawing.Size(204, 144)
        Me.albaniaFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.albaniaFlagPictureBox.TabIndex = 3
        Me.albaniaFlagPictureBox.TabStop = False
        '
        'dateTimeCaptionLabel
        '
        Me.dateTimeCaptionLabel.AutoSize = True
        Me.dateTimeCaptionLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeCaptionLabel.Location = New System.Drawing.Point(228, 253)
        Me.dateTimeCaptionLabel.Name = "dateTimeCaptionLabel"
        Me.dateTimeCaptionLabel.Size = New System.Drawing.Size(160, 34)
        Me.dateTimeCaptionLabel.TabIndex = 5
        Me.dateTimeCaptionLabel.Text = "Date/Time"
        '
        'costCaptionLabel
        '
        Me.costCaptionLabel.AutoSize = True
        Me.costCaptionLabel.BackColor = System.Drawing.SystemColors.Control
        Me.costCaptionLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costCaptionLabel.Location = New System.Drawing.Point(982, 134)
        Me.costCaptionLabel.Name = "costCaptionLabel"
        Me.costCaptionLabel.Size = New System.Drawing.Size(82, 37)
        Me.costCaptionLabel.TabIndex = 6
        Me.costCaptionLabel.Text = "Cost"
        '
        'costDisplayLabel
        '
        Me.costDisplayLabel.BackColor = System.Drawing.Color.SkyBlue
        Me.costDisplayLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costDisplayLabel.Location = New System.Drawing.Point(777, 56)
        Me.costDisplayLabel.Name = "costDisplayLabel"
        Me.costDisplayLabel.Size = New System.Drawing.Size(505, 53)
        Me.costDisplayLabel.TabIndex = 7
        Me.costDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'amountSoldCaptionLabel
        '
        Me.amountSoldCaptionLabel.AutoSize = True
        Me.amountSoldCaptionLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountSoldCaptionLabel.Location = New System.Drawing.Point(907, 343)
        Me.amountSoldCaptionLabel.Name = "amountSoldCaptionLabel"
        Me.amountSoldCaptionLabel.Size = New System.Drawing.Size(240, 37)
        Me.amountSoldCaptionLabel.TabIndex = 8
        Me.amountSoldCaptionLabel.Text = "Fish Tacos Sold"
        '
        'dateTimeLabel
        '
        Me.dateTimeLabel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.dateTimeLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeLabel.Location = New System.Drawing.Point(52, 193)
        Me.dateTimeLabel.Name = "dateTimeLabel"
        Me.dateTimeLabel.Size = New System.Drawing.Size(507, 49)
        Me.dateTimeLabel.TabIndex = 12
        Me.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateTimer
        '
        Me.dateTimer.Enabled = True
        Me.dateTimer.Interval = 1000
        '
        'amountSoldLabel
        '
        Me.amountSoldLabel.BackColor = System.Drawing.Color.SkyBlue
        Me.amountSoldLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountSoldLabel.Location = New System.Drawing.Point(770, 264)
        Me.amountSoldLabel.Name = "amountSoldLabel"
        Me.amountSoldLabel.Size = New System.Drawing.Size(512, 45)
        Me.amountSoldLabel.TabIndex = 9
        Me.amountSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valuesTimer
        '
        Me.valuesTimer.Enabled = True
        Me.valuesTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 458)
        Me.Controls.Add(Me.amountSoldLabel)
        Me.Controls.Add(Me.amountSoldCaptionLabel)
        Me.Controls.Add(Me.costDisplayLabel)
        Me.Controls.Add(Me.costCaptionLabel)
        Me.Controls.Add(Me.dateTimeCaptionLabel)
        Me.Controls.Add(Me.dateTimeLabel)
        Me.Controls.Add(Me.albaniaFlagPictureBox)
        Me.Controls.Add(Me.disneylandFlagPictureBox)
        Me.Controls.Add(Me.indiaFlagPictureBox)
        Me.Controls.Add(Me.usaFlagPictureBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.usaFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.indiaFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disneylandFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albaniaFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usaFlagPictureBox As PictureBox
    Friend WithEvents indiaFlagPictureBox As PictureBox
    Friend WithEvents disneylandFlagPictureBox As PictureBox
    Friend WithEvents albaniaFlagPictureBox As PictureBox
    Friend WithEvents dateTimeCaptionLabel As Label
    Friend WithEvents costCaptionLabel As Label
    Friend WithEvents costDisplayLabel As Label
    Friend WithEvents amountSoldCaptionLabel As Label
    Friend WithEvents dateTimeLabel As Label
    Friend WithEvents dateTimer As Timer
    Friend WithEvents amountSoldLabel As Label
    Friend WithEvents valuesTimer As Timer
End Class
