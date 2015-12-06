
var ammeter = function () {

    var renderHtml = function ($template, $html, data) {
        var source = $template.html();
        var template = Handlebars.compile(source);

        $html.html(template(data));
    };

    var loadAmmeter = function (id) {
        $.getJSON(aglaia.apiserver + "api/ammeter/get/", { id: id }, function (response) {

            renderHtml($("#header-template"), $('#header-template-html'), response);
            renderHtml($("#base-template"), $('#base-template-html'), response);
        });
    };

    var loadCalendarEnergy = function () {
        var start = $('#datefrom').val();
        var end = $('#dateto').val();
        
        $.getJSON(aglaia.apiserver + "api/energy/GetCalendarEnergy/", { start: start, end: end }, function (response) {

            renderHtml($("#calendar-template"), $('#calendar-template-html'), response);

            aglaia.initCalendarTable($('#calendar-table'), 3);
        });
    };

    var loadMaintainEnergy = function () {
        var start = $('#datefrom2').val();
        var end = $('#dateto2').val();

        $.getJSON(aglaia.apiserver + "api/energy/GetMaintainEnergy/", { start: start, end: end }, function (response) {

            renderHtml($("#maintain-template"), $('#maintain-template-html'), response);

            aglaia.initCalendarTable($('#maintain-table'), 6);
        });
    };

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
                        url: aglaia.apiserver + "api/energy/get",
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
    };


    var initBaseTab = function () {
        $("#chart-datepicker").kendoDatePicker({
            change: function () {
                var value = this.val();

            }
        });
        initChart();
    };

    var initCalendarTab = function () {
        aglaia.initMonthPicker($('#calendar-range-picker'));
        loadCalendarEnergy();

        $('a#calendar-refresh').click(function () {
            loadCalendarEnergy();
        });
    };

    var initMaintainTab = function () {
        aglaia.initDatePicker($('#maintain-range-picker'));
        loadMaintainEnergy();

        $('a#maintain-refresh').click(function () {
            loadMaintainEnergy();
        });
    };

    return {
        init: function () {
            var id = localStorage['ammeterParam'];
            loadAmmeter(id);
          
            initBaseTab();
            initCalendarTab();
            initMaintainTab();
        },

        svgOnLoad: function (loadEvent) {

            var result = parseFloat(145775).toFixed(2).toString();
            var h0 = "";
            for (var i = 0; i < (10 - result.length) ; i++) {
                h0 += "0";
            }
            if (result == 0) {
                loadEvent.target.ownerDocument.getElementById("Energy").firstChild.data = "0000000.00";
                loadEvent.target.ownerDocument.getElementById("Power").firstChild.data = "0000000.00";
            }
            else {
                loadEvent.target.ownerDocument.getElementById("Energy").firstChild.data = h0 + result;
                loadEvent.target.ownerDocument.getElementById("Power").firstChild.data = h0 + result;
            }
        }
    }
}();