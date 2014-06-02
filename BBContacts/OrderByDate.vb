Public Class OrderByDate
    Inherits Comparer(Of Order)
    Public Overrides Function Compare(ByVal one As Order, ByVal two As Order) As Integer
        Return two.DateCreated.CompareTo(one.DateCreated)
    End Function
End Class
