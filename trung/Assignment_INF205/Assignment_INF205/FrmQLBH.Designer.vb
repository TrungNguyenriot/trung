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
        Me.dgvDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbLSP = New System.Windows.Forms.ComboBox()
        Me.cmbfind = New System.Windows.Forms.ComboBox()
        Me.rdokhachhang = New System.Windows.Forms.RadioButton()
        Me.rdohoadon = New System.Windows.Forms.RadioButton()
        Me.rdoloaisanpham = New System.Windows.Forms.RadioButton()
        Me.rdoSanPham = New System.Windows.Forms.RadioButton()
        CType(Me.dgvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDataGridView
        '
        Me.dgvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataGridView.Location = New System.Drawing.Point(12, 75)
        Me.dgvDataGridView.Name = "dgvDataGridView"
        Me.dgvDataGridView.Size = New System.Drawing.Size(496, 242)
        Me.dgvDataGridView.TabIndex = 0
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(635, 75)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(113, 23)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(635, 104)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(113, 23)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(635, 133)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(113, 23)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SEARCH"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(202, 37)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(306, 20)
        Me.txtsearch.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CmbLSP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(529, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 98)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiter"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Loaisanpham"
        '
        'CmbLSP
        '
        Me.CmbLSP.FormattingEnabled = True
        Me.CmbLSP.Location = New System.Drawing.Point(6, 46)
        Me.CmbLSP.Name = "CmbLSP"
        Me.CmbLSP.Size = New System.Drawing.Size(190, 24)
        Me.CmbLSP.TabIndex = 0
        '
        'cmbfind
        '
        Me.cmbfind.FormattingEnabled = True
        Me.cmbfind.Items.AddRange(New Object() {"MaKH", "TenKH"})
        Me.cmbfind.Location = New System.Drawing.Point(72, 36)
        Me.cmbfind.Name = "cmbfind"
        Me.cmbfind.Size = New System.Drawing.Size(124, 21)
        Me.cmbfind.TabIndex = 13
        '
        'rdokhachhang
        '
        Me.rdokhachhang.AutoSize = True
        Me.rdokhachhang.Location = New System.Drawing.Point(529, 75)
        Me.rdokhachhang.Name = "rdokhachhang"
        Me.rdokhachhang.Size = New System.Drawing.Size(91, 17)
        Me.rdokhachhang.TabIndex = 14
        Me.rdokhachhang.TabStop = True
        Me.rdokhachhang.Text = "KhachHang"
        Me.rdokhachhang.UseVisualStyleBackColor = True
        '
        'rdohoadon
        '
        Me.rdohoadon.AutoSize = True
        Me.rdohoadon.Location = New System.Drawing.Point(529, 104)
        Me.rdohoadon.Name = "rdohoadon"
        Me.rdohoadon.Size = New System.Drawing.Size(71, 17)
        Me.rdohoadon.TabIndex = 15
        Me.rdohoadon.TabStop = True
        Me.rdohoadon.Text = "HoaDon"
        Me.rdohoadon.UseVisualStyleBackColor = True
        '
        'rdoloaisanpham
        '
        Me.rdoloaisanpham.AutoSize = True
        Me.rdoloaisanpham.Location = New System.Drawing.Point(529, 133)
        Me.rdoloaisanpham.Name = "rdoloaisanpham"
        Me.rdoloaisanpham.Size = New System.Drawing.Size(102, 17)
        Me.rdoloaisanpham.TabIndex = 16
        Me.rdoloaisanpham.TabStop = True
        Me.rdoloaisanpham.Text = "LoaiSanPham"
        Me.rdoloaisanpham.UseVisualStyleBackColor = True
        '
        'rdoSanPham
        '
        Me.rdoSanPham.AutoSize = True
        Me.rdoSanPham.Location = New System.Drawing.Point(529, 157)
        Me.rdoSanPham.Name = "rdoSanPham"
        Me.rdoSanPham.Size = New System.Drawing.Size(78, 17)
        Me.rdoSanPham.TabIndex = 17
        Me.rdoSanPham.TabStop = True
        Me.rdoSanPham.Text = "SanPham"
        Me.rdoSanPham.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 350)
        Me.Controls.Add(Me.rdoSanPham)
        Me.Controls.Add(Me.rdoloaisanpham)
        Me.Controls.Add(Me.rdohoadon)
        Me.Controls.Add(Me.rdokhachhang)
        Me.Controls.Add(Me.cmbfind)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dgvDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Quản Lí Bán Hàng"
        CType(Me.dgvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbLSP As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbfind As System.Windows.Forms.ComboBox
    Friend WithEvents rdokhachhang As System.Windows.Forms.RadioButton
    Friend WithEvents rdohoadon As System.Windows.Forms.RadioButton
    Friend WithEvents rdoloaisanpham As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSanPham As System.Windows.Forms.RadioButton

End Class
