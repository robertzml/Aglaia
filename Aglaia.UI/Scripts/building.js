
var building = function() {
	
    var id;
    var building;
    var viewModel;

	function load(id) {
		
		var buildingSource = new kendo.data.DataSource({
			transport: {
				read: {
					url: "/api/building/get",
					type: "get",
					dataType: "json",
					data: { id: id }
				}
			},
			schema: {
				data: function (data) {
					return [data];
				}
			}
		});
	
		buildingSource.fetch(function () {
		    var buildings = buildingSource.data();
		    this.building = buildings[0];
            this.viewModel = kendo.observable(this.building);
            kendo.bind($("#building-view"), this.viewModel);
            this.viewModel.set("name", "Jane Doe");
		});
	}
	
	return {
        //main function to initiate the module
        init: function (id) {
			this.id = id;
			load(this.id);
        }
	}
}();