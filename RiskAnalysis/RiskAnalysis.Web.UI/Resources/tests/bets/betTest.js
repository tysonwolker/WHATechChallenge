(function () {
    var viewModels = app.namespace('app.viewModels');
    var happyPathBetModel = {
        customer: {
            customerId: 1
        },
        event: {
            eventId: 2
        },
        participant: {
            participantId: 3
        },
        stake: 50,
        win: 250
    };
    QUnit.module("Bet - Tests", {
        setup: function (assert) {
            assert.ok(viewModels, "should be defined" );
        }
    });

    QUnit.test("test bet with setup", function (assert) {
        var bet = new viewModels.Bet();
        assert.ok(bet, "testing setup and object exists");
    });

    QUnit.test("test customerId was copied to view model", function (assert) {
        var bet = new viewModels.Bet(happyPathBetModel);
        assert.ok(bet.customerId() === 1, "customer id is as expected");
    });
    
    QUnit.test("test eventId was copied to view model", function (assert) {
        var bet = new viewModels.Bet(happyPathBetModel);
        assert.ok(bet.eventId() === 2, "event id is as expected");
    });

    QUnit.test("test participantId was copied to view model", function (assert) {
        var bet = new viewModels.Bet(happyPathBetModel);
        assert.ok(bet.participantId() === 3, "participant id is as expected");
    });

    QUnit.test("test stake was copied to view model", function (assert) {
        var bet = new viewModels.Bet(happyPathBetModel);
        assert.ok(bet.stake() === 50, "stake is as expected");
    });

    QUnit.test("test win was copied to view model", function (assert) {
        var bet = new viewModels.Bet(happyPathBetModel);
        assert.ok(bet.win() === 250, "win is as expected");
    });
})();
