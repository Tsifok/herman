$( document ).ready(function() {
    var code_html = "";
    var bandera = "";
    var pag_act= 1;
    var i = 0;

    
myFunction(pag_act);
function myFunction (pag_act,bandera){

        $.ajax({
            url:"php/show.php",
            type:"GET",
            data:{pag:pag_act,bandera:bandera},
            dataType: "json",
            success:function(data){

                if(data.bandera == "last"){
                    pag_act = data.max_reg;
                }else if(data.bandera == "beginning"){
                    pag_act = 1;
                }
                code_html = `<table style='solid' id='${pag_act}'>`; 
                //console.log(data);
                datatotal = data.demas;

                datatotal.forEach((element) => {
                    //console.log(element);
                    code_html +=` <tr> <td>${element.id}</td> <td>${element.content}</td> </tr>`;
                    
                });

                if(data.max_reg == pag_act){
                    $("#Next").addClass("disabled");
                    $("#last").addClass("disabled");
                }else{
                    $("#Next").removeClass("disabled");
                    $("#last").removeClass("disabled");
                }

                if(1 == pag_act){
                    $( "#Previous" ).addClass( "disabled" );
                    $( "#beginning_btn" ).addClass( "disabled" );
                    //alert("bandera");
                }else if($("#Previous").hasClass('disabled')){
                    $("#Previous").removeClass("disabled");
                    $("#beginning_btn").removeClass("disabled");
                    //alert("no")
                }

                $("#tabla").html(code_html+="</table>");
                $('#contador').html(`<div>hola${pag_act}</div>`);
                console.log(pag_act)


                btns_html = `
                <div id="first-child" class="pagination">
                    <li class="page-item">
                        <a class="page-link btn_num" href="" id="num1">${pag_act == data.max_reg ? pag_act-4 : pag_act == data.max_reg-1 ? pag_act-4 : pag_act == data.max_reg-2 ? pag_act-2 : pag_act <= 3 ? 1 : pag_act-2 }</a>
                    </li>
                    
                    <li class="page-item">
                        <a class="page-link btn_num" href="" id="num2">${pag_act == data.max_reg ? pag_act-3 : pag_act == data.max_reg-1 ? pag_act-2 : pag_act == data.max_reg-2 ? pag_act-1 : pag_act <= 3 ? 2 : pag_act-1 }</a>
                    </li>
                    
                    <li class="page-item">
                        <a class="page-link btn_num" href="" id="num3">${pag_act == data.max_reg ? pag_act-2 : pag_act == data.max_reg-1 ? pag_act-1 : pag_act == data.max_reg-2 ? pag_act : pag_act <= 3 ? 3 : pag_act }</a>
                    </li>
            
                    <li class="page-item">
                        <a class="page-link btn_num" href="" id="num4">${pag_act == data.max_reg ? pag_act-1 : pag_act == data.max_reg-1 ? pag_act : pag_act == data.max_reg-2 ? pag_act+1 : pag_act <= 3 ? 4 : pag_act+1 }</a>
                    </li>
                    
                    <li class="page-item">
                        <a class="page-link btn_num" href="" id="num5">${pag_act <= data.max_reg-3 ? pag_act+2 : pag_act > data.max_reg-3 ? (data.max_reg - pag_act)+pag_act :pag_act <= 3 ? 5 : pag_act+2 }</a>
                    </li>
                </div>`;

                $("#buttons").html(btns_html);
                $("#pag").html(`${"La pagina actual es : "+pag_act}`);
            }   
        
        });
    }

    $("#next_btn").click(function(e){
        e.preventDefault();
        pag_act++;
        myFunction(pag_act);
        console.log(pag_act);

    })

    $("#previous_btn").click(function(e){

        if($("#last").hasClass("disabled")){
            pag_act=$("#num5").text();
        }
        e.preventDefault();
        pag_act--;
        myFunction(pag_act);

    })

    $("#beginning_btn").click(function(e){
        e.preventDefault();
        bandera = "beginning"
        pag_act = 1;
        myFunction(pag_act,bandera);

    })

    $("#last_btn").click(function(e){
        e.preventDefault();
        bandera = "last"
        pag_act = 1;
        myFunction(pag_act,bandera);

    })

    $("#buttons").on("click", ".btn_num", function (e) {
        e.preventDefault();
        

        pag_act = parseInt(this.text);
        myFunction(pag_act);

    })



});