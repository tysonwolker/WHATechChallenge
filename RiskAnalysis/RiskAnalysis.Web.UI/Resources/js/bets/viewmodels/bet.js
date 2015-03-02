(function (ko, app) {
    var viewModels = app.namespace('app.viewModels');
    viewModels.Bet = (function () {
        var BetViewModel = function (model) {
            this.customerId = ko.observable();
            this.eventId = ko.observable();
            this.participantId = ko.observable();
            this.stake = ko.observable();
            this.win = ko.observable();

            this.bindModel(model);
        };
        BetViewModel.prototype = (function () {
            function bindModel(model) {
                if (model) {
                    this.customerId(model.customer.customerId);
                    this.eventId = ko.observable(model.event.eventId);
                    this.participantId = ko.observable(model.participant.participantId);
                    this.stake = ko.observable(model.stake);
                    this.win = ko.observable(model.win);
                }
            }
            return {
                bindModel: bindModel
            }
        })();
        return BetViewModel;
    })();
})(ko, app);