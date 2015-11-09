
var index = function() {
	
	var loadBuildingTree = function() {
		$("#tree_2").jstree({
            "core" : {
                "themes" : {
                    "responsive": false
                }, 
                // so that create works
                "check_callback" : true,
                'data' : {
                    'url' : function (node) {
                      return '/api/building/';
                    },
                    'data' : function (node) {
                      return { 'id' : node.id, 'level' : node.text };
                    }
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
            "state" : { "key" : "demo3" },
            "plugins" : [ "types" ]
        });
		
		 // handle link clicks in tree nodes(support target="_blank" as well)
		$('#tree_2').on('select_node.jstree', function (e, data) {
			var id = $('#' + data.selected).attr('id');
			
			if (id != null) {
				if (parseInt(id) < 4) {
					$('#page-content-body').load('/Home/Building', { id: id });
				} else {
					$('#page-content-body').load('/Home/Room', { id: id });
				}				
			}
		});
	}
	
	
	return {
        //main function to initiate the module
        init: function () {
			loadBuildingTree();

        }
	}
}();