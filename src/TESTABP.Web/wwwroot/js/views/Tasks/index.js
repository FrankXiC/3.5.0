(function ($) {
    $(function () {
        debugger;
        var _$taskStateCombobox = $('#TaskStateCombobox');
       
        _$taskStateCombobox.change(function () {
            var state = "";
            if (_$taskStateCombobox.val() == "open") {
                state = 1;
            }
            else if (_$taskStateCombobox.val() == "Completed") {
                state = 2;
            }
            location.href = '/Tasks/TaskList?state=' + state;
        });

    });
})(jQuery);