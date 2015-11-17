
var room = function() {
	
    var id;
    var viewModel = new kendo.data.ObservableObject;

    var load = function (id) {

        var roomSource = new kendo.data.DataSource({
            transport: {
                read: {
                    url: "/api/ammeter/get",
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

        roomSource.fetch(function () {
            var rooms = roomSource.data();

            viewModel.set("room", rooms[0]);

            kendo.bind($("#room-view"), viewModel);
        });
    }

    var initChart = function () {
        $("#energy-chart").kendoChart({
            seriesDefaults: {
                type: "column"
            },
            legend: {
                visible: false
            },
            series: [{
                field: "value",
                name: "”√ƒ‹"
            }],
            categoryAxis: {
                field: "time",
                type: "date",
                baseUnit: "hours",
                labels: {
                    dateFormats: {
                        hours: "HH mm"
                    },
                    step: 4
                }
            },
            dataSource: {
                transport: {
                    read: {
                        url: "/api/ammeter/GetEnergy",
                        data: { date: '2015-11-12' },
                        dataType: "json"
                    }
                }
            }
        });
    }

	return {
	    init: function (id) {
	        this.id = parseInt(id);
	        load(id);
	        initChart();
	    }
	}
}();