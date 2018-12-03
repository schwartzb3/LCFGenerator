module.exports = {

    template: require('../templates/loan.member.html'),

    controller: ['loanFactory',  function (loanFactory) {
        this.loans = [];

        var getLoans = function () {
            loanFactory.getLoans().then(
                function (success) {
                    this.loans = response.data;
                },
                function (error) {
                    utils.alertMessagePopup('error', error.data.message);
                }
            );
        };

        this.create = function () {
            /*      function (data) {
                       data.Id = this.makeId?
                       loanFactory.createLoan(data).then(
                        function(success) {
                            something to say you created it
                            getLoans();
                        },
                        function(error){
                            error popup
                        }
                        );
                } */
        };
    }]
};