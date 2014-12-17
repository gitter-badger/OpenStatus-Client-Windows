<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenStatusClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenStatusClient))
        Me.btnChangeUsername = New System.Windows.Forms.Button()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.grpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChangeUsername
        '
        Me.btnChangeUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangeUsername.Location = New System.Drawing.Point(6, 32)
        Me.btnChangeUsername.Name = "btnChangeUsername"
        Me.btnChangeUsername.Size = New System.Drawing.Size(188, 23)
        Me.btnChangeUsername.TabIndex = 0
        Me.btnChangeUsername.Text = "Change Username"
        Me.btnChangeUsername.UseVisualStyleBackColor = True
        '
        'grpStatus
        '
        Me.grpStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStatus.Controls.Add(Me.lblServer)
        Me.grpStatus.Controls.Add(Me.lblUsername)
        Me.grpStatus.Controls.Add(Me.btnChangeUsername)
        Me.grpStatus.Location = New System.Drawing.Point(360, 12)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(200, 352)
        Me.grpStatus.TabIndex = 1
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Current Status"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(6, 16)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(111, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username: NOT_SET"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(6, 58)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(140, 13)
        Me.lblServer.TabIndex = 2
        Me.lblServer.Text = "Server: NOT_CONNECTED"
        '
        'OpenStatusClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 376)
        Me.Controls.Add(Me.grpStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OpenStatusClient"
        Me.Text = "OpenStatus Windows Client"
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnChangeUsername As System.Windows.Forms.Button
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label

End Class
