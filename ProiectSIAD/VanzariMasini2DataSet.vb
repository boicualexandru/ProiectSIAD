Partial Class VanzariMasini2DataSet
    Partial Public Class DotariDataTable
        Private Sub DotariDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class DotariMasiniDataTable
        Private Sub DotariMasiniDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class MarciDataTable
        Private Sub MarciDataTable_MarciRowChanging(sender As Object, e As MarciRowChangeEvent) Handles Me.MarciRowChanging

        End Sub

    End Class

    Partial Public Class NormeDePoluareDataTable
        Private Sub NormeDePoluareDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace VanzariMasini2DataSetTableAdapters

    Partial Public Class clientiTableAdapter
    End Class
End Namespace
