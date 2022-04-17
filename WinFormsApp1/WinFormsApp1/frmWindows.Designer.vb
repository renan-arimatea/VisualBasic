<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWindows
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnNovoForm = New System.Windows.Forms.Button()
        Me.btnPrivate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(276, 109)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 32)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(125, 109)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(114, 32)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnNovoForm
        '
        Me.btnNovoForm.Location = New System.Drawing.Point(125, 188)
        Me.btnNovoForm.Name = "btnNovoForm"
        Me.btnNovoForm.Size = New System.Drawing.Size(114, 31)
        Me.btnNovoForm.TabIndex = 2
        Me.btnNovoForm.Text = "Novo Form"
        Me.btnNovoForm.UseVisualStyleBackColor = True
        '
        'btnPrivate
        '
        Me.btnPrivate.Location = New System.Drawing.Point(276, 188)
        Me.btnPrivate.Name = "btnPrivate"
        Me.btnPrivate.Size = New System.Drawing.Size(108, 31)
        Me.btnPrivate.TabIndex = 3
        Me.btnPrivate.TabStop = False
        Me.btnPrivate.Text = "Private"
        Me.btnPrivate.UseVisualStyleBackColor = True
        '
        'frmWindows
        '
        Me.AcceptButton = Me.btnConfirmar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(528, 288)
        Me.Controls.Add(Me.btnPrivate)
        Me.Controls.Add(Me.btnNovoForm)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "frmWindows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnNovoForm As Button
    Friend WithEvents btnPrivate As Button
End Class
