Public Class FrmThem
    Private _DBAccess As New DataBaseAccess

    Private Function InsertKH() As Boolean
        Dim sqlQuery As String = " INSERT INTO KhachHang (MaKH,TenKH,SDT,DiaChi)"
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}')", _
        txtIDKH.Text, txtTenKH.Text, txtSDT.Text, txtAddress.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    'Ham update
    Private Function Updatecode() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE KhachHang SET TenKH = '{0}',SDT ='{1}',DiaChi ='{2}' WHERE MaKH ='{3}'", Me.txtTenKH.Text, Me.txtSDT.Text, Me.txtAddress.Text, Me.txtIDKH.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function



    Private Function Empty() As Boolean
        Return (String.IsNullOrEmpty(txtIDKH.Text) OrElse String.IsNullOrEmpty(txtTenKH.Text) OrElse String.IsNullOrEmpty(txtSDT.Text) OrElse String.IsNullOrEmpty(txtAddress.Text))

    End Function
    'Private Sub frmThem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    If Empty() Then
    '        MessageBox.Show("Nhap Gia tri trc khi luu", "Error", MessageBoxButtons.OK)
    '    Else
    '        If InsertKH() Then
    '            MessageBox.Show("Luu thanh cong !", "Infomation", MessageBoxButtons.OK)
    '        Else
    '            MessageBox.Show("Du lieu luu bi loi~ !", "Error", MessageBoxButtons.OK)
    '        End If
    '    End If
    'End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Empty() Then
            MessageBox.Show("Nhap Gia tri trc khi luu", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If Updatecode() Then
                    MessageBox.Show("Luu thanh cong !", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Du lieu luu bi loi~ !", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertKH() Then
                    MessageBox.Show("Luu thanh cong !", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    MessageBox.Show("Du lieu luu bi loi~ !", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
            
            Me.Close()
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private _isEdit As Boolean = False

    Public Sub New(IsEdit As Boolean)
        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub
End Class