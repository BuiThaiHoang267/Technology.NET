document.addEventListener('DOMContentLoaded', function () {
    // Lấy tất cả các button
    var buttons = document.querySelectorAll('.header-button');

    // Gắn sự kiện click cho mỗi button
    buttons.forEach(function (button) {
        button.addEventListener('click', function (event) {
            event.preventDefault(); // Ngăn chặn việc load lại trang

            // Xóa class 'isActive' từ tất cả các button
            buttons.forEach(function (btn) {
                btn.classList.remove('button-active');
            });

            // Thêm class 'isActive' cho button vừa nhấn
            button.classList.add('button-active');

            // Điều hướng đến URL tương ứng
            var url = button.getAttribute('data-url');
            window.location.href = url; // Điều hướng đến URL
        });
    });
});
