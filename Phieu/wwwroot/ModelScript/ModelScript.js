
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
    //var dangky = $('#DangKySuaChua').serialize();
    //console.log(data);
    var manv = document.getElementById('MaNV').value;
    var sdt = document.getElementById('Sdt').value;
    var tenmaytinh = document.getElementById('Tenmaytinh').value;
    var username = document.getElementById('Username').value;
    var passwords = document.getElementById('Password').value;
    var thietbikhac = document.getElementById('Thietbikhac').value;
    var tinhtrang = document.getElementById('Tinhtrang').value;
    var ghichu = document.getElementById('Ghichu').value;
    var trangThaiPhieu = "Chờ tiếp nhận";
    var loaiSuaChua = "Chưa xác định";
        Swal.fire(
            'Số phiếu là:' ,
            'Chúc mừng bạn đã đăng ký thành công')
       
    $.ajax({
        type: 'POST',
        url: '/DangKySuaChua/DangKySuaChua',
        //contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        datatype: Text,
        data: { manv, sdt, tenmaytinh, username, passwords, thietbikhac, tinhtrang, ghichu, trangThaiPhieu, loaiSuaChua },
        success: function (response) {
            window.location.reload()
        },
        //{ manv: MaNV, hoten: Hoten, donvi: Donvi, chucdanh: Chucdanh, sdt: Sdt, Tenmaytinh: Tenmaytinh, Username: Username, Password: Password, Thietbikhac: Thietbikhac, Tinhtrang: Tinhtrang, Ghichu: Ghichu }
    }

    )
   
    }


