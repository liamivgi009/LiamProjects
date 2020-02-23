let $slider = $('.slider-item');
let currentSliderItem = 0;
let sliderInterval = setInterval(nextSlide, 6000);

let playing = true;
let $pausePlayButton = $('#pause-play');
let $nextButton = $('#next');
let $previousButton = $('#previous');

let $sliderPanel = $('.slider-panel');
let $indContainer = $('.slider-panel__navigation');
let $indItem = $('.indicator');

function nextSlide() {
    goToSlide(currentSliderItem + 1);
    remove();
    if (currentSliderItem == 1) {
        moveTextAnimation();
    }
    else if (currentSliderItem == 0) {
        moveButton();
    }
    else if (currentSliderItem == 2) {
        moveTruck();
        //moveContactButton();
        moveBoxes();
        moveTextImage3();
    }
    else if (currentSliderItem == 3) {
        GloveSlide();
        BlanstonSlide();
        ContactBut();
        ShoeSlide();
        Slide4Text();
    }
    else if (currentSliderItem == 4) {
        Slide5Text();
        FormSlide();
    }
       
}
$(document).ready(function () {
    moveButton();
});


function prevSlide() {
    goToSlide(currentSliderItem - 1);
    if (currentSliderItem == 1) {
        moveTextAnimation();
    }
    else if (currentSliderItem == 0) {
        moveButton();
    }
    else if (currentSliderItem == 2) {
        moveTruck();
        //moveContactButton();
        moveBoxes();
        moveTextImage3();
    }
    else if (currentSliderItem == 3) {
        GloveSlide();
        BlanstonSlide();
        ShoeSlide();
        Slide4Text();
        ContactBut();
    }
    else if (currentSliderItem == 4) {
        Slide5Text();
        FormSlide();
    }
}

function goToSlide(n) {
    $($slider[currentSliderItem]).toggleClass('active');
    $($indItem[currentSliderItem]).attr('class', 'far fa-circle indicator');

    currentSliderItem = ($slider.length + n) % $slider.length;

    $($slider[currentSliderItem]).toggleClass('active');
    $($indItem[currentSliderItem]).attr('class', 'fas fa-circle indicator');
}

function pauseSlideShow() {
    $pausePlayButton.attr('class', 'far fa-play-circle');
    playing = false;
    clearInterval(sliderInterval);
}

function playSlideShow() {
    $pausePlayButton.attr('class', 'far fa-pause-circle');
    playing = true;
    sliderInterval = setInterval(nextSlide, 3000);
}

$sliderPanel.css('display', 'flex');

$pausePlayButton.on('click', () => {
    if (playing) pauseSlideShow();
    else playSlideShow();
});

$nextButton.on('click', () => {
    pauseSlideShow();
    nextSlide();
});

$previousButton.on('click', () => {
    pauseSlideShow();
    prevSlide();
});

$indContainer.on('click', (event) => {
    let target = event.target;

    if (target.classList.contains('indicator')) {
        pauseSlideShow();
        goToSlide(+target.getAttribute('data-slide-to'));
    }
});

//---------------------------------------------------------------------
$(document).on('keydown', keyNavigation);

function keyNavigation(event) {

    if (event.code === 'ArrowLeft') { //стрелка влево
        pauseSlideShow();
        prevSlide();
    }
    if (event.code === 'ArrowRight') { //стрелка вправо
        pauseSlideShow();
        nextSlide();
    }
    if (event.code === 'Space') { //пробел
        if (playing) pauseSlideShow();
        else playSlideShow();
    }
}
function moveText()
{
    $(".slider-text-h1First").addClass("moveText" + 1);
    $(".slider-text-h1Second").addClass("moveText" + 2);
    $(".slider-text-h1Third").addClass("moveText" + 3);
    $(".buttonRegister").addClass("RegisterButton");
}

function moveTextAnimation()
{
    var w = document.getElementById("slider").clientWidth;
   
    $(".slider-text-h1First").animate({
        left:  w/2 +"px",
    }, 2000);
    $(".slider-text-h1Second").animate({
        left: (w / 2) - (w / 2)* 0.15 + "px",
    }, 2000);
    $(".slider-text-h1Third").animate({
        left: (w / 2) - (w / 2) * 0.34 + "px",
    }, 2000);

}
function remove()
{
    $(".slider-text-h1First").removeClass("moveText" + 1);
    $(".slider-text-h1Second").removeClass("moveText" + 2);
    $(".slider-text-h1Third").removeClass("moveText" + 3);
    $(".buttonRegister").removeClass("RegisterButton");
    $(".buttonLogin").removeClass("LoginButton");
    $(".truckImage").removeClass("ImageTruck");
    $(".BoxesImage").removeClass("ImageBoxes");
    $(".sliderTextImage3Header1").removeClass("slideTextFirst");
    $(".sliderTextImage3Header2").removeClass("slideTextSecond");
    $(".ContactButton").removeClass("ButtonContactImage3");
    $(".GloveImg").removeClass("ImageGlove");
    $(".BlanstonImg").removeClass("ImageBlanston");
    $(".ShoeImg").removeClass("ImageShoe");
    $(".slide4head1").removeClass("slide4FirstHead");
    $(".slide4head2").removeClass("slide4SecondHead");
    $(".ContactButton").removeClass("ButtonContactNow");
    $(".SliderTextLastImg1").removeClass("SlideTextLastImage");
    $(".SliderTextLastImg2").removeClass("SlideTextLastImage2");
    $(".slide5Form").removeClass("LastSlideForm");
}
function moveButton() {
    $(".buttonLogin").addClass("LoginButton");
}
function moveTruck() {
    $(".truckImage").addClass("ImageTruck");
}
function moveBoxes() {
    $(".BoxesImage").addClass("ImageBoxes");
}
function moveTextImage3() {
    $(".sliderTextImage3Header1").addClass("slideTextFirst");
    $(".sliderTextImage3Header2").addClass("slideTextSecond");
}
function moveContactButton() {
    $(".ContactButton").addClass("ButtonContactImage3");

}
function GloveSlide() {
    $(".GloveImg").addClass("ImageGlove");
}
function BlanstonSlide() {
    $(".BlanstonImg").addClass("ImageBlanston");
}
function ShoeSlide() {
    $(".ShoeImg").addClass("ImageShoe");
}
function Slide4Text() {
    $(".slide4head1").addClass("slide4FirstHead");
    $(".slide4head2").addClass("slide4SecondHead");
}
function ContactBut() {
    $(".ContactButton").addClass("ButtonContactNow");
}
function Slide5Text() {
    $(".SliderTextLastImg1").addClass("SlideTextLastImage");
    $(".SliderTextLastImg2").addClass("SlideTextLastImage2");
}
function FormSlide() {
    $(".slide5Form").addClass("LastSlideForm");
}
//---------------------------------------------------------------------