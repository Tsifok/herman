$(document).ready(function () {
    lat = -34.6148022 ;
    var tiempo ="";
    lon = -58.4056014 ;
    apiK = "0a3503cab55ea599bdb96158ea8798d8" ; 
    $.ajax({
        url:"https://api.openweathermap.org/data/2.5/forecast?lat="+lat+"&lon="+lon+"&appid="+apiK+"&units=metric",
        dataType: "json",
        success:function(clima){
            
            //cosas que se declaran para tener una base con la que comparar
            texto = ''
            i = 1;          
            clima = clima['list'];
            temp_actual = clima[0]['main']['temp'];
            temp_b_max = clima[0]['main']['temp_max'];
            temp_b_min = clima[0]['main']['temp_min'];
            diasb = parseInt((clima[0]['dt_txt']).slice(8,10));
            diasb2 = parseInt((clima[0]['dt_txt']).slice(8,10));
            document.getElementById("temp_actual").innerHTML = temp_actual+"°C actual";

            clima.forEach(function(el1){
                
                dias = parseInt(el1['dt_txt'].slice(8,10));

                    if(dias == diasb){
                        tempmax1=el1['main']['temp_max'];
                        tempmin1=el1['main']['temp_min'];
                        weather = el1['weather'][0]['main'];
                        

                            switch(weather){
                                case "Clear":
                                    tiempo = "http://openweathermap.org/img/wn/01d@2x.png";
                                break;
                                case "Clouds":
                                    tiempo = "http://openweathermap.org/img/wn/03d@2x.png";
                                break;
                                case "Thunderstorm":
                                    tiempo = "http://openweathermap.org/img/wn/10d@2x.png";
                                break;
                                case "Rain":
                                    tiempo = "http://openweathermap.org/img/wn/01d@2x.png";
                                break;
                                case "Mist":
                                    tiempo = "http://openweathermap.org/img/wn/50d@2x.png";
                                break;
                                default:
                                    tiempo = "https://w7.pngwing.com/pngs/388/487/png-transparent-computer-icons-graphy-img-landscape-graphy-icon-miscellaneous-angle-text.png"
                                break;
                            }
                           
                        if(tempmax1>temp_b_max){
                            temp_b_max = tempmax1;
                        }
                        if(tempmin1<temp_b_min){
                            temp_b_min = tempmin1;
                        }
                    }
                    else{
                        if(i <=6){
                        document.getElementById("datos").innerHTML += `<div class="card" style="width: 14rem;">
                        <img class="card-img-top" id="img_dia${i}" src="" alt="img">
                        <div class="card-body">
                        <p class="card-text" id="dia${i}"></p>
                        </div>
                        </div>`
                        document.getElementById("dia"+i).innerHTML = "MAX de "+temp_b_max+"°C <br> MIN de "+temp_b_min+"°C <br> del dia "+diasb;
                        $("#img_dia"+i).attr("src",tiempo);
                        diasb = dias
                            i ++;
                         if(i <6){
                            temp_b_max = 0;
                            temp_b_min = 100; 
                         }

                        }
                        
                    }
                    
                    

            });            

        }
    })

});