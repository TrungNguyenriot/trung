Public Class Form1
    Private _DBAccess As New DataBaseAccess

    'Khai bao bien trang thai kiem tar du lieu load
    Private _isLoading As Boolean = False

    'nem LSP len combobox
    Private Sub LoadDataOnComboBox()
        Dim sqlQuery As String = "SELECT MaLSP, TenLSP, Soluong From dbo.LoaiSanPham"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.CmbLSP.DataSource = dTable
        Me.CmbLSP.ValueMember = "MaLSP"
        Me.CmbLSP.DisplayMember = "TenLSP"
    End Sub
    'Nem SP len gridview
    Private Sub LoadDataOnGridView(MaLSP As String)
        Dim sqlQuery As String = _
            String.Format("SELECT MaSP, TenSP, Soluong, MaLSP, Mota From dbo.SanPham Where MaLSP = '{0}'", MaLSP)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvDataGridView.DataSource = dTable
        With Me.dgvDataGridView
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "TenSP"
            .Columns(2).HeaderText = "Soluong"
            .Columns(3).HeaderText = "MaLSP"
            .Columns(4).HeaderText = "Mota"

        End With
    End Sub
    Private Sub LoadDataKhacHang()
        Dim sqlQuery As String = "SELECT * from dbo.KhachHang "
        'If Me.cmbfind.SelectedIndex = 0 Then
        '    sqlQuery += String.Format("AND MaKH like '{0}%'", Value)
        'ElseIf Me.cmbfind.SelectedIndex = 1 Then
        '    sqlQuery += String.Format("AND TenKH like '{0}%'", Value)
        'End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvDataGridView.DataSource = dTable
        With Me.dgvDataGridView
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(1).Width = 150

        End With
    End Sub
    Private Sub LoadDataHoaDon()
        Dim sqlQuery As String = "SELECT * from dbo.HoaDon "
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvDataGridView.DataSource = dTable
        With Me.dgvDataGridView
            .Columns(0).HeaderText = "MaHD"
            .Columns(1).HeaderText = "NgayXHD"
            .Columns(2).HeaderText = "MaKH"
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(0).Width = 150

        End With
    End Sub
    Private Sub LoadDataLSP()
        Dim sqlquery As String = "SELECT * from dbo.LoaiSanPham"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlquery)
        Me.dgvDataGridView.DataSource = dTable
        With Me.dgvDataGridView
            .Columns(0).HeaderText = "MaLSP"
            .Columns(1).HeaderText = "TenLSP"
            .Columns(2).HeaderText = "SoLuong"
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(0).Width = 150
        End With
    End Sub
    Private Sub LoadDataSanPham()
        Dim sqlquery As String = "SELECT * from dbo.SanPham"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlquery)
        Me.dgvDataGridView.DataSource = dTable
        With Me.dgvDataGridView
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "TenSP"
            .Columns(2).HeaderText = "SoLuong"
            .Columns(3).HeaderText = "MaLSP"
            .Columns(4).HeaderText = "MoTa"

        End With
    End Sub


    Private Sub FrmQLBH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True 'true khi bat du load du lieu

        LoadDataOnComboBox()
        LoadDataOnGridView(Me.CmbLSP.SelectedValue)

        _isLoading = False 'false khi load du lieu xong
    End Sub

    Private Sub CmbLSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLSP.SelectedIndexChanged
        If Not _isLoading Then ' ham if neu load du lieu xong
            LoadDataOnGridView(Me.CmbLSP.SelectedValue)
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim MaKH As String = Me.dgvDataGridView.Rows(Me.dgvDataGridView.CurrentCell.RowIndex).Cells("MaKH").Value
        Dim sqlQuery As String = String.Format("DELETE KhachHang WHERE MaKH ='{0}'", MaKH)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Xoa Thanh Cong !")
            LoadDataKhacHang()
        Else
            MessageBox.Show("Xoa Ko Thanh Cong !")
        End If
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim frm As New FrmThem(True)
        frm.txtIDKH.ReadOnly = True
        With Me.dgvDataGridView
            frm.txtIDKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
            frm.txtTenKH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
            frm.txtSDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
            frm.txtAddress.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
        End With
        frm.ShowDialog()
    End Sub
    

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New FrmThem(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataKhacHang()
        End If
    End Sub
    Private Sub search(value As String)
        Dim sqlQuery As String = "SELECT * from dbo.KhachHang "
        If Me.cmbfind.SelectedIndex = 0 Then
            sqlQuery += String.Format("AND MaKH LIKE '{0}%'", value)
        ElseIf Me.cmbfind.SelectedIndex = 1 Then
            sqlQuery += String.Format("AND TenKH LIKE '{0}%'", Value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvDataGridView.DataSource = dTable
        With Me.dgvDataGridView
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(1).Width = 150

        End With
    End Sub

    Private Sub rdokhachhang_CheckedChanged(sender As Object, e As EventArgs) Handles rdokhachhang.CheckedChanged
        LoadDataKhacHang()
    End Sub

    Private Sub rdohoadon_CheckedChanged(sender As Object, e As EventArgs) Handles rdohoadon.CheckedChanged
        LoadDataHoaDon()
    End Sub

    Private Sub rdoloaisanpham_CheckedChanged(sender As Object, e As EventArgs) Handles rdoloaisanpham.CheckedChanged
        LoadDataLSP()
    End Sub

    Private Sub rdoSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSanPham.CheckedChanged
        LoadDataSanPham()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub
End Class
