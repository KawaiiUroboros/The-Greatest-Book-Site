// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {


	var
		screen = 0,
		container = $('.cont'),
		pages = $('.page'),
		inscroll = false;

	$('.page:first-child').addClass('active');

	$('body').on('mousewheel', function (event) {

		console.log(event.deltaY);

		var
			activepage = pages.filter('.active');


		if (!inscroll) {
			inscroll = true;


			if (event.deltaY > 0) {

				if (activepage.prev().length) {
					screen--;
				}

			}
			else {
				if (activepage.next().length) {
					screen++;
				}
			}

		}

		var
			position = (-screen * 100) + '%';



		pages.eq(screen).addClass('active').siblings().removeClass('active');

		container.css('top', position);



		setTimeout(function () {
			inscroll = false;
		}, 300);




	});




});