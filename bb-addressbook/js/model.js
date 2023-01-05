(function($) {
  'use strict';

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

  alert(james.get('name'));

  james.set('name', 'Joe from Canada');

  alert(james.get('name'));
})();
