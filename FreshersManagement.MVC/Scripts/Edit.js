$(document).ready(function () {
    $(".btnEdit").click(function () {
        var id = $("#editForm").serialize();
        $.ajax({
            type: "POST",
            url: "/Trainee/Trainees/Edit",
            data: id,
            success: function () {
                $("#myModal").modal("hide");
                window.location.href = "/Trainee/Trainees/DisplayTrainee";
            },
            error: function () {
                alert("There was an error. Try again please!");
            }
        })
    });
});

function EditTrainee(Id) {
    var url = "/Trainee/Trainees/Edit?Id=" + Id;
    $("#btnUpdate").load(url, function () {
        $("#myModal").modal("show");
    });
}

