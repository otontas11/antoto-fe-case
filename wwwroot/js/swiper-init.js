 const swiper = new Swiper('.slide-content', {
    loop: false,
    spaceBetween: 12, // px
   observer: true,
    
    breakpoints: {

        320: {
            slidesPerView: 1.5,     
            slidesPerGroup: 1,   
            slidesPerGroupAuto: true,
            slidesOffsetAfter: 10,
        },

        768: {
            slidesPerView: 3,   
            slidesPerGroup: 2,   
            slidesPerGroupAuto: true,
            slidesOffsetAfter: 50,
        },
        
        1024: {
            slidesPerView: 5,    
            slidesPerGroup: 3,  
            slidesPerGroupAuto: true,
            slidesOffsetAfter: 80,
        }
    },
 
    // Navigation arrows
    navigation: {
      nextEl: '.swiper-button-next',
      prevEl: '.swiper-button-prev',
    },
  
    // And if we need scrollbar
    scrollbar: {
      el: '.swiper-scrollbar',
    },

    watchOverflow: true,

  });

 