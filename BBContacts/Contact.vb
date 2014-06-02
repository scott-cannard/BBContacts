Public Class Contact
    Public User As String
    Public Email As String
    Public Name As String
    Public Addr1 As String
    Public Addr2 As String
    Public Addr3 As String
    Public Addr4 As String
    Public lstOrders As New List(Of Order)

    Public Sub New()
        User = ""
        Email = ""
        Name = ""
        Addr1 = ""
        Addr2 = ""
        Addr3 = ""
        Addr4 = ""
    End Sub

    Public Sub New(ByRef usr As String)
        User = usr
        Email = ""
        Name = ""
        Addr1 = ""
        Addr2 = ""
        Addr3 = ""
        Addr4 = ""
    End Sub

    Public Sub New(ByRef usr As String, ByRef eml As String, ByRef nm As String, ByRef ad1 As String, ByRef ad2 As String, _
                   ByRef ad3 As String, ByRef ad4 As String)
        User = usr
        Email = eml
        Name = nm
        Addr1 = ad1
        Addr2 = ad2
        Addr3 = ad3
        Addr4 = ad4
    End Sub
End Class
