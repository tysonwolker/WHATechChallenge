$(document).ready(function () {
    var viewModels = app.namespace('app.viewModels');
    ko.applyBindings(new viewModels.BetAnalysis(), document.getElementById('bet-analysis'));
});