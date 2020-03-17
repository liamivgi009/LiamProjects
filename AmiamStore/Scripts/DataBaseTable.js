
$("#submit").on('click', function (e) {
    e.preventDefault();
    var data = $("#attendees tr.data").map(function (index, elem) {
        var ret = [];
        $('.inputValue', this).each(function () {
            var d = $(this).val() || $(this).text();
            ret.push(d);
            console.log(d);
            if (d == "N/A") {
                console.log(true);
            }
        });
        return ret;
    });
    console.log(data);
    console.log(data[0]);
});