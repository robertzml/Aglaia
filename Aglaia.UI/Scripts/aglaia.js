
var aglaia = function() {
	
	
	return {
		
		leftNavActive: function($dom) {
			handleLeftNavActive($dom);
		},
	
		showLoading: function() {
			$('div#ajax-load').show();
		},
		
		hideLoading: function() {
			$('div#ajax-load').hide();
		}
	}
}();