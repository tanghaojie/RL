(function (win) {
    win.jt = {};
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function () {
        if (xhr.readyState === XMLHttpRequest.DONE) {
            if (xhr.status === 200) {
                var responseJSON = JSON.parse(xhr.responseText);
                win.jt.token = responseJSON.result.accessToken;
            } else {
                alert('Login failed !');
            }
        }
    };
    xhr.open('POST', '/api/Auth', true);
    xhr.setRequestHeader('Content-type', 'application/json');
    xhr.send("{username:'root', password:'root', rememberClient: true}");
})(window);