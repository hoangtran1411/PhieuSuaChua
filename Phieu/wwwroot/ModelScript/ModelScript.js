
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
    var manv = $("#MaNV").val();;

    CheckNV(
        function (manv) {
            if (manv != "") {
                console.log("Mã nhân viên hợp lệ: " + manv);

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
                        Swal.fire(
                            'Chúc mừng đăng ký thành công',
                            'Số phiếu là:');
                        ResetForm();
                    }
                });
            }
            else {
                console.log("Mã nhân viên không hợp lệ");
            }
        },
        function () {
            console.log("Mã nhân viên không chính xác");
           
        }
    );
}

 

function CheckNV(successCallback, errorCallback) {
   
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
                successCallback(item.maNv);
            }
            else {
                Swal.fire(
                    'Mã nhân viên chưa chính xác',
                    'Xin nhập lại');
                errorCallback();
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
    // enable form disble
    $("#Thietbikhac").attr("disabled", false);
    $("#Tenmaytinh").attr("disabled", false);
    $("#Username").attr("disabled", false);
    $("#Password").attr("disabled", false);

}
function CheckThietBi() {
    var kt = $("#Tenmaytinh").val();
    var tb = $("#Thietbikhac").val();
    if (kt != "" && tb == "") {
        $("#Thietbikhac").attr("disabled", true);
    }
    else {       
        $("#Tenmaytinh").attr("disabled", true);
        $("#Username").attr("disabled", true);
        $("#Password").attr("disabled", true);
    }

}




