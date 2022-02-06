$("#search-form").submit((e) => {
    e.preventDefault()
    let url = window.location.href.slice(23)
    let key = $("#searchinput").val()
    $.ajax({
        url: `${url}/search?key=${key}`,
        type: "get",
        dataType: "html",
        beforeSend: function () {
        },
        success: function (response) {
            $("#search-result").html(response)
        },
        error: function (error) {
        },
        complete: function () {
        }
    });
})