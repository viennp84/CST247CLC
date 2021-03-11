$(function () {
    console.log("Page is ready");

    $(document).bind("contextmenu", function (e) {
        e.preventDefault();
    });

    $(document).on("mousedown", ".game-button", function (event) {
        switch (event.which) {
            case 1:
                event.preventDefault();
                var buttonNumber = $(this).val();
                console.log("Button number " + buttonNumber + " was left clicked");
                doButtonUpdate(buttonNumber, "/minesweeper/ShowOneButton");
                break;
            case 2:
                alert('Middle mouse button is pressed');
                break;
            case 3:
                event.preventDefault();
                var buttonNumber = $(this).val();
                console.log("Button number " + buttonNumber + " was right clicked");
                doButtonUpdate(buttonNumber, "/minesweeper/RightClickShowOneButton");
                break;
            default:
                alert('Nothing');
        }
    });

});

function doButtonUpdate(buttonNumber, urlString) {
    $.ajax({
        method: "POST",
        url: urlString,
        data: {
            "buttonNumber": buttonNumber
        },
        success: function (data) {
            console.log(data);
            $("#" + buttonNumber).html(data.part1);
            $("#messageArea").html(data.part2);
        }
    });
};