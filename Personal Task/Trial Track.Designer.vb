<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Trial_Track
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RemarksBox = New System.Windows.Forms.TextBox()
        Me.ShipDate = New System.Windows.Forms.DateTimePicker()
        Me.SampleDate = New System.Windows.Forms.DateTimePicker()
        Me.ContactDate = New System.Windows.Forms.DateTimePicker()
        Me.ContactBox = New System.Windows.Forms.TextBox()
        Me.TCodeBox = New System.Windows.Forms.TextBox()
        Me.QtyBox = New System.Windows.Forms.TextBox()
        Me.ShipModeBox = New System.Windows.Forms.TextBox()
        Me.DocketBox = New System.Windows.Forms.TextBox()
        Me.ProductBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.PersonBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CustBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GRID1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.RecordCount = New System.Windows.Forms.Label()
        Me.RecordLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contact Peson"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.RemarksBox)
        Me.Panel1.Controls.Add(Me.ShipDate)
        Me.Panel1.Controls.Add(Me.SampleDate)
        Me.Panel1.Controls.Add(Me.ContactDate)
        Me.Panel1.Controls.Add(Me.ContactBox)
        Me.Panel1.Controls.Add(Me.TCodeBox)
        Me.Panel1.Controls.Add(Me.QtyBox)
        Me.Panel1.Controls.Add(Me.ShipModeBox)
        Me.Panel1.Controls.Add(Me.DocketBox)
        Me.Panel1.Controls.Add(Me.ProductBox)
        Me.Panel1.Controls.Add(Me.CityBox)
        Me.Panel1.Controls.Add(Me.PersonBox)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.CustBox)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 167)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(741, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 58)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controls"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(87, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(6, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RemarksBox
        '
        Me.RemarksBox.Location = New System.Drawing.Point(112, 98)
        Me.RemarksBox.Multiline = True
        Me.RemarksBox.Name = "RemarksBox"
        Me.RemarksBox.Size = New System.Drawing.Size(619, 58)
        Me.RemarksBox.TabIndex = 9
        '
        'ShipDate
        '
        Me.ShipDate.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.ShipDate.CustomFormat = "yyyy-MM-dd"
        Me.ShipDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ShipDate.Location = New System.Drawing.Point(622, 67)
        Me.ShipDate.Name = "ShipDate"
        Me.ShipDate.Size = New System.Drawing.Size(109, 20)
        Me.ShipDate.TabIndex = 7
        '
        'SampleDate
        '
        Me.SampleDate.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.SampleDate.CustomFormat = "yyyy-MM-dd"
        Me.SampleDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SampleDate.Location = New System.Drawing.Point(622, 39)
        Me.SampleDate.Name = "SampleDate"
        Me.SampleDate.Size = New System.Drawing.Size(109, 20)
        Me.SampleDate.TabIndex = 7
        '
        'ContactDate
        '
        Me.ContactDate.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.ContactDate.CustomFormat = "yyyy-MM-dd"
        Me.ContactDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ContactDate.Location = New System.Drawing.Point(622, 9)
        Me.ContactDate.Name = "ContactDate"
        Me.ContactDate.Size = New System.Drawing.Size(109, 20)
        Me.ContactDate.TabIndex = 6
        '
        'ContactBox
        '
        Me.ContactBox.BackColor = System.Drawing.Color.LightYellow
        Me.ContactBox.Location = New System.Drawing.Point(112, 67)
        Me.ContactBox.Name = "ContactBox"
        Me.ContactBox.Size = New System.Drawing.Size(166, 20)
        Me.ContactBox.TabIndex = 2
        '
        'TCodeBox
        '
        Me.TCodeBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TCodeBox.Enabled = False
        Me.TCodeBox.Location = New System.Drawing.Point(834, 128)
        Me.TCodeBox.Name = "TCodeBox"
        Me.TCodeBox.Size = New System.Drawing.Size(83, 20)
        Me.TCodeBox.TabIndex = 8
        '
        'QtyBox
        '
        Me.QtyBox.BackColor = System.Drawing.Color.LightYellow
        Me.QtyBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.QtyBox.Location = New System.Drawing.Point(834, 98)
        Me.QtyBox.Name = "QtyBox"
        Me.QtyBox.Size = New System.Drawing.Size(83, 20)
        Me.QtyBox.TabIndex = 8
        '
        'ShipModeBox
        '
        Me.ShipModeBox.BackColor = System.Drawing.Color.LightYellow
        Me.ShipModeBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ShipModeBox.Location = New System.Drawing.Point(834, 67)
        Me.ShipModeBox.Name = "ShipModeBox"
        Me.ShipModeBox.Size = New System.Drawing.Size(83, 20)
        Me.ShipModeBox.TabIndex = 8
        '
        'DocketBox
        '
        Me.DocketBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DocketBox.Location = New System.Drawing.Point(351, 67)
        Me.DocketBox.Name = "DocketBox"
        Me.DocketBox.Size = New System.Drawing.Size(175, 20)
        Me.DocketBox.TabIndex = 5
        '
        'ProductBox
        '
        Me.ProductBox.BackColor = System.Drawing.Color.LightYellow
        Me.ProductBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ProductBox.Location = New System.Drawing.Point(351, 38)
        Me.ProductBox.Name = "ProductBox"
        Me.ProductBox.Size = New System.Drawing.Size(175, 20)
        Me.ProductBox.TabIndex = 4
        '
        'CityBox
        '
        Me.CityBox.BackColor = System.Drawing.Color.LightYellow
        Me.CityBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CityBox.Location = New System.Drawing.Point(351, 9)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(175, 20)
        Me.CityBox.TabIndex = 3
        '
        'PersonBox
        '
        Me.PersonBox.BackColor = System.Drawing.Color.LightYellow
        Me.PersonBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PersonBox.Location = New System.Drawing.Point(112, 37)
        Me.PersonBox.Name = "PersonBox"
        Me.PersonBox.Size = New System.Drawing.Size(166, 20)
        Me.PersonBox.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Trial Remarks"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(290, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Docket ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(290, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Product"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(290, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(738, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "TCode"
        '
        'CustBox
        '
        Me.CustBox.BackColor = System.Drawing.Color.LightYellow
        Me.CustBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CustBox.Location = New System.Drawing.Point(112, 7)
        Me.CustBox.Name = "CustBox"
        Me.CustBox.Size = New System.Drawing.Size(166, 20)
        Me.CustBox.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(738, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 15)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Product Qty"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(738, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Shipping Mode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(532, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Shipping Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(532, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Sample Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(532, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Contact Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Contact No"
        '
        'GRID1
        '
        Me.GRID1.BackgroundColor = System.Drawing.Color.Lavender
        Me.GRID1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID1.Location = New System.Drawing.Point(0, 213)
        Me.GRID1.Name = "GRID1"
        Me.GRID1.Size = New System.Drawing.Size(936, 278)
        Me.GRID1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.RecordCount)
        Me.Panel2.Controls.Add(Me.RecordLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 167)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(936, 46)
        Me.Panel2.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(844, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Location = New System.Drawing.Point(158, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 37)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTERS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(444, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Product"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(229, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 15)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "City"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 15)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Name"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Lavender
        Me.TextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox11.Location = New System.Drawing.Point(497, 12)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(166, 20)
        Me.TextBox11.TabIndex = 0
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Lavender
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.Location = New System.Drawing.Point(265, 12)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(166, 20)
        Me.TextBox10.TabIndex = 0
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Lavender
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.Location = New System.Drawing.Point(51, 12)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(166, 20)
        Me.TextBox9.TabIndex = 0
        '
        'RecordCount
        '
        Me.RecordCount.AutoSize = True
        Me.RecordCount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordCount.Location = New System.Drawing.Point(14, 12)
        Me.RecordCount.Name = "RecordCount"
        Me.RecordCount.Size = New System.Drawing.Size(67, 19)
        Me.RecordCount.TabIndex = 2
        Me.RecordCount.Text = "Records :"
        '
        'RecordLabel
        '
        Me.RecordLabel.AutoSize = True
        Me.RecordLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordLabel.Location = New System.Drawing.Point(87, 12)
        Me.RecordLabel.Name = "RecordLabel"
        Me.RecordLabel.Size = New System.Drawing.Size(33, 19)
        Me.RecordLabel.TabIndex = 0
        Me.RecordLabel.Text = "488"
        '
        'Trial_Track
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(936, 491)
        Me.Controls.Add(Me.GRID1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Trial_Track"
        Me.Text = "Trial_Track"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContactBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents PersonBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CustBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GRID1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RecordCount As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RemarksBox As TextBox
    Friend WithEvents SampleDate As DateTimePicker
    Friend WithEvents ContactDate As DateTimePicker
    Friend WithEvents DocketBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents RecordLabel As Label
    Friend WithEvents ShipModeBox As TextBox
    Friend WithEvents ProductBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ShipDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents QtyBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TCodeBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
End Class
