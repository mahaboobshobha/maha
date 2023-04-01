<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminhome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminhome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndeletetrain = New System.Windows.Forms.Button()
        Me.btnaddtrain = New System.Windows.Forms.Button()
        Me.btnviewcustemerregistration = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(309, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome ADMIN"
        '
        'btndeletetrain
        '
        Me.btndeletetrain.Location = New System.Drawing.Point(204, 99)
        Me.btndeletetrain.Name = "btndeletetrain"
        Me.btndeletetrain.Size = New System.Drawing.Size(123, 23)
        Me.btndeletetrain.TabIndex = 2
        Me.btndeletetrain.Text = "DELETE TRAIN INFO"
        Me.btndeletetrain.UseVisualStyleBackColor = True
        '
        'btnaddtrain
        '
        Me.btnaddtrain.Location = New System.Drawing.Point(54, 99)
        Me.btnaddtrain.Name = "btnaddtrain"
        Me.btnaddtrain.Size = New System.Drawing.Size(123, 23)
        Me.btnaddtrain.TabIndex = 4
        Me.btnaddtrain.Text = "ADD TRAIN INFO"
        Me.btnaddtrain.UseVisualStyleBackColor = True
        '
        'btnviewcustemerregistration
        '
        Me.btnviewcustemerregistration.Location = New System.Drawing.Point(500, 99)
        Me.btnviewcustemerregistration.Name = "btnviewcustemerregistration"
        Me.btnviewcustemerregistration.Size = New System.Drawing.Size(204, 23)
        Me.btnviewcustemerregistration.TabIndex = 5
        Me.btnviewcustemerregistration.Text = "VIEW CUSTOMER REGISTRATION"
        Me.btnviewcustemerregistration.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(758, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "LOGOUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(354, 99)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(123, 23)
        Me.btnupdate.TabIndex = 7
        Me.btnupdate.Text = "UPDATE TRAIN INFO"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(710, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "About us"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'adminhome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(851, 399)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnviewcustemerregistration)
        Me.Controls.Add(Me.btnaddtrain)
        Me.Controls.Add(Me.btndeletetrain)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminhome"
        Me.Text = "adminhome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btndeletetrain As System.Windows.Forms.Button
    Friend WithEvents btnaddtrain As System.Windows.Forms.Button
    Friend WithEvents btnviewcustemerregistration As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
