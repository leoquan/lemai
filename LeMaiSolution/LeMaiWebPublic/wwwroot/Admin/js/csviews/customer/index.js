$(document).ready($(function () {
    toastr.options = {
        closeButton: false,
        debug: false,
        newestOnTop: false,
        progressBar: false,
        positionClass: "toast-top-right",
        preventDuplicates: false,
        onclick: null,
        showDuration: "300",
        hideDuration: "1000",
        timeOut: "5000",
        extendedTimeOut: "1000",
        showEasing: "swing",
        hideEasing: "linear",
        showMethod: "fadeIn",
        hideMethod: "fadeOut"
    };
    // Cấu hình input Validate
    $('#CustomerPhone').mask("0000000000", { reverse: true, selectOnFocus: true });

    $('#btnAdd').on("click", function () {
        $('#CreateUpdateModal').modal('show');
    });
    // Lưu trên Modal
    $('#btnSave').on("click", function () {
        // Kiểm tra dữ liệu input
        var resultCheck = checkValid(true);
        if (resultCheck) {
            var _CustomerName = $('#CustomerName').val();
            $.ajax({
                type: "POST",
                url: _urlApi + "PCustomer/CreateUpdate",
                contentType: "application/json",
                data: JSON.stringify({
                    CustomerName: _CustomerName,
                }),
                success: function (result) {
                    if (result.code == 200) {
                        toastr["success"]("Lưu thành công: " + result.resultString, "Thành công");
                    }
                    else {
                        toastr["error"](result.error, "Lỗi");
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });

        }
    });
    // Xem chi tiết
    $('.SubView').on("click", function () {

        // Load dữ liệu cho Modal
    });

    // Chỉnh sửa
    $('.SubEdit').on("click", function () {
        var _this = $(this);
        alert(_this.data('itemid'));
        // Load dữ liệu cho Modal
        $('#CustomerName').val("Chỉnh sửa khách hàng");
        // Hiển thị Popup
        $('#CreateUpdateModal').modal('show');
    });

    // Xóa
    $('.SubDelete').on("click", function () {
        var _this = $(this);
        if (confirm("Bạn có chắc muốn xóa đi thông tin khách hàng?") == true) {
            var _id = _this.data('itemid');
            $.ajax({
                type: "POST",
                url: _urlApi + "PCustomer/Delete",
                data: { Id: _id },
                success: function (result) {
                    if (result.code == 200) {
                        toastr["success"]("Xóa dữ liệu thành công!", "Thành công");
                        _this.parent().parent().remove();
                        $('#datatablesSimple').bootstrapTable();
                    }
                    else {
                        toastr["error"](result.error, "Lỗi");
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }
    });

    // Xuất dữ liệu excel
    $("#btnExport").on("click", function () {
        var _TuNgay = $('#TuNgay').val();
        var _DenNgay = $('#DenNgay').val();
        var _Status = $('#status').val();
        var currentdate = new Date();
        var inputModel = {
            datefrom: _TuNgay,
            dateto: _DenNgay,
            status: _Status
        }
        $.ajax({
            type: "POST",
            url: _urlApi + "PCustomer/Export",
            data: JSON.stringify(inputModel),
            success: function (filedata) {
                var bytes = Base64ToBytes(filedata);
                var blob = new Blob([bytes], { type: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" });
                var isIE = false || !!document.documentMode;
                if (isIE) {
                    window.navigator.msSaveBlob(blob, "Hang_Gui." + _TuNgay + "." + _DenNgay + ".xlsx");
                } else {
                    var url = window.URL || window.webkitURL;
                    link = url.createObjectURL(blob);
                    var a = $("<a />");
                    a.attr("download", "Hang_Gui." + _TuNgay + "." + _DenNgay + ".xlsx");
                    a.attr("href", link);
                    $("body").append(a);
                    a[0].click();
                    $("body").remove(a);
                }
            },
            error: function (err) {
                console.log(err);
            },
            cache: false,
            contentType: false,
            processData: false,
        });
    });
    function Base64ToBytes(base64) {
        var binary_string = window.atob(base64);
        var len = binary_string.length;
        var bytes = new Uint8Array(len);
        for (var i = 0; i < len; i++) {
            bytes[i] = binary_string.charCodeAt(i);
        }
        return bytes.buffer;
    }
    function checkValid(showMessage) {
        var resultValid = true;
        var _CustomerName = $('#CustomerName').val();

        // Thông tin người gửi
        if (_CustomerName == '') {
            $('#CustomerName').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#CustomerName').removeClass('is-invalid').addClass('is-valid');
        }


        if (resultValid == false && showMessage == true) {
            toastr["error"]("Lỗi dữ liệu cần kiểm tra lại!");
        }
        return resultValid;
    };
}));


