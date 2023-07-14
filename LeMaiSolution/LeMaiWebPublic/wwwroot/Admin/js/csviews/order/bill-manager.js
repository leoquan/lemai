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

    $('#btnFilter').on("click", function () {

        $.ajax({
            type: "POST",
            url: _urlApi + "POrder/BillManager",
            contentType: "application/json",
            data: JSON.stringify({
                FromDate: '2023-07-01',
                ToDate: '2023-07-10',
                Status: '-1',
                KeySearch: 'Từ khóa'
            }),
            success: function (result) {
                if (result.code == 200) {

                }
                else {
                    toastr["error"](result.error, "Lỗi");
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    });

    $('#btnExport').on("click", function () {
        alert('Export');
    });

}));


