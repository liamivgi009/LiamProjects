$("document").ready(
    function()
    {
        var amount = 1;
        $(".minus").click(
            function()
            {
             
                if (amount > 1)
                    amount--;
                $(".count").val(amount);
            }
            
            );

        $(".plus").click(
           function () {
              
               amount++;
               $(".count").val(amount);
           }
           );
    }
    );