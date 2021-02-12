<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesTaxCalculator
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
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.LblSalesTaxTotal = New System.Windows.Forms.Label()
        Me.lblTotalCostTotal = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCost2 = New System.Windows.Forms.Label()
        Me.txtItemCost = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.lblStore = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(28, 85)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(201, 17)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.Text = "Enter Name of Purchased Item:"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(91, 53)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(301, 21)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "The tax rate for all items is 8.75%"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(28, 128)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(126, 17)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Enter Cost of Item:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(93, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(299, 34)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Sales Tax Calculator"
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(317, 185)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(189, 185)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 27)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.AutoSize = True
        Me.btnCalc.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(31, 185)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(93, 27)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "Display Cost"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(235, 82)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(153, 22)
        Me.txtName.TabIndex = 10
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(235, 125)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(149, 22)
        Me.txtCost.TabIndex = 11
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTax.Location = New System.Drawing.Point(28, 334)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(70, 17)
        Me.lblSalesTax.TabIndex = 12
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(28, 379)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(75, 17)
        Me.lblTotalCost.TabIndex = 13
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'LblSalesTaxTotal
        '
        Me.LblSalesTaxTotal.AutoSize = True
        Me.LblSalesTaxTotal.Location = New System.Drawing.Point(270, 168)
        Me.LblSalesTaxTotal.Name = "LblSalesTaxTotal"
        Me.LblSalesTaxTotal.Size = New System.Drawing.Size(0, 17)
        Me.LblSalesTaxTotal.TabIndex = 14
        '
        'lblTotalCostTotal
        '
        Me.lblTotalCostTotal.AutoSize = True
        Me.lblTotalCostTotal.Location = New System.Drawing.Point(270, 213)
        Me.lblTotalCostTotal.Name = "lblTotalCostTotal"
        Me.lblTotalCostTotal.Size = New System.Drawing.Size(0, 17)
        Me.lblTotalCostTotal.TabIndex = 15
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(235, 331)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(149, 22)
        Me.txtTax.TabIndex = 16
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(235, 376)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(149, 22)
        Me.txtTotalCost.TabIndex = 17
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(31, 247)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(75, 17)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Item Name"
        '
        'lblCost2
        '
        Me.lblCost2.AutoSize = True
        Me.lblCost2.Location = New System.Drawing.Point(44, 286)
        Me.lblCost2.Name = "lblCost2"
        Me.lblCost2.Size = New System.Drawing.Size(36, 17)
        Me.lblCost2.TabIndex = 19
        Me.lblCost2.Text = "Cost"
        '
        'txtItemCost
        '
        Me.txtItemCost.Location = New System.Drawing.Point(235, 283)
        Me.txtItemCost.Name = "txtItemCost"
        Me.txtItemCost.Size = New System.Drawing.Size(149, 22)
        Me.txtItemCost.TabIndex = 20
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(235, 244)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(149, 22)
        Me.txtItemName.TabIndex = 21
        '
        'lblStore
        '
        Me.lblStore.AutoSize = True
        Me.lblStore.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStore.Location = New System.Drawing.Point(439, 40)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(316, 34)
        Me.lblStore.TabIndex = 23
        Me.lblStore.Text = "Draconismon Gaming"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(445, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 313)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'frmSalesTaxCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 424)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStore)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtItemCost)
        Me.Controls.Add(Me.lblCost2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTotalCostTotal)
        Me.Controls.Add(Me.LblSalesTaxTotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblItemName)
        Me.Name = "frmSalesTaxCalculator"
        Me.Text = "Sales Tax Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemName As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents LblSalesTaxTotal As Label
    Friend WithEvents lblTotalCostTotal As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblCost2 As Label
    Friend WithEvents txtItemCost As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblStore As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
