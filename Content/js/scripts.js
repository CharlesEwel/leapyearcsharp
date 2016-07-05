$(document).ready(function(){
  //Responsibility Field ID Number:
  i = 1;
  $(".add-testword").click(function(){
    $("#test-word-div").append('<br><label for ="testWord'+i+'">Enter a Test Word:</label>'+
    '<input id ="testWord'+i+'" name="testWord'+i+'" type="text" required="true">');
    $("#number-of-testWords").val(i+1);
    i ++;
  });
});
