
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
		
		showLoading: function() {
			$('div#ajax-load').show();
		},
		
		hideLoading: function() {
			$('div#ajax-load').hide();
		}
	}
}();