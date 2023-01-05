var c = function() {
  self = this;
  this.pass = ko.observable('');
  this._length = ko.observable('');
  var nonce_generate = function(len){
    var length;
    if(len>0){
      length = (Math.floor(Math.random() * len));
    } else {
      length = (Math.floor(Math.random() * 32));
    }
    // SRC #002{'https://blog.nraboy.com/2015/03/create-a-random-nonce-string-using-javascript/'}
    var text = '';
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    for(var i = 0; i < length; i++) {
        text += text + possible.charAt(Math.floor(Math.random() * possible.length));
    }
    self.pass(text);
  };
  var genPass = ko.computed(function() {
    var p = nonce_generate(self._length());
    return p;
  }, this);
};

ko.applyBindings(new c());
