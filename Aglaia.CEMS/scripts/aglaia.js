
var aglaia = function() {
	
    var handleInitTree = function ($dom) {

        $dom.jstree({
            "core": {
                "themes": {
                    "responsive": false
                }
            },
            "types": {
                "default": {
                    "icon": "fa fa-folder icon-state-warning icon-lg"
                },
                "file": {
                    "icon": "fa fa-file icon-state-warning icon-lg"
                }
            },
            "plugins": ["types"]
        });
    };

    var handleInitDatePicker = function ($dom, today) {
        if (today == true) {
            $dom.datepicker({
                format: "yyyy-mm-dd",
                weekStart: 7,
                language: "zh-CN",
                autoclose: true,
                todayHighlight: true
            });
        } else {
            $dom.datepicker({
                format: "yyyy-mm-dd",
                weekStart: 7,
                language: "zh-CN",
                autoclose: true
            });
        }
    };

    var handleInitMonthPicker = function ($dom) {
        $dom.datepicker({
            format: "yyyy-mm",
            defaultViewDate: 0,
            minViewMode: 1,
            language: "zh-CN",
            autoclose: true
        });
    };
   
    var handleInitCalendarDatatable = function ($dom, pageLength) {
        var oTable = $dom.DataTable({
           
            // set the initial value
            "pageLength": pageLength,

            "ordering": false,

            "language": {
                "lengthMenu": "  _MENU_ 记录",
                "sLengthMenu": "每页 _MENU_ 条记录",
                "sInfo": "显示 _START_ 至 _END_ 共有 _TOTAL_ 条记录",
                "sInfoEmpty": "记录为空",
                "sInfoFiltered": " - 从 _MAX_ 条记录中",
                "sZeroRecords": "结果为空",
                "sSearch": "搜索:",
                "paginate": {
                    "previous": "Prev",
                    "next": "Next",
                    "last": "Last",
                    "first": "First"
                }
            },

            "pagingType": "bootstrap_full_number",

            "dom": "<t><'row'<'col-md-5 col-sm-12'i><'col-md-7 col-sm-12' p>>", // horizobtal scrollable datatable
        });

        return oTable;
    }
	
	return {
		
		leftNavActive: function($dom) {
			handleLeftNavActive($dom);
		},
		
		showMessage: function(message) {
			
		},
		
		initTree: function($dom) {
			handleInitTree($dom);
		},
	
		initDatePicker: function($dom, today) {
			handleInitDatePicker($dom, today);
		},

		initMonthPicker: function($dom) {
		    handleInitMonthPicker($dom);
		},

		initCalendarTable: function ($dom, pageLength) {
		    handleInitCalendarDatatable($dom, pageLength);
		},
		
		showLoading: function() {
			$('div#ajax-load').show();
		},
		
		hideLoading: function() {
			$('div#ajax-load').hide();
		}
	}
}();