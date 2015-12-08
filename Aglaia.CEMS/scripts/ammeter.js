
var ammeter = function () {

    var id;
    var loop = 1;

    var renderHtml = function ($template, $html, data) {
        var source = $template.html();
        var template = Handlebars.compile(source);

        $html.html(template(data));
    };

    var loopLoad = function (ammeter, loopNumber) {
        var data = {
            ammeter: ammeter,
            loop: ammeter.loops[loopNumber - 1]
        };

        renderHtml($("#base-template"), $('#base-template-html'), data);
        loadCalendarEnergy();
        loadMaintainEnergy();
    };

    var loadAmmeter = function (id) {
        $.getJSON(aglaia.apiserver + "api/ammeter/get/", { id: id }, function (response) {

            renderHtml($("#header-template"), $('#header-template-html'), response);
            loopLoad(response, 1);

            $('.loop-toggle > label').click(function () {
               
                var loopNumber = $(this).children('input').val();
                loop = loopNumber;
                loopLoad(response, loopNumber);
            });
        });
    };

    var loadCalendarEnergy = function () {
        var start = $('#datefrom').val();
        var end = $('#dateto').val();
        
        $.getJSON(aglaia.apiserver + "api/energy/GetCalendarEnergy/", { ammeterId: id, loop: loop, start: start, end: end }, function (response) {

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
        aglaia.initDatePicker($('#chart-datepicker'), true)
            .on('changeDate', function (e) {
                //alert(e.date);
            });

        initChart();
    };

    var initCalendarTab = function () {
        aglaia.initMonthPicker($('#calendar-range-picker'));
        $('a#calendar-refresh').click(function () {
            loadCalendarEnergy();
        });
    };

    var initMaintainTab = function () {
        aglaia.initDatePicker($('#maintain-range-picker'));

        $('a#maintain-refresh').click(function () {
            loadMaintainEnergy();
        });
    };

    return {
        init: function () {
            id = localStorage['ammeterParam'];

            Handlebars.registerHelper("formatDate", function (time) {
                return moment(time).format('YYYY-MM-DD HH:mm:ss');
            });

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