function getInfo() {
    let stopID = document.getElementById("stopId").value;
    let stopName = document.getElementById("stopName");
    let busesList = document.getElementById("buses");

    busesList.innerHTML = "";
    fetch(`http://localhost:3030/jsonstore/bus/businfo/${stopID}`)
        .then((response) => response.json())
        .then((res) => {
            stopName.textContent = res.name;
            let count = 0;

            for (const key in res.buses) {
                let busId = key;
                let time = Object.values(res.buses)[count];

                let li = document.createElement("li");
                li.textContent = `Bus ${busId} arrives in ${time} minutes`;
                
                busesList.appendChild(li);
                count++;
            }
        })
        .catch((err) => (stopName.textContent = "Error"));

    // async function resolve() {
    //     let response = await fetch(`http://localhost:3030/jsonstore/bus/businfo/${stopID}`)
    //         .then(response => response.json())
    //         .then((res) => {
    //             stopName.textContent = res.name;
    //             let count = 0;

    //             for (const key in res.buses) {
    //                 let busId = key;
    //                 let time = Object.values(res.buses)[count];

    //                 let li = document.createElement("li");
    //                 li.textContent = `Bus ${busId} arrives in ${time} minutes`;

    //                 busesList.appendChild(li);
    //                 count++;
    //             }
    //         })
    //         .catch((err) => (stopName.textContent = "Error"));
    // }
    // resolve();
}