
var index = function() {
	
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

	var initAngular = function () {

	    
	};

	function onSelect(e) {
		var dataItem = this.dataItem(e.node);
		if (dataItem.type == 2) {
			$('#page-content-body').load('/home/building', { id: dataItem.id });
		} else if (dataItem.type == 3){
			$('#page-content-body').load('/home/room', { id: dataItem.id });
		}
		console.log("Selected node with type = " + dataItem.type);
	}
	
	

	return {
        //main function to initiate the module
        init: function () {
			initPanelbar();
			//loadBuildingTree();
			//initAngular();
        }
	}
}();