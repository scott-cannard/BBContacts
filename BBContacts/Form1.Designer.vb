<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.gbAddress = New System.Windows.Forms.GroupBox()
        Me.lblAddr4 = New System.Windows.Forms.Label()
        Me.lblAddr3 = New System.Windows.Forms.Label()
        Me.tbAddr4 = New System.Windows.Forms.TextBox()
        Me.tbAddr3 = New System.Windows.Forms.TextBox()
        Me.tbAddr2 = New System.Windows.Forms.TextBox()
        Me.lblAddr2 = New System.Windows.Forms.Label()
        Me.lblAddr1 = New System.Windows.Forms.Label()
        Me.tbAddr1 = New System.Windows.Forms.TextBox()
        Me.gbEmail = New System.Windows.Forms.GroupBox()
        Me.pnlOrders = New System.Windows.Forms.Panel()
        Me.lblOrders = New System.Windows.Forms.Label()
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.cboUsername = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemMsgd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemInvd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemPaid = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemPckd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemUnchkd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemNoOrd = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemAddOrd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbAddress.SuspendLayout()
        Me.gbEmail.SuspendLayout()
        Me.gbUser.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(60, 22)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(168, 20)
        Me.tbName.TabIndex = 3
        '
        'tbEmail
        '
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(6, 19)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(222, 20)
        Me.tbEmail.TabIndex = 2
        '
        'gbAddress
        '
        Me.gbAddress.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbAddress.Controls.Add(Me.lblAddr4)
        Me.gbAddress.Controls.Add(Me.lblAddr3)
        Me.gbAddress.Controls.Add(Me.tbAddr4)
        Me.gbAddress.Controls.Add(Me.tbAddr3)
        Me.gbAddress.Controls.Add(Me.tbAddr2)
        Me.gbAddress.Controls.Add(Me.lblAddr2)
        Me.gbAddress.Controls.Add(Me.lblAddr1)
        Me.gbAddress.Controls.Add(Me.tbAddr1)
        Me.gbAddress.Controls.Add(Me.tbName)
        Me.gbAddress.Controls.Add(Me.lblName)
        Me.gbAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAddress.Location = New System.Drawing.Point(7, 121)
        Me.gbAddress.Name = "gbAddress"
        Me.gbAddress.Size = New System.Drawing.Size(234, 132)
        Me.gbAddress.TabIndex = 2
        Me.gbAddress.TabStop = False
        Me.gbAddress.Text = "Address"
        '
        'lblAddr4
        '
        Me.lblAddr4.AutoSize = True
        Me.lblAddr4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr4.Location = New System.Drawing.Point(6, 109)
        Me.lblAddr4.Name = "lblAddr4"
        Me.lblAddr4.Size = New System.Drawing.Size(54, 13)
        Me.lblAddr4.TabIndex = 15
        Me.lblAddr4.Text = "Address 4"
        '
        'lblAddr3
        '
        Me.lblAddr3.AutoSize = True
        Me.lblAddr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr3.Location = New System.Drawing.Point(6, 88)
        Me.lblAddr3.Name = "lblAddr3"
        Me.lblAddr3.Size = New System.Drawing.Size(54, 13)
        Me.lblAddr3.TabIndex = 14
        Me.lblAddr3.Text = "Address 3"
        '
        'tbAddr4
        '
        Me.tbAddr4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddr4.Location = New System.Drawing.Point(60, 106)
        Me.tbAddr4.Name = "tbAddr4"
        Me.tbAddr4.Size = New System.Drawing.Size(168, 20)
        Me.tbAddr4.TabIndex = 7
        '
        'tbAddr3
        '
        Me.tbAddr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddr3.Location = New System.Drawing.Point(60, 85)
        Me.tbAddr3.Name = "tbAddr3"
        Me.tbAddr3.Size = New System.Drawing.Size(168, 20)
        Me.tbAddr3.TabIndex = 6
        '
        'tbAddr2
        '
        Me.tbAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddr2.Location = New System.Drawing.Point(60, 64)
        Me.tbAddr2.Name = "tbAddr2"
        Me.tbAddr2.Size = New System.Drawing.Size(168, 20)
        Me.tbAddr2.TabIndex = 5
        '
        'lblAddr2
        '
        Me.lblAddr2.AutoSize = True
        Me.lblAddr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr2.Location = New System.Drawing.Point(6, 67)
        Me.lblAddr2.Name = "lblAddr2"
        Me.lblAddr2.Size = New System.Drawing.Size(54, 13)
        Me.lblAddr2.TabIndex = 10
        Me.lblAddr2.Text = "Address 2"
        '
        'lblAddr1
        '
        Me.lblAddr1.AutoSize = True
        Me.lblAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr1.Location = New System.Drawing.Point(6, 46)
        Me.lblAddr1.Name = "lblAddr1"
        Me.lblAddr1.Size = New System.Drawing.Size(54, 13)
        Me.lblAddr1.TabIndex = 9
        Me.lblAddr1.Text = "Address 1"
        '
        'tbAddr1
        '
        Me.tbAddr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddr1.Location = New System.Drawing.Point(60, 43)
        Me.tbAddr1.Name = "tbAddr1"
        Me.tbAddr1.Size = New System.Drawing.Size(168, 20)
        Me.tbAddr1.TabIndex = 4
        '
        'gbEmail
        '
        Me.gbEmail.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbEmail.Controls.Add(Me.tbEmail)
        Me.gbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEmail.Location = New System.Drawing.Point(7, 70)
        Me.gbEmail.Name = "gbEmail"
        Me.gbEmail.Size = New System.Drawing.Size(234, 47)
        Me.gbEmail.TabIndex = 1
        Me.gbEmail.TabStop = False
        Me.gbEmail.Text = "E-mail"
        '
        'pnlOrders
        '
        Me.pnlOrders.AutoScroll = True
        Me.pnlOrders.BackColor = System.Drawing.Color.Beige
        Me.pnlOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrders.Location = New System.Drawing.Point(246, 26)
        Me.pnlOrders.Name = "pnlOrders"
        Me.pnlOrders.Size = New System.Drawing.Size(308, 227)
        Me.pnlOrders.TabIndex = 16
        '
        'lblOrders
        '
        Me.lblOrders.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrders.Location = New System.Drawing.Point(256, 20)
        Me.lblOrders.Name = "lblOrders"
        Me.lblOrders.Size = New System.Drawing.Size(69, 13)
        Me.lblOrders.TabIndex = 17
        Me.lblOrders.Text = "Order history"
        '
        'gbUser
        '
        Me.gbUser.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbUser.Controls.Add(Me.cboUsername)
        Me.gbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUser.Location = New System.Drawing.Point(7, 26)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(234, 40)
        Me.gbUser.TabIndex = 0
        Me.gbUser.TabStop = False
        Me.gbUser.Text = "Username"
        '
        'cboUsername
        '
        Me.cboUsername.FormattingEnabled = True
        Me.cboUsername.Location = New System.Drawing.Point(6, 15)
        Me.cboUsername.Name = "cboUsername"
        Me.cboUsername.Size = New System.Drawing.Size(222, 21)
        Me.cboUsername.Sorted = True
        Me.cboUsername.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ContactToolStripMenuItem, Me.FiltersToolStripMenuItem, Me.OrdersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemUndo, Me.ToolStripSeparator1, Me.NewContactToolStripMenuItem, Me.DeleteContactToolStripMenuItem})
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'MenuItemUndo
        '
        Me.MenuItemUndo.Enabled = False
        Me.MenuItemUndo.Name = "MenuItemUndo"
        Me.MenuItemUndo.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemUndo.Text = "Undo changes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'NewContactToolStripMenuItem
        '
        Me.NewContactToolStripMenuItem.Name = "NewContactToolStripMenuItem"
        Me.NewContactToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewContactToolStripMenuItem.Text = "New Contact"
        '
        'DeleteContactToolStripMenuItem
        '
        Me.DeleteContactToolStripMenuItem.Name = "DeleteContactToolStripMenuItem"
        Me.DeleteContactToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteContactToolStripMenuItem.Text = "Delete Contact"
        '
        'FiltersToolStripMenuItem
        '
        Me.FiltersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemMsgd, Me.MenuItemInvd, Me.MenuItemPaid, Me.MenuItemPckd, Me.MenuItemUnchkd, Me.MenuItemNoOrd})
        Me.FiltersToolStripMenuItem.Name = "FiltersToolStripMenuItem"
        Me.FiltersToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.FiltersToolStripMenuItem.Text = "Filters"
        '
        'MenuItemMsgd
        '
        Me.MenuItemMsgd.Checked = True
        Me.MenuItemMsgd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItemMsgd.Name = "MenuItemMsgd"
        Me.MenuItemMsgd.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemMsgd.Text = "Messaged"
        '
        'MenuItemInvd
        '
        Me.MenuItemInvd.Checked = True
        Me.MenuItemInvd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItemInvd.Name = "MenuItemInvd"
        Me.MenuItemInvd.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemInvd.Text = "Invoiced"
        '
        'MenuItemPaid
        '
        Me.MenuItemPaid.Name = "MenuItemPaid"
        Me.MenuItemPaid.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemPaid.Text = "Paid"
        '
        'MenuItemPckd
        '
        Me.MenuItemPckd.Name = "MenuItemPckd"
        Me.MenuItemPckd.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemPckd.Text = "Packed"
        '
        'MenuItemUnchkd
        '
        Me.MenuItemUnchkd.Checked = True
        Me.MenuItemUnchkd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItemUnchkd.Name = "MenuItemUnchkd"
        Me.MenuItemUnchkd.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemUnchkd.Text = "Unchecked"
        '
        'MenuItemNoOrd
        '
        Me.MenuItemNoOrd.Checked = True
        Me.MenuItemNoOrd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItemNoOrd.Name = "MenuItemNoOrd"
        Me.MenuItemNoOrd.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemNoOrd.Text = "No Orders"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemAddOrd})
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'MenuItemAddOrd
        '
        Me.MenuItemAddOrd.Name = "MenuItemAddOrd"
        Me.MenuItemAddOrd.Size = New System.Drawing.Size(152, 22)
        Me.MenuItemAddOrd.Text = "Add Order"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 260)
        Me.Controls.Add(Me.gbUser)
        Me.Controls.Add(Me.lblOrders)
        Me.Controls.Add(Me.pnlOrders)
        Me.Controls.Add(Me.gbEmail)
        Me.Controls.Add(Me.gbAddress)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Order Tracker"
        Me.gbAddress.ResumeLayout(False)
        Me.gbAddress.PerformLayout()
        Me.gbEmail.ResumeLayout(False)
        Me.gbEmail.PerformLayout()
        Me.gbUser.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents gbAddress As System.Windows.Forms.GroupBox
    Friend WithEvents tbAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents gbEmail As System.Windows.Forms.GroupBox
    Friend WithEvents lblAddr4 As System.Windows.Forms.Label
    Friend WithEvents lblAddr3 As System.Windows.Forms.Label
    Friend WithEvents tbAddr4 As System.Windows.Forms.TextBox
    Friend WithEvents tbAddr3 As System.Windows.Forms.TextBox
    Friend WithEvents tbAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAddr2 As System.Windows.Forms.Label
    Friend WithEvents lblAddr1 As System.Windows.Forms.Label
    Friend WithEvents pnlOrders As System.Windows.Forms.Panel
    Friend WithEvents lblOrders As System.Windows.Forms.Label
    Friend WithEvents gbUser As System.Windows.Forms.GroupBox
    Friend WithEvents cboUsername As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemMsgd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemInvd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemPaid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemPckd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemUnchkd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemNoOrd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemAddOrd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
