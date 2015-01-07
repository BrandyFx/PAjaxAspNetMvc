$(function() {
    $(':checkbox').prop('checked', $.cookie('pjax') === 'true')

  if (!$(':checkbox').prop('checked'))
    $.fn.pjax = $.noop

  $(':checkbox').change(function() {
    if ( $.pjax == $.noop ) {
      $(this).removeAttr('checked')
      return alert( "Sorry, your browser doesn't support pjax :(" )
    }

    if ($(this).prop('checked'))
      $.cookie('pjax', true)
    else
      $.cookie('pjax', false)

    window.location = location.href
  })
});