Public Class Form1
    Private Const dataFile As String = "CtInfo.dat"
    Private Const swapFile As String = "CtInfo.swp"

    Private lstContacts As New Dictionary(Of String, Contact)
    Private workingContact As New Contact
    Private bModified As Boolean = False
    Private bUnsaved As Boolean = False
    Private bSkipLoad As Boolean = False


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim fVal As IO.FileStream
        Dim rd As IO.StreamReader
        Dim newContact As Contact
        Dim newOrder As Order

        'Check data file for proper closing tag.
        '(1) Data file is corrupt,
        '   -- check for swap file with proper closing tag
        '      (a) use swap file as data file
        '
        '(2) Data file closed properly,
        '   -- delete swap file if it exists

        Try
            fVal = New IO.FileStream(dataFile, IO.FileMode.Open)    'open .dat file
            fVal.Seek(-1, IO.SeekOrigin.End)                        'seek to last char
            If fVal.ReadByte = 128 Then                             'if last char is closing tag
                fVal.Close()                                        '(T)...
                IO.File.Copy(dataFile, swapFile, True)              '   ...copy data file to swap file
            Else
                Throw New IO.IOException                            '(F)...file is bad (drop to Catch clause)
            End If
        Catch exDat As IO.IOException
            Try
                fVal = New IO.FileStream(swapFile, IO.FileMode.Open)        'open .swp file
                fVal.Seek(-1, IO.SeekOrigin.End)                            'seek to last char
                If fVal.ReadByte = 128 Then                                 'if last char is closing tag
                    fVal.Close()                                            '(T)...
                    IO.File.Copy(swapFile, dataFile, True)                  '   ...copy swap file to data file
                Else
                    Throw New Exception                                     '(F)...neither file appears to be intact
                End If
            Catch exSwp As Exception
                MessageBox.Show("Error: Contact list has been corrupted." + vbCrLf + "Tell Scott.  He may be able to recover it.")
                Me.Close()
            End Try
        End Try

        rd = New IO.StreamReader(dataFile)
        Do Until rd.Peek() = 65533
            newContact = New Contact
            newContact.User = rd.ReadLine()
            newContact.Email = rd.ReadLine()
            newContact.Name = rd.ReadLine()
            newContact.Addr1 = rd.ReadLine()
            newContact.Addr2 = rd.ReadLine()
            newContact.Addr3 = rd.ReadLine()
            newContact.Addr4 = rd.ReadLine()

            newContact.lstOrders.Clear()
            Do Until Chr(rd.Peek()) = ";"
                newOrder = New Order
                newOrder.DateCreated = rd.ReadLine()
                newOrder.CurrentStatus = rd.ReadLine()
                newOrder.Comments = rd.ReadLine()

                newContact.lstOrders.Add(newOrder)
            Loop
            rd.ReadLine()   'discard delimiting line
            lstContacts.Add(newContact.User, newContact)
        Loop
        rd.Close()
        FilterComboBox()
    End Sub


    '*** Menu ***
    'Menu -- Enable menu items
    Private Sub FileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FileToolStripMenuItem.MouseDown
        EnableMenuItems()
    End Sub
    Private Sub ContactToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContactToolStripMenuItem.MouseDown
        EnableMenuItems()
    End Sub
    Private Sub FiltersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FiltersToolStripMenuItem.MouseDown
        EnableMenuItems()
    End Sub
    Private Sub OrdersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OrdersToolStripMenuItem.MouseDown
        EnableMenuItems()
    End Sub
    Private Sub EnableMenuItems()
        MenuItemUndo.Enabled = bModified
        MenuItemAddOrd.Enabled = (workingContact.User <> "")
    End Sub

    'Menu -- Buttons
    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Save()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If bModified Or bUnsaved Then
            Select Case MessageBox.Show("Changes have been made!" + vbCrLf + "Would you like to save before exiting?", "Exit without saving...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    Save()
                    Me.Close()
                Case Windows.Forms.DialogResult.No
                    bUnsaved = False
                    Me.Close()
            End Select
        Else
            Me.Close()
        End If
    End Sub

    Private Sub MenuItemUndo_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemUndo.Click
        LoadUserInfo(workingContact.User)
    End Sub

    Private Sub NewContactToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewContactToolStripMenuItem.Click
        Dim newContact As Contact
        Dim user As String = InputBox("What is the new contact's user name?", "")

        If user <> "" Then
            If lstContacts.ContainsKey(user) Then
                MessageBox.Show("That user is already in the list.")
                cboUsername.Text = user
            Else
                newContact = New Contact(user)
                lstContacts.Add(newContact.User, newContact)
                cboUsername.Items.Add(newContact.User)
                cboUsername.Text = newContact.User
            End If
            FilterComboBox()
            bUnsaved = True
        End If
    End Sub

    Private Sub DeleteContactToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteContactToolStripMenuItem.Click
        Dim id As String
        Try
            id = workingContact.User
        Catch ex As Exception
            id = ""
        End Try
        If id <> "" Then
            If MessageBox.Show(id & " will be permanently erased." & vbCrLf & "Are you sure?", "Verify Delete", _
                               MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cboUsername.SelectedIndex -= 1
                If cboUsername.SelectedIndex = -1 Then
                    workingContact = New Contact
                End If
                lstContacts.Remove(id)
                cboUsername.Items.Remove(id)
                bUnsaved = True
            End If
        End If
    End Sub

    Private Sub AddOrderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemAddOrd.Click
        If workingContact.User <> "" Then
            Dim newForm As New OrderForm
            newForm.Location = New Point(8, 8)
            For Each pnl As System.Windows.Forms.Panel In pnlOrders.Controls
                pnl.Location = New Point(pnl.Location.X, pnl.Location.Y + 101)
            Next
            pnlOrders.Controls.Add(newForm.Panel)
            bModified = True
        End If
    End Sub

    'Menu -- Filters
    Private Sub MessagedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemMsgd.Click
        MenuItemMsgd.Checked = Not MenuItemMsgd.Checked
        FilterComboBox()
    End Sub
    Private Sub InvoicedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemInvd.Click
        MenuItemInvd.Checked = Not MenuItemInvd.Checked
        FilterComboBox()
    End Sub
    Private Sub PaidToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemPaid.Click
        MenuItemPaid.Checked = Not MenuItemPaid.Checked
        FilterComboBox()
    End Sub
    Private Sub PackedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemPckd.Click
        MenuItemPckd.Checked = Not MenuItemPckd.Checked
        FilterComboBox()
    End Sub
    Private Sub UncheckedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemUnchkd.Click
        MenuItemUnchkd.Checked = Not MenuItemUnchkd.Checked
        FilterComboBox()
    End Sub
    Private Sub NoOrdersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemNoOrd.Click
        MenuItemNoOrd.Checked = Not MenuItemNoOrd.Checked
        FilterComboBox()
    End Sub


    'View management
    Private Sub cboUsername_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboUsername.SelectedIndexChanged
        'There are occassions when we don't want to reload user info when this event is triggered
        If Not bSkipLoad Then
            If bModified Then
                bUnsaved = True
            End If
            UpdateMemento()
            'User info will be reloaded
            If Not LoadUserInfo(cboUsername.Text) Then
                '...in case user name is null
                tbEmail.Text = ""
                tbName.Text = ""
                tbAddr1.Text = ""
                tbAddr2.Text = ""
                tbAddr3.Text = ""
                tbAddr4.Text = ""
                pnlOrders.Controls.Clear()
            End If
            bModified = False
        End If
    End Sub

    Private Function LoadUserInfo(ByRef id As String) As Boolean
        Dim newForm As OrderForm
        If lstContacts.TryGetValue(id, workingContact) Then
            tbEmail.Text = workingContact.Email
            tbName.Text = workingContact.Name
            tbAddr1.Text = workingContact.Addr1
            tbAddr2.Text = workingContact.Addr2
            tbAddr3.Text = workingContact.Addr3
            tbAddr4.Text = workingContact.Addr4
            'Create Order Forms
            pnlOrders.Controls.Clear()
            For Each ord As Order In workingContact.lstOrders
                newForm = New OrderForm
                newForm.Location = New Point(8, 8 + (8 + 93) * workingContact.lstOrders.IndexOf(ord))
                newForm.DateCreated = ord.DateCreated
                newForm.CurrentStatus = ord.CurrentStatus
                newForm.Comments = ord.Comments
                pnlOrders.Controls.Add(newForm.Panel)
            Next
            bModified = False
            Return True
        End If
        Return False
    End Function


    'Input handling
    Private Sub cboUsername_KeyPress(sender As System.Object, e As KeyEventArgs) Handles cboUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Index comboBox based on selected text
            cboUsername.SelectedIndex = cboUsername.Items.IndexOf(cboUsername.Text)
        ElseIf e.KeyCode = Keys.Escape Then
            'Reset comboBox from memento
            bSkipLoad = True
            cboUsername.Text = workingContact.User
            bSkipLoad = False
        End If
    End Sub

    Private Sub cboUsername_LostFocus(sender As System.Object, e As System.EventArgs) Handles cboUsername.LostFocus
        bSkipLoad = True
        Try
            cboUsername.Text = workingContact.User
        Catch ex As Exception
            'in case no user has yet been selected
            cboUsername.Text = ""
        End Try
        bSkipLoad = False
    End Sub

    Private Sub tbEmail_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbEmail.TextChanged
        bModified = True
    End Sub
    Private Sub tbName_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbName.TextChanged
        bModified = True
    End Sub
    Private Sub tbAddr1_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAddr1.TextChanged
        bModified = True
    End Sub
    Private Sub tbAddr2_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAddr2.TextChanged
        bModified = True
    End Sub
    Private Sub tbAddr3_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAddr3.TextChanged
        bModified = True
    End Sub
    Private Sub tbAddr4_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbAddr4.TextChanged
        bModified = True
    End Sub


    'Data manipulation
    Private Sub FilterComboBox()
        cboUsername.Items.Clear()
        For Each ct As Contact In lstContacts.Values
            If (ct.lstOrders.Count = 0 And MenuItemNoOrd.Checked) Then
                cboUsername.Items.Add(ct.User)
            Else
                For Each ord As Order In ct.lstOrders
                    If (MenuItemMsgd.Checked And ord.CurrentStatus = Order.Status.Messaged) Or _
                       (MenuItemInvd.Checked And ord.CurrentStatus = Order.Status.Invoiced) Or _
                       (MenuItemPaid.Checked And ord.CurrentStatus = Order.Status.Paid) Or _
                       (MenuItemPckd.Checked And ord.CurrentStatus = Order.Status.Packed) Or _
                       (MenuItemUnchkd.Checked And ord.CurrentStatus = Order.Status.Untouched) Then
                        cboUsername.Items.Add(ct.User)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub UpdateMemento()
        Dim newOrder As Order
        Dim datePicker As System.Windows.Forms.DateTimePicker
        Dim radio1 As System.Windows.Forms.RadioButton
        Dim radio2 As System.Windows.Forms.RadioButton
        Dim radio3 As System.Windows.Forms.RadioButton
        Dim radio4 As System.Windows.Forms.RadioButton
        Dim txtField As System.Windows.Forms.TextBox

        Try
            If workingContact.User <> "" Then
                workingContact.Email = tbEmail.Text
                workingContact.Name = tbName.Text
                workingContact.Addr1 = tbAddr1.Text
                workingContact.Addr2 = tbAddr2.Text
                workingContact.Addr3 = tbAddr3.Text
                workingContact.Addr4 = tbAddr4.Text
                workingContact.lstOrders.Clear()
                For Each pnl As System.Windows.Forms.Panel In pnlOrders.Controls
                    datePicker = DirectCast(pnl.Controls(0), DateTimePicker)
                    radio1 = DirectCast(pnl.Controls(1), RadioButton)
                    radio2 = DirectCast(pnl.Controls(2), RadioButton)
                    radio3 = DirectCast(pnl.Controls(3), RadioButton)
                    radio4 = DirectCast(pnl.Controls(4), RadioButton)
                    txtField = DirectCast(pnl.Controls(5), TextBox)

                    newOrder = New Order
                    newOrder.DateCreated = datePicker.Value
                    If radio1.Checked Then
                        newOrder.CurrentStatus = Order.Status.Messaged
                    ElseIf radio2.Checked Then
                        newOrder.CurrentStatus = Order.Status.Invoiced
                    ElseIf radio3.Checked Then
                        newOrder.CurrentStatus = Order.Status.Paid
                    ElseIf radio4.Checked Then
                        newOrder.CurrentStatus = Order.Status.Packed
                    Else
                        newOrder.CurrentStatus = Order.Status.Untouched
                    End If
                    newOrder.Comments = txtField.Text

                    workingContact.lstOrders.Add(newOrder)
                Next
                lstContacts.Remove(workingContact.User)
                lstContacts.Add(workingContact.User, workingContact)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Save()
        UpdateMemento()

        Dim wr As New IO.StreamWriter(dataFile)
        For Each ct As Contact In lstContacts.Values
            wr.WriteLine(ct.User)
            wr.WriteLine(ct.Email)
            wr.WriteLine(ct.Name)
            wr.WriteLine(ct.Addr1)
            wr.WriteLine(ct.Addr2)
            wr.WriteLine(ct.Addr3)
            wr.WriteLine(ct.Addr4)

            ct.lstOrders.Sort(New OrderByDate)
            For Each ord As Order In ct.lstOrders
                wr.WriteLine(ord.DateCreated)
                wr.WriteLine(ord.CurrentStatus)
                wr.WriteLine(ord.Comments)
            Next
            wr.WriteLine(";")
        Next
        wr.Flush()
        wr.Close()
        Dim fTag As New IO.FileStream(dataFile, IO.FileMode.Append)
        fTag.WriteByte(128)
        fTag.Close()

        IO.File.Copy(dataFile, swapFile, True)

        bModified = False
        bUnsaved = False
    End Sub


    'Closing
    Private Sub Form1_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        If bModified Or bUnsaved Then
            If MessageBox.Show("Some information has been changed!" + vbCrLf + "Would you like to save before exiting?", "Exit without saving...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Save()
            End If
        End If
        IO.File.Delete(swapFile)
    End Sub
End Class
