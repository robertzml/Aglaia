
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
                name: "用能",
                color: "#2e99fe"
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
                },
                majorGridLines: {
                    step: 24,
                    width: 3
                },
            },
            dataSource: {
                transport: {
                    read: {
                        url: "/api/ammeter/GetEnergy",
                        data: { date: '2015-11-12' },
                        dataType: "json"
                    }
                }
            },
            tooltip: {
                visible: true,
                format: "{0}",
                template: "#= kendo.toString(category, 'yyyy/MM/dd HH:mm:ss') # <br/>  实时能耗: #= value # 千瓦时"
            }
        });
    }

    var initDatePicker = function () {
        $("#chart-datepicker").kendoDatePicker();
    }

	return {
	    init: function (id) {
	        this.id = parseInt(id);
	        load(id);
	        initChart();
	        initDatePicker();
	    }
	}
}();