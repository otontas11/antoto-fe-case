document.querySelectorAll('.footer-items').forEach(item => {
    item.addEventListener('click', function () {
      document.querySelectorAll('.footer-items').forEach(el => el.classList.remove('active'));
      this.classList.add('active');
    });
  });
  