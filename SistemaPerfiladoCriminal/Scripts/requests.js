/*$(document).ready(function () {
    $.ajax({
        dataType: "json",
        url: "api/Casos",
        success: function (res) {
            console.log(res);
            let tablaCasos = $("#tabla-casos tbody");

            res.forEach((c) => {
                tablaCasos.append(`
                <tr>
                    <td>${c.LstrNombre}</td>
                    <td><a href="/Caso/${c.LintId}">Ver</a></td>
                </tr>`);
            });
        }
    });
});*/