(function (ko, app) {
    var viewModels = app.namespace('app.viewModels');
    viewModels.CustomerBets = (function () {
        var CustomerBetsViewModel = function (customerId) {
            this.customerId = ko.observable(customerId);
            this.unsettledBets = ko.observableArray();
            this.settledBets = ko.observableArray();
            this.averageBetStake = ko.pureComputed(this.averageBetStake, this);
            this.percentWin = ko.pureComputed(this.percentWin, this);
        };
        CustomerBetsViewModel.prototype = (function () {
            function averageBetStake() {
                var average = 0;
                _.forEach(this.settledBets(), function (settledBet) {
                    average += settledBet.stake();
                });
                return average ? average / this.settledBets().length : 0;
            }
            function percentWin() {
                var numberOfWins = 0;
                _.forEach(this.settledBets(), function (settledBet) {
                    if (settledBet.win !== 0) {
                        numberOfWins++;
                    }
                });
                return numberOfWins ? numberOfWins / this.settledBets().length * 100 : 0;
            }
            return {
                averageBetStake: averageBetStake,
                percentWin: percentWin
            }
        })();
        return CustomerBetsViewModel;
    })();
})(ko, app);