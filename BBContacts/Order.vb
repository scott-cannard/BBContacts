Public Class Order
    Public Enum Status
        Untouched
        Messaged
        Invoiced
        Paid
        Packed
    End Enum

    Private mDate As Date
    Private mStatus As Status
    Private mComments As String

    Public Sub New()
        mDate = Date.Now
        mStatus = Status.Untouched
        mComments = ""
    End Sub

    Public Sub New(dt As Date, st As Status, com As String)
        mDate = dt
        mStatus = st
        mComments = com
    End Sub

    Property DateCreated As Date
        Get
            Return mDate
        End Get
        Set(value As Date)
            mDate = value
        End Set
    End Property

    Property CurrentStatus As Status
        Get
            Return mStatus
        End Get
        Set(value As Status)
            mStatus = value
        End Set
    End Property

    Property Comments As String
        Get
            Return mComments
        End Get
        Set(value As String)
            mComments = value
        End Set
    End Property
End Class
