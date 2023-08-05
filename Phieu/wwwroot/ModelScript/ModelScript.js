
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

function Success(MaNV, Sdt, Tenmaytinh, Username, Password, Thietbikhac, Tinhtrang, Ghichu) {
    var i = 0;
    var manv = document.getElementById('MaNV').value;

    if (manv != null) {


        var sdt = document.getElementById('Sdt').value;
        var tenpc = document.getElementById('Tenmaytinh').value;
        var user = document.getElementById('Username').value;
        var pass = document.getElementById('Password').value;
        var thietbikhac = document.getElementById('Thietbikhac').value;
        var tinhtrang = document.getElementById('Tinhtrang').value;
        var ghichu = document.getElementById('Ghichu').value;
        var trangThaiPhieu = "Chờ tiếp nhận";
        var loaiSuaChua = "Chưa xác định";

        $.ajax({
            type: 'POST',
            url: '/DangKySuaChua/DangKySuaChua',
            //contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            datatype: Text,
            data: { manv, sdt, tenpc, user, pass, thietbikhac, tinhtrang, ghichu, trangThaiPhieu, loaiSuaChua },
            success: function (response) {
                window.location.reload();
                Swal.fire(
                    'Chúc mừng đăng ký thành công',
                    'Số phiếu là:');
            }
        });


    }



    else {
        Swal.fire(
            'Mời nhập mã nhân viên',
            'Xin nhập lại')
    }

}

   

function CheckNV() {
    //var manv = document.getElementById('MaNV').value;
    var manv = $("#MaNV").val();
    $.ajax({

        url: '/DangKySuaChua/KiemtraMaNV',
        type: 'POST',
       /* datatype: Text,*/
        data: { manv },
        success: function (response) {
            if (response.mesage == "OK") {
                var item = response.model;
                $("#Hoten").val(item.tenNv);
                $("#Donvi").val(item.donVi);
                $("#Chucdanh").val(item.chucDanh);
            }
            else {
                Swal.fire(
                    'Mã nhân viên chưa chính xác',
                    'Xin nhập lại');
                ResetForm();
            }
        }
    });
}
function ResetForm() {
    $("#MaNV").val("");
    $("#Hoten").val("");
    $("#Donvi").val("");
    $("#Chucdanh").val("");
    $("#Sdt").val("");
    $("#Tenmaytinh").val("");
    $("#Username").val("");
    $("#Password").val("");
    $("#Thietbikhac").val("");
    $("#Tinhtrang").val("");
    $("#Ghichu").val("");

}



