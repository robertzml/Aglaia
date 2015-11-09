
var aglaia = function() {
	
	var handleInitTree = function ($dom) {

        $dom.jstree({
            "core" : {
                "themes" : {
                    "responsive": false
                }            
            },
            "types" : {
                "default" : {
                    "icon" : "fa fa-folder icon-state-warning icon-lg"
                },
                "file" : {
                    "icon" : "fa fa-file icon-state-warning icon-lg"
                }
            },
            "plugins": ["types"]
        });
    }
	
	return {
		
		leftNavActive: function($dom) {
			handleLeftNavActive($dom);
		},
		
		showMessage: function(message) {
			handleTostarMessage(message);
		},
		
		initTree: function($dom) {
			handleInitTree($dom);
		},
	
		initDatePicker: function($dom, today) {
			handleInitDatePicker($dom, today);
		},
		
		initSelect2: function($dom) {
			handleInitSelect2($dom);
		},
		
		showLoading: function() {
			$('div#ajax-load').show();
		},
		
		hideLoading: function() {
			$('div#ajax-load').hide();
		}
	}
}();