$(document).ready(function () {
    lat = -34.6148022 ;
    lon = -58.4056014 ;
    apiK = "0a3503cab55ea599bdb96158ea8798d8" ; 


    $.ajax({
        url:"https://api.openweathermap.org/data/2.5/forecast?lat="+lat+"&lon="+lon+"&appid="+apiK,
        dataType: "json",
        success:function(clima)
        {
            clima = clima['list'];
            //la primera toma que te da el Json de unas temperaturas
            temp_max_base = clima[0]['main']['temp_min'];
            temp_min_base = clima[0]['main']['temp_max'];
            //la primera toma que te da el Json de una fecha
            day = clima[0]['dt_txt'];
            //debajo declaro las variables para ver el estado del tiempo una sola vez 
            lluvia_semanal = 0;
            clear_day = 0;
            rainy_day = 0;
            cloud_day = 0;

            clima.forEach(function(el1){
            
            min = el1['main']['temp_min'];
            max = el1['main']['temp_max'];
            weather = el1['weather'][0]['main'];

                //ver el estado del tiempo ej: nublado, lluvioso etc ademas si llueve en la semana

                switch(weather){
                    case "Clouds":
                        if(cloud_day != 0){
                        }
                        else{
                            cloud_day = el1['dt_txt'];
                        }
                        break;
                        //document.getElementById("hola").innerHTML = parseInt(cloud_day.slice(11,13));
                    case "Rain":
                        if(rainy_day != 0){
                        }
                        else{
                            rainy_day = el1['dt_txt'];
                            lluvia_semanal ++;
                        }
                        break;
                    case "Clear":
                        if(clear_day != 0){
                        }
                        else{
                            clear_day = el1['dt_txt'];
                        }
                        break;
                }

                //tomar temperaturas max & min
                if(max > temp_max_base){
                    temp_max_base = max;
                    hotter_day = el1['dt_txt'];
                }
            
                if(temp_min_base > min){    
                    temp_min_base = min;
                    colder_day = el1['dt_txt'];
                }

            })

            //pasar las temperaturas de K a C
            aprox_max = temp_max_base - 273.15;
            aprox_min = temp_min_base - 273.15;
            
            //Print en consola
            if(lluvia_semanal > 0){
                console.log("si va a llover en esta semana")
            }
            else{
                console.log("no va a llover esta semana")
            }
            console.log("La temperatura maxima fue "+aprox_max.toFixed(2)+"C el dia "+hotter_day.slice(8,10)+" del "+hotter_day.slice(5,7)+" del año "+hotter_day.slice(0,4)+" y la temperatura minima fue "+aprox_min.toFixed(2)+"C");
        }
            
    })






























});