(function () {
    'use strict';
    var services = app.namespace('app.services');
    services.betAnalysis = (function () {
        function getBets() {
            return $.ajax({
                url: 'http://localhost:55850/api/bet',
                type: "get"
            });
        }
        function getResultedBets() {
            return $.ajax({
                url: 'http://localhost:55850/api/resultedbet',
                type: "get"
            });
        }
        return {
            getBets: getBets,
            getResultedBets: getResultedBets
        };
    })();
})();