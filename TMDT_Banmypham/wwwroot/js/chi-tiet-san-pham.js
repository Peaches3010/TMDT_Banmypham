$(document).ready(function() {
    $("#zoom").elevateZoom(); // zoom sản phẩm

    //navbar & back to top
    $('ul li').click(function(event) {
        $(this).addClass('active').siblings().removeClass('active');
    })
    $(window).scroll(function() {
        var pos_body = $('html, body').scrollTop();

        if (pos_body > 50) {
            $('nav').addClass('shadow');
            $('nav').addClass('sticky');
        } else {

            $('nav').removeClass('shadow');
            $('nav').removeClass('sticky');
        }
        if (pos_body > 400) {
            $('nav').addClass('nav-change-color');
            $('.nav-link').addClass('menu');
            $('.dropdown-menu').css("background-color", "#F79483");
            $("#show-log-in-form a").css("color", "white");
            $("#show-sign-up-form a").css("color", "white");
            $('.dropdown a').css("color", "white");
        } else {
            $('nav').removeClass('nav-change-color');
            $('.nav-link').removeClass('menu');
            $('.dropdown-menu').css("background-color", "");
            $("#show-log-in-form a").css("color", "");
            $("#show-sign-up-form a").css("color", "");
            $('.dropdown a').css("color", "");
        }
        if (pos_body > 1000) {
            $('.back-to-top').addClass('show-btt');
        } else {
            $('.back-to-top').removeClass('show-btt');
        }
        $('.back-to-top').click(function(event) {
            window.scrollTo(0, 0);
        })
    });

    // form dang ky & dang nhap
    document.getElementById('show-log-in-form').addEventListener("click", function() {
        document.querySelector(".background1").style.display = "flex";
        $('html, body').addClass('disable-scrolling');
    });

    document.querySelector(".close-button1").addEventListener("click", function() {
        document.querySelector(".background1").style.display = "none";
        $('html, body').removeClass('disable-scrolling');
    });
    document.getElementById('show-sign-up-form').addEventListener("click", function() {
        document.querySelector(".background").style.display = "flex";
        $('html, body').addClass('disable-scrolling');
    });

    document.querySelector(".close-button").addEventListener("click", function() {
        document.querySelector(".background").style.display = "none";
        $('html, body').removeClass('disable-scrolling');
    });

    document.getElementById('show-sign-up-in-log-in').addEventListener("click", function() {
        document.querySelector(".background1").style.display = "none";
        document.querySelector(".background").style.display = "flex";
    });


    //days & months & years

    $(document).ready(function() {
        var year = new Date().getFullYear();
        // load years
        for (var i = 2020; i >= 1940; i--) $("#year").append('<option value=' + i + '>' + i + '</option>');
        // load months
        for (var i = 1; i <= 12; i++) $("#month").append('<option value=' + i + '>' + i + '</option>');
        // load days
        for (var i = 1; i <= 31; i++) $("#day").append('<option value=' + i + '>' + i + '</option>');
    });

    $(function() {
        $('#year').change(function() {
            var now = new Date();
            if ($('#year').val() == now.getFullYear()) {
                $('#month option').each(function() {
                    if ($(this).val() > (now.getMonth() + 1)) $(this).remove();
                });
            } else {
                for (var i = 1; i < 13; i++)
                    if ($("#month option[value='" + i + "']").val() == undefined)
                        $("#month").append('<option value=' + i + '>' + i + '</option>');
            }

            checkMonth();
        });

        $('#month').change(checkMonth);
    });

    function checkMonth() {
        var now = new Date();
        if ($('#year').val() == now.getFullYear() && $('#month').val() == (now.getMonth() + 1)) {
            $('#day option').each(function() {
                if ($(this).val() > now.getDate()) $(this).remove();
            });
        } else {
            var days = 31;
            var month = $('#month').val();
            if (month == 2) {
                if (($('#year').val() % 4) == 0) days = 29; // leap year
                else days = 28;
            } else if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11) {
                days = 30;
            }
            for (var i = 1; i < 32; i++)
                if (i > days)
                    $("#day option[value='" + i + "']").remove();
                else if ($("#day option[value='" + i + "']").val() == undefined)
                $("#day").append('<option value=' + i + '>' + i + '</option>');
        }
    }

    //hide & show password sign up
    $(document).ready(function() {
        var pass = document.getElementById('psword');
        document.querySelector("i.fa-eye").addEventListener("click", function() {
            if (pass.type === "password") {
                pass.type = "text";
                document.querySelector('i.fa-eye').style.display = "none";
                document.querySelector('i.fa-eye-slash').style.display = "inline-block";
            }
        })
        document.querySelector("i.fa-eye-slash").addEventListener("click", function() {
            if (pass.type === "text") {
                pass.type = "password";
                document.querySelector('i.fa-eye').style.display = "inline-block";
                document.querySelector('i.fa-eye-slash').style.display = "none";
            }
        })
    })

    //dark mode
    var checkbox = document.querySelector("input[name=checkbox]");
    checkbox.addEventListener('change', function() {
        if (this.checked) {
            document.body.classList.add('dark');
            document.querySelector('.jss44').classList.add('bgchange-color');
            document.querySelector('.footer').classList.add('change');
        } else {
            document.body.classList.remove('dark');
            document.querySelector('.jss44').classList.remove('bgchange-color');  
            document.querySelector('.footer').classList.remove('change');
        }
    })
});