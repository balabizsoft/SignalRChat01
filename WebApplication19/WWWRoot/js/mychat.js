$(function () {

    $('#btnSend').prop('disabled', true);

    var cn = new signalR.HubConnectionBuilder().withUrl("/mychat").build();
    cn.on('display', (name, msg) => {
        var str = `${name} says ${msg}`;
        $('#lstMessage').append(`<li>${str}</li>`);
    });

    cn.start().then(x => {
        $('#btnSend').prop('disabled', false);
        console.log("Connected");
    });


    $('#btnSend').click(x => {
        var name = $('#txtName').val();
        var msg = $('#txtMessage').val();
        cn.invoke('sendMessage', name, msg);
    });
});