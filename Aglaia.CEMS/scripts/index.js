
var index = function() {
	
    var apiserver = "http://localhost:61070/";

	var initPanelbar = function() {
		$("#side-panelbar").kendoPanelBar();
	};
	
	var loadBuildingTree = function() {
		$('#building-tree-view').kendoTreeView({
			 dataSource: {
				transport: {
					read: {
						url: "/api/building/GetChildren/",
						dataType: "json"
					}
				},
				schema: {
					model: {
					    id: "id",
						hasChildren: "hasChildren"
					}
				}
			},
			dataTextField: "text",
			select: onSelect
		});
	};

	var loadTree1 = function () {

	    var tree1 = [];

	    $.getJSON(apiserver + "api/tree/get/1", function (response) {
	        $.each(response, function (i, item) {
	            var parent;
	            if (item.parentId == 0)
	                parent = '#';
	            else
	                parent = item.parentId;

	            var li_attr = { 'data-type': item.type, 'data-id': item.ammeterId };
                
	            tree1.push({ 'id': item.id, 'parent': parent, 'text': item.text, 'li_attr': li_attr });
	        });
	       
	       
	        $('#tree_1').jstree({
	            "core": {
                    'data': tree1
	            }
	        });
	    });

	    $('#tree_1').on('select_node.jstree', function (e, data) {
	        var id = $('#' + data.selected).attr('data-id');
	        var type = $('#' + data.selected).attr('data-type');

	        if (type == 1) {
	            //localStorage["ammeterParam"] = id;
	            //$('#page-content-body').load('/ammeterGroup.html');
	        } else if (type == 2 || type == 3) {
	            localStorage["ammeterParam"] = id;
	            $('#page-content-body').load('/ammeter.html');
	        }
	    });
	}	

	return {
        //main function to initiate the module
        init: function () {
            initPanelbar();
            loadTree1();
        }
	}
}();