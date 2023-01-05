(function($) {
  'use strict';

  // Model
  var Person = Backbone.Model.extend({
    defaults:{
      name: '',
      age: -1,
      gender: '',
      address: '',
      city: '',
      state: '',
      country: '',
      email: '',
      phone: ''
    }
  });

  var People = Backbone.Collection.extend({
    model: Person, //the model that we can store in the collection
    // http://documentup.com/jeromegn/backbone.localStorage
    // localStorage: new Backbone.localStorage('collection-name')
    localStorage: new Backbone.localStorage('people-book')
  });

  var people = new People(); //initialize everything

  var james = new Person({
    name: 'James Fehr',
    age: '35',
    gender: 'M',
    address: '30 2nd St',
    city: 'Roseisle',
    state: 'Manitoba',
    country: 'Canada',
    email: 'fehr.james@gmail.com',
    phone: '(204) 828-3613'
  });

  people.add(james);

  // we grab the model we want by passing it in to people.get
  // alternatively we can use the ID of the model we want
  // note the second 'get' call is on the model we grabbed

  alert(people.get(james).get('name'));
})();
