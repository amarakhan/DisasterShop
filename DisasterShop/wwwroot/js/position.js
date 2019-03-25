
navigator.geolocation.getCurrentPosition(function(pos){

            fetch("/home/position/",
{
            method: "post",
headers:
                {
                    'Accept': 'application/json',
    'Content-Type': 'application/json'
    },
body: JSON.stringify({ latitude: pos.coords.latitude, longitude: pos.coords.longitude})
});
        });

