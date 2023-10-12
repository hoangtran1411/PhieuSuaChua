
async function Dangky() {
   /* var i = 0;*/
    var manv = $('#MaNV').val();
    var sdt = $('#Sdt').val();
    var tenpc = $('#Tenmaytinh').val();
    var user = $('#Username').val();
    var pass = $('#Password').val();
    var thietbikhac = $('#Thietbikhac').val();
    var tinhtrang = $('#Tinhtrang').val();
    var ghichu = $('#Ghichu').val();  
    var hoten = $('#Hoten').val();
    var donvi = $('#Donvi').val();
    var chucdanh = $('#Chucdanh').val();
    var checkNV = await CheckNV();
    var checkSDT = CheckSdt();
    var trangThaiPhieu = "Chờ tiếp nhận";
    var loaiSuaChua = "==============";
    if (checkNV == true && checkSDT == true)
        {
            $.ajax({
                type: 'POST',
                url: '/DangKySuaChua/DangKySuaChua',
                dataType: 'json',
                data: { manv, sdt, tenpc, user, pass, thietbikhac, tinhtrang, ghichu, trangThaiPhieu, loaiSuaChua },
                success: function (response) {
                    if (response.mesage == "OK") {
                        //console.log(response.model)
                        Swal.fire(
                            'Số phiếu là: ' + response.model,
                            'Chúc mừng đăng ký thành công',);
                        ResetForm();
                    }

                }
            });
        }
        
     else {
            Swal.fire(
                'Vui lòng nhập đủ thông tin',
                'Xin nhập lại');           
        }
    }
   
async function CheckNV() {

    //successCallback, errorCallback
    var manv = $("#MaNV").val();
    //var result;
    var response =  await $.ajax({

        url: '/DangKySuaChua/KiemtraMaNV',
        type: 'POST',
        dataType: 'json',
        data: { manv }
      
        }
    );
  
        if (response.mesage == "OK") {
            var item = response.model;
            $("#Hoten").val(item.tenNv);
            $("#Donvi").val(item.donVi);
            $("#Chucdanh").val(item.chucDanh);
            return true;
          
        }
        else {
          
            return false;
        
            ResetForm();
        }
    //return result;
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
function CheckSdt() {
    var sdt = $('#Sdt').val();
    if (sdt == "") {
        return false;
    }
    else {
        return true;
    }
}
function CheckUserPass() {
    var user = $('#Username').val();
    var pass = $('#Password').val();
    if (user == "" || pass == "") {
        Swal.fire(
            'Chưa nhập UserName hoặc Password',
            'Vui lòng nhập đủ thông tin');
    }
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
