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
    var _status = $('#Status').val();
    var array = _status.split(',');
    $('#SelectStatus').val(array);


    $('#SelectStatus').select2({
        theme: "bootstrap"
    });

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
            url: _urlApi + "POrder/Export",
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
    $("#SelectStatus").on("change", function () {
        var _select = $('#SelectStatus').val();
        var arselect = "";
        $.each(_select, function (index, value) {
            arselect = arselect + value + ",";
        });
        $('#Status').val(arselect);
    });

}));


