window.onload = ()=>{

};

function Search() {

    var datas = { data: 'pasha' };

    $.post({
        url: "Quest/Filter",
        contentType: "application/json",
        data: JSON.stringify(datas),
        success: function (result) {
            console.log(result);
        },
        error: function () {
            console.log("Error while calling the server!");
        }
    });
}