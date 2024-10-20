$(function () {
    var connection = new signalR.HubConnectionBuilder().withUrl("/chatHubnew").build();

    connection.on("ReceiveMessage", function (message) {
        $('#MessageList').append('<li><strong><i class="fas fa-long-arrow-alt-right"></i>接收： ' + message + '</strong></li>');
    });
    connection.start().then(function () {
        console.log("开启");
    }).catch(function (err) {
        return console.error(err.toString());
    });

    $('#SendMessageButton').click(function (e) {
        e.preventDefault();

        var targetUserName = $('#TargetUser').val();
        var message = $('#Message').val();
        $('#Message').val('');

        connection.invoke("SendMessage", targetUserName, message)
            .then(function () {
                $('#MessageList')
                    .append('<li><i class="fas fa-long-arrow-alt-left"></i> 发送：' + abp.currentUser.userName + ': ' + message + '</li>');
            })
            .catch(function (err) {
                return console.error(err.toString());
            });
    });
});
