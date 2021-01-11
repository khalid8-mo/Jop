    /* Start  Button Down For Reading More */

var ourInput = document.getElementById('ourinput'),
    myDiv1 =document.getElementById("ourtext"),
    myDiv2 =document.getElementById("level-div"),
    myDiv3 =document.getElementById("use-div"),
    myButtom1= document.getElementById('show'),
    myButtom2 = document.getElementById('level'),
    myButtom3 = document.getElementById('use');

ourInput.onfocus = function(){
'use strict';
if(this.placeholder==='البريد الالكتروني'){
    this.placeholder ='';
};

};
ourInput.onblur = function(){
    'use strict';
    if(this.placeholder===''){
        this.placeholder ='البريد الالكتروني';
    };
    
    };
    myButtom1.onclick=function(){
        'use strict';
        myDiv1.classList.toggle("hidden")
    }
    myButtom2.onclick=function(){
        'use strict';
        myDiv2.classList.toggle("hidden")
    }
    myButtom3.onclick=function(){
        'use strict';
        myDiv3.classList.toggle("hidden")
    }
    /* End Button Down For Reading More */
    /* Start Animation Window */
    window.onload = function(){
        var mySpinner = document.getElementById("platform");
        document.body.style.overflow = "hidden";
        setTimeout(function(){
            mySpinner.style.display = "none";
            document.body.style.overflow = "auto";
        },5000); 
    };
 /* End Animation Window */
 var myCount1 = document.getElementById("count1"),
     myCount2 = document.getElementById("count2"),
     myCount3 = document.getElementById("count3"),
     myCount4 = document.getElementById("count4");

     function animedCounter(element, start , end , duration){
         var range = end - start ;
         var current = start;
         var inCrement = 0 ;
         if(end > start){
            inCrement = 1 ;
         }else{
             inCrement = -1;
         };
         var timer = setInterval(function(){
            current += inCrement;
            element.textContent = current;
            if(current == end){
                clearInterval(timer);
            };
        },duration);
     };
    animedCounter(myCount1 , 1 , 3000 ,2);
    animedCounter(myCount2 , 1 , 3000 ,30);
    animedCounter(myCount3 , 1 , 5000 ,40);
    animedCounter(myCount4 , 1 , 6000 ,50);


    /********************** Start Progress  Color************************************** */
    $("#Start").click(function(){
        $(".progress-bar").animate({
            width:'30%',
            },2000);
            $(".progress-bar").animate({
                width:'40%',
                },2000);
                $(".progress-bar").animate({
                   width:'50%',
                    },2000);
                    $(".progress-bar").animate({
                        width:'60%',
                        background:'#088923',
                        },2000);
                        $(".progress-bar").animate({
                            width:'70%',
                            background:'#29c049',
                            },2000);
                            $(".progress-bar").animate({
                                width:'80%',
                                background:'#29c049',
                                },2000);
                                $(".progress-bar").animate({
                                    width:'90%',
                                    background:'#29c049',
                                    },2000);
                                    $(".progress-bar").animate({
                                        width:'100%',
                                        background:'#29c049',
                                        },2000);
                                        $(".progress-bar").animate({
                                            width:'20%',
                                            background:'#29c049',
                                            },2000);
    });
    
      /********************** End Start Progress Color************************************** */

          /********************** Stop Progress Color************************************** */
          $("#Stop").click(function(){
            $(".progress-bar").animate({
                width:'30%',
                });
             
        });     
         /********************** End Stop Progress Color************************************** */

