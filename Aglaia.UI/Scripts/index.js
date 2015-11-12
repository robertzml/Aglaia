
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
	
	function onSelect(e) {
		var dataItem = this.dataItem(e.node);
		console.log("Selected node with type = " + dataItem.type);
	}
	
	return {
        //main function to initiate the module
        init: function () {
			initPanelbar();
			loadBuildingTree();
			
        }
	}
}();