(function($) {
  'use strict';

  var ListView = Backbone.View.extend({
    // the DOM element we bind this.el to can be any valid CSS selector
    el: $('body'),

    // now for some multiple events
    events: {
      'click button#add': 'addItem',
      'click button#remove': 'removeItem'
    },

    // called when our view is created
    initialize: function() {
      this.render();
    },

    // our render function
    render: function() {
      $('#list').append('<li>hey!!!</li>');
    },

    addItem: function() {
      $('#list').append('<li>Another Item</li>');
    },

    removeItem: function() {
      $('#list li:last').remove();
    }

  });

  // now we create the list view for the app
  var list = new ListView();
})(jQuery);
