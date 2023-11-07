document.getElementById('uploadButton').addEventListener('click', function (e) {
    e.preventDefault(); // Ngăn chuyển hướng khi người dùng nhấp vào thẻ <a>.
    document.getElementById('imageFileInput').click(); // Khi người dùng nhấp vào thẻ <a>, kích hoạt sự kiện click cho input file.
});

document.getElementById('imageFileInput').addEventListener('change', function () {
    var fileInput = document.getElementById('imageFileInput');
    var selectedFile = fileInput.files[0];

    if (selectedFile) {
        var formData = new FormData();
        formData.append('imageFile', selectedFile);

        // Sử dụng Fetch API để gửi ảnh lên máy chủ bằng phương thức POST
        fetch('/Admin/Employee/UpdateImage', {
            method: 'POST',
            body: formData
        })
            .then(response => {
                if (response.ok) {
                    console.log('Upload successful!');
                    fileInput.value = null; // Đặt lại giá trị của input file để cho phép người dùng chọn lại cùng một tệp tin (nếu cần).

                    // Làm mới trang sau khi tải lên thành công
                    location.reload();
                } else {
                    console.error('Upload failed!');
                }
            })
            .catch(error => {
                console.error('Upload failed: ' + error);
            });
    }
});