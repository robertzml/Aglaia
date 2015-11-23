
var ammeter = function () {

    var apiserver = "http://localhost:61070/";

    var loadAmmeter = function (id) {
        $.getJSON(apiserver + "api/ammeter/get/", { id: id }, function (response) {

            var source = $("#header-template").html();
            var template = Handlebars.compile(source);

            $('#page-header').html(template(response));
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
                        url: apiserver + "api/ammeter/GetEnergy",
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
        init: function () {
            var id = localStorage['ammeterParam'];
            loadAmmeter(id);
            initChart();
            initDatePicker();
        }
    }
}();