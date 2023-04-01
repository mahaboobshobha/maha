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
        Me.Login = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.loginadmin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(54, 238)
        Me.Login.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(202, 94)
        Me.Login.TabIndex = 0
        Me.Login.Text = "User Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register.Location = New System.Drawing.Point(516, 238)
        Me.Register.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(202, 94)
        Me.Register.TabIndex = 1
        Me.Register.Text = "New User Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'loginadmin
        '
        Me.loginadmin.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginadmin.Location = New System.Drawing.Point(281, 238)
        Me.loginadmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.loginadmin.Name = "loginadmin"
        Me.loginadmin.Size = New System.Drawing.Size(202, 94)
        Me.loginadmin.TabIndex = 2
        Me.loginadmin.Text = "Admin Login"
        Me.loginadmin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(281, 444)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 94)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(98, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Online Train Booking System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 602)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.loginadmin)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Login)
        Me.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents Register As System.Windows.Forms.Button
    Friend WithEvents loginadmin As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
