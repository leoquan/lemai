$(function (){
  $("#date").mask("99/99/9999");
  $("#phone").mask("(999) 999-9999");
  $("#tin").mask("99-9999999");
  $("#ssn").mask("999-99-9999");
  $("#eyescript").mask("~9.99 ~9.99 999");
  $("#ccn").mask("9999 9999 9999 9999");

  $('#select2-1, #select2-2, #select2-4').select2({
    theme: "bootstrap"
  });

  $('#select2-3').select2({
    theme: "bootstrap",
    placeholder: "Your Favorite Football Team",
    allowClear: true
  });

  $('input[name="daterange"]').daterangepicker({
    opens: 'left',
    ranges: {
      'Hôm nay': [moment(), moment()],
      'Hôm qua': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
      '7 Ngày gần nhất': [moment().subtract(6, 'days'), moment()],
      '30 Ngày gần nhất': [moment().subtract(29, 'days'), moment()],
      'Tháng này': [moment().startOf('month'), moment().endOf('month')],
      'Tháng trước': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
    }
  });

})
