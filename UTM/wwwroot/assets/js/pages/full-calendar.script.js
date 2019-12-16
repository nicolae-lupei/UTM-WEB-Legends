


(function($){

"use strict";

        $('#calendar').fullCalendar({
          header: false,
          defaultDate: moment('2018-06-01'),
          events: [
        {
          title: 'Obiect 1',
          start: '2018-06-01'
        },
        {
            title: 'Obiect 1',
          start: '2018-06-07',
          end: '2018-06-10'
        },
        {
          id: 999,
            title: 'Obiect 1',
          start: '2018-06-09T16:00:00'
        },
        {
          id: 999,
            title: 'Obiect 4',
          start: '2018-06-16T16:00:00'
        },
        {
            title: 'Obiect 1',
          start: '2018-06-11',
          end: '2018-06-13'
        },
        {
            title: 'Obiect 1',
          start: '2018-06-12T10:30:00',
          end: '2018-06-12T12:30:00'
        },
        {
            title: 'Obiect 3',
          start: '2018-03-12T12:00:00'
        },
        {
            title: 'Obiect 2',
          start: '2018-06-12T14:30:00'
        },
        {
            title: 'Obiect 1',
          start: '2018-06-12T17:30:00'
        },
        {
            title: 'Obiect 1',
          start: '2018-06-12T20:00:00'
        },
        {
            title: 'Obiect 4',
          start: '2018-06-13T07:00:00'
        },
        {
            title: 'Obiect 1',
          url: 'http://google.com/',
          start: '2018-06-28'
        }
      ]
        });


        $('#prev').on('click', function() {
          $('#calendar').fullCalendar('prev'); // call method
        });

        $('#next').on('click', function() {
          $('#calendar').fullCalendar('next'); // call method
        });

        $('#today').on('click', function() {
          $('#calendar').fullCalendar('today'); // call method
        });


        $('#list-view').on('click', function() {
          $('#calendar').fullCalendar( 'changeView', 'list'); // call method
        });

        $('#week-view').on('click', function() {
          $('#calendar').fullCalendar( 'changeView', 'basicWeek'); // call method
        });

        $('#day-view').on('click', function() {
          $('#calendar').fullCalendar( 'changeView', 'agenda'); // call method
        });

        $('#month-view').on('click', function() {
          $('#calendar').fullCalendar( 'changeView', 'month'); // call method
        });


})(jQuery);