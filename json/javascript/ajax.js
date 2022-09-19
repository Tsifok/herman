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
            let temp_max_base = clima[0]['main']['temp_min'];
            let temp_min_base = clima[0]['main']['temp_max'];
            //la primera toma que te da el Json de una fecha
            //debajo declaro las variables para ver el estado del tiempo una sola vez 
            let lluvia_semanal = 0;
            let con_clear_days = 0;
            let clear_day = 0;
            let rainy_day = 0;
            let cloud_day = 0;
            let amaneceres = [];

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
                            con_clear_days++;
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
                //dia 

            })

            //pasar las temperaturas de K a C       Fuera el foreach
            aprox_max = temp_max_base - 273.15;
            aprox_min = temp_min_base - 273.15;
            document.getElementById("temp_max").innerHTML = "La maxima de estos proximos dias sera de "+aprox_max.toFixed(2)+"C° el "+hotter_day.slice(8,10)+" del "+hotter_day.slice(5,7);
            document.getElementById("temp_min").innerHTML = "La minima de estos proximos dias sera de "+aprox_min.toFixed(2)+"C° el "+colder_day.slice(8,10)+" del "+colder_day.slice(5,7);
            
            //Print en consola
            if(con_clear_days > 0){
                document.getElementById("clear_day").innerHTML = "Estara despejado el dia "+clear_day.slice(8,10)+" del "+clear_day.slice(5,7);
            }
            else{
                document.getElementById("clear_day").innerHTML = "No habra dias despejados esta semana : ( ";
            }
            
            
            if(lluvia_semanal > 0){
                document.getElementById("lluvia_semanal").innerHTML = "Si, va a llover el "+rainy_day.slice(8,10)+" del "+rainy_day.slice(5,7)+" a las "+rainy_day.slice(11,16)+" hrs";
            }
            else{
                ultimo_dia_de_la_toma = clima[39]['dt_txt'];
                document.getElementById("lluvia_semanal").innerHTML = "No habra lluvia hasta el "+ultimo_dia_de_la_toma.slice(8,10)+" del "+ultimo_dia_de_la_toma.slice(5,7);
            }
            
        }
            
    })






























});