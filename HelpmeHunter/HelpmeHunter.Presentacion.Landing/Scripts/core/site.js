'use strict';

var Site = window.Site;
$(document).ready(() => {
    Site.run();
});


$.validator.addMethod('digitosTelefono', (v, e) =>[0, 7].indexOf(v.trim().length) > -1, 'El teléfono tiene que ser de 7 dígitos');
$.validator.addMethod('digitosCelular', (v, e) =>[0, 9].indexOf(v.trim().length) > -1, 'El celular tiene que ser de 9 dígitos');
$.validator.addMethod('empiezaCon9', (v, e) => /^(9)/.test(v.trim()), 'El celular debe empezar 9')



$(document).on('keydown', '.input-number', function (e) {
    // Allow: backspace, delete, tab, escape, enter
    if ($.inArray(e.keyCode, [46, 8, 9, 27, 13]) !== -1 ||
        // Allow: Ctrl+A
        (e.keyCode == 65 && e.ctrlKey === true) ||
        // Allow: home, end, left, right
        (e.keyCode >= 35 && e.keyCode <= 39)) {
        // let it happen, don't do anything
        return true;
    }

    // Allow copy, cut and don't allow paste
    var ctrlDown = e.ctrlKey || e.metaKey; // Mac support
    if (ctrlDown && e.altKey) return true;
    else if (ctrlDown && e.keyCode == 67) return true; // c
    else if (ctrlDown && e.keyCode == 86) return false; // v
    else if (ctrlDown && e.keyCode == 88) return true; // x

    // Ensure that it is a number and stop the keypress
    if ((e.shiftKey || e.altKey || e.ctrlKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
        e.preventDefault();
    }
});

$(document).on('keydown', '.input-decimal', function (e) {
    // Allow: backspace, delete, tab, escape, enter, dash(2)
    if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 109, 173]) !== -1 ||
        // Allow: Ctrl+A
        (e.keyCode == 65 && e.ctrlKey === true) ||
        // Allow: home, end, left, right
        (e.keyCode >= 35 && e.keyCode <= 39)) {
        // let it happen, don't do anything
        return true;
    }

    // Allow: '.' (just once)
    if (e.keyCode == 190 || e.keyCode == 110) {
        if ($(this).val().indexOf('.') == -1) {
            return true;
        }
    }

    // Allow copy, cut and don't allow paste
    var ctrlDown = e.ctrlKey || e.metaKey; // Mac support
    if (ctrlDown && e.altKey) return true;
    else if (ctrlDown && e.keyCode == 67) return true; // c
    else if (ctrlDown && e.keyCode == 86) return false; // v
    else if (ctrlDown && e.keyCode == 88) return true; // x

    // Ensure that it is a number and stop the keypress
    if ((e.shiftKey || e.altKey || e.ctrlKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
        e.preventDefault();
    }
});

$(document).on('keydown', '.input-date', () => false);

$(document).on('keydown', '.input-hour', () => false);


function parseForm(selector) {
    $.validator.unobtrusive.parse(selector || 'form');
    //$('[name$="Celular"]').rules('add', {
    //    empiezaCon9: true,
    //    digitosCelular: true
    //});
    //$('[name$="Telefono"]').rules('add', {
    //    digitosTelefono: true
    //});
}
