
    var customerName = localStorage.getItem("CustomerName");
    var ballance = localStorage.getItem("Ballance");
    var accountIBAN = localStorage.getItem("AccountIBAN");
    var accountNumber = localStorage.getItem("AccountNumber");
    $(document).ready(function () {
        $('#ballance').text(ballance);
        $('#customerName').text(customerName);
        $('#accountIBAN').text(accountIBAN);
        $('#accountNumber').text(accountNumber);
    });

