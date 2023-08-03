
    function Dangky() {

        Swal.fire({
            title: 'Bạn có chắc chắn?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes'
        }).then((result) => {
            if (result.isConfirmed) {
                Swal.fire(
                    'Deleted!',
                    'Your file has been deleted.',
                    'success'
                )
            }
        })
    }

function Success(MaNV,Sdt,Tenmaytinh,Username,Password,Thietbikhac,Tinhtrang,Ghichu) {
    var i = 0;
    var manv = document.getElementById('MaNV').value;
    
    if (KiemTraManv(manv) > 0) {
        var sdt = document.getElementById('Sdt').value;
        var tenpc = document.getElementById('Tenmaytinh').value;
        var user = document.getElementById('Username').value;
        var pass = document.getElementById('Password').value;
        var thietbikhac = document.getElementById('Thietbikhac').value;
        var tinhtrang = document.getElementById('Tinhtrang').value;
        var ghichu = document.getElementById('Ghichu').value;
        var trangThaiPhieu = "Chờ tiếp nhận";
        var loaiSuaChua = "Chưa xác định";
        if (manv != null) {
            Swal.fire(
                'Số phiếu là:',
                'Chúc mừng bạn đã đăng ký thành công')

            $.ajax({
                type: 'POST',
                url: '/DangKySuaChua/DangKySuaChua',
                //contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                datatype: Text,
                data: { manv, sdt, tenpc, user, pass, thietbikhac, tinhtrang, ghichu, trangThaiPhieu, loaiSuaChua },
                success: function (response) {
                    //window.location.reload()
                },
            }

            )
        }
        else {
            Swal.fire(
                'Bạn chưa nhập mã nhân viên',
                'Xin nhập đủ thông tin')
        }
    }
    else {
        Swal.fire(
            'Mã nhân viên chưa chính xác',
            'Xin nhập lại')
    }
   
}
function KiemTraManv(manv) {
    let result = 0;
    $.ajax({
        type: 'POST',
        url: '/DangKySuaChua/KiemtraMaNV',
        datatype: JSON,
        data: { manv },
        success: function (response) {
            if (response) {
                result = 1;
            }
            else {
                result = 0
            }
        }
    })
    return result;
}
function ResetForm() {
    $("#MaNV").value("");
    $("#Hoten").value("");
    $("#Donvi").value("");
    $("#Chucdanh").value("");
    $("#Sdt").value("");
    $("#Tenmaytinh").value("");
    $("#Username").value("");
    $("#Password").value("");
    $("#Thietbikhac").value("");
    $("#Tinhtrang").value("");
    $("#Ghichu").value("");

}



