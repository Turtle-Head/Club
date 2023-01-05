(function($){

  // Backbone.sync: Overrides persistence storage with dummy function. This enables use of Model.destroy() without raising an error.
  Backbone.sync = function(method, model, success, error){
    success();
  };

  // Item class: The atomic part of our Model. A model is basically a Javascript object, i.e. key-value pairs, with some helper functions to handle event triggering, persistence, etc.
  var Item = Backbone.Model.extend({
    defaults: {
      part1: 'hello',
      part2: 'world'
    }
  });

  // List class: A collection of Items. Basically an array of Model objects with some helper functions.
  var List = Backbone.Collection.extend({
    model: Item
  });

  // ItemView class: Responsible for rendering each individual Item
  var ItemView = Backbone.View.extend({
    tagName: 'li', // name of tag to be created

    // events: Where DOM events are bound to View methods. Backbone doesn't have a separate controller to handle such bindings; it all happens in a View.
    // ItemViews now respond to two clickable actions for each Item: swap and delete.
    events: {
      'click span.swap':  'swap',
      'click span.delete': 'remove'
    },

    //initialize() now binds model change/removal to the corresponding handlers below.
    initialize: function(){
      _.bindAll(this, 'render', 'unrender', 'swap', 'remove'); // every function that uses 'this' as the current object should be in here

      this.model.bind('change', this.render);
      this.model.bind('remove', this.unrender);
    },

    // render() now includes two extra spans corresponding to the actions swap and delete.
    render: function(){
      $(this.el).html('<span style="color:black;">'+this.model.get('part1')+' '+this.model.get('part2')+'</span> &nbsp; &nbsp; <span class="swap" style="font-family:sans-serif; color:blue; cursor:pointer;">[swap]</span> <span class="delete" style="cursor:pointer; color:red; font-family:sans-serif;">[delete]</span>');
      return this; // for chainable calls, like .render().el
    },

    // unrender(): Makes Model remove itself from the DOM.
    unrender: function(){
      $(this.el).remove();
    },

    // swap() will interchange an Item's attributes. When the .set() model function is called, the event change will be triggered.
    swap: function(){
      var swapped = {
        part1: this.model.get('part2'),
        part2: this.model.get('part1')
      };
      this.model.set(swapped);
    },

    // remove(): We use the method destroy() to remove a model from its collection.
    // Normally this would also delete the record from its persistent storage, but we have overridden that (see above).
    remove: function(){
      this.model.destroy();
    }
  });


  // Because the new features (swap and delete) are intrinsic to each Item, there is no need to modify ListView.
  var ListView = Backbone.View.extend({
    el: $('body'), // el attaches to existing element
    events: {
      'click button#add': 'addItem'
    },

    // initialize() now instantiates a Collection, and binds its add event to own method appendItem. (Recall that Backbone doesn't offer a separate Controller for bindings...).
    initialize: function(){
      _.bindAll(this, 'render', 'addItem', 'appendItem'); // every function that uses 'this' as the current object should be in here

      this.collection = new List();
      this.collection.bind('add', this.appendItem); // collection event binder

      this.counter = 0;
      this.render();
    },
    render: function(){

      // Save reference to this so it can be accessed from within the scope of the callback below
      var self = this;
      $(this.el).append("<button id='add'>Add list item</button>");
      $(this.el).append("<ul></ul>");
      _(this.collection.models).each(function(item){ // in case collection is not empty
        self.appendItem(item);
      }, this);
    },

    // addItem() now deals solely with models/collections. View updates are delegated to the add event listener appendItem() below.
    addItem: function(){
      this.counter++;
      var item = new Item();
      item.set({
        part2: item.get('part2') + this.counter // modify item defaults
      });
      this.collection.add(item);
    },

    // appendItem() is no longer responsible for rendering an individual Item. This is now delegated to the render() method of each ItemView instance.
    appendItem: function(item){
      var itemView = new ItemView({
        model: item
      });
      $('ul', this.el).append(itemView.render().el);
    }
  });

  var listView = new ListView();
})(jQuery);
