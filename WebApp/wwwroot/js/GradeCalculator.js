//Calculate the grade
document.getElementById('btnsubmit').addEventListener('click', function () {
    asign = $('#As').val();
    group = $('#GP').val();
    quiz = $('#Qz').val();
    midterm = $('#MEx').val();
    final = $('#FEx').val();
    intex = $('#INTEX').val();

    total = (asign * .5) + (group * .1) + (quiz * .1) + (midterm * .1) + (final * .1) + (intex * .1)

    $('#numTotal').text(total);

    alert("Final Grade: " + total)
})