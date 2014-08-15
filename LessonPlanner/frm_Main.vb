Public Class frm_main

#Region "Variable Def"

#End Region

#Region "Form Load"

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

#End Region

#Region "Menu Click Handlers"

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim edit_frm As New frm_edit_week
        edit_frm.MdiParent = Me
        edit_frm.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

    End Sub

    Private Sub ExportToPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToPDFToolStripMenuItem.Click

    End Sub

#End Region

End Class