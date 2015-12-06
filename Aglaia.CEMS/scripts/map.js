
var map = function () {

    //var apiserver = "http://localhost:61070/";

    var initMap = function () {

        $.getJSON(aglaia.apiserver + "api/map/getpoints", function (response) {

            var extent = [0, 0, 1280, 900];
            var projection = new ol.proj.Projection({
                code: 'xkcd-image',
                units: 'pixels',
                extent: extent
            });

            var vectorSource = new ol.source.Vector({
                //create empty vector
            });

            $.each(response, function (i, item) {
                var iconFeature = new ol.Feature({
                    geometry: new ol.geom.Point([item.x, item.y]),
                    name: item.content,
                    population: 4000,
                    rainfall: 500
                });
                vectorSource.addFeature(iconFeature);
            });

            //create the style
            var iconStyle = new ol.style.Style({
                image: new ol.style.Icon(/** @type {olx.style.IconOptions} */({
                    anchor: [0.5, 46],
                    anchorXUnits: 'fraction',
                    anchorYUnits: 'pixels',
                    opacity: 0.85,
                    src: '/images/icon1.png'
                }))
            });

            var vectorLayer = new ol.layer.Vector({
                source: vectorSource,
                style: iconStyle
            });


            var map = new ol.Map({
                target: 'map',
                layers: [
                    new ol.layer.Image({
                        source: new ol.source.ImageStatic({
                            url: '/images/map.jpg',
                            projection: projection,
                            imageExtent: extent
                        })
                    }),
                    vectorLayer
                ],
                view: new ol.View({
                    projection: projection,
                    center: ol.extent.getCenter(extent),
                    zoom: 3,
                    minZoom: 2,
                    maxZoom: 5,
                    extent: [400, 270, 860, 530]
                })
            });



            var element = document.getElementById('popup');

            var popup = new ol.Overlay({
                element: element,
                positioning: 'bottom-center',
                stopEvent: false
            });
            map.addOverlay(popup);

            // display popup on click
            map.on('click', function (evt) {
                var feature = map.forEachFeatureAtPixel(evt.pixel,
                    function (feature, layer) {
                        return feature;
                    });
                if (feature) {
                    popup.setPosition(evt.coordinate);
                    $(element).popover({
                        'placement': 'top',
                        'html': true,
                        'content': feature.get('name')
                    });

                    $(element).popover('show');
                } else {
                    $(element).popover('destroy');
                }
            });
        });
    };

    return {
        init: function () {
            initMap();
        }
    }
}();