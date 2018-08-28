/**
 * Höf Arnar Daði Steinþórsson 15.4.17
 */
var title = 'Tónleikar á Íslandi';
var errorcode = 'Því miður náðist ekki að sækja gögnin :/';

/**
 * Preloader
 */
jQuery(window).load(function() {
    // will first fade out the loading animation
    jQuery("#status").fadeOut();
    // will fade out the whole DIV that covers the website.
    jQuery("#preloader").delay(1000).fadeOut("slow");
});



$('.main').html('<h1 class="text-center">' + title + '');

$.ajax({
    'url': 'https://apis.is/concerts',
    'type': 'GET',
    'dataType': 'json',
    'success': function(response) {
        for(var i = 0; i < response.results.length; i++){
            var data = response.results;
            var date = moment(data[i].dateOfShow).format('DD.MMMM YYYY, h:mm');
            $('.main').append('' +
                '<div class="col-sm-4 col-md-3" data-tags="'+ data[i].eventHallName +'" alt="'+data[i].eventDateName+'" >' +
                    '<div class="thumbnail">' +
                        '<img class="eventimage" src="' + data[i].imageSource + '">' +
                        '<div class="caption">' +
                            '<h4 class="ellipsis"><b>' + data[i].eventDateName + '</b></h4>' +
                            '<p>' + data[i].eventHallName + '</p>' +
                            '<small>' + date + '</small>' +
                        '</div>' +
                    '</div>' +
                '</div>');
            $("img").error(function () {
                $(this).unbind("error").attr("src", "image/missing.jpg");
            });

        }




        var $events = $('.main .col-sm-4 col-md-3');          // Get the images
          var $search = $('#filter-search');      // Get the input element
          var fylki = [];                         // Create an array called cache

          $events.each(function() {                 // For each image
            fylki.push({                          // Add an object to the cache array
              element: this,                      // This image
              text: this.alt.trim().toLowerCase() // Its alt text (lowercase trimmed)
            });
          });

          function filter() {                     // Declare filter() function
            var query = this.value.trim().toLowerCase();  // Get the query
            fylki.forEach(function(div) {         // For each entry in cache pass image 
              var index = 0;                      // Set index to 0

              if (query) {                        // If there is some query text
                index = div.text.indexOf(query);  // Find if query text is in there
              }

              div.element.style.display = index === -1 ? 'none' : '';  // Show / hide
            });
          }


          if ('oninput' in $search[0]) {          // If browser supports input event
            $search.on('input', filter);          // Use input event to call filter()
          } else {                                // Otherwise
            $search.on('keyup', filter);          // Use keyup event to call filter()
          }              

          
    }
})
.fail(function() {
    $('.main').html('<h1 class="text-center">' + errorcode + '');
});


