// js/blogger.js
// 2016 James Fehr

$(function(){

	$(".linky").on("click", function(){
		if(this.id === 'home') {
			$('.content').hide();
			$('#welcome').show(true);
		}
	});

	var stickyNavTop = $('nav').offset().top;
	var stickyNav = function(){
		var scrollTop = $(window).scrollTop();
		if (scrollTop > stickyNavTop) {
			$('nav').addClass('sticky');
		} else {
			$('nav').removeClass('sticky');
		}
	};
	stickyNav();
	$(window).scroll(function() {
		stickyNav();
	});
	$('#article').hide();
});
