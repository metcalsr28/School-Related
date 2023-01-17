<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresentation
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
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHelloWorld = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbCustomerID = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbAddress1 = New System.Windows.Forms.TextBox()
        Me.tbAddress2 = New System.Windows.Forms.TextBox()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.tbState = New System.Windows.Forms.TextBox()
        Me.tbZip = New System.Windows.Forms.TextBox()
        Me.CustomerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.City = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.State = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Zip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvDisplay = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.OrangeRed
        Me.btnInsert.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInsert.Location = New System.Drawing.Point(524, 209)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(94, 59)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "Add New"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSelect.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSelect.Location = New System.Drawing.Point(524, 77)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(94, 59)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Search"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Crimson
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(524, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 59)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(524, 144)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 59)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnHelloWorld
        '
        Me.btnHelloWorld.BackColor = System.Drawing.Color.HotPink
        Me.btnHelloWorld.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelloWorld.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHelloWorld.Location = New System.Drawing.Point(524, 12)
        Me.btnHelloWorld.Name = "btnHelloWorld"
        Me.btnHelloWorld.Size = New System.Drawing.Size(94, 59)
        Me.btnHelloWorld.TabIndex = 4
        Me.btnHelloWorld.Text = "Hello World"
        Me.btnHelloWorld.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Customer Information:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(350, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 535)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(339, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "State"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(354, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Zip"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 488)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Address1"
        '
        'tbCustomerID
        '
        Me.tbCustomerID.Location = New System.Drawing.Point(122, 397)
        Me.tbCustomerID.Name = "tbCustomerID"
        Me.tbCustomerID.Size = New System.Drawing.Size(193, 20)
        Me.tbCustomerID.TabIndex = 14
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(122, 446)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(193, 20)
        Me.tbName.TabIndex = 15
        '
        'tbAddress1
        '
        Me.tbAddress1.Location = New System.Drawing.Point(122, 490)
        Me.tbAddress1.Name = "tbAddress1"
        Me.tbAddress1.Size = New System.Drawing.Size(193, 20)
        Me.tbAddress1.TabIndex = 16
        '
        'tbAddress2
        '
        Me.tbAddress2.Location = New System.Drawing.Point(122, 535)
        Me.tbAddress2.Name = "tbAddress2"
        Me.tbAddress2.Size = New System.Drawing.Size(193, 20)
        Me.tbAddress2.TabIndex = 17
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(400, 397)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(218, 20)
        Me.tbCity.TabIndex = 18
        '
        'tbState
        '
        Me.tbState.Location = New System.Drawing.Point(400, 443)
        Me.tbState.Name = "tbState"
        Me.tbState.Size = New System.Drawing.Size(218, 20)
        Me.tbState.TabIndex = 19
        '
        'tbZip
        '
        Me.tbZip.Location = New System.Drawing.Point(400, 487)
        Me.tbZip.Name = "tbZip"
        Me.tbZip.Size = New System.Drawing.Size(218, 20)
        Me.tbZip.TabIndex = 20
        '
        'CustomerID
        '
        Me.CustomerID.Text = "Customer ID"
        '
        'CustomerName
        '
        Me.CustomerName.Text = "Name"
        '
        'Address1
        '
        Me.Address1.Text = "Address 1"
        '
        'Address2
        '
        Me.Address2.Text = "Address 2"
        '
        'City
        '
        Me.City.Text = "City"
        '
        'State
        '
        Me.State.Text = "State"
        '
        'Zip
        '
        Me.Zip.Text = "Zip"
        '
        'lvDisplay
        '
        Me.lvDisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CustomerID, Me.CustomerName, Me.Address1, Me.Address2, Me.City, Me.State, Me.Zip})
        Me.lvDisplay.Location = New System.Drawing.Point(12, 12)
        Me.lvDisplay.Name = "lvDisplay"
        Me.lvDisplay.Size = New System.Drawing.Size(490, 322)
        Me.lvDisplay.TabIndex = 5
        Me.lvDisplay.UseCompatibleStateImageBehavior = False
        Me.lvDisplay.View = System.Windows.Forms.View.Details
        '
        'frmPresentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(634, 579)
        Me.Controls.Add(Me.tbZip)
        Me.Controls.Add(Me.tbState)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.tbAddress2)
        Me.Controls.Add(Me.tbAddress1)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.tbCustomerID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvDisplay)
        Me.Controls.Add(Me.btnHelloWorld)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "frmPresentation"
        Me.Text = "Web Service Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsert As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHelloWorld As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbCustomerID As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbAddress1 As TextBox
    Friend WithEvents tbAddress2 As TextBox
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbState As TextBox
    Friend WithEvents tbZip As TextBox
    Friend WithEvents CustomerID As ColumnHeader
    Friend WithEvents CustomerName As ColumnHeader
    Friend WithEvents Address1 As ColumnHeader
    Friend WithEvents Address2 As ColumnHeader
    Friend WithEvents City As ColumnHeader
    Friend WithEvents State As ColumnHeader
    Friend WithEvents Zip As ColumnHeader
    Friend WithEvents lvDisplay As ListView
End Class
