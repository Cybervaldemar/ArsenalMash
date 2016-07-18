$(document).ready(function () {
    alert('HELO BLYAT');
    //при нажатию на любую кнопку, имеющую класс .btn
    $("#launch-modal").click(function () {
        //открыть модальное окно с id="myModal"
        $("#myModal").modal('show');
    });
});

