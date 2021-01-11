(function(window, undefined) {
  'use strict';
 /**********************Validation Form******************************/
	$("#btnSave").click(function (e) {
    if ($(".form-control").val() == "") {
        e.preventDefault()
        $(".error").show();
    } else {
        $(".error").hide();
    }
});
/**********************End Validation Form******************************/

/********************** DataTable  ******************************/
$(document).ready(function () {
  $('#table').DataTable(
      {
          "oLanguage": {
              "sUrl": "/DataTableSetting/dataTable.txt"
          }
      });


});


 
/**********************End DataTable  ******************************/
})(window);



 
