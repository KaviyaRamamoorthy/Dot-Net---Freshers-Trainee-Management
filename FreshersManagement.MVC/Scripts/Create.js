$(document).ready(function () {
    $(".btnAdd").click(function () {

        var id = $(this).data("value");
        $("#teste").load("/Trainee/Trainees/Create/" + id, function () {
            $('#myModal').modal("show");
        });
    });
});