(function (ko, app) {
    'use stict';
    var services = app.namespace('app.services');
    var viewModels = app.namespace('app.viewModels');
    viewModels.BetAnalysis = (function () {
        var BetAnalysisViewModel = function () {
            this.customerBets = ko.observableArray();
            this.suspiciousBetAmount = 1000;
            this.load();
        };
        BetAnalysisViewModel.prototype = (function () {
            function extractCustomerBets(bets, betType) {
                var self = this;
                var betsPerCustomer = _.groupBy(bets, function (item) {
                    return item.customerId();
                });
                for (var customerIdProperty in betsPerCustomer) {
                    if (betsPerCustomer.hasOwnProperty(customerIdProperty)) {
                        var customerId = _.parseInt(customerIdProperty);
                        var existingCustomerBets = _.find(self.customerBets(), function (customerBets) {
                            return customerBets.customerId() === customerId;
                        });
                        if (!existingCustomerBets) {
                            existingCustomerBets = new viewModels.CustomerBets(customerId);
                            self.customerBets.push(existingCustomerBets);
                        }
                        [].push.apply(existingCustomerBets[betType](), betsPerCustomer[customerIdProperty]);
                    }
                }
            }
            function load() {
                var self = this;
                services.betAnalysis.getBets()
                    .done(function (model) {
                        var unsettledBets = _.map(model, function (bet) {
                            return new viewModels.Bet(bet);
                        });
                        extractCustomerBets.call(self, unsettledBets, "unsettledBets");
                    });
                services.betAnalysis.getResultedBets()
                    .done(function (model) {
                        var settledBets = _.map(model, function (resultedBet) {
                            return new viewModels.Bet(resultedBet.bet);
                        });
                        extractCustomerBets.call(self, settledBets, "settledBets");
                    });
            }
            return {
                load: load
            }
        })();
        return BetAnalysisViewModel;
    })();
})(ko, app);