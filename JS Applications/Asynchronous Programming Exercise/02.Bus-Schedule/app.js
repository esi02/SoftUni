function solve() {
    let departButtonElement = document.getElementById('depart');
    let arriveButtonElement = document.getElementById('arrive');
    let infoBoxElement = document.getElementById('info');
    let currentStop = 'depot';
    let nextStop = '';

    function depart() {
        fetch(`http://localhost:3030/jsonstore/bus/schedule/${currentStop}`)
            .then(response => response.json())
            .then(result => {
                infoBoxElement.textContent = `Next stop ${result.name}`;
                currentStop = result.name;
                nextStop = result.next;

                departButtonElement.disabled = true;
                arriveButtonElement.disabled = false;
            })
            .catch(err => {
                infoBoxElement.textContent = 'Error';
                departButtonElement.disabled = true;
                arriveButtonElement.disabled = true;
            });
    }

    function arrive() {
        infoBoxElement.textContent = `Arriving at ${currentStop}`;

        departButtonElement.disabled = false;
        arriveButtonElement.disabled = true;

        currentStop = nextStop;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();