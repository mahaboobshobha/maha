<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class creditdetail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttid = New System.Windows.Forms.TextBox()
        Me.txtcnm = New System.Windows.Forms.TextBox()
        Me.txtpnm = New System.Windows.Forms.TextBox()
        Me.txtbnm = New System.Windows.Forms.TextBox()
        Me.txtunm = New System.Windows.Forms.TextBox()
        Me.btnbook = New System.Windows.Forms.Button()
        Me.btncncl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Train ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pin NUmber :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Credit Card Number :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Bank Name"
        '
        'txttid
        '
        Me.txttid.Location = New System.Drawing.Point(113, 52)
        Me.txttid.Name = "txttid"
        Me.txttid.Size = New System.Drawing.Size(100, 20)
        Me.txttid.TabIndex = 6
        '
        'txtcnm
        '
        Me.txtcnm.Location = New System.Drawing.Point(113, 132)
        Me.txtcnm.Name = "txtcnm"
        Me.txtcnm.Size = New System.Drawing.Size(100, 20)
        Me.txtcnm.TabIndex = 7
        '
        'txtpnm
        '
        Me.txtpnm.Location = New System.Drawing.Point(113, 158)
        Me.txtpnm.Name = "txtpnm"
        Me.txtpnm.Size = New System.Drawing.Size(100, 20)
        Me.txtpnm.TabIndex = 8
        '
        'txtbnm
        '
        Me.txtbnm.Location = New System.Drawing.Point(113, 103)
        Me.txtbnm.Name = "txtbnm"
        Me.txtbnm.Size = New System.Drawing.Size(100, 20)
        Me.txtbnm.TabIndex = 10
        '
        'txtunm
        '
        Me.txtunm.Location = New System.Drawing.Point(113, 77)
        Me.txtunm.Name = "txtunm"
        Me.txtunm.Size = New System.Drawing.Size(100, 20)
        Me.txtunm.TabIndex = 11
        '
        'btnbook
        '
        Me.btnbook.Location = New System.Drawing.Point(68, 211)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(75, 23)
        Me.btnbook.TabIndex = 12
        Me.btnbook.Text = "Submit"
        Me.btnbook.UseVisualStyleBackColor = True
        '
        'btncncl
        '
        Me.btncncl.Location = New System.Drawing.Point(169, 211)
        Me.btncncl.Name = "btncncl"
        Me.btncncl.Size = New System.Drawing.Size(75, 23)
        Me.btncncl.TabIndex = 13
        Me.btncncl.Text = "cancel"
        Me.btncncl.UseVisualStyleBackColor = True
        '
        'creditdetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 261)
        Me.Controls.Add(Me.btncncl)
        Me.Controls.Add(Me.btnbook)
        Me.Controls.Add(Me.txtunm)
        Me.Controls.Add(Me.txtbnm)
        Me.Controls.Add(Me.txtpnm)
        Me.Controls.Add(Me.txtcnm)
        Me.Controls.Add(Me.txttid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "creditdetail"
        Me.Text = "creditdetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttid As System.Windows.Forms.TextBox
    Friend WithEvents txtcnm As System.Windows.Forms.TextBox
    Friend WithEvents txtpnm As System.Windows.Forms.TextBox
    Friend WithEvents txtbnm As System.Windows.Forms.TextBox
    Friend WithEvents txtunm As System.Windows.Forms.TextBox
    Friend WithEvents btnbook As System.Windows.Forms.Button
    Friend WithEvents btncncl As System.Windows.Forms.Button
End Class
