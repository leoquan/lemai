$(document).ready(function () {
    $("#btnExportExcel").on("click", function () {
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
            url: linkExport,
            data: JSON.stringify(inputModel),
            success: function (filedata) {
                var bytes = Base64ToBytes(filedata);
                var blob = new Blob([bytes], { type: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" });
                var isIE = false || !!document.documentMode;
                if (isIE) {
                    window.navigator.msSaveBlob(blob, "Don_Dat." + _TuNgay + "." + _DenNgay + ".xlsx");
                } else {
                    var url = window.URL || window.webkitURL;
                    link = url.createObjectURL(blob);
                    var a = $("<a />");
                    a.attr("download", "Don_Dat." + _TuNgay + "." + _DenNgay + ".xlsx");
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

    // Xóa item
    $(".deleteItem").on("click", function () {
        // Hiển thị dialog xóa
        var _this = $(this);
        var orderid = _this.data("orderid");
        var ordercode = _this.data("ordercode");
        if (confirm("Bạn có muốn xóa đơn đặt hàng " + ordercode) == true) {
            $.ajax({
                type: "POST",
                url: linkDelete,
                data: { OrderId: orderid },
                success: function (o) {
                    if (o == true) {
                        // xóa dòng dữ liệu
                        //$(this).parents("tr").remove();
                        $('#btnfilter').click();
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }

    });
});