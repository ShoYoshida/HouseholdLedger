$(function () {

    var now = new Date();
    var y = now.getFullYear();
    var m = now.getMonth() + 1;
    if (m < 10) { m = "0" + m; }
    var d = now.getDate();
    if (d < 10) { d = "0" + d; }

    var today = y + "/" + m + "/" + d;

    $("#TxtDate").datepicker({
        changeMonth: true,
        changeYear: true,
        dateFormat: 'yy/mm/dd',
        yearRange: '1970:2100'
    }).addClass("grid-datepicker")
    .val(today)
    ;

    $("#TxtDate").change(function () {
        var date = $("#TxtDate").val();
        console.log("日付変更：" + date);
        //リロード
        $('#grid').trigger("reloadGrid"); 
    });


    //Grid
    $("#grid").jqGrid({
        editurl: "/Service/ExpenseHandler.ashx",
        datatype: function (postData) {
            var date = $("#TxtDate").val();
            console.log("検索条件：" + date);
            //ajaxメソッドによるPOST通信の結果をjqGridに設定する
            $.ajax({
                type: "POST",
                url: "/Service/ExpenseHandler.ashx",
                data: "date=" + date,
                success: function (responseData) {
                    //JSON形式の文字列をJavascriptオブジェクトに変換する
                    var json_res = $.parseJSON(responseData);
                    console.log("response:" + responseData);
                    $("#grid")[0].addJSONData(json_res);
                }
            });
        },
        width: 600,
        height: 400,
        rownumbers: true,
        shrinkToFit: false,
        hidegrid: false,
        pager: "#pager",
        pgbuttons: false,
        pginput: false,
        viewrecords: true,
        sortname: 'id',
        sortorder: 'ASC',
        colNames: ['ID', 'ITEM', 'TYPE', 'AMOUNT', 'PAYEE', 'WHO', 'DELFLG', 'DATE'],
        colModel: [
                    { 'name': 'id', 'index': 'id', 'width': 30, 'editable': false, 'hidden': false },
                    { 'name': 'item', 'index': 'item', 'width': 80, 'editoptions': { maxlength: 100 }, 'editable': true },
                    { 'name': 'type', 'width': 80, 'editable': true, 'edittype': "select", 'editoptions': { value: getType() }, 'title': true },
                    {
                        "name": "amount",
                        "index": "amount",
                        "width": 76,
                        "sorttype": "int",
                        "editable": true,
                        "align": "right",
                        'editoptions': { maxlength: 18 },
                        "editrules": { required: false,
                            edithidden: false,
                            integer: true
                        },
                        "title": true
                    },
                    { 'name': 'payee', 'index': 'payee', 'width': 120, 'editoptions': { maxlength: 100 }, 'editable': true },
                    { 'name': 'who', 'index': 'who', 'width': 80, 'editoptions': { maxlength: 20 }, 'editable': true },
                    { 'name': 'delflg', 'index': 'delflg', 'width': 30, 'editable': false, 'hidden': false },
                    { 'name': 'date', 'index': 'date', 'width': 76, 'editable': true, 'hidden': false },
        ],
        serializeRowData: function (data) {
            $.each(data, function (k, v) {
                console.log(k + ":" + v);
            });

            return data;
        },
        caption: 'Expense'
    });
    $('#grid').jqGrid('navGrid', '#pager', { edit: false, add: false, del: true, search: false });
    $('#grid').jqGrid('inlineNav', '#pager', {
        edit: true,
        editicon: "ui-icon-pencil",
        add: true,
        addicon: "ui-icon-plus",
        save: true,
        saveicon: "ui-icon-disk",
        cancel: true,
        cancelicon: "ui-icon-cancel",
        editParams: { oneditfunc: onEdit },
        addParams: {
            "rowID": 0, //初期値
            "addRowParams": {
                oneditfunc: onEdit,
                successfunc: function (response) {
                    //リロード
                    $('#grid').trigger("reloadGrid");
                    return true;
                }
            }
        }
    }
    );




});

//Function
function getType() {

    var type = "0:食費"
            + ";1:交際費"
            + ";2:日用品"
            + ";3:備品家具"
            + ";4:家賃"
            + ";5:電気代"
            + ";6:ガス代"
            + ";7:水道代"
            + ";8:電話代"
            + ";9:携帯代"
            + ";10:交通費"
            + ";11:教育費"
            + ";12:保険料"
            + ";13:衣類"
            + ";14:医療費"
            + ";15:その他"

    return type;
}

function onEdit(id) {
    console.log(id);
    $("#" + id + "_date").val($("#TxtDate").val());

}
