<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatetrain
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
        Me.txttrnavl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttrndstn = New System.Windows.Forms.TextBox()
        Me.txttrnsrc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttrnname = New System.Windows.Forms.TextBox()
        Me.txttrnid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txttrnavl
        '
        Me.txttrnavl.Location = New System.Drawing.Point(193, 227)
        Me.txttrnavl.Name = "txttrnavl"
        Me.txttrnavl.Size = New System.Drawing.Size(100, 20)
        Me.txttrnavl.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "seat availability :"
        '
        'txttrndstn
        '
        Me.txttrndstn.Location = New System.Drawing.Point(193, 193)
        Me.txttrndstn.Name = "txttrndstn"
        Me.txttrndstn.Size = New System.Drawing.Size(100, 20)
        Me.txttrndstn.TabIndex = 43
        '
        'txttrnsrc
        '
        Me.txttrnsrc.Location = New System.Drawing.Point(193, 155)
        Me.txttrnsrc.Name = "txttrnsrc"
        Me.txttrnsrc.Size = New System.Drawing.Size(100, 20)
        Me.txttrnsrc.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "destination :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "source :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "UPDATE TRAIN INFORMATION"
        '
        'txttrnname
        '
        Me.txttrnname.Location = New System.Drawing.Point(193, 113)
        Me.txttrnname.Name = "txttrnname"
        Me.txttrnname.Size = New System.Drawing.Size(100, 20)
        Me.txttrnname.TabIndex = 38
        '
        'txttrnid
        '
        Me.txttrnid.Location = New System.Drawing.Point(193, 73)
        Me.txttrnid.Name = "txttrnid"
        Me.txttrnid.Size = New System.Drawing.Size(100, 20)
        Me.txttrnid.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Train Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Train ID :"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(193, 275)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(69, 275)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(94, 23)
        Me.btnLogin.TabIndex = 33
        Me.btnLogin.Text = "Update Train"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'updatetrain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 322)
        Me.Controls.Add(Me.txttrnavl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttrndstn)
        Me.Controls.Add(Me.txttrnsrc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttrnname)
        Me.Controls.Add(Me.txttrnid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "updatetrain"
        Me.Text = "updatetrain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttrnavl As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttrndstn As System.Windows.Forms.TextBox
    Friend WithEvents txttrnsrc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttrnname As System.Windows.Forms.TextBox
    Friend WithEvents txttrnid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
End Class
