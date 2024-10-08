async function getData(el, url, valprop, idprop, ev, ustid, target) {
    if (ev.type == "focusout") {
        var res = await getResponse(el, url, valprop, idprop, ev, ustid, target);
        res.result ? clickEnter(el) : null;
        return res;
    } else {
        return { result: false };
    }
}

function getResponse(el, reqUrl, valProp, idProp, evn, ustid, target) {
    var deger = el.val().trim();
    return new Promise((resolve, reject) => {
        evn.preventDefault();
        if (deger.length > 0) {
            $.ajax({
                url: reqUrl,
                type: "GET",
                data: { ustId: ustid, content: deger },
                success: (res) => {
                    switch (res.length) {
                        case 0:
                            alert("Böyle Bir Kayıt Bulunamadı");
                            //check if el id = CariUnvan
                            const elementId = el.attr("id"); // id'yi burada al
                            if (elementId !== "CariUnvan" && elementId !== "CariKod" && elementId !== "VergiDairesi") {
                                el.focus();
                                el.val(null);
                                el.removeAttr("data-id");
                                resolve({ result: false, data: null });
                            }
                            else {
                                $("#Unvan").attr('value', el.val());
                            }
                           
                            break;
                        case 1:
                            el.val(res[0][valProp]);
                            el.attr("data-id", res[0][idProp]);
                            resolve({ result: true, data: res[0] });
                            break;
                        default:
                            el.val(null);
                            el.removeAttr("data-id");
                            resolve({ result: false, data: null });
                            loadModal(res, target);
                            break;
                    }
                }
            });
        }
        else {
            resolve({ result: false, data: null });
            el.removeAttr("data-id");
        }
    });
}
function loadModal(content, trgt, label) {
    var labl = label || "Seç";
    $("#modal").modal("show", { target: trgt });
    var cont = $("#modalContent");
    var lbl = $("#modalLabel");
    cont.empty();
    lbl.empty();
    cont.html(content);
    lbl.text(labl);
}
$(document).keydown(function (event) {
    if (event.key === 'F12') {
        event.preventDefault();
        const focusedInput = $('.input-group input:focus');
        if (focusedInput.length > 0) {
            const closestButton = focusedInput.siblings('button');
            if (closestButton.length > 0 && closestButton.is('button')) {
                closestButton.click();
            }
        }
    }
});
function clickEnter(elm) {
    var e = jQuery.Event("keypress");
    e.which = 13;
    e.keyCode = 13;
    $(elm).trigger(e);
}