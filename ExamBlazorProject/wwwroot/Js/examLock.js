window.ExamLock = {
    enable: function () {
        window.onbeforeunload = function (e) {
            e.preventDefault();
            e.returnValue = "You have an ongoing exam! Are you sure you want to leave?";
            return e.returnValue;
        };
    },
    disable: function () {
        window.onbeforeunload = null;
    }
};