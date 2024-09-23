// Sayma animasyonu için

document.addEventListener("DOMContentLoaded", function () {
    var counters = document.querySelectorAll(".counter");
    var speed = 8000; // Animasyonun hızı

    counters.forEach(counter => {
        var updateCount = () => {
            var target = +counter.getAttribute('data-count');
            var count = +counter.innerText;
            var increment = target / speed;

            if (count < target) {
                counter.innerText = Math.ceil(count + increment);
                setTimeout(updateCount, 1);
            } else {
                counter.innerText = target;
            }
        };

        updateCount();
    });
});

new WOW().init();

// Scroll animasyonları için ScrollReveal kullanımı
ScrollReveal().reveal('.card', {
    duration: 1000,
    origin: 'bottom',
    distance: '50px',
    easing: 'ease-in-out',
    reset: true
});

// Yavaş fade-in animasyonu için
document.addEventListener("DOMContentLoaded", function () {
    let elements = document.querySelectorAll('.fade-in');
    elements.forEach(el => {
        el.style.opacity = 0;
        el.style.transition = 'opacity 2s ease-in-out';
        setTimeout(() => el.style.opacity = 1, 1000);
    });
});

// Carousel başlıklarına animasyon eklemek
let slogans = document.querySelectorAll('.slogans');
slogans.forEach((slogan, index) => {
    slogan.classList.add('animate__animated', 'animate__fadeInUp');
    slogan.style.animationDelay = `${index * 0.5}s`;
});


