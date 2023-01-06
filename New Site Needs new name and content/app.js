$(function(){
  var view = {
    nonce_generate: function() {
      var length = 5;
      // SRC #002{'https://blog.nraboy.com/2015/03/create-a-random-nonce-string-using-javascript/'}
      var text = "";
      var possible = "123456";
      for(var i = 0; i < length; i++) {
          text += possible.charAt(Math.floor(Math.random() * possible.length));
      }
      return text;
    },
    init: function() {
      for(var i = 0; i < 10; i++) {
        $('body').append('<div>' + view.nonce_generate() + '</div>');
      }
    }
  };
  view.init();
});
