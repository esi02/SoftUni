function attachEvents() {
    let location = document.getElementById('location');
    let submitButton = document.getElementById('submit');
    let forecastElement = document.getElementById('forecast');
    let currentConditions = document.getElementById('current');
    let upcomingConditions = document.getElementById('upcoming');

    const symbols = {
        ['Sunny']: '☀',
        ['Partly sunny']: '⛅',
        ['Overcast']: '☁',
        ['Rain']: '☂',
        ['Degrees']: '°',
    };

    let locationsUrl = `http://localhost:3030/jsonstore/forecaster/locations`;

    submitButton.addEventListener('click', () => {
        //Locations request
        fetch(locationsUrl)
            .then(response => response.json())
            .then(result => {
                let { code } = Object.values(result).find(x => x.name == location.value);
                forecastElement.style.display = 'block';

                let currentConditionsUrl = `http://localhost:3030/jsonstore/forecaster/today/${code}`;
                let upcomingConditionsUrl = `http://localhost:3030/jsonstore/forecaster/upcoming/${code}`;
                
                //Current conditions request
                fetch(currentConditionsUrl)
                    .then(response1 => response1.json())
                    .then(result1 => {
                        let forecastsDivElement = document.createElement('div');
                        forecastsDivElement.classList.add('forecasts');

                        let conditionSpanElement = document.createElement('span');
                        conditionSpanElement.classList.add('condition');

                        let symbolSpanElement = document.createElement('span');
                        symbolSpanElement.classList.add('condition');
                        symbolSpanElement.classList.add('symbol');

                        symbolSpanElement.textContent = symbols[result1.forecast.condition];

                        let townNameSpanElement = document.createElement('span');
                        townNameSpanElement.classList.add('forecast-data');
                        townNameSpanElement.textContent = result1.name;

                        let degreesSpanElement = document.createElement('span');
                        degreesSpanElement.classList.add('forecast-data');
                        degreesSpanElement.textContent = `${result1.forecast.low}°/${result1.forecast.high}°`

                        let conditionElement = document.createElement('span');
                        conditionElement.classList.add('forecast-data');
                        conditionElement.textContent = result1.forecast.condition;

                        conditionSpanElement.appendChild(townNameSpanElement);
                        conditionSpanElement.appendChild(degreesSpanElement);
                        conditionSpanElement.appendChild(conditionElement);

                        forecastsDivElement.appendChild(symbolSpanElement);
                        forecastsDivElement.appendChild(conditionSpanElement);

                        currentConditions.appendChild(forecastsDivElement);

                        //Upcoming conditions request
                        fetch(upcomingConditionsUrl)
                            .then(response2 => response2.json())
                            .then(result2 => {
                                let elementsToAppend = [];
                                let upcomingForecastsDivElement = document.createElement('div');
                                for (const weather of result2.forecast) {
                                    upcomingForecastsDivElement.classList.add('forecast-info');

                                    let upcomingSpanElement = document.createElement('span');
                                    upcomingSpanElement.classList.add('upcoming');

                                    let symbolSpanElement = document.createElement('span');
                                    symbolSpanElement.classList.add('symbol');

                                    symbolSpanElement.textContent = symbols[weather.condition];

                                    let degreesSpanElement = document.createElement('span');
                                    degreesSpanElement.classList.add('forecast-data');
                                    degreesSpanElement.textContent = `${weather.low}°/${weather.high}°`

                                    let conditionElement = document.createElement('span');
                                    conditionElement.classList.add('forecast-data');
                                    conditionElement.textContent = weather.condition;

                                    upcomingSpanElement.appendChild(symbolSpanElement);
                                    upcomingSpanElement.appendChild(degreesSpanElement);
                                    upcomingSpanElement.appendChild(conditionElement);

                                    upcomingForecastsDivElement.appendChild(upcomingSpanElement);

                                    elementsToAppend.push(upcomingSpanElement);
                                }

                                elementsToAppend.forEach(x => upcomingForecastsDivElement.appendChild(x));
                                upcomingConditions.appendChild(upcomingForecastsDivElement);

                            })
                            .catch(err => {
                                forecastElement.textContent = 'Error';
                            });
                    })
                    .catch(err => {
                        forecastElement.textContent = 'Error';
                    });

            })
            .catch(err => {
                forecastElement.textContent = 'Error';
            });
    });

}

attachEvents();