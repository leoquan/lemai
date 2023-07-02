
$(document).ready($(function () {

    $('#AcceptProvince, #PickupProvince').select2({
        theme: "bootstrap"
    });
    // Ẩn đi cái panel
    $('.panelPickup').hide();

    $('#FeeWeight').mask("000,000", { reverse: true, selectOnFocus: true });
    $('#BillWeigt').mask("000,000", { reverse: true, selectOnFocus: true }); 
    $('#COD').mask("00,000,000", { reverse: true, selectOnFocus: true });
    $('#Freight').mask("00,000,000", { reverse: true, selectOnFocus: true });
    $('#DIM_W').mask("000", { reverse: true, selectOnFocus: true });
    $('#DIM_L').mask("000", { reverse: true, selectOnFocus: true });
    $('#DIM_H').mask("000", { reverse: true, selectOnFocus: true });
    $('#AcceptManPhone').mask("0000000000", { reverse: true, selectOnFocus: true });
    $('#PickupManPhone').mask("0000000000", { reverse: true, selectOnFocus: true });
    $('#SendManPhone').mask("0000000000", { reverse: true, selectOnFocus: true });

    // Tìm người gửi
    $("#SendManPhone").on("focusout", function () {
        alert("Tìm số điện thoại của bạn");
    });
    // Tìm người nhận
    $("#AcceptManPhone").on("focusout", function () {
        alert("Tìm số điện thoại người nhận");
    });
    $("#FeeWeight").on("focusout", function () {
        var _Tinh = $('#AcceptProvince').val();
        var _Huyen = $('#AcceptDistrict').val();
        var _Weight = $('#Weight').val();
        $.ajax({
            type: "POST",
            url: '@Url.Action("GetCalculator", "KhachHang")',
            data: { IdTinh: _Tinh, IdHuyen: _Huyen, Weight: _Weight },
            success: function (json) {
                // Set giá
                $('#feeOut').val(json);
            },
            error: function (err) {
                console.log(err);
            }
        });
    });

    $("#AcceptProvince").on("change", function () {
        var _Tinh = $('#AcceptProvince').val();
        $.ajax({
            type: "POST",
            url: _urlApi + "KhachHang/GetHuyen",
            data: { IdTinh: _Tinh },
            success: function (json) {
                console.log(json);
                $('#AcceptDistrict').html('');
                for (let i = 0; i < json.dist.length; i++) {
                    var emlHTML = '<option value="' + json.dist[i].districtID + '">' + json.dist[i].districtName + '</option>';
                    $("#AcceptDistrict").append(emlHTML);
                }
                //Clear combobox XA
                $('#AcceptWard').html('');
                for (let j = 0; j < json.ward.length; j++) {
                    $("#AcceptWard").append('<option value="' + json.ward[j].wardId + '">' + json.ward[j].wardName + '</option>');
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    });
    $("#AcceptDistrict").on("change", function () {
        var _Huyen = $('#AcceptDistrict').val();
        $.ajax({
            type: "POST",
            url: _urlApi + "KhachHang/GetXa",
            data: { IdHuyen: _Huyen },
            success: function (json) {
                // Load Xã
                $('#AcceptWard').html('');
                for (let j = 0; j < json.length; j++) {
                    $("#AcceptWard").append('<option value="' + json[j].wardId + '">' + json[j].wardName + '</option>');
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    });

    $("#PickupProvince").on("change", function () {
        var _Tinh = $('#PickupProvince').val();
        $.ajax({
            type: "POST",
            url: _urlApi + "KhachHang/GetHuyen",
            data: { IdTinh: _Tinh },
            success: function (json) {
                console.log(json);
                $('#PickupDistrict').html('');
                for (let i = 0; i < json.dist.length; i++) {
                    var emlHTML = '<option value="' + json.dist[i].districtID + '">' + json.dist[i].districtName + '</option>';
                    $("#PickupDistrict").append(emlHTML);
                }
                //Clear combobox XA
                $('#PickupWard').html('');
                for (let j = 0; j < json.ward.length; j++) {
                    $("#PickupWard").append('<option value="' + json.ward[j].wardId + '">' + json.ward[j].wardName + '</option>');
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    });
    $("#PickupDistrict").on("change", function () {
        var _Huyen = $('#PickupDistrict').val();
        $.ajax({
            type: "POST",
            url: _urlApi + "KhachHang/GetXa",
            data: { IdHuyen: _Huyen },
            success: function (json) {
                // Load Xã
                $('#PickupWard').html('');
                for (let j = 0; j < json.length; j++) {
                    $("#PickupWard").append('<option value="' + json[j].wardId + '">' + json[j].wardName + '</option>');
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    });

    $("#IsPickup").on("change", function () {
        if (this.checked) {
            $('.panelPickup').show();
        }
        else {
            $('.panelPickup').hide();
        }
    });
    $('#DIM_W,#DIM_L,#DIM_H').on("focusout", function () {
        calTLTT();
    });

    $("#btnSave").on("click", function () {
       
    });
    $("#btnPrintReceipt").on("click", function () {
        alert("In phiếu thu");
    });
    $("#btnSaveAndSend").on("click", function () {
        alert("Lưu và nạp bên thứ 3");
    });
    $("#btnPrint").on("click", function () {
        alert("In tem dán");
    });

    function calTLTT() {
        var _dimW = $('#DIM_W').val();
        var _dimL = $('#DIM_L').val();
        var _dimH = $('#DIM_H').val();
        if (_dimW > 0 && _dimL > 0 && _dimH) {
            var TLTT = _dimW * _dimL * _dimH;
            $('#DIM').val(TLTT/5000);
        }
        else {
            $('#DIM').val(0);
        }
    };
    function showToast(title, content, type) {
        
    };

}));
