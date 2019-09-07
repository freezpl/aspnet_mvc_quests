window.onload = ()=>{  
    $(document).on('click', '#res ul li', function (e) {
        console.log(e.target.id);
    });
};

function Search(e) {
    if (e.target.value.length > 0) {
        $.ajax({
            url: "Quest/Filter",
            method: "POST",
            contentType: "application/json; charset=utf-8",
            //dataType: "json",
            data: JSON.stringify(e.target.value),
            success: function (result) {
                $('#res').html(result);
            },
            error: function () {
                console.log("Error while calling the server!");
            }
        });
    } else {
        $('#res').empty();
    }
    
}