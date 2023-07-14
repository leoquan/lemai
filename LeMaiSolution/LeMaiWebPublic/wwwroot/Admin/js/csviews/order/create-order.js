
$(document).ready($(function () {
    // Cấu hình Toast
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
    // Select 2
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
        var _Phone = $('#SendManPhone').val();
        var _Post = $('#PostId').val();

        $.ajax({
            type: "POST",
            url: _urlApi + "POrder/GetSender",
            data: { Phone: _Phone, Post: _Post },
            success: function (rs) {
                // Set giá
                if (rs.found == true) {
                    $('#PickupManPhone').val(rs.phone);

                    $('#SendMan').val(rs.name);
                    $('#PickupMan').val(rs.name);

                    $('#SendAddress').val(rs.address);
                    $('#PickupAddress').val(rs.address);

                    $('#CustomerId').val(rs.customerId);
                    $('#AcceptManPhone').focus();
                }
                else {
                    $('#CustomerId').val('');
                    $('#SendMan').focus();
                }
                $('#Note').val('Đơn hàng có vấn đề vui lòng liên hệ số điện thoại ' + _Phone + ' để được giải quyết, xin cảm ơn!');
                checkValid(false);
            },
            error: function (err) {
                console.log(err);
            }
        });
    });
    // Tìm người nhận
    $("#AcceptManPhone").on("focusout", function () {
        var _Phone = $('#AcceptManPhone').val();

        $.ajax({
            type: "POST",
            url: _urlApi + "POrder/GetAccept",
            data: { Phone: _Phone },
            success: function (rs) {
                // Set giá
                console.log(rs);
                if (rs.found == true) {
                    $('#AcceptMan').val(rs.name);
                    $('#AcceptAddress').val(rs.address);
                    // Tỉnh
                    $('#AcceptProvince').html('');
                    for (let i = 0; i < rs.provinceList.length; i++) {
                        var emlHTML = '<option value="' + rs.provinceList[i].key + '">' + rs.provinceList[i].name + '</option>';
                        if (rs.provinceList[i].key == rs.selectProvince) {
                            emlHTML = '<option value="' + rs.provinceList[i].key + '" selected>' + rs.provinceList[i].name + '</option>';
                        }
                        $("#AcceptProvince").append(emlHTML);
                    }
                    // Huyện
                    $('#AcceptDistrict').html('');
                    for (let i = 0; i < rs.districtList.length; i++) {
                        var emlHTML = '<option value="' + rs.districtList[i].key + '">' + rs.districtList[i].name + '</option>';
                        if (rs.districtList[i].key == rs.selectDistrict) {
                            emlHTML = '<option value="' + rs.districtList[i].key + '" selected>' + rs.districtList[i].name + '</option>';
                        }
                        $("#AcceptDistrict").append(emlHTML);
                    }
                    // Xã
                    $('#AcceptWard').html('');
                    for (let i = 0; i < rs.wardList.length; i++) {
                        var emlHTML = '<option value="' + rs.wardList[i].key + '">' + rs.wardList[i].name + '</option>';
                        if (rs.wardList[i].key == rs.selectWard) {
                            emlHTML = '<option value="' + rs.wardList[i].key + '" selected>' + rs.wardList[i].name + '</option>';
                        }
                        $("#AcceptWard").append(emlHTML);
                    }

                    $('#GoodName').focus();

                }
                else {
                    $('#AcceptMan').focus();
                }
                checkValid(false);
            },
            error: function (err) {
                console.log(err);
            }
        });
    });
    $("#FeeWeight").on("focusout", function () {
        // Viết lại cái hàm này
        var _Tinh = $('#AcceptProvince').val();
        var _Huyen = $('#AcceptDistrict').val();

        var _Weight = $('#FeeWeight').val();

        var _Post = $('#PostId').val();
        var _CustomerId = $('#CustomerId').val();
        $.ajax({
            type: "POST",
            url: _urlApi + "POrder/GetCalculator",
            data: { IdTinh: _Tinh, IdHuyen: _Huyen, Weight: _Weight, Post: _Post, CustomerId: _CustomerId },
            success: function (json) {
                // Set giá
                $('#Freight').val(json);
            },
            error: function (err) {
                console.log(err);
            }
        });
    });

    $("#BillWeigt").on("focusout", function () {
        // Viết lại cái hàm này
        var _Tinh = $('#AcceptProvince').val();
        var _Huyen = $('#AcceptDistrict').val();
        var _Weight = $('#BillWeigt').val();
        var _Post = $('#PostId').val();
        $.ajax({
            type: "POST",
            url: _urlApi + "Post/GetSuggestProvider",
            data: { IdTinh: _Tinh, IdHuyen: _Huyen, Weight: _Weight, Post: _Post },
            success: function (json) {
                // Set giáy
                $('#Provider').val(json);
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
        var resultCheck = checkValid(true);
        if (resultCheck) {
            var _SendManPhone = $('#SendManPhone').val();
            var _SendMan = $('#SendMan').val();
            var _SendAddress = $('#SendAddress').val();
            var _IsPickup = $("#IsPickup").is(":checked");
            var _PickupManPhone = $('#PickupManPhone').val();
            var _PickupMan = $('#PickupMan').val();
            var _PickupProvinceSelected = $('#PickupProvince').val();
            var _PickupDistrictSelected = $('#PickupDistrict').val();
            var _PickupWardSelected = $('#PickupWard').val();
            var _PickupAddress = $('#PickupAddress').val();
            var _AcceptManPhone = $('#AcceptManPhone').val();
            var _AcceptMan = $('#AcceptMan').val();
            var _AcceptProvinceSelected = $('#AcceptProvince').val();
            var _AcceptDistrictSelected = $('#AcceptDistrict').val();
            var _AcceptWardSelected = $('#AcceptWard').val();
            var _AcceptAddress = $('#AcceptAddress').val();
            var _GoodName = $('#GoodName').val();
            var _FeeWeight = $('#FeeWeight').val();
            _FeeWeight = _FeeWeight.replace(',', '');
            var _BillWeigt = $('#BillWeigt').val();
            _BillWeigt = _BillWeigt.replace(',', '');
            var _ProviderSelected = $('#Provider').val();
            var _DIM_L = $('#DIM_L').val();
            var _DIM_W = $('#DIM_W').val();
            var _DIM_H = $('#DIM_H').val();
            var _DIM = $('#DIM').val();
            var _Freight = $('#Freight').val();
            _Freight = _Freight.replace(/\,/g, '');
            var _COD = $('#COD').val();
            _COD = _COD.replace(/\,/g, '');
            var _PayTypeSelected = $('#PayType').val();
            var _ShipTypeSelected = $('#ShipeType').val();
            var _Note = $('#Note').val();
            var _UserId = $('#UserId').val();
            var _PostId = $('#PostId').val();
            var _SiteCode = $('#SiteCode').val();
            var _CustomerId = $('#CustomerId').val();
            var _SaveAndSend = false;

            var _AcceptProvinceName = $("#AcceptProvince option:selected").text();
            var _AcceptDistrictName = $("#AcceptDistrict option:selected").text();
            var _AcceptWardName = $("#AcceptWard option:selected").text();

            $.ajax({
                type: "POST",
                url: _urlApi + "POrder/TaoDonHang",
                contentType: "application/json",
                data: JSON.stringify({
                    SendManPhone: _SendManPhone,
                    SendMan: _SendMan,
                    SendAddress: _SendAddress,
                    IsPickup: _IsPickup,
                    PickupManPhone: _PickupManPhone,
                    PickupMan: _PickupMan,
                    PickupProvinceSelected: _PickupProvinceSelected,
                    PickupDistrictSelected: _PickupDistrictSelected,
                    PickupWardSelected: _PickupWardSelected,
                    PickupAddress: _PickupAddress,
                    AcceptManPhone: _AcceptManPhone,
                    AcceptMan: _AcceptMan,
                    AcceptProvinceSelected: _AcceptProvinceSelected,
                    AcceptDistrictSelected: _AcceptDistrictSelected,
                    AcceptWardSelected: _AcceptWardSelected,
                    AcceptProvinceName: _AcceptProvinceName,
                    AcceptDistrictName: _AcceptDistrictName,
                    AcceptWardName: _AcceptWardName,
                    AcceptAddress: _AcceptAddress,
                    GoodName: _GoodName,
                    FeeWeight: _FeeWeight,
                    BillWeigt: _BillWeigt,
                    ProviderSelected: _ProviderSelected,
                    DIM_L: _DIM_L,
                    DIM_W: _DIM_W,
                    DIM_H: _DIM_H,
                    DIM: _DIM,
                    Freight: _Freight,
                    COD: _COD,
                    PayTypeSelected: _PayTypeSelected,
                    ShipTypeSelected: _ShipTypeSelected,
                    Note: _Note,
                    UserId: _UserId,
                    PostId: _PostId,
                    SiteCode: _SiteCode,
                    CustomerId: _CustomerId,
                    SaveAndSend: _SaveAndSend
                }),
                success: function (result) {
                    if (result.code == 200) {
                        toastr["success"]("Tạo đơn hàng thành công: " + result.resultString, "Thành công");
                        $('#BillCode').val(result.resultString);
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
    $("#btnPrintReceipt").on("click", function () {
        var url = _urlApi + "POrder/PrintBill?billcode=" + $('#BillCode').val();
        window.open(url, "MsgWindow", "width=1024,height=700");
    });
    $("#btnSaveAndSend").on("click", function () {
        var resultCheck = checkValid(true);
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
            $('#DIM').val(TLTT / 5000);
        }
        else {
            $('#DIM').val(0);
        }
    };
    function showToast(title, content, type) {

    };
    function checkValid(showMessage) {
        var resultValid = true;
        var _SendManPhone = $('#SendManPhone').val();
        var _SendMan = $('#SendMan').val();
        var _SendAddress = $('#SendAddress').val();
        var _IsPickup = $("#IsPickup").is(":checked");
        var _PickupManPhone = $('#PickupManPhone').val();
        var _PickupMan = $('#PickupMan').val();
        var _PickupAddress = $('#PickupAddress').val();
        var _AcceptManPhone = $('#AcceptManPhone').val();
        var _AcceptMan = $('#AcceptMan').val();
        var _AcceptAddress = $('#AcceptAddress').val();
        var _GoodName = $('#GoodName').val();
        var _FeeWeight = $('#FeeWeight').val();
        _FeeWeight = _FeeWeight.replace(',', '');
        var _BillWeigt = $('#BillWeigt').val();
        _BillWeigt = _BillWeigt.replace(',', '');
        var _ProviderSelected = $('#Provider').val();
        var _DIM_L = $('#DIM_L').val();
        var _DIM_W = $('#DIM_W').val();
        var _DIM_H = $('#DIM_H').val();
        var _DIM = $('#DIM').val();
        var _Freight = $('#Freight').val();
        _Freight = _Freight.replace(/\,/g, '');
        var _COD = $('#COD').val();
        _COD = _COD.replace(/\,/g, '');
        // Thông tin người gửi
        if (_SendMan == '') {
            $('#SendMan').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#SendMan').removeClass('is-invalid').addClass('is-valid');
        }

        if (_SendManPhone == '' || _SendManPhone.length < 10 || _SendManPhone.length > 11) {
            $('#SendManPhone').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#SendManPhone').removeClass('is-invalid').addClass('is-valid');
        }
        if (_SendAddress == '') {
            $('#SendAddress').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#SendAddress').removeClass('is-invalid').addClass('is-valid');
        }
        if (_IsPickup) {
            if (_PickupMan == '') {
                $('#PickupMan').addClass('is-invalid').removeClass('is-valid');
                resultValid = false;
            }
            else {
                $('#PickupMan').removeClass('is-invalid').addClass('is-valid');
            }

            if (_PickupManPhone == '' || _PickupManPhone.length < 10 || _PickupManPhone.length > 11) {
                $('#PickupManPhone').addClass('is-invalid').removeClass('is-valid');
                resultValid = false;
            }
            else {
                $('#PickupManPhone').removeClass('is-invalid').addClass('is-valid');
            }
            if (_PickupAddress == '') {
                $('#PickupAddress').addClass('is-invalid').removeClass('is-valid');
                resultValid = false;
            }
            else {
                $('#PickupAddress').removeClass('is-invalid').addClass('is-valid');
            }
        }
        // Thông tin người nhận
        if (_AcceptMan == '') {
            $('#AcceptMan').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#AcceptMan').removeClass('is-invalid').addClass('is-valid');
        }

        if (_AcceptManPhone == '' || _AcceptManPhone.length < 10 || _AcceptManPhone.length > 11) {
            $('#AcceptManPhone').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#AcceptManPhone').removeClass('is-invalid').addClass('is-valid');
        }
        if (_AcceptAddress == '') {
            $('#AcceptAddress').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#AcceptAddress').removeClass('is-invalid').addClass('is-valid');
        }
        // Thông tin đơn hàng
        if (_GoodName == '') {
            $('#GoodName').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#GoodName').removeClass('is-invalid').addClass('is-valid');
        }

        if (_FeeWeight == '' || _FeeWeight == 0) {
            $('#FeeWeight').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#FeeWeight').removeClass('is-invalid').addClass('is-valid');
        }

        if (_BillWeigt == '' || _BillWeigt == 0) {
            $('#BillWeigt').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#BillWeigt').removeClass('is-invalid').addClass('is-valid');
        }

        if (_Freight == '' || _Freight == 0) {
            $('#Freight').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#Freight').removeClass('is-invalid').addClass('is-valid');
        }

        if (_COD == '') {
            $('#COD').addClass('is-invalid').removeClass('is-valid');
            resultValid = false;
        }
        else {
            $('#COD').removeClass('is-invalid').addClass('is-valid');
        }
        if (resultValid == false && showMessage == true) {
            toastr["error"]("Lỗi dữ liệu cần kiểm tra lại!");
        }
        return resultValid;
    };

}));
