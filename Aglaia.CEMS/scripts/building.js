
var building = function() {
	
    var id;
    var viewModel = new kendo.data.ObservableObject;

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

		var rooms = new kendo.data.DataSource({
		    transport: {
		        read: {
		            url: "/api/ammeter/GetByBuilding",
		            type: "get",
		            dataType: "json",
		            data: { buildingId: id }
		        }
		    }
		});
	
		buildingSource.fetch(function () {
		    var buildings = buildingSource.data();
		
		    viewModel.set("building", buildings[0]);
		    viewModel.set("rooms", rooms);

            kendo.bind($("#building-view"), viewModel);
		});
	}

	
	
	return {
        //main function to initiate the module
	    init: function (id) {

            this.id = parseInt(id);
            load(this.id);

        }
	}
}();