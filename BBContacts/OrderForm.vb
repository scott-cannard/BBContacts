Public Class OrderForm
    Private mPanel As System.Windows.Forms.Panel
    Private mDatePicker As System.Windows.Forms.DateTimePicker
    Private mRadio(4) As System.Windows.Forms.RadioButton
    Private mTextField As System.Windows.Forms.TextBox

    Public Sub New()
        mPanel = New System.Windows.Forms.Panel
        mPanel.Size = New Size(274, 93)
        mPanel.BackColor = Color.PaleGoldenrod

        mDatePicker = New System.Windows.Forms.DateTimePicker
        mDatePicker.Format = DateTimePickerFormat.Short
        mDatePicker.Location = New Point(4, 5)
        mDatePicker.Size = New Size(81, 20)
        AddHandler mDatePicker.ValueChanged, AddressOf ModFlag
        mPanel.Controls.Add(mDatePicker)

        For rb = 0 To 3
            mRadio(rb) = New System.Windows.Forms.RadioButton
            mRadio(rb).Location = New Point(4, 24 + (16 * rb))
            mRadio(rb).Size = New Size(74, 17)
            mRadio(rb).RightToLeft = RightToLeft.Yes
            mRadio(rb).TextAlign = ContentAlignment.MiddleCenter
            mRadio(rb).Text = {"Messaged", "Invoiced", "Paid", "Packed"}(rb)
            AddHandler mRadio(rb).CheckedChanged, AddressOf ModFlag
            mPanel.Controls.Add(mRadio(rb))
        Next

        mTextField = New System.Windows.Forms.TextBox
        mTextField.Location = New Point(87, 4)
        mTextField.Size = New Size(183, 85)
        mTextField.Multiline = True
        AddHandler mTextField.TextChanged, AddressOf ModFlag
        mPanel.Controls.Add(mTextField)
    End Sub

    ReadOnly Property Panel As System.Windows.Forms.Panel
        Get
            Return mPanel
        End Get
    End Property

    WriteOnly Property Location As Point
        Set(value As Point)
            mPanel.Location = value
        End Set
    End Property

    Property DateCreated As Date
        Get
            Return mDatePicker.Value
        End Get
        Set(value As Date)
            mDatePicker.Value = value
        End Set
    End Property

    Property CurrentStatus As Order.Status
        Get
            If mRadio(0).Checked Then
                Return Order.Status.Messaged
            ElseIf mRadio(1).Checked Then
                Return Order.Status.Invoiced
            ElseIf mRadio(2).Checked Then
                Return Order.Status.Paid
            ElseIf mRadio(3).Checked Then
                Return Order.Status.Packed
            End If
            Return Order.Status.Untouched
        End Get
        Set(value As Order.Status)
            If value <> Order.Status.Untouched Then
                mRadio(value - 1).Checked = True
            End If
        End Set
    End Property

    Property Comments As String
        Get
            Return mTextField.Text
        End Get
        Set(value As String)
            mTextField.Text = value
        End Set
    End Property


    Private Sub ModFlag()
        Form1.MenuItemUndo.Enabled = True
    End Sub
End Class
