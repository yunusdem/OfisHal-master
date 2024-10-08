
/**
 * 
 * @param {boolean} success - Success Or Error (true=success)
 * @param {string} text - Alert Text
 */
function ShowAlert(success, text, time) {
    if (time === null || time === undefined) {
        time = 2000;
    }
    Swal.fire({
        title: text,
        icon: success ? "success" : "error",
        showConfirmButton: false,
        timerProgressBar: success,
        timer: time,
        showCloseButton: !success,
        toast: true,
        customClass: {
            closeButton: "fw-bold"
        }
    });
}
function DeleteConfirm(confirmTitle) {
    confirmTitle = confirmTitle || "Silmek Istediginize Emin Misiniz?";
    return new Promise((resolve, reject) => {
        Swal.fire({
            title: confirmTitle,
            icon: "question",
            showConfirmButton: true,
            showCancelButton: true,
            showCloseButton: true,
            toast: true,
            confirmButtonText: "Evet",
            cancelButtonText: "Hayir",
            focusCancel: true,
            confirmButtonColor: "#f06548",
            customClass: {
                closeButton: "fw-bold",
                icon: 'text-primary border-primary',
            }
        }).then(res => {
            resolve(res);
        });
    });
}
$(document).keydown(function (event) {
    if (event.key === 'F2') {
        event.preventDefault();
        $("#hideRemoveBtn").trigger("click");
    }
});

function ErrorAlert(text) {
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-bottom-right",
        //"preventDuplicates": true,
        //"onclick": null,
        //"showDuration": "100",
        //"hideDuration": "1000",
        "timeOut": "0",
        "extendedTimeOut": "0",
        //"showEasing": "swing",
        //"hideEasing": "linear",
        //"showMethod": "show",
        //"hideMethod": "hide"
    };
    toastr.error(text)
}

function SuccessAlert(text) {
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-bottom-right",
        //"preventDuplicates": true,
        //"onclick": null,
        //"showDuration": "100",
        //"hideDuration": "1000",
        "timeOut": "0",
        "extendedTimeOut": "0",
        //"showEasing": "swing",
        //"hideEasing": "linear",
        //"showMethod": "show",
        //"hideMethod": "hide"
    };
    toastr.success(text)
}