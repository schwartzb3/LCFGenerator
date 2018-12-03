module.exports = ['$http', function ($http) {

    return {
        getLoans: function () {
            return $http.get("localhost:17212/loan/getAllLoans");
        },

        createLoans: function (data) {
            return $http.put("localhost:17212/loan/createLoan", data);
        },

        getPaymentSchedule: function (data) {
            return $http.post("localhost:17212/loan/makePaymentSchedule", data);
        },

        getBalanceSchedule: function (data) {
            return $http.post("localhost:17212/loan/getRemainingBalance", data);
        },

        getInterestSchedule: function (data) {
            return $http.post("localhost:17212/loan/getInterestPayments", data)
        }
    };
}];