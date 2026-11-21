$(function (){
    $('.pkhd-loai').click(function (e){
        e.preventDefault();
        var id = $(this).data('maloai'), li = $(this).parent();
        if ($('#pkhd-content').length ==0) {location.href = '/?maLoai=' + id; return; }
        $.get('/Home/LocTheoLoai', { maLoai: id}, function (html) {
            $('#pkhd-content').html(html);
            $('.menu li').removeClass('active');
            li.addClass('active');
        });
    });
});