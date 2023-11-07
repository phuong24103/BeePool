document.getElementById('uploadButton').addEventListener('click', function () {
    document.getElementById('imageFileInput').click();
});

document.getElementById('imageFileInput').addEventListener('change', function () {
    var fileInput = document.getElementById('imageFileInput');
    var selectedFile = fileInput.files[0];

    if (selectedFile) {
        var formData = new FormData();
        formData.append('imageFile', selectedFile);

        // Sử dụng Fetch API để gửi ảnh lên máy chủ bằng phương thức POST
        fetch('/Customer/UpdateImage', {
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