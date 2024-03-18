(function ($) {

    "use strict";

    // init Chocolat light box
    var initChocolat = function () {
        Chocolat(document.querySelectorAll('.image-link'), {
            imageSize: 'contain',
            loop: true,
        })
    }

    var initCharts = function () {

        if ($(".chart")[0]) {

            var barColors = [
                "#F4BE37",
                "#E2EAF1"
            ];

            new Chart("orphans", {
                type: "doughnut",
                data: {
                    labels: ['Needs Help', 'Priviledged'],
                    datasets: [{
                        backgroundColor: barColors,
                        data: [65, 49]
                    }]
                },
                options: {
                    plugins: {
                        legend: false,
                        tooltip: false,
                    },
                    title: {
                        display: false,
                        text: "World Orphans 2018"
                    }
                }
            });

            new Chart("labor", {
                type: "doughnut",
                data: {
                    labels: ['Needs Help', 'Priviledged'],
                    datasets: [{
                        backgroundColor: barColors,
                        data: [35, 65]
                    }]
                },
                options: {
                    plugins: {
                        legend: false,
                        tooltip: false,
                    },
                    title: {
                        display: false,
                        text: "World Children Labor 2018"
                    }
                }
            });

            new Chart("education", {
                type: "doughnut",
                data: {
                    labels: ['Needs Help', 'Priviledged'],
                    datasets: [{
                        backgroundColor: barColors,
                        data: [75, 35]
                    }]
                },
                options: {
                    plugins: {
                        legend: false,
                        tooltip: false,
                    },
                    title: {
                        display: false,
                        text: "World Children Education 2022"
                    }
                }
            });

            new Chart("health", {
                type: "doughnut",
                data: {
                    labels: ['Needs Help', 'Priviledged'],
                    datasets: [{
                        backgroundColor: barColors,
                        data: [85, 25]
                    }]
                },
                options: {
                    plugins: {
                        legend: false,
                        tooltip: false,
                    },
                    title: {
                        display: false,
                        text: "World Children Health 2022"
                    }
                }
            });
        }
    }

    // init jarallax parallax
    var initJarallax = function () {
        jarallax(document.querySelectorAll(".jarallax"));

        jarallax(document.querySelectorAll(".jarallax-keep-img"), {
            keepImg: true,
        });
    }

    var initScrollNav = function () {
        $(window).scroll(function () {
            var scroll = $(window).scrollTop();

            if (scroll >= 200) {
                $('.site-header').addClass("bg-dark");
            } else {
                $('.site-header').removeClass("bg-dark");
            }
        });
    }

    $(document).ready(function () {
        // Lấy dữ liệu từ localStorage
        const myData = JSON.parse(localStorage.getItem('myData'));
        console.log(myData);
        if (myData != null) {
            document.querySelector('.sign-in-btn').innerHTML = "Log out"

        }
    });

    $(document).ready(function () {

        // preloader
        $(window).load(function () {
            $("#overlayer").fadeOut("slow");
            $('body').addClass('loaded');
        })

        initScrollNav();
        initChocolat();
        initCharts();
        initJarallax();

        // Animate on Scroll
        AOS.init({
            duration: 600,
            once: true,
        })
    });


})(jQuery);

// File Upload
// 
function ekUpload() {
    function Init() {

        console.log("Upload Initialised");

        var fileSelect = document.getElementById('file-upload'),
            fileDrag = document.getElementById('file-drag'),
            submitButton = document.getElementById('submit-button');

        fileSelect.addEventListener('change', fileSelectHandler, false);

        // Is XHR2 available?
        var xhr = new XMLHttpRequest();
        if (xhr.upload) {
            // File Drop
            fileDrag.addEventListener('dragover', fileDragHover, false);
            fileDrag.addEventListener('dragleave', fileDragHover, false);
            fileDrag.addEventListener('drop', fileSelectHandler, false);
        }
    }

    function fileDragHover(e) {
        var fileDrag = document.getElementById('file-drag');

        e.stopPropagation();
        e.preventDefault();

        fileDrag.className = (e.type === 'dragover' ? 'hover' : 'modal-body file-upload');
    }

    function fileSelectHandler(e) {
        // Fetch FileList object
        var files = e.target.files || e.dataTransfer.files;

        // Cancel event and hover styling
        fileDragHover(e);

        // Process all File objects
        for (var i = 0, f; f = files[i]; i++) {
            parseFile(f);
        }
    }

    // Output

    function parseFile(file) {
        document.getElementById('start').classList.add("hidden");
        document.getElementById('notimage').classList.add("hidden");
        // Thumbnail Preview
        document.getElementById('file-image').classList.remove("hidden");
        document.getElementById('file-image').src = URL.createObjectURL(file);

    }




    // Check for the various File API support.
    if (window.File && window.FileList && window.FileReader) {
        Init();
    } else {
        document.getElementById('file-drag').style.display = 'none';
    }
}
ekUpload();