Public Class frmWindows
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MessageBox.Show("Botão Cancelar Executado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        MessageBox.Show("Botão Confirmar executado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmWindows_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNovoForm_Click(sender As Object, e As EventArgs) Handles btnNovoForm.Click
        'Dim frm As New frmNovoForm
        'frm.Show()

        Dim frm As New frmNovoForm
        frm.ShowDialog(Me)
    End Sub
End Class
