function calculate(steps, lengthInMeters, speedKmH) {
    let distance = steps * lengthInMeters;
    let speed = speedKmH * 1000 / 3600;
    let rest = Math.floor(distance / 500) * 60;

    let time = (distance / speed) + rest;

    let hours = Math.floor(time / 3600);
    let minutes = Math.floor(time / 60);
    let seconds = time % 60;

    let formattedTime = `${hours}:${minutes}:${seconds}`
    console.log(formattedTime);
}
calculate(4000, 0.60, 5);